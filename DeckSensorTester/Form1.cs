using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;

namespace DeckSensorTester
{
    public partial class Form1 : Form
    {
        int udpListenPort = 42507;
        int udpSendPort = 42007;
        int unitId = 7;
        string strIpAddress = "10.20.78.181";
        bool isListening = false;
        IPAddress dsIpAddress;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBoxIpAddress.Text = strIpAddress;
            txtBoxListenPort.Text = udpListenPort.ToString();
            txtBoxSendPort.Text = udpSendPort.ToString();
            txtBoxUnitId.Text = unitId.ToString();
            radioBtnPreset1.Checked = true;
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            strIpAddress = txtBoxIpAddress.Text;

            if (isListening)
            {
                isListening = false;
                btnListen.Text = "Start Listening";
                backgroundWorker1.CancelAsync();
                MessageBox.Show("Worker Stopping");
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

                    dsIpAddress = IPAddress.Parse(strIpAddress);

                    if (!backgroundWorker1.IsBusy)
                    {
                        isListening = true;
                        backgroundWorker1.RunWorkerAsync();
                        btnListen.Text = "Stop Listening";
                        MessageBox.Show("Worker Staring");
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

        private void parseReceivedData(byte[] dataReceived)
        {
            int dataLength = dataReceived.Length;
            int dataType = dataReceived[2]; // 0x65(Dec 101)=Preset | 0x6A(Dec 106)=Zone Status
            
            for (int i = 0; i < dataLength; i++)
            {
                int byteToSend = dataReceived[i];
                txtBoxRecveivedData.Text += byteToSend.ToString("X2") + " ";
            }
            
            txtBoxRecveivedData.Text += "\r\n";
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            UdpClient listener = new UdpClient(udpListenPort);
            IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, udpListenPort);

            while (isListening)
            {
                byte[] recvBytes = listener.Receive(ref groupEP);

                this.Invoke(new MethodInvoker(delegate { parseReceivedData(recvBytes); }));
            }

            listener.Close();
            MessageBox.Show("BW Listener Close");
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            isListening = false;
        }
    }
}
