using Services;
using System;
using System.ServiceModel;
using System.Windows.Forms;

namespace Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public partial class Main : Form, IMyService
    {
        ServiceHost host;
        public Main() => InitializeComponent();
        public int Sum(int first, int second) => first + second;
        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                Uri address = new Uri("http://localhost:1111/IMyService"); // ADDRESS.    (A)
                BasicHttpBinding binding = new BasicHttpBinding();        // BINDING.    (B)
                Type contract = typeof(IMyService);                       // CONTRACT.   (C) 
                host = new ServiceHost(this);
                host.AddServiceEndpoint(contract, binding, address);
                host.Open();
                StartButton.Enabled = false;
                StopButton.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            host.Close();
            StartButton.Enabled = true;
            StopButton.Enabled = false;
        }
    }
}
