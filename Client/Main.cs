using Services;
using System;
using System.ServiceModel;
using System.Windows.Forms;

namespace Client
{
    public partial class Main : Form
    {
        IMyService channel;
        public Main()
        {
            InitializeComponent();
            Uri address = new Uri("http://localhost:1111/IMyService");  // ADDRESS.   (A)
            BasicHttpBinding binding = new BasicHttpBinding();         // BINDING.   (B)
            EndpointAddress endpoint = new EndpointAddress(address);
            ChannelFactory<IMyService> factory = new ChannelFactory<IMyService>(binding, endpoint);  // CONTRACT.  (C) 
            channel = factory.CreateChannel();
        }
        private void CalcButton_Click(object sender, EventArgs e)
        {
            int x = int.Parse(firstNumberTextBox.Text);
            int y = int.Parse(secondNumberTextBox.Text);
            ResultLabel.Text = $"Result: {channel.Sum(x, y)}";
        }
    }
}
