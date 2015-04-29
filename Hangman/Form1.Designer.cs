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
            this.tbCharacter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResults = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.gbZborovi = new System.Windows.Forms.GroupBox();
            this.btnContinue = new System.Windows.Forms.Button();
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
            this.новаИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нивоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.листаСоРезултатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.опцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструкцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.излезToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.lblRemainingTime = new System.Windows.Forms.Label();
            this.timerRemainingTime = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.заАпликацијатаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.gbZborovi.SuspendLayout();
            this.gbVasiInformacii.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPogodiZbor
            // 
            resources.ApplyResources(this.lblPogodiZbor, "lblPogodiZbor");
            this.lblPogodiZbor.Name = "lblPogodiZbor";
            // 
            // tbCharacter
            // 
            resources.ApplyResources(this.tbCharacter, "tbCharacter");
            this.tbCharacter.Name = "tbCharacter";
            this.tbCharacter.ReadOnly = true;
            this.tbCharacter.Validating += new System.ComponentModel.CancelEventHandler(this.tbCharacter_Validating);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnResults
            // 
            this.btnResults.BackColor = System.Drawing.SystemColors.AppWorkspace;
            resources.ApplyResources(this.btnResults, "btnResults");
            this.btnResults.Name = "btnResults";
            this.btnResults.UseVisualStyleBackColor = false;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btnPause, "btnPause");
            this.btnPause.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPause.Name = "btnPause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.btnCheck, "btnCheck");
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // gbZborovi
            // 
            this.gbZborovi.Controls.Add(this.btnContinue);
            this.gbZborovi.Controls.Add(this.btnHelp);
            this.gbZborovi.Controls.Add(this.btnCheck);
            this.gbZborovi.Controls.Add(this.tbCharacter);
            this.gbZborovi.Controls.Add(this.label1);
            this.gbZborovi.Controls.Add(this.lblPogodiZbor);
            this.gbZborovi.Controls.Add(this.btnResults);
            this.gbZborovi.Controls.Add(this.btnPause);
            resources.ApplyResources(this.gbZborovi, "gbZborovi");
            this.gbZborovi.Name = "gbZborovi";
            this.gbZborovi.TabStop = false;
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.Goldenrod;
            resources.ApplyResources(this.btnContinue, "btnContinue");
            this.btnContinue.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.btnHelp, "btnHelp");
            this.btnHelp.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // gbVasiInformacii
            // 
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
            this.gbVasiInformacii.ForeColor = System.Drawing.Color.DarkRed;
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
            this.новаИграToolStripMenuItem,
            this.нивоToolStripMenuItem,
            this.листаСоРезултатиToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            resources.ApplyResources(this.играToolStripMenuItem, "играToolStripMenuItem");
            // 
            // новаИграToolStripMenuItem
            // 
            this.новаИграToolStripMenuItem.Name = "новаИграToolStripMenuItem";
            resources.ApplyResources(this.новаИграToolStripMenuItem, "новаИграToolStripMenuItem");
            this.новаИграToolStripMenuItem.Click += new System.EventHandler(this.новаИграToolStripMenuItem_Click);
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
            // pnlBody
            // 
            resources.ApplyResources(this.pnlBody, "pnlBody");
            this.pnlBody.Name = "pnlBody";
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
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Gold;
            resources.ApplyResources(this.btnStartGame, "btnStartGame");
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
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
            // заАпликацијатаToolStripMenuItem
            // 
            this.заАпликацијатаToolStripMenuItem.Name = "заАпликацијатаToolStripMenuItem";
            resources.ApplyResources(this.заАпликацијатаToolStripMenuItem, "заАпликацијатаToolStripMenuItem");
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // HangmanForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblRemainingTime);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.gbVasiInformacii);
            this.Controls.Add(this.gbZborovi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HangmanForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formBesilka_FormClosing);
            this.Load += new System.EventHandler(this.HangmanForm_Load);
            this.gbZborovi.ResumeLayout(false);
            this.gbZborovi.PerformLayout();
            this.gbVasiInformacii.ResumeLayout(false);
            this.gbVasiInformacii.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPogodiZbor;
        private System.Windows.Forms.TextBox tbCharacter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.GroupBox gbZborovi;
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
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label lblRemainingTime;
        private System.Windows.Forms.Timer timerRemainingTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem новаИграToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem листаСоРезултатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нивоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem заАпликацијатаToolStripMenuItem;
        private System.Windows.Forms.Label label7;
    }
}

