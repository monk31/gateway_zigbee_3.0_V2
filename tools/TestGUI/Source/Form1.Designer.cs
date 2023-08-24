namespace ZGWUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripPortSettings = new System.Windows.Forms.ToolStripStatusLabel();
            this.lampe_hue = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxPollInterval = new System.Windows.Forms.TextBox();
            this.buttonPollInterval = new System.Windows.Forms.Button();
            this.buttonNWKState = new System.Windows.Forms.Button();
            this.buttonDiscoveryOnly = new System.Windows.Forms.Button();
            this.textBoxBindTargetExtAddr = new System.Windows.Forms.TextBox();
            this.textBoxUserSetReqDescription = new System.Windows.Forms.TextBox();
            this.textBoxUserSetReqAddr = new System.Windows.Forms.TextBox();
            this.buttonUserSetReq = new System.Windows.Forms.Button();
            this.textBoxUserReqAddr = new System.Windows.Forms.TextBox();
            this.buttonUserReq = new System.Windows.Forms.Button();
            this.textBoxRestoreNwkFrameCounter = new System.Windows.Forms.TextBox();
            this.comboBoxLeaveChildren = new System.Windows.Forms.ComboBox();
            this.comboBoxLeaveReJoin = new System.Windows.Forms.ComboBox();
            this.textBoxLeaveAddr = new System.Windows.Forms.TextBox();
            this.buttonLeave = new System.Windows.Forms.Button();
            this.textBoxRemoveChildAddr = new System.Windows.Forms.TextBox();
            this.textBoxRemoveParentAddr = new System.Windows.Forms.TextBox();
            this.buttonRemoveDevice = new System.Windows.Forms.Button();
            this.buttonPermitJoinState = new System.Windows.Forms.Button();
            this.buttonRestoreNwk = new System.Windows.Forms.Button();
            this.buttonRecoverNwk = new System.Windows.Forms.Button();
            this.comboBoxMgmtLeaveChildren = new System.Windows.Forms.ComboBox();
            this.comboBoxMgmtLeaveReJoin = new System.Windows.Forms.ComboBox();
            this.textBoxMgmtLeaveExtAddr = new System.Windows.Forms.TextBox();
            this.textBoxMgmtLeaveAddr = new System.Windows.Forms.TextBox();
            this.buttonMgmtLeave = new System.Windows.Forms.Button();
            this.textBoxUnBindDestEP = new System.Windows.Forms.TextBox();
            this.textBoxUnBindDestAddr = new System.Windows.Forms.TextBox();
            this.comboBoxUnBindAddrMode = new System.Windows.Forms.ComboBox();
            this.textBoxUnBindClusterID = new System.Windows.Forms.TextBox();
            this.textBoxUnBindTargetEP = new System.Windows.Forms.TextBox();
            this.textBoxUnBindTargetExtAddr = new System.Windows.Forms.TextBox();
            this.buttonUnBind = new System.Windows.Forms.Button();
            this.textBoxBindDestEP = new System.Windows.Forms.TextBox();
            this.textBoxBindDestAddr = new System.Windows.Forms.TextBox();
            this.comboBoxBindAddrMode = new System.Windows.Forms.ComboBox();
            this.textBoxBindClusterID = new System.Windows.Forms.TextBox();
            this.textBoxBindTargetEP = new System.Windows.Forms.TextBox();
            this.textBoxLqiReqStartIndex = new System.Windows.Forms.TextBox();
            this.textBoxLqiReqTargetAddr = new System.Windows.Forms.TextBox();
            this.buttonMgmtLqiReq = new System.Windows.Forms.Button();
            this.buttonStartScan = new System.Windows.Forms.Button();
            this.textBoxNwkAddrReqStartIndex = new System.Windows.Forms.TextBox();
            this.comboBoxNwkAddrReqType = new System.Windows.Forms.ComboBox();
            this.textBoxNwkAddrReqExtAddr = new System.Windows.Forms.TextBox();
            this.textBoxNwkAddrReqTargetAddr = new System.Windows.Forms.TextBox();
            this.textBoxIeeeReqStartIndex = new System.Windows.Forms.TextBox();
            this.comboBoxIeeeReqType = new System.Windows.Forms.ComboBox();
            this.textBoxIeeeReqAddr = new System.Windows.Forms.TextBox();
            this.textBoxIeeeReqTargetAddr = new System.Windows.Forms.TextBox();
            this.textBoxComplexReqAddr = new System.Windows.Forms.TextBox();
            this.buttonComplexReq = new System.Windows.Forms.Button();
            this.textBoxMatchReqOutputClusters = new System.Windows.Forms.TextBox();
            this.textBoxMatchReqInputClusters = new System.Windows.Forms.TextBox();
            this.textBoxMatchReqProfileID = new System.Windows.Forms.TextBox();
            this.textBoxMatchReqNbrOutputClusters = new System.Windows.Forms.TextBox();
            this.textBoxMatchReqNbrInputClusters = new System.Windows.Forms.TextBox();
            this.textBoxMatchReqAddr = new System.Windows.Forms.TextBox();
            this.textBoxActiveEpAddr = new System.Windows.Forms.TextBox();
            this.textBoxPowerReqAddr = new System.Windows.Forms.TextBox();
            this.textBoxSimpleReqEndPoint = new System.Windows.Forms.TextBox();
            this.textBoxSimpleReqAddr = new System.Windows.Forms.TextBox();
            this.buttonMatchReq = new System.Windows.Forms.Button();
            this.buttonActiveEpReq = new System.Windows.Forms.Button();
            this.buttonPowerDescReq = new System.Windows.Forms.Button();
            this.buttonSimpleDescReq = new System.Windows.Forms.Button();
            this.textBoxNodeDescReq = new System.Windows.Forms.TextBox();
            this.buttonNodeDescReq = new System.Windows.Forms.Button();
            this.buttonIeeeAddrReq = new System.Windows.Forms.Button();
            this.buttonNwkAddrReq = new System.Windows.Forms.Button();
            this.comboBoxSecurityKey = new System.Windows.Forms.ComboBox();
            this.comboBoxPermitJoinTCsignificance = new System.Windows.Forms.ComboBox();
            this.textBoxPermitJoinInterval = new System.Windows.Forms.TextBox();
            this.textBoxPermitJoinAddr = new System.Windows.Forms.TextBox();
            this.buttonPermitJoin = new System.Windows.Forms.Button();
            this.comboBoxSetKeyType = new System.Windows.Forms.ComboBox();
            this.comboBoxSetKeyState = new System.Windows.Forms.ComboBox();
            this.comboBoxSetType = new System.Windows.Forms.ComboBox();
            this.buttonStartNWK = new System.Windows.Forms.Button();
            this.buttonBind = new System.Windows.Forms.Button();
            this.buttonErasePD = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.textBoxSetSecurityKeySeqNbr = new System.Windows.Forms.TextBox();
            this.buttonSetDeviceType = new System.Windows.Forms.Button();
            this.buttonSetSecurity = new System.Windows.Forms.Button();
            this.textBoxSetEPID = new System.Windows.Forms.TextBox();
            this.textBoxSetCMSK = new System.Windows.Forms.TextBox();
            this.buttonSetCMSK = new System.Windows.Forms.Button();
            this.buttonSetEPID = new System.Windows.Forms.Button();
            this.buttonGetVersion = new System.Windows.Forms.Button();
            this.tabPageDevice = new System.Windows.Forms.TabPage();
            this.buttonCopyAddr = new System.Windows.Forms.Button();
            this.buttonDiscoverDevices = new System.Windows.Forms.Button();
            this.textBoxExtAddr = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBoxAddressList = new System.Windows.Forms.ComboBox();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.textBoxOOBDataKey = new System.Windows.Forms.TextBox();
            this.textBoxOOBDataAddr = new System.Windows.Forms.TextBox();
            this.buttonOOBCommissioningData = new System.Windows.Forms.Button();
            this.textBoxDiscoverAttributesStartAttrId = new System.Windows.Forms.TextBox();
            this.textBoxRawDataCommandsProfileID = new System.Windows.Forms.TextBox();
            this.textBoxRawDataCommandsSecurityMode = new System.Windows.Forms.TextBox();
            this.textBoxRawDataCommandsRadius = new System.Windows.Forms.TextBox();
            this.textBoxRawDataCommandsData = new System.Windows.Forms.TextBox();
            this.textBoxRawDataCommandsClusterID = new System.Windows.Forms.TextBox();
            this.textBoxRawDataCommandsDstEP = new System.Windows.Forms.TextBox();
            this.textBoxRawDataCommandsSrcEP = new System.Windows.Forms.TextBox();
            this.textBoxRawDataCommandsTargetAddr = new System.Windows.Forms.TextBox();
            this.comboBoxRawDataCommandsAddrMode = new System.Windows.Forms.ComboBox();
            this.buttonRawDataSend = new System.Windows.Forms.Button();
            this.textBoxMgmtNwkUpdateNwkManagerAddr = new System.Windows.Forms.TextBox();
            this.comboBoxDiscoverCommandsRxGen = new System.Windows.Forms.ComboBox();
            this.comboBoxDiscoverAttributesExtended = new System.Windows.Forms.ComboBox();
            this.textBoxDiscoverCommandsMaxCommands = new System.Windows.Forms.TextBox();
            this.textBoxDiscoverCommandsManuID = new System.Windows.Forms.TextBox();
            this.comboBoxDiscoverCommandsManuSpecific = new System.Windows.Forms.ComboBox();
            this.textBoxDiscoverCommandsCommandID = new System.Windows.Forms.TextBox();
            this.comboBoxDiscoverCommandsDirection = new System.Windows.Forms.ComboBox();
            this.textBoxDiscoverCommandsClusterID = new System.Windows.Forms.TextBox();
            this.textBoxDiscoverCommandsDstEP = new System.Windows.Forms.TextBox();
            this.textBoxDiscoverCommandsSrcEP = new System.Windows.Forms.TextBox();
            this.textBoxDiscoverCommandsTargetAddr = new System.Windows.Forms.TextBox();
            this.comboBoxDiscoverCommandsAddrMode = new System.Windows.Forms.ComboBox();
            this.buttonDiscoverCommands = new System.Windows.Forms.Button();
            this.textBoxMgmtNwkUpdateScanCount = new System.Windows.Forms.TextBox();
            this.textBoxMgmtNwkUpdateScanDuration = new System.Windows.Forms.TextBox();
            this.textBoxMgmtNwkUpdateChannelMask = new System.Windows.Forms.TextBox();
            this.textBoxMgmtNwkUpdateTargetAddr = new System.Windows.Forms.TextBox();
            this.comboBoxMgmtNwkUpdateAddrMode = new System.Windows.Forms.ComboBox();
            this.buttonMgmtNwkUpdate = new System.Windows.Forms.Button();
            this.comboBoxManyToOneRouteRequestCacheRoute = new System.Windows.Forms.ComboBox();
            this.textBoxManyToOneRouteRequesRadius = new System.Windows.Forms.TextBox();
            this.buttonManyToOneRouteRequest = new System.Windows.Forms.Button();
            this.comboBoxReadReportConfigDirection = new System.Windows.Forms.ComboBox();
            this.comboBoxReadReportConfigDirIsRx = new System.Windows.Forms.ComboBox();
            this.textBoxReadReportConfigAttribID = new System.Windows.Forms.TextBox();
            this.textBoxReadReportConfigClusterID = new System.Windows.Forms.TextBox();
            this.textBoxReadReportConfigDstEP = new System.Windows.Forms.TextBox();
            this.textBoxReadReportConfigSrcEP = new System.Windows.Forms.TextBox();
            this.textBoxReadReportConfigTargetAddr = new System.Windows.Forms.TextBox();
            this.comboBoxReadReportConfigAddrMode = new System.Windows.Forms.ComboBox();
            this.buttonReadReportConfig = new System.Windows.Forms.Button();
            this.textBoxWriteAttribManuID = new System.Windows.Forms.TextBox();
            this.comboBoxWriteAttribManuSpecific = new System.Windows.Forms.ComboBox();
            this.textBoxWriteAttribDataType = new System.Windows.Forms.TextBox();
            this.textBoxReadAttribManuID = new System.Windows.Forms.TextBox();
            this.comboBoxReadAttribManuSpecific = new System.Windows.Forms.ComboBox();
            this.comboBoxConfigReportAddrMode = new System.Windows.Forms.ComboBox();
            this.textBoxWriteAttribData = new System.Windows.Forms.TextBox();
            this.textBoxWriteAttribID = new System.Windows.Forms.TextBox();
            this.comboBoxWriteAttribDirection = new System.Windows.Forms.ComboBox();
            this.textBoxWriteAttribClusterID = new System.Windows.Forms.TextBox();
            this.textBoxWriteAttribDstEP = new System.Windows.Forms.TextBox();
            this.textBoxWriteAttribSrcEP = new System.Windows.Forms.TextBox();
            this.textBoxWriteAttribTargetAddr = new System.Windows.Forms.TextBox();
            this.textBoxConfigReportChange = new System.Windows.Forms.TextBox();
            this.textBoxConfigReportTimeOut = new System.Windows.Forms.TextBox();
            this.textBoxConfigReportMaxInterval = new System.Windows.Forms.TextBox();
            this.textBoxDiscoverAttributesMaxIDs = new System.Windows.Forms.TextBox();
            this.comboBoxDiscoverAttributesDirection = new System.Windows.Forms.ComboBox();
            this.textBoxDiscoverAttributesClusterID = new System.Windows.Forms.TextBox();
            this.textBoxDiscoverAttributesDstEp = new System.Windows.Forms.TextBox();
            this.textBoxDiscoverAttributesSrcEp = new System.Windows.Forms.TextBox();
            this.textBoxDiscoverAttributesAddr = new System.Windows.Forms.TextBox();
            this.buttonDiscoverAttributes = new System.Windows.Forms.Button();
            this.comboBoxReadAllAttribDirection = new System.Windows.Forms.ComboBox();
            this.textBoxReadAllAttribClusterID = new System.Windows.Forms.TextBox();
            this.textBoxReadAllAttribDstEP = new System.Windows.Forms.TextBox();
            this.textBoxReadAllAttribSrcEP = new System.Windows.Forms.TextBox();
            this.textBoxReadAllAttribAddr = new System.Windows.Forms.TextBox();
            this.buttonReadAllAttrib = new System.Windows.Forms.Button();
            this.comboBoxConfigReportAttribDirection = new System.Windows.Forms.ComboBox();
            this.textBoxConfigReportAttribType = new System.Windows.Forms.TextBox();
            this.textBoxConfigReportMinInterval = new System.Windows.Forms.TextBox();
            this.textBoxConfigReportAttribID = new System.Windows.Forms.TextBox();
            this.comboBoxConfigReportDirection = new System.Windows.Forms.ComboBox();
            this.textBoxConfigReportClusterID = new System.Windows.Forms.TextBox();
            this.textBoxConfigReportDstEP = new System.Windows.Forms.TextBox();
            this.textBoxConfigReportSrcEP = new System.Windows.Forms.TextBox();
            this.textBoxConfigReportTargetAddr = new System.Windows.Forms.TextBox();
            this.buttonConfigReport = new System.Windows.Forms.Button();
            this.buttonWriteAttrib = new System.Windows.Forms.Button();
            this.textBoxReadAttribCount = new System.Windows.Forms.TextBox();
            this.comboBoxReadAttribDirection = new System.Windows.Forms.ComboBox();
            this.textBoxReadAttribID1 = new System.Windows.Forms.TextBox();
            this.textBoxReadAttribClusterID = new System.Windows.Forms.TextBox();
            this.textBoxReadAttribDstEP = new System.Windows.Forms.TextBox();
            this.textBoxReadAttribSrcEP = new System.Windows.Forms.TextBox();
            this.textBoxReadAttribTargetAddr = new System.Windows.Forms.TextBox();
            this.buttonReadAttrib = new System.Windows.Forms.Button();
            this.Temperature = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.tension = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.count_mess_xiaomi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.humidity_xiaomi = new System.Windows.Forms.TextBox();
            this.temperature_xiaomi = new System.Windows.Forms.TextBox();
            this.smart_plug = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_direction = new System.Windows.Forms.ComboBox();
            this.state = new System.Windows.Forms.RadioButton();
            this.conso_smart = new System.Windows.Forms.Button();
            this.conso = new System.Windows.Forms.TextBox();
            this.power_socket = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonMessageViewClear = new System.Windows.Forms.Button();
            this.buttonClearRaw = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxMessageView = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxCommandResponse = new System.Windows.Forms.RichTextBox();
            this.openOtaFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTipGeneralTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxDebug = new System.Windows.Forms.CheckBox();
            this.lamp_osram = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.lampe_hue.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPageDevice.SuspendLayout();
            this.tabPage12.SuspendLayout();
            this.Temperature.SuspendLayout();
            this.smart_plug.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.openPortToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1027, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // openPortToolStripMenuItem
            // 
            this.openPortToolStripMenuItem.Name = "openPortToolStripMenuItem";
            this.openPortToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.openPortToolStripMenuItem.Text = "Open Port";
            this.openPortToolStripMenuItem.Click += new System.EventHandler(this.openPortToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusPort,
            this.toolStripPortSettings});
            this.statusStrip.Location = new System.Drawing.Point(0, 727);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 15, 0);
            this.statusStrip.Size = new System.Drawing.Size(1027, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusPort
            // 
            this.toolStripStatusPort.Name = "toolStripStatusPort";
            this.toolStripStatusPort.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripPortSettings
            // 
            this.toolStripPortSettings.Name = "toolStripPortSettings";
            this.toolStripPortSettings.Size = new System.Drawing.Size(0, 17);
            // 
            // lampe_hue
            // 
            this.lampe_hue.Controls.Add(this.tabPage2);
            this.lampe_hue.Controls.Add(this.tabPageDevice);
            this.lampe_hue.Controls.Add(this.tabPage12);
            this.lampe_hue.Controls.Add(this.Temperature);
            this.lampe_hue.Controls.Add(this.smart_plug);
            this.lampe_hue.Controls.Add(this.tabPage1);
            this.lampe_hue.Location = new System.Drawing.Point(13, 26);
            this.lampe_hue.Name = "lampe_hue";
            this.lampe_hue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lampe_hue.SelectedIndex = 0;
            this.lampe_hue.Size = new System.Drawing.Size(1359, 442);
            this.lampe_hue.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.textBoxPollInterval);
            this.tabPage2.Controls.Add(this.buttonPollInterval);
            this.tabPage2.Controls.Add(this.buttonNWKState);
            this.tabPage2.Controls.Add(this.buttonDiscoveryOnly);
            this.tabPage2.Controls.Add(this.textBoxBindTargetExtAddr);
            this.tabPage2.Controls.Add(this.textBoxUserSetReqDescription);
            this.tabPage2.Controls.Add(this.textBoxUserSetReqAddr);
            this.tabPage2.Controls.Add(this.buttonUserSetReq);
            this.tabPage2.Controls.Add(this.textBoxUserReqAddr);
            this.tabPage2.Controls.Add(this.buttonUserReq);
            this.tabPage2.Controls.Add(this.textBoxRestoreNwkFrameCounter);
            this.tabPage2.Controls.Add(this.comboBoxLeaveChildren);
            this.tabPage2.Controls.Add(this.comboBoxLeaveReJoin);
            this.tabPage2.Controls.Add(this.textBoxLeaveAddr);
            this.tabPage2.Controls.Add(this.buttonLeave);
            this.tabPage2.Controls.Add(this.textBoxRemoveChildAddr);
            this.tabPage2.Controls.Add(this.textBoxRemoveParentAddr);
            this.tabPage2.Controls.Add(this.buttonRemoveDevice);
            this.tabPage2.Controls.Add(this.buttonPermitJoinState);
            this.tabPage2.Controls.Add(this.buttonRestoreNwk);
            this.tabPage2.Controls.Add(this.buttonRecoverNwk);
            this.tabPage2.Controls.Add(this.comboBoxMgmtLeaveChildren);
            this.tabPage2.Controls.Add(this.comboBoxMgmtLeaveReJoin);
            this.tabPage2.Controls.Add(this.textBoxMgmtLeaveExtAddr);
            this.tabPage2.Controls.Add(this.textBoxMgmtLeaveAddr);
            this.tabPage2.Controls.Add(this.buttonMgmtLeave);
            this.tabPage2.Controls.Add(this.textBoxUnBindDestEP);
            this.tabPage2.Controls.Add(this.textBoxUnBindDestAddr);
            this.tabPage2.Controls.Add(this.comboBoxUnBindAddrMode);
            this.tabPage2.Controls.Add(this.textBoxUnBindClusterID);
            this.tabPage2.Controls.Add(this.textBoxUnBindTargetEP);
            this.tabPage2.Controls.Add(this.textBoxUnBindTargetExtAddr);
            this.tabPage2.Controls.Add(this.buttonUnBind);
            this.tabPage2.Controls.Add(this.textBoxBindDestEP);
            this.tabPage2.Controls.Add(this.textBoxBindDestAddr);
            this.tabPage2.Controls.Add(this.comboBoxBindAddrMode);
            this.tabPage2.Controls.Add(this.textBoxBindClusterID);
            this.tabPage2.Controls.Add(this.textBoxBindTargetEP);
            this.tabPage2.Controls.Add(this.textBoxLqiReqStartIndex);
            this.tabPage2.Controls.Add(this.textBoxLqiReqTargetAddr);
            this.tabPage2.Controls.Add(this.buttonMgmtLqiReq);
            this.tabPage2.Controls.Add(this.buttonStartScan);
            this.tabPage2.Controls.Add(this.textBoxNwkAddrReqStartIndex);
            this.tabPage2.Controls.Add(this.comboBoxNwkAddrReqType);
            this.tabPage2.Controls.Add(this.textBoxNwkAddrReqExtAddr);
            this.tabPage2.Controls.Add(this.textBoxNwkAddrReqTargetAddr);
            this.tabPage2.Controls.Add(this.textBoxIeeeReqStartIndex);
            this.tabPage2.Controls.Add(this.comboBoxIeeeReqType);
            this.tabPage2.Controls.Add(this.textBoxIeeeReqAddr);
            this.tabPage2.Controls.Add(this.textBoxIeeeReqTargetAddr);
            this.tabPage2.Controls.Add(this.textBoxComplexReqAddr);
            this.tabPage2.Controls.Add(this.buttonComplexReq);
            this.tabPage2.Controls.Add(this.textBoxMatchReqOutputClusters);
            this.tabPage2.Controls.Add(this.textBoxMatchReqInputClusters);
            this.tabPage2.Controls.Add(this.textBoxMatchReqProfileID);
            this.tabPage2.Controls.Add(this.textBoxMatchReqNbrOutputClusters);
            this.tabPage2.Controls.Add(this.textBoxMatchReqNbrInputClusters);
            this.tabPage2.Controls.Add(this.textBoxMatchReqAddr);
            this.tabPage2.Controls.Add(this.textBoxActiveEpAddr);
            this.tabPage2.Controls.Add(this.textBoxPowerReqAddr);
            this.tabPage2.Controls.Add(this.textBoxSimpleReqEndPoint);
            this.tabPage2.Controls.Add(this.textBoxSimpleReqAddr);
            this.tabPage2.Controls.Add(this.buttonMatchReq);
            this.tabPage2.Controls.Add(this.buttonActiveEpReq);
            this.tabPage2.Controls.Add(this.buttonPowerDescReq);
            this.tabPage2.Controls.Add(this.buttonSimpleDescReq);
            this.tabPage2.Controls.Add(this.textBoxNodeDescReq);
            this.tabPage2.Controls.Add(this.buttonNodeDescReq);
            this.tabPage2.Controls.Add(this.buttonIeeeAddrReq);
            this.tabPage2.Controls.Add(this.buttonNwkAddrReq);
            this.tabPage2.Controls.Add(this.comboBoxSecurityKey);
            this.tabPage2.Controls.Add(this.comboBoxPermitJoinTCsignificance);
            this.tabPage2.Controls.Add(this.textBoxPermitJoinInterval);
            this.tabPage2.Controls.Add(this.textBoxPermitJoinAddr);
            this.tabPage2.Controls.Add(this.buttonPermitJoin);
            this.tabPage2.Controls.Add(this.comboBoxSetKeyType);
            this.tabPage2.Controls.Add(this.comboBoxSetKeyState);
            this.tabPage2.Controls.Add(this.comboBoxSetType);
            this.tabPage2.Controls.Add(this.buttonStartNWK);
            this.tabPage2.Controls.Add(this.buttonBind);
            this.tabPage2.Controls.Add(this.buttonErasePD);
            this.tabPage2.Controls.Add(this.buttonReset);
            this.tabPage2.Controls.Add(this.textBoxSetSecurityKeySeqNbr);
            this.tabPage2.Controls.Add(this.buttonSetDeviceType);
            this.tabPage2.Controls.Add(this.buttonSetSecurity);
            this.tabPage2.Controls.Add(this.textBoxSetEPID);
            this.tabPage2.Controls.Add(this.textBoxSetCMSK);
            this.tabPage2.Controls.Add(this.buttonSetCMSK);
            this.tabPage2.Controls.Add(this.buttonSetEPID);
            this.tabPage2.Controls.Add(this.buttonGetVersion);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1351, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Management";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // textBoxPollInterval
            // 
            this.textBoxPollInterval.Location = new System.Drawing.Point(95, 386);
            this.textBoxPollInterval.Name = "textBoxPollInterval";
            this.textBoxPollInterval.Size = new System.Drawing.Size(129, 20);
            this.textBoxPollInterval.TabIndex = 89;
            this.textBoxPollInterval.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxPollInterval_MouseClick);
            this.textBoxPollInterval.MouseLeave += new System.EventHandler(this.textBoxPollInterval_MouseLeave);
            this.textBoxPollInterval.MouseHover += new System.EventHandler(this.textBoxPollInterval_MouseHover);
            // 
            // buttonPollInterval
            // 
            this.buttonPollInterval.Location = new System.Drawing.Point(6, 382);
            this.buttonPollInterval.Name = "buttonPollInterval";
            this.buttonPollInterval.Size = new System.Drawing.Size(80, 25);
            this.buttonPollInterval.TabIndex = 88;
            this.buttonPollInterval.Text = "PollInterval";
            this.buttonPollInterval.UseVisualStyleBackColor = true;
            this.buttonPollInterval.Click += new System.EventHandler(this.PollInterval_Click);
            // 
            // buttonNWKState
            // 
            this.buttonNWKState.Location = new System.Drawing.Point(752, 383);
            this.buttonNWKState.Name = "buttonNWKState";
            this.buttonNWKState.Size = new System.Drawing.Size(105, 22);
            this.buttonNWKState.TabIndex = 88;
            this.buttonNWKState.Text = "Network State";
            this.buttonNWKState.UseVisualStyleBackColor = true;
            this.buttonNWKState.Click += new System.EventHandler(this.buttonNWKState_Click);
            // 
            // buttonDiscoveryOnly
            // 
            this.buttonDiscoveryOnly.Location = new System.Drawing.Point(438, 6);
            this.buttonDiscoveryOnly.Name = "buttonDiscoveryOnly";
            this.buttonDiscoveryOnly.Size = new System.Drawing.Size(118, 22);
            this.buttonDiscoveryOnly.TabIndex = 6;
            this.buttonDiscoveryOnly.Text = "Scan Discovery Only";
            this.buttonDiscoveryOnly.UseVisualStyleBackColor = true;
            this.buttonDiscoveryOnly.Visible = true;
            this.buttonDiscoveryOnly.Click += new System.EventHandler(this.buttonDiscoveryOnly_Click);
            // 
            // textBoxBindTargetExtAddr
            // 
            this.textBoxBindTargetExtAddr.Location = new System.Drawing.Point(93, 326);
            this.textBoxBindTargetExtAddr.Name = "textBoxBindTargetExtAddr";
            this.textBoxBindTargetExtAddr.Size = new System.Drawing.Size(129, 20);
            this.textBoxBindTargetExtAddr.TabIndex = 43;
            this.textBoxBindTargetExtAddr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxBindTargetExtAddr_MouseClick);
            this.textBoxBindTargetExtAddr.Leave += new System.EventHandler(this.textBoxBindTargetExtAddr_Leave);
            this.textBoxBindTargetExtAddr.MouseLeave += new System.EventHandler(this.textBoxBindTargetExtAddr_MouseLeave);
            this.textBoxBindTargetExtAddr.MouseHover += new System.EventHandler(this.textBoxBindTargetExtAddr_MouseHover);
            // 
            // textBoxUserSetReqDescription
            // 
            this.textBoxUserSetReqDescription.Location = new System.Drawing.Point(951, 239);
            this.textBoxUserSetReqDescription.Name = "textBoxUserSetReqDescription";
            this.textBoxUserSetReqDescription.Size = new System.Drawing.Size(160, 20);
            this.textBoxUserSetReqDescription.TabIndex = 81;
            this.textBoxUserSetReqDescription.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxUserSetReqDescription_MouseClick);
            this.textBoxUserSetReqDescription.Leave += new System.EventHandler(this.textBoxUserSetReqDescription_Leave);
            this.textBoxUserSetReqDescription.MouseLeave += new System.EventHandler(this.textBoxUserSetReqDescription_MouseLeave);
            this.textBoxUserSetReqDescription.MouseHover += new System.EventHandler(this.textBoxUserSetReqDescription_MouseHover);
            // 
            // textBoxUserSetReqAddr
            // 
            this.textBoxUserSetReqAddr.Location = new System.Drawing.Point(838, 239);
            this.textBoxUserSetReqAddr.Name = "textBoxUserSetReqAddr";
            this.textBoxUserSetReqAddr.Size = new System.Drawing.Size(106, 20);
            this.textBoxUserSetReqAddr.TabIndex = 80;
            this.textBoxUserSetReqAddr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxUserSetReqAddr_MouseClick);
            this.textBoxUserSetReqAddr.Leave += new System.EventHandler(this.textBoxUserSetReqAddr_Leave);
            this.textBoxUserSetReqAddr.MouseLeave += new System.EventHandler(this.textBoxUserSetReqAddr_MouseLeave);
            this.textBoxUserSetReqAddr.MouseHover += new System.EventHandler(this.textBoxUserSetReqAddr_MouseHover);
            // 
            // buttonUserSetReq
            // 
            this.buttonUserSetReq.Location = new System.Drawing.Point(752, 238);
            this.buttonUserSetReq.Name = "buttonUserSetReq";
            this.buttonUserSetReq.Size = new System.Drawing.Size(80, 22);
            this.buttonUserSetReq.TabIndex = 79;
            this.buttonUserSetReq.Text = "UserSetReq";
            this.buttonUserSetReq.UseVisualStyleBackColor = true;
            this.buttonUserSetReq.Click += new System.EventHandler(this.buttonUserSetReq_Click);
            // 
            // textBoxUserReqAddr
            // 
            this.textBoxUserReqAddr.Location = new System.Drawing.Point(838, 210);
            this.textBoxUserReqAddr.Name = "textBoxUserReqAddr";
            this.textBoxUserReqAddr.Size = new System.Drawing.Size(106, 20);
            this.textBoxUserReqAddr.TabIndex = 78;
            this.textBoxUserReqAddr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxUserReqAddr_MouseClick);
            this.textBoxUserReqAddr.Leave += new System.EventHandler(this.textBoxUserReqAddr_Leave);
            this.textBoxUserReqAddr.MouseLeave += new System.EventHandler(this.textBoxUserReqAddr_MouseLeave);
            this.textBoxUserReqAddr.MouseHover += new System.EventHandler(this.textBoxUserReqAddr_MouseHover);
            // 
            // buttonUserReq
            // 
            this.buttonUserReq.Location = new System.Drawing.Point(752, 209);
            this.buttonUserReq.Name = "buttonUserReq";
            this.buttonUserReq.Size = new System.Drawing.Size(80, 22);
            this.buttonUserReq.TabIndex = 77;
            this.buttonUserReq.Text = "UserReq";
            this.buttonUserReq.UseVisualStyleBackColor = true;
            this.buttonUserReq.Click += new System.EventHandler(this.buttonUserReq_Click);
            // 
            // textBoxRestoreNwkFrameCounter
            // 
            this.textBoxRestoreNwkFrameCounter.Location = new System.Drawing.Point(838, 327);
            this.textBoxRestoreNwkFrameCounter.Name = "textBoxRestoreNwkFrameCounter";
            this.textBoxRestoreNwkFrameCounter.Size = new System.Drawing.Size(163, 20);
            this.textBoxRestoreNwkFrameCounter.TabIndex = 87;
            this.textBoxRestoreNwkFrameCounter.Visible = false;
            this.textBoxRestoreNwkFrameCounter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxRestoreNwkFrameCounter_MouseClick);
            this.textBoxRestoreNwkFrameCounter.MouseLeave += new System.EventHandler(this.textBoxRestoreNwkFrameCounter_MouseLeave);
            this.textBoxRestoreNwkFrameCounter.MouseHover += new System.EventHandler(this.textBoxRestoreNwkFrameCounter_MouseHover);
            // 
            // comboBoxLeaveChildren
            // 
            this.comboBoxLeaveChildren.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLeaveChildren.FormattingEnabled = true;
            this.comboBoxLeaveChildren.Location = new System.Drawing.Point(434, 182);
            this.comboBoxLeaveChildren.Name = "comboBoxLeaveChildren";
            this.comboBoxLeaveChildren.Size = new System.Drawing.Size(196, 21);
            this.comboBoxLeaveChildren.TabIndex = 26;
            // 
            // comboBoxLeaveReJoin
            // 
            this.comboBoxLeaveReJoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLeaveReJoin.FormattingEnabled = true;
            this.comboBoxLeaveReJoin.Location = new System.Drawing.Point(308, 182);
            this.comboBoxLeaveReJoin.Name = "comboBoxLeaveReJoin";
            this.comboBoxLeaveReJoin.Size = new System.Drawing.Size(119, 21);
            this.comboBoxLeaveReJoin.TabIndex = 25;
            // 
            // textBoxLeaveAddr
            // 
            this.textBoxLeaveAddr.Location = new System.Drawing.Point(93, 182);
            this.textBoxLeaveAddr.Name = "textBoxLeaveAddr";
            this.textBoxLeaveAddr.Size = new System.Drawing.Size(209, 20);
            this.textBoxLeaveAddr.TabIndex = 24;
            this.textBoxLeaveAddr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxLeaveAddr_MouseClick);
            this.textBoxLeaveAddr.Leave += new System.EventHandler(this.textBoxLeaveAddr_Leave);
            this.textBoxLeaveAddr.MouseLeave += new System.EventHandler(this.textBoxLeaveAddr_MouseLeave);
            this.textBoxLeaveAddr.MouseHover += new System.EventHandler(this.textBoxLeaveAddr_MouseHover);
            // 
            // buttonLeave
            // 
            this.buttonLeave.Location = new System.Drawing.Point(6, 180);
            this.buttonLeave.Name = "buttonLeave";
            this.buttonLeave.Size = new System.Drawing.Size(80, 22);
            this.buttonLeave.TabIndex = 23;
            this.buttonLeave.Text = "Leave";
            this.buttonLeave.UseVisualStyleBackColor = true;
            this.buttonLeave.Click += new System.EventHandler(this.buttonLeave_Click);
            // 
            // textBoxRemoveChildAddr
            // 
            this.textBoxRemoveChildAddr.Location = new System.Drawing.Point(321, 212);
            this.textBoxRemoveChildAddr.Name = "textBoxRemoveChildAddr";
            this.textBoxRemoveChildAddr.Size = new System.Drawing.Size(219, 20);
            this.textBoxRemoveChildAddr.TabIndex = 29;
            this.textBoxRemoveChildAddr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxRemoveChildAddr_MouseClick);
            this.textBoxRemoveChildAddr.Leave += new System.EventHandler(this.textBoxRemoveChildAddr_Leave);
            this.textBoxRemoveChildAddr.MouseLeave += new System.EventHandler(this.textBoxRemoveChildAddr_MouseLeave);
            this.textBoxRemoveChildAddr.MouseHover += new System.EventHandler(this.textBoxRemoveChildAddr_MouseHover);
            // 
            // textBoxRemoveParentAddr
            // 
            this.textBoxRemoveParentAddr.Location = new System.Drawing.Point(93, 212);
            this.textBoxRemoveParentAddr.Name = "textBoxRemoveParentAddr";
            this.textBoxRemoveParentAddr.Size = new System.Drawing.Size(219, 20);
            this.textBoxRemoveParentAddr.TabIndex = 28;
            this.textBoxRemoveParentAddr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxRemoveParentAddr_MouseClick);
            this.textBoxRemoveParentAddr.Leave += new System.EventHandler(this.textBoxRemoveParentAddr_Leave);
            this.textBoxRemoveParentAddr.MouseLeave += new System.EventHandler(this.textBoxRemoveParentAddr_MouseLeave);
            this.textBoxRemoveParentAddr.MouseHover += new System.EventHandler(this.textBoxRemoveParentAddr_MouseHover);
            // 
            // buttonRemoveDevice
            // 
            this.buttonRemoveDevice.Location = new System.Drawing.Point(6, 210);
            this.buttonRemoveDevice.Name = "buttonRemoveDevice";
            this.buttonRemoveDevice.Size = new System.Drawing.Size(80, 22);
            this.buttonRemoveDevice.TabIndex = 27;
            this.buttonRemoveDevice.Text = "Remove";
            this.buttonRemoveDevice.UseVisualStyleBackColor = true;
            this.buttonRemoveDevice.Click += new System.EventHandler(this.buttonRemoveDevice_Click);
            // 
            // buttonPermitJoinState
            // 
            this.buttonPermitJoinState.Location = new System.Drawing.Point(6, 267);
            this.buttonPermitJoinState.Name = "buttonPermitJoinState";
            this.buttonPermitJoinState.Size = new System.Drawing.Size(105, 22);
            this.buttonPermitJoinState.TabIndex = 34;
            this.buttonPermitJoinState.Text = "Permit Join State";
            this.buttonPermitJoinState.UseVisualStyleBackColor = true;
            this.buttonPermitJoinState.Click += new System.EventHandler(this.buttonPermitJoinState_Click);
            // 
            // buttonRestoreNwk
            // 
            this.buttonRestoreNwk.Location = new System.Drawing.Point(752, 324);
            this.buttonRestoreNwk.Name = "buttonRestoreNwk";
            this.buttonRestoreNwk.Size = new System.Drawing.Size(80, 22);
            this.buttonRestoreNwk.TabIndex = 86;
            this.buttonRestoreNwk.Text = "RES NWK";
            this.buttonRestoreNwk.UseVisualStyleBackColor = true;
            this.buttonRestoreNwk.Visible = false;
            this.buttonRestoreNwk.Click += new System.EventHandler(this.buttonRestoreNwk_Click);
            // 
            // buttonRecoverNwk
            // 
            this.buttonRecoverNwk.Location = new System.Drawing.Point(752, 295);
            this.buttonRecoverNwk.Name = "buttonRecoverNwk";
            this.buttonRecoverNwk.Size = new System.Drawing.Size(80, 22);
            this.buttonRecoverNwk.TabIndex = 85;
            this.buttonRecoverNwk.Text = "REC NWK";
            this.buttonRecoverNwk.UseVisualStyleBackColor = true;
            this.buttonRecoverNwk.Visible = false;
            this.buttonRecoverNwk.Click += new System.EventHandler(this.buttonRecoverNwk_Click);
            // 
            // comboBoxMgmtLeaveChildren
            // 
            this.comboBoxMgmtLeaveChildren.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMgmtLeaveChildren.FormattingEnabled = true;
            this.comboBoxMgmtLeaveChildren.Location = new System.Drawing.Point(547, 154);
            this.comboBoxMgmtLeaveChildren.Name = "comboBoxMgmtLeaveChildren";
            this.comboBoxMgmtLeaveChildren.Size = new System.Drawing.Size(196, 21);
            this.comboBoxMgmtLeaveChildren.TabIndex = 22;
            // 
            // comboBoxMgmtLeaveReJoin
            // 
            this.comboBoxMgmtLeaveReJoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMgmtLeaveReJoin.FormattingEnabled = true;
            this.comboBoxMgmtLeaveReJoin.Location = new System.Drawing.Point(422, 154);
            this.comboBoxMgmtLeaveReJoin.Name = "comboBoxMgmtLeaveReJoin";
            this.comboBoxMgmtLeaveReJoin.Size = new System.Drawing.Size(119, 21);
            this.comboBoxMgmtLeaveReJoin.TabIndex = 21;
            // 
            // textBoxMgmtLeaveExtAddr
            // 
            this.textBoxMgmtLeaveExtAddr.Location = new System.Drawing.Point(206, 154);
            this.textBoxMgmtLeaveExtAddr.Name = "textBoxMgmtLeaveExtAddr";
            this.textBoxMgmtLeaveExtAddr.Size = new System.Drawing.Size(209, 20);
            this.textBoxMgmtLeaveExtAddr.TabIndex = 20;
            this.textBoxMgmtLeaveExtAddr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxMgmtLeaveExtAddr_MouseClick);
            this.textBoxMgmtLeaveExtAddr.Leave += new System.EventHandler(this.textBoxMgmtLeaveExtAddr_Leave);
            this.textBoxMgmtLeaveExtAddr.MouseLeave += new System.EventHandler(this.textBoxMgmtLeaveExtAddr_MouseLeave);
            this.textBoxMgmtLeaveExtAddr.MouseHover += new System.EventHandler(this.textBoxMgmtLeaveExtAddr_MouseHover);
            // 
            // textBoxMgmtLeaveAddr
            // 
            this.textBoxMgmtLeaveAddr.Location = new System.Drawing.Point(93, 154);
            this.textBoxMgmtLeaveAddr.Name = "textBoxMgmtLeaveAddr";
            this.textBoxMgmtLeaveAddr.Size = new System.Drawing.Size(106, 20);
            this.textBoxMgmtLeaveAddr.TabIndex = 19;
            this.textBoxMgmtLeaveAddr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxMgmtLeaveAddr_MouseClick);
            this.textBoxMgmtLeaveAddr.Leave += new System.EventHandler(this.textBoxMgmtLeaveAddr_Leave);
            this.textBoxMgmtLeaveAddr.MouseLeave += new System.EventHandler(this.textBoxMgmtLeaveAddr_MouseLeave);
            this.textBoxMgmtLeaveAddr.MouseHover += new System.EventHandler(this.textBoxMgmtLeaveAddr_MouseHover);
            // 
            // buttonMgmtLeave
            // 
            this.buttonMgmtLeave.Location = new System.Drawing.Point(6, 152);
            this.buttonMgmtLeave.Name = "buttonMgmtLeave";
            this.buttonMgmtLeave.Size = new System.Drawing.Size(80, 22);
            this.buttonMgmtLeave.TabIndex = 18;
            this.buttonMgmtLeave.Text = "Mgmt Leave";
            this.buttonMgmtLeave.UseVisualStyleBackColor = true;
            this.buttonMgmtLeave.Click += new System.EventHandler(this.buttonMgmtLeave_Click);
            // 
            // textBoxUnBindDestEP
            // 
            this.textBoxUnBindDestEP.Location = new System.Drawing.Point(652, 351);
            this.textBoxUnBindDestEP.Name = "textBoxUnBindDestEP";
            this.textBoxUnBindDestEP.Size = new System.Drawing.Size(88, 20);
            this.textBoxUnBindDestEP.TabIndex = 55;
            this.textBoxUnBindDestEP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxUnBindDestEP_MouseClick);
            this.textBoxUnBindDestEP.Leave += new System.EventHandler(this.textBoxUnBindDestEP_Leave);
            this.textBoxUnBindDestEP.MouseLeave += new System.EventHandler(this.textBoxUnBindDestEP_MouseLeave);
            this.textBoxUnBindDestEP.MouseHover += new System.EventHandler(this.textBoxUnBindDestEP_MouseHover);
            // 
            // textBoxUnBindDestAddr
            // 
            this.textBoxUnBindDestAddr.Location = new System.Drawing.Point(411, 351);
            this.textBoxUnBindDestAddr.Name = "textBoxUnBindDestAddr";
            this.textBoxUnBindDestAddr.Size = new System.Drawing.Size(133, 20);
            this.textBoxUnBindDestAddr.TabIndex = 53;
            this.textBoxUnBindDestAddr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxUnBindDestAddr_MouseClick);
            this.textBoxUnBindDestAddr.Leave += new System.EventHandler(this.textBoxUnBindDestAddr_Leave);
            this.textBoxUnBindDestAddr.MouseLeave += new System.EventHandler(this.textBoxUnBindDestAddr_MouseLeave);
            this.textBoxUnBindDestAddr.MouseHover += new System.EventHandler(this.textBoxUnBindDestAddr_MouseHover);
            // 
            // comboBoxUnBindAddrMode
            // 
            this.comboBoxUnBindAddrMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUnBindAddrMode.FormattingEnabled = true;
            this.comboBoxUnBindAddrMode.Location = new System.Drawing.Point(322, 351);
            this.comboBoxUnBindAddrMode.Name = "comboBoxUnBindAddrMode";
            this.comboBoxUnBindAddrMode.Size = new System.Drawing.Size(84, 21);
            this.comboBoxUnBindAddrMode.TabIndex = 52;
            this.comboBoxUnBindAddrMode.MouseLeave += new System.EventHandler(this.comboBoxUnBindAddrMode_MouseLeave);
            this.comboBoxUnBindAddrMode.MouseHover += new System.EventHandler(this.comboBoxUnBindAddrMode_MouseHover);
            // 
            // textBoxUnBindClusterID
            // 
            this.textBoxUnBindClusterID.Location = new System.Drawing.Point(550, 351);
            this.textBoxUnBindClusterID.Name = "textBoxUnBindClusterID";
            this.textBoxUnBindClusterID.Size = new System.Drawing.Size(96, 20);
            this.textBoxUnBindClusterID.TabIndex = 54;
            this.textBoxUnBindClusterID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxUnBindClusterID_MouseClick);
            this.textBoxUnBindClusterID.Leave += new System.EventHandler(this.textBoxUnBindClusterID_Leave);
            this.textBoxUnBindClusterID.MouseLeave += new System.EventHandler(this.textBoxUnBindClusterID_MouseLeave);
            this.textBoxUnBindClusterID.MouseHover += new System.EventHandler(this.textBoxUnBindClusterID_MouseHover);
            // 
            // textBoxUnBindTargetEP
            // 
            this.textBoxUnBindTargetEP.Location = new System.Drawing.Point(228, 351);
            this.textBoxUnBindTargetEP.Name = "textBoxUnBindTargetEP";
            this.textBoxUnBindTargetEP.Size = new System.Drawing.Size(84, 20);
            this.textBoxUnBindTargetEP.TabIndex = 51;
            this.textBoxUnBindTargetEP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxUnBindTargetEP_MouseClick);
            this.textBoxUnBindTargetEP.Leave += new System.EventHandler(this.textBoxUnBindTargetEP_Leave);
            this.textBoxUnBindTargetEP.MouseLeave += new System.EventHandler(this.textBoxUnBindTargetEP_MouseLeave);
            this.textBoxUnBindTargetEP.MouseHover += new System.EventHandler(this.textBoxUnBindTargetEP_MouseHover);
            // 
            // textBoxUnBindTargetExtAddr
            // 
            this.textBoxUnBindTargetExtAddr.Location = new System.Drawing.Point(93, 353);
            this.textBoxUnBindTargetExtAddr.Name = "textBoxUnBindTargetExtAddr";
            this.textBoxUnBindTargetExtAddr.Size = new System.Drawing.Size(129, 20);
            this.textBoxUnBindTargetExtAddr.TabIndex = 50;
            this.textBoxUnBindTargetExtAddr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxUnBindTargetExtAddr_MouseClick);
            this.textBoxUnBindTargetExtAddr.Leave += new System.EventHandler(this.textBoxUnBindTargetExtAddr_Leave);
            this.textBoxUnBindTargetExtAddr.MouseLeave += new System.EventHandler(this.textBoxUnBindTargetExtAddr_MouseLeave);
            this.textBoxUnBindTargetExtAddr.MouseHover += new System.EventHandler(this.textBoxUnBindTargetExtAddr_MouseHover);
            // 
            // buttonUnBind
            // 
            this.buttonUnBind.Location = new System.Drawing.Point(6, 351);
            this.buttonUnBind.Name = "buttonUnBind";
            this.buttonUnBind.Size = new System.Drawing.Size(80, 25);
            this.buttonUnBind.TabIndex = 49;
            this.buttonUnBind.Text = "UnBind";
            this.buttonUnBind.UseVisualStyleBackColor = true;
            this.buttonUnBind.Click += new System.EventHandler(this.buttonUnBind_Click);
            // 
            // textBoxBindDestEP
            // 
            this.textBoxBindDestEP.Location = new System.Drawing.Point(652, 327);
            this.textBoxBindDestEP.Name = "textBoxBindDestEP";
            this.textBoxBindDestEP.Size = new System.Drawing.Size(88, 20);
            this.textBoxBindDestEP.TabIndex = 48;
            this.textBoxBindDestEP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxBindDestEP_MouseClick);
            this.textBoxBindDestEP.Leave += new System.EventHandler(this.textBoxBindDestEP_Leave);
            this.textBoxBindDestEP.MouseLeave += new System.EventHandler(this.textBoxBindDestEP_MouseLeave);
            this.textBoxBindDestEP.MouseHover += new System.EventHandler(this.textBoxBindDestEP_MouseHover);
            // 
            // textBoxBindDestAddr
            // 
            this.textBoxBindDestAddr.Location = new System.Drawing.Point(411, 326);
            this.textBoxBindDestAddr.Name = "textBoxBindDestAddr";
            this.textBoxBindDestAddr.Size = new System.Drawing.Size(133, 20);
            this.textBoxBindDestAddr.TabIndex = 46;
            this.textBoxBindDestAddr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxBindDestAddr_MouseClick);
            this.textBoxBindDestAddr.Leave += new System.EventHandler(this.textBoxBindDestAddr_Leave);
            this.textBoxBindDestAddr.MouseLeave += new System.EventHandler(this.textBoxBindDestAddr_MouseLeave);
            this.textBoxBindDestAddr.MouseHover += new System.EventHandler(this.textBoxBindDestAddr_MouseHover);
            // 
            // comboBoxBindAddrMode
            // 
            this.comboBoxBindAddrMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBindAddrMode.FormattingEnabled = true;
            this.comboBoxBindAddrMode.Location = new System.Drawing.Point(322, 326);
            this.comboBoxBindAddrMode.Name = "comboBoxBindAddrMode";
            this.comboBoxBindAddrMode.Size = new System.Drawing.Size(84, 21);
            this.comboBoxBindAddrMode.TabIndex = 45;
            this.comboBoxBindAddrMode.MouseLeave += new System.EventHandler(this.comboBoxBindAddrMode_MouseLeave);
            this.comboBoxBindAddrMode.MouseHover += new System.EventHandler(this.comboBoxBindAddrMode_MouseHover);
            // 
            // textBoxBindClusterID
            // 
            this.textBoxBindClusterID.Location = new System.Drawing.Point(550, 327);
            this.textBoxBindClusterID.Name = "textBoxBindClusterID";
            this.textBoxBindClusterID.Size = new System.Drawing.Size(96, 20);
            this.textBoxBindClusterID.TabIndex = 47;
            this.textBoxBindClusterID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxBindClusterID_MouseClick);
            this.textBoxBindClusterID.Leave += new System.EventHandler(this.textBoxBindClusterID_Leave);
            this.textBoxBindClusterID.MouseLeave += new System.EventHandler(this.textBoxBindClusterID_MouseLeave);
            this.textBoxBindClusterID.MouseHover += new System.EventHandler(this.textBoxBindClusterID_MouseHover);
            // 
            // textBoxBindTargetEP
            // 
            this.textBoxBindTargetEP.Location = new System.Drawing.Point(228, 326);
            this.textBoxBindTargetEP.Name = "textBoxBindTargetEP";
            this.textBoxBindTargetEP.Size = new System.Drawing.Size(84, 20);
            this.textBoxBindTargetEP.TabIndex = 44;
            this.textBoxBindTargetEP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxBindTargetEP_MouseClick);
            this.textBoxBindTargetEP.Leave += new System.EventHandler(this.textBoxBindTargetEP_Leave);
            this.textBoxBindTargetEP.MouseLeave += new System.EventHandler(this.textBoxBindTargetEP_MouseLeave);
            this.textBoxBindTargetEP.MouseHover += new System.EventHandler(this.textBoxBindTargetEP_MouseHover);
            // 
            // textBoxLqiReqStartIndex
            // 
            this.textBoxLqiReqStartIndex.Location = new System.Drawing.Point(951, 268);
            this.textBoxLqiReqStartIndex.Name = "textBoxLqiReqStartIndex";
            this.textBoxLqiReqStartIndex.Size = new System.Drawing.Size(106, 20);
            this.textBoxLqiReqStartIndex.TabIndex = 84;
            this.textBoxLqiReqStartIndex.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxLqiReqStartIndex_MouseClick);
            this.textBoxLqiReqStartIndex.Leave += new System.EventHandler(this.textBoxLqiReqStartIndex_Leave);
            this.textBoxLqiReqStartIndex.MouseLeave += new System.EventHandler(this.textBoxLqiReqStartIndex_MouseLeave);
            this.textBoxLqiReqStartIndex.MouseHover += new System.EventHandler(this.textBoxLqiReqStartIndex_MouseHover);
            // 
            // textBoxLqiReqTargetAddr
            // 
            this.textBoxLqiReqTargetAddr.Location = new System.Drawing.Point(838, 269);
            this.textBoxLqiReqTargetAddr.Name = "textBoxLqiReqTargetAddr";
            this.textBoxLqiReqTargetAddr.Size = new System.Drawing.Size(106, 20);
            this.textBoxLqiReqTargetAddr.TabIndex = 83;
            this.textBoxLqiReqTargetAddr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxLqiReqTargetAddr_MouseClick);
            this.textBoxLqiReqTargetAddr.Leave += new System.EventHandler(this.textBoxLqiReqTargetAddr_Leave);
            this.textBoxLqiReqTargetAddr.MouseLeave += new System.EventHandler(this.textBoxLqiReqTargetAddr_MouseLeave);
            this.textBoxLqiReqTargetAddr.MouseHover += new System.EventHandler(this.textBoxLqiReqTargetAddr_MouseHover);
            // 
            // buttonMgmtLqiReq
            // 
            this.buttonMgmtLqiReq.Location = new System.Drawing.Point(752, 267);
            this.buttonMgmtLqiReq.Name = "buttonMgmtLqiReq";
            this.buttonMgmtLqiReq.Size = new System.Drawing.Size(80, 22);
            this.buttonMgmtLqiReq.TabIndex = 82;
            this.buttonMgmtLqiReq.Text = "Lqi Req";
            this.buttonMgmtLqiReq.UseVisualStyleBackColor = true;
            this.buttonMgmtLqiReq.Click += new System.EventHandler(this.buttonMgmtLqiReq_Click_1);
            // 
            // buttonStartScan
            // 
            this.buttonStartScan.Location = new System.Drawing.Point(352, 6);
            this.buttonStartScan.Name = "buttonStartScan";
            this.buttonStartScan.Size = new System.Drawing.Size(80, 22);
            this.buttonStartScan.TabIndex = 5;
            this.buttonStartScan.Text = "Start Scan";
            this.buttonStartScan.UseVisualStyleBackColor = true;
            this.buttonStartScan.Click += new System.EventHandler(this.buttonStartScan_Click);
            // 
            // textBoxNwkAddrReqStartIndex
            // 
            this.textBoxNwkAddrReqStartIndex.Location = new System.Drawing.Point(1200, 64);
            this.textBoxNwkAddrReqStartIndex.Name = "textBoxNwkAddrReqStartIndex";
            this.textBoxNwkAddrReqStartIndex.Size = new System.Drawing.Size(106, 20);
            this.textBoxNwkAddrReqStartIndex.TabIndex = 67;
            this.textBoxNwkAddrReqStartIndex.Leave += new System.EventHandler(this.textBoxNwkAddrReqStartIndex_Leave);
            this.textBoxNwkAddrReqStartIndex.MouseLeave += new System.EventHandler(this.textBoxNwkAddrReqStartIndex_MouseLeave);
            this.textBoxNwkAddrReqStartIndex.MouseHover += new System.EventHandler(this.textBoxNwkAddrReqStartIndex_MouseHover);
            // 
            // comboBoxNwkAddrReqType
            // 
            this.comboBoxNwkAddrReqType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNwkAddrReqType.FormattingEnabled = true;
            this.comboBoxNwkAddrReqType.Location = new System.Drawing.Point(1065, 64);
            this.comboBoxNwkAddrReqType.Name = "comboBoxNwkAddrReqType";
            this.comboBoxNwkAddrReqType.Size = new System.Drawing.Size(129, 21);
            this.comboBoxNwkAddrReqType.TabIndex = 66;
            // 
            // textBoxNwkAddrReqExtAddr
            // 
            this.textBoxNwkAddrReqExtAddr.Location = new System.Drawing.Point(951, 65);
            this.textBoxNwkAddrReqExtAddr.Name = "textBoxNwkAddrReqExtAddr";
            this.textBoxNwkAddrReqExtAddr.Size = new System.Drawing.Size(106, 20);
            this.textBoxNwkAddrReqExtAddr.TabIndex = 65;
            this.textBoxNwkAddrReqExtAddr.Leave += new System.EventHandler(this.textBoxNwkAddrReqExtAddr_Leave);
            this.textBoxNwkAddrReqExtAddr.MouseLeave += new System.EventHandler(this.textBoxNwkAddrReqExtAddr_MouseLeave);
            this.textBoxNwkAddrReqExtAddr.MouseHover += new System.EventHandler(this.textBoxNwkAddrReqExtAddr_MouseHover);
            // 
            // textBoxNwkAddrReqTargetAddr
            // 
            this.textBoxNwkAddrReqTargetAddr.Location = new System.Drawing.Point(838, 65);
            this.textBoxNwkAddrReqTargetAddr.Name = "textBoxNwkAddrReqTargetAddr";
            this.textBoxNwkAddrReqTargetAddr.Size = new System.Drawing.Size(106, 20);
            this.textBoxNwkAddrReqTargetAddr.TabIndex = 64;
            this.textBoxNwkAddrReqTargetAddr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxNwkAddrReqTargetAddr_MouseClick);
            this.textBoxNwkAddrReqTargetAddr.Leave += new System.EventHandler(this.textBoxNwkAddrReqTargetAddr_Leave);
            this.textBoxNwkAddrReqTargetAddr.MouseLeave += new System.EventHandler(this.textBoxNwkAddrReqTargetAddr_MouseLeave);
            this.textBoxNwkAddrReqTargetAddr.MouseHover += new System.EventHandler(this.textBoxNwkAddrReqTargetAddr_MouseHover);
            // 
            // textBoxIeeeReqStartIndex
            // 
            this.textBoxIeeeReqStartIndex.Location = new System.Drawing.Point(1200, 35);
            this.textBoxIeeeReqStartIndex.Name = "textBoxIeeeReqStartIndex";
            this.textBoxIeeeReqStartIndex.Size = new System.Drawing.Size(106, 20);
            this.textBoxIeeeReqStartIndex.TabIndex = 62;
            this.textBoxIeeeReqStartIndex.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxIeeeReqStartIndex_MouseClick);
            this.textBoxIeeeReqStartIndex.Leave += new System.EventHandler(this.textBoxIeeeReqStartIndex_Leave);
            this.textBoxIeeeReqStartIndex.MouseLeave += new System.EventHandler(this.textBoxIeeeReqStartIndex_MouseLeave);
            this.textBoxIeeeReqStartIndex.MouseHover += new System.EventHandler(this.textBoxIeeeReqStartIndex_MouseHover);
            // 
            // comboBoxIeeeReqType
            // 
            this.comboBoxIeeeReqType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIeeeReqType.FormattingEnabled = true;
            this.comboBoxIeeeReqType.Location = new System.Drawing.Point(1065, 35);
            this.comboBoxIeeeReqType.Name = "comboBoxIeeeReqType";
            this.comboBoxIeeeReqType.Size = new System.Drawing.Size(129, 21);
            this.comboBoxIeeeReqType.TabIndex = 61;
            // 
            // textBoxIeeeReqAddr
            // 
            this.textBoxIeeeReqAddr.Location = new System.Drawing.Point(951, 37);
            this.textBoxIeeeReqAddr.Name = "textBoxIeeeReqAddr";
            this.textBoxIeeeReqAddr.Size = new System.Drawing.Size(106, 20);
            this.textBoxIeeeReqAddr.TabIndex = 60;
            this.textBoxIeeeReqAddr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxIeeeReqAddr_MouseClick);
            this.textBoxIeeeReqAddr.Leave += new System.EventHandler(this.textBoxIeeeReqAddr_Leave);
            this.textBoxIeeeReqAddr.MouseLeave += new System.EventHandler(this.textBoxIeeeReqAddr_MouseLeave);
            this.textBoxIeeeReqAddr.MouseHover += new System.EventHandler(this.textBoxIeeeReqAddr_MouseHover);
            // 
            // textBoxIeeeReqTargetAddr
            // 
            this.textBoxIeeeReqTargetAddr.Location = new System.Drawing.Point(838, 37);
            this.textBoxIeeeReqTargetAddr.Name = "textBoxIeeeReqTargetAddr";
            this.textBoxIeeeReqTargetAddr.Size = new System.Drawing.Size(106, 20);
            this.textBoxIeeeReqTargetAddr.TabIndex = 59;
            this.textBoxIeeeReqTargetAddr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxIeeeReqTargetAddr_MouseClick);
            this.textBoxIeeeReqTargetAddr.Leave += new System.EventHandler(this.textBoxIeeeReqTargetAddr_Leave);
            this.textBoxIeeeReqTargetAddr.MouseLeave += new System.EventHandler(this.textBoxIeeeReqTargetAddr_MouseLeave);
            this.textBoxIeeeReqTargetAddr.MouseHover += new System.EventHandler(this.textBoxIeeeReqTargetAddr_MouseHover);
            // 
            // textBoxComplexReqAddr
            // 
            this.textBoxComplexReqAddr.Location = new System.Drawing.Point(838, 182);
            this.textBoxComplexReqAddr.Name = "textBoxComplexReqAddr";
            this.textBoxComplexReqAddr.Size = new System.Drawing.Size(106, 20);
            this.textBoxComplexReqAddr.TabIndex = 76;
            this.textBoxComplexReqAddr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxComplexReqAddr_MouseClick);
            this.textBoxComplexReqAddr.Leave += new System.EventHandler(this.textBoxComplexReqAddr_Leave);
            this.textBoxComplexReqAddr.MouseLeave += new System.EventHandler(this.textBoxComplexReqAddr_MouseLeave);
            this.textBoxComplexReqAddr.MouseHover += new System.EventHandler(this.textBoxComplexReqAddr_MouseHover);
            // 
            // buttonComplexReq
            // 
            this.buttonComplexReq.Location = new System.Drawing.Point(752, 180);
            this.buttonComplexReq.Name = "buttonComplexReq";
            this.buttonComplexReq.Size = new System.Drawing.Size(80, 22);
            this.buttonComplexReq.TabIndex = 75;
            this.buttonComplexReq.Text = "ComplexReq";
            this.buttonComplexReq.UseVisualStyleBackColor = true;
            this.buttonComplexReq.Click += new System.EventHandler(this.buttonComplexReq_Click);
            // 
            // textBoxMatchReqOutputClusters
            // 
            this.textBoxMatchReqOutputClusters.Location = new System.Drawing.Point(637, 298);
            this.textBoxMatchReqOutputClusters.Name = "textBoxMatchReqOutputClusters";
            this.textBoxMatchReqOutputClusters.Size = new System.Drawing.Size(103, 20);
            this.textBoxMatchReqOutputClusters.TabIndex = 41;
            this.textBoxMatchReqOutputClusters.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxMatchReqOutputClusters_MouseClick);
            this.textBoxMatchReqOutputClusters.Leave += new System.EventHandler(this.textBoxMatchReqOutputClusters_Leave);
            this.textBoxMatchReqOutputClusters.MouseLeave += new System.EventHandler(this.textBoxMatchReqOutputClusters_MouseLeave);
            this.textBoxMatchReqOutputClusters.MouseHover += new System.EventHandler(this.textBoxMatchReqOutputClusters_MouseHover);
            // 
            // textBoxMatchReqInputClusters
            // 
            this.textBoxMatchReqInputClusters.Location = new System.Drawing.Point(422, 298);
            this.textBoxMatchReqInputClusters.Name = "textBoxMatchReqInputClusters";
            this.textBoxMatchReqInputClusters.Size = new System.Drawing.Size(106, 20);
            this.textBoxMatchReqInputClusters.TabIndex = 39;
            this.textBoxMatchReqInputClusters.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxMatchReqInputClusters_MouseClick);
            this.textBoxMatchReqInputClusters.Leave += new System.EventHandler(this.textBoxMatchReqInputClusters_Leave);
            this.textBoxMatchReqInputClusters.MouseLeave += new System.EventHandler(this.textBoxMatchReqInputClusters_MouseLeave);
            this.textBoxMatchReqInputClusters.MouseHover += new System.EventHandler(this.textBoxMatchReqInputClusters_MouseHover);
            // 
            // textBoxMatchReqProfileID
            // 
            this.textBoxMatchReqProfileID.Location = new System.Drawing.Point(206, 298);
            this.textBoxMatchReqProfileID.Name = "textBoxMatchReqProfileID";
            this.textBoxMatchReqProfileID.Size = new System.Drawing.Size(106, 20);
            this.textBoxMatchReqProfileID.TabIndex = 37;
            this.textBoxMatchReqProfileID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxMatchReqProfileID_MouseClick);
            this.textBoxMatchReqProfileID.Leave += new System.EventHandler(this.textBoxMatchReqProfileID_Leave);
            this.textBoxMatchReqProfileID.MouseLeave += new System.EventHandler(this.textBoxMatchReqProfileID_MouseLeave);
            this.textBoxMatchReqProfileID.MouseHover += new System.EventHandler(this.textBoxMatchReqProfileID_MouseHover);
            // 
            // textBoxMatchReqNbrOutputClusters
            // 
            this.textBoxMatchReqNbrOutputClusters.Location = new System.Drawing.Point(534, 298);
            this.textBoxMatchReqNbrOutputClusters.Name = "textBoxMatchReqNbrOutputClusters";
            this.textBoxMatchReqNbrOutputClusters.Size = new System.Drawing.Size(96, 20);
            this.textBoxMatchReqNbrOutputClusters.TabIndex = 40;
            this.textBoxMatchReqNbrOutputClusters.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxMatchReqNbrOutputClusters_MouseClick);
            this.textBoxMatchReqNbrOutputClusters.Leave += new System.EventHandler(this.textBoxMatchReqNbrOutputClusters_Leave);
            this.textBoxMatchReqNbrOutputClusters.MouseLeave += new System.EventHandler(this.textBoxMatchReqNbrOutputClusters_MouseLeave);
            this.textBoxMatchReqNbrOutputClusters.MouseHover += new System.EventHandler(this.textBoxMatchReqNbrOutputClusters_MouseHover);
            // 
            // textBoxMatchReqNbrInputClusters
            // 
            this.textBoxMatchReqNbrInputClusters.Location = new System.Drawing.Point(319, 298);
            this.textBoxMatchReqNbrInputClusters.Name = "textBoxMatchReqNbrInputClusters";
            this.textBoxMatchReqNbrInputClusters.Size = new System.Drawing.Size(96, 20);
            this.textBoxMatchReqNbrInputClusters.TabIndex = 38;
            this.textBoxMatchReqNbrInputClusters.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxMatchReqNbrInputClusters_MouseClick);
            this.textBoxMatchReqNbrInputClusters.Leave += new System.EventHandler(this.textBoxMatchReqNbrInputClusters_Leave);
            this.textBoxMatchReqNbrInputClusters.MouseLeave += new System.EventHandler(this.textBoxMatchReqNbrInputClusters_MouseLeave);
            this.textBoxMatchReqNbrInputClusters.MouseHover += new System.EventHandler(this.textBoxMatchReqNbrInputClusters_MouseHover);
            // 
            // textBoxMatchReqAddr
            // 
            this.textBoxMatchReqAddr.Location = new System.Drawing.Point(93, 298);
            this.textBoxMatchReqAddr.Name = "textBoxMatchReqAddr";
            this.textBoxMatchReqAddr.Size = new System.Drawing.Size(106, 20);
            this.textBoxMatchReqAddr.TabIndex = 36;
            this.textBoxMatchReqAddr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxMatchReqAddr_MouseClick);
            this.textBoxMatchReqAddr.Leave += new System.EventHandler(this.textBoxMatchReqAddr_Leave);
            this.textBoxMatchReqAddr.MouseLeave += new System.EventHandler(this.textBoxMatchReqAddr_MouseLeave);
            this.textBoxMatchReqAddr.MouseHover += new System.EventHandler(this.textBoxMatchReqAddr_MouseHover);
            // 
            // textBoxActiveEpAddr
            // 
            this.textBoxActiveEpAddr.Location = new System.Drawing.Point(838, 8);
            this.textBoxActiveEpAddr.Name = "textBoxActiveEpAddr";
            this.textBoxActiveEpAddr.Size = new System.Drawing.Size(106, 20);
            this.textBoxActiveEpAddr.TabIndex = 57;
            this.textBoxActiveEpAddr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxActiveEpAddr_MouseClick);
            this.textBoxActiveEpAddr.Leave += new System.EventHandler(this.textBoxActiveEpAddr_Leave);
            this.textBoxActiveEpAddr.MouseLeave += new System.EventHandler(this.textBoxActiveEpAddr_MouseLeave);
            this.textBoxActiveEpAddr.MouseHover += new System.EventHandler(this.textBoxActiveEpAddr_MouseHover);
            // 
            // textBoxPowerReqAddr
            // 
            this.textBoxPowerReqAddr.Location = new System.Drawing.Point(838, 124);
            this.textBoxPowerReqAddr.Name = "textBoxPowerReqAddr";
            this.textBoxPowerReqAddr.Size = new System.Drawing.Size(106, 20);
            this.textBoxPowerReqAddr.TabIndex = 71;
            this.textBoxPowerReqAddr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxPowerReqAddr_MouseClick);
            this.textBoxPowerReqAddr.Leave += new System.EventHandler(this.textBoxPowerReqAddr_Leave);
            this.textBoxPowerReqAddr.MouseLeave += new System.EventHandler(this.textBoxPowerReqAddr_MouseLeave);
            this.textBoxPowerReqAddr.MouseHover += new System.EventHandler(this.textBoxPowerReqAddr_MouseHover);
            // 
            // textBoxSimpleReqEndPoint
            // 
            this.textBoxSimpleReqEndPoint.Location = new System.Drawing.Point(951, 153);
            this.textBoxSimpleReqEndPoint.Name = "textBoxSimpleReqEndPoint";
            this.textBoxSimpleReqEndPoint.Size = new System.Drawing.Size(106, 20);
            this.textBoxSimpleReqEndPoint.TabIndex = 74;
            this.textBoxSimpleReqEndPoint.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxSimpleReqEndPoint_MouseClick);
            this.textBoxSimpleReqEndPoint.Leave += new System.EventHandler(this.textBoxSimpleReqEndPoint_Leave);
            this.textBoxSimpleReqEndPoint.MouseLeave += new System.EventHandler(this.textBoxSimpleReqEndPoint_MouseLeave);
            this.textBoxSimpleReqEndPoint.MouseHover += new System.EventHandler(this.textBoxSimpleReqEndPoint_MouseHover);
            // 
            // textBoxSimpleReqAddr
            // 
            this.textBoxSimpleReqAddr.Location = new System.Drawing.Point(838, 153);
            this.textBoxSimpleReqAddr.Name = "textBoxSimpleReqAddr";
            this.textBoxSimpleReqAddr.Size = new System.Drawing.Size(106, 20);
            this.textBoxSimpleReqAddr.TabIndex = 73;
            this.textBoxSimpleReqAddr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxSimpleReqAddr_MouseClick);
            this.textBoxSimpleReqAddr.Leave += new System.EventHandler(this.textBoxSimpleReqAddr_Leave);
            this.textBoxSimpleReqAddr.MouseLeave += new System.EventHandler(this.textBoxSimpleReqAddr_MouseLeave);
            this.textBoxSimpleReqAddr.MouseHover += new System.EventHandler(this.textBoxSimpleReqAddr_MouseHover);
            // 
            // buttonMatchReq
            // 
            this.buttonMatchReq.Location = new System.Drawing.Point(6, 295);
            this.buttonMatchReq.Name = "buttonMatchReq";
            this.buttonMatchReq.Size = new System.Drawing.Size(80, 22);
            this.buttonMatchReq.TabIndex = 35;
            this.buttonMatchReq.Text = "Match Req";
            this.buttonMatchReq.UseVisualStyleBackColor = true;
            this.buttonMatchReq.Click += new System.EventHandler(this.buttonMatchReq_Click);
            // 
            // buttonActiveEpReq
            // 
            this.buttonActiveEpReq.Location = new System.Drawing.Point(752, 6);
            this.buttonActiveEpReq.Name = "buttonActiveEpReq";
            this.buttonActiveEpReq.Size = new System.Drawing.Size(80, 22);
            this.buttonActiveEpReq.TabIndex = 56;
            this.buttonActiveEpReq.Text = "Active Req";
            this.buttonActiveEpReq.UseVisualStyleBackColor = true;
            this.buttonActiveEpReq.Click += new System.EventHandler(this.buttonActiveEpReq_Click);
            // 
            // buttonPowerDescReq
            // 
            this.buttonPowerDescReq.Location = new System.Drawing.Point(752, 122);
            this.buttonPowerDescReq.Name = "buttonPowerDescReq";
            this.buttonPowerDescReq.Size = new System.Drawing.Size(80, 22);
            this.buttonPowerDescReq.TabIndex = 70;
            this.buttonPowerDescReq.Text = "Power Req";
            this.buttonPowerDescReq.UseVisualStyleBackColor = true;
            this.buttonPowerDescReq.Click += new System.EventHandler(this.buttonPowerDescReq_Click);
            // 
            // buttonSimpleDescReq
            // 
            this.buttonSimpleDescReq.Location = new System.Drawing.Point(752, 150);
            this.buttonSimpleDescReq.Name = "buttonSimpleDescReq";
            this.buttonSimpleDescReq.Size = new System.Drawing.Size(80, 22);
            this.buttonSimpleDescReq.TabIndex = 72;
            this.buttonSimpleDescReq.Text = "Simple Req";
            this.buttonSimpleDescReq.UseVisualStyleBackColor = true;
            this.buttonSimpleDescReq.Click += new System.EventHandler(this.buttonSimpleDescReq_Click);
            // 
            // textBoxNodeDescReq
            // 
            this.textBoxNodeDescReq.Location = new System.Drawing.Point(838, 94);
            this.textBoxNodeDescReq.Name = "textBoxNodeDescReq";
            this.textBoxNodeDescReq.Size = new System.Drawing.Size(106, 20);
            this.textBoxNodeDescReq.TabIndex = 69;
            this.textBoxNodeDescReq.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxNodeDescReq_MouseClick);
            this.textBoxNodeDescReq.Leave += new System.EventHandler(this.textBoxNodeDescReq_Leave);
            this.textBoxNodeDescReq.MouseLeave += new System.EventHandler(this.textBoxNodeDescReq_MouseLeave);
            this.textBoxNodeDescReq.MouseHover += new System.EventHandler(this.textBoxNodeDescReq_MouseHover);
            // 
            // buttonNodeDescReq
            // 
            this.buttonNodeDescReq.Location = new System.Drawing.Point(752, 93);
            this.buttonNodeDescReq.Name = "buttonNodeDescReq";
            this.buttonNodeDescReq.Size = new System.Drawing.Size(80, 22);
            this.buttonNodeDescReq.TabIndex = 68;
            this.buttonNodeDescReq.Text = "Node Req";
            this.buttonNodeDescReq.UseVisualStyleBackColor = true;
            this.buttonNodeDescReq.Click += new System.EventHandler(this.buttonNodeDescReq_Click);
            // 
            // buttonIeeeAddrReq
            // 
            this.buttonIeeeAddrReq.Location = new System.Drawing.Point(752, 34);
            this.buttonIeeeAddrReq.Name = "buttonIeeeAddrReq";
            this.buttonIeeeAddrReq.Size = new System.Drawing.Size(80, 22);
            this.buttonIeeeAddrReq.TabIndex = 58;
            this.buttonIeeeAddrReq.Text = "IEEE Req";
            this.buttonIeeeAddrReq.UseVisualStyleBackColor = true;
            this.buttonIeeeAddrReq.Click += new System.EventHandler(this.buttonIeeeAddrReq_Click);
            // 
            // buttonNwkAddrReq
            // 
            this.buttonNwkAddrReq.Location = new System.Drawing.Point(752, 63);
            this.buttonNwkAddrReq.Name = "buttonNwkAddrReq";
            this.buttonNwkAddrReq.Size = new System.Drawing.Size(80, 22);
            this.buttonNwkAddrReq.TabIndex = 63;
            this.buttonNwkAddrReq.Text = "Addr Req";
            this.buttonNwkAddrReq.UseVisualStyleBackColor = true;
            this.buttonNwkAddrReq.Click += new System.EventHandler(this.buttonNwkAddrReq_Click);
            // 
            // comboBoxSecurityKey
            // 
            this.comboBoxSecurityKey.FormattingEnabled = true;
            this.comboBoxSecurityKey.Location = new System.Drawing.Point(512, 94);
            this.comboBoxSecurityKey.Name = "comboBoxSecurityKey";
            this.comboBoxSecurityKey.Size = new System.Drawing.Size(237, 21);
            this.comboBoxSecurityKey.TabIndex = 15;
            // 
            // comboBoxPermitJoinTCsignificance
            // 
            this.comboBoxPermitJoinTCsignificance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPermitJoinTCsignificance.FormattingEnabled = true;
            this.comboBoxPermitJoinTCsignificance.Location = new System.Drawing.Point(319, 238);
            this.comboBoxPermitJoinTCsignificance.Name = "comboBoxPermitJoinTCsignificance";
            this.comboBoxPermitJoinTCsignificance.Size = new System.Drawing.Size(129, 21);
            this.comboBoxPermitJoinTCsignificance.TabIndex = 33;
            // 
            // textBoxPermitJoinInterval
            // 
            this.textBoxPermitJoinInterval.Location = new System.Drawing.Point(206, 238);
            this.textBoxPermitJoinInterval.Name = "textBoxPermitJoinInterval";
            this.textBoxPermitJoinInterval.Size = new System.Drawing.Size(106, 20);
            this.textBoxPermitJoinInterval.TabIndex = 32;
            this.textBoxPermitJoinInterval.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxPermitJoinInterval_MouseClick);
            this.textBoxPermitJoinInterval.Leave += new System.EventHandler(this.textBoxPermitJoinInterval_Leave);
            this.textBoxPermitJoinInterval.MouseLeave += new System.EventHandler(this.textBoxPermitJoinInterval_MouseLeave);
            this.textBoxPermitJoinInterval.MouseHover += new System.EventHandler(this.textBoxPermitJoinInterval_MouseHover);
            // 
            // textBoxPermitJoinAddr
            // 
            this.textBoxPermitJoinAddr.Location = new System.Drawing.Point(93, 238);
            this.textBoxPermitJoinAddr.Name = "textBoxPermitJoinAddr";
            this.textBoxPermitJoinAddr.Size = new System.Drawing.Size(106, 20);
            this.textBoxPermitJoinAddr.TabIndex = 31;
            this.textBoxPermitJoinAddr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxPermitJoinAddr_MouseClick);
            this.textBoxPermitJoinAddr.TextChanged += new System.EventHandler(this.textBoxPermitJoinAddr_TextChanged);
            this.textBoxPermitJoinAddr.Leave += new System.EventHandler(this.textBoxPermitJoinAddr_Leave);
            this.textBoxPermitJoinAddr.MouseLeave += new System.EventHandler(this.textBoxPermitJoinAddr_MouseLeave);
            this.textBoxPermitJoinAddr.MouseHover += new System.EventHandler(this.textBoxPermitJoinAddr_MouseHover);
            // 
            // buttonPermitJoin
            // 
            this.buttonPermitJoin.Location = new System.Drawing.Point(6, 238);
            this.buttonPermitJoin.Name = "buttonPermitJoin";
            this.buttonPermitJoin.Size = new System.Drawing.Size(80, 22);
            this.buttonPermitJoin.TabIndex = 30;
            this.buttonPermitJoin.Text = "Permit Join";
            this.buttonPermitJoin.UseVisualStyleBackColor = true;
            this.buttonPermitJoin.Click += new System.EventHandler(this.buttonPermitJoin_Click);
            // 
            // comboBoxSetKeyType
            // 
            this.comboBoxSetKeyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSetKeyType.FormattingEnabled = true;
            this.comboBoxSetKeyType.Location = new System.Drawing.Point(377, 93);
            this.comboBoxSetKeyType.Name = "comboBoxSetKeyType";
            this.comboBoxSetKeyType.Size = new System.Drawing.Size(129, 21);
            this.comboBoxSetKeyType.TabIndex = 14;
            // 
            // comboBoxSetKeyState
            // 
            this.comboBoxSetKeyState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSetKeyState.FormattingEnabled = true;
            this.comboBoxSetKeyState.Location = new System.Drawing.Point(95, 94);
            this.comboBoxSetKeyState.Name = "comboBoxSetKeyState";
            this.comboBoxSetKeyState.Size = new System.Drawing.Size(213, 21);
            this.comboBoxSetKeyState.TabIndex = 12;
            // 
            // comboBoxSetType
            // 
            this.comboBoxSetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSetType.FormattingEnabled = true;
            this.comboBoxSetType.Location = new System.Drawing.Point(95, 124);
            this.comboBoxSetType.Name = "comboBoxSetType";
            this.comboBoxSetType.Size = new System.Drawing.Size(213, 21);
            this.comboBoxSetType.TabIndex = 17;
            // 
            // buttonStartNWK
            // 
            this.buttonStartNWK.Location = new System.Drawing.Point(266, 6);
            this.buttonStartNWK.Name = "buttonStartNWK";
            this.buttonStartNWK.Size = new System.Drawing.Size(80, 22);
            this.buttonStartNWK.TabIndex = 4;
            this.buttonStartNWK.Text = "Start NWK";
            this.buttonStartNWK.UseVisualStyleBackColor = true;
            this.buttonStartNWK.Click += new System.EventHandler(this.buttonStartNWK_Click);
            // 
            // buttonBind
            // 
            this.buttonBind.Location = new System.Drawing.Point(6, 324);
            this.buttonBind.Name = "buttonBind";
            this.buttonBind.Size = new System.Drawing.Size(80, 22);
            this.buttonBind.TabIndex = 42;
            this.buttonBind.Text = "Bind";
            this.buttonBind.UseVisualStyleBackColor = true;
            this.buttonBind.Click += new System.EventHandler(this.buttonBind_Click);
            // 
            // buttonErasePD
            // 
            this.buttonErasePD.Location = new System.Drawing.Point(6, 6);
            this.buttonErasePD.Name = "buttonErasePD";
            this.buttonErasePD.Size = new System.Drawing.Size(80, 22);
            this.buttonErasePD.TabIndex = 1;
            this.buttonErasePD.Text = "Erase PD";
            this.buttonErasePD.UseVisualStyleBackColor = true;
            this.buttonErasePD.Click += new System.EventHandler(this.buttonErasePD_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(93, 6);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(80, 22);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // textBoxSetSecurityKeySeqNbr
            // 
            this.textBoxSetSecurityKeySeqNbr.Location = new System.Drawing.Point(314, 94);
            this.textBoxSetSecurityKeySeqNbr.Name = "textBoxSetSecurityKeySeqNbr";
            this.textBoxSetSecurityKeySeqNbr.Size = new System.Drawing.Size(55, 20);
            this.textBoxSetSecurityKeySeqNbr.TabIndex = 13;
            this.textBoxSetSecurityKeySeqNbr.Click += new System.EventHandler(this.textBoxSetSecurityKeySeqNbr_Click);
            this.textBoxSetSecurityKeySeqNbr.Leave += new System.EventHandler(this.textBoxSetSecurityKeySeqNbr_Leave);
            // 
            // buttonSetDeviceType
            // 
            this.buttonSetDeviceType.Location = new System.Drawing.Point(6, 122);
            this.buttonSetDeviceType.Name = "buttonSetDeviceType";
            this.buttonSetDeviceType.Size = new System.Drawing.Size(80, 22);
            this.buttonSetDeviceType.TabIndex = 16;
            this.buttonSetDeviceType.Text = "Set Type";
            this.buttonSetDeviceType.UseVisualStyleBackColor = true;
            this.buttonSetDeviceType.Click += new System.EventHandler(this.buttonSetDeviceType_Click);
            // 
            // buttonSetSecurity
            // 
            this.buttonSetSecurity.Location = new System.Drawing.Point(6, 93);
            this.buttonSetSecurity.Name = "buttonSetSecurity";
            this.buttonSetSecurity.Size = new System.Drawing.Size(80, 22);
            this.buttonSetSecurity.TabIndex = 11;
            this.buttonSetSecurity.Text = "Set Security";
            this.buttonSetSecurity.UseVisualStyleBackColor = true;
            this.buttonSetSecurity.Click += new System.EventHandler(this.buttonSetSecurity_Click);
            // 
            // textBoxSetEPID
            // 
            this.textBoxSetEPID.Location = new System.Drawing.Point(95, 37);
            this.textBoxSetEPID.Name = "textBoxSetEPID";
            this.textBoxSetEPID.Size = new System.Drawing.Size(213, 20);
            this.textBoxSetEPID.TabIndex = 8;
            this.textBoxSetEPID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxSetEPID_MouseClick);
            this.textBoxSetEPID.Leave += new System.EventHandler(this.textBoxSetEPID_Leave);
            this.textBoxSetEPID.MouseLeave += new System.EventHandler(this.textBoxSetEPID_MouseLeave);
            this.textBoxSetEPID.MouseHover += new System.EventHandler(this.textBoxSetEPID_MouseHover);
            // 
            // textBoxSetCMSK
            // 
            this.textBoxSetCMSK.Location = new System.Drawing.Point(95, 65);
            this.textBoxSetCMSK.Name = "textBoxSetCMSK";
            this.textBoxSetCMSK.Size = new System.Drawing.Size(213, 20);
            this.textBoxSetCMSK.TabIndex = 10;
            this.textBoxSetCMSK.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxSetCMSK_MouseClick);
            this.textBoxSetCMSK.Leave += new System.EventHandler(this.textBoxSetCMSK_Leave);
            this.textBoxSetCMSK.MouseLeave += new System.EventHandler(this.textBoxSetCMSK_MouseLeave);
            this.textBoxSetCMSK.MouseHover += new System.EventHandler(this.textBoxSetCMSK_MouseHover);
            // 
            // buttonSetCMSK
            // 
            this.buttonSetCMSK.Location = new System.Drawing.Point(6, 63);
            this.buttonSetCMSK.Name = "buttonSetCMSK";
            this.buttonSetCMSK.Size = new System.Drawing.Size(80, 22);
            this.buttonSetCMSK.TabIndex = 9;
            this.buttonSetCMSK.Text = "Set CMSK";
            this.buttonSetCMSK.UseVisualStyleBackColor = true;
            this.buttonSetCMSK.Click += new System.EventHandler(this.buttonSetCMSK_Click);
            // 
            // buttonSetEPID
            // 
            this.buttonSetEPID.Location = new System.Drawing.Point(6, 34);
            this.buttonSetEPID.Name = "buttonSetEPID";
            this.buttonSetEPID.Size = new System.Drawing.Size(80, 22);
            this.buttonSetEPID.TabIndex = 7;
            this.buttonSetEPID.Text = "Set EPID";
            this.buttonSetEPID.UseVisualStyleBackColor = true;
            this.buttonSetEPID.Click += new System.EventHandler(this.buttonSetEPID_Click);
            // 
            // buttonGetVersion
            // 
            this.buttonGetVersion.Location = new System.Drawing.Point(179, 6);
            this.buttonGetVersion.Name = "buttonGetVersion";
            this.buttonGetVersion.Size = new System.Drawing.Size(80, 22);
            this.buttonGetVersion.TabIndex = 3;
            this.buttonGetVersion.Text = "Get Version";
            this.buttonGetVersion.UseVisualStyleBackColor = true;
            this.buttonGetVersion.Click += new System.EventHandler(this.buttonGetVersion_Click);
            // 
            // tabPageDevice
            // 
            this.tabPageDevice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageDevice.Controls.Add(this.buttonCopyAddr);
            this.tabPageDevice.Controls.Add(this.buttonDiscoverDevices);
            this.tabPageDevice.Controls.Add(this.textBoxExtAddr);
            this.tabPageDevice.Controls.Add(this.label16);
            this.tabPageDevice.Controls.Add(this.comboBoxAddressList);
            this.tabPageDevice.Location = new System.Drawing.Point(4, 22);
            this.tabPageDevice.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageDevice.Name = "tabPageDevice";
            this.tabPageDevice.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageDevice.Size = new System.Drawing.Size(1351, 416);
            this.tabPageDevice.TabIndex = 18;
            this.tabPageDevice.Text = "Discover Devices";
            // 
            // buttonCopyAddr
            // 
            this.buttonCopyAddr.Location = new System.Drawing.Point(212, 86);
            this.buttonCopyAddr.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCopyAddr.Name = "buttonCopyAddr";
            this.buttonCopyAddr.Size = new System.Drawing.Size(97, 26);
            this.buttonCopyAddr.TabIndex = 3;
            this.buttonCopyAddr.Text = "Copy";
            this.buttonCopyAddr.UseVisualStyleBackColor = true;
            // 
            // buttonDiscoverDevices
            // 
            this.buttonDiscoverDevices.Location = new System.Drawing.Point(27, 30);
            this.buttonDiscoverDevices.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDiscoverDevices.Name = "buttonDiscoverDevices";
            this.buttonDiscoverDevices.Size = new System.Drawing.Size(180, 26);
            this.buttonDiscoverDevices.TabIndex = 0;
            this.buttonDiscoverDevices.Text = "Discover devices";
            this.buttonDiscoverDevices.UseVisualStyleBackColor = true;
            this.buttonDiscoverDevices.Click += new System.EventHandler(this.buttonDiscoverDevices_Click);
            // 
            // textBoxExtAddr
            // 
            this.textBoxExtAddr.Location = new System.Drawing.Point(27, 94);
            this.textBoxExtAddr.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxExtAddr.Name = "textBoxExtAddr";
            this.textBoxExtAddr.ReadOnly = true;
            this.textBoxExtAddr.Size = new System.Drawing.Size(181, 20);
            this.textBoxExtAddr.TabIndex = 2;
            this.textBoxExtAddr.Text = " ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 78);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Extended Address";
            // 
            // comboBoxAddressList
            // 
            this.comboBoxAddressList.FormattingEnabled = true;
            this.comboBoxAddressList.Location = new System.Drawing.Point(212, 34);
            this.comboBoxAddressList.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxAddressList.Name = "comboBoxAddressList";
            this.comboBoxAddressList.Size = new System.Drawing.Size(98, 21);
            this.comboBoxAddressList.TabIndex = 1;
            this.comboBoxAddressList.SelectedIndexChanged += new System.EventHandler(this.comboBoxAddressList_SelectedIndexChanged);
            // 
            // tabPage12
            // 
            this.tabPage12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage12.Controls.Add(this.textBoxOOBDataKey);
            this.tabPage12.Controls.Add(this.textBoxOOBDataAddr);
            this.tabPage12.Controls.Add(this.buttonOOBCommissioningData);
            this.tabPage12.Controls.Add(this.textBoxDiscoverAttributesStartAttrId);
            this.tabPage12.Controls.Add(this.textBoxRawDataCommandsProfileID);
            this.tabPage12.Controls.Add(this.textBoxRawDataCommandsSecurityMode);
            this.tabPage12.Controls.Add(this.textBoxRawDataCommandsRadius);
            this.tabPage12.Controls.Add(this.textBoxRawDataCommandsData);
            this.tabPage12.Controls.Add(this.textBoxRawDataCommandsClusterID);
            this.tabPage12.Controls.Add(this.textBoxRawDataCommandsDstEP);
            this.tabPage12.Controls.Add(this.textBoxRawDataCommandsSrcEP);
            this.tabPage12.Controls.Add(this.textBoxRawDataCommandsTargetAddr);
            this.tabPage12.Controls.Add(this.comboBoxRawDataCommandsAddrMode);
            this.tabPage12.Controls.Add(this.buttonRawDataSend);
            this.tabPage12.Controls.Add(this.textBoxMgmtNwkUpdateNwkManagerAddr);
            this.tabPage12.Controls.Add(this.comboBoxDiscoverCommandsRxGen);
            this.tabPage12.Controls.Add(this.comboBoxDiscoverAttributesExtended);
            this.tabPage12.Controls.Add(this.textBoxDiscoverCommandsMaxCommands);
            this.tabPage12.Controls.Add(this.textBoxDiscoverCommandsManuID);
            this.tabPage12.Controls.Add(this.comboBoxDiscoverCommandsManuSpecific);
            this.tabPage12.Controls.Add(this.textBoxDiscoverCommandsCommandID);
            this.tabPage12.Controls.Add(this.comboBoxDiscoverCommandsDirection);
            this.tabPage12.Controls.Add(this.textBoxDiscoverCommandsClusterID);
            this.tabPage12.Controls.Add(this.textBoxDiscoverCommandsDstEP);
            this.tabPage12.Controls.Add(this.textBoxDiscoverCommandsSrcEP);
            this.tabPage12.Controls.Add(this.textBoxDiscoverCommandsTargetAddr);
            this.tabPage12.Controls.Add(this.comboBoxDiscoverCommandsAddrMode);
            this.tabPage12.Controls.Add(this.buttonDiscoverCommands);
            this.tabPage12.Controls.Add(this.textBoxMgmtNwkUpdateScanCount);
            this.tabPage12.Controls.Add(this.textBoxMgmtNwkUpdateScanDuration);
            this.tabPage12.Controls.Add(this.textBoxMgmtNwkUpdateChannelMask);
            this.tabPage12.Controls.Add(this.textBoxMgmtNwkUpdateTargetAddr);
            this.tabPage12.Controls.Add(this.comboBoxMgmtNwkUpdateAddrMode);
            this.tabPage12.Controls.Add(this.buttonMgmtNwkUpdate);
            this.tabPage12.Controls.Add(this.comboBoxManyToOneRouteRequestCacheRoute);
            this.tabPage12.Controls.Add(this.textBoxManyToOneRouteRequesRadius);
            this.tabPage12.Controls.Add(this.buttonManyToOneRouteRequest);
            this.tabPage12.Controls.Add(this.comboBoxReadReportConfigDirection);
            this.tabPage12.Controls.Add(this.comboBoxReadReportConfigDirIsRx);
            this.tabPage12.Controls.Add(this.textBoxReadReportConfigAttribID);
            this.tabPage12.Controls.Add(this.textBoxReadReportConfigClusterID);
            this.tabPage12.Controls.Add(this.textBoxReadReportConfigDstEP);
            this.tabPage12.Controls.Add(this.textBoxReadReportConfigSrcEP);
            this.tabPage12.Controls.Add(this.textBoxReadReportConfigTargetAddr);
            this.tabPage12.Controls.Add(this.comboBoxReadReportConfigAddrMode);
            this.tabPage12.Controls.Add(this.buttonReadReportConfig);
            this.tabPage12.Controls.Add(this.textBoxWriteAttribManuID);
            this.tabPage12.Controls.Add(this.comboBoxWriteAttribManuSpecific);
            this.tabPage12.Controls.Add(this.textBoxWriteAttribDataType);
            this.tabPage12.Controls.Add(this.textBoxReadAttribManuID);
            this.tabPage12.Controls.Add(this.comboBoxReadAttribManuSpecific);
            this.tabPage12.Controls.Add(this.comboBoxConfigReportAddrMode);
            this.tabPage12.Controls.Add(this.textBoxWriteAttribData);
            this.tabPage12.Controls.Add(this.textBoxWriteAttribID);
            this.tabPage12.Controls.Add(this.comboBoxWriteAttribDirection);
            this.tabPage12.Controls.Add(this.textBoxWriteAttribClusterID);
            this.tabPage12.Controls.Add(this.textBoxWriteAttribDstEP);
            this.tabPage12.Controls.Add(this.textBoxWriteAttribSrcEP);
            this.tabPage12.Controls.Add(this.textBoxWriteAttribTargetAddr);
            this.tabPage12.Controls.Add(this.textBoxConfigReportChange);
            this.tabPage12.Controls.Add(this.textBoxConfigReportTimeOut);
            this.tabPage12.Controls.Add(this.textBoxConfigReportMaxInterval);
            this.tabPage12.Controls.Add(this.textBoxDiscoverAttributesMaxIDs);
            this.tabPage12.Controls.Add(this.comboBoxDiscoverAttributesDirection);
            this.tabPage12.Controls.Add(this.textBoxDiscoverAttributesClusterID);
            this.tabPage12.Controls.Add(this.textBoxDiscoverAttributesDstEp);
            this.tabPage12.Controls.Add(this.textBoxDiscoverAttributesSrcEp);
            this.tabPage12.Controls.Add(this.textBoxDiscoverAttributesAddr);
            this.tabPage12.Controls.Add(this.buttonDiscoverAttributes);
            this.tabPage12.Controls.Add(this.comboBoxReadAllAttribDirection);
            this.tabPage12.Controls.Add(this.textBoxReadAllAttribClusterID);
            this.tabPage12.Controls.Add(this.textBoxReadAllAttribDstEP);
            this.tabPage12.Controls.Add(this.textBoxReadAllAttribSrcEP);
            this.tabPage12.Controls.Add(this.textBoxReadAllAttribAddr);
            this.tabPage12.Controls.Add(this.buttonReadAllAttrib);
            this.tabPage12.Controls.Add(this.comboBoxConfigReportAttribDirection);
            this.tabPage12.Controls.Add(this.textBoxConfigReportAttribType);
            this.tabPage12.Controls.Add(this.textBoxConfigReportMinInterval);
            this.tabPage12.Controls.Add(this.textBoxConfigReportAttribID);
            this.tabPage12.Controls.Add(this.comboBoxConfigReportDirection);
            this.tabPage12.Controls.Add(this.textBoxConfigReportClusterID);
            this.tabPage12.Controls.Add(this.textBoxConfigReportDstEP);
            this.tabPage12.Controls.Add(this.textBoxConfigReportSrcEP);
            this.tabPage12.Controls.Add(this.textBoxConfigReportTargetAddr);
            this.tabPage12.Controls.Add(this.buttonConfigReport);
            this.tabPage12.Controls.Add(this.buttonWriteAttrib);
            this.tabPage12.Controls.Add(this.textBoxReadAttribCount);
            this.tabPage12.Controls.Add(this.comboBoxReadAttribDirection);
            this.tabPage12.Controls.Add(this.textBoxReadAttribID1);
            this.tabPage12.Controls.Add(this.textBoxReadAttribClusterID);
            this.tabPage12.Controls.Add(this.textBoxReadAttribDstEP);
            this.tabPage12.Controls.Add(this.textBoxReadAttribSrcEP);
            this.tabPage12.Controls.Add(this.textBoxReadAttribTargetAddr);
            this.tabPage12.Controls.Add(this.buttonReadAttrib);
            this.tabPage12.Location = new System.Drawing.Point(4, 22);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(1351, 416);
            this.tabPage12.TabIndex = 12;
            this.tabPage12.Text = "General";
            this.tabPage12.Click += new System.EventHandler(this.tabPage12_Click);
            // 
            // textBoxOOBDataKey
            // 
            this.textBoxOOBDataKey.Location = new System.Drawing.Point(270, 350);
            this.textBoxOOBDataKey.Name = "textBoxOOBDataKey";
            this.textBoxOOBDataKey.Size = new System.Drawing.Size(266, 20);
            this.textBoxOOBDataKey.TabIndex = 96;
            this.textBoxOOBDataKey.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxOOBDataKey_MouseClick);
            this.textBoxOOBDataKey.Leave += new System.EventHandler(this.textBoxOOBDataKey_Leave);
            this.textBoxOOBDataKey.MouseLeave += new System.EventHandler(this.textBoxOOBDataKey_MouseLeave);
            this.textBoxOOBDataKey.MouseHover += new System.EventHandler(this.textBoxOOBDataKey_MouseHover);
            // 
            // textBoxOOBDataAddr
            // 
            this.textBoxOOBDataAddr.Location = new System.Drawing.Point(158, 350);
            this.textBoxOOBDataAddr.Name = "textBoxOOBDataAddr";
            this.textBoxOOBDataAddr.Size = new System.Drawing.Size(106, 20);
            this.textBoxOOBDataAddr.TabIndex = 95;
            this.textBoxOOBDataAddr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxOOBDataAddr_MouseClick);
            this.textBoxOOBDataAddr.Leave += new System.EventHandler(this.textBoxOOBDataAddr_Leave);
            this.textBoxOOBDataAddr.MouseLeave += new System.EventHandler(this.textBoxOOBDataAddr_MouseLeave);
            this.textBoxOOBDataAddr.MouseHover += new System.EventHandler(this.textBoxOOBDataAddr_MouseHover);
            // 
            // buttonOOBCommissioningData
            // 
            this.buttonOOBCommissioningData.Location = new System.Drawing.Point(6, 348);
            this.buttonOOBCommissioningData.Name = "buttonOOBCommissioningData";
            this.buttonOOBCommissioningData.Size = new System.Drawing.Size(146, 22);
            this.buttonOOBCommissioningData.TabIndex = 91;
            this.buttonOOBCommissioningData.Text = "OOB Commissioning Data";
            this.buttonOOBCommissioningData.UseVisualStyleBackColor = true;
            this.buttonOOBCommissioningData.Click += new System.EventHandler(this.buttonOOBCommissioningData_Click);
            // 
            // textBoxDiscoverAttributesStartAttrId
            // 
            this.textBoxDiscoverAttributesStartAttrId.Location = new System.Drawing.Point(541, 210);
            this.textBoxDiscoverAttributesStartAttrId.Name = "textBoxDiscoverAttributesStartAttrId";
            this.textBoxDiscoverAttributesStartAttrId.Size = new System.Drawing.Size(110, 20);
            this.textBoxDiscoverAttributesStartAttrId.TabIndex = 55;
            this.textBoxDiscoverAttributesStartAttrId.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxDiscoverAttributesStartAttrId_MouseClick);
            this.textBoxDiscoverAttributesStartAttrId.Leave += new System.EventHandler(this.textBoxDiscoverAttributesStartAttrId_Leave);
            this.textBoxDiscoverAttributesStartAttrId.MouseLeave += new System.EventHandler(this.textBoxDiscoverAttributesStartAttrId_MouseLeave);
            this.textBoxDiscoverAttributesStartAttrId.MouseHover += new System.EventHandler(this.textBoxDiscoverAttributesStartAttrId_MouseHover);
            // 
            // textBoxRawDataCommandsProfileID
            // 
            this.textBoxRawDataCommandsProfileID.Location = new System.Drawing.Point(541, 320);
            this.textBoxRawDataCommandsProfileID.Name = "textBoxRawDataCommandsProfileID";
            this.textBoxRawDataCommandsProfileID.Size = new System.Drawing.Size(110, 20);
            this.textBoxRawDataCommandsProfileID.TabIndex = 86;
            this.textBoxRawDataCommandsProfileID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxRawDataCommandsProfileID_MouseClick);
            this.textBoxRawDataCommandsProfileID.Leave += new System.EventHandler(this.textBoxRawDataCommandsProfileID_Leave);
            this.textBoxRawDataCommandsProfileID.MouseLeave += new System.EventHandler(this.textBoxRawDataCommandsProfileID_MouseLeave);
            this.textBoxRawDataCommandsProfileID.MouseHover += new System.EventHandler(this.textBoxRawDataCommandsProfileID_MouseHover);
            // 
            // textBoxRawDataCommandsSecurityMode
            // 
            this.textBoxRawDataCommandsSecurityMode.Location = new System.Drawing.Point(884, 320);
            this.textBoxRawDataCommandsSecurityMode.Name = "textBoxRawDataCommandsSecurityMode";
            this.textBoxRawDataCommandsSecurityMode.Size = new System.Drawing.Size(208, 20);
            this.textBoxRawDataCommandsSecurityMode.TabIndex = 89;
            this.textBoxRawDataCommandsSecurityMode.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxRawDataCommandsSecurityMode_MouseClick);
            this.textBoxRawDataCommandsSecurityMode.Leave += new System.EventHandler(this.textBoxRawDataCommandsSecurityMode_Leave);
            this.textBoxRawDataCommandsSecurityMode.MouseLeave += new System.EventHandler(this.textBoxRawDataCommandsSecurityMode_MouseLeave);
            this.textBoxRawDataCommandsSecurityMode.MouseHover += new System.EventHandler(this.textBoxRawDataCommandsSecurityMode_MouseHover);
            // 
            // textBoxRawDataCommandsRadius
            // 
            this.textBoxRawDataCommandsRadius.Location = new System.Drawing.Point(771, 320);
            this.textBoxRawDataCommandsRadius.Name = "textBoxRawDataCommandsRadius";
            this.textBoxRawDataCommandsRadius.Size = new System.Drawing.Size(106, 20);
            this.textBoxRawDataCommandsRadius.TabIndex = 88;
            this.textBoxRawDataCommandsRadius.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxRawDataCommandsRadius_MouseClick);
            this.textBoxRawDataCommandsRadius.Leave += new System.EventHandler(this.textBoxRawDataCommandsRadius_Leave);
            this.textBoxRawDataCommandsRadius.MouseLeave += new System.EventHandler(this.textBoxRawDataCommandsRadius_MouseLeave);
            this.textBoxRawDataCommandsRadius.MouseHover += new System.EventHandler(this.textBoxRawDataCommandsRadius_MouseHover);
            // 
            // textBoxRawDataCommandsData
            // 
            this.textBoxRawDataCommandsData.Location = new System.Drawing.Point(1098, 320);
            this.textBoxRawDataCommandsData.Name = "textBoxRawDataCommandsData";
            this.textBoxRawDataCommandsData.Size = new System.Drawing.Size(248, 20);
            this.textBoxRawDataCommandsData.TabIndex = 90;
            this.textBoxRawDataCommandsData.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxRawDataCommandsData_MouseClick);
            this.textBoxRawDataCommandsData.Leave += new System.EventHandler(this.textBoxRawDataCommandsData_Leave);
            this.textBoxRawDataCommandsData.MouseLeave += new System.EventHandler(this.textBoxRawDataCommandsData_MouseLeave);
            this.textBoxRawDataCommandsData.MouseHover += new System.EventHandler(this.textBoxRawDataCommandsData_MouseHover);
            // 
            // textBoxRawDataCommandsClusterID
            // 
            this.textBoxRawDataCommandsClusterID.Location = new System.Drawing.Point(658, 320);
            this.textBoxRawDataCommandsClusterID.Name = "textBoxRawDataCommandsClusterID";
            this.textBoxRawDataCommandsClusterID.Size = new System.Drawing.Size(109, 20);
            this.textBoxRawDataCommandsClusterID.TabIndex = 87;
            this.textBoxRawDataCommandsClusterID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxRawDataCommandsClusterID_MouseClick);
            this.textBoxRawDataCommandsClusterID.Leave += new System.EventHandler(this.textBoxRawDataCommandsClusterID_Leave);
            this.textBoxRawDataCommandsClusterID.MouseLeave += new System.EventHandler(this.textBoxRawDataCommandsClusterID_MouseLeave);
            this.textBoxRawDataCommandsClusterID.MouseHover += new System.EventHandler(this.textBoxRawDataCommandsClusterID_MouseHover);
            // 
            // textBoxRawDataCommandsDstEP
            // 
            this.textBoxRawDataCommandsDstEP.Location = new System.Drawing.Point(432, 320);
            this.textBoxRawDataCommandsDstEP.Name = "textBoxRawDataCommandsDstEP";
            this.textBoxRawDataCommandsDstEP.Size = new System.Drawing.Size(103, 20);
            this.textBoxRawDataCommandsDstEP.TabIndex = 85;
            this.textBoxRawDataCommandsDstEP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxRawDataCommandsDstEP_MouseClick);
            this.textBoxRawDataCommandsDstEP.Leave += new System.EventHandler(this.textBoxRawDataCommandsDstEP_Leave);
            this.textBoxRawDataCommandsDstEP.MouseLeave += new System.EventHandler(this.textBoxRawDataCommandsDstEP_MouseLeave);
            this.textBoxRawDataCommandsDstEP.MouseHover += new System.EventHandler(this.textBoxRawDataCommandsDstEP_MouseHover);
            // 
            // textBoxRawDataCommandsSrcEP
            // 
            this.textBoxRawDataCommandsSrcEP.Location = new System.Drawing.Point(319, 320);
            this.textBoxRawDataCommandsSrcEP.Name = "textBoxRawDataCommandsSrcEP";
            this.textBoxRawDataCommandsSrcEP.Size = new System.Drawing.Size(106, 20);
            this.textBoxRawDataCommandsSrcEP.TabIndex = 84;
            this.textBoxRawDataCommandsSrcEP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxRawDataCommandsSrcEP_MouseClick);
            this.textBoxRawDataCommandsSrcEP.Leave += new System.EventHandler(this.textBoxRawDataCommandsSrcEP_Leave);
            this.textBoxRawDataCommandsSrcEP.MouseLeave += new System.EventHandler(this.textBoxRawDataCommandsSrcEP_MouseLeave);
            this.textBoxRawDataCommandsSrcEP.MouseHover += new System.EventHandler(this.textBoxRawDataCommandsSrcEP_MouseHover);
            // 
            // textBoxRawDataCommandsTargetAddr
            // 
            this.textBoxRawDataCommandsTargetAddr.Location = new System.Drawing.Point(208, 320);
            this.textBoxRawDataCommandsTargetAddr.Name = "textBoxRawDataCommandsTargetAddr";
            this.textBoxRawDataCommandsTargetAddr.Size = new System.Drawing.Size(106, 20);
            this.textBoxRawDataCommandsTargetAddr.TabIndex = 83;
            this.textBoxRawDataCommandsTargetAddr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxRawDataCommandsTargetAddr_MouseClick);
            this.textBoxRawDataCommandsTargetAddr.Leave += new System.EventHandler(this.textBoxRawDataCommandsTargetAddr_Leave);
            this.textBoxRawDataCommandsTargetAddr.MouseLeave += new System.EventHandler(this.textBoxRawDataCommandsTargetAddr_MouseLeave);
            this.textBoxRawDataCommandsTargetAddr.MouseHover += new System.EventHandler(this.textBoxRawDataCommandsTargetAddr_MouseHover);
            // 
            // comboBoxRawDataCommandsAddrMode
            // 
            this.comboBoxRawDataCommandsAddrMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRawDataCommandsAddrMode.FormattingEnabled = true;
            this.comboBoxRawDataCommandsAddrMode.Location = new System.Drawing.Point(108, 321);
            this.comboBoxRawDataCommandsAddrMode.Name = "comboBoxRawDataCommandsAddrMode";
            this.comboBoxRawDataCommandsAddrMode.Size = new System.Drawing.Size(94, 21);
            this.comboBoxRawDataCommandsAddrMode.TabIndex = 82;
            // 
            // buttonRawDataSend
            // 
            this.buttonRawDataSend.Location = new System.Drawing.Point(6, 320);
            this.buttonRawDataSend.Name = "buttonRawDataSend";
            this.buttonRawDataSend.Size = new System.Drawing.Size(95, 22);
            this.buttonRawDataSend.TabIndex = 81;
            this.buttonRawDataSend.Text = "Raw Data";
            this.buttonRawDataSend.UseVisualStyleBackColor = true;
            this.buttonRawDataSend.Click += new System.EventHandler(this.buttonRawDataSend_Click);
            // 
            // textBoxMgmtNwkUpdateNwkManagerAddr
            // 
            this.textBoxMgmtNwkUpdateNwkManagerAddr.Location = new System.Drawing.Point(658, 267);
            this.textBoxMgmtNwkUpdateNwkManagerAddr.Name = "textBoxMgmtNwkUpdateNwkManagerAddr";
            this.textBoxMgmtNwkUpdateNwkManagerAddr.Size = new System.Drawing.Size(141, 20);
            this.textBoxMgmtNwkUpdateNwkManagerAddr.TabIndex = 68;
            this.textBoxMgmtNwkUpdateNwkManagerAddr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxMgmtNwkUpdateNwkManagerAddr_MouseClick);
            this.textBoxMgmtNwkUpdateNwkManagerAddr.Leave += new System.EventHandler(this.textBoxMgmtNwkUpdateNwkManagerAddr_Leave);
            this.textBoxMgmtNwkUpdateNwkManagerAddr.MouseLeave += new System.EventHandler(this.textBoxMgmtNwkUpdateNwkManagerAddr_MouseLeave);
            this.textBoxMgmtNwkUpdateNwkManagerAddr.MouseHover += new System.EventHandler(this.textBoxMgmtNwkUpdateNwkManagerAddr_MouseHover);
            // 
            // comboBoxDiscoverCommandsRxGen
            // 
            this.comboBoxDiscoverCommandsRxGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiscoverCommandsRxGen.FormattingEnabled = true;
            this.comboBoxDiscoverCommandsRxGen.Location = new System.Drawing.Point(1217, 294);
            this.comboBoxDiscoverCommandsRxGen.Name = "comboBoxDiscoverCommandsRxGen";
            this.comboBoxDiscoverCommandsRxGen.Size = new System.Drawing.Size(96, 21);
            this.comboBoxDiscoverCommandsRxGen.TabIndex = 80;
            this.comboBoxDiscoverCommandsRxGen.MouseLeave += new System.EventHandler(this.comboBoxDiscoverCommandsRxGen_MouseLeave);
            this.comboBoxDiscoverCommandsRxGen.MouseHover += new System.EventHandler(this.comboBoxDiscoverCommandsRxGen_MouseHover);
            // 
            // comboBoxDiscoverAttributesExtended
            // 
            this.comboBoxDiscoverAttributesExtended.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiscoverAttributesExtended.FormattingEnabled = true;
            this.comboBoxDiscoverAttributesExtended.Location = new System.Drawing.Point(883, 209);
            this.comboBoxDiscoverAttributesExtended.Name = "comboBoxDiscoverAttributesExtended";
            this.comboBoxDiscoverAttributesExtended.Size = new System.Drawing.Size(106, 21);
            this.comboBoxDiscoverAttributesExtended.TabIndex = 58;
            this.comboBoxDiscoverAttributesExtended.MouseLeave += new System.EventHandler(this.comboBoxDiscoverAttributesExtended_MouseLeave);
            this.comboBoxDiscoverAttributesExtended.MouseHover += new System.EventHandler(this.comboBoxDiscoverAttributesExtended_MouseHover);
            // 
            // textBoxDiscoverCommandsMaxCommands
            // 
            this.textBoxDiscoverCommandsMaxCommands.Location = new System.Drawing.Point(1098, 294);
            this.textBoxDiscoverCommandsMaxCommands.Name = "textBoxDiscoverCommandsMaxCommands";
            this.textBoxDiscoverCommandsMaxCommands.Size = new System.Drawing.Size(112, 20);
            this.textBoxDiscoverCommandsMaxCommands.TabIndex = 79;
            this.textBoxDiscoverCommandsMaxCommands.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxDiscoverCommandsMaxCommands_MouseClick);
            this.textBoxDiscoverCommandsMaxCommands.Leave += new System.EventHandler(this.textBoxDiscoverCommandsMaxCommands_Leave);
            this.textBoxDiscoverCommandsMaxCommands.MouseLeave += new System.EventHandler(this.textBoxDiscoverCommandsMaxCommands_MouseLeave);
            this.textBoxDiscoverCommandsMaxCommands.MouseHover += new System.EventHandler(this.textBoxDiscoverCommandsMaxCommands_MouseHover);
            // 
            // textBoxDiscoverCommandsManuID
            // 
            this.textBoxDiscoverCommandsManuID.Location = new System.Drawing.Point(982, 294);
            this.textBoxDiscoverCommandsManuID.Name = "textBoxDiscoverCommandsManuID";
            this.textBoxDiscoverCommandsManuID.Size = new System.Drawing.Size(112, 20);
            this.textBoxDiscoverCommandsManuID.TabIndex = 78;
            this.textBoxDiscoverCommandsManuID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxDiscoverCommandsManuID_MouseClick);
            this.textBoxDiscoverCommandsManuID.Leave += new System.EventHandler(this.textBoxDiscoverCommandsManuID_Leave);
            this.textBoxDiscoverCommandsManuID.MouseLeave += new System.EventHandler(this.textBoxDiscoverCommandsManuID_MouseLeave);
            this.textBoxDiscoverCommandsManuID.MouseHover += new System.EventHandler(this.textBoxDiscoverCommandsManuID_MouseHover);
            // 
            // comboBoxDiscoverCommandsManuSpecific
            // 
            this.comboBoxDiscoverCommandsManuSpecific.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiscoverCommandsManuSpecific.FormattingEnabled = true;
            this.comboBoxDiscoverCommandsManuSpecific.Location = new System.Drawing.Point(884, 294);
            this.comboBoxDiscoverCommandsManuSpecific.Name = "comboBoxDiscoverCommandsManuSpecific";
            this.comboBoxDiscoverCommandsManuSpecific.Size = new System.Drawing.Size(91, 21);
            this.comboBoxDiscoverCommandsManuSpecific.TabIndex = 77;
            this.comboBoxDiscoverCommandsManuSpecific.MouseLeave += new System.EventHandler(this.comboBoxDiscoverCommandsManuSpecific_MouseLeave);
            this.comboBoxDiscoverCommandsManuSpecific.MouseHover += new System.EventHandler(this.comboBoxDiscoverCommandsManuSpecific_MouseHover);
            // 
            // textBoxDiscoverCommandsCommandID
            // 
            this.textBoxDiscoverCommandsCommandID.Location = new System.Drawing.Point(770, 294);
            this.textBoxDiscoverCommandsCommandID.Name = "textBoxDiscoverCommandsCommandID";
            this.textBoxDiscoverCommandsCommandID.Size = new System.Drawing.Size(109, 20);
            this.textBoxDiscoverCommandsCommandID.TabIndex = 76;
            this.textBoxDiscoverCommandsCommandID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxDiscoverCommandsCommandID_MouseClick);
            this.textBoxDiscoverCommandsCommandID.Leave += new System.EventHandler(this.textBoxDiscoverCommandsCommandID_Leave);
            this.textBoxDiscoverCommandsCommandID.MouseLeave += new System.EventHandler(this.textBoxDiscoverCommandsCommandID_MouseLeave);
            this.textBoxDiscoverCommandsCommandID.MouseHover += new System.EventHandler(this.textBoxDiscoverCommandsCommandID_MouseHover);
            // 
            // comboBoxDiscoverCommandsDirection
            // 
            this.comboBoxDiscoverCommandsDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiscoverCommandsDirection.FormattingEnabled = true;
            this.comboBoxDiscoverCommandsDirection.Location = new System.Drawing.Point(658, 294);
            this.comboBoxDiscoverCommandsDirection.Name = "comboBoxDiscoverCommandsDirection";
            this.comboBoxDiscoverCommandsDirection.Size = new System.Drawing.Size(106, 21);
            this.comboBoxDiscoverCommandsDirection.TabIndex = 75;
            this.comboBoxDiscoverCommandsDirection.MouseLeave += new System.EventHandler(this.comboBoxDiscoverCommandsDirection_MouseLeave);
            this.comboBoxDiscoverCommandsDirection.MouseHover += new System.EventHandler(this.comboBoxDiscoverCommandsDirection_MouseHover);
            // 
            // textBoxDiscoverCommandsClusterID
            // 
            this.textBoxDiscoverCommandsClusterID.Location = new System.Drawing.Point(538, 294);
            this.textBoxDiscoverCommandsClusterID.Name = "textBoxDiscoverCommandsClusterID";
            this.textBoxDiscoverCommandsClusterID.Size = new System.Drawing.Size(113, 20);
            this.textBoxDiscoverCommandsClusterID.TabIndex = 74;
            this.textBoxDiscoverCommandsClusterID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxDiscoverCommandsClusterID_MouseClick);
            this.textBoxDiscoverCommandsClusterID.Leave += new System.EventHandler(this.textBoxDiscoverCommandsClusterID_Leave);
            this.textBoxDiscoverCommandsClusterID.MouseLeave += new System.EventHandler(this.textBoxDiscoverCommandsClusterID_MouseLeave);
            this.textBoxDiscoverCommandsClusterID.MouseHover += new System.EventHandler(this.textBoxDiscoverCommandsClusterID_MouseHover);
            // 
            // textBoxDiscoverCommandsDstEP
            // 
            this.textBoxDiscoverCommandsDstEP.Location = new System.Drawing.Point(431, 294);
            this.textBoxDiscoverCommandsDstEP.Name = "textBoxDiscoverCommandsDstEP";
            this.textBoxDiscoverCommandsDstEP.Size = new System.Drawing.Size(103, 20);
            this.textBoxDiscoverCommandsDstEP.TabIndex = 73;
            this.textBoxDiscoverCommandsDstEP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxDiscoverCommandsDstEP_MouseClick);
            this.textBoxDiscoverCommandsDstEP.Leave += new System.EventHandler(this.textBoxDiscoverCommandsDstEP_Leave);
            this.textBoxDiscoverCommandsDstEP.MouseLeave += new System.EventHandler(this.textBoxDiscoverCommandsDstEP_MouseLeave);
            this.textBoxDiscoverCommandsDstEP.MouseHover += new System.EventHandler(this.textBoxDiscoverCommandsDstEP_MouseHover);
            // 
            // textBoxDiscoverCommandsSrcEP
            // 
            this.textBoxDiscoverCommandsSrcEP.Location = new System.Drawing.Point(319, 294);
            this.textBoxDiscoverCommandsSrcEP.Name = "textBoxDiscoverCommandsSrcEP";
            this.textBoxDiscoverCommandsSrcEP.Size = new System.Drawing.Size(106, 20);
            this.textBoxDiscoverCommandsSrcEP.TabIndex = 72;
            this.textBoxDiscoverCommandsSrcEP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxDiscoverCommandsSrcEP_MouseClick);
            this.textBoxDiscoverCommandsSrcEP.Leave += new System.EventHandler(this.textBoxDiscoverCommandsSrcEP_Leave);
            this.textBoxDiscoverCommandsSrcEP.MouseLeave += new System.EventHandler(this.textBoxDiscoverCommandsSrcEP_MouseLeave);
            this.textBoxDiscoverCommandsSrcEP.MouseHover += new System.EventHandler(this.textBoxDiscoverCommandsSrcEP_MouseHover);
            // 
            // textBoxDiscoverCommandsTargetAddr
            // 
            this.textBoxDiscoverCommandsTargetAddr.Location = new System.Drawing.Point(206, 294);
            this.textBoxDiscoverCommandsTargetAddr.Name = "textBoxDiscoverCommandsTargetAddr";
            this.textBoxDiscoverCommandsTargetAddr.Size = new System.Drawing.Size(106, 20);
            this.textBoxDiscoverCommandsTargetAddr.TabIndex = 71;
            this.textBoxDiscoverCommandsTargetAddr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxDiscoverCommandsTargetAddr_MouseClick);
            this.textBoxDiscoverCommandsTargetAddr.Leave += new System.EventHandler(this.textBoxDiscoverCommandsTargetAddr_Leave);
            this.textBoxDiscoverCommandsTargetAddr.MouseLeave += new System.EventHandler(this.textBoxDiscoverCommandsTargetAddr_MouseLeave);
            this.textBoxDiscoverCommandsTargetAddr.MouseHover += new System.EventHandler(this.textBoxDiscoverCommandsTargetAddr_MouseHover);
            // 
            // comboBoxDiscoverCommandsAddrMode
            // 
            this.comboBoxDiscoverCommandsAddrMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiscoverCommandsAddrMode.FormattingEnabled = true;
            this.comboBoxDiscoverCommandsAddrMode.Location = new System.Drawing.Point(108, 294);
            this.comboBoxDiscoverCommandsAddrMode.Name = "comboBoxDiscoverCommandsAddrMode";
            this.comboBoxDiscoverCommandsAddrMode.Size = new System.Drawing.Size(94, 21);
            this.comboBoxDiscoverCommandsAddrMode.TabIndex = 70;
            this.comboBoxDiscoverCommandsAddrMode.MouseLeave += new System.EventHandler(this.comboBoxDiscoverCommandsAddrMode_MouseLeave);
            this.comboBoxDiscoverCommandsAddrMode.MouseHover += new System.EventHandler(this.comboBoxDiscoverCommandsAddrMode_MouseHover);
            // 
            // buttonDiscoverCommands
            // 
            this.buttonDiscoverCommands.Location = new System.Drawing.Point(6, 293);
            this.buttonDiscoverCommands.Name = "buttonDiscoverCommands";
            this.buttonDiscoverCommands.Size = new System.Drawing.Size(95, 22);
            this.buttonDiscoverCommands.TabIndex = 69;
            this.buttonDiscoverCommands.Text = "Disc Cmds";
            this.buttonDiscoverCommands.UseVisualStyleBackColor = true;
            this.buttonDiscoverCommands.Click += new System.EventHandler(this.buttonDiscoverCommands_Click);
            // 
            // textBoxMgmtNwkUpdateScanCount
            // 
            this.textBoxMgmtNwkUpdateScanCount.Location = new System.Drawing.Point(538, 267);
            this.textBoxMgmtNwkUpdateScanCount.Name = "textBoxMgmtNwkUpdateScanCount";
            this.textBoxMgmtNwkUpdateScanCount.Size = new System.Drawing.Size(113, 20);
            this.textBoxMgmtNwkUpdateScanCount.TabIndex = 67;
            this.textBoxMgmtNwkUpdateScanCount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxMgmtNwkUpdateScanCount_MouseClick);
            this.textBoxMgmtNwkUpdateScanCount.Leave += new System.EventHandler(this.textBoxMgmtNwkUpdateScanCount_Leave);
            this.textBoxMgmtNwkUpdateScanCount.MouseLeave += new System.EventHandler(this.textBoxMgmtNwkUpdateScanCount_MouseLeave);
            this.textBoxMgmtNwkUpdateScanCount.MouseHover += new System.EventHandler(this.textBoxMgmtNwkUpdateScanCount_MouseHover);
            // 
            // textBoxMgmtNwkUpdateScanDuration
            // 
            this.textBoxMgmtNwkUpdateScanDuration.Location = new System.Drawing.Point(431, 267);
            this.textBoxMgmtNwkUpdateScanDuration.Name = "textBoxMgmtNwkUpdateScanDuration";
            this.textBoxMgmtNwkUpdateScanDuration.Size = new System.Drawing.Size(103, 20);
            this.textBoxMgmtNwkUpdateScanDuration.TabIndex = 66;
            this.textBoxMgmtNwkUpdateScanDuration.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxMgmtNwkUpdateScanDuration_MouseClick);
            this.textBoxMgmtNwkUpdateScanDuration.Leave += new System.EventHandler(this.textBoxMgmtNwkUpdateScanDuration_Leave);
            this.textBoxMgmtNwkUpdateScanDuration.MouseLeave += new System.EventHandler(this.textBoxMgmtNwkUpdateScanDuration_MouseLeave);
            this.textBoxMgmtNwkUpdateScanDuration.MouseHover += new System.EventHandler(this.textBoxMgmtNwkUpdateScanDuration_MouseHover);
            // 
            // textBoxMgmtNwkUpdateChannelMask
            // 
            this.textBoxMgmtNwkUpdateChannelMask.Location = new System.Drawing.Point(319, 267);
            this.textBoxMgmtNwkUpdateChannelMask.Name = "textBoxMgmtNwkUpdateChannelMask";
            this.textBoxMgmtNwkUpdateChannelMask.Size = new System.Drawing.Size(106, 20);
            this.textBoxMgmtNwkUpdateChannelMask.TabIndex = 65;
            this.textBoxMgmtNwkUpdateChannelMask.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxMgmtNwkUpdateChannelMask_MouseClick);
            this.textBoxMgmtNwkUpdateChannelMask.Leave += new System.EventHandler(this.textBoxMgmtNwkUpdateChannelMask_Leave);
            this.textBoxMgmtNwkUpdateChannelMask.MouseLeave += new System.EventHandler(this.textBoxMgmtNwkUpdateChannelMask_MouseLeave);
            this.textBoxMgmtNwkUpdateChannelMask.MouseHover += new System.EventHandler(this.textBoxMgmtNwkUpdateChannelMask_MouseHover);
            // 
            // textBoxMgmtNwkUpdateTargetAddr
            // 
            this.textBoxMgmtNwkUpdateTargetAddr.Location = new System.Drawing.Point(207, 267);
            this.textBoxMgmtNwkUpdateTargetAddr.Name = "textBoxMgmtNwkUpdateTargetAddr";
            this.textBoxMgmtNwkUpdateTargetAddr.Size = new System.Drawing.Size(106, 20);
            this.textBoxMgmtNwkUpdateTargetAddr.TabIndex = 64;
            this.textBoxMgmtNwkUpdateTargetAddr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxMgmtNwkUpdateTargetAddr_MouseClick);
            this.textBoxMgmtNwkUpdateTargetAddr.Leave += new System.EventHandler(this.textBoxMgmtNwkUpdateTargetAddr_Leave);
            this.textBoxMgmtNwkUpdateTargetAddr.MouseLeave += new System.EventHandler(this.textBoxMgmtNwkUpdateTargetAddr_MouseLeave);
            this.textBoxMgmtNwkUpdateTargetAddr.MouseHover += new System.EventHandler(this.textBoxMgmtNwkUpdateTargetAddr_MouseHover);
            // 
            // comboBoxMgmtNwkUpdateAddrMode
            // 
            this.comboBoxMgmtNwkUpdateAddrMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMgmtNwkUpdateAddrMode.FormattingEnabled = true;
            this.comboBoxMgmtNwkUpdateAddrMode.Location = new System.Drawing.Point(108, 267);
            this.comboBoxMgmtNwkUpdateAddrMode.Name = "comboBoxMgmtNwkUpdateAddrMode";
            this.comboBoxMgmtNwkUpdateAddrMode.Size = new System.Drawing.Size(94, 21);
            this.comboBoxMgmtNwkUpdateAddrMode.TabIndex = 63;
            this.comboBoxMgmtNwkUpdateAddrMode.MouseLeave += new System.EventHandler(this.comboBoxMgmtNwkUpdateAddrMode_MouseLeave);
            this.comboBoxMgmtNwkUpdateAddrMode.MouseHover += new System.EventHandler(this.comboBoxMgmtNwkUpdateAddrMode_MouseHover);
            // 
            // buttonMgmtNwkUpdate
            // 
            this.buttonMgmtNwkUpdate.Location = new System.Drawing.Point(6, 265);
            this.buttonMgmtNwkUpdate.Name = "buttonMgmtNwkUpdate";
            this.buttonMgmtNwkUpdate.Size = new System.Drawing.Size(95, 22);
            this.buttonMgmtNwkUpdate.TabIndex = 62;
            this.buttonMgmtNwkUpdate.Text = "NWK Update";
            this.buttonMgmtNwkUpdate.UseVisualStyleBackColor = true;
            this.buttonMgmtNwkUpdate.Click += new System.EventHandler(this.buttonMgmtNwkUpdate_Click);
            // 
            // comboBoxManyToOneRouteRequestCacheRoute
            // 
            this.comboBoxManyToOneRouteRequestCacheRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManyToOneRouteRequestCacheRoute.FormattingEnabled = true;
            this.comboBoxManyToOneRouteRequestCacheRoute.Location = new System.Drawing.Point(108, 238);
            this.comboBoxManyToOneRouteRequestCacheRoute.Name = "comboBoxManyToOneRouteRequestCacheRoute";
            this.comboBoxManyToOneRouteRequestCacheRoute.Size = new System.Drawing.Size(91, 21);
            this.comboBoxManyToOneRouteRequestCacheRoute.TabIndex = 60;
            this.comboBoxManyToOneRouteRequestCacheRoute.MouseLeave += new System.EventHandler(this.comboBoxManyToOneRouteRequestCacheRoute_MouseLeave);
            this.comboBoxManyToOneRouteRequestCacheRoute.MouseHover += new System.EventHandler(this.comboBoxManyToOneRouteRequestCacheRoute_MouseHover);
            // 
            // textBoxManyToOneRouteRequesRadius
            // 
            this.textBoxManyToOneRouteRequesRadius.Location = new System.Drawing.Point(207, 238);
            this.textBoxManyToOneRouteRequesRadius.Name = "textBoxManyToOneRouteRequesRadius";
            this.textBoxManyToOneRouteRequesRadius.Size = new System.Drawing.Size(106, 20);
            this.textBoxManyToOneRouteRequesRadius.TabIndex = 61;
            this.textBoxManyToOneRouteRequesRadius.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxManyToOneRouteRequesRadius_MouseClick);
            this.textBoxManyToOneRouteRequesRadius.Leave += new System.EventHandler(this.textBoxManyToOneRouteRequesRadius_Leave);
            this.textBoxManyToOneRouteRequesRadius.MouseLeave += new System.EventHandler(this.textBoxManyToOneRouteRequesRadius_MouseLeave);
            this.textBoxManyToOneRouteRequesRadius.MouseHover += new System.EventHandler(this.textBoxManyToOneRouteRequesRadius_MouseHover);
            // 
            // buttonManyToOneRouteRequest
            // 
            this.buttonManyToOneRouteRequest.Location = new System.Drawing.Point(6, 235);
            this.buttonManyToOneRouteRequest.Name = "buttonManyToOneRouteRequest";
            this.buttonManyToOneRouteRequest.Size = new System.Drawing.Size(95, 24);
            this.buttonManyToOneRouteRequest.TabIndex = 59;
            this.buttonManyToOneRouteRequest.Text = "MTO Rt Req";
            this.buttonManyToOneRouteRequest.UseVisualStyleBackColor = true;
            this.buttonManyToOneRouteRequest.Click += new System.EventHandler(this.buttonManyToOneRouteRequest_Click);
            // 
            // comboBoxReadReportConfigDirection
            // 
            this.comboBoxReadReportConfigDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReadReportConfigDirection.FormattingEnabled = true;
            this.comboBoxReadReportConfigDirection.Location = new System.Drawing.Point(654, 152);
            this.comboBoxReadReportConfigDirection.Name = "comboBoxReadReportConfigDirection";
            this.comboBoxReadReportConfigDirection.Size = new System.Drawing.Size(110, 21);
            this.comboBoxReadReportConfigDirection.TabIndex = 41;
            this.comboBoxReadReportConfigDirection.MouseLeave += new System.EventHandler(this.comboBoxReadReportConfigDirection_MouseLeave);
            this.comboBoxReadReportConfigDirection.MouseHover += new System.EventHandler(this.comboBoxReadReportConfigDirection_MouseHover);
            // 
            // comboBoxReadReportConfigDirIsRx
            // 
            this.comboBoxReadReportConfigDirIsRx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReadReportConfigDirIsRx.FormattingEnabled = true;
            this.comboBoxReadReportConfigDirIsRx.Location = new System.Drawing.Point(884, 152);
            this.comboBoxReadReportConfigDirIsRx.Name = "comboBoxReadReportConfigDirIsRx";
            this.comboBoxReadReportConfigDirIsRx.Size = new System.Drawing.Size(106, 21);
            this.comboBoxReadReportConfigDirIsRx.TabIndex = 43;
            this.comboBoxReadReportConfigDirIsRx.MouseLeave += new System.EventHandler(this.comboBoxReadReportConfigDirIsRx_MouseLeave);
            this.comboBoxReadReportConfigDirIsRx.MouseHover += new System.EventHandler(this.comboBoxReadReportConfigDirIsRx_MouseHover);
            // 
            // textBoxReadReportConfigAttribID
            // 
            this.textBoxReadReportConfigAttribID.Location = new System.Drawing.Point(770, 153);
            this.textBoxReadReportConfigAttribID.Name = "textBoxReadReportConfigAttribID";
            this.textBoxReadReportConfigAttribID.Size = new System.Drawing.Size(107, 20);
            this.textBoxReadReportConfigAttribID.TabIndex = 42;
            this.textBoxReadReportConfigAttribID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxReadReportConfigAttribID_MouseClick);
            this.textBoxReadReportConfigAttribID.Leave += new System.EventHandler(this.textBoxReadReportConfigAttribID_Leave);
            this.textBoxReadReportConfigAttribID.MouseLeave += new System.EventHandler(this.textBoxReadReportConfigAttribID_MouseLeave);
            this.textBoxReadReportConfigAttribID.MouseHover += new System.EventHandler(this.textBoxReadReportConfigAttribID_MouseHover);
            // 
            // textBoxReadReportConfigClusterID
            // 
            this.textBoxReadReportConfigClusterID.Location = new System.Drawing.Point(545, 153);
            this.textBoxReadReportConfigClusterID.Name = "textBoxReadReportConfigClusterID";
            this.textBoxReadReportConfigClusterID.Size = new System.Drawing.Size(106, 20);
            this.textBoxReadReportConfigClusterID.TabIndex = 40;
            this.textBoxReadReportConfigClusterID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxReadReportConfigClusterID_MouseClick);
            this.textBoxReadReportConfigClusterID.Leave += new System.EventHandler(this.textBoxReadReportConfigClusterID_Leave);
            this.textBoxReadReportConfigClusterID.MouseLeave += new System.EventHandler(this.textBoxReadReportConfigClusterID_MouseLeave);
            this.textBoxReadReportConfigClusterID.MouseHover += new System.EventHandler(this.textBoxReadReportConfigClusterID_MouseHover);
            // 
            // textBoxReadReportConfigDstEP
            // 
            this.textBoxReadReportConfigDstEP.Location = new System.Drawing.Point(432, 153);
            this.textBoxReadReportConfigDstEP.Name = "textBoxReadReportConfigDstEP";
            this.textBoxReadReportConfigDstEP.Size = new System.Drawing.Size(106, 20);
            this.textBoxReadReportConfigDstEP.TabIndex = 39;
            this.textBoxReadReportConfigDstEP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxReadReportConfigDstEP_MouseClick);
            this.textBoxReadReportConfigDstEP.Leave += new System.EventHandler(this.textBoxReadReportConfigDstEP_Leave);
            this.textBoxReadReportConfigDstEP.MouseLeave += new System.EventHandler(this.textBoxReadReportConfigDstEP_MouseLeave);
            this.textBoxReadReportConfigDstEP.MouseHover += new System.EventHandler(this.textBoxReadReportConfigDstEP_MouseHover);
            // 
            // textBoxReadReportConfigSrcEP
            // 
            this.textBoxReadReportConfigSrcEP.Location = new System.Drawing.Point(318, 153);
            this.textBoxReadReportConfigSrcEP.Name = "textBoxReadReportConfigSrcEP";
            this.textBoxReadReportConfigSrcEP.Size = new System.Drawing.Size(106, 20);
            this.textBoxReadReportConfigSrcEP.TabIndex = 38;
            this.textBoxReadReportConfigSrcEP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxReadReportConfigSrcEP_MouseClick);
            this.textBoxReadReportConfigSrcEP.Leave += new System.EventHandler(this.textBoxReadReportConfigSrcEP_Leave);
            this.textBoxReadReportConfigSrcEP.MouseLeave += new System.EventHandler(this.textBoxReadReportConfigSrcEP_MouseLeave);
            this.textBoxReadReportConfigSrcEP.MouseHover += new System.EventHandler(this.textBoxReadReportConfigSrcEP_MouseHover);
            // 
            // textBoxReadReportConfigTargetAddr
            // 
            this.textBoxReadReportConfigTargetAddr.Location = new System.Drawing.Point(205, 153);
            this.textBoxReadReportConfigTargetAddr.Name = "textBoxReadReportConfigTargetAddr";
            this.textBoxReadReportConfigTargetAddr.Size = new System.Drawing.Size(106, 20);
            this.textBoxReadReportConfigTargetAddr.TabIndex = 37;
            this.textBoxReadReportConfigTargetAddr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxReadReportConfigTargetAddr_MouseClick);
            this.textBoxReadReportConfigTargetAddr.Leave += new System.EventHandler(this.textBoxReadReportConfigTargetAddr_Leave);
            this.textBoxReadReportConfigTargetAddr.MouseLeave += new System.EventHandler(this.textBoxReadReportConfigTargetAddr_MouseLeave);
            this.textBoxReadReportConfigTargetAddr.MouseHover += new System.EventHandler(this.textBoxReadReportConfigTargetAddr_MouseHover);
            // 
            // comboBoxReadReportConfigAddrMode
            // 
            this.comboBoxReadReportConfigAddrMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReadReportConfigAddrMode.FormattingEnabled = true;
            this.comboBoxReadReportConfigAddrMode.Location = new System.Drawing.Point(93, 153);
            this.comboBoxReadReportConfigAddrMode.Name = "comboBoxReadReportConfigAddrMode";
            this.comboBoxReadReportConfigAddrMode.Size = new System.Drawing.Size(106, 21);
            this.comboBoxReadReportConfigAddrMode.TabIndex = 36;
            this.comboBoxReadReportConfigAddrMode.MouseLeave += new System.EventHandler(this.comboBoxReadReportConfigAddrMode_MouseLeave);
            this.comboBoxReadReportConfigAddrMode.MouseHover += new System.EventHandler(this.comboBoxReadReportConfigAddrMode_MouseHover);
            // 
            // buttonReadReportConfig
            // 
            this.buttonReadReportConfig.Location = new System.Drawing.Point(6, 150);
            this.buttonReadReportConfig.Name = "buttonReadReportConfig";
            this.buttonReadReportConfig.Size = new System.Drawing.Size(80, 24);
            this.buttonReadReportConfig.TabIndex = 35;
            this.buttonReadReportConfig.Text = "Read Rprt";
            this.buttonReadReportConfig.UseVisualStyleBackColor = true;
            this.buttonReadReportConfig.Click += new System.EventHandler(this.buttonReadReportConfig_Click);
            // 
            // textBoxWriteAttribManuID
            // 
            this.textBoxWriteAttribManuID.Location = new System.Drawing.Point(1110, 37);
            this.textBoxWriteAttribManuID.Name = "textBoxWriteAttribManuID";
            this.textBoxWriteAttribManuID.Size = new System.Drawing.Size(106, 20);
            this.textBoxWriteAttribManuID.TabIndex = 20;
            this.textBoxWriteAttribManuID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxWriteAttribManuID_MouseClick);
            this.textBoxWriteAttribManuID.Leave += new System.EventHandler(this.textBoxWriteAttribManuID_Leave);
            this.textBoxWriteAttribManuID.MouseLeave += new System.EventHandler(this.textBoxWriteAttribManuID_MouseLeave);
            this.textBoxWriteAttribManuID.MouseHover += new System.EventHandler(this.textBoxWriteAttribManuID_MouseHover);
            // 
            // comboBoxWriteAttribManuSpecific
            // 
            this.comboBoxWriteAttribManuSpecific.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWriteAttribManuSpecific.FormattingEnabled = true;
            this.comboBoxWriteAttribManuSpecific.Location = new System.Drawing.Point(998, 37);
            this.comboBoxWriteAttribManuSpecific.Name = "comboBoxWriteAttribManuSpecific";
            this.comboBoxWriteAttribManuSpecific.Size = new System.Drawing.Size(106, 21);
            this.comboBoxWriteAttribManuSpecific.TabIndex = 19;
            this.comboBoxWriteAttribManuSpecific.MouseLeave += new System.EventHandler(this.comboBoxWriteAttribManuSpecific_MouseLeave);
            this.comboBoxWriteAttribManuSpecific.MouseHover += new System.EventHandler(this.comboBoxWriteAttribManuSpecific_MouseHover);
            // 
            // textBoxWriteAttribDataType
            // 
            this.textBoxWriteAttribDataType.Location = new System.Drawing.Point(771, 37);
            this.textBoxWriteAttribDataType.Name = "textBoxWriteAttribDataType";
            this.textBoxWriteAttribDataType.Size = new System.Drawing.Size(107, 20);
            this.textBoxWriteAttribDataType.TabIndex = 17;
            this.textBoxWriteAttribDataType.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxWriteAttribDataType_MouseClick);
            this.textBoxWriteAttribDataType.Leave += new System.EventHandler(this.textBoxWriteAttribDataType_Leave);
            this.textBoxWriteAttribDataType.MouseLeave += new System.EventHandler(this.textBoxWriteAttribDataType_MouseLeave);
            this.textBoxWriteAttribDataType.MouseHover += new System.EventHandler(this.textBoxWriteAttribDataType_MouseHover);
            // 
            // textBoxReadAttribManuID
            // 
            this.textBoxReadAttribManuID.Location = new System.Drawing.Point(998, 8);
            this.textBoxReadAttribManuID.Name = "textBoxReadAttribManuID";
            this.textBoxReadAttribManuID.Size = new System.Drawing.Size(106, 20);
            this.textBoxReadAttribManuID.TabIndex = 9;
            this.textBoxReadAttribManuID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxReadAttribManuID_MouseClick);
            this.textBoxReadAttribManuID.Leave += new System.EventHandler(this.textBoxReadAttribManuID_Leave);
            this.textBoxReadAttribManuID.MouseLeave += new System.EventHandler(this.textBoxReadAttribManuID_MouseLeave);
            this.textBoxReadAttribManuID.MouseHover += new System.EventHandler(this.textBoxReadAttribManuID_MouseHover);
            // 
            // comboBoxReadAttribManuSpecific
            // 
            this.comboBoxReadAttribManuSpecific.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReadAttribManuSpecific.FormattingEnabled = true;
            this.comboBoxReadAttribManuSpecific.Location = new System.Drawing.Point(884, 8);
            this.comboBoxReadAttribManuSpecific.Name = "comboBoxReadAttribManuSpecific";
            this.comboBoxReadAttribManuSpecific.Size = new System.Drawing.Size(106, 21);
            this.comboBoxReadAttribManuSpecific.TabIndex = 8;
            this.comboBoxReadAttribManuSpecific.MouseLeave += new System.EventHandler(this.comboBoxReadAttribManuSpecific_MouseLeave);
            this.comboBoxReadAttribManuSpecific.MouseHover += new System.EventHandler(this.comboBoxReadAttribManuSpecific_MouseHover);
            // 
            // comboBoxConfigReportAddrMode
            // 
            this.comboBoxConfigReportAddrMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConfigReportAddrMode.FormattingEnabled = true;
            this.comboBoxConfigReportAddrMode.Location = new System.Drawing.Point(93, 66);
            this.comboBoxConfigReportAddrMode.Name = "comboBoxConfigReportAddrMode";
            this.comboBoxConfigReportAddrMode.Size = new System.Drawing.Size(106, 21);
            this.comboBoxConfigReportAddrMode.TabIndex = 22;
            this.comboBoxConfigReportAddrMode.MouseLeave += new System.EventHandler(this.comboBoxConfigReportAddrMode_MouseLeave);
            this.comboBoxConfigReportAddrMode.MouseHover += new System.EventHandler(this.comboBoxConfigReportAddrMode_MouseHover);
            // 
            // textBoxWriteAttribData
            // 
            this.textBoxWriteAttribData.Location = new System.Drawing.Point(884, 37);
            this.textBoxWriteAttribData.Name = "textBoxWriteAttribData";
            this.textBoxWriteAttribData.Size = new System.Drawing.Size(106, 20);
            this.textBoxWriteAttribData.TabIndex = 18;
            this.textBoxWriteAttribData.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxWriteAttribData_MouseClick);
            this.textBoxWriteAttribData.Leave += new System.EventHandler(this.textBoxWriteAttribData_Leave);
            this.textBoxWriteAttribData.MouseLeave += new System.EventHandler(this.textBoxWriteAttribData_MouseLeave);
            this.textBoxWriteAttribData.MouseHover += new System.EventHandler(this.textBoxWriteAttribData_MouseHover);
            // 
            // textBoxWriteAttribID
            // 
            this.textBoxWriteAttribID.Location = new System.Drawing.Point(658, 37);
            this.textBoxWriteAttribID.Name = "textBoxWriteAttribID";
            this.textBoxWriteAttribID.Size = new System.Drawing.Size(106, 20);
            this.textBoxWriteAttribID.TabIndex = 16;
            this.textBoxWriteAttribID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxWriteAttribID_MouseClick);
            this.textBoxWriteAttribID.Leave += new System.EventHandler(this.textBoxWriteAttribID_Leave);
            this.textBoxWriteAttribID.MouseLeave += new System.EventHandler(this.textBoxWriteAttribID_MouseLeave);
            this.textBoxWriteAttribID.MouseHover += new System.EventHandler(this.textBoxWriteAttribID_MouseHover);
            // 
            // comboBoxWriteAttribDirection
            // 
            this.comboBoxWriteAttribDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWriteAttribDirection.FormattingEnabled = true;
            this.comboBoxWriteAttribDirection.Location = new System.Drawing.Point(545, 37);
            this.comboBoxWriteAttribDirection.Name = "comboBoxWriteAttribDirection";
            this.comboBoxWriteAttribDirection.Size = new System.Drawing.Size(106, 21);
            this.comboBoxWriteAttribDirection.TabIndex = 15;
            this.comboBoxWriteAttribDirection.MouseLeave += new System.EventHandler(this.comboBoxWriteAttribDirection_MouseLeave);
            this.comboBoxWriteAttribDirection.MouseHover += new System.EventHandler(this.comboBoxWriteAttribDirection_MouseHover);
            // 
            // textBoxWriteAttribClusterID
            // 
            this.textBoxWriteAttribClusterID.Location = new System.Drawing.Point(432, 37);
            this.textBoxWriteAttribClusterID.Name = "textBoxWriteAttribClusterID";
            this.textBoxWriteAttribClusterID.Size = new System.Drawing.Size(106, 20);
            this.textBoxWriteAttribClusterID.TabIndex = 14;
            this.textBoxWriteAttribClusterID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxWriteAttribClusterID_MouseClick);
            this.textBoxWriteAttribClusterID.Leave += new System.EventHandler(this.textBoxWriteAttribClusterID_Leave);
            this.textBoxWriteAttribClusterID.MouseLeave += new System.EventHandler(this.textBoxWriteAttribClusterID_MouseLeave);
            this.textBoxWriteAttribClusterID.MouseHover += new System.EventHandler(this.textBoxWriteAttribClusterID_MouseHover);
            // 
            // textBoxWriteAttribDstEP
            // 
            this.textBoxWriteAttribDstEP.Location = new System.Drawing.Point(319, 37);
            this.textBoxWriteAttribDstEP.Name = "textBoxWriteAttribDstEP";
            this.textBoxWriteAttribDstEP.Size = new System.Drawing.Size(106, 20);
            this.textBoxWriteAttribDstEP.TabIndex = 13;
            this.textBoxWriteAttribDstEP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxWriteAttribDstEP_MouseClick);
            this.textBoxWriteAttribDstEP.Leave += new System.EventHandler(this.textBoxWriteAttribDstEP_Leave);
            this.textBoxWriteAttribDstEP.MouseLeave += new System.EventHandler(this.textBoxWriteAttribDstEP_MouseLeave);
            this.textBoxWriteAttribDstEP.MouseHover += new System.EventHandler(this.textBoxWriteAttribDstEP_MouseHover);
            // 
            // textBoxWriteAttribSrcEP
            // 
            this.textBoxWriteAttribSrcEP.Location = new System.Drawing.Point(206, 37);
            this.textBoxWriteAttribSrcEP.Name = "textBoxWriteAttribSrcEP";
            this.textBoxWriteAttribSrcEP.Size = new System.Drawing.Size(106, 20);
            this.textBoxWriteAttribSrcEP.TabIndex = 12;
            this.textBoxWriteAttribSrcEP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxWriteAttribSrcEP_MouseClick);
            this.textBoxWriteAttribSrcEP.Leave += new System.EventHandler(this.textBoxWriteAttribSrcEP_Leave);
            this.textBoxWriteAttribSrcEP.MouseLeave += new System.EventHandler(this.textBoxWriteAttribSrcEP_MouseLeave);
            this.textBoxWriteAttribSrcEP.MouseHover += new System.EventHandler(this.textBoxWriteAttribSrcEP_MouseHover);
            // 
            // textBoxWriteAttribTargetAddr
            // 
            this.textBoxWriteAttribTargetAddr.Location = new System.Drawing.Point(93, 37);
            this.textBoxWriteAttribTargetAddr.Name = "textBoxWriteAttribTargetAddr";
            this.textBoxWriteAttribTargetAddr.Size = new System.Drawing.Size(106, 20);
            this.textBoxWriteAttribTargetAddr.TabIndex = 11;
            this.textBoxWriteAttribTargetAddr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxWriteAttribTargetAddr_MouseClick);
            this.textBoxWriteAttribTargetAddr.Leave += new System.EventHandler(this.textBoxWriteAttribTargetAddr_Leave);
            this.textBoxWriteAttribTargetAddr.MouseLeave += new System.EventHandler(this.textBoxWriteAttribTargetAddr_MouseLeave);
            this.textBoxWriteAttribTargetAddr.MouseHover += new System.EventHandler(this.textBoxWriteAttribTargetAddr_MouseHover);
            // 
            // textBoxConfigReportChange
            // 
            this.textBoxConfigReportChange.Location = new System.Drawing.Point(998, 117);
            this.textBoxConfigReportChange.Name = "textBoxConfigReportChange";
            this.textBoxConfigReportChange.Size = new System.Drawing.Size(106, 20);
            this.textBoxConfigReportChange.TabIndex = 34;
            this.textBoxConfigReportChange.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxConfigReportChange_MouseClick);
            this.textBoxConfigReportChange.Leave += new System.EventHandler(this.textBoxConfigReportChange_Leave);
            this.textBoxConfigReportChange.MouseLeave += new System.EventHandler(this.textBoxConfigReportChange_MouseLeave);
            this.textBoxConfigReportChange.MouseHover += new System.EventHandler(this.textBoxConfigReportChange_MouseHover);
            // 
            // textBoxConfigReportTimeOut
            // 
            this.textBoxConfigReportTimeOut.Location = new System.Drawing.Point(886, 117);
            this.textBoxConfigReportTimeOut.Name = "textBoxConfigReportTimeOut";
            this.textBoxConfigReportTimeOut.Size = new System.Drawing.Size(106, 20);
            this.textBoxConfigReportTimeOut.TabIndex = 33;
            this.textBoxConfigReportTimeOut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxConfigReportTimeOut_MouseClick);
            this.textBoxConfigReportTimeOut.Leave += new System.EventHandler(this.textBoxConfigReportTimeOut_Leave);
            this.textBoxConfigReportTimeOut.MouseLeave += new System.EventHandler(this.textBoxConfigReportTimeOut_MouseLeave);
            this.textBoxConfigReportTimeOut.MouseHover += new System.EventHandler(this.textBoxConfigReportTimeOut_MouseHover);
            // 
            // textBoxConfigReportMaxInterval
            // 
            this.textBoxConfigReportMaxInterval.Location = new System.Drawing.Point(998, 91);
            this.textBoxConfigReportMaxInterval.Name = "textBoxConfigReportMaxInterval";
            this.textBoxConfigReportMaxInterval.Size = new System.Drawing.Size(106, 20);
            this.textBoxConfigReportMaxInterval.TabIndex = 32;
            this.textBoxConfigReportMaxInterval.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxConfigReportMaxInterval_MouseClick);
            this.textBoxConfigReportMaxInterval.Leave += new System.EventHandler(this.textBoxConfigReportMaxInterval_Leave);
            this.textBoxConfigReportMaxInterval.MouseLeave += new System.EventHandler(this.textBoxConfigReportMaxInterval_MouseLeave);
            this.textBoxConfigReportMaxInterval.MouseHover += new System.EventHandler(this.textBoxConfigReportMaxInterval_MouseHover);
            // 
            // textBoxDiscoverAttributesMaxIDs
            // 
            this.textBoxDiscoverAttributesMaxIDs.Location = new System.Drawing.Point(767, 210);
            this.textBoxDiscoverAttributesMaxIDs.Name = "textBoxDiscoverAttributesMaxIDs";
            this.textBoxDiscoverAttributesMaxIDs.Size = new System.Drawing.Size(110, 20);
            this.textBoxDiscoverAttributesMaxIDs.TabIndex = 57;
            this.textBoxDiscoverAttributesMaxIDs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxDiscoverAttributesMaxIDs_MouseClick);
            this.textBoxDiscoverAttributesMaxIDs.Leave += new System.EventHandler(this.textBoxDiscoverAttributesMaxIDs_Leave);
            this.textBoxDiscoverAttributesMaxIDs.MouseLeave += new System.EventHandler(this.textBoxDiscoverAttributesMaxIDs_MouseLeave);
            this.textBoxDiscoverAttributesMaxIDs.MouseHover += new System.EventHandler(this.textBoxDiscoverAttributesMaxIDs_MouseHover);
            // 
            // comboBoxDiscoverAttributesDirection
            // 
            this.comboBoxDiscoverAttributesDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiscoverAttributesDirection.FormattingEnabled = true;
            this.comboBoxDiscoverAttributesDirection.Location = new System.Drawing.Point(654, 210);
            this.comboBoxDiscoverAttributesDirection.Name = "comboBoxDiscoverAttributesDirection";
            this.comboBoxDiscoverAttributesDirection.Size = new System.Drawing.Size(106, 21);
            this.comboBoxDiscoverAttributesDirection.TabIndex = 56;
            this.comboBoxDiscoverAttributesDirection.MouseLeave += new System.EventHandler(this.comboBoxDiscoverAttributesDirection_MouseLeave);
            this.comboBoxDiscoverAttributesDirection.MouseHover += new System.EventHandler(this.comboBoxDiscoverAttributesDirection_MouseHover);
            // 
            // textBoxDiscoverAttributesClusterID
            // 
            this.textBoxDiscoverAttributesClusterID.Location = new System.Drawing.Point(431, 210);
            this.textBoxDiscoverAttributesClusterID.Name = "textBoxDiscoverAttributesClusterID";
            this.textBoxDiscoverAttributesClusterID.Size = new System.Drawing.Size(102, 20);
            this.textBoxDiscoverAttributesClusterID.TabIndex = 54;
            this.textBoxDiscoverAttributesClusterID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxDiscoverAttributesClusterID_MouseClick);
            this.textBoxDiscoverAttributesClusterID.Leave += new System.EventHandler(this.textBoxDiscoverAttributesClusterID_Leave);
            this.textBoxDiscoverAttributesClusterID.MouseLeave += new System.EventHandler(this.textBoxDiscoverAttributesClusterID_MouseLeave);
            this.textBoxDiscoverAttributesClusterID.MouseHover += new System.EventHandler(this.textBoxDiscoverAttributesClusterID_MouseHover);
            // 
            // textBoxDiscoverAttributesDstEp
            // 
            this.textBoxDiscoverAttributesDstEp.Location = new System.Drawing.Point(319, 210);
            this.textBoxDiscoverAttributesDstEp.Name = "textBoxDiscoverAttributesDstEp";
            this.textBoxDiscoverAttributesDstEp.Size = new System.Drawing.Size(106, 20);
            this.textBoxDiscoverAttributesDstEp.TabIndex = 53;
            this.textBoxDiscoverAttributesDstEp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxDiscoverAttributesDstEp_MouseClick);
            this.textBoxDiscoverAttributesDstEp.Leave += new System.EventHandler(this.textBoxDiscoverAttributesDstEp_Leave);
            this.textBoxDiscoverAttributesDstEp.MouseLeave += new System.EventHandler(this.textBoxDiscoverAttributesDstEp_MouseLeave);
            this.textBoxDiscoverAttributesDstEp.MouseHover += new System.EventHandler(this.textBoxDiscoverAttributesDstEp_MouseHover);
            // 
            // textBoxDiscoverAttributesSrcEp
            // 
            this.textBoxDiscoverAttributesSrcEp.Location = new System.Drawing.Point(206, 210);
            this.textBoxDiscoverAttributesSrcEp.Name = "textBoxDiscoverAttributesSrcEp";
            this.textBoxDiscoverAttributesSrcEp.Size = new System.Drawing.Size(106, 20);
            this.textBoxDiscoverAttributesSrcEp.TabIndex = 52;
            this.textBoxDiscoverAttributesSrcEp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxDiscoverAttributesSrcEp_MouseClick);
            this.textBoxDiscoverAttributesSrcEp.Leave += new System.EventHandler(this.textBoxDiscoverAttributesSrcEp_Leave);
            this.textBoxDiscoverAttributesSrcEp.MouseLeave += new System.EventHandler(this.textBoxDiscoverAttributesSrcEp_MouseLeave);
            this.textBoxDiscoverAttributesSrcEp.MouseHover += new System.EventHandler(this.textBoxDiscoverAttributesSrcEp_MouseHover);
            // 
            // textBoxDiscoverAttributesAddr
            // 
            this.textBoxDiscoverAttributesAddr.Location = new System.Drawing.Point(108, 210);
            this.textBoxDiscoverAttributesAddr.Name = "textBoxDiscoverAttributesAddr";
            this.textBoxDiscoverAttributesAddr.Size = new System.Drawing.Size(91, 20);
            this.textBoxDiscoverAttributesAddr.TabIndex = 51;
            this.textBoxDiscoverAttributesAddr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxDiscoverAttributesAddr_MouseClick);
            this.textBoxDiscoverAttributesAddr.Leave += new System.EventHandler(this.textBoxDiscoverAttributesAddr_Leave);
            this.textBoxDiscoverAttributesAddr.MouseLeave += new System.EventHandler(this.textBoxDiscoverAttributesAddr_MouseLeave);
            this.textBoxDiscoverAttributesAddr.MouseHover += new System.EventHandler(this.textBoxDiscoverAttributesAddr_MouseHover);
            // 
            // buttonDiscoverAttributes
            // 
            this.buttonDiscoverAttributes.Location = new System.Drawing.Point(6, 208);
            this.buttonDiscoverAttributes.Name = "buttonDiscoverAttributes";
            this.buttonDiscoverAttributes.Size = new System.Drawing.Size(95, 22);
            this.buttonDiscoverAttributes.TabIndex = 50;
            this.buttonDiscoverAttributes.Text = "Disc Attribs";
            this.buttonDiscoverAttributes.UseVisualStyleBackColor = true;
            this.buttonDiscoverAttributes.Click += new System.EventHandler(this.buttonDiscoverAttributes_Click);
            // 
            // comboBoxReadAllAttribDirection
            // 
            this.comboBoxReadAllAttribDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReadAllAttribDirection.FormattingEnabled = true;
            this.comboBoxReadAllAttribDirection.Location = new System.Drawing.Point(541, 181);
            this.comboBoxReadAllAttribDirection.Name = "comboBoxReadAllAttribDirection";
            this.comboBoxReadAllAttribDirection.Size = new System.Drawing.Size(106, 21);
            this.comboBoxReadAllAttribDirection.TabIndex = 49;
            this.comboBoxReadAllAttribDirection.Visible = false;
            this.comboBoxReadAllAttribDirection.MouseLeave += new System.EventHandler(this.comboBoxReadAllAttribDirection_MouseLeave);
            this.comboBoxReadAllAttribDirection.MouseHover += new System.EventHandler(this.comboBoxReadAllAttribDirection_MouseHover);
            // 
            // textBoxReadAllAttribClusterID
            // 
            this.textBoxReadAllAttribClusterID.Location = new System.Drawing.Point(431, 182);
            this.textBoxReadAllAttribClusterID.Name = "textBoxReadAllAttribClusterID";
            this.textBoxReadAllAttribClusterID.Size = new System.Drawing.Size(103, 20);
            this.textBoxReadAllAttribClusterID.TabIndex = 48;
            this.textBoxReadAllAttribClusterID.Visible = false;
            this.textBoxReadAllAttribClusterID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxReadAllAttribClusterID_MouseClick);
            this.textBoxReadAllAttribClusterID.Leave += new System.EventHandler(this.textBoxReadAllAttribClusterID_Leave);
            this.textBoxReadAllAttribClusterID.MouseLeave += new System.EventHandler(this.textBoxReadAllAttribClusterID_MouseLeave);
            this.textBoxReadAllAttribClusterID.MouseHover += new System.EventHandler(this.textBoxReadAllAttribClusterID_MouseHover);
            // 
            // textBoxReadAllAttribDstEP
            // 
            this.textBoxReadAllAttribDstEP.Location = new System.Drawing.Point(319, 182);
            this.textBoxReadAllAttribDstEP.Name = "textBoxReadAllAttribDstEP";
            this.textBoxReadAllAttribDstEP.Size = new System.Drawing.Size(106, 20);
            this.textBoxReadAllAttribDstEP.TabIndex = 47;
            this.textBoxReadAllAttribDstEP.Visible = false;
            this.textBoxReadAllAttribDstEP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxReadAllAttribDstEP_MouseClick);
            this.textBoxReadAllAttribDstEP.Leave += new System.EventHandler(this.textBoxReadAllAttribDstEP_Leave);
            this.textBoxReadAllAttribDstEP.MouseLeave += new System.EventHandler(this.textBoxReadAllAttribDstEP_MouseLeave);
            this.textBoxReadAllAttribDstEP.MouseHover += new System.EventHandler(this.textBoxReadAllAttribDstEP_MouseHover);
            // 
            // textBoxReadAllAttribSrcEP
            // 
            this.textBoxReadAllAttribSrcEP.Location = new System.Drawing.Point(206, 183);
            this.textBoxReadAllAttribSrcEP.Name = "textBoxReadAllAttribSrcEP";
            this.textBoxReadAllAttribSrcEP.Size = new System.Drawing.Size(106, 20);
            this.textBoxReadAllAttribSrcEP.TabIndex = 46;
            this.textBoxReadAllAttribSrcEP.Visible = false;
            this.textBoxReadAllAttribSrcEP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxReadAllAttribSrcEP_MouseClick);
            this.textBoxReadAllAttribSrcEP.Leave += new System.EventHandler(this.textBoxReadAllAttribSrcEP_Leave);
            this.textBoxReadAllAttribSrcEP.MouseLeave += new System.EventHandler(this.textBoxReadAllAttribSrcEP_MouseLeave);
            this.textBoxReadAllAttribSrcEP.MouseHover += new System.EventHandler(this.textBoxReadAllAttribSrcEP_MouseHover);
            // 
            // textBoxReadAllAttribAddr
            // 
            this.textBoxReadAllAttribAddr.Location = new System.Drawing.Point(108, 183);
            this.textBoxReadAllAttribAddr.Name = "textBoxReadAllAttribAddr";
            this.textBoxReadAllAttribAddr.Size = new System.Drawing.Size(91, 20);
            this.textBoxReadAllAttribAddr.TabIndex = 45;
            this.textBoxReadAllAttribAddr.Visible = false;
            this.textBoxReadAllAttribAddr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxReadAllAttribAddr_MouseClick);
            this.textBoxReadAllAttribAddr.Leave += new System.EventHandler(this.textBoxReadAllAttribAddr_Leave);
            this.textBoxReadAllAttribAddr.MouseLeave += new System.EventHandler(this.textBoxReadAllAttribAddr_MouseLeave);
            this.textBoxReadAllAttribAddr.MouseHover += new System.EventHandler(this.textBoxReadAllAttribAddr_MouseHover);
            // 
            // buttonReadAllAttrib
            // 
            this.buttonReadAllAttrib.Location = new System.Drawing.Point(6, 182);
            this.buttonReadAllAttrib.Name = "buttonReadAllAttrib";
            this.buttonReadAllAttrib.Size = new System.Drawing.Size(95, 20);
            this.buttonReadAllAttrib.TabIndex = 44;
            this.buttonReadAllAttrib.Text = "Read All Attrib";
            this.buttonReadAllAttrib.UseVisualStyleBackColor = true;
            this.buttonReadAllAttrib.Visible = false;
            // 
            // comboBoxConfigReportAttribDirection
            // 
            this.comboBoxConfigReportAttribDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConfigReportAttribDirection.FormattingEnabled = true;
            this.comboBoxConfigReportAttribDirection.Location = new System.Drawing.Point(771, 66);
            this.comboBoxConfigReportAttribDirection.Name = "comboBoxConfigReportAttribDirection";
            this.comboBoxConfigReportAttribDirection.Size = new System.Drawing.Size(107, 21);
            this.comboBoxConfigReportAttribDirection.TabIndex = 28;
            this.comboBoxConfigReportAttribDirection.SelectedIndexChanged += new System.EventHandler(this.comboBoxConfigReportAttribDirection_SelectedIndexChanged);
            this.comboBoxConfigReportAttribDirection.MouseLeave += new System.EventHandler(this.comboBoxConfigReportAttribDirection_MouseLeave);
            this.comboBoxConfigReportAttribDirection.MouseHover += new System.EventHandler(this.comboBoxConfigReportAttribDirection_MouseHover);
            // 
            // textBoxConfigReportAttribType
            // 
            this.textBoxConfigReportAttribType.Location = new System.Drawing.Point(886, 66);
            this.textBoxConfigReportAttribType.Name = "textBoxConfigReportAttribType";
            this.textBoxConfigReportAttribType.Size = new System.Drawing.Size(106, 20);
            this.textBoxConfigReportAttribType.TabIndex = 29;
            this.textBoxConfigReportAttribType.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxConfigReportAttribType_MouseClick);
            this.textBoxConfigReportAttribType.Leave += new System.EventHandler(this.textBoxConfigReportAttribType_Leave);
            this.textBoxConfigReportAttribType.MouseLeave += new System.EventHandler(this.textBoxConfigReportAttribType_MouseLeave);
            this.textBoxConfigReportAttribType.MouseHover += new System.EventHandler(this.textBoxConfigReportAttribType_MouseHover);
            // 
            // textBoxConfigReportMinInterval
            // 
            this.textBoxConfigReportMinInterval.Location = new System.Drawing.Point(886, 91);
            this.textBoxConfigReportMinInterval.Name = "textBoxConfigReportMinInterval";
            this.textBoxConfigReportMinInterval.Size = new System.Drawing.Size(106, 20);
            this.textBoxConfigReportMinInterval.TabIndex = 31;
            this.textBoxConfigReportMinInterval.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxConfigReportMinInterval_MouseClick);
            this.textBoxConfigReportMinInterval.Leave += new System.EventHandler(this.textBoxConfigReportMinInterval_Leave);
            this.textBoxConfigReportMinInterval.MouseLeave += new System.EventHandler(this.textBoxConfigReportMinInterval_MouseLeave);
            this.textBoxConfigReportMinInterval.MouseHover += new System.EventHandler(this.textBoxConfigReportMinInterval_MouseHover);
            // 
            // textBoxConfigReportAttribID
            // 
            this.textBoxConfigReportAttribID.Location = new System.Drawing.Point(998, 66);
            this.textBoxConfigReportAttribID.Name = "textBoxConfigReportAttribID";
            this.textBoxConfigReportAttribID.Size = new System.Drawing.Size(106, 20);
            this.textBoxConfigReportAttribID.TabIndex = 30;
            this.textBoxConfigReportAttribID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxConfigReportAttribID_MouseClick);
            this.textBoxConfigReportAttribID.Leave += new System.EventHandler(this.textBoxConfigReportAttribID_Leave);
            this.textBoxConfigReportAttribID.MouseLeave += new System.EventHandler(this.textBoxConfigReportAttribID_MouseLeave);
            this.textBoxConfigReportAttribID.MouseHover += new System.EventHandler(this.textBoxConfigReportAttribID_MouseHover);
            // 
            // comboBoxConfigReportDirection
            // 
            this.comboBoxConfigReportDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConfigReportDirection.FormattingEnabled = true;
            this.comboBoxConfigReportDirection.Location = new System.Drawing.Point(658, 66);
            this.comboBoxConfigReportDirection.Name = "comboBoxConfigReportDirection";
            this.comboBoxConfigReportDirection.Size = new System.Drawing.Size(106, 21);
            this.comboBoxConfigReportDirection.TabIndex = 27;
            this.comboBoxConfigReportDirection.MouseLeave += new System.EventHandler(this.comboBoxConfigReportDirection_MouseLeave);
            this.comboBoxConfigReportDirection.MouseHover += new System.EventHandler(this.comboBoxConfigReportDirection_MouseHover);
            // 
            // textBoxConfigReportClusterID
            // 
            this.textBoxConfigReportClusterID.Location = new System.Drawing.Point(545, 66);
            this.textBoxConfigReportClusterID.Name = "textBoxConfigReportClusterID";
            this.textBoxConfigReportClusterID.Size = new System.Drawing.Size(106, 20);
            this.textBoxConfigReportClusterID.TabIndex = 26;
            this.textBoxConfigReportClusterID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxConfigReportClusterID_MouseClick);
            this.textBoxConfigReportClusterID.Leave += new System.EventHandler(this.textBoxConfigReportClusterID_Leave);
            this.textBoxConfigReportClusterID.MouseLeave += new System.EventHandler(this.textBoxConfigReportClusterID_MouseLeave);
            this.textBoxConfigReportClusterID.MouseHover += new System.EventHandler(this.textBoxConfigReportClusterID_MouseHover);
            // 
            // textBoxConfigReportDstEP
            // 
            this.textBoxConfigReportDstEP.Location = new System.Drawing.Point(432, 66);
            this.textBoxConfigReportDstEP.Name = "textBoxConfigReportDstEP";
            this.textBoxConfigReportDstEP.Size = new System.Drawing.Size(106, 20);
            this.textBoxConfigReportDstEP.TabIndex = 25;
            this.textBoxConfigReportDstEP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxConfigReportDstEP_MouseClick);
            this.textBoxConfigReportDstEP.Leave += new System.EventHandler(this.textBoxConfigReportDstEP_Leave);
            this.textBoxConfigReportDstEP.MouseLeave += new System.EventHandler(this.textBoxConfigReportDstEP_MouseLeave);
            this.textBoxConfigReportDstEP.MouseHover += new System.EventHandler(this.textBoxConfigReportDstEP_MouseHover);
            // 
            // textBoxConfigReportSrcEP
            // 
            this.textBoxConfigReportSrcEP.Location = new System.Drawing.Point(319, 66);
            this.textBoxConfigReportSrcEP.Name = "textBoxConfigReportSrcEP";
            this.textBoxConfigReportSrcEP.Size = new System.Drawing.Size(106, 20);
            this.textBoxConfigReportSrcEP.TabIndex = 24;
            this.textBoxConfigReportSrcEP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxConfigReportSrcEP_MouseClick);
            this.textBoxConfigReportSrcEP.Leave += new System.EventHandler(this.textBoxConfigReportSrcEP_Leave);
            this.textBoxConfigReportSrcEP.MouseLeave += new System.EventHandler(this.textBoxConfigReportSrcEP_MouseLeave);
            this.textBoxConfigReportSrcEP.MouseHover += new System.EventHandler(this.textBoxConfigReportSrcEP_MouseHover);
            // 
            // textBoxConfigReportTargetAddr
            // 
            this.textBoxConfigReportTargetAddr.Location = new System.Drawing.Point(206, 66);
            this.textBoxConfigReportTargetAddr.Name = "textBoxConfigReportTargetAddr";
            this.textBoxConfigReportTargetAddr.Size = new System.Drawing.Size(106, 20);
            this.textBoxConfigReportTargetAddr.TabIndex = 23;
            this.textBoxConfigReportTargetAddr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxConfigReportTargetAddr_MouseClick);
            this.textBoxConfigReportTargetAddr.Leave += new System.EventHandler(this.textBoxConfigReportTargetAddr_Leave);
            this.textBoxConfigReportTargetAddr.MouseLeave += new System.EventHandler(this.textBoxConfigReportTargetAddr_MouseLeave);
            this.textBoxConfigReportTargetAddr.MouseHover += new System.EventHandler(this.textBoxConfigReportTargetAddr_MouseHover);
            // 
            // buttonConfigReport
            // 
            this.buttonConfigReport.Location = new System.Drawing.Point(6, 63);
            this.buttonConfigReport.Name = "buttonConfigReport";
            this.buttonConfigReport.Size = new System.Drawing.Size(80, 24);
            this.buttonConfigReport.TabIndex = 21;
            this.buttonConfigReport.Text = "Config Rprt";
            this.buttonConfigReport.UseVisualStyleBackColor = true;
            this.buttonConfigReport.Click += new System.EventHandler(this.buttonConfigReport_Click_1);
            // 
            // buttonWriteAttrib
            // 
            this.buttonWriteAttrib.Location = new System.Drawing.Point(6, 34);
            this.buttonWriteAttrib.Name = "buttonWriteAttrib";
            this.buttonWriteAttrib.Size = new System.Drawing.Size(80, 22);
            this.buttonWriteAttrib.TabIndex = 10;
            this.buttonWriteAttrib.Text = "Write Attrib";
            this.buttonWriteAttrib.UseVisualStyleBackColor = true;
            this.buttonWriteAttrib.Click += new System.EventHandler(this.buttonWriteAttrib_Click_1);
            // 
            // textBoxReadAttribCount
            // 
            this.textBoxReadAttribCount.Location = new System.Drawing.Point(658, 8);
            this.textBoxReadAttribCount.Name = "textBoxReadAttribCount";
            this.textBoxReadAttribCount.Size = new System.Drawing.Size(106, 20);
            this.textBoxReadAttribCount.TabIndex = 6;
            this.textBoxReadAttribCount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxReadAttribCount_MouseClick);
            this.textBoxReadAttribCount.Leave += new System.EventHandler(this.textBoxReadAttribCount_Leave);
            this.textBoxReadAttribCount.MouseLeave += new System.EventHandler(this.textBoxReadAttribCount_MouseLeave);
            this.textBoxReadAttribCount.MouseHover += new System.EventHandler(this.textBoxReadAttribCount_MouseHover);
            // 
            // comboBoxReadAttribDirection
            // 
            this.comboBoxReadAttribDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReadAttribDirection.FormattingEnabled = true;
            this.comboBoxReadAttribDirection.Location = new System.Drawing.Point(545, 8);
            this.comboBoxReadAttribDirection.Name = "comboBoxReadAttribDirection";
            this.comboBoxReadAttribDirection.Size = new System.Drawing.Size(106, 21);
            this.comboBoxReadAttribDirection.TabIndex = 5;
            this.comboBoxReadAttribDirection.SelectedIndexChanged += new System.EventHandler(this.comboBoxReadAttribDirection_SelectedIndexChanged);
            this.comboBoxReadAttribDirection.MouseLeave += new System.EventHandler(this.comboBoxReadAttribDirection_MouseLeave);
            this.comboBoxReadAttribDirection.MouseHover += new System.EventHandler(this.comboBoxReadAttribDirection_MouseHover);
            // 
            // textBoxReadAttribID1
            // 
            this.textBoxReadAttribID1.Location = new System.Drawing.Point(771, 8);
            this.textBoxReadAttribID1.Name = "textBoxReadAttribID1";
            this.textBoxReadAttribID1.Size = new System.Drawing.Size(106, 20);
            this.textBoxReadAttribID1.TabIndex = 7;
            this.textBoxReadAttribID1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxReadAttribID1_MouseClick);
            this.textBoxReadAttribID1.Leave += new System.EventHandler(this.textBoxReadAttribID1_Leave);
            this.textBoxReadAttribID1.MouseLeave += new System.EventHandler(this.textBoxReadAttribID1_MouseLeave);
            this.textBoxReadAttribID1.MouseHover += new System.EventHandler(this.textBoxReadAttribID1_MouseHover);
            // 
            // textBoxReadAttribClusterID
            // 
            this.textBoxReadAttribClusterID.Location = new System.Drawing.Point(432, 8);
            this.textBoxReadAttribClusterID.Name = "textBoxReadAttribClusterID";
            this.textBoxReadAttribClusterID.Size = new System.Drawing.Size(106, 20);
            this.textBoxReadAttribClusterID.TabIndex = 4;
            this.textBoxReadAttribClusterID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxReadAttribClusterID_MouseClick);
            this.textBoxReadAttribClusterID.Leave += new System.EventHandler(this.textBoxReadAttribClusterID_Leave);
            this.textBoxReadAttribClusterID.MouseLeave += new System.EventHandler(this.textBoxReadAttribClusterID_MouseLeave);
            this.textBoxReadAttribClusterID.MouseHover += new System.EventHandler(this.textBoxReadAttribClusterID_MouseHover);
            // 
            // textBoxReadAttribDstEP
            // 
            this.textBoxReadAttribDstEP.Location = new System.Drawing.Point(319, 8);
            this.textBoxReadAttribDstEP.Name = "textBoxReadAttribDstEP";
            this.textBoxReadAttribDstEP.Size = new System.Drawing.Size(106, 20);
            this.textBoxReadAttribDstEP.TabIndex = 3;
            this.textBoxReadAttribDstEP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxReadAttribDstEP_MouseClick);
            this.textBoxReadAttribDstEP.Leave += new System.EventHandler(this.textBoxReadAttribDstEP_Leave);
            this.textBoxReadAttribDstEP.MouseLeave += new System.EventHandler(this.textBoxReadAttribDstEP_MouseLeave);
            this.textBoxReadAttribDstEP.MouseHover += new System.EventHandler(this.textBoxReadAttribDstEP_MouseHover);
            // 
            // textBoxReadAttribSrcEP
            // 
            this.textBoxReadAttribSrcEP.Location = new System.Drawing.Point(206, 8);
            this.textBoxReadAttribSrcEP.Name = "textBoxReadAttribSrcEP";
            this.textBoxReadAttribSrcEP.Size = new System.Drawing.Size(106, 20);
            this.textBoxReadAttribSrcEP.TabIndex = 2;
            this.textBoxReadAttribSrcEP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxReadAttribSrcEP_MouseClick);
            this.textBoxReadAttribSrcEP.Leave += new System.EventHandler(this.textBoxReadAttribSrcEP_Leave);
            this.textBoxReadAttribSrcEP.MouseLeave += new System.EventHandler(this.textBoxReadAttribSrcEP_MouseLeave);
            this.textBoxReadAttribSrcEP.MouseHover += new System.EventHandler(this.textBoxReadAttribSrcEP_MouseHover);
            // 
            // textBoxReadAttribTargetAddr
            // 
            this.textBoxReadAttribTargetAddr.Location = new System.Drawing.Point(93, 8);
            this.textBoxReadAttribTargetAddr.Name = "textBoxReadAttribTargetAddr";
            this.textBoxReadAttribTargetAddr.Size = new System.Drawing.Size(106, 20);
            this.textBoxReadAttribTargetAddr.TabIndex = 1;
            this.textBoxReadAttribTargetAddr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxReadAttribTargetAddr_MouseClick);
            this.textBoxReadAttribTargetAddr.Leave += new System.EventHandler(this.textBoxReadAttribTargetAddr_Leave);
            this.textBoxReadAttribTargetAddr.MouseLeave += new System.EventHandler(this.textBoxReadAttribTargetAddr_MouseLeave);
            this.textBoxReadAttribTargetAddr.MouseHover += new System.EventHandler(this.textBoxReadAttribTargetAddr_MouseHover);
            // 
            // buttonReadAttrib
            // 
            this.buttonReadAttrib.Location = new System.Drawing.Point(6, 6);
            this.buttonReadAttrib.Name = "buttonReadAttrib";
            this.buttonReadAttrib.Size = new System.Drawing.Size(80, 22);
            this.buttonReadAttrib.TabIndex = 0;
            this.buttonReadAttrib.Text = "Read Attrib";
            this.buttonReadAttrib.UseVisualStyleBackColor = true;
            this.buttonReadAttrib.Click += new System.EventHandler(this.buttonReadAttrib_Click_1);
            // 
            // Temperature
            // 
            this.Temperature.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Temperature.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Temperature.Controls.Add(this.label6);
            this.Temperature.Controls.Add(this.tension);
            this.Temperature.Controls.Add(this.label5);
            this.Temperature.Controls.Add(this.count_mess_xiaomi);
            this.Temperature.Controls.Add(this.label2);
            this.Temperature.Controls.Add(this.label1);
            this.Temperature.Controls.Add(this.humidity_xiaomi);
            this.Temperature.Controls.Add(this.temperature_xiaomi);
            this.Temperature.Location = new System.Drawing.Point(4, 22);
            this.Temperature.Name = "Temperature";
            this.Temperature.Padding = new System.Windows.Forms.Padding(3);
            this.Temperature.Size = new System.Drawing.Size(1351, 416);
            this.Temperature.TabIndex = 16;
            this.Temperature.Text = "Temperature";
            this.Temperature.Click += new System.EventHandler(this.AHIControl_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            // 
            // tension
            // 
            this.tension.Location = new System.Drawing.Point(129, 134);
            this.tension.Name = "tension";
            this.tension.Size = new System.Drawing.Size(50, 20);
            this.tension.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            // 
            // count_mess_xiaomi
            // 
            this.count_mess_xiaomi.Location = new System.Drawing.Point(129, 66);
            this.count_mess_xiaomi.Name = "count_mess_xiaomi";
            this.count_mess_xiaomi.Size = new System.Drawing.Size(100, 20);
            this.count_mess_xiaomi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // humidity_xiaomi
            // 
            this.humidity_xiaomi.Location = new System.Drawing.Point(320, 134);
            this.humidity_xiaomi.Name = "humidity_xiaomi";
            this.humidity_xiaomi.Size = new System.Drawing.Size(50, 20);
            this.humidity_xiaomi.TabIndex = 1;
            // 
            // temperature_xiaomi
            // 
            this.temperature_xiaomi.Location = new System.Drawing.Point(320, 67);
            this.temperature_xiaomi.Name = "temperature_xiaomi";
            this.temperature_xiaomi.Size = new System.Drawing.Size(50, 20);
            this.temperature_xiaomi.TabIndex = 0;
            // 
            // smart_plug
            // 
            this.smart_plug.BackColor = System.Drawing.Color.WhiteSmoke;
            this.smart_plug.Controls.Add(this.label7);
            this.smart_plug.Controls.Add(this.comboBox_direction);
            this.smart_plug.Controls.Add(this.state);
            this.smart_plug.Controls.Add(this.conso_smart);
            this.smart_plug.Controls.Add(this.conso);
            this.smart_plug.Controls.Add(this.power_socket);
            this.smart_plug.Location = new System.Drawing.Point(4, 22);
            this.smart_plug.Name = "smart_plug";
            this.smart_plug.Padding = new System.Windows.Forms.Padding(3);
            this.smart_plug.Size = new System.Drawing.Size(1351, 416);
            this.smart_plug.TabIndex = 19;
            this.smart_plug.Text = "smart_plug";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(538, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "puissance -> W";
            // 
            // comboBox_direction
            // 
            this.comboBox_direction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_direction.FormattingEnabled = true;
            this.comboBox_direction.Location = new System.Drawing.Point(119, 271);
            this.comboBox_direction.Name = "comboBox_direction";
            this.comboBox_direction.Size = new System.Drawing.Size(106, 21);
            this.comboBox_direction.TabIndex = 6;
            this.comboBox_direction.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Location = new System.Drawing.Point(408, 105);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(135, 17);
            this.state.TabIndex = 4;
            this.state.TabStop = true;
            this.state.Text = "response power socket";
            this.state.UseVisualStyleBackColor = true;
            // 
            // conso_smart
            // 
            this.conso_smart.Location = new System.Drawing.Point(110, 170);
            this.conso_smart.Name = "conso_smart";
            this.conso_smart.Size = new System.Drawing.Size(147, 70);
            this.conso_smart.TabIndex = 3;
            this.conso_smart.Text = "ASK CONSO";
            this.conso_smart.UseVisualStyleBackColor = true;
            this.conso_smart.Click += new System.EventHandler(this.conso_smart_Click);
            // 
            // conso
            // 
            this.conso.Location = new System.Drawing.Point(408, 179);
            this.conso.Name = "conso";
            this.conso.Size = new System.Drawing.Size(100, 20);
            this.conso.TabIndex = 2;
            // 
            // power_socket
            // 
            this.power_socket.Location = new System.Drawing.Point(110, 58);
            this.power_socket.Name = "power_socket";
            this.power_socket.Size = new System.Drawing.Size(147, 70);
            this.power_socket.TabIndex = 0;
            this.power_socket.Text = "OFF";
            this.power_socket.UseVisualStyleBackColor = true;
            this.power_socket.Click += new System.EventHandler(this.power_socket_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.lamp_osram);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1351, 416);
            this.tabPage1.TabIndex = 20;
            this.tabPage1.Text = "lampe extension";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "lampe hue";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "OFF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonMessageViewClear
            // 
            this.buttonMessageViewClear.Location = new System.Drawing.Point(1292, 474);
            this.buttonMessageViewClear.Name = "buttonMessageViewClear";
            this.buttonMessageViewClear.Size = new System.Drawing.Size(80, 22);
            this.buttonMessageViewClear.TabIndex = 92;
            this.buttonMessageViewClear.Text = "Clear";
            this.buttonMessageViewClear.UseVisualStyleBackColor = true;
            this.buttonMessageViewClear.Click += new System.EventHandler(this.buttonMessageViewClear_Click);
            // 
            // buttonClearRaw
            // 
            this.buttonClearRaw.Location = new System.Drawing.Point(749, 474);
            this.buttonClearRaw.Name = "buttonClearRaw";
            this.buttonClearRaw.Size = new System.Drawing.Size(80, 22);
            this.buttonClearRaw.TabIndex = 91;
            this.buttonClearRaw.Text = "Clear";
            this.buttonClearRaw.UseVisualStyleBackColor = true;
            this.buttonClearRaw.Click += new System.EventHandler(this.buttonClearRaw_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(831, 479);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Received Message View";
            // 
            // richTextBoxMessageView
            // 
            this.richTextBoxMessageView.Location = new System.Drawing.Point(834, 502);
            this.richTextBoxMessageView.Name = "richTextBoxMessageView";
            this.richTextBoxMessageView.Size = new System.Drawing.Size(538, 238);
            this.richTextBoxMessageView.TabIndex = 17;
            this.richTextBoxMessageView.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Raw Data";
            // 
            // richTextBoxCommandResponse
            // 
            this.richTextBoxCommandResponse.Location = new System.Drawing.Point(13, 502);
            this.richTextBoxCommandResponse.Name = "richTextBoxCommandResponse";
            this.richTextBoxCommandResponse.Size = new System.Drawing.Size(816, 238);
            this.richTextBoxCommandResponse.TabIndex = 4;
            this.richTextBoxCommandResponse.Text = "";
            // 
            // openOtaFileDialog
            // 
            this.openOtaFileDialog.FileName = "openFileDialog1";
            this.openOtaFileDialog.Filter = "OTA|*.ota";
            this.openOtaFileDialog.Title = "Select an OTA Image";
            // 
            // checkBoxDebug
            // 
            this.checkBoxDebug.AutoSize = true;
            this.checkBoxDebug.Location = new System.Drawing.Point(966, 478);
            this.checkBoxDebug.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxDebug.Name = "checkBoxDebug";
            this.checkBoxDebug.Size = new System.Drawing.Size(139, 17);
            this.checkBoxDebug.TabIndex = 93;
            this.checkBoxDebug.Text = "View Additional Debug?";
            this.checkBoxDebug.UseVisualStyleBackColor = true;
            // 
            // lamp_osram
            // 
            this.lamp_osram.Location = new System.Drawing.Point(356, 68);
            this.lamp_osram.Name = "lamp_osram";
            this.lamp_osram.Size = new System.Drawing.Size(143, 75);
            this.lamp_osram.TabIndex = 2;
            this.lamp_osram.Text = "OFF";
            this.lamp_osram.UseVisualStyleBackColor = true;
            this.lamp_osram.Click += new System.EventHandler(this.lamp_osram_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "lampe osram";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1027, 749);
            this.Controls.Add(this.checkBoxDebug);
            this.Controls.Add(this.lampe_hue);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonClearRaw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBoxCommandResponse);
            this.Controls.Add(this.richTextBoxMessageView);
            this.Controls.Add(this.buttonMessageViewClear);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ZigBee xiaomi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.lampe_hue.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPageDevice.ResumeLayout(false);
            this.tabPageDevice.PerformLayout();
            this.tabPage12.ResumeLayout(false);
            this.tabPage12.PerformLayout();
            this.Temperature.ResumeLayout(false);
            this.Temperature.PerformLayout();
            this.smart_plug.ResumeLayout(false);
            this.smart_plug.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPortToolStripMenuItem;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusPort;
        private System.Windows.Forms.ToolStripStatusLabel toolStripPortSettings;
        private System.Windows.Forms.TabControl lampe_hue;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonSetEPID;
        private System.Windows.Forms.Button buttonGetVersion;
        private System.Windows.Forms.Button buttonSetCMSK;
        private System.Windows.Forms.RichTextBox richTextBoxCommandResponse;
        private System.Windows.Forms.TextBox textBoxSetEPID;
        private System.Windows.Forms.TextBox textBoxSetCMSK;
        private System.Windows.Forms.Button buttonSetSecurity;
        private System.Windows.Forms.Button buttonSetDeviceType;
        private System.Windows.Forms.TextBox textBoxSetSecurityKeySeqNbr;
        private System.Windows.Forms.Button buttonErasePD;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonBind;
        private System.Windows.Forms.Button buttonStartNWK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBoxMessageView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonClearRaw;
        private System.Windows.Forms.Button buttonMessageViewClear;
        private System.Windows.Forms.ComboBox comboBoxSetType;
        private System.Windows.Forms.ComboBox comboBoxSetKeyState;
        private System.Windows.Forms.ComboBox comboBoxSetKeyType;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonPermitJoin;
        private System.Windows.Forms.TextBox textBoxPermitJoinAddr;
        private System.Windows.Forms.TextBox textBoxPermitJoinInterval;
        private System.Windows.Forms.ComboBox comboBoxPermitJoinTCsignificance;
        private System.Windows.Forms.ComboBox comboBoxSecurityKey;
        private System.Windows.Forms.Button buttonIeeeAddrReq;
        private System.Windows.Forms.Button buttonNwkAddrReq;
        private System.Windows.Forms.TextBox textBoxNodeDescReq;
        private System.Windows.Forms.Button buttonNodeDescReq;
        private System.Windows.Forms.Button buttonMatchReq;
        private System.Windows.Forms.Button buttonActiveEpReq;
        private System.Windows.Forms.Button buttonPowerDescReq;
        private System.Windows.Forms.Button buttonSimpleDescReq;
        private System.Windows.Forms.TextBox textBoxSimpleReqEndPoint;
        private System.Windows.Forms.TextBox textBoxSimpleReqAddr;
        private System.Windows.Forms.TextBox textBoxPowerReqAddr;
        private System.Windows.Forms.TextBox textBoxActiveEpAddr;
        private System.Windows.Forms.TextBox textBoxMatchReqAddr;
        private System.Windows.Forms.TextBox textBoxMatchReqNbrInputClusters;
        private System.Windows.Forms.TextBox textBoxMatchReqNbrOutputClusters;
        private System.Windows.Forms.TextBox textBoxMatchReqProfileID;
        private System.Windows.Forms.TextBox textBoxMatchReqInputClusters;
        private System.Windows.Forms.TextBox textBoxMatchReqOutputClusters;
        private System.Windows.Forms.TextBox textBoxComplexReqAddr;
        private System.Windows.Forms.Button buttonComplexReq;
        private System.Windows.Forms.TextBox textBoxIeeeReqStartIndex;
        private System.Windows.Forms.ComboBox comboBoxIeeeReqType;
        private System.Windows.Forms.TextBox textBoxIeeeReqAddr;
        private System.Windows.Forms.TextBox textBoxIeeeReqTargetAddr;
        private System.Windows.Forms.TextBox textBoxNwkAddrReqTargetAddr;
        private System.Windows.Forms.TextBox textBoxNwkAddrReqExtAddr;
        private System.Windows.Forms.TextBox textBoxNwkAddrReqStartIndex;
        private System.Windows.Forms.ComboBox comboBoxNwkAddrReqType;
        private System.Windows.Forms.Button buttonStartScan;
        private System.Windows.Forms.Button buttonRecoverNwk;
        private System.Windows.Forms.Button buttonRestoreNwk;
        private System.Windows.Forms.Button buttonMgmtLqiReq;
        private System.Windows.Forms.TextBox textBoxBindTargetEP;
        private System.Windows.Forms.TextBox textBoxBindClusterID;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.Button buttonReadAttrib;
        private System.Windows.Forms.TextBox textBoxReadAttribTargetAddr;
        private System.Windows.Forms.TextBox textBoxReadAttribSrcEP;
        private System.Windows.Forms.TextBox textBoxReadAttribDstEP;
        private System.Windows.Forms.TextBox textBoxReadAttribClusterID;
        private System.Windows.Forms.TextBox textBoxReadAttribID1;
        private System.Windows.Forms.ComboBox comboBoxReadAttribDirection;
        private System.Windows.Forms.TextBox textBoxReadAttribCount;
        private System.Windows.Forms.Button buttonWriteAttrib;
        private System.Windows.Forms.TextBox textBoxConfigReportTargetAddr;
        private System.Windows.Forms.Button buttonConfigReport;
        private System.Windows.Forms.TextBox textBoxConfigReportSrcEP;
        private System.Windows.Forms.TextBox textBoxConfigReportClusterID;
        private System.Windows.Forms.TextBox textBoxConfigReportDstEP;
        private System.Windows.Forms.ComboBox comboBoxConfigReportDirection;
        private System.Windows.Forms.TextBox textBoxConfigReportMinInterval;
        private System.Windows.Forms.TextBox textBoxConfigReportAttribID;
        private System.Windows.Forms.TextBox textBoxConfigReportAttribType;
        private System.Windows.Forms.ComboBox comboBoxConfigReportAttribDirection;
        private System.Windows.Forms.ComboBox comboBoxBindAddrMode;
        private System.Windows.Forms.TextBox textBoxBindDestAddr;
        private System.Windows.Forms.TextBox textBoxBindDestEP;
        private System.Windows.Forms.TextBox textBoxReadAllAttribAddr;
        private System.Windows.Forms.Button buttonReadAllAttrib;
        private System.Windows.Forms.TextBox textBoxReadAllAttribDstEP;
        private System.Windows.Forms.TextBox textBoxReadAllAttribSrcEP;
        private System.Windows.Forms.ComboBox comboBoxReadAllAttribDirection;
        private System.Windows.Forms.TextBox textBoxReadAllAttribClusterID;
        private System.Windows.Forms.Button buttonUnBind;
        private System.Windows.Forms.TextBox textBoxUnBindTargetExtAddr;
        private System.Windows.Forms.TextBox textBoxUnBindTargetEP;
        private System.Windows.Forms.TextBox textBoxUnBindClusterID;
        private System.Windows.Forms.TextBox textBoxUnBindDestAddr;
        private System.Windows.Forms.ComboBox comboBoxUnBindAddrMode;
        private System.Windows.Forms.TextBox textBoxUnBindDestEP;
        private System.Windows.Forms.Button buttonDiscoverAttributes;
        private System.Windows.Forms.TextBox textBoxDiscoverAttributesMaxIDs;
        private System.Windows.Forms.ComboBox comboBoxDiscoverAttributesDirection;
        private System.Windows.Forms.TextBox textBoxDiscoverAttributesClusterID;
        private System.Windows.Forms.TextBox textBoxDiscoverAttributesDstEp;
        private System.Windows.Forms.TextBox textBoxDiscoverAttributesSrcEp;
        private System.Windows.Forms.TextBox textBoxDiscoverAttributesAddr;
        private System.Windows.Forms.Button buttonMgmtLeave;
        private System.Windows.Forms.ComboBox comboBoxMgmtLeaveChildren;
        private System.Windows.Forms.ComboBox comboBoxMgmtLeaveReJoin;
        private System.Windows.Forms.TextBox textBoxMgmtLeaveExtAddr;
        private System.Windows.Forms.TextBox textBoxMgmtLeaveAddr;
        private System.Windows.Forms.TextBox textBoxConfigReportChange;
        private System.Windows.Forms.TextBox textBoxConfigReportTimeOut;
        private System.Windows.Forms.TextBox textBoxConfigReportMaxInterval;
        private System.Windows.Forms.ComboBox comboBoxWriteAttribDirection;
        private System.Windows.Forms.TextBox textBoxWriteAttribClusterID;
        private System.Windows.Forms.TextBox textBoxWriteAttribDstEP;
        private System.Windows.Forms.TextBox textBoxWriteAttribSrcEP;
        private System.Windows.Forms.TextBox textBoxWriteAttribTargetAddr;
        private System.Windows.Forms.TextBox textBoxWriteAttribData;
        private System.Windows.Forms.TextBox textBoxWriteAttribID;
        private System.Windows.Forms.ComboBox comboBoxConfigReportAddrMode;
        private System.Windows.Forms.TextBox textBoxWriteAttribDataType;
        private System.Windows.Forms.OpenFileDialog openOtaFileDialog;
        private System.Windows.Forms.ComboBox comboBoxReadAttribManuSpecific;
        private System.Windows.Forms.TextBox textBoxReadAttribManuID;
        private System.Windows.Forms.TextBox textBoxWriteAttribManuID;
        private System.Windows.Forms.ComboBox comboBoxWriteAttribManuSpecific;
        private System.Windows.Forms.Button buttonReadReportConfig;
        private System.Windows.Forms.ComboBox comboBoxReadReportConfigAddrMode;
        private System.Windows.Forms.TextBox textBoxReadReportConfigTargetAddr;
        private System.Windows.Forms.TextBox textBoxReadReportConfigDstEP;
        private System.Windows.Forms.TextBox textBoxReadReportConfigSrcEP;
        private System.Windows.Forms.TextBox textBoxReadReportConfigClusterID;
        private System.Windows.Forms.TextBox textBoxReadReportConfigAttribID;
        private System.Windows.Forms.ComboBox comboBoxReadReportConfigDirIsRx;
        private System.Windows.Forms.ComboBox comboBoxReadReportConfigDirection;
        private System.Windows.Forms.TextBox textBoxManyToOneRouteRequesRadius;
        private System.Windows.Forms.Button buttonManyToOneRouteRequest;
        private System.Windows.Forms.ComboBox comboBoxManyToOneRouteRequestCacheRoute;
        private System.Windows.Forms.Button buttonMgmtNwkUpdate;
        private System.Windows.Forms.ComboBox comboBoxMgmtNwkUpdateAddrMode;
        private System.Windows.Forms.TextBox textBoxMgmtNwkUpdateTargetAddr;
        private System.Windows.Forms.TextBox textBoxMgmtNwkUpdateChannelMask;
        private System.Windows.Forms.TextBox textBoxMgmtNwkUpdateScanDuration;
        private System.Windows.Forms.TextBox textBoxMgmtNwkUpdateScanCount;
        private System.Windows.Forms.Button buttonDiscoverCommands;
        private System.Windows.Forms.ComboBox comboBoxDiscoverCommandsAddrMode;
        private System.Windows.Forms.TextBox textBoxDiscoverCommandsTargetAddr;
        private System.Windows.Forms.TextBox textBoxDiscoverCommandsDstEP;
        private System.Windows.Forms.TextBox textBoxDiscoverCommandsSrcEP;
        private System.Windows.Forms.TextBox textBoxDiscoverCommandsClusterID;
        private System.Windows.Forms.ComboBox comboBoxDiscoverCommandsDirection;
        private System.Windows.Forms.TextBox textBoxDiscoverCommandsCommandID;
        private System.Windows.Forms.ComboBox comboBoxDiscoverCommandsManuSpecific;
        private System.Windows.Forms.TextBox textBoxDiscoverCommandsManuID;
        private System.Windows.Forms.TextBox textBoxDiscoverCommandsMaxCommands;
        private System.Windows.Forms.ComboBox comboBoxDiscoverAttributesExtended;
        private System.Windows.Forms.ComboBox comboBoxDiscoverCommandsRxGen;
        private System.Windows.Forms.TextBox textBoxMgmtNwkUpdateNwkManagerAddr;
        private System.Windows.Forms.Button buttonPermitJoinState;
        private System.Windows.Forms.TextBox textBoxRemoveChildAddr;
        private System.Windows.Forms.TextBox textBoxRemoveParentAddr;
        private System.Windows.Forms.Button buttonRemoveDevice;
        private System.Windows.Forms.ComboBox comboBoxLeaveChildren;
        private System.Windows.Forms.ComboBox comboBoxLeaveReJoin;
        private System.Windows.Forms.TextBox textBoxLeaveAddr;
        private System.Windows.Forms.Button buttonLeave;
        private System.Windows.Forms.TextBox textBoxLqiReqStartIndex;
        private System.Windows.Forms.TextBox textBoxLqiReqTargetAddr;
        private System.Windows.Forms.TextBox textBoxRestoreNwkFrameCounter;
        private System.Windows.Forms.ToolTip toolTipGeneralTooltip;
        private System.Windows.Forms.TextBox textBoxRawDataCommandsData;
        private System.Windows.Forms.TextBox textBoxRawDataCommandsClusterID;
        private System.Windows.Forms.TextBox textBoxRawDataCommandsDstEP;
        private System.Windows.Forms.TextBox textBoxRawDataCommandsSrcEP;
        private System.Windows.Forms.TextBox textBoxRawDataCommandsTargetAddr;
        private System.Windows.Forms.ComboBox comboBoxRawDataCommandsAddrMode;
        private System.Windows.Forms.Button buttonRawDataSend;
        private System.Windows.Forms.TextBox textBoxRawDataCommandsRadius;
        private System.Windows.Forms.TextBox textBoxRawDataCommandsSecurityMode;
        private System.Windows.Forms.TextBox textBoxRawDataCommandsProfileID;
        private System.Windows.Forms.TextBox textBoxUserReqAddr;
        private System.Windows.Forms.Button buttonUserReq;
        private System.Windows.Forms.TextBox textBoxUserSetReqAddr;
        private System.Windows.Forms.Button buttonUserSetReq;
        private System.Windows.Forms.TextBox textBoxUserSetReqDescription;
        private System.Windows.Forms.TextBox textBoxDiscoverAttributesStartAttrId;
        private System.Windows.Forms.TextBox textBoxBindTargetExtAddr;
        private System.Windows.Forms.TabPage Temperature;
        private System.Windows.Forms.TabPage tabPageDevice;
        private System.Windows.Forms.Button buttonCopyAddr;
        private System.Windows.Forms.Button buttonDiscoverDevices;
        private System.Windows.Forms.TextBox textBoxExtAddr;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBoxAddressList;
        private System.Windows.Forms.TextBox textBoxOOBDataKey;
        private System.Windows.Forms.TextBox textBoxOOBDataAddr;
        private System.Windows.Forms.Button buttonOOBCommissioningData;
        private System.Windows.Forms.Button buttonDiscoveryOnly;
        private System.Windows.Forms.CheckBox checkBoxDebug;
        private System.Windows.Forms.Button buttonNWKState;
        private System.Windows.Forms.TextBox textBoxPollInterval;
        private System.Windows.Forms.Button buttonPollInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox humidity_xiaomi;
        private System.Windows.Forms.TextBox temperature_xiaomi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox count_mess_xiaomi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tension;
        private System.Windows.Forms.TabPage smart_plug;
        private System.Windows.Forms.Button power_socket;
        private System.Windows.Forms.TextBox conso;
        private System.Windows.Forms.Button conso_smart;
        private System.Windows.Forms.RadioButton state;
        private System.Windows.Forms.ComboBox comboBox_direction;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button lamp_osram;
    }
}

