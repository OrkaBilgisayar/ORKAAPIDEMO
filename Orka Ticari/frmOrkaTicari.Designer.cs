
namespace Orka_Ticari
{
    partial class frmOrkaTicari
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
            this.butInvoiceList = new System.Windows.Forms.Button();
            this.rchSonuc = new System.Windows.Forms.RichTextBox();
            this.butInvoiceListWithFilters = new System.Windows.Forms.Button();
            this.butAddOrder = new System.Windows.Forms.Button();
            this.butAddInvoice = new System.Windows.Forms.Button();
            this.butPaymentList = new System.Windows.Forms.Button();
            this.butAddCashPayment = new System.Windows.Forms.Button();
            this.butAddBankPayment = new System.Windows.Forms.Button();
            this.butPaymentListWithFilters = new System.Windows.Forms.Button();
            this.butGetAllStocks = new System.Windows.Forms.Button();
            this.butStockListWithFilters = new System.Windows.Forms.Button();
            this.butAddStock = new System.Windows.Forms.Button();
            this.butDeleteStock = new System.Windows.Forms.Button();
            this.butGetExtreWithCode = new System.Windows.Forms.Button();
            this.butGetStockExtreWithCode = new System.Windows.Forms.Button();
            this.stripDurum = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripDurum.SuspendLayout();
            this.SuspendLayout();
            // 
            // butInvoiceList
            // 
            this.butInvoiceList.BackColor = System.Drawing.Color.PeachPuff;
            this.butInvoiceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butInvoiceList.Location = new System.Drawing.Point(12, 12);
            this.butInvoiceList.Name = "butInvoiceList";
            this.butInvoiceList.Size = new System.Drawing.Size(100, 101);
            this.butInvoiceList.TabIndex = 1;
            this.butInvoiceList.Text = "FATURA LİSTESİ";
            this.butInvoiceList.UseVisualStyleBackColor = false;
            this.butInvoiceList.Click += new System.EventHandler(this.butInvoiceList_Click);
            // 
            // rchSonuc
            // 
            this.rchSonuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rchSonuc.Location = new System.Drawing.Point(348, 12);
            this.rchSonuc.Name = "rchSonuc";
            this.rchSonuc.Size = new System.Drawing.Size(463, 636);
            this.rchSonuc.TabIndex = 2;
            this.rchSonuc.Text = "";
            // 
            // butInvoiceListWithFilters
            // 
            this.butInvoiceListWithFilters.BackColor = System.Drawing.Color.PeachPuff;
            this.butInvoiceListWithFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butInvoiceListWithFilters.Location = new System.Drawing.Point(12, 119);
            this.butInvoiceListWithFilters.Name = "butInvoiceListWithFilters";
            this.butInvoiceListWithFilters.Size = new System.Drawing.Size(100, 101);
            this.butInvoiceListWithFilters.TabIndex = 3;
            this.butInvoiceListWithFilters.Text = "PARAMETRE FATURA LİSTESİ";
            this.butInvoiceListWithFilters.UseVisualStyleBackColor = false;
            this.butInvoiceListWithFilters.Click += new System.EventHandler(this.butInvoiceListWithFilters_Click);
            // 
            // butAddOrder
            // 
            this.butAddOrder.BackColor = System.Drawing.Color.PeachPuff;
            this.butAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butAddOrder.Location = new System.Drawing.Point(12, 226);
            this.butAddOrder.Name = "butAddOrder";
            this.butAddOrder.Size = new System.Drawing.Size(100, 101);
            this.butAddOrder.TabIndex = 4;
            this.butAddOrder.Text = "SİPARİŞ EKLE";
            this.butAddOrder.UseVisualStyleBackColor = false;
            this.butAddOrder.Click += new System.EventHandler(this.butAddOrder_Click);
            // 
            // butAddInvoice
            // 
            this.butAddInvoice.BackColor = System.Drawing.Color.PeachPuff;
            this.butAddInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butAddInvoice.Location = new System.Drawing.Point(12, 333);
            this.butAddInvoice.Name = "butAddInvoice";
            this.butAddInvoice.Size = new System.Drawing.Size(100, 101);
            this.butAddInvoice.TabIndex = 5;
            this.butAddInvoice.Text = "FATURA EKLE";
            this.butAddInvoice.UseVisualStyleBackColor = false;
            this.butAddInvoice.Click += new System.EventHandler(this.butAddInvoice_Click);
            // 
            // butPaymentList
            // 
            this.butPaymentList.BackColor = System.Drawing.Color.PeachPuff;
            this.butPaymentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butPaymentList.Location = new System.Drawing.Point(127, 12);
            this.butPaymentList.Name = "butPaymentList";
            this.butPaymentList.Size = new System.Drawing.Size(100, 101);
            this.butPaymentList.TabIndex = 6;
            this.butPaymentList.Text = "ÖDEMELER LİSTESİ";
            this.butPaymentList.UseVisualStyleBackColor = false;
            this.butPaymentList.Click += new System.EventHandler(this.butPaymentList_Click);
            // 
            // butAddCashPayment
            // 
            this.butAddCashPayment.BackColor = System.Drawing.Color.PeachPuff;
            this.butAddCashPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butAddCashPayment.Location = new System.Drawing.Point(127, 226);
            this.butAddCashPayment.Name = "butAddCashPayment";
            this.butAddCashPayment.Size = new System.Drawing.Size(100, 101);
            this.butAddCashPayment.TabIndex = 7;
            this.butAddCashPayment.Text = "NAKİT ÖDEME EKLE";
            this.butAddCashPayment.UseVisualStyleBackColor = false;
            this.butAddCashPayment.Click += new System.EventHandler(this.butAddCashPayment_Click);
            // 
            // butAddBankPayment
            // 
            this.butAddBankPayment.BackColor = System.Drawing.Color.PeachPuff;
            this.butAddBankPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butAddBankPayment.Location = new System.Drawing.Point(127, 333);
            this.butAddBankPayment.Name = "butAddBankPayment";
            this.butAddBankPayment.Size = new System.Drawing.Size(100, 101);
            this.butAddBankPayment.TabIndex = 8;
            this.butAddBankPayment.Text = "BANKA ÖDEME EKLE";
            this.butAddBankPayment.UseVisualStyleBackColor = false;
            this.butAddBankPayment.Click += new System.EventHandler(this.butAddBankPayment_Click);
            // 
            // butPaymentListWithFilters
            // 
            this.butPaymentListWithFilters.BackColor = System.Drawing.Color.PeachPuff;
            this.butPaymentListWithFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butPaymentListWithFilters.Location = new System.Drawing.Point(127, 119);
            this.butPaymentListWithFilters.Name = "butPaymentListWithFilters";
            this.butPaymentListWithFilters.Size = new System.Drawing.Size(100, 101);
            this.butPaymentListWithFilters.TabIndex = 9;
            this.butPaymentListWithFilters.Text = "PARAMETRE ÖDEME LİSTESİ";
            this.butPaymentListWithFilters.UseVisualStyleBackColor = false;
            this.butPaymentListWithFilters.Click += new System.EventHandler(this.butPaymentListWithFilters_Click);
            // 
            // butGetAllStocks
            // 
            this.butGetAllStocks.BackColor = System.Drawing.Color.PeachPuff;
            this.butGetAllStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butGetAllStocks.Location = new System.Drawing.Point(242, 12);
            this.butGetAllStocks.Name = "butGetAllStocks";
            this.butGetAllStocks.Size = new System.Drawing.Size(100, 101);
            this.butGetAllStocks.TabIndex = 10;
            this.butGetAllStocks.Text = "STOK LİSTESİ";
            this.butGetAllStocks.UseVisualStyleBackColor = false;
            this.butGetAllStocks.Click += new System.EventHandler(this.butGetAllStocks_Click);
            // 
            // butStockListWithFilters
            // 
            this.butStockListWithFilters.BackColor = System.Drawing.Color.PeachPuff;
            this.butStockListWithFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butStockListWithFilters.Location = new System.Drawing.Point(242, 119);
            this.butStockListWithFilters.Name = "butStockListWithFilters";
            this.butStockListWithFilters.Size = new System.Drawing.Size(100, 101);
            this.butStockListWithFilters.TabIndex = 11;
            this.butStockListWithFilters.Text = "PARAMETRE STOK LİSTESİ";
            this.butStockListWithFilters.UseVisualStyleBackColor = false;
            this.butStockListWithFilters.Click += new System.EventHandler(this.butStockListWithFilters_Click);
            // 
            // butAddStock
            // 
            this.butAddStock.BackColor = System.Drawing.Color.PeachPuff;
            this.butAddStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butAddStock.Location = new System.Drawing.Point(242, 226);
            this.butAddStock.Name = "butAddStock";
            this.butAddStock.Size = new System.Drawing.Size(100, 101);
            this.butAddStock.TabIndex = 12;
            this.butAddStock.Text = "STOK KARTI EKLE";
            this.butAddStock.UseVisualStyleBackColor = false;
            this.butAddStock.Click += new System.EventHandler(this.butAddStock_Click);
            // 
            // butDeleteStock
            // 
            this.butDeleteStock.BackColor = System.Drawing.Color.PeachPuff;
            this.butDeleteStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butDeleteStock.Location = new System.Drawing.Point(242, 333);
            this.butDeleteStock.Name = "butDeleteStock";
            this.butDeleteStock.Size = new System.Drawing.Size(100, 101);
            this.butDeleteStock.TabIndex = 13;
            this.butDeleteStock.Text = "STOK KARTI SİL";
            this.butDeleteStock.UseVisualStyleBackColor = false;
            this.butDeleteStock.Click += new System.EventHandler(this.butDeleteStock_Click);
            // 
            // butGetExtreWithCode
            // 
            this.butGetExtreWithCode.BackColor = System.Drawing.Color.PeachPuff;
            this.butGetExtreWithCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butGetExtreWithCode.Location = new System.Drawing.Point(68, 440);
            this.butGetExtreWithCode.Name = "butGetExtreWithCode";
            this.butGetExtreWithCode.Size = new System.Drawing.Size(100, 101);
            this.butGetExtreWithCode.TabIndex = 14;
            this.butGetExtreWithCode.Text = "CARİ EKSTRE";
            this.butGetExtreWithCode.UseVisualStyleBackColor = false;
            this.butGetExtreWithCode.Click += new System.EventHandler(this.butGetExtreWithCode_Click);
            // 
            // butGetStockExtreWithCode
            // 
            this.butGetStockExtreWithCode.BackColor = System.Drawing.Color.PeachPuff;
            this.butGetStockExtreWithCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butGetStockExtreWithCode.Location = new System.Drawing.Point(174, 440);
            this.butGetStockExtreWithCode.Name = "butGetStockExtreWithCode";
            this.butGetStockExtreWithCode.Size = new System.Drawing.Size(100, 101);
            this.butGetStockExtreWithCode.TabIndex = 15;
            this.butGetStockExtreWithCode.Text = "STOK EKSTRE";
            this.butGetStockExtreWithCode.UseVisualStyleBackColor = false;
            this.butGetStockExtreWithCode.Click += new System.EventHandler(this.butGetStockExtreWithCode_Click);
            // 
            // stripDurum
            // 
            this.stripDurum.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.stripDurum.Location = new System.Drawing.Point(0, 651);
            this.stripDurum.Name = "stripDurum";
            this.stripDurum.Size = new System.Drawing.Size(823, 22);
            this.stripDurum.TabIndex = 16;
            this.stripDurum.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // frmOrkaTicari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 673);
            this.Controls.Add(this.stripDurum);
            this.Controls.Add(this.butGetStockExtreWithCode);
            this.Controls.Add(this.butGetExtreWithCode);
            this.Controls.Add(this.butDeleteStock);
            this.Controls.Add(this.butAddStock);
            this.Controls.Add(this.butStockListWithFilters);
            this.Controls.Add(this.butGetAllStocks);
            this.Controls.Add(this.butPaymentListWithFilters);
            this.Controls.Add(this.butAddBankPayment);
            this.Controls.Add(this.butAddCashPayment);
            this.Controls.Add(this.butPaymentList);
            this.Controls.Add(this.butAddInvoice);
            this.Controls.Add(this.butAddOrder);
            this.Controls.Add(this.butInvoiceListWithFilters);
            this.Controls.Add(this.rchSonuc);
            this.Controls.Add(this.butInvoiceList);
            this.Name = "frmOrkaTicari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ORKA TİCARİ iŞLEMLER";
            this.Load += new System.EventHandler(this.frmOrkaTicari_Load);
            this.stripDurum.ResumeLayout(false);
            this.stripDurum.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butInvoiceList;
        private System.Windows.Forms.RichTextBox rchSonuc;
        private System.Windows.Forms.Button butInvoiceListWithFilters;
        private System.Windows.Forms.Button butAddOrder;
        private System.Windows.Forms.Button butAddInvoice;
        private System.Windows.Forms.Button butPaymentList;
        private System.Windows.Forms.Button butAddCashPayment;
        private System.Windows.Forms.Button butAddBankPayment;
        private System.Windows.Forms.Button butPaymentListWithFilters;
        private System.Windows.Forms.Button butGetAllStocks;
        private System.Windows.Forms.Button butStockListWithFilters;
        private System.Windows.Forms.Button butAddStock;
        private System.Windows.Forms.Button butDeleteStock;
        private System.Windows.Forms.Button butGetExtreWithCode;
        private System.Windows.Forms.Button butGetStockExtreWithCode;
        private System.Windows.Forms.StatusStrip stripDurum;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
    }
}

