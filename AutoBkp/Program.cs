using System;
using System.Xml;

namespace AutoBkp
{
    internal static class Program
    {
        public static string ip;
        public static string username;
        public static string passwd;
        public static string drive;
        public static string directory;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            


            XmlDocument xmldoc = new XmlDocument();
            try
            {
                xmldoc.Load("config.xml");
                XmlNode config = xmldoc.SelectSingleNode("//config");

                ip = config["ip"].InnerText.ToString();
                username = config["username"].InnerText;
                passwd = config["passwd"].InnerText;
                drive = config["drive"].InnerText;
                directory = config["directory"].InnerText;

                Application.Run(new Form1());

            }
            catch
            {
                MessageBox.Show("ERRO !! CRÍTICO - Cód 01\n\n" +
                    "Não foi possivel carregar o arquivo de configurações.\n" +
                    "Contate o Desenvolvedor: hiltonmm@gmail.com\n\n" +
                    "O aplicativo será encerrado\n\n" +
                    "Seus aquivos estão em risco.", "ERRO CRÍTICO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }
    }
}