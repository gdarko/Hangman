namespace Hangman
{
    partial class HangmanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HangmanForm));
            this.lblPogodiZbor = new System.Windows.Forms.Label();
            this.btnResults = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.gbVasiInformacii = new System.Windows.Forms.GroupBox();
            this.lblPoeni = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPrekar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameMI = new System.Windows.Forms.ToolStripMenuItem();
            this.нивоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.листаСоРезултатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.опцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заАпликацијатаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструкцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.излезToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRemainingTime = new System.Windows.Forms.Label();
            this.timerRemainingTime = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.charP = new System.Windows.Forms.Button();
            this.charM = new System.Windows.Forms.Button();
            this.charN = new System.Windows.Forms.Button();
            this.charL = new System.Windows.Forms.Button();
            this.charK = new System.Windows.Forms.Button();
            this.charJ = new System.Windows.Forms.Button();
            this.charH = new System.Windows.Forms.Button();
            this.charQ = new System.Windows.Forms.Button();
            this.charO = new System.Windows.Forms.Button();
            this.charI = new System.Windows.Forms.Button();
            this.charU = new System.Windows.Forms.Button();
            this.charB = new System.Windows.Forms.Button();
            this.charY = new System.Windows.Forms.Button();
            this.charV = new System.Windows.Forms.Button();
            this.charC = new System.Windows.Forms.Button();
            this.charX = new System.Windows.Forms.Button();
            this.charZ = new System.Windows.Forms.Button();
            this.charF = new System.Windows.Forms.Button();
            this.charD = new System.Windows.Forms.Button();
            this.charS = new System.Windows.Forms.Button();
            this.charG = new System.Windows.Forms.Button();
            this.charA = new System.Windows.Forms.Button();
            this.charW = new System.Windows.Forms.Button();
            this.charE = new System.Windows.Forms.Button();
            this.charR = new System.Windows.Forms.Button();
            this.charT = new System.Windows.Forms.Button();
            this.pbGuy = new System.Windows.Forms.PictureBox();
            this.gbVasiInformacii.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPogodiZbor
            // 
            resources.ApplyResources(this.lblPogodiZbor, "lblPogodiZbor");
            this.lblPogodiZbor.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPogodiZbor.Name = "lblPogodiZbor";
            // 
            // btnResults
            // 
            this.btnResults.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnResults.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnResults, "btnResults");
            this.btnResults.ForeColor = System.Drawing.Color.White;
            this.btnResults.Name = "btnResults";
            this.btnResults.UseVisualStyleBackColor = false;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btnPause, "btnPause");
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.ForeColor = System.Drawing.Color.White;
            this.btnPause.Name = "btnPause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Goldenrod;
            this.btnStartGame.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnStartGame, "btnStartGame");
            this.btnStartGame.ForeColor = System.Drawing.Color.White;
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.UseVisualStyleBackColor = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.btnHelp, "btnHelp");
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // gbVasiInformacii
            // 
            this.gbVasiInformacii.BackColor = System.Drawing.Color.Transparent;
            this.gbVasiInformacii.Controls.Add(this.lblPoeni);
            this.gbVasiInformacii.Controls.Add(this.label4);
            this.gbVasiInformacii.Controls.Add(this.label5);
            this.gbVasiInformacii.Controls.Add(this.tbPrekar);
            this.gbVasiInformacii.Controls.Add(this.label3);
            this.gbVasiInformacii.Controls.Add(this.label2);
            this.gbVasiInformacii.Controls.Add(this.tbPrezime);
            this.gbVasiInformacii.Controls.Add(this.tbIme);
            this.gbVasiInformacii.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            resources.ApplyResources(this.gbVasiInformacii, "gbVasiInformacii");
            this.gbVasiInformacii.ForeColor = System.Drawing.Color.DarkGreen;
            this.gbVasiInformacii.Name = "gbVasiInformacii";
            this.gbVasiInformacii.TabStop = false;
            // 
            // lblPoeni
            // 
            resources.ApplyResources(this.lblPoeni, "lblPoeni");
            this.lblPoeni.Name = "lblPoeni";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // tbPrekar
            // 
            resources.ApplyResources(this.tbPrekar, "tbPrekar");
            this.tbPrekar.Name = "tbPrekar";
            this.tbPrekar.ReadOnly = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tbPrezime
            // 
            resources.ApplyResources(this.tbPrezime, "tbPrezime");
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.ReadOnly = true;
            // 
            // tbIme
            // 
            resources.ApplyResources(this.tbIme, "tbIme");
            this.tbIme.Name = "tbIme";
            this.tbIme.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem,
            this.опцииToolStripMenuItem,
            this.инструкцииToolStripMenuItem,
            this.излезToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameMI,
            this.нивоToolStripMenuItem,
            this.листаСоРезултатиToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            resources.ApplyResources(this.играToolStripMenuItem, "играToolStripMenuItem");
            // 
            // newGameMI
            // 
            this.newGameMI.Name = "newGameMI";
            resources.ApplyResources(this.newGameMI, "newGameMI");
            this.newGameMI.Click += new System.EventHandler(this.новаИграToolStripMenuItem_Click);
            // 
            // нивоToolStripMenuItem
            // 
            this.нивоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.hardToolStripMenuItem});
            this.нивоToolStripMenuItem.Name = "нивоToolStripMenuItem";
            resources.ApplyResources(this.нивоToolStripMenuItem, "нивоToolStripMenuItem");
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            resources.ApplyResources(this.easyToolStripMenuItem, "easyToolStripMenuItem");
            this.easyToolStripMenuItem.Click += new System.EventHandler(this.easyToolStripMenuItem_Click);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            resources.ApplyResources(this.normalToolStripMenuItem, "normalToolStripMenuItem");
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            resources.ApplyResources(this.hardToolStripMenuItem, "hardToolStripMenuItem");
            this.hardToolStripMenuItem.Click += new System.EventHandler(this.hardToolStripMenuItem_Click);
            // 
            // листаСоРезултатиToolStripMenuItem
            // 
            this.листаСоРезултатиToolStripMenuItem.Name = "листаСоРезултатиToolStripMenuItem";
            resources.ApplyResources(this.листаСоРезултатиToolStripMenuItem, "листаСоРезултатиToolStripMenuItem");
            this.листаСоРезултатиToolStripMenuItem.Click += new System.EventHandler(this.листаСоРезултатиToolStripMenuItem_Click);
            // 
            // опцииToolStripMenuItem
            // 
            this.опцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заАпликацијатаToolStripMenuItem});
            this.опцииToolStripMenuItem.Name = "опцииToolStripMenuItem";
            resources.ApplyResources(this.опцииToolStripMenuItem, "опцииToolStripMenuItem");
            // 
            // заАпликацијатаToolStripMenuItem
            // 
            this.заАпликацијатаToolStripMenuItem.Name = "заАпликацијатаToolStripMenuItem";
            resources.ApplyResources(this.заАпликацијатаToolStripMenuItem, "заАпликацијатаToolStripMenuItem");
            // 
            // инструкцииToolStripMenuItem
            // 
            this.инструкцииToolStripMenuItem.Name = "инструкцииToolStripMenuItem";
            resources.ApplyResources(this.инструкцииToolStripMenuItem, "инструкцииToolStripMenuItem");
            this.инструкцииToolStripMenuItem.Click += new System.EventHandler(this.помошToolStripMenuItem_Click);
            // 
            // излезToolStripMenuItem
            // 
            this.излезToolStripMenuItem.Name = "излезToolStripMenuItem";
            resources.ApplyResources(this.излезToolStripMenuItem, "излезToolStripMenuItem");
            this.излезToolStripMenuItem.Click += new System.EventHandler(this.излезToolStripMenuItem_Click);
            // 
            // lblRemainingTime
            // 
            resources.ApplyResources(this.lblRemainingTime, "lblRemainingTime");
            this.lblRemainingTime.Name = "lblRemainingTime";
            // 
            // timerRemainingTime
            // 
            this.timerRemainingTime.Tick += new System.EventHandler(this.timerRemainingTime_Tick);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator,
            this.helpToolStripButton});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.newToolStripButton, "newToolStripButton");
            this.newToolStripButton.Name = "newToolStripButton";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.openToolStripButton, "openToolStripButton");
            this.openToolStripButton.Name = "openToolStripButton";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.saveToolStripButton, "saveToolStripButton");
            this.saveToolStripButton.Name = "saveToolStripButton";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            resources.ApplyResources(this.toolStripSeparator, "toolStripSeparator");
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.helpToolStripButton, "helpToolStripButton");
            this.helpToolStripButton.Name = "helpToolStripButton";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Hangman.Properties.Resources.sidepanel;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnStartGame);
            this.panel1.Controls.Add(this.gbVasiInformacii);
            this.panel1.Controls.Add(this.lblRemainingTime);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnResults);
            this.panel1.Controls.Add(this.lblPogodiZbor);
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.ForeColor = System.Drawing.Color.Snow;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.charP);
            this.panel2.Controls.Add(this.charM);
            this.panel2.Controls.Add(this.charN);
            this.panel2.Controls.Add(this.charL);
            this.panel2.Controls.Add(this.charK);
            this.panel2.Controls.Add(this.charJ);
            this.panel2.Controls.Add(this.charH);
            this.panel2.Controls.Add(this.charQ);
            this.panel2.Controls.Add(this.charO);
            this.panel2.Controls.Add(this.charI);
            this.panel2.Controls.Add(this.charU);
            this.panel2.Controls.Add(this.charB);
            this.panel2.Controls.Add(this.charY);
            this.panel2.Controls.Add(this.charV);
            this.panel2.Controls.Add(this.charC);
            this.panel2.Controls.Add(this.charX);
            this.panel2.Controls.Add(this.charZ);
            this.panel2.Controls.Add(this.charF);
            this.panel2.Controls.Add(this.charD);
            this.panel2.Controls.Add(this.charS);
            this.panel2.Controls.Add(this.charG);
            this.panel2.Controls.Add(this.charA);
            this.panel2.Controls.Add(this.charW);
            this.panel2.Controls.Add(this.charE);
            this.panel2.Controls.Add(this.charR);
            this.panel2.Controls.Add(this.charT);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // charP
            // 
            this.charP.BackColor = System.Drawing.Color.Maroon;
            this.charP.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.charP.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.charP, "charP");
            this.charP.Name = "charP";
            this.charP.UseVisualStyleBackColor = false;
            this.charP.Click += new System.EventHandler(this.charP_Click);
            // 
            // charM
            // 
            this.charM.BackColor = System.Drawing.Color.Maroon;
            this.charM.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.charM.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.charM, "charM");
            this.charM.Name = "charM";
            this.charM.UseVisualStyleBackColor = false;
            this.charM.Click += new System.EventHandler(this.charM_Click);
            // 
            // charN
            // 
            this.charN.BackColor = System.Drawing.Color.Maroon;
            this.charN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.charN.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.charN, "charN");
            this.charN.Name = "charN";
            this.charN.UseVisualStyleBackColor = false;
            this.charN.Click += new System.EventHandler(this.charN_Click);
            // 
            // charL
            // 
            this.charL.BackColor = System.Drawing.Color.Maroon;
            this.charL.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.charL.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.charL, "charL");
            this.charL.Name = "charL";
            this.charL.UseVisualStyleBackColor = false;
            this.charL.Click += new System.EventHandler(this.charL_Click);
            // 
            // charK
            // 
            this.charK.BackColor = System.Drawing.Color.Maroon;
            this.charK.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.charK.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.charK, "charK");
            this.charK.Name = "charK";
            this.charK.UseVisualStyleBackColor = false;
            this.charK.Click += new System.EventHandler(this.charK_Click);
            // 
            // charJ
            // 
            this.charJ.BackColor = System.Drawing.Color.Maroon;
            this.charJ.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.charJ.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.charJ, "charJ");
            this.charJ.Name = "charJ";
            this.charJ.UseVisualStyleBackColor = false;
            this.charJ.Click += new System.EventHandler(this.charJ_Click);
            // 
            // charH
            // 
            this.charH.BackColor = System.Drawing.Color.Maroon;
            this.charH.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.charH.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.charH, "charH");
            this.charH.Name = "charH";
            this.charH.UseVisualStyleBackColor = false;
            this.charH.Click += new System.EventHandler(this.charH_Click);
            // 
            // charQ
            // 
            this.charQ.BackColor = System.Drawing.Color.Maroon;
            this.charQ.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.charQ.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.charQ, "charQ");
            this.charQ.Name = "charQ";
            this.charQ.UseVisualStyleBackColor = false;
            this.charQ.Click += new System.EventHandler(this.charQ_Click);
            // 
            // charO
            // 
            this.charO.BackColor = System.Drawing.Color.Maroon;
            this.charO.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.charO.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.charO, "charO");
            this.charO.Name = "charO";
            this.charO.UseVisualStyleBackColor = false;
            this.charO.Click += new System.EventHandler(this.charO_Click);
            // 
            // charI
            // 
            this.charI.BackColor = System.Drawing.Color.Maroon;
            this.charI.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.charI.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.charI, "charI");
            this.charI.Name = "charI";
            this.charI.UseVisualStyleBackColor = false;
            this.charI.Click += new System.EventHandler(this.charI_Click);
            // 
            // charU
            // 
            this.charU.BackColor = System.Drawing.Color.Maroon;
            this.charU.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.charU.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.charU, "charU");
            this.charU.Name = "charU";
            this.charU.UseVisualStyleBackColor = false;
            this.charU.Click += new System.EventHandler(this.charU_Click);
            // 
            // charB
            // 
            this.charB.BackColor = System.Drawing.Color.Maroon;
            this.charB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.charB.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.charB, "charB");
            this.charB.Name = "charB";
            this.charB.UseVisualStyleBackColor = false;
            this.charB.Click += new System.EventHandler(this.charB_Click);
            // 
            // charY
            // 
            this.charY.BackColor = System.Drawing.Color.Maroon;
            this.charY.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.charY.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.charY, "charY");
            this.charY.Name = "charY";
            this.charY.UseVisualStyleBackColor = false;
            this.charY.Click += new System.EventHandler(this.charY_Click);
            // 
            // charV
            // 
            this.charV.BackColor = System.Drawing.Color.Maroon;
            this.charV.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.charV.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.charV, "charV");
            this.charV.Name = "charV";
            this.charV.UseVisualStyleBackColor = false;
            this.charV.Click += new System.EventHandler(this.charV_Click);
            // 
            // charC
            // 
            this.charC.BackColor = System.Drawing.Color.Maroon;
            this.charC.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.charC.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.charC, "charC");
            this.charC.Name = "charC";
            this.charC.UseVisualStyleBackColor = false;
            this.charC.Click += new System.EventHandler(this.charC_Click);
            // 
            // charX
            // 
            this.charX.BackColor = System.Drawing.Color.Maroon;
            this.charX.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.charX.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.charX, "charX");
            this.charX.Name = "charX";
            this.charX.UseVisualStyleBackColor = false;
            this.charX.Click += new System.EventHandler(this.charX_Click);
            // 
            // charZ
            // 
            this.charZ.BackColor = System.Drawing.Color.Maroon;
            this.charZ.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.charZ.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.charZ, "charZ");
            this.charZ.Name = "charZ";
            this.charZ.UseVisualStyleBackColor = false;
            this.charZ.Click += new System.EventHandler(this.charZ_Click);
            // 
            // charF
            // 
            this.charF.BackColor = System.Drawing.Color.Maroon;
            this.charF.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.charF.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.charF, "charF");
            this.charF.Name = "charF";
            this.charF.UseVisualStyleBackColor = false;
            this.charF.Click += new System.EventHandler(this.charF_Click);
            // 
            // charD
            // 
            this.charD.BackColor = System.Drawing.Color.Maroon;
            this.charD.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.charD.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.charD, "charD");
            this.charD.Name = "charD";
            this.charD.UseVisualStyleBackColor = false;
            this.charD.Click += new System.EventHandler(this.charD_Click);
            // 
            // charS
            // 
            this.charS.BackColor = System.Drawing.Color.Maroon;
            this.charS.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.charS.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.charS, "charS");
            this.charS.Name = "charS";
            this.charS.UseVisualStyleBackColor = false;
            this.charS.Click += new System.EventHandler(this.charS_Click);
            // 
            // charG
            // 
            this.charG.BackColor = System.Drawing.Color.Maroon;
            this.charG.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.charG.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.charG, "charG");
            this.charG.Name = "charG";
            this.charG.UseVisualStyleBackColor = false;
            this.charG.Click += new System.EventHandler(this.charG_Click);
            // 
            // charA
            // 
            this.charA.BackColor = System.Drawing.Color.Maroon;
            this.charA.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.charA.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.charA, "charA");
            this.charA.Name = "charA";
            this.charA.UseVisualStyleBackColor = false;
            this.charA.Click += new System.EventHandler(this.charA_Click);
            // 
            // charW
            // 
            this.charW.BackColor = System.Drawing.Color.Maroon;
            this.charW.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.charW.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.charW, "charW");
            this.charW.Name = "charW";
            this.charW.UseVisualStyleBackColor = false;
            this.charW.Click += new System.EventHandler(this.charW_Click);
            // 
            // charE
            // 
            this.charE.BackColor = System.Drawing.Color.Maroon;
            this.charE.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.charE.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.charE, "charE");
            this.charE.Name = "charE";
            this.charE.UseVisualStyleBackColor = false;
            this.charE.Click += new System.EventHandler(this.charE_Click);
            // 
            // charR
            // 
            this.charR.BackColor = System.Drawing.Color.Maroon;
            this.charR.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.charR.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.charR, "charR");
            this.charR.Name = "charR";
            this.charR.UseVisualStyleBackColor = false;
            this.charR.Click += new System.EventHandler(this.charR_Click);
            // 
            // charT
            // 
            this.charT.BackColor = System.Drawing.Color.Maroon;
            this.charT.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.charT.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.charT, "charT");
            this.charT.Name = "charT";
            this.charT.UseVisualStyleBackColor = false;
            this.charT.Click += new System.EventHandler(this.charT_Click);
            // 
            // pbGuy
            // 
            resources.ApplyResources(this.pbGuy, "pbGuy");
            this.pbGuy.BackColor = System.Drawing.Color.Transparent;
            this.pbGuy.Name = "pbGuy";
            this.pbGuy.TabStop = false;
            // 
            // HangmanForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Hangman.Properties.Resources.Land_008;
            this.Controls.Add(this.pbGuy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HangmanForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formBesilka_FormClosing);
            this.gbVasiInformacii.ResumeLayout(false);
            this.gbVasiInformacii.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPogodiZbor;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.GroupBox gbVasiInformacii;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPrekar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPoeni;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem опцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструкцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem излезToolStripMenuItem;
        private System.Windows.Forms.Label lblRemainingTime;
        private System.Windows.Forms.Timer timerRemainingTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem newGameMI;
        private System.Windows.Forms.ToolStripMenuItem листаСоРезултатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нивоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem заАпликацијатаToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button charQ;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button charB;
        private System.Windows.Forms.Button charV;
        private System.Windows.Forms.Button charC;
        private System.Windows.Forms.Button charX;
        private System.Windows.Forms.Button charZ;
        private System.Windows.Forms.Button charF;
        private System.Windows.Forms.Button charD;
        private System.Windows.Forms.Button charS;
        private System.Windows.Forms.Button charG;
        private System.Windows.Forms.Button charA;
        private System.Windows.Forms.Button charW;
        private System.Windows.Forms.Button charE;
        private System.Windows.Forms.Button charR;
        private System.Windows.Forms.Button charT;
        private System.Windows.Forms.Button charU;
        private System.Windows.Forms.Button charY;
        private System.Windows.Forms.Button charI;
        private System.Windows.Forms.Button charO;
        private System.Windows.Forms.Button charL;
        private System.Windows.Forms.Button charK;
        private System.Windows.Forms.Button charJ;
        private System.Windows.Forms.Button charH;
        private System.Windows.Forms.Button charN;
        private System.Windows.Forms.Button charP;
        private System.Windows.Forms.Button charM;
        private System.Windows.Forms.PictureBox pbGuy;
    }
}

