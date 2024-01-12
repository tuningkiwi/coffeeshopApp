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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.welcomeTab = new System.Windows.Forms.TabPage();
            this.welcomeImgButton = new System.Windows.Forms.Button();
            this.takeOutTab = new System.Windows.Forms.TabPage();
            this.toGoBtn = new System.Windows.Forms.Button();
            this.forHereBtn = new System.Windows.Forms.Button();
            this.menuTab = new System.Windows.Forms.TabPage();
            this.cartTab = new System.Windows.Forms.TabPage();
            this.payTab = new System.Windows.Forms.TabPage();
            this.AdminTab = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.welcomeTab.SuspendLayout();
            this.takeOutTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.welcomeTab);
            this.tabControl.Controls.Add(this.takeOutTab);
            this.tabControl.Controls.Add(this.menuTab);
            this.tabControl.Controls.Add(this.cartTab);
            this.tabControl.Controls.Add(this.payTab);
            this.tabControl.Controls.Add(this.AdminTab);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1920, 1080);
            this.tabControl.TabIndex = 0;
            // 
            // welcomeTab
            // 
            this.welcomeTab.Controls.Add(this.welcomeImgButton);
            this.welcomeTab.Location = new System.Drawing.Point(4, 22);
            this.welcomeTab.Name = "welcomeTab";
            this.welcomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.welcomeTab.Size = new System.Drawing.Size(1912, 1054);
            this.welcomeTab.TabIndex = 0;
            this.welcomeTab.Text = "웰컴";
            this.welcomeTab.UseVisualStyleBackColor = true;
            // 
            // welcomeImgButton
            // 
            this.welcomeImgButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomeImgButton.Image = ((System.Drawing.Image)(resources.GetObject("welcomeImgButton.Image")));
            this.welcomeImgButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.welcomeImgButton.Location = new System.Drawing.Point(3, 3);
            this.welcomeImgButton.Name = "welcomeImgButton";
            this.welcomeImgButton.Size = new System.Drawing.Size(1906, 1048);
            this.welcomeImgButton.TabIndex = 0;
            this.welcomeImgButton.UseVisualStyleBackColor = true;
            this.welcomeImgButton.Click += new System.EventHandler(this.welcomeImgButton_Click);
            // 
            // takeOutTab
            // 
            this.takeOutTab.Controls.Add(this.toGoBtn);
            this.takeOutTab.Controls.Add(this.forHereBtn);
            this.takeOutTab.Location = new System.Drawing.Point(4, 22);
            this.takeOutTab.Name = "takeOutTab";
            this.takeOutTab.Padding = new System.Windows.Forms.Padding(3);
            this.takeOutTab.Size = new System.Drawing.Size(1912, 1054);
            this.takeOutTab.TabIndex = 1;
            this.takeOutTab.Text = "테이크아웃/인";
            this.takeOutTab.UseVisualStyleBackColor = true;
            // 
            // toGoBtn
            // 
            this.toGoBtn.Location = new System.Drawing.Point(1017, 305);
            this.toGoBtn.Name = "toGoBtn";
            this.toGoBtn.Size = new System.Drawing.Size(418, 401);
            this.toGoBtn.TabIndex = 1;
            this.toGoBtn.Text = "포장하기";
            this.toGoBtn.UseVisualStyleBackColor = true;
            // 
            // forHereBtn
            // 
            this.forHereBtn.Location = new System.Drawing.Point(378, 305);
            this.forHereBtn.Name = "forHereBtn";
            this.forHereBtn.Size = new System.Drawing.Size(418, 401);
            this.forHereBtn.TabIndex = 0;
            this.forHereBtn.Text = "먹고가기";
            this.forHereBtn.UseVisualStyleBackColor = true;
            this.forHereBtn.Click += new System.EventHandler(this.forHereBtn_Click);
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
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "유동 커피숍";
            this.tabControl.ResumeLayout(false);
            this.welcomeTab.ResumeLayout(false);
            this.takeOutTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage welcomeTab;
        private System.Windows.Forms.TabPage takeOutTab;
        private System.Windows.Forms.TabPage menuTab;
        private System.Windows.Forms.TabPage cartTab;
        private System.Windows.Forms.TabPage payTab;
        private System.Windows.Forms.TabPage AdminTab;
        private System.Windows.Forms.Button welcomeImgButton;
        private System.Windows.Forms.Button forHereBtn;
        private System.Windows.Forms.Button toGoBtn;
    }
}

