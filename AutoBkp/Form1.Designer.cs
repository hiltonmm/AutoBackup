namespace AutoBkp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notify_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_srv_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.logBox = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.file_read = new System.Windows.Forms.Label();
            this.net = new System.Diagnostics.Process();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.robocopy = new System.Diagnostics.Process();
            this.button3 = new System.Windows.Forms.Button();
            this.alert_CargaInicial = new System.Windows.Forms.Label();
            this.observador = new System.IO.FileSystemWatcher();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button4 = new System.Windows.Forms.Button();
            this.explorer = new System.Diagnostics.Process();
            this.notify_menu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.observador)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.notify_menu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Auto Backup";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // notify_menu
            // 
            this.notify_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.notify_menu.Name = "notify_menu";
            this.notify_menu.Size = new System.Drawing.Size(110, 48);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notificações:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lb_srv_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 416);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(105, 17);
            this.toolStripStatusLabel1.Text = "Status do Servidor:";
            // 
            // lb_srv_status
            // 
            this.lb_srv_status.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_srv_status.Name = "lb_srv_status";
            this.lb_srv_status.Size = new System.Drawing.Size(42, 17);
            this.lb_srv_status.Text = "Status";
            // 
            // logBox
            // 
            this.logBox.BackColor = System.Drawing.Color.White;
            this.logBox.Location = new System.Drawing.Point(23, 27);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logBox.Size = new System.Drawing.Size(755, 269);
            this.logBox.TabIndex = 3;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(23, 360);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(581, 33);
            this.progressBar.TabIndex = 4;
            // 
            // file_read
            // 
            this.file_read.AutoSize = true;
            this.file_read.Location = new System.Drawing.Point(23, 342);
            this.file_read.Name = "file_read";
            this.file_read.Size = new System.Drawing.Size(0, 15);
            this.file_read.TabIndex = 5;
            // 
            // net
            // 
            this.net.EnableRaisingEvents = true;
            this.net.StartInfo.CreateNoWindow = true;
            this.net.StartInfo.Domain = "";
            this.net.StartInfo.FileName = "net.exe";
            this.net.StartInfo.LoadUserProfile = false;
            this.net.StartInfo.Password = null;
            this.net.StartInfo.StandardErrorEncoding = null;
            this.net.StartInfo.StandardInputEncoding = null;
            this.net.StartInfo.StandardOutputEncoding = null;
            this.net.StartInfo.UserName = "";
            this.net.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            this.net.SynchronizingObject = this;
            this.net.Exited += new System.EventHandler(this.net_Exited);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(610, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Criar Uniade de Rede";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(610, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Deletar Unidade de Rede";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // robocopy
            // 
            this.robocopy.EnableRaisingEvents = true;
            this.robocopy.StartInfo.CreateNoWindow = true;
            this.robocopy.StartInfo.Domain = "";
            this.robocopy.StartInfo.FileName = "robocopy.exe";
            this.robocopy.StartInfo.LoadUserProfile = false;
            this.robocopy.StartInfo.Password = null;
            this.robocopy.StartInfo.RedirectStandardOutput = true;
            this.robocopy.StartInfo.StandardErrorEncoding = null;
            this.robocopy.StartInfo.StandardInputEncoding = null;
            this.robocopy.StartInfo.StandardOutputEncoding = null;
            this.robocopy.StartInfo.UserName = "";
            this.robocopy.SynchronizingObject = this;
            this.robocopy.OutputDataReceived += new System.Diagnostics.DataReceivedEventHandler(this.robocopy_OutputDataReceived);
            this.robocopy.Exited += new System.EventHandler(this.robocopy_Exited);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(610, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Executar Backup Manual";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // alert_CargaInicial
            // 
            this.alert_CargaInicial.AutoSize = true;
            this.alert_CargaInicial.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.alert_CargaInicial.ForeColor = System.Drawing.Color.Red;
            this.alert_CargaInicial.Location = new System.Drawing.Point(156, 312);
            this.alert_CargaInicial.Name = "alert_CargaInicial";
            this.alert_CargaInicial.Size = new System.Drawing.Size(315, 32);
            this.alert_CargaInicial.TabIndex = 9;
            this.alert_CargaInicial.Text = "Carga inicial não realizada";
            this.alert_CargaInicial.Visible = false;
            // 
            // observador
            // 
            this.observador.EnableRaisingEvents = true;
            this.observador.IncludeSubdirectories = true;
            this.observador.SynchronizingObject = this;
            this.observador.Changed += new System.IO.FileSystemEventHandler(this.observador_Changed);
            this.observador.Created += new System.IO.FileSystemEventHandler(this.observador_Created);
            this.observador.Deleted += new System.IO.FileSystemEventHandler(this.observador_Deleted);
            this.observador.Renamed += new System.IO.RenamedEventHandler(this.observador_Renamed);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(749, 5);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(37, 15);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sobre";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(610, 302);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Abrir Backup";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // explorer
            // 
            this.explorer.StartInfo.Domain = "";
            this.explorer.StartInfo.FileName = "explorer.exe";
            this.explorer.StartInfo.LoadUserProfile = false;
            this.explorer.StartInfo.Password = null;
            this.explorer.StartInfo.StandardErrorEncoding = null;
            this.explorer.StartInfo.StandardInputEncoding = null;
            this.explorer.StartInfo.StandardOutputEncoding = null;
            this.explorer.StartInfo.UserName = "";
            this.explorer.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 438);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.alert_CargaInicial);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.file_read);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Backup";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.notify_menu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.observador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NotifyIcon notifyIcon;
        private ContextMenuStrip notify_menu;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private Label label1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lb_srv_status;
        private TextBox logBox;
        private ProgressBar progressBar;
        private Label file_read;
        private System.Diagnostics.Process net;
        private Button button1;
        private Button button2;
        private System.Diagnostics.Process robocopy;
        private Button button3;
        private Label alert_CargaInicial;
        private FileSystemWatcher observador;
        private LinkLabel linkLabel1;
        private ToolStripMenuItem fecharToolStripMenuItem;
        private Button button4;
        private System.Diagnostics.Process explorer;
    }
}