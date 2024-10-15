using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
using System.Windows.Forms.VisualStyles;

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
        const int ALARM = 2;
        const int NORMAL = 1;
        const int TROUBLE = 99;
        int currentPreset = 0;
        UdpClient udpClient = new UdpClient();

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
                btnListen.BackColor = Color.LightGray;
                backgroundWorker1.CancelAsync();
                // MessageBox.Show("Worker Stopping");
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
                        btnListen.BackColor = Color.LightGreen;
                        // MessageBox.Show("Worker Staring");
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

            if (dataType == 106) // Zone Status
            {
                int id = dataReceived[5];
                int zoneNumber = dataReceived[11] + 1;
                int zoneStat = dataReceived[12];
                if (unitId == id)
                {
                    updateZoneStatus(zoneNumber, zoneStat);
                }
            }
            else if (dataType == 101) // Preset Status
            {
                currentPreset = dataReceived[3] + 1;

                switch (currentPreset)
                {
                    case 1:
                        radioBtnPreset1.Checked = true;
                        break;

                    case 2:
                        radioBtnPreset2.Checked = true;
                        break;

                    case 3:
                        radioBtnPreset3.Checked = true;
                        break;

                    case 4:
                        radioBtnPreset4.Checked = true;
                        break;

                    default:
                        break;
                }
            }
        }

        private void updateSentData(byte[] bytesSent)
        {
            int dataLength = bytesSent.Length;

            for (int i = 0; i < dataLength; i++)
            {
                int byteSent = bytesSent[i];
                txtBoxSentData.Text += byteSent.ToString("X2") + " ";
            }

            txtBoxSentData.Text += "\r\n";
        }

        private void updateZoneStatus(int zoneNumber, int zoneStatus)
        {
            switch (zoneNumber)
            {
                case 1:
                    if (zoneStatus == NORMAL)
                    {
                        btnZoneStat1.BackColor = Color.Green;
                    }
                    else if (zoneStatus == ALARM)
                    {
                        btnZoneStat1.BackColor = Color.Red;
                    }
                    else if (zoneStatus == TROUBLE)
                    {
                        btnZoneStat1.BackColor = Color.Violet;
                    }
                    break;

                case 2:
                    if (zoneStatus == NORMAL)
                    {
                        btnZoneStat2.BackColor = Color.Green;
                    }
                    else if (zoneStatus == ALARM)
                    {
                        btnZoneStat2.BackColor = Color.Red;
                    }
                    else if (zoneStatus == TROUBLE)
                    {
                        btnZoneStat2.BackColor = Color.Violet;
                    }
                    break;

                case 3:
                    if (zoneStatus == NORMAL)
                    {
                        btnZoneStat3.BackColor = Color.Green;
                    }
                    else if (zoneStatus == ALARM)
                    {
                        btnZoneStat3.BackColor = Color.Red;
                    }
                    else if (zoneStatus == TROUBLE)
                    {
                        btnZoneStat3.BackColor = Color.Violet;
                    }
                    break;

                case 4:
                    if (zoneStatus == NORMAL)
                    {
                        btnZoneStat4.BackColor = Color.Green;
                    }
                    else if (zoneStatus == ALARM)
                    {
                        btnZoneStat4.BackColor = Color.Red;
                    }
                    else if (zoneStatus == TROUBLE)
                    {
                        btnZoneStat4.BackColor = Color.Violet;
                    }
                    break;

                case 5:
                    if (zoneStatus == NORMAL)
                    {
                        btnZoneStat5.BackColor = Color.Green;
                    }
                    else if (zoneStatus == ALARM)
                    {
                        btnZoneStat5.BackColor = Color.Red;
                    }
                    else if (zoneStatus == TROUBLE)
                    {
                        btnZoneStat5.BackColor = Color.Violet;
                    }
                    break;

                case 6:
                    if (zoneStatus == NORMAL)
                    {
                        btnZoneStat6.BackColor = Color.Green;
                    }
                    else if (zoneStatus == ALARM)
                    {
                        btnZoneStat6.BackColor = Color.Red;
                    }
                    else if (zoneStatus == TROUBLE)
                    {
                        btnZoneStat6.BackColor = Color.Violet;
                    }
                    break;

                default:
                    break;
            }
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
            // MessageBox.Show("BW Listener Close");
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            isListening = false;
        }

        private void radioBtnPreset1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnPreset1.Checked && currentPreset != 1)
            {
                sendPreset(1);
            }
        }

        private void radioBtnPreset2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnPreset2.Checked && currentPreset != 2)
            {
                sendPreset(2);
            }
        }

        private void radioBtnPreset3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnPreset3.Checked && currentPreset != 3)
            {
                sendPreset(3);
            }
        }

        private void radioBtnPreset4_CheckedChanged(object sender, EventArgs e)
        {
            if(radioBtnPreset4.Checked && currentPreset != 4)
            {
                sendPreset(4);
            }
        }

        private void sendPreset(int presetToSend)
        {
            Byte[] dataToSend = { 0x54, 0x66, 0x64, 0x00 };
            int byteLength = 4;

            currentPreset = presetToSend;

            switch (presetToSend)
            {
                case 1:
                    dataToSend[3] = 0x00;
                    udpClient.Send(dataToSend, byteLength, strIpAddress, udpSendPort);
                    updateSentData(dataToSend);
                    radioBtnPreset1.Checked = true;
                    
                    break;

                case 2:
                    dataToSend[3] = 0x01;
                    udpClient.Send(dataToSend, byteLength, strIpAddress, udpSendPort);
                    updateSentData(dataToSend);
                    radioBtnPreset2.Checked = true;
                    break;

                case 3:
                    dataToSend[3] = 0x02;
                    udpClient.Send(dataToSend, byteLength, strIpAddress, udpSendPort);
                    updateSentData(dataToSend);
                    radioBtnPreset3.Checked = true;
                    break;

                case 4:
                    dataToSend[3] = 0x03;
                    udpClient.Send(dataToSend, byteLength, strIpAddress, udpSendPort);
                    updateSentData(dataToSend);
                    radioBtnPreset4.Checked = true;
                    break;

                default:
                    break;
            }
        }
    }
}
