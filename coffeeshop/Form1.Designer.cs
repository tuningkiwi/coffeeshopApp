namespace coffeeshop
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.welcomeTab = new System.Windows.Forms.TabPage();
            this.takeOutTab = new System.Windows.Forms.TabPage();
            this.menuTab = new System.Windows.Forms.TabPage();
            this.cartTab = new System.Windows.Forms.TabPage();
            this.payTab = new System.Windows.Forms.TabPage();
            this.AdminTab = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.welcomeTab);
            this.tabControl1.Controls.Add(this.takeOutTab);
            this.tabControl1.Controls.Add(this.menuTab);
            this.tabControl1.Controls.Add(this.cartTab);
            this.tabControl1.Controls.Add(this.payTab);
            this.tabControl1.Controls.Add(this.AdminTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1920, 1080);
            this.tabControl1.TabIndex = 0;
            // 
            // welcomeTab
            // 
            this.welcomeTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("welcomeTab.BackgroundImage")));
            this.welcomeTab.Location = new System.Drawing.Point(4, 22);
            this.welcomeTab.Name = "welcomeTab";
            this.welcomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.welcomeTab.Size = new System.Drawing.Size(1912, 1054);
            this.welcomeTab.TabIndex = 0;
            this.welcomeTab.Text = "웰컴";
            this.welcomeTab.UseVisualStyleBackColor = true;
            // 
            // takeOutTab
            // 
            this.takeOutTab.Location = new System.Drawing.Point(4, 22);
            this.takeOutTab.Name = "takeOutTab";
            this.takeOutTab.Padding = new System.Windows.Forms.Padding(3);
            this.takeOutTab.Size = new System.Drawing.Size(1912, 1054);
            this.takeOutTab.TabIndex = 1;
            this.takeOutTab.Text = "테이크아웃/인";
            this.takeOutTab.UseVisualStyleBackColor = true;
            // 
            // menuTab
            // 
            this.menuTab.Location = new System.Drawing.Point(4, 22);
            this.menuTab.Name = "menuTab";
            this.menuTab.Size = new System.Drawing.Size(1912, 1054);
            this.menuTab.TabIndex = 2;
            this.menuTab.Text = "메뉴";
            this.menuTab.UseVisualStyleBackColor = true;
            // 
            // cartTab
            // 
            this.cartTab.Location = new System.Drawing.Point(4, 22);
            this.cartTab.Name = "cartTab";
            this.cartTab.Size = new System.Drawing.Size(1912, 1054);
            this.cartTab.TabIndex = 3;
            this.cartTab.Text = "장바구니";
            this.cartTab.UseVisualStyleBackColor = true;
            // 
            // payTab
            // 
            this.payTab.Location = new System.Drawing.Point(4, 22);
            this.payTab.Name = "payTab";
            this.payTab.Size = new System.Drawing.Size(1912, 1054);
            this.payTab.TabIndex = 4;
            this.payTab.Text = "결제하기";
            this.payTab.UseVisualStyleBackColor = true;
            // 
            // AdminTab
            // 
            this.AdminTab.Location = new System.Drawing.Point(4, 22);
            this.AdminTab.Name = "AdminTab";
            this.AdminTab.Size = new System.Drawing.Size(1912, 1054);
            this.AdminTab.TabIndex = 5;
            this.AdminTab.Text = "관리자모드";
            this.AdminTab.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "유동 커피숍";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage welcomeTab;
        private System.Windows.Forms.TabPage takeOutTab;
        private System.Windows.Forms.TabPage menuTab;
        private System.Windows.Forms.TabPage cartTab;
        private System.Windows.Forms.TabPage payTab;
        private System.Windows.Forms.TabPage AdminTab;
    }
}

