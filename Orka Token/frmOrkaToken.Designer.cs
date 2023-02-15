
namespace OrkaToken
{
    partial class frmOrkaToken
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrkaToken));
            this.butToken = new System.Windows.Forms.Button();
            this.rchSonuc = new System.Windows.Forms.RichTextBox();
            this.butCompanyList = new System.Windows.Forms.Button();
            this.butSetCompany = new System.Windows.Forms.Button();
            this.lblStepOne = new System.Windows.Forms.Label();
            this.lblStepTwo = new System.Windows.Forms.Label();
            this.lblStepThree = new System.Windows.Forms.Label();
            this.gbDescription = new System.Windows.Forms.GroupBox();
            this.rchDescription = new System.Windows.Forms.RichTextBox();
            this.grpModules = new System.Windows.Forms.GroupBox();
            this.butModul = new System.Windows.Forms.Button();
            this.stripDurum = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbDescription.SuspendLayout();
            this.grpModules.SuspendLayout();
            this.stripDurum.SuspendLayout();
            this.SuspendLayout();
            // 
            // butToken
            // 
            this.butToken.BackColor = System.Drawing.Color.PeachPuff;
            this.butToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butToken.Location = new System.Drawing.Point(12, 44);
            this.butToken.Name = "butToken";
            this.butToken.Size = new System.Drawing.Size(100, 101);
            this.butToken.TabIndex = 0;
            this.butToken.Text = "TOKEN AL";
            this.butToken.UseVisualStyleBackColor = false;
            this.butToken.Click += new System.EventHandler(this.butToken_Click);
            // 
            // rchSonuc
            // 
            this.rchSonuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rchSonuc.Location = new System.Drawing.Point(118, 12);
            this.rchSonuc.Name = "rchSonuc";
            this.rchSonuc.Size = new System.Drawing.Size(632, 420);
            this.rchSonuc.TabIndex = 1;
            this.rchSonuc.Text = "";
            // 
            // butCompanyList
            // 
            this.butCompanyList.BackColor = System.Drawing.Color.PeachPuff;
            this.butCompanyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butCompanyList.Location = new System.Drawing.Point(12, 175);
            this.butCompanyList.Name = "butCompanyList";
            this.butCompanyList.Size = new System.Drawing.Size(100, 101);
            this.butCompanyList.TabIndex = 2;
            this.butCompanyList.Text = "FİRMA LİSTESİ";
            this.butCompanyList.UseVisualStyleBackColor = false;
            this.butCompanyList.Click += new System.EventHandler(this.butCompanyList_Click);
            // 
            // butSetCompany
            // 
            this.butSetCompany.BackColor = System.Drawing.Color.PeachPuff;
            this.butSetCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butSetCompany.Location = new System.Drawing.Point(12, 317);
            this.butSetCompany.Name = "butSetCompany";
            this.butSetCompany.Size = new System.Drawing.Size(100, 101);
            this.butSetCompany.TabIndex = 3;
            this.butSetCompany.Text = "FİRMA SEÇ";
            this.butSetCompany.UseVisualStyleBackColor = false;
            this.butSetCompany.Click += new System.EventHandler(this.butSetCompany_Click);
            // 
            // lblStepOne
            // 
            this.lblStepOne.AutoSize = true;
            this.lblStepOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStepOne.Location = new System.Drawing.Point(24, 17);
            this.lblStepOne.Name = "lblStepOne";
            this.lblStepOne.Size = new System.Drawing.Size(75, 24);
            this.lblStepOne.TabIndex = 4;
            this.lblStepOne.Text = "1.Adım";
            // 
            // lblStepTwo
            // 
            this.lblStepTwo.AutoSize = true;
            this.lblStepTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStepTwo.Location = new System.Drawing.Point(24, 148);
            this.lblStepTwo.Name = "lblStepTwo";
            this.lblStepTwo.Size = new System.Drawing.Size(75, 24);
            this.lblStepTwo.TabIndex = 5;
            this.lblStepTwo.Text = "2.Adım";
            // 
            // lblStepThree
            // 
            this.lblStepThree.AutoSize = true;
            this.lblStepThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStepThree.Location = new System.Drawing.Point(24, 290);
            this.lblStepThree.Name = "lblStepThree";
            this.lblStepThree.Size = new System.Drawing.Size(75, 24);
            this.lblStepThree.TabIndex = 6;
            this.lblStepThree.Text = "3.Adım";
            // 
            // gbDescription
            // 
            this.gbDescription.Controls.Add(this.rchDescription);
            this.gbDescription.Location = new System.Drawing.Point(12, 430);
            this.gbDescription.Name = "gbDescription";
            this.gbDescription.Size = new System.Drawing.Size(738, 466);
            this.gbDescription.TabIndex = 7;
            this.gbDescription.TabStop = false;
            this.gbDescription.Text = "Açıklamalar";
            // 
            // rchDescription
            // 
            this.rchDescription.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchDescription.Location = new System.Drawing.Point(6, 19);
            this.rchDescription.Name = "rchDescription";
            this.rchDescription.ReadOnly = true;
            this.rchDescription.Size = new System.Drawing.Size(726, 441);
            this.rchDescription.TabIndex = 0;
            this.rchDescription.Text = resources.GetString("rchDescription.Text");
            // 
            // grpModules
            // 
            this.grpModules.Controls.Add(this.butModul);
            this.grpModules.Location = new System.Drawing.Point(763, 6);
            this.grpModules.Name = "grpModules";
            this.grpModules.Size = new System.Drawing.Size(117, 890);
            this.grpModules.TabIndex = 8;
            this.grpModules.TabStop = false;
            this.grpModules.Text = "Modüller";
            // 
            // butModul
            // 
            this.butModul.BackColor = System.Drawing.Color.SandyBrown;
            this.butModul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butModul.Location = new System.Drawing.Point(6, 19);
            this.butModul.Name = "butModul";
            this.butModul.Size = new System.Drawing.Size(100, 101);
            this.butModul.TabIndex = 4;
            this.butModul.Text = "SEÇİLEN MODÜL";
            this.butModul.UseVisualStyleBackColor = false;
            this.butModul.Click += new System.EventHandler(this.butModul_Click);
            // 
            // stripDurum
            // 
            this.stripDurum.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.stripDurum.Location = new System.Drawing.Point(0, 900);
            this.stripDurum.Name = "stripDurum";
            this.stripDurum.Size = new System.Drawing.Size(892, 22);
            this.stripDurum.TabIndex = 9;
            this.stripDurum.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // frmOrkaToken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 922);
            this.Controls.Add(this.stripDurum);
            this.Controls.Add(this.grpModules);
            this.Controls.Add(this.gbDescription);
            this.Controls.Add(this.lblStepThree);
            this.Controls.Add(this.lblStepTwo);
            this.Controls.Add(this.lblStepOne);
            this.Controls.Add(this.butSetCompany);
            this.Controls.Add(this.butCompanyList);
            this.Controls.Add(this.rchSonuc);
            this.Controls.Add(this.butToken);
            this.Name = "frmOrkaToken";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ORKA TOKEN ALMA";
            this.Load += new System.EventHandler(this.frmOrkaToken_Load);
            this.gbDescription.ResumeLayout(false);
            this.grpModules.ResumeLayout(false);
            this.stripDurum.ResumeLayout(false);
            this.stripDurum.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butToken;
        private System.Windows.Forms.RichTextBox rchSonuc;
        private System.Windows.Forms.Button butCompanyList;
        private System.Windows.Forms.Button butSetCompany;
        private System.Windows.Forms.Label lblStepOne;
        private System.Windows.Forms.Label lblStepTwo;
        private System.Windows.Forms.Label lblStepThree;
        private System.Windows.Forms.GroupBox gbDescription;
        private System.Windows.Forms.RichTextBox rchDescription;
        private System.Windows.Forms.GroupBox grpModules;
        private System.Windows.Forms.Button butModul;
        private System.Windows.Forms.StatusStrip stripDurum;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
    }
}

