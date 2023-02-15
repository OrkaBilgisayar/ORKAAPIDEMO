
namespace Orka_Personel
{
    partial class frmOrkaPersonel
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
            this.rchSonuc = new System.Windows.Forms.RichTextBox();
            this.butGetAllEmployees = new System.Windows.Forms.Button();
            this.butGetAllPermit = new System.Windows.Forms.Button();
            this.butGetAllPayment = new System.Windows.Forms.Button();
            this.butAddPermit = new System.Windows.Forms.Button();
            this.butGetAllJoinedEmployees = new System.Windows.Forms.Button();
            this.butGetAllLeftedEmployees = new System.Windows.Forms.Button();
            this.butGetAllPersonPermit = new System.Windows.Forms.Button();
            this.stripDurum = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripDurum.SuspendLayout();
            this.SuspendLayout();
            // 
            // rchSonuc
            // 
            this.rchSonuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rchSonuc.Location = new System.Drawing.Point(348, 12);
            this.rchSonuc.Name = "rchSonuc";
            this.rchSonuc.Size = new System.Drawing.Size(463, 623);
            this.rchSonuc.TabIndex = 3;
            this.rchSonuc.Text = "";
            // 
            // butGetAllEmployees
            // 
            this.butGetAllEmployees.BackColor = System.Drawing.Color.PeachPuff;
            this.butGetAllEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butGetAllEmployees.Location = new System.Drawing.Point(12, 12);
            this.butGetAllEmployees.Name = "butGetAllEmployees";
            this.butGetAllEmployees.Size = new System.Drawing.Size(100, 101);
            this.butGetAllEmployees.TabIndex = 16;
            this.butGetAllEmployees.Text = "PERSONEL LİSTESİ ";
            this.butGetAllEmployees.UseVisualStyleBackColor = false;
            this.butGetAllEmployees.Click += new System.EventHandler(this.butGetAllEmployees_Click);
            // 
            // butGetAllPermit
            // 
            this.butGetAllPermit.BackColor = System.Drawing.Color.PeachPuff;
            this.butGetAllPermit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butGetAllPermit.Location = new System.Drawing.Point(118, 12);
            this.butGetAllPermit.Name = "butGetAllPermit";
            this.butGetAllPermit.Size = new System.Drawing.Size(100, 101);
            this.butGetAllPermit.TabIndex = 17;
            this.butGetAllPermit.Text = "İZİN LİSTESİ";
            this.butGetAllPermit.UseVisualStyleBackColor = false;
            this.butGetAllPermit.Click += new System.EventHandler(this.butGetAllPermit_Click);
            // 
            // butGetAllPayment
            // 
            this.butGetAllPayment.BackColor = System.Drawing.Color.PeachPuff;
            this.butGetAllPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butGetAllPayment.Location = new System.Drawing.Point(224, 12);
            this.butGetAllPayment.Name = "butGetAllPayment";
            this.butGetAllPayment.Size = new System.Drawing.Size(100, 101);
            this.butGetAllPayment.TabIndex = 18;
            this.butGetAllPayment.Text = "ÖDEMELER LİSTESİ";
            this.butGetAllPayment.UseVisualStyleBackColor = false;
            this.butGetAllPayment.Click += new System.EventHandler(this.butGetAllPayment_Click);
            // 
            // butAddPermit
            // 
            this.butAddPermit.BackColor = System.Drawing.Color.PeachPuff;
            this.butAddPermit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butAddPermit.Location = new System.Drawing.Point(118, 226);
            this.butAddPermit.Name = "butAddPermit";
            this.butAddPermit.Size = new System.Drawing.Size(100, 101);
            this.butAddPermit.TabIndex = 19;
            this.butAddPermit.Text = "İZİN EKLE";
            this.butAddPermit.UseVisualStyleBackColor = false;
            this.butAddPermit.Click += new System.EventHandler(this.butAddPermit_Click);
            // 
            // butGetAllJoinedEmployees
            // 
            this.butGetAllJoinedEmployees.BackColor = System.Drawing.Color.PeachPuff;
            this.butGetAllJoinedEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butGetAllJoinedEmployees.Location = new System.Drawing.Point(12, 119);
            this.butGetAllJoinedEmployees.Name = "butGetAllJoinedEmployees";
            this.butGetAllJoinedEmployees.Size = new System.Drawing.Size(100, 101);
            this.butGetAllJoinedEmployees.TabIndex = 20;
            this.butGetAllJoinedEmployees.Text = "İŞE BAŞLAYAN PERSONEL LİSTESİ";
            this.butGetAllJoinedEmployees.UseVisualStyleBackColor = false;
            this.butGetAllJoinedEmployees.Click += new System.EventHandler(this.butGetAllJoinedEmployees_Click);
            // 
            // butGetAllLeftedEmployees
            // 
            this.butGetAllLeftedEmployees.BackColor = System.Drawing.Color.PeachPuff;
            this.butGetAllLeftedEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butGetAllLeftedEmployees.Location = new System.Drawing.Point(12, 226);
            this.butGetAllLeftedEmployees.Name = "butGetAllLeftedEmployees";
            this.butGetAllLeftedEmployees.Size = new System.Drawing.Size(100, 101);
            this.butGetAllLeftedEmployees.TabIndex = 21;
            this.butGetAllLeftedEmployees.Text = "İŞTEN ÇIKAN PERSONEL LİSTESİ";
            this.butGetAllLeftedEmployees.UseVisualStyleBackColor = false;
            this.butGetAllLeftedEmployees.Click += new System.EventHandler(this.butGetAllLeftedEmployees_Click);
            // 
            // butGetAllPersonPermit
            // 
            this.butGetAllPersonPermit.BackColor = System.Drawing.Color.PeachPuff;
            this.butGetAllPersonPermit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butGetAllPersonPermit.Location = new System.Drawing.Point(118, 119);
            this.butGetAllPersonPermit.Name = "butGetAllPersonPermit";
            this.butGetAllPersonPermit.Size = new System.Drawing.Size(100, 101);
            this.butGetAllPersonPermit.TabIndex = 22;
            this.butGetAllPersonPermit.Text = "İZİN TALEP LİSTESİ";
            this.butGetAllPersonPermit.UseVisualStyleBackColor = false;
            this.butGetAllPersonPermit.Click += new System.EventHandler(this.butGetAllPersonPermit_Click);
            // 
            // stripDurum
            // 
            this.stripDurum.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.stripDurum.Location = new System.Drawing.Point(0, 638);
            this.stripDurum.Name = "stripDurum";
            this.stripDurum.Size = new System.Drawing.Size(823, 22);
            this.stripDurum.TabIndex = 23;
            this.stripDurum.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // frmOrkaPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 660);
            this.Controls.Add(this.stripDurum);
            this.Controls.Add(this.butGetAllPersonPermit);
            this.Controls.Add(this.butGetAllLeftedEmployees);
            this.Controls.Add(this.butGetAllJoinedEmployees);
            this.Controls.Add(this.butAddPermit);
            this.Controls.Add(this.butGetAllPayment);
            this.Controls.Add(this.butGetAllPermit);
            this.Controls.Add(this.butGetAllEmployees);
            this.Controls.Add(this.rchSonuc);
            this.Name = "frmOrkaPersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ORKA PERSONEL";
            this.Load += new System.EventHandler(this.frmOrkaPersonel_Load);
            this.stripDurum.ResumeLayout(false);
            this.stripDurum.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchSonuc;
        private System.Windows.Forms.Button butGetAllEmployees;
        private System.Windows.Forms.Button butGetAllPermit;
        private System.Windows.Forms.Button butGetAllPayment;
        private System.Windows.Forms.Button butAddPermit;
        private System.Windows.Forms.Button butGetAllJoinedEmployees;
        private System.Windows.Forms.Button butGetAllLeftedEmployees;
        private System.Windows.Forms.Button butGetAllPersonPermit;
        private System.Windows.Forms.StatusStrip stripDurum;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
    }
}

