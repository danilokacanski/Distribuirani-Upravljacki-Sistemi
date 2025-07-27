using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Opc.Ua;
using Opc.Ua.Configuration;
using Opc.Ua.Server;
using static System.Net.Mime.MediaTypeNames;

namespace BatchPlantWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            try
            {
                ApplicationInstance application = new ApplicationInstance();
                application.ApplicationType = ApplicationType.Server;
                application.ConfigSectionName = "BatchPlantServer";
                application.LoadApplicationConfiguration("..\\..\\BatchPlantServer.Config.xml", false).Wait();
                application.CheckApplicationInstanceCertificate(false, 0).Wait();
                application.Start(new BatchPlantServer()).Wait();

                var m_application = application;
                var m_server = application.Server as StandardServer;
                var m_configuration = application.ApplicationConfiguration;

                cmbUrl.Items.Clear();
                foreach (var endpoint in m_server.GetEndpoints())
                {
                    cmbUrl.Items.Add(endpoint.EndpointUrl);
                }
                
            }   
            catch (Exception e)
            {
                string text = "Exception: " + e.Message;
                if (e.InnerException != null)
                {
                    text += "\r\nInner exception: ";
                    text += e.InnerException.Message;
                }
                MessageBox.Show(text);
            }
            if (cmbUrl.Items.Count > 0)
            {
                cmbUrl.SelectedIndex = 0;
            }
        }
    }
}
