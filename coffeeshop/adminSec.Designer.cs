namespace coffeeshop
{
    partial class adminSec
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.totalSalesBtn = new System.Windows.Forms.Label();
            this.completedListBtn = new System.Windows.Forms.Button();
            this.waitingListBtn = new System.Windows.Forms.Button();
            this.dataGridView_admin = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_admin)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.totalSalesBtn);
            this.splitContainer1.Panel1.Controls.Add(this.completedListBtn);
            this.splitContainer1.Panel1.Controls.Add(this.waitingListBtn);
            this.splitContainer1.Panel1MinSize = 180;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView_admin);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.TabIndex = 0;
            // 
            // totalSalesBtn
            // 
            this.totalSalesBtn.AutoSize = true;
            this.totalSalesBtn.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.totalSalesBtn.Location = new System.Drawing.Point(539, 48);
            this.totalSalesBtn.Name = "totalSalesBtn";
            this.totalSalesBtn.Size = new System.Drawing.Size(130, 24);
            this.totalSalesBtn.TabIndex = 2;
            this.totalSalesBtn.Text = "누적 매출: ";
            this.totalSalesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // completedListBtn
            // 
            this.completedListBtn.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.completedListBtn.Location = new System.Drawing.Point(288, 35);
            this.completedListBtn.Name = "completedListBtn";
            this.completedListBtn.Size = new System.Drawing.Size(245, 50);
            this.completedListBtn.TabIndex = 1;
            this.completedListBtn.Text = "완료주문 확인하기";
            this.completedListBtn.UseVisualStyleBackColor = true;
            // 
            // waitingListBtn
            // 
            this.waitingListBtn.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.waitingListBtn.Location = new System.Drawing.Point(26, 35);
            this.waitingListBtn.Name = "waitingListBtn";
            this.waitingListBtn.Size = new System.Drawing.Size(245, 50);
            this.waitingListBtn.TabIndex = 0;
            this.waitingListBtn.Text = "대기주문 확인하기";
            this.waitingListBtn.UseVisualStyleBackColor = true;
            this.waitingListBtn.Click += new System.EventHandler(this.waitingListBtn_Click);
            // 
            // dataGridView_admin
            // 
            this.dataGridView_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_admin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_admin.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_admin.Name = "dataGridView_admin";
            this.dataGridView_admin.RowTemplate.Height = 40;
            this.dataGridView_admin.Size = new System.Drawing.Size(800, 266);
            this.dataGridView_admin.TabIndex = 0;
            this.dataGridView_admin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_admin_CellClick);
            // 
            // adminSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "adminSec";
            this.Text = "관리자 모드";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_admin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button waitingListBtn;
        private System.Windows.Forms.DataGridView dataGridView_admin;
        private System.Windows.Forms.Label totalSalesBtn;
        private System.Windows.Forms.Button completedListBtn;
    }
}