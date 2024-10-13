namespace DeckSensorTester
{
    public partial class Form1 : Form
    {
        int udpListenPort = 41001;
        int udpSendPort = 41501;
        string ipAddress = "192.168.1.100";
        bool isListening = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBoxIpAddress.Text = ipAddress;
            txtBoxListenPort.Text = udpListenPort.ToString();
            txtBoxSendPort.Text = udpSendPort.ToString();
            radioBtnPreset1.Checked = true;
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            ipAddress = txtBoxIpAddress.Text;

            if (isListening)
            {
                isListening = false;
            }

            else
            {
                try
                {
                    udpListenPort = int.Parse(txtBoxListenPort.Text);
                    udpSendPort = int.Parse(txtBoxSendPort.Text);
                    if (udpListenPort < 1 || udpListenPort > 65535)
                    {
                        MessageBox.Show("Listen Port Value must be between 1 an 65535");
                    }

                    if (udpSendPort < 1 || udpSendPort > 65535)
                    {
                        MessageBox.Show("Send Port Value must be between 1 an 65535");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtBoxIpAddress_TextChanged(object sender, EventArgs e)
        {
            // ipAddress = txtBoxIpAddress.Text;
        }

        private void txtBoxListenPort_TextChanged(object sender, EventArgs e)
        {
            // udpListenPort = int.Parse(txtBoxListenPort.Text);
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBoxListenPort.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtBoxListenPort.Text = txtBoxListenPort.Text.Remove(txtBoxListenPort.Text.Length - 1);
            }
        }

        private void txtBoxSendPort_TextChanged(object sender, EventArgs e)
        {
            // udpSendPort = int.Parse(txtBoxSendPort.Text);
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBoxSendPort.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtBoxSendPort.Text = txtBoxSendPort.Text.Remove(txtBoxSendPort.Text.Length - 1);
            }
        }
    }
}
