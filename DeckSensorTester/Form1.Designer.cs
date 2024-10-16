namespace DeckSensorTester
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
            groupBoxCommSettings = new GroupBox();
            txtBoxUnitId = new TextBox();
            lblUnitId = new Label();
            btnListen = new Button();
            txtBoxSendPort = new TextBox();
            txtBoxListenPort = new TextBox();
            lblSendPort = new Label();
            lblListenPort = new Label();
            lblIpAddress = new Label();
            txtBoxIpAddress = new TextBox();
            groupBoxPresets = new GroupBox();
            radioBtnPreset4 = new RadioButton();
            radioBtnPreset3 = new RadioButton();
            radioBtnPreset2 = new RadioButton();
            radioBtnPreset1 = new RadioButton();
            txtBoxSentData = new TextBox();
            txtBoxReceivedData = new TextBox();
            lblSentData = new Label();
            lblReceivedData = new Label();
            grpBoxZoneStatus = new GroupBox();
            btnZoneStat6 = new Button();
            btnZoneStat5 = new Button();
            btnZoneStat4 = new Button();
            btnZoneStat3 = new Button();
            btnZoneStat2 = new Button();
            btnZoneStat1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnGetPresets = new Button();
            btnGetZoneStatus = new Button();
            btnClearSentData = new Button();
            btnClearReceivedData = new Button();
            label1 = new Label();
            label2 = new Label();
            groupBoxCommSettings.SuspendLayout();
            groupBoxPresets.SuspendLayout();
            grpBoxZoneStatus.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCommSettings
            // 
            groupBoxCommSettings.Controls.Add(txtBoxUnitId);
            groupBoxCommSettings.Controls.Add(lblUnitId);
            groupBoxCommSettings.Controls.Add(btnListen);
            groupBoxCommSettings.Controls.Add(txtBoxSendPort);
            groupBoxCommSettings.Controls.Add(txtBoxListenPort);
            groupBoxCommSettings.Controls.Add(lblSendPort);
            groupBoxCommSettings.Controls.Add(lblListenPort);
            groupBoxCommSettings.Controls.Add(lblIpAddress);
            groupBoxCommSettings.Controls.Add(txtBoxIpAddress);
            groupBoxCommSettings.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxCommSettings.Location = new Point(31, 26);
            groupBoxCommSettings.Name = "groupBoxCommSettings";
            groupBoxCommSettings.Size = new Size(333, 232);
            groupBoxCommSettings.TabIndex = 0;
            groupBoxCommSettings.TabStop = false;
            groupBoxCommSettings.Text = "Comm Settings";
            // 
            // txtBoxUnitId
            // 
            txtBoxUnitId.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxUnitId.Location = new Point(132, 145);
            txtBoxUnitId.Name = "txtBoxUnitId";
            txtBoxUnitId.Size = new Size(183, 26);
            txtBoxUnitId.TabIndex = 8;
            // 
            // lblUnitId
            // 
            lblUnitId.AutoSize = true;
            lblUnitId.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnitId.Location = new Point(68, 148);
            lblUnitId.Name = "lblUnitId";
            lblUnitId.Size = new Size(56, 19);
            lblUnitId.TabIndex = 7;
            lblUnitId.Text = "Unit ID";
            // 
            // btnListen
            // 
            btnListen.Location = new Point(16, 181);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(299, 45);
            btnListen.TabIndex = 6;
            btnListen.Text = "Start Listening";
            btnListen.UseVisualStyleBackColor = true;
            btnListen.Click += btnListen_Click;
            // 
            // txtBoxSendPort
            // 
            txtBoxSendPort.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSendPort.Location = new Point(132, 106);
            txtBoxSendPort.Name = "txtBoxSendPort";
            txtBoxSendPort.Size = new Size(183, 26);
            txtBoxSendPort.TabIndex = 5;
            txtBoxSendPort.TextChanged += txtBoxSendPort_TextChanged;
            // 
            // txtBoxListenPort
            // 
            txtBoxListenPort.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxListenPort.Location = new Point(132, 68);
            txtBoxListenPort.Name = "txtBoxListenPort";
            txtBoxListenPort.Size = new Size(183, 26);
            txtBoxListenPort.TabIndex = 4;
            txtBoxListenPort.TextChanged += txtBoxListenPort_TextChanged;
            // 
            // lblSendPort
            // 
            lblSendPort.AutoSize = true;
            lblSendPort.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSendPort.Location = new Point(16, 109);
            lblSendPort.Name = "lblSendPort";
            lblSendPort.Size = new Size(110, 19);
            lblSendPort.TabIndex = 3;
            lblSendPort.Text = "UDP Send Port";
            // 
            // lblListenPort
            // 
            lblListenPort.AutoSize = true;
            lblListenPort.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListenPort.Location = new Point(6, 71);
            lblListenPort.Name = "lblListenPort";
            lblListenPort.Size = new Size(120, 19);
            lblListenPort.TabIndex = 2;
            lblListenPort.Text = "UDP Port Listen:";
            // 
            // lblIpAddress
            // 
            lblIpAddress.AutoSize = true;
            lblIpAddress.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIpAddress.Location = new Point(42, 33);
            lblIpAddress.Name = "lblIpAddress";
            lblIpAddress.Size = new Size(84, 19);
            lblIpAddress.TabIndex = 1;
            lblIpAddress.Text = "IP Address:";
            // 
            // txtBoxIpAddress
            // 
            txtBoxIpAddress.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxIpAddress.Location = new Point(132, 30);
            txtBoxIpAddress.Name = "txtBoxIpAddress";
            txtBoxIpAddress.Size = new Size(183, 26);
            txtBoxIpAddress.TabIndex = 0;
            txtBoxIpAddress.TextChanged += txtBoxIpAddress_TextChanged;
            // 
            // groupBoxPresets
            // 
            groupBoxPresets.Controls.Add(radioBtnPreset4);
            groupBoxPresets.Controls.Add(radioBtnPreset3);
            groupBoxPresets.Controls.Add(radioBtnPreset2);
            groupBoxPresets.Controls.Add(radioBtnPreset1);
            groupBoxPresets.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxPresets.Location = new Point(389, 26);
            groupBoxPresets.Name = "groupBoxPresets";
            groupBoxPresets.Size = new Size(123, 232);
            groupBoxPresets.TabIndex = 1;
            groupBoxPresets.TabStop = false;
            groupBoxPresets.Text = "Presets";
            // 
            // radioBtnPreset4
            // 
            radioBtnPreset4.AutoSize = true;
            radioBtnPreset4.Location = new Point(14, 181);
            radioBtnPreset4.Name = "radioBtnPreset4";
            radioBtnPreset4.Size = new Size(94, 27);
            radioBtnPreset4.TabIndex = 3;
            radioBtnPreset4.TabStop = true;
            radioBtnPreset4.Text = "Preset 4";
            radioBtnPreset4.UseVisualStyleBackColor = true;
            radioBtnPreset4.CheckedChanged += radioBtnPreset4_CheckedChanged;
            // 
            // radioBtnPreset3
            // 
            radioBtnPreset3.AutoSize = true;
            radioBtnPreset3.Location = new Point(14, 131);
            radioBtnPreset3.Name = "radioBtnPreset3";
            radioBtnPreset3.Size = new Size(94, 27);
            radioBtnPreset3.TabIndex = 2;
            radioBtnPreset3.TabStop = true;
            radioBtnPreset3.Text = "Preset 3";
            radioBtnPreset3.UseVisualStyleBackColor = true;
            radioBtnPreset3.CheckedChanged += radioBtnPreset3_CheckedChanged;
            // 
            // radioBtnPreset2
            // 
            radioBtnPreset2.AutoSize = true;
            radioBtnPreset2.Location = new Point(14, 82);
            radioBtnPreset2.Name = "radioBtnPreset2";
            radioBtnPreset2.Size = new Size(94, 27);
            radioBtnPreset2.TabIndex = 1;
            radioBtnPreset2.TabStop = true;
            radioBtnPreset2.Text = "Preset 2";
            radioBtnPreset2.UseVisualStyleBackColor = true;
            radioBtnPreset2.CheckedChanged += radioBtnPreset2_CheckedChanged;
            // 
            // radioBtnPreset1
            // 
            radioBtnPreset1.AutoSize = true;
            radioBtnPreset1.Location = new Point(14, 36);
            radioBtnPreset1.Name = "radioBtnPreset1";
            radioBtnPreset1.Size = new Size(94, 27);
            radioBtnPreset1.TabIndex = 0;
            radioBtnPreset1.TabStop = true;
            radioBtnPreset1.Text = "Preset 1";
            radioBtnPreset1.UseVisualStyleBackColor = true;
            radioBtnPreset1.CheckedChanged += radioBtnPreset1_CheckedChanged;
            // 
            // txtBoxSentData
            // 
            txtBoxSentData.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSentData.Location = new Point(30, 364);
            txtBoxSentData.Multiline = true;
            txtBoxSentData.Name = "txtBoxSentData";
            txtBoxSentData.ReadOnly = true;
            txtBoxSentData.ScrollBars = ScrollBars.Vertical;
            txtBoxSentData.Size = new Size(761, 207);
            txtBoxSentData.TabIndex = 4;
            // 
            // txtBoxReceivedData
            // 
            txtBoxReceivedData.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxReceivedData.Location = new Point(30, 633);
            txtBoxReceivedData.Multiline = true;
            txtBoxReceivedData.Name = "txtBoxReceivedData";
            txtBoxReceivedData.ReadOnly = true;
            txtBoxReceivedData.ScrollBars = ScrollBars.Vertical;
            txtBoxReceivedData.Size = new Size(761, 207);
            txtBoxReceivedData.TabIndex = 5;
            // 
            // lblSentData
            // 
            lblSentData.AutoSize = true;
            lblSentData.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSentData.Location = new Point(340, 338);
            lblSentData.Name = "lblSentData";
            lblSentData.Size = new Size(141, 23);
            lblSentData.TabIndex = 6;
            lblSentData.Text = "Sent Data in Hex";
            // 
            // lblReceivedData
            // 
            lblReceivedData.AutoSize = true;
            lblReceivedData.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReceivedData.Location = new Point(319, 607);
            lblReceivedData.Name = "lblReceivedData";
            lblReceivedData.Size = new Size(178, 23);
            lblReceivedData.TabIndex = 7;
            lblReceivedData.Text = "Received Data in Hex";
            // 
            // grpBoxZoneStatus
            // 
            grpBoxZoneStatus.Controls.Add(btnZoneStat6);
            grpBoxZoneStatus.Controls.Add(btnZoneStat5);
            grpBoxZoneStatus.Controls.Add(btnZoneStat4);
            grpBoxZoneStatus.Controls.Add(btnZoneStat3);
            grpBoxZoneStatus.Controls.Add(btnZoneStat2);
            grpBoxZoneStatus.Controls.Add(btnZoneStat1);
            grpBoxZoneStatus.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBoxZoneStatus.Location = new Point(543, 26);
            grpBoxZoneStatus.Name = "grpBoxZoneStatus";
            grpBoxZoneStatus.Size = new Size(249, 232);
            grpBoxZoneStatus.TabIndex = 8;
            grpBoxZoneStatus.TabStop = false;
            grpBoxZoneStatus.Text = "Zone Status";
            // 
            // btnZoneStat6
            // 
            btnZoneStat6.BackColor = SystemColors.Control;
            btnZoneStat6.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnZoneStat6.Location = new Point(168, 131);
            btnZoneStat6.Name = "btnZoneStat6";
            btnZoneStat6.Size = new Size(75, 75);
            btnZoneStat6.TabIndex = 5;
            btnZoneStat6.Text = "6";
            btnZoneStat6.UseVisualStyleBackColor = false;
            // 
            // btnZoneStat5
            // 
            btnZoneStat5.BackColor = SystemColors.Control;
            btnZoneStat5.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnZoneStat5.Location = new Point(87, 131);
            btnZoneStat5.Name = "btnZoneStat5";
            btnZoneStat5.Size = new Size(75, 75);
            btnZoneStat5.TabIndex = 4;
            btnZoneStat5.Text = "5";
            btnZoneStat5.UseVisualStyleBackColor = false;
            // 
            // btnZoneStat4
            // 
            btnZoneStat4.BackColor = SystemColors.Control;
            btnZoneStat4.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnZoneStat4.Location = new Point(6, 131);
            btnZoneStat4.Name = "btnZoneStat4";
            btnZoneStat4.Size = new Size(75, 75);
            btnZoneStat4.TabIndex = 3;
            btnZoneStat4.Text = "4";
            btnZoneStat4.UseVisualStyleBackColor = false;
            // 
            // btnZoneStat3
            // 
            btnZoneStat3.BackColor = SystemColors.Control;
            btnZoneStat3.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnZoneStat3.Location = new Point(168, 50);
            btnZoneStat3.Name = "btnZoneStat3";
            btnZoneStat3.Size = new Size(75, 75);
            btnZoneStat3.TabIndex = 2;
            btnZoneStat3.Text = "3";
            btnZoneStat3.UseVisualStyleBackColor = false;
            // 
            // btnZoneStat2
            // 
            btnZoneStat2.BackColor = SystemColors.Control;
            btnZoneStat2.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnZoneStat2.Location = new Point(87, 50);
            btnZoneStat2.Name = "btnZoneStat2";
            btnZoneStat2.Size = new Size(75, 75);
            btnZoneStat2.TabIndex = 1;
            btnZoneStat2.Text = "2";
            btnZoneStat2.UseVisualStyleBackColor = false;
            // 
            // btnZoneStat1
            // 
            btnZoneStat1.BackColor = SystemColors.Control;
            btnZoneStat1.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnZoneStat1.Location = new Point(6, 50);
            btnZoneStat1.Name = "btnZoneStat1";
            btnZoneStat1.Size = new Size(75, 75);
            btnZoneStat1.TabIndex = 0;
            btnZoneStat1.Text = "1";
            btnZoneStat1.UseVisualStyleBackColor = false;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // btnGetPresets
            // 
            btnGetPresets.Enabled = false;
            btnGetPresets.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetPresets.Location = new Point(389, 266);
            btnGetPresets.Name = "btnGetPresets";
            btnGetPresets.Size = new Size(123, 40);
            btnGetPresets.TabIndex = 9;
            btnGetPresets.Text = "Query Presets";
            btnGetPresets.UseVisualStyleBackColor = true;
            btnGetPresets.Click += btnGetPresets_Click;
            // 
            // btnGetZoneStatus
            // 
            btnGetZoneStatus.Enabled = false;
            btnGetZoneStatus.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetZoneStatus.Location = new Point(543, 266);
            btnGetZoneStatus.Name = "btnGetZoneStatus";
            btnGetZoneStatus.Size = new Size(249, 40);
            btnGetZoneStatus.TabIndex = 10;
            btnGetZoneStatus.Text = "Query Zone Status";
            btnGetZoneStatus.UseVisualStyleBackColor = true;
            btnGetZoneStatus.Click += btnGetZoneStatus_Click;
            // 
            // btnClearSentData
            // 
            btnClearSentData.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearSentData.Location = new Point(30, 326);
            btnClearSentData.Name = "btnClearSentData";
            btnClearSentData.Size = new Size(135, 32);
            btnClearSentData.TabIndex = 11;
            btnClearSentData.Text = "Clear Sent Data";
            btnClearSentData.UseVisualStyleBackColor = true;
            btnClearSentData.Click += btnClearSentData_Click;
            // 
            // btnClearReceivedData
            // 
            btnClearReceivedData.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearReceivedData.Location = new Point(30, 595);
            btnClearReceivedData.Name = "btnClearReceivedData";
            btnClearReceivedData.Size = new Size(178, 32);
            btnClearReceivedData.TabIndex = 12;
            btnClearReceivedData.Text = "Clear Received Data";
            btnClearReceivedData.UseVisualStyleBackColor = true;
            btnClearReceivedData.Click += btnClearReceivedData_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 261);
            label1.Name = "label1";
            label1.Size = new Size(249, 15);
            label1.TabIndex = 13;
            label1.Text = "The UDP Listen Port is Deck Sensor Target Port";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 280);
            label2.Name = "label2";
            label2.Size = new Size(247, 15);
            label2.TabIndex = 14;
            label2.Text = "The UDP Send Port is Deck Sensor Listent Port";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 862);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClearReceivedData);
            Controls.Add(btnClearSentData);
            Controls.Add(btnGetZoneStatus);
            Controls.Add(btnGetPresets);
            Controls.Add(grpBoxZoneStatus);
            Controls.Add(lblReceivedData);
            Controls.Add(lblSentData);
            Controls.Add(txtBoxReceivedData);
            Controls.Add(txtBoxSentData);
            Controls.Add(groupBoxPresets);
            Controls.Add(groupBoxCommSettings);
            Name = "Form1";
            Text = "Deck Sensor Tester";
            Load += Form1_Load;
            groupBoxCommSettings.ResumeLayout(false);
            groupBoxCommSettings.PerformLayout();
            groupBoxPresets.ResumeLayout(false);
            groupBoxPresets.PerformLayout();
            grpBoxZoneStatus.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxCommSettings;
        private TextBox txtBoxIpAddress;
        private TextBox txtBoxSendPort;
        private TextBox txtBoxListenPort;
        private Label lblSendPort;
        private Label lblListenPort;
        private Label lblIpAddress;
        private Button btnListen;
        private GroupBox groupBoxPresets;
        private RadioButton radioBtnPreset1;
        private RadioButton radioBtnPreset4;
        private RadioButton radioBtnPreset3;
        private RadioButton radioBtnPreset2;
        private TextBox txtBoxSentData;
        private TextBox txtBoxReceivedData;
        private Label lblSentData;
        private Label lblReceivedData;
        private GroupBox grpBoxZoneStatus;
        private Button btnZoneStat3;
        private Button btnZoneStat2;
        private Button btnZoneStat1;
        private Button btnZoneStat6;
        private Button btnZoneStat5;
        private Button btnZoneStat4;
        private TextBox txtBoxUnitId;
        private Label lblUnitId;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnGetPresets;
        private Button btnGetZoneStatus;
        private Button btnClearSentData;
        private Button btnClearReceivedData;
        private Label label1;
        private Label label2;
    }
}
