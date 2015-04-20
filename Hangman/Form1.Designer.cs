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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HangmanForm));
            this.lblPogodiZbor = new System.Windows.Forms.Label();
            this.tbCharacter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResults = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.gbZborovi = new System.Windows.Forms.GroupBox();
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
            this.опцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помошToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.излезToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.gbZborovi.SuspendLayout();
            this.gbVasiInformacii.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.btnCheck, "btnCheck");
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // gbZborovi
            // 
            this.gbZborovi.Controls.Add(this.btnCheck);
            this.gbZborovi.Controls.Add(this.tbCharacter);
            this.gbZborovi.Controls.Add(this.label1);
            this.gbZborovi.Controls.Add(this.lblPogodiZbor);
            this.gbZborovi.Controls.Add(this.btnResults);
            this.gbZborovi.Controls.Add(this.btnClose);
            resources.ApplyResources(this.gbZborovi, "gbZborovi");
            this.gbZborovi.Name = "gbZborovi";
            this.gbZborovi.TabStop = false;
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
            resources.ApplyResources(this.gbVasiInformacii, "gbVasiInformacii");
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
            this.помошToolStripMenuItem,
            this.излезToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            resources.ApplyResources(this.играToolStripMenuItem, "играToolStripMenuItem");
            // 
            // опцииToolStripMenuItem
            // 
            this.опцииToolStripMenuItem.Name = "опцииToolStripMenuItem";
            resources.ApplyResources(this.опцииToolStripMenuItem, "опцииToolStripMenuItem");
            // 
            // помошToolStripMenuItem
            // 
            this.помошToolStripMenuItem.Name = "помошToolStripMenuItem";
            resources.ApplyResources(this.помошToolStripMenuItem, "помошToolStripMenuItem");
            // 
            // излезToolStripMenuItem
            // 
            this.излезToolStripMenuItem.Name = "излезToolStripMenuItem";
            resources.ApplyResources(this.излезToolStripMenuItem, "излезToolStripMenuItem");
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pnlBody
            // 
            resources.ApplyResources(this.pnlBody, "pnlBody");
            this.pnlBody.Name = "pnlBody";
            // 
            // HangmanForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.gbVasiInformacii);
            this.Controls.Add(this.gbZborovi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HangmanForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formBesilka_FormClosing);
            this.gbZborovi.ResumeLayout(false);
            this.gbZborovi.PerformLayout();
            this.gbVasiInformacii.ResumeLayout(false);
            this.gbVasiInformacii.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPogodiZbor;
        private System.Windows.Forms.TextBox tbCharacter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.Button btnClose;
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
        private System.Windows.Forms.ToolStripMenuItem помошToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem излезToolStripMenuItem;
        private System.Windows.Forms.Panel pnlBody;
    }
}

