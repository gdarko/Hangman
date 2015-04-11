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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbHead = new System.Windows.Forms.PictureBox();
            this.pbLeftHand = new System.Windows.Forms.PictureBox();
            this.pbLeftLeg = new System.Windows.Forms.PictureBox();
            this.pbRightHand = new System.Windows.Forms.PictureBox();
            this.pbRightLeg = new System.Windows.Forms.PictureBox();
            this.pbBody = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftLeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightLeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBody)).BeginInit();
            this.gbZborovi.SuspendLayout();
            this.gbVasiInformacii.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pbHead
            // 
            resources.ApplyResources(this.pbHead, "pbHead");
            this.pbHead.Name = "pbHead";
            this.pbHead.TabStop = false;
            // 
            // pbLeftHand
            // 
            resources.ApplyResources(this.pbLeftHand, "pbLeftHand");
            this.pbLeftHand.Name = "pbLeftHand";
            this.pbLeftHand.TabStop = false;
            // 
            // pbLeftLeg
            // 
            resources.ApplyResources(this.pbLeftLeg, "pbLeftLeg");
            this.pbLeftLeg.Name = "pbLeftLeg";
            this.pbLeftLeg.TabStop = false;
            // 
            // pbRightHand
            // 
            resources.ApplyResources(this.pbRightHand, "pbRightHand");
            this.pbRightHand.Name = "pbRightHand";
            this.pbRightHand.TabStop = false;
            // 
            // pbRightLeg
            // 
            resources.ApplyResources(this.pbRightLeg, "pbRightLeg");
            this.pbRightLeg.Name = "pbRightLeg";
            this.pbRightLeg.TabStop = false;
            // 
            // pbBody
            // 
            resources.ApplyResources(this.pbBody, "pbBody");
            this.pbBody.Name = "pbBody";
            this.pbBody.TabStop = false;
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
            // HangmanForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbVasiInformacii);
            this.Controls.Add(this.gbZborovi);
            this.Controls.Add(this.pbBody);
            this.Controls.Add(this.pbRightLeg);
            this.Controls.Add(this.pbRightHand);
            this.Controls.Add(this.pbLeftLeg);
            this.Controls.Add(this.pbLeftHand);
            this.Controls.Add(this.pbHead);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HangmanForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formBesilka_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftLeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightLeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBody)).EndInit();
            this.gbZborovi.ResumeLayout(false);
            this.gbZborovi.PerformLayout();
            this.gbVasiInformacii.ResumeLayout(false);
            this.gbVasiInformacii.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbHead;
        private System.Windows.Forms.PictureBox pbLeftHand;
        private System.Windows.Forms.PictureBox pbLeftLeg;
        private System.Windows.Forms.PictureBox pbRightHand;
        private System.Windows.Forms.PictureBox pbRightLeg;
        private System.Windows.Forms.PictureBox pbBody;
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
    }
}

