namespace coffeeshop
{
    partial class termConfig
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
            this.label1 = new System.Windows.Forms.Label();
            this.comPortBox = new System.Windows.Forms.ComboBox();
            this.baudRateBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.parityBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataBitsBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stopBitsBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.sbLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.OKbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Com Port";
            // 
            // comPortBox
            // 
            this.comPortBox.FormattingEnabled = true;
            this.comPortBox.Items.AddRange(new object[] {
            "COM1"});
            this.comPortBox.Location = new System.Drawing.Point(128, 59);
            this.comPortBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comPortBox.Name = "comPortBox";
            this.comPortBox.Size = new System.Drawing.Size(138, 23);
            this.comPortBox.TabIndex = 1;
            // 
            // baudRateBox
            // 
            this.baudRateBox.FormattingEnabled = true;
            this.baudRateBox.Items.AddRange(new object[] {
            "115200",
            "57600",
            "38400",
            "19200",
            "9600"});
            this.baudRateBox.Location = new System.Drawing.Point(128, 91);
            this.baudRateBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.baudRateBox.Name = "baudRateBox";
            this.baudRateBox.Size = new System.Drawing.Size(138, 23);
            this.baudRateBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud Rate";
            // 
            // parityBox
            // 
            this.parityBox.FormattingEnabled = true;
            this.parityBox.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.parityBox.Location = new System.Drawing.Point(128, 124);
            this.parityBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.parityBox.Name = "parityBox";
            this.parityBox.Size = new System.Drawing.Size(138, 23);
            this.parityBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parity";
            // 
            // dataBitsBox
            // 
            this.dataBitsBox.FormattingEnabled = true;
            this.dataBitsBox.Items.AddRange(new object[] {
            "8",
            "7"});
            this.dataBitsBox.Location = new System.Drawing.Point(128, 156);
            this.dataBitsBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataBitsBox.Name = "dataBitsBox";
            this.dataBitsBox.Size = new System.Drawing.Size(138, 23);
            this.dataBitsBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data Bits";
            // 
            // stopBitsBox
            // 
            this.stopBitsBox.FormattingEnabled = true;
            this.stopBitsBox.Items.AddRange(new object[] {
            "None",
            "1",
            "2"});
            this.stopBitsBox.Location = new System.Drawing.Point(128, 189);
            this.stopBitsBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stopBitsBox.Name = "stopBitsBox";
            this.stopBitsBox.Size = new System.Drawing.Size(138, 23);
            this.stopBitsBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stop Bits";
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbLabel1});
            this.statusBar.Location = new System.Drawing.Point(0, 299);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusBar.Size = new System.Drawing.Size(295, 26);
            this.statusBar.TabIndex = 10;
            this.statusBar.Text = "포트연결결과";
            // 
            // sbLabel1
            // 
            this.sbLabel1.Name = "sbLabel1";
            this.sbLabel1.Size = new System.Drawing.Size(69, 20);
            this.sbLabel1.Text = "포트연결";
            // 
            // OKbtn
            // 
            this.OKbtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKbtn.Location = new System.Drawing.Point(167, 240);
            this.OKbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(86, 29);
            this.OKbtn.TabIndex = 11;
            this.OKbtn.Text = "확인";
            this.OKbtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(53, 240);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "취소";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // termConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 325);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OKbtn);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.stopBitsBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataBitsBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.parityBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.baudRateBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comPortBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "termConfig";
            this.Text = "통신파라미터설정";
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel sbLabel1;
        public System.Windows.Forms.ComboBox comPortBox;
        public System.Windows.Forms.ComboBox baudRateBox;
        public System.Windows.Forms.ComboBox parityBox;
        public System.Windows.Forms.ComboBox dataBitsBox;
        public System.Windows.Forms.ComboBox stopBitsBox;
        private System.Windows.Forms.Button OKbtn;
        private System.Windows.Forms.Button button1;
    }
}