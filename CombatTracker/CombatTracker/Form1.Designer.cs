namespace CombatTracker
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPlayers = new System.Windows.Forms.TabPage();
            this.btnPicture = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.cboPlayerSize = new System.Windows.Forms.ComboBox();
            this.btnPlayerCombat = new System.Windows.Forms.Button();
            this.btnRemovePlayer = new System.Windows.Forms.Button();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPlayerType = new System.Windows.Forms.ComboBox();
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.txtPlayerInitiative = new System.Windows.Forms.TextBox();
            this.txtPlayerMaxHP = new System.Windows.Forms.TextBox();
            this.txtCurrentHP = new System.Windows.Forms.TextBox();
            this.txtPlayerAC = new System.Windows.Forms.TextBox();
            this.txtPlayer = new System.Windows.Forms.TextBox();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.tabNPC = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.cboNPCSize = new System.Windows.Forms.ComboBox();
            this.btnRemoveAllNPC = new System.Windows.Forms.Button();
            this.btnNPCCombat = new System.Windows.Forms.Button();
            this.btnRemoveNPC = new System.Windows.Forms.Button();
            this.btnAddNPC = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cboNPCType = new System.Windows.Forms.ComboBox();
            this.lstNPC = new System.Windows.Forms.ListBox();
            this.txtNPCInitiative = new System.Windows.Forms.TextBox();
            this.txtNPCHP = new System.Windows.Forms.TextBox();
            this.txtNPCAC = new System.Windows.Forms.TextBox();
            this.txtNPCName = new System.Windows.Forms.TextBox();
            this.tabControls = new System.Windows.Forms.TabPage();
            this.grpConcentrationCalc = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDamage = new System.Windows.Forms.TextBox();
            this.txtConstitution = new System.Windows.Forms.TextBox();
            this.lblConcentrationCheck = new System.Windows.Forms.Label();
            this.btnCheckConcentration = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.grpCombat = new System.Windows.Forms.GroupBox();
            this.btnDeathSave = new System.Windows.Forms.Button();
            this.btnTempHP = new System.Windows.Forms.Button();
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.btnDamage = new System.Windows.Forms.Button();
            this.txtHPChange = new System.Windows.Forms.TextBox();
            this.lblTurn = new System.Windows.Forms.Label();
            this.btnHeal = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.cboConditions = new System.Windows.Forms.ComboBox();
            this.btnRemoveConditions = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.btnAddCondition = new System.Windows.Forms.Button();
            this.btnConcentrate = new System.Windows.Forms.Button();
            this.btnReaction = new System.Windows.Forms.Button();
            this.btnRemoveCombat = new System.Windows.Forms.Button();
            this.lstCombat = new System.Windows.Forms.ListBox();
            this.grpCurrent = new System.Windows.Forms.GroupBox();
            this.picCurrent = new System.Windows.Forms.PictureBox();
            this.lblDeathSuccess = new System.Windows.Forms.Label();
            this.lblDeathFail = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblTempHP = new System.Windows.Forms.Label();
            this.lblConditions = new System.Windows.Forms.Label();
            this.lblConcentrating = new System.Windows.Forms.Label();
            this.lblReaction = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblAC = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnPicNPC = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPlayers.SuspendLayout();
            this.tabNPC.SuspendLayout();
            this.tabControls.SuspendLayout();
            this.grpConcentrationCalc.SuspendLayout();
            this.grpCombat.SuspendLayout();
            this.grpCurrent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrent)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPlayers);
            this.tabControl1.Controls.Add(this.tabNPC);
            this.tabControl1.Controls.Add(this.tabControls);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(331, 685);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPlayers
            // 
            this.tabPlayers.Controls.Add(this.btnPicture);
            this.tabPlayers.Controls.Add(this.label21);
            this.tabPlayers.Controls.Add(this.cboPlayerSize);
            this.tabPlayers.Controls.Add(this.btnPlayerCombat);
            this.tabPlayers.Controls.Add(this.btnRemovePlayer);
            this.tabPlayers.Controls.Add(this.btnAddPlayer);
            this.tabPlayers.Controls.Add(this.label7);
            this.tabPlayers.Controls.Add(this.label6);
            this.tabPlayers.Controls.Add(this.label5);
            this.tabPlayers.Controls.Add(this.label4);
            this.tabPlayers.Controls.Add(this.label3);
            this.tabPlayers.Controls.Add(this.label2);
            this.tabPlayers.Controls.Add(this.label1);
            this.tabPlayers.Controls.Add(this.cboPlayerType);
            this.tabPlayers.Controls.Add(this.lstPlayers);
            this.tabPlayers.Controls.Add(this.txtPlayerInitiative);
            this.tabPlayers.Controls.Add(this.txtPlayerMaxHP);
            this.tabPlayers.Controls.Add(this.txtCurrentHP);
            this.tabPlayers.Controls.Add(this.txtPlayerAC);
            this.tabPlayers.Controls.Add(this.txtPlayer);
            this.tabPlayers.Controls.Add(this.txtPlayerName);
            this.tabPlayers.Location = new System.Drawing.Point(4, 25);
            this.tabPlayers.Name = "tabPlayers";
            this.tabPlayers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlayers.Size = new System.Drawing.Size(323, 656);
            this.tabPlayers.TabIndex = 0;
            this.tabPlayers.Text = "Players";
            this.tabPlayers.UseVisualStyleBackColor = true;
            // 
            // btnPicture
            // 
            this.btnPicture.Location = new System.Drawing.Point(109, 559);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(106, 37);
            this.btnPicture.TabIndex = 20;
            this.btnPicture.Text = "Picture";
            this.btnPicture.UseVisualStyleBackColor = true;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(32, 270);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(36, 16);
            this.label21.TabIndex = 19;
            this.label21.Text = "Size:";
            // 
            // cboPlayerSize
            // 
            this.cboPlayerSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlayerSize.FormattingEnabled = true;
            this.cboPlayerSize.Items.AddRange(new object[] {
            "Gargantuan",
            "Huge",
            "Large",
            "Medium",
            "Small",
            "Tiny"});
            this.cboPlayerSize.Location = new System.Drawing.Point(88, 267);
            this.cboPlayerSize.MaxDropDownItems = 15;
            this.cboPlayerSize.Name = "cboPlayerSize";
            this.cboPlayerSize.Size = new System.Drawing.Size(199, 24);
            this.cboPlayerSize.Sorted = true;
            this.cboPlayerSize.TabIndex = 18;
            // 
            // btnPlayerCombat
            // 
            this.btnPlayerCombat.Location = new System.Drawing.Point(200, 608);
            this.btnPlayerCombat.Name = "btnPlayerCombat";
            this.btnPlayerCombat.Size = new System.Drawing.Size(99, 34);
            this.btnPlayerCombat.TabIndex = 17;
            this.btnPlayerCombat.Text = "To Combat";
            this.btnPlayerCombat.UseVisualStyleBackColor = true;
            this.btnPlayerCombat.Click += new System.EventHandler(this.btnPlayerCombat_Click);
            // 
            // btnRemovePlayer
            // 
            this.btnRemovePlayer.Location = new System.Drawing.Point(202, 314);
            this.btnRemovePlayer.Name = "btnRemovePlayer";
            this.btnRemovePlayer.Size = new System.Drawing.Size(106, 37);
            this.btnRemovePlayer.TabIndex = 16;
            this.btnRemovePlayer.Text = "Remove";
            this.btnRemovePlayer.UseVisualStyleBackColor = true;
            this.btnRemovePlayer.Click += new System.EventHandler(this.btnRemovePlayer_Click);
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(13, 314);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(106, 37);
            this.btnAddPlayer.TabIndex = 15;
            this.btnAddPlayer.Text = "Add";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 617);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Initiative:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Max HP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Current HP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "AC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Player:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name:";
            // 
            // cboPlayerType
            // 
            this.cboPlayerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlayerType.FormattingEnabled = true;
            this.cboPlayerType.Items.AddRange(new object[] {
            "Aberration",
            "Beast",
            "Celestial",
            "Construct",
            "Dragon",
            "Elemental",
            "Fey",
            "Fiend",
            "Giant",
            "Humanoid",
            "Monstrosity",
            "Ooze",
            "Plant",
            "Undead"});
            this.cboPlayerType.Location = new System.Drawing.Point(89, 221);
            this.cboPlayerType.MaxDropDownItems = 15;
            this.cboPlayerType.Name = "cboPlayerType";
            this.cboPlayerType.Size = new System.Drawing.Size(199, 24);
            this.cboPlayerType.Sorted = true;
            this.cboPlayerType.TabIndex = 7;
            // 
            // lstPlayers
            // 
            this.lstPlayers.FormattingEnabled = true;
            this.lstPlayers.ItemHeight = 16;
            this.lstPlayers.Location = new System.Drawing.Point(8, 357);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Size = new System.Drawing.Size(309, 196);
            this.lstPlayers.TabIndex = 6;
            // 
            // txtPlayerInitiative
            // 
            this.txtPlayerInitiative.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlayerInitiative.Location = new System.Drawing.Point(91, 615);
            this.txtPlayerInitiative.Name = "txtPlayerInitiative";
            this.txtPlayerInitiative.Size = new System.Drawing.Size(90, 22);
            this.txtPlayerInitiative.TabIndex = 5;
            // 
            // txtPlayerMaxHP
            // 
            this.txtPlayerMaxHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlayerMaxHP.Location = new System.Drawing.Point(224, 174);
            this.txtPlayerMaxHP.Name = "txtPlayerMaxHP";
            this.txtPlayerMaxHP.Size = new System.Drawing.Size(61, 22);
            this.txtPlayerMaxHP.TabIndex = 4;
            // 
            // txtCurrentHP
            // 
            this.txtCurrentHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrentHP.Location = new System.Drawing.Point(91, 174);
            this.txtCurrentHP.Name = "txtCurrentHP";
            this.txtCurrentHP.Size = new System.Drawing.Size(61, 22);
            this.txtCurrentHP.TabIndex = 3;
            // 
            // txtPlayerAC
            // 
            this.txtPlayerAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlayerAC.Location = new System.Drawing.Point(91, 124);
            this.txtPlayerAC.Name = "txtPlayerAC";
            this.txtPlayerAC.Size = new System.Drawing.Size(199, 22);
            this.txtPlayerAC.TabIndex = 2;
            // 
            // txtPlayer
            // 
            this.txtPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlayer.Location = new System.Drawing.Point(91, 73);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(199, 22);
            this.txtPlayer.TabIndex = 1;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlayerName.Location = new System.Drawing.Point(91, 29);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(199, 22);
            this.txtPlayerName.TabIndex = 0;
            // 
            // tabNPC
            // 
            this.tabNPC.Controls.Add(this.btnPicNPC);
            this.tabNPC.Controls.Add(this.label22);
            this.tabNPC.Controls.Add(this.cboNPCSize);
            this.tabNPC.Controls.Add(this.btnRemoveAllNPC);
            this.tabNPC.Controls.Add(this.btnNPCCombat);
            this.tabNPC.Controls.Add(this.btnRemoveNPC);
            this.tabNPC.Controls.Add(this.btnAddNPC);
            this.tabNPC.Controls.Add(this.label8);
            this.tabNPC.Controls.Add(this.label9);
            this.tabNPC.Controls.Add(this.label10);
            this.tabNPC.Controls.Add(this.label12);
            this.tabNPC.Controls.Add(this.label14);
            this.tabNPC.Controls.Add(this.cboNPCType);
            this.tabNPC.Controls.Add(this.lstNPC);
            this.tabNPC.Controls.Add(this.txtNPCInitiative);
            this.tabNPC.Controls.Add(this.txtNPCHP);
            this.tabNPC.Controls.Add(this.txtNPCAC);
            this.tabNPC.Controls.Add(this.txtNPCName);
            this.tabNPC.Location = new System.Drawing.Point(4, 25);
            this.tabNPC.Name = "tabNPC";
            this.tabNPC.Padding = new System.Windows.Forms.Padding(3);
            this.tabNPC.Size = new System.Drawing.Size(323, 656);
            this.tabNPC.TabIndex = 1;
            this.tabNPC.Text = "NPCs";
            this.tabNPC.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(41, 264);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(36, 16);
            this.label22.TabIndex = 38;
            this.label22.Text = "Size:";
            // 
            // cboNPCSize
            // 
            this.cboNPCSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNPCSize.FormattingEnabled = true;
            this.cboNPCSize.Items.AddRange(new object[] {
            "Gargantuan",
            "Huge",
            "Large",
            "Medium",
            "Small",
            "Tiny"});
            this.cboNPCSize.Location = new System.Drawing.Point(88, 261);
            this.cboNPCSize.MaxDropDownItems = 15;
            this.cboNPCSize.Name = "cboNPCSize";
            this.cboNPCSize.Size = new System.Drawing.Size(199, 24);
            this.cboNPCSize.Sorted = true;
            this.cboNPCSize.TabIndex = 37;
            // 
            // btnRemoveAllNPC
            // 
            this.btnRemoveAllNPC.Location = new System.Drawing.Point(209, 307);
            this.btnRemoveAllNPC.Name = "btnRemoveAllNPC";
            this.btnRemoveAllNPC.Size = new System.Drawing.Size(106, 37);
            this.btnRemoveAllNPC.TabIndex = 36;
            this.btnRemoveAllNPC.Text = "Remove All";
            this.btnRemoveAllNPC.UseVisualStyleBackColor = true;
            this.btnRemoveAllNPC.Click += new System.EventHandler(this.btnRemoveAllNPC_Click);
            // 
            // btnNPCCombat
            // 
            this.btnNPCCombat.Location = new System.Drawing.Point(200, 600);
            this.btnNPCCombat.Name = "btnNPCCombat";
            this.btnNPCCombat.Size = new System.Drawing.Size(99, 34);
            this.btnNPCCombat.TabIndex = 35;
            this.btnNPCCombat.Text = "To Combat";
            this.btnNPCCombat.UseVisualStyleBackColor = true;
            this.btnNPCCombat.Click += new System.EventHandler(this.btnNPCCombat_Click);
            // 
            // btnRemoveNPC
            // 
            this.btnRemoveNPC.Location = new System.Drawing.Point(106, 307);
            this.btnRemoveNPC.Name = "btnRemoveNPC";
            this.btnRemoveNPC.Size = new System.Drawing.Size(97, 37);
            this.btnRemoveNPC.TabIndex = 34;
            this.btnRemoveNPC.Text = "Remove";
            this.btnRemoveNPC.UseVisualStyleBackColor = true;
            this.btnRemoveNPC.Click += new System.EventHandler(this.btnRemoveNPC_Click);
            // 
            // btnAddNPC
            // 
            this.btnAddNPC.Location = new System.Drawing.Point(6, 307);
            this.btnAddNPC.Name = "btnAddNPC";
            this.btnAddNPC.Size = new System.Drawing.Size(94, 37);
            this.btnAddNPC.TabIndex = 33;
            this.btnAddNPC.Text = "Add";
            this.btnAddNPC.UseVisualStyleBackColor = true;
            this.btnAddNPC.Click += new System.EventHandler(this.btnAddNPC_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 609);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Initiative:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "Type:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "Max HP:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "AC:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(35, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 16);
            this.label14.TabIndex = 26;
            this.label14.Text = "Name:";
            // 
            // cboNPCType
            // 
            this.cboNPCType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNPCType.FormattingEnabled = true;
            this.cboNPCType.Items.AddRange(new object[] {
            "Aberration",
            "Beast",
            "Celestial",
            "Construct",
            "Dragon",
            "Elemental",
            "Fey",
            "Fiend",
            "Giant",
            "Humanoid",
            "Monstrosity",
            "Ooze",
            "Plant",
            "Undead"});
            this.cboNPCType.Location = new System.Drawing.Point(88, 207);
            this.cboNPCType.MaxDropDownItems = 15;
            this.cboNPCType.Name = "cboNPCType";
            this.cboNPCType.Size = new System.Drawing.Size(199, 24);
            this.cboNPCType.Sorted = true;
            this.cboNPCType.TabIndex = 25;
            // 
            // lstNPC
            // 
            this.lstNPC.FormattingEnabled = true;
            this.lstNPC.ItemHeight = 16;
            this.lstNPC.Location = new System.Drawing.Point(6, 350);
            this.lstNPC.Name = "lstNPC";
            this.lstNPC.Size = new System.Drawing.Size(309, 196);
            this.lstNPC.TabIndex = 24;
            // 
            // txtNPCInitiative
            // 
            this.txtNPCInitiative.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNPCInitiative.Location = new System.Drawing.Point(91, 607);
            this.txtNPCInitiative.Name = "txtNPCInitiative";
            this.txtNPCInitiative.Size = new System.Drawing.Size(90, 22);
            this.txtNPCInitiative.TabIndex = 23;
            // 
            // txtNPCHP
            // 
            this.txtNPCHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNPCHP.Location = new System.Drawing.Point(88, 147);
            this.txtNPCHP.Name = "txtNPCHP";
            this.txtNPCHP.Size = new System.Drawing.Size(199, 22);
            this.txtNPCHP.TabIndex = 22;
            // 
            // txtNPCAC
            // 
            this.txtNPCAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNPCAC.Location = new System.Drawing.Point(88, 88);
            this.txtNPCAC.Name = "txtNPCAC";
            this.txtNPCAC.Size = new System.Drawing.Size(199, 22);
            this.txtNPCAC.TabIndex = 20;
            // 
            // txtNPCName
            // 
            this.txtNPCName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNPCName.Location = new System.Drawing.Point(88, 40);
            this.txtNPCName.Name = "txtNPCName";
            this.txtNPCName.Size = new System.Drawing.Size(199, 22);
            this.txtNPCName.TabIndex = 18;
            // 
            // tabControls
            // 
            this.tabControls.Controls.Add(this.grpConcentrationCalc);
            this.tabControls.Controls.Add(this.btnEnd);
            this.tabControls.Controls.Add(this.btnStart);
            this.tabControls.Location = new System.Drawing.Point(4, 25);
            this.tabControls.Name = "tabControls";
            this.tabControls.Size = new System.Drawing.Size(323, 656);
            this.tabControls.TabIndex = 2;
            this.tabControls.Text = "Controls";
            this.tabControls.UseVisualStyleBackColor = true;
            // 
            // grpConcentrationCalc
            // 
            this.grpConcentrationCalc.Controls.Add(this.label18);
            this.grpConcentrationCalc.Controls.Add(this.label17);
            this.grpConcentrationCalc.Controls.Add(this.txtDamage);
            this.grpConcentrationCalc.Controls.Add(this.txtConstitution);
            this.grpConcentrationCalc.Controls.Add(this.lblConcentrationCheck);
            this.grpConcentrationCalc.Controls.Add(this.btnCheckConcentration);
            this.grpConcentrationCalc.Location = new System.Drawing.Point(4, 424);
            this.grpConcentrationCalc.Name = "grpConcentrationCalc";
            this.grpConcentrationCalc.Size = new System.Drawing.Size(316, 228);
            this.grpConcentrationCalc.TabIndex = 29;
            this.grpConcentrationCalc.TabStop = false;
            this.grpConcentrationCalc.Text = "Concentration Calculator";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 84);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(163, 16);
            this.label18.TabIndex = 29;
            this.label18.Text = "Constitution Saving Throw:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(106, 39);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 16);
            this.label17.TabIndex = 27;
            this.label17.Text = "Damage:";
            // 
            // txtDamage
            // 
            this.txtDamage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDamage.Location = new System.Drawing.Point(192, 37);
            this.txtDamage.Name = "txtDamage";
            this.txtDamage.Size = new System.Drawing.Size(118, 22);
            this.txtDamage.TabIndex = 28;
            // 
            // txtConstitution
            // 
            this.txtConstitution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConstitution.Location = new System.Drawing.Point(192, 82);
            this.txtConstitution.Name = "txtConstitution";
            this.txtConstitution.Size = new System.Drawing.Size(118, 22);
            this.txtConstitution.TabIndex = 27;
            // 
            // lblConcentrationCheck
            // 
            this.lblConcentrationCheck.AutoSize = true;
            this.lblConcentrationCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcentrationCheck.ForeColor = System.Drawing.Color.Red;
            this.lblConcentrationCheck.Location = new System.Drawing.Point(113, 185);
            this.lblConcentrationCheck.Name = "lblConcentrationCheck";
            this.lblConcentrationCheck.Size = new System.Drawing.Size(0, 32);
            this.lblConcentrationCheck.TabIndex = 27;
            // 
            // btnCheckConcentration
            // 
            this.btnCheckConcentration.Location = new System.Drawing.Point(109, 124);
            this.btnCheckConcentration.Name = "btnCheckConcentration";
            this.btnCheckConcentration.Size = new System.Drawing.Size(106, 37);
            this.btnCheckConcentration.TabIndex = 27;
            this.btnCheckConcentration.Text = "Check";
            this.btnCheckConcentration.UseVisualStyleBackColor = true;
            this.btnCheckConcentration.Click += new System.EventHandler(this.btnCheckConcentration_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(181, 187);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(122, 49);
            this.btnEnd.TabIndex = 28;
            this.btnEnd.Text = "End Combat";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(19, 187);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(122, 49);
            this.btnStart.TabIndex = 27;
            this.btnStart.Text = "Start Combat";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // grpCombat
            // 
            this.grpCombat.Controls.Add(this.btnDeathSave);
            this.grpCombat.Controls.Add(this.btnTempHP);
            this.grpCombat.Controls.Add(this.btnEndTurn);
            this.grpCombat.Controls.Add(this.btnDamage);
            this.grpCombat.Controls.Add(this.txtHPChange);
            this.grpCombat.Controls.Add(this.lblTurn);
            this.grpCombat.Controls.Add(this.btnHeal);
            this.grpCombat.Controls.Add(this.label20);
            this.grpCombat.Controls.Add(this.lblRound);
            this.grpCombat.Controls.Add(this.cboConditions);
            this.grpCombat.Controls.Add(this.btnRemoveConditions);
            this.grpCombat.Controls.Add(this.label19);
            this.grpCombat.Controls.Add(this.btnAddCondition);
            this.grpCombat.Controls.Add(this.btnConcentrate);
            this.grpCombat.Controls.Add(this.btnReaction);
            this.grpCombat.Controls.Add(this.btnRemoveCombat);
            this.grpCombat.Controls.Add(this.lstCombat);
            this.grpCombat.Location = new System.Drawing.Point(349, 13);
            this.grpCombat.Name = "grpCombat";
            this.grpCombat.Size = new System.Drawing.Size(965, 452);
            this.grpCombat.TabIndex = 1;
            this.grpCombat.TabStop = false;
            this.grpCombat.Text = "Combat";
            // 
            // btnDeathSave
            // 
            this.btnDeathSave.Location = new System.Drawing.Point(121, 218);
            this.btnDeathSave.Name = "btnDeathSave";
            this.btnDeathSave.Size = new System.Drawing.Size(101, 37);
            this.btnDeathSave.TabIndex = 28;
            this.btnDeathSave.Text = "Death Save";
            this.btnDeathSave.UseVisualStyleBackColor = true;
            this.btnDeathSave.Click += new System.EventHandler(this.btnDeathSave_Click);
            // 
            // btnTempHP
            // 
            this.btnTempHP.Location = new System.Drawing.Point(121, 297);
            this.btnTempHP.Name = "btnTempHP";
            this.btnTempHP.Size = new System.Drawing.Size(101, 37);
            this.btnTempHP.TabIndex = 27;
            this.btnTempHP.Text = "Temp HP";
            this.btnTempHP.UseVisualStyleBackColor = true;
            this.btnTempHP.Click += new System.EventHandler(this.btnTempHP_Click);
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndTurn.Location = new System.Drawing.Point(23, 340);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(295, 101);
            this.btnEndTurn.TabIndex = 26;
            this.btnEndTurn.Text = "End Turn";
            this.btnEndTurn.UseVisualStyleBackColor = true;
            this.btnEndTurn.Click += new System.EventHandler(this.btnEndTurn_Click);
            // 
            // btnDamage
            // 
            this.btnDamage.Location = new System.Drawing.Point(235, 258);
            this.btnDamage.Name = "btnDamage";
            this.btnDamage.Size = new System.Drawing.Size(83, 37);
            this.btnDamage.TabIndex = 25;
            this.btnDamage.Text = "Damage";
            this.btnDamage.UseVisualStyleBackColor = true;
            this.btnDamage.Click += new System.EventHandler(this.btnDamage_Click);
            // 
            // txtHPChange
            // 
            this.txtHPChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHPChange.Location = new System.Drawing.Point(121, 266);
            this.txtHPChange.Name = "txtHPChange";
            this.txtHPChange.Size = new System.Drawing.Size(101, 22);
            this.txtHPChange.TabIndex = 18;
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTurn.Location = new System.Drawing.Point(659, 367);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(56, 20);
            this.lblTurn.TabIndex = 30;
            this.lblTurn.Text = "Player";
            // 
            // btnHeal
            // 
            this.btnHeal.Location = new System.Drawing.Point(23, 258);
            this.btnHeal.Name = "btnHeal";
            this.btnHeal.Size = new System.Drawing.Size(83, 37);
            this.btnHeal.TabIndex = 24;
            this.btnHeal.Text = "Heal";
            this.btnHeal.UseVisualStyleBackColor = true;
            this.btnHeal.Click += new System.EventHandler(this.btnHeal_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(650, 404);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 20);
            this.label20.TabIndex = 28;
            this.label20.Text = "Turn";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblRound.Location = new System.Drawing.Point(473, 367);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(56, 20);
            this.lblRound.TabIndex = 29;
            this.lblRound.Text = "Player";
            // 
            // cboConditions
            // 
            this.cboConditions.FormattingEnabled = true;
            this.cboConditions.Items.AddRange(new object[] {
            "Blinded",
            "Charmed",
            "Deafened",
            "Enlarged",
            "Exhausted",
            "Frightened",
            "Grappled",
            "Incapacitated",
            "Invisible",
            "Paralyzed",
            "Petrified",
            "Poisoned",
            "Prone",
            "Reduced",
            "Restrained",
            "Stunned",
            "Unconscious"});
            this.cboConditions.Location = new System.Drawing.Point(153, 109);
            this.cboConditions.Name = "cboConditions";
            this.cboConditions.Size = new System.Drawing.Size(165, 24);
            this.cboConditions.TabIndex = 23;
            // 
            // btnRemoveConditions
            // 
            this.btnRemoveConditions.Location = new System.Drawing.Point(117, 146);
            this.btnRemoveConditions.Name = "btnRemoveConditions";
            this.btnRemoveConditions.Size = new System.Drawing.Size(122, 49);
            this.btnRemoveConditions.TabIndex = 22;
            this.btnRemoveConditions.Text = "Remove Conditions";
            this.btnRemoveConditions.UseVisualStyleBackColor = true;
            this.btnRemoveConditions.Click += new System.EventHandler(this.btnRemoveConditions_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(462, 404);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 20);
            this.label19.TabIndex = 27;
            this.label19.Text = "Round";
            // 
            // btnAddCondition
            // 
            this.btnAddCondition.Location = new System.Drawing.Point(23, 103);
            this.btnAddCondition.Name = "btnAddCondition";
            this.btnAddCondition.Size = new System.Drawing.Size(113, 37);
            this.btnAddCondition.TabIndex = 21;
            this.btnAddCondition.Text = "Add Condition";
            this.btnAddCondition.UseVisualStyleBackColor = true;
            this.btnAddCondition.Click += new System.EventHandler(this.btnAddCondition_Click);
            // 
            // btnConcentrate
            // 
            this.btnConcentrate.Location = new System.Drawing.Point(212, 39);
            this.btnConcentrate.Name = "btnConcentrate";
            this.btnConcentrate.Size = new System.Drawing.Size(106, 37);
            this.btnConcentrate.TabIndex = 20;
            this.btnConcentrate.Text = "Concentrate";
            this.btnConcentrate.UseVisualStyleBackColor = true;
            this.btnConcentrate.Click += new System.EventHandler(this.btnConcentrate_Click);
            // 
            // btnReaction
            // 
            this.btnReaction.Location = new System.Drawing.Point(23, 39);
            this.btnReaction.Name = "btnReaction";
            this.btnReaction.Size = new System.Drawing.Size(106, 37);
            this.btnReaction.TabIndex = 19;
            this.btnReaction.Text = "Use Reaction";
            this.btnReaction.UseVisualStyleBackColor = true;
            this.btnReaction.Click += new System.EventHandler(this.btnReaction_Click);
            // 
            // btnRemoveCombat
            // 
            this.btnRemoveCombat.Location = new System.Drawing.Point(853, 381);
            this.btnRemoveCombat.Name = "btnRemoveCombat";
            this.btnRemoveCombat.Size = new System.Drawing.Size(106, 37);
            this.btnRemoveCombat.TabIndex = 18;
            this.btnRemoveCombat.Text = "Remove";
            this.btnRemoveCombat.UseVisualStyleBackColor = true;
            this.btnRemoveCombat.Click += new System.EventHandler(this.btnRemoveCombat_Click);
            // 
            // lstCombat
            // 
            this.lstCombat.FormattingEnabled = true;
            this.lstCombat.ItemHeight = 16;
            this.lstCombat.Location = new System.Drawing.Point(357, 26);
            this.lstCombat.Name = "lstCombat";
            this.lstCombat.Size = new System.Drawing.Size(602, 324);
            this.lstCombat.TabIndex = 18;
            // 
            // grpCurrent
            // 
            this.grpCurrent.Controls.Add(this.picCurrent);
            this.grpCurrent.Controls.Add(this.lblDeathSuccess);
            this.grpCurrent.Controls.Add(this.lblDeathFail);
            this.grpCurrent.Controls.Add(this.lblSize);
            this.grpCurrent.Controls.Add(this.label24);
            this.grpCurrent.Controls.Add(this.lblTempHP);
            this.grpCurrent.Controls.Add(this.lblConditions);
            this.grpCurrent.Controls.Add(this.lblConcentrating);
            this.grpCurrent.Controls.Add(this.lblReaction);
            this.grpCurrent.Controls.Add(this.lblName);
            this.grpCurrent.Controls.Add(this.lblType);
            this.grpCurrent.Controls.Add(this.lblAC);
            this.grpCurrent.Controls.Add(this.lblHP);
            this.grpCurrent.Controls.Add(this.lblPlayer);
            this.grpCurrent.Controls.Add(this.label16);
            this.grpCurrent.Controls.Add(this.label15);
            this.grpCurrent.Controls.Add(this.label13);
            this.grpCurrent.Controls.Add(this.label11);
            this.grpCurrent.Location = new System.Drawing.Point(349, 471);
            this.grpCurrent.Name = "grpCurrent";
            this.grpCurrent.Size = new System.Drawing.Size(965, 222);
            this.grpCurrent.TabIndex = 2;
            this.grpCurrent.TabStop = false;
            this.grpCurrent.Text = "Current";
            // 
            // picCurrent
            // 
            this.picCurrent.Image = global::CombatTracker.Properties.Resources._20210501_072726;
            this.picCurrent.Location = new System.Drawing.Point(7, 18);
            this.picCurrent.Name = "picCurrent";
            this.picCurrent.Size = new System.Drawing.Size(246, 198);
            this.picCurrent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCurrent.TabIndex = 36;
            this.picCurrent.TabStop = false;
            // 
            // lblDeathSuccess
            // 
            this.lblDeathSuccess.AutoSize = true;
            this.lblDeathSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeathSuccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDeathSuccess.Location = new System.Drawing.Point(498, 18);
            this.lblDeathSuccess.Name = "lblDeathSuccess";
            this.lblDeathSuccess.Size = new System.Drawing.Size(56, 20);
            this.lblDeathSuccess.TabIndex = 35;
            this.lblDeathSuccess.Text = "Player";
            // 
            // lblDeathFail
            // 
            this.lblDeathFail.AutoSize = true;
            this.lblDeathFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeathFail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDeathFail.Location = new System.Drawing.Point(274, 18);
            this.lblDeathFail.Name = "lblDeathFail";
            this.lblDeathFail.Size = new System.Drawing.Size(56, 20);
            this.lblDeathFail.TabIndex = 34;
            this.lblDeathFail.Text = "Player";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSize.Location = new System.Drawing.Point(652, 161);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(56, 20);
            this.lblSize.TabIndex = 33;
            this.lblSize.Text = "Player";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(663, 183);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(42, 20);
            this.label24.TabIndex = 32;
            this.label24.Text = "Size";
            // 
            // lblTempHP
            // 
            this.lblTempHP.AutoSize = true;
            this.lblTempHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTempHP.Location = new System.Drawing.Point(418, 135);
            this.lblTempHP.Name = "lblTempHP";
            this.lblTempHP.Size = new System.Drawing.Size(56, 20);
            this.lblTempHP.TabIndex = 31;
            this.lblTempHP.Text = "Player";
            // 
            // lblConditions
            // 
            this.lblConditions.AutoSize = true;
            this.lblConditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConditions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblConditions.Location = new System.Drawing.Point(252, 111);
            this.lblConditions.Name = "lblConditions";
            this.lblConditions.Size = new System.Drawing.Size(88, 20);
            this.lblConditions.TabIndex = 26;
            this.lblConditions.Text = "Conditions";
            // 
            // lblConcentrating
            // 
            this.lblConcentrating.AutoSize = true;
            this.lblConcentrating.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcentrating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblConcentrating.Location = new System.Drawing.Point(723, 99);
            this.lblConcentrating.Name = "lblConcentrating";
            this.lblConcentrating.Size = new System.Drawing.Size(192, 32);
            this.lblConcentrating.TabIndex = 25;
            this.lblConcentrating.Text = "Concentrating";
            // 
            // lblReaction
            // 
            this.lblReaction.AutoSize = true;
            this.lblReaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblReaction.Location = new System.Drawing.Point(723, 39);
            this.lblReaction.Name = "lblReaction";
            this.lblReaction.Size = new System.Drawing.Size(200, 32);
            this.lblReaction.TabIndex = 24;
            this.lblReaction.Text = "Used Reaction";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(247, 51);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(162, 54);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Player";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblType.Location = new System.Drawing.Point(804, 161);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(56, 20);
            this.lblType.TabIndex = 22;
            this.lblType.Text = "Player";
            // 
            // lblAC
            // 
            this.lblAC.AutoSize = true;
            this.lblAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAC.Location = new System.Drawing.Point(562, 161);
            this.lblAC.Name = "lblAC";
            this.lblAC.Size = new System.Drawing.Size(56, 20);
            this.lblAC.TabIndex = 21;
            this.lblAC.Text = "Player";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblHP.Location = new System.Drawing.Point(418, 161);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(56, 20);
            this.lblHP.TabIndex = 20;
            this.lblHP.Text = "Player";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPlayer.Location = new System.Drawing.Point(262, 161);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(56, 20);
            this.lblPlayer.TabIndex = 19;
            this.lblPlayer.Text = "Player";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(815, 183);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 20);
            this.label16.TabIndex = 18;
            this.label16.Text = "Type";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(562, 183);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 20);
            this.label15.TabIndex = 18;
            this.label15.Text = "AC";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(432, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "HP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(262, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Player";
            // 
            // btnPicNPC
            // 
            this.btnPicNPC.Location = new System.Drawing.Point(91, 552);
            this.btnPicNPC.Name = "btnPicNPC";
            this.btnPicNPC.Size = new System.Drawing.Size(106, 37);
            this.btnPicNPC.TabIndex = 39;
            this.btnPicNPC.Text = "Picture";
            this.btnPicNPC.UseVisualStyleBackColor = true;
            this.btnPicNPC.Click += new System.EventHandler(this.btnPicNPC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 709);
            this.Controls.Add(this.grpCurrent);
            this.Controls.Add(this.grpCombat);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "CombatTracker";
            this.tabControl1.ResumeLayout(false);
            this.tabPlayers.ResumeLayout(false);
            this.tabPlayers.PerformLayout();
            this.tabNPC.ResumeLayout(false);
            this.tabNPC.PerformLayout();
            this.tabControls.ResumeLayout(false);
            this.grpConcentrationCalc.ResumeLayout(false);
            this.grpConcentrationCalc.PerformLayout();
            this.grpCombat.ResumeLayout(false);
            this.grpCombat.PerformLayout();
            this.grpCurrent.ResumeLayout(false);
            this.grpCurrent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPlayers;
        private System.Windows.Forms.TabPage tabNPC;
        private System.Windows.Forms.GroupBox grpCombat;
        private System.Windows.Forms.GroupBox grpCurrent;
        private System.Windows.Forms.TabPage tabControls;
        private System.Windows.Forms.TextBox txtPlayer;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.TextBox txtPlayerMaxHP;
        private System.Windows.Forms.TextBox txtCurrentHP;
        private System.Windows.Forms.TextBox txtPlayerAC;
        private System.Windows.Forms.ComboBox cboPlayerType;
        private System.Windows.Forms.ListBox lstPlayers;
        private System.Windows.Forms.TextBox txtPlayerInitiative;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemovePlayer;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnPlayerCombat;
        private System.Windows.Forms.Button btnNPCCombat;
        private System.Windows.Forms.Button btnRemoveNPC;
        private System.Windows.Forms.Button btnAddNPC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboNPCType;
        private System.Windows.Forms.ListBox lstNPC;
        private System.Windows.Forms.TextBox txtNPCInitiative;
        private System.Windows.Forms.TextBox txtNPCHP;
        private System.Windows.Forms.TextBox txtNPCAC;
        private System.Windows.Forms.TextBox txtNPCName;
        private System.Windows.Forms.Button btnRemoveAllNPC;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblAC;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblConditions;
        private System.Windows.Forms.Label lblConcentrating;
        private System.Windows.Forms.Label lblReaction;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnReaction;
        private System.Windows.Forms.Button btnRemoveCombat;
        private System.Windows.Forms.ListBox lstCombat;
        private System.Windows.Forms.Button btnDamage;
        private System.Windows.Forms.TextBox txtHPChange;
        private System.Windows.Forms.Button btnHeal;
        private System.Windows.Forms.ComboBox cboConditions;
        private System.Windows.Forms.Button btnRemoveConditions;
        private System.Windows.Forms.Button btnAddCondition;
        private System.Windows.Forms.Button btnConcentrate;
        private System.Windows.Forms.Button btnEndTurn;
        private System.Windows.Forms.GroupBox grpConcentrationCalc;
        private System.Windows.Forms.Label lblConcentrationCheck;
        private System.Windows.Forms.Button btnCheckConcentration;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDamage;
        private System.Windows.Forms.TextBox txtConstitution;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cboPlayerSize;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cboNPCSize;
        private System.Windows.Forms.Label lblTempHP;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnTempHP;
        private System.Windows.Forms.Label lblDeathFail;
        private System.Windows.Forms.Label lblDeathSuccess;
        private System.Windows.Forms.Button btnDeathSave;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.PictureBox picCurrent;
        private System.Windows.Forms.Button btnPicNPC;
    }
}

