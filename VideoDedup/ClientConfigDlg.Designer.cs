namespace VideoDedup
{

    partial class ClientConfigDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientConfigDlg));
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOkay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PibServerAddressLoading = new System.Windows.Forms.PictureBox();
            this.NudStatusRequestInterval = new System.Windows.Forms.NumericUpDown();
            this.TxtServerAddress = new VideoDedup.DnsTextBox.DnsTextBoxCtrl();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PibServerAddressLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudStatusRequestInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(294, 123);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 23;
            this.BtnCancel.Text = "&Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnOkay
            // 
            this.BtnOkay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOkay.Location = new System.Drawing.Point(213, 123);
            this.BtnOkay.Name = "BtnOkay";
            this.BtnOkay.Size = new System.Drawing.Size(75, 23);
            this.BtnOkay.TabIndex = 22;
            this.BtnOkay.Text = "&OK";
            this.BtnOkay.UseVisualStyleBackColor = true;
            this.BtnOkay.Click += new System.EventHandler(this.BtnOkay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 105);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Connection";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PibServerAddressLoading, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtServerAddress, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.NudStatusRequestInterval, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(351, 86);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Address:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Status Request Interval in milliseconds:";
            // 
            // PibServerAddressLoading
            // 
            this.PibServerAddressLoading.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PibServerAddressLoading.InitialImage = null;
            this.PibServerAddressLoading.Location = new System.Drawing.Point(290, 5);
            this.PibServerAddressLoading.Name = "PibServerAddressLoading";
            this.PibServerAddressLoading.Size = new System.Drawing.Size(32, 32);
            this.PibServerAddressLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PibServerAddressLoading.TabIndex = 2;
            this.PibServerAddressLoading.TabStop = false;
            // 
            // NudStatusRequestInterval
            // 
            this.NudStatusRequestInterval.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NudStatusRequestInterval.Location = new System.Drawing.Point(290, 54);
            this.NudStatusRequestInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudStatusRequestInterval.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NudStatusRequestInterval.Name = "NudStatusRequestInterval";
            this.NudStatusRequestInterval.Size = new System.Drawing.Size(58, 20);
            this.NudStatusRequestInterval.TabIndex = 4;
            this.NudStatusRequestInterval.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // TxtServerAddress
            // 
            this.TxtServerAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtServerAddress.Location = new System.Drawing.Point(91, 11);
            this.TxtServerAddress.Name = "TxtServerAddress";
            this.TxtServerAddress.ResolvedSuccessfully = false;
            this.TxtServerAddress.Resolving = false;
            this.TxtServerAddress.Size = new System.Drawing.Size(193, 20);
            this.TxtServerAddress.TabIndex = 3;
            this.TxtServerAddress.ResolveStarted += new System.EventHandler<VideoDedup.DnsTextBox.ResolveStartedEventArgs>(this.TxtServerAddress_ResolveStarted);
            this.TxtServerAddress.ResolveSuccessful += new System.EventHandler<VideoDedup.DnsTextBox.ResolveSuccessfulEventArgs>(this.TxtServerAddress_ResolveSuccessful);
            this.TxtServerAddress.ResolveFailed += new System.EventHandler<VideoDedup.DnsTextBox.ResolveFailedEventArgs>(this.TxtServerAddress_ResolveFailed);
            // 
            // ClientConfigDlg
            // 
            this.AcceptButton = this.BtnOkay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(381, 158);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOkay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientConfigDlg";
            this.Text = "Client Configuration";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PibServerAddressLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudStatusRequestInterval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOkay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PibServerAddressLoading;
        private DnsTextBox.DnsTextBoxCtrl TxtServerAddress;
        private System.Windows.Forms.NumericUpDown NudStatusRequestInterval;
    }
}