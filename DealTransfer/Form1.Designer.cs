namespace DealTransfer
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
            this.dgvInputData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenInputFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPasteData = new System.Windows.Forms.Button();
            this.AccountId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentDealNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentDeal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentBal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LitFlowStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInputData
            // 
            this.dgvInputData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInputData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountId,
            this.CurrentDealNo,
            this.CurrentDeal,
            this.CurrentBal,
            this.LitFlowStatus});
            this.dgvInputData.Location = new System.Drawing.Point(26, 103);
            this.dgvInputData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvInputData.Name = "dgvInputData";
            this.dgvInputData.RowTemplate.Height = 33;
            this.dgvInputData.Size = new System.Drawing.Size(897, 530);
            this.dgvInputData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source Deal Contents";
            // 
            // btnOpenInputFile
            // 
            this.btnOpenInputFile.Location = new System.Drawing.Point(652, 19);
            this.btnOpenInputFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenInputFile.Name = "btnOpenInputFile";
            this.btnOpenInputFile.Size = new System.Drawing.Size(114, 29);
            this.btnOpenInputFile.TabIndex = 2;
            this.btnOpenInputFile.Text = "Load Accounts";
            this.btnOpenInputFile.UseVisualStyleBackColor = true;
            this.btnOpenInputFile.Click += new System.EventHandler(this.btnOpenInputFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(793, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "File must be in CSV format";
            // 
            // btnPasteData
            // 
            this.btnPasteData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPasteData.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasteData.Location = new System.Drawing.Point(26, 27);
            this.btnPasteData.Name = "btnPasteData";
            this.btnPasteData.Size = new System.Drawing.Size(140, 48);
            this.btnPasteData.TabIndex = 4;
            this.btnPasteData.Text = "Paste Data";
            this.btnPasteData.UseVisualStyleBackColor = false;
            this.btnPasteData.Click += new System.EventHandler(this.btnPasteData_Click);
            // 
            // AccountId
            // 
            this.AccountId.HeaderText = "AccountID";
            this.AccountId.Name = "AccountId";
            this.AccountId.Width = 80;
            // 
            // CurrentDealNo
            // 
            this.CurrentDealNo.HeaderText = "Current Deal No";
            this.CurrentDealNo.Name = "CurrentDealNo";
            this.CurrentDealNo.Width = 80;
            // 
            // CurrentDeal
            // 
            this.CurrentDeal.HeaderText = "Current Deal";
            this.CurrentDeal.Name = "CurrentDeal";
            this.CurrentDeal.Width = 300;
            // 
            // CurrentBal
            // 
            this.CurrentBal.HeaderText = "Balance";
            this.CurrentBal.Name = "CurrentBal";
            // 
            // LitFlowStatus
            // 
            this.LitFlowStatus.HeaderText = "Status";
            this.LitFlowStatus.Name = "LitFlowStatus";
            this.LitFlowStatus.Width = 300;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 663);
            this.Controls.Add(this.btnPasteData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOpenInputFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvInputData);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInputData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenInputFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPasteData;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentDealNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentDeal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentBal;
        private System.Windows.Forms.DataGridViewTextBoxColumn LitFlowStatus;
    }
}

