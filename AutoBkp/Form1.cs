using System.Net.NetworkInformation;
using System.Threading;
using System.Collections;
namespace AutoBkp
{
    public partial class Form1 : Form
    {
        public string netProcDesc;
        public bool robocopyExec = false;
        public List<int> filaExecucao = new List<int>();
       
        
        public Form1()
        {
            InitializeComponent();
            iniciar_observador();


        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

      
        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            log("Sistema iniciado");
            log("Testando conexão com o servidor");
            if (srvStatus()) { 
                log("Servidor onlne");
            } else
            {
                log("Servidor offline");
    
            }
            if (!statusDrive())
            {
                log("Criando Unidade de Rede");
                netCriar();
                Thread.Sleep(1000);
                    if (!statusDrive())
                    {
                        log("Unidade de Rede Indisponivel");
                    }                
            } else
            {
                log("Unidade de Rede disponivel");
                

                if (!verificarCargaInicial())
                {
                    alert_CargaInicial.Visible = true;

                    var ret = MessageBox.Show("Atenção:\n" +
                        "É necessario realizar uma carga inicial do seu backup.\n\n" +
                        "Deseja realizar a carga inicial agora ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (ret == DialogResult.Yes)
                    {
                        sync(1);
                        sync(2);
                        sync(3);
                        log("Realizando Carga Inicial");
                        alert_CargaInicial.Visible = false;
                        
                    }
                    else
                    {
                        ret = MessageBox.Show("Atenção!\n" +
                            "Você optou por não realizar a carga inicial agora. \n\n" +
                            "O sistema não ira realizar nenhum backup automatico até a realização da carga inicial.\n\n" +
                            "Deseja mudar de ideia e ralizar a carga inicial agora ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if(ret == DialogResult.Yes)
                        {
                            sync(1);
                            sync(2);
                            sync(3);
                            log("Realizando carga inicial");
                            alert_CargaInicial.Visible = false;
                        
                        } else
                        {
                            return;
                        }
                    }

                }
            }

        }

        private void iniciar_observador()
        {
            observador.Path = "C:\\";
            observador.Filter = "*";
            log("Observador Iniciado");

        }
        private bool verificarCargaInicial()
        {
            if (Directory.Exists(Program.drive + ":\\Users\\" + Environment.UserName))
            {
                return true;
            } else
            {
                return false;
            }
        }

     
        private bool srvStatus()
        {
            Ping ping = new Ping();
            if(ping.Send(Program.ip).Status == IPStatus.Success)
            {
                this.lb_srv_status.Text = "Online";
                this.lb_srv_status.ForeColor = Color.Green;
                return true;
            } else
            {
                this.lb_srv_status.Text = "Offline";
                this.lb_srv_status.ForeColor = Color.Red;
                return true;
            }
        }
        private void log(string txt)
        {
            this.logBox.AppendText(txt);
            this.logBox.AppendText(Environment.NewLine);
           
        }

        private void net_Exited(object sender, EventArgs e)
        {
            net.Close();
            log(this.netProcDesc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            netCriar();
        }
        private void netCriar()
        {
            this.netProcDesc = "Unidade de Rede "+ Program.drive.ToUpper()+": Criada";
            net.StartInfo.Arguments = "use "+Program.drive.ToUpper()+@": \\"+Program.ip+"\\"+Program.directory+" /user:"+Program.username+" "+Program.passwd;
            net.Start();
        }
        private void netDeletar()
        {
            this.netProcDesc = "Unidade de Rede "+ Program.drive.ToUpper()+": Deletada";
            net.StartInfo.Arguments = @"use "+ Program.drive.ToUpper()+": /DELETE /Y";
            net.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            netDeletar();
        }

        private bool statusDrive()
        {
            if (Directory.Exists(Program.drive+":"))
            {
                return true;
            } else
            {
                return false;
            }
        }

        private void robocopy_Exited(object sender, EventArgs e)
        {
            robocopy.CancelOutputRead();
            robocopy.Close();
            robocopyExec = false;
            log("Sincronismo executado");
            file_read.Text = "";
            if (filaExecucao.Count > 0)
            {
                executaFila();
            }

        }


        private void executaFila()
        {
            if (filaExecucao.Count > 0)
            {
                sync(filaExecucao[0]);
                filaExecucao.RemoveAt(0);
                log("Executando fila");
            } else
            {
                log("Sem fila para execução");
            }

        }

      


        private void robocopy_OutputDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            
            string data = e.Data;
            string[] part;
            string arquivo = "";
            int per = 0;
            if (data is not null)
            {
                if (data.Length > 0)
                {
                    part = data.Split("%");
                    //log(part[0].Length.ToString() + " - " + part[0]);
                    if (part[0].Length <= 6)
                    {
                        try
                        {
                            per = Convert.ToInt32(part[0]);
                        } catch {
                            per = Convert.ToInt32(part[0].Split('.')[0]);
                        }
                    } else
                    {
                        arquivo = part[0].ToString().Trim();
                        if(part.Length == 2)
                        {
                            arquivo = part[1].Trim();
                        }
                    }
                }
                progressBar.Value = per;
                if(arquivo != "")
                {
                    file_read.Text = arquivo;
                    log(arquivo);
                }
                
            }
        }
        private void sync(int tipo)
        {
            if (statusDrive())
            {
                if (!robocopyExec)
                {
                    string patch = "";
                    switch (tipo)
                    {
                        case 1:
                            patch = "C:\\Users\\"+Environment.UserName+"\\Desktop "+Program.drive+":\\Users\\"+Environment.UserName+"\\Desktop /njh /njs /ndl /nc /tee /ns /MIR";
                            break;
                        case 2:
                            patch = "C:\\Users\\"+Environment.UserName+"\\Documents "+Program.drive+":\\Users\\"+Environment.UserName+"\\Documents /njh /njs /ndl /nc /tee /ns /MIR /R:0";
                            break;
                        case 3:
                            patch = "C:\\Users\\"+Environment.UserName+"\\Pictures "+Program.drive+":\\Users\\"+Environment.UserName+"\\Pictures /njh /njs /ndl /nc /tee /ns /MIR";
                            break;
                    }

                    robocopy.StartInfo.Arguments = patch;
                    robocopy.Start();
                    robocopy.BeginOutputReadLine();
                    robocopyExec = true;
                }
                else
                {


                    log("RoboCopy em execução, incluindo processo na fila");
                    filaExecucao.Add(tipo);
                }
            } else
            {
                log("Unidade de Rede Indisponivel, tentando reconectar");
                filaExecucao.Add(tipo);
                netCriar();
                Thread.Sleep(1000);
                executaFila();                    
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            sync(1);
            sync(2);
            sync(3);
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            executaFila();
        }

        private void observador_Changed(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }
            backup(e.FullPath);
            
        }

        private void observador_Created(object sender, FileSystemEventArgs e)
        {
            backup(e.FullPath);
        }

        private void observador_Renamed(object sender, RenamedEventArgs e)
        {
            backup(e.FullPath);
        }

        private void backup(string patch)
        {
            

            if (patch.Contains("C:\\Users\\"+Environment.UserName+"\\Desktop\\")){
                sync(1);
            } else if (patch.Contains("C:\\Users\\"+Environment.UserName+"\\Documents\\")){
                sync(2);
            } else if (patch.Contains("C:\\Users\\"+Environment.UserName+"\\Pictures\\")){
                sync(3);
            }

            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sobre sobre = new sobre();
            sobre.ShowDialog();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ret = MessageBox.Show("Deseja realmente fechar a aplicação?\n\n" +
                "Essa ação deixará os seus arquvios em risco.", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(ret == DialogResult.Yes)
            {
                Application.Exit(); 
            } 
        }

        private void observador_Deleted(object sender, FileSystemEventArgs e)
        {
            backup(e.FullPath);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            netCriar();
            explorer.StartInfo.Arguments = Program.drive+":\\Users\\"+Environment.UserName;


            var ret = MessageBox.Show("Você está prestes a acessar os seus arquivos de backup.\n" +
                "CUIDADO, qualquer alteração poderá resultar em perdada de dados, prossiga somente se tiver ABSOLUTA certeza do que está fazendo.\n\n" +
                "TEM CERTEZA ?", "ATENÇÂO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if( ret == DialogResult.Yes)
            {
                ret = MessageBox.Show("TEM CERTEZA?", "ATENÇÂO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if( (ret == DialogResult.Yes))
                {
                    explorer.Start();
                }
            }           
           
        }
    }
}