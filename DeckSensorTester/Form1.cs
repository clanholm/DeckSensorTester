using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;

namespace DeckSensorTester
{
    public partial class Form1 : Form
    {
        int udpListenPort = 42507;
        int udpSendPort = 42071;
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

        //private void StartListener()
        //{
        //    UdpClient listener = new UdpClient(udpListenPort);
        //    IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, udpListenPort);

        //    try
        //    {
        //        while (true)
        //        {
        //            //Console.WriteLine("Waiting for broadcast");
        //            byte[] recvBytes = listener.Receive(ref groupEP);
        //            txtBoxRecveivedData.Text += Convert.ToHexString(recvBytes) + "\r\n";
        //            MessageBox.Show("Data Received");

        //            //Console.WriteLine($"Received broadcast from {groupEP} :");
        //            //Console.WriteLine($" {Encoding.ASCII.GetString(bytes, 0, bytes.Length)}");
        //        }
        //    }
        //    catch (SocketException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        listener.Close();
        //        MessageBox.Show("Listener Closed");
        //    }
        //}

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

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            UdpClient listener = new UdpClient(udpListenPort);
            IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, udpListenPort);

            while (isListening)
            {
                byte[] recvBytes = listener.Receive(ref groupEP);

                this.Invoke(new MethodInvoker(delegate { txtBoxRecveivedData.Text += Convert.ToHexString(recvBytes) + "\r\n"; }));

                //txtBoxReceivedData.Text += Convert.ToHexString(recvBytes) + "\r\n";                
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
