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
            this.orderListTb = new System.Windows.Forms.TextBox();
            this.vlaBtn = new System.Windows.Forms.Button();
            this.latBtn = new System.Windows.Forms.Button();
            this.ameBtn = new System.Windows.Forms.Button();
            this.cartTab = new System.Windows.Forms.TabPage();
            this.paymentBtn = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cart_orderlist = new System.Windows.Forms.Label();
            this.payTab = new System.Windows.Forms.TabPage();
            this.pay_priceLb = new System.Windows.Forms.Label();
            this.AdminTab = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.welcomeTab.SuspendLayout();
            this.takeOutTab.SuspendLayout();
            this.menuTab.SuspendLayout();
            this.cartTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1064, 681);
            this.tabControl.TabIndex = 0;
            // 
            // welcomeTab
            // 
            this.welcomeTab.Controls.Add(this.welcomeImgBtn);
            this.welcomeTab.Controls.Add(this.welcomeImgButton);
            this.welcomeTab.Location = new System.Drawing.Point(4, 22);
            this.welcomeTab.Name = "welcomeTab";
            this.welcomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.welcomeTab.Size = new System.Drawing.Size(1056, 655);
            this.welcomeTab.TabIndex = 0;
            this.welcomeTab.Text = "웰컴";
            this.welcomeTab.UseVisualStyleBackColor = true;
            // 
            // welcomeImgBtn
            // 
            this.welcomeImgBtn.Location = new System.Drawing.Point(498, 264);
            this.welcomeImgBtn.Name = "welcomeImgBtn";
            this.welcomeImgBtn.Size = new System.Drawing.Size(75, 23);
            this.welcomeImgBtn.TabIndex = 0;
            this.welcomeImgBtn.Text = "button";
            this.welcomeImgBtn.Visible = false;
            // 
            // welcomeImgButton
            // 
            this.welcomeImgButton.BackgroundImage = global::coffeeshop.Properties.Resources.americano;
            this.welcomeImgButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomeImgButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.welcomeImgButton.Location = new System.Drawing.Point(3, 3);
            this.welcomeImgButton.Name = "welcomeImgButton";
            this.welcomeImgButton.Size = new System.Drawing.Size(1050, 649);
            this.welcomeImgButton.TabIndex = 0;
            this.welcomeImgButton.UseVisualStyleBackColor = true;
            this.welcomeImgButton.Click += new System.EventHandler(this.welcomeImgBtn_Click);
            // 
            // takeOutTab
            // 
            this.takeOutTab.Controls.Add(this.toGoBtn);
            this.takeOutTab.Controls.Add(this.forHereBtn);
            this.takeOutTab.Location = new System.Drawing.Point(4, 22);
            this.takeOutTab.Name = "takeOutTab";
            this.takeOutTab.Padding = new System.Windows.Forms.Padding(3);
            this.takeOutTab.Size = new System.Drawing.Size(1056, 655);
            this.takeOutTab.TabIndex = 1;
            this.takeOutTab.Text = "테이크아웃/인";
            this.takeOutTab.UseVisualStyleBackColor = true;
            // 
            // toGoBtn
            // 
            this.toGoBtn.Location = new System.Drawing.Point(591, 80);
            this.toGoBtn.Name = "toGoBtn";
            this.toGoBtn.Size = new System.Drawing.Size(418, 401);
            this.toGoBtn.TabIndex = 1;
            this.toGoBtn.Text = "포장하기";
            this.toGoBtn.UseVisualStyleBackColor = true;
            this.toGoBtn.Click += new System.EventHandler(this.toGoBtn_Click);
            // 
            // forHereBtn
            // 
            this.forHereBtn.Location = new System.Drawing.Point(100, 80);
            this.forHereBtn.Name = "forHereBtn";
            this.forHereBtn.Size = new System.Drawing.Size(418, 401);
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
            this.menuTab.Controls.Add(this.orderListTb);
            this.menuTab.Controls.Add(this.vlaBtn);
            this.menuTab.Controls.Add(this.latBtn);
            this.menuTab.Controls.Add(this.ameBtn);
            this.menuTab.Location = new System.Drawing.Point(4, 22);
            this.menuTab.Name = "menuTab";
            this.menuTab.Size = new System.Drawing.Size(1056, 655);
            this.menuTab.TabIndex = 2;
            this.menuTab.Text = "메뉴";
            this.menuTab.UseVisualStyleBackColor = true;
            // 
            // menuListLb
            // 
            this.menuListLb.AutoSize = true;
            this.menuListLb.Location = new System.Drawing.Point(68, 403);
            this.menuListLb.Name = "menuListLb";
            this.menuListLb.Size = new System.Drawing.Size(38, 12);
            this.menuListLb.TabIndex = 5;
            this.menuListLb.Text = "label1";
            // 
            // menu_cart
            // 
            this.menu_cart.Font = new System.Drawing.Font("D2Coding", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menu_cart.Location = new System.Drawing.Point(902, 533);
            this.menu_cart.Name = "menu_cart";
            this.menu_cart.Size = new System.Drawing.Size(177, 73);
            this.menu_cart.TabIndex = 4;
            this.menu_cart.Text = "장바구니";
            this.menu_cart.UseVisualStyleBackColor = true;
            this.menu_cart.Click += new System.EventHandler(this.menu_cart_Click);
            // 
            // goToBegin
            // 
            this.goToBegin.Font = new System.Drawing.Font("D2Coding", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.goToBegin.Location = new System.Drawing.Point(902, 440);
            this.goToBegin.Name = "goToBegin";
            this.goToBegin.Size = new System.Drawing.Size(177, 73);
            this.goToBegin.TabIndex = 1;
            this.goToBegin.Text = "처음으로";
            this.goToBegin.UseVisualStyleBackColor = true;
            this.goToBegin.Click += new System.EventHandler(this.goToBegin_Click);
            // 
            // orderListTb
            // 
            this.orderListTb.Font = new System.Drawing.Font("D2Coding", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.orderListTb.Location = new System.Drawing.Point(60, 495);
            this.orderListTb.Multiline = true;
            this.orderListTb.Name = "orderListTb";
            this.orderListTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.orderListTb.Size = new System.Drawing.Size(800, 100);
            this.orderListTb.TabIndex = 3;
            // 
            // vlaBtn
            // 
            this.vlaBtn.Image = global::coffeeshop.Properties.Resources.vanilalatte;
            this.vlaBtn.Location = new System.Drawing.Point(846, 100);
            this.vlaBtn.Name = "vlaBtn";
            this.vlaBtn.Size = new System.Drawing.Size(276, 276);
            this.vlaBtn.TabIndex = 2;
            this.vlaBtn.Text = "button3";
            this.vlaBtn.UseVisualStyleBackColor = true;
            // 
            // latBtn
            // 
            this.latBtn.Image = global::coffeeshop.Properties.Resources.latte;
            this.latBtn.Location = new System.Drawing.Point(489, 100);
            this.latBtn.Name = "latBtn";
            this.latBtn.Size = new System.Drawing.Size(276, 276);
            this.latBtn.TabIndex = 1;
            this.latBtn.Text = "button2";
            this.latBtn.UseVisualStyleBackColor = true;
            this.latBtn.Click += new System.EventHandler(this.latBtn_Click);
            // 
            // ameBtn
            // 
            this.ameBtn.Image = global::coffeeshop.Properties.Resources.americano;
            this.ameBtn.Location = new System.Drawing.Point(100, 100);
            this.ameBtn.Name = "ameBtn";
            this.ameBtn.Size = new System.Drawing.Size(276, 276);
            this.ameBtn.TabIndex = 0;
            this.ameBtn.Text = "button1";
            this.ameBtn.UseVisualStyleBackColor = true;
            this.ameBtn.Click += new System.EventHandler(this.ameBtn_Click);
            // 
            // cartTab
            // 
            this.cartTab.Controls.Add(this.paymentBtn);
            this.cartTab.Controls.Add(this.numericUpDown1);
            this.cartTab.Controls.Add(this.textBox1);
            this.cartTab.Controls.Add(this.cart_orderlist);
            this.cartTab.Location = new System.Drawing.Point(4, 22);
            this.cartTab.Name = "cartTab";
            this.cartTab.Size = new System.Drawing.Size(1056, 655);
            this.cartTab.TabIndex = 3;
            this.cartTab.Text = "장바구니";
            this.cartTab.UseVisualStyleBackColor = true;
            // 
            // paymentBtn
            // 
            this.paymentBtn.Location = new System.Drawing.Point(800, 500);
            this.paymentBtn.Name = "paymentBtn";
            this.paymentBtn.Size = new System.Drawing.Size(75, 23);
            this.paymentBtn.TabIndex = 3;
            this.paymentBtn.Text = "결제하기";
            this.paymentBtn.UseVisualStyleBackColor = true;
            this.paymentBtn.Click += new System.EventHandler(this.paymentBtn_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("D2Coding", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numericUpDown1.Location = new System.Drawing.Point(431, 50);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 45);
            this.numericUpDown1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 50);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(391, 271);
            this.textBox1.TabIndex = 1;
            // 
            // cart_orderlist
            // 
            this.cart_orderlist.AutoSize = true;
            this.cart_orderlist.Location = new System.Drawing.Point(8, 8);
            this.cart_orderlist.Name = "cart_orderlist";
            this.cart_orderlist.Size = new System.Drawing.Size(53, 12);
            this.cart_orderlist.TabIndex = 0;
            this.cart_orderlist.Text = "주문내역";
            // 
            // payTab
            // 
            this.payTab.Controls.Add(this.pay_priceLb);
            this.payTab.Location = new System.Drawing.Point(4, 22);
            this.payTab.Name = "payTab";
            this.payTab.Size = new System.Drawing.Size(1056, 655);
            this.payTab.TabIndex = 4;
            this.payTab.Text = "결제하기";
            this.payTab.UseVisualStyleBackColor = true;
            // 
            // pay_priceLb
            // 
            this.pay_priceLb.AutoSize = true;
            this.pay_priceLb.Font = new System.Drawing.Font("D2Coding", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pay_priceLb.Location = new System.Drawing.Point(20, 250);
            this.pay_priceLb.Name = "pay_priceLb";
            this.pay_priceLb.Size = new System.Drawing.Size(113, 37);
            this.pay_priceLb.TabIndex = 0;
            this.pay_priceLb.Text = "label1";
            // 
            // AdminTab
            // 
            this.AdminTab.Location = new System.Drawing.Point(4, 22);
            this.AdminTab.Name = "AdminTab";
            this.AdminTab.Size = new System.Drawing.Size(1056, 655);
            this.AdminTab.TabIndex = 5;
            this.AdminTab.Text = "관리자모드";
            this.AdminTab.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "유동 커피숍";
            this.tabControl.ResumeLayout(false);
            this.welcomeTab.ResumeLayout(false);
            this.takeOutTab.ResumeLayout(false);
            this.menuTab.ResumeLayout(false);
            this.menuTab.PerformLayout();
            this.cartTab.ResumeLayout(false);
            this.cartTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.TextBox orderListTb;
        private System.Windows.Forms.Button goToBegin;
        private System.Windows.Forms.Button menu_cart;
        private System.Windows.Forms.Label cart_orderlist;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label menuListLb;
        private System.Windows.Forms.Label pay_priceLb;
        private System.Windows.Forms.Button paymentBtn;
    }
}

