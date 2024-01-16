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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.portOpenBtn = new System.Windows.Forms.Button();
            this.bell_5 = new System.Windows.Forms.Button();
            this.bell_4 = new System.Windows.Forms.Button();
            this.bell_3 = new System.Windows.Forms.Button();
            this.bell_2 = new System.Windows.Forms.Button();
            this.bell_1 = new System.Windows.Forms.Button();
            this.totalSalesBtn = new System.Windows.Forms.Label();
            this.completedListBtn = new System.Windows.Forms.Button();
            this.waitingListBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sbLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView_admin = new System.Windows.Forms.DataGridView();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.portOpenBtn);
            this.splitContainer1.Panel1.Controls.Add(this.bell_5);
            this.splitContainer1.Panel1.Controls.Add(this.bell_4);
            this.splitContainer1.Panel1.Controls.Add(this.bell_3);
            this.splitContainer1.Panel1.Controls.Add(this.bell_2);
            this.splitContainer1.Panel1.Controls.Add(this.bell_1);
            this.splitContainer1.Panel1.Controls.Add(this.totalSalesBtn);
            this.splitContainer1.Panel1.Controls.Add(this.completedListBtn);
            this.splitContainer1.Panel1.Controls.Add(this.waitingListBtn);
            this.splitContainer1.Panel1MinSize = 180;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView_admin);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.TabIndex = 0;
            // 
            // portOpenBtn
            // 
            this.portOpenBtn.Location = new System.Drawing.Point(363, 104);
            this.portOpenBtn.Name = "portOpenBtn";
            this.portOpenBtn.Size = new System.Drawing.Size(109, 23);
            this.portOpenBtn.TabIndex = 8;
            this.portOpenBtn.Text = "진동벨 연결";
            this.portOpenBtn.UseVisualStyleBackColor = true;
            this.portOpenBtn.Click += new System.EventHandler(this.portOpenBtn_Click);
            // 
            // bell_5
            // 
            this.bell_5.Location = new System.Drawing.Point(575, 133);
            this.bell_5.Name = "bell_5";
            this.bell_5.Size = new System.Drawing.Size(75, 23);
            this.bell_5.TabIndex = 7;
            this.bell_5.Text = "5번 벨";
            this.bell_5.UseVisualStyleBackColor = true;
            this.bell_5.Click += new System.EventHandler(this.bell_5_Click);
            // 
            // bell_4
            // 
            this.bell_4.Location = new System.Drawing.Point(494, 133);
            this.bell_4.Name = "bell_4";
            this.bell_4.Size = new System.Drawing.Size(75, 23);
            this.bell_4.TabIndex = 6;
            this.bell_4.Text = "4번 벨";
            this.bell_4.UseVisualStyleBackColor = true;
            this.bell_4.Click += new System.EventHandler(this.bell_4_Click);
            // 
            // bell_3
            // 
            this.bell_3.Location = new System.Drawing.Point(656, 104);
            this.bell_3.Name = "bell_3";
            this.bell_3.Size = new System.Drawing.Size(75, 23);
            this.bell_3.TabIndex = 5;
            this.bell_3.Text = "3번 벨";
            this.bell_3.UseVisualStyleBackColor = true;
            this.bell_3.Click += new System.EventHandler(this.bell_3_Click);
            // 
            // bell_2
            // 
            this.bell_2.Location = new System.Drawing.Point(575, 104);
            this.bell_2.Name = "bell_2";
            this.bell_2.Size = new System.Drawing.Size(75, 23);
            this.bell_2.TabIndex = 4;
            this.bell_2.Text = "2번 벨";
            this.bell_2.UseVisualStyleBackColor = true;
            this.bell_2.Click += new System.EventHandler(this.bell_2_Click);
            // 
            // bell_1
            // 
            this.bell_1.Location = new System.Drawing.Point(494, 104);
            this.bell_1.Name = "bell_1";
            this.bell_1.Size = new System.Drawing.Size(75, 23);
            this.bell_1.TabIndex = 3;
            this.bell_1.Text = "1번 벨";
            this.bell_1.UseVisualStyleBackColor = true;
            this.bell_1.Click += new System.EventHandler(this.bell_1_Click);
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 244);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sbLabel1
            // 
            this.sbLabel1.Name = "sbLabel1";
            this.sbLabel1.Size = new System.Drawing.Size(10, 17);
            this.sbLabel1.Text = ".";
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
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_admin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button waitingListBtn;
        private System.Windows.Forms.DataGridView dataGridView_admin;
        private System.Windows.Forms.Label totalSalesBtn;
        private System.Windows.Forms.Button completedListBtn;
        private System.Windows.Forms.Button bell_5;
        private System.Windows.Forms.Button bell_4;
        private System.Windows.Forms.Button bell_3;
        private System.Windows.Forms.Button bell_2;
        private System.Windows.Forms.Button bell_1;
        private System.Windows.Forms.Button portOpenBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sbLabel1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}