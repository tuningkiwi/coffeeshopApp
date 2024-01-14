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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.welcomeTab = new System.Windows.Forms.TabPage();
            this.welcomeImgBtn = new System.Windows.Forms.Button();
            this.welcomeImgButton = new System.Windows.Forms.Button();
            this.takeOutTab = new System.Windows.Forms.TabPage();
            this.toGoBtn = new System.Windows.Forms.Button();
            this.forHereBtn = new System.Windows.Forms.Button();
            this.menuTab = new System.Windows.Forms.TabPage();
            this.menuListLb = new System.Windows.Forms.Label();
            this.menu_cart = new System.Windows.Forms.Button();
            this.goToBegin = new System.Windows.Forms.Button();
            this.vlaBtn = new System.Windows.Forms.Button();
            this.latBtn = new System.Windows.Forms.Button();
            this.ameBtn = new System.Windows.Forms.Button();
            this.cartTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.totalCountLb = new System.Windows.Forms.Label();
            this.paymentBtn = new System.Windows.Forms.Button();
            this.payTab = new System.Windows.Forms.TabPage();
            this.pay_priceLb = new System.Windows.Forms.Label();
            this.AdminTab = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.welcomeTab.SuspendLayout();
            this.takeOutTab.SuspendLayout();
            this.menuTab.SuspendLayout();
            this.cartTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.payTab.SuspendLayout();
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
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1520, 1022);
            this.tabControl.TabIndex = 0;
            // 
            // welcomeTab
            // 
            this.welcomeTab.Controls.Add(this.welcomeImgBtn);
            this.welcomeTab.Controls.Add(this.welcomeImgButton);
            this.welcomeTab.Location = new System.Drawing.Point(4, 28);
            this.welcomeTab.Margin = new System.Windows.Forms.Padding(4);
            this.welcomeTab.Name = "welcomeTab";
            this.welcomeTab.Padding = new System.Windows.Forms.Padding(4);
            this.welcomeTab.Size = new System.Drawing.Size(1512, 990);
            this.welcomeTab.TabIndex = 0;
            this.welcomeTab.Text = "웰컴";
            this.welcomeTab.UseVisualStyleBackColor = true;
            // 
            // welcomeImgBtn
            // 
            this.welcomeImgBtn.Location = new System.Drawing.Point(711, 396);
            this.welcomeImgBtn.Margin = new System.Windows.Forms.Padding(4);
            this.welcomeImgBtn.Name = "welcomeImgBtn";
            this.welcomeImgBtn.Size = new System.Drawing.Size(107, 34);
            this.welcomeImgBtn.TabIndex = 0;
            this.welcomeImgBtn.Text = "button";
            this.welcomeImgBtn.Visible = false;
            // 
            // welcomeImgButton
            // 
            this.welcomeImgButton.BackgroundImage = global::coffeeshop.Properties.Resources.americano;
            this.welcomeImgButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomeImgButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.welcomeImgButton.Location = new System.Drawing.Point(4, 4);
            this.welcomeImgButton.Margin = new System.Windows.Forms.Padding(4);
            this.welcomeImgButton.Name = "welcomeImgButton";
            this.welcomeImgButton.Size = new System.Drawing.Size(1504, 982);
            this.welcomeImgButton.TabIndex = 0;
            this.welcomeImgButton.UseVisualStyleBackColor = true;
            this.welcomeImgButton.Click += new System.EventHandler(this.welcomeImgBtn_Click);
            // 
            // takeOutTab
            // 
            this.takeOutTab.Controls.Add(this.toGoBtn);
            this.takeOutTab.Controls.Add(this.forHereBtn);
            this.takeOutTab.Location = new System.Drawing.Point(4, 28);
            this.takeOutTab.Margin = new System.Windows.Forms.Padding(4);
            this.takeOutTab.Name = "takeOutTab";
            this.takeOutTab.Padding = new System.Windows.Forms.Padding(4);
            this.takeOutTab.Size = new System.Drawing.Size(1512, 990);
            this.takeOutTab.TabIndex = 1;
            this.takeOutTab.Text = "테이크아웃/인";
            this.takeOutTab.UseVisualStyleBackColor = true;
            // 
            // toGoBtn
            // 
            this.toGoBtn.Location = new System.Drawing.Point(844, 120);
            this.toGoBtn.Margin = new System.Windows.Forms.Padding(4);
            this.toGoBtn.Name = "toGoBtn";
            this.toGoBtn.Size = new System.Drawing.Size(597, 602);
            this.toGoBtn.TabIndex = 1;
            this.toGoBtn.Text = "포장하기";
            this.toGoBtn.UseVisualStyleBackColor = true;
            this.toGoBtn.Click += new System.EventHandler(this.toGoBtn_Click);
            // 
            // forHereBtn
            // 
            this.forHereBtn.Location = new System.Drawing.Point(143, 120);
            this.forHereBtn.Margin = new System.Windows.Forms.Padding(4);
            this.forHereBtn.Name = "forHereBtn";
            this.forHereBtn.Size = new System.Drawing.Size(597, 602);
            this.forHereBtn.TabIndex = 0;
            this.forHereBtn.Text = "먹고가기";
            this.forHereBtn.UseVisualStyleBackColor = true;
            this.forHereBtn.Click += new System.EventHandler(this.forHereBtn_Click);
            // 
            // menuTab
            // 
            this.menuTab.AutoScroll = true;
            this.menuTab.Controls.Add(this.menuListLb);
            this.menuTab.Controls.Add(this.menu_cart);
            this.menuTab.Controls.Add(this.goToBegin);
            this.menuTab.Controls.Add(this.vlaBtn);
            this.menuTab.Controls.Add(this.latBtn);
            this.menuTab.Controls.Add(this.ameBtn);
            this.menuTab.Location = new System.Drawing.Point(4, 28);
            this.menuTab.Margin = new System.Windows.Forms.Padding(4);
            this.menuTab.Name = "menuTab";
            this.menuTab.Size = new System.Drawing.Size(1512, 990);
            this.menuTab.TabIndex = 2;
            this.menuTab.Text = "메뉴";
            this.menuTab.UseVisualStyleBackColor = true;
            // 
            // menuListLb
            // 
            this.menuListLb.AutoSize = true;
            this.menuListLb.Font = new System.Drawing.Font("D2Coding", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuListLb.Location = new System.Drawing.Point(97, 604);
            this.menuListLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.menuListLb.Name = "menuListLb";
            this.menuListLb.Size = new System.Drawing.Size(113, 37);
            this.menuListLb.TabIndex = 5;
            this.menuListLb.Text = "label1";
            // 
            // menu_cart
            // 
            this.menu_cart.Font = new System.Drawing.Font("D2Coding", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menu_cart.Location = new System.Drawing.Point(1289, 800);
            this.menu_cart.Margin = new System.Windows.Forms.Padding(4);
            this.menu_cart.Name = "menu_cart";
            this.menu_cart.Size = new System.Drawing.Size(253, 110);
            this.menu_cart.TabIndex = 4;
            this.menu_cart.Text = "장바구니";
            this.menu_cart.UseVisualStyleBackColor = true;
            this.menu_cart.Click += new System.EventHandler(this.menu_cart_Click);
            // 
            // goToBegin
            // 
            this.goToBegin.Font = new System.Drawing.Font("D2Coding", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.goToBegin.Location = new System.Drawing.Point(1289, 660);
            this.goToBegin.Margin = new System.Windows.Forms.Padding(4);
            this.goToBegin.Name = "goToBegin";
            this.goToBegin.Size = new System.Drawing.Size(253, 110);
            this.goToBegin.TabIndex = 1;
            this.goToBegin.Text = "처음으로";
            this.goToBegin.UseVisualStyleBackColor = true;
            this.goToBegin.Click += new System.EventHandler(this.goToBegin_Click);
            // 
            // vlaBtn
            // 
            this.vlaBtn.Image = global::coffeeshop.Properties.Resources.vanilalatte;
            this.vlaBtn.Location = new System.Drawing.Point(1209, 150);
            this.vlaBtn.Margin = new System.Windows.Forms.Padding(4);
            this.vlaBtn.Name = "vlaBtn";
            this.vlaBtn.Size = new System.Drawing.Size(394, 414);
            this.vlaBtn.TabIndex = 2;
            this.vlaBtn.Text = "button3";
            this.vlaBtn.UseVisualStyleBackColor = true;
            // 
            // latBtn
            // 
            this.latBtn.Image = global::coffeeshop.Properties.Resources.latte;
            this.latBtn.Location = new System.Drawing.Point(699, 150);
            this.latBtn.Margin = new System.Windows.Forms.Padding(4);
            this.latBtn.Name = "latBtn";
            this.latBtn.Size = new System.Drawing.Size(394, 414);
            this.latBtn.TabIndex = 1;
            this.latBtn.Text = "button2";
            this.latBtn.UseVisualStyleBackColor = true;
            this.latBtn.Click += new System.EventHandler(this.latBtn_Click);
            // 
            // ameBtn
            // 
            this.ameBtn.Image = global::coffeeshop.Properties.Resources.americano;
            this.ameBtn.Location = new System.Drawing.Point(143, 150);
            this.ameBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ameBtn.Name = "ameBtn";
            this.ameBtn.Size = new System.Drawing.Size(394, 414);
            this.ameBtn.TabIndex = 0;
            this.ameBtn.Text = "button1";
            this.ameBtn.UseVisualStyleBackColor = true;
            this.ameBtn.Click += new System.EventHandler(this.ameBtn_Click);
            // 
            // cartTab
            // 
            this.cartTab.Controls.Add(this.splitContainer1);
            this.cartTab.Location = new System.Drawing.Point(4, 28);
            this.cartTab.Margin = new System.Windows.Forms.Padding(4);
            this.cartTab.Name = "cartTab";
            this.cartTab.Size = new System.Drawing.Size(1512, 990);
            this.cartTab.TabIndex = 3;
            this.cartTab.Text = "장바구니";
            this.cartTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.totalCountLb);
            this.splitContainer1.Panel2.Controls.Add(this.paymentBtn);
            this.splitContainer1.Size = new System.Drawing.Size(1512, 990);
            this.splitContainer1.SplitterDistance = 750;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(750, 990);
            this.dataGridView1.TabIndex = 0;
            // 
            // totalCountLb
            // 
            this.totalCountLb.AutoSize = true;
            this.totalCountLb.Font = new System.Drawing.Font("D2Coding", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.totalCountLb.Location = new System.Drawing.Point(110, 451);
            this.totalCountLb.Name = "totalCountLb";
            this.totalCountLb.Size = new System.Drawing.Size(216, 42);
            this.totalCountLb.TabIndex = 2;
            this.totalCountLb.Text = "TOTAL LABEL";
            this.totalCountLb.Click += new System.EventHandler(this.totalCountLb_Click);
            // 
            // paymentBtn
            // 
            this.paymentBtn.Location = new System.Drawing.Point(143, 515);
            this.paymentBtn.Name = "paymentBtn";
            this.paymentBtn.Size = new System.Drawing.Size(197, 59);
            this.paymentBtn.TabIndex = 1;
            this.paymentBtn.Text = "결제하기";
            this.paymentBtn.UseVisualStyleBackColor = true;
            this.paymentBtn.Click += new System.EventHandler(this.paymentBtn_Click);
            // 
            // payTab
            // 
            this.payTab.Controls.Add(this.pay_priceLb);
            this.payTab.Location = new System.Drawing.Point(4, 28);
            this.payTab.Margin = new System.Windows.Forms.Padding(4);
            this.payTab.Name = "payTab";
            this.payTab.Size = new System.Drawing.Size(1512, 990);
            this.payTab.TabIndex = 4;
            this.payTab.Text = "결제하기";
            this.payTab.UseVisualStyleBackColor = true;
            // 
            // pay_priceLb
            // 
            this.pay_priceLb.AutoSize = true;
            this.pay_priceLb.Font = new System.Drawing.Font("D2Coding", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pay_priceLb.Location = new System.Drawing.Point(29, 375);
            this.pay_priceLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pay_priceLb.Name = "pay_priceLb";
            this.pay_priceLb.Size = new System.Drawing.Size(168, 55);
            this.pay_priceLb.TabIndex = 0;
            this.pay_priceLb.Text = "label1";
            // 
            // AdminTab
            // 
            this.AdminTab.Location = new System.Drawing.Point(4, 28);
            this.AdminTab.Margin = new System.Windows.Forms.Padding(4);
            this.AdminTab.Name = "AdminTab";
            this.AdminTab.Size = new System.Drawing.Size(1512, 990);
            this.AdminTab.TabIndex = 5;
            this.AdminTab.Text = "관리자모드";
            this.AdminTab.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 1022);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "유동 커피숍";
            this.tabControl.ResumeLayout(false);
            this.welcomeTab.ResumeLayout(false);
            this.takeOutTab.ResumeLayout(false);
            this.menuTab.ResumeLayout(false);
            this.menuTab.PerformLayout();
            this.cartTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.payTab.ResumeLayout(false);
            this.payTab.PerformLayout();
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
        private System.Windows.Forms.Button ameBtn;
        private System.Windows.Forms.Button vlaBtn;
        private System.Windows.Forms.Button latBtn;
        private System.Windows.Forms.Button welcomeImgBtn;
        private System.Windows.Forms.Button goToBegin;
        private System.Windows.Forms.Button menu_cart;
        private System.Windows.Forms.Label menuListLb;
        private System.Windows.Forms.Label pay_priceLb;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button paymentBtn;
        private System.Windows.Forms.Label totalCountLb;
    }
}

