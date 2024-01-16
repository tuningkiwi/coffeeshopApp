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
            this.components = new System.ComponentModel.Container();
            this.orderTabCtrl = new System.Windows.Forms.TabControl();
            this.welcomeTab = new System.Windows.Forms.TabPage();
            this.welcomeImgButton = new System.Windows.Forms.Button();
            this.takeOutTab = new System.Windows.Forms.TabPage();
            this.toGoBtn = new System.Windows.Forms.Button();
            this.forHereBtn = new System.Windows.Forms.Button();
            this.menuTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.latteLb = new System.Windows.Forms.Label();
            this.ameLb = new System.Windows.Forms.Label();
            this.menuListLb = new System.Windows.Forms.Label();
            this.menu_cart = new System.Windows.Forms.Button();
            this.goToBegin = new System.Windows.Forms.Button();
            this.blueyogurtBtn = new System.Windows.Forms.Button();
            this.royalBtn = new System.Windows.Forms.Button();
            this.strawberrylatteBtn = new System.Windows.Forms.Button();
            this.vlaBtn = new System.Windows.Forms.Button();
            this.latBtn = new System.Windows.Forms.Button();
            this.ameBtn = new System.Windows.Forms.Button();
            this.cartTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cart_cancelBtn = new System.Windows.Forms.Button();
            this.paymentBtn = new System.Windows.Forms.Button();
            this.totalCountLb = new System.Windows.Forms.Label();
            this.payTab = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.payCompleted = new System.Windows.Forms.Button();
            this.pay_CancelBtn = new System.Windows.Forms.Button();
            this.pay_priceLb = new System.Windows.Forms.Label();
            this.orderCompletedTab = new System.Windows.Forms.TabPage();
            this.orderNumberLb2 = new System.Windows.Forms.Label();
            this.completed_gotoStartBtn = new System.Windows.Forms.Button();
            this.orderNumberLb1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AdminTab = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.idLB = new System.Windows.Forms.Label();
            this.pwBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.adminLogin = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.orderTabCtrl.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.orderCompletedTab.SuspendLayout();
            this.AdminTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderTabCtrl
            // 
            this.orderTabCtrl.Controls.Add(this.welcomeTab);
            this.orderTabCtrl.Controls.Add(this.takeOutTab);
            this.orderTabCtrl.Controls.Add(this.menuTab);
            this.orderTabCtrl.Controls.Add(this.cartTab);
            this.orderTabCtrl.Controls.Add(this.payTab);
            this.orderTabCtrl.Controls.Add(this.orderCompletedTab);
            this.orderTabCtrl.Controls.Add(this.AdminTab);
            this.orderTabCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderTabCtrl.Location = new System.Drawing.Point(0, 0);
            this.orderTabCtrl.Margin = new System.Windows.Forms.Padding(4);
            this.orderTabCtrl.Name = "orderTabCtrl";
            this.orderTabCtrl.SelectedIndex = 0;
            this.orderTabCtrl.Size = new System.Drawing.Size(1899, 1024);
            this.orderTabCtrl.TabIndex = 0;
            this.orderTabCtrl.TabStop = false;
            // 
            // welcomeTab
            // 
            this.welcomeTab.Controls.Add(this.welcomeImgButton);
            this.welcomeTab.Location = new System.Drawing.Point(4, 28);
            this.welcomeTab.Margin = new System.Windows.Forms.Padding(4);
            this.welcomeTab.Name = "welcomeTab";
            this.welcomeTab.Padding = new System.Windows.Forms.Padding(4);
            this.welcomeTab.Size = new System.Drawing.Size(1891, 992);
            this.welcomeTab.TabIndex = 0;
            this.welcomeTab.Text = "웰컴";
            this.welcomeTab.UseVisualStyleBackColor = true;
            // 
            // welcomeImgButton
            // 
            this.welcomeImgButton.AutoSize = true;
            this.welcomeImgButton.BackgroundImage = global::coffeeshop.Properties.Resources.americano;
            this.welcomeImgButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomeImgButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.welcomeImgButton.Location = new System.Drawing.Point(4, 4);
            this.welcomeImgButton.Margin = new System.Windows.Forms.Padding(4);
            this.welcomeImgButton.Name = "welcomeImgButton";
            this.welcomeImgButton.Size = new System.Drawing.Size(1883, 984);
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
            this.takeOutTab.Size = new System.Drawing.Size(1891, 992);
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
            this.menuTab.Controls.Add(this.label4);
            this.menuTab.Controls.Add(this.label3);
            this.menuTab.Controls.Add(this.label2);
            this.menuTab.Controls.Add(this.label1);
            this.menuTab.Controls.Add(this.latteLb);
            this.menuTab.Controls.Add(this.ameLb);
            this.menuTab.Controls.Add(this.menuListLb);
            this.menuTab.Controls.Add(this.menu_cart);
            this.menuTab.Controls.Add(this.goToBegin);
            this.menuTab.Controls.Add(this.blueyogurtBtn);
            this.menuTab.Controls.Add(this.royalBtn);
            this.menuTab.Controls.Add(this.strawberrylatteBtn);
            this.menuTab.Controls.Add(this.vlaBtn);
            this.menuTab.Controls.Add(this.latBtn);
            this.menuTab.Controls.Add(this.ameBtn);
            this.menuTab.Location = new System.Drawing.Point(4, 28);
            this.menuTab.Margin = new System.Windows.Forms.Padding(4);
            this.menuTab.Name = "menuTab";
            this.menuTab.Size = new System.Drawing.Size(1891, 992);
            this.menuTab.TabIndex = 2;
            this.menuTab.Text = "메뉴";
            this.menuTab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gulim", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(1530, 504);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "블루베리요거트";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gulim", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(1253, 504);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "스트로베리라떼";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gulim", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(1006, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "로얄밀크티";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(729, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "바닐라라떼";
            // 
            // latteLb
            // 
            this.latteLb.AutoSize = true;
            this.latteLb.Font = new System.Drawing.Font("Gulim", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.latteLb.Location = new System.Drawing.Point(449, 504);
            this.latteLb.Name = "latteLb";
            this.latteLb.Size = new System.Drawing.Size(124, 28);
            this.latteLb.TabIndex = 10;
            this.latteLb.Text = "카페라떼";
            // 
            // ameLb
            // 
            this.ameLb.AutoSize = true;
            this.ameLb.Font = new System.Drawing.Font("Gulim", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ameLb.Location = new System.Drawing.Point(166, 504);
            this.ameLb.Name = "ameLb";
            this.ameLb.Size = new System.Drawing.Size(152, 28);
            this.ameLb.TabIndex = 9;
            this.ameLb.Text = "아메리카노";
            // 
            // menuListLb
            // 
            this.menuListLb.AutoSize = true;
            this.menuListLb.Font = new System.Drawing.Font("D2Coding", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuListLb.Location = new System.Drawing.Point(164, 626);
            this.menuListLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.menuListLb.Name = "menuListLb";
            this.menuListLb.Size = new System.Drawing.Size(161, 37);
            this.menuListLb.TabIndex = 5;
            this.menuListLb.Text = "주문 내역";
            // 
            // menu_cart
            // 
            this.menu_cart.BackColor = System.Drawing.Color.SeaShell;
            this.menu_cart.Font = new System.Drawing.Font("D2Coding", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menu_cart.Location = new System.Drawing.Point(1503, 795);
            this.menu_cart.Margin = new System.Windows.Forms.Padding(4);
            this.menu_cart.Name = "menu_cart";
            this.menu_cart.Size = new System.Drawing.Size(253, 110);
            this.menu_cart.TabIndex = 4;
            this.menu_cart.Text = "장바구니";
            this.menu_cart.UseVisualStyleBackColor = false;
            this.menu_cart.Click += new System.EventHandler(this.menu_cart_Click);
            // 
            // goToBegin
            // 
            this.goToBegin.BackColor = System.Drawing.Color.SeaShell;
            this.goToBegin.Font = new System.Drawing.Font("D2Coding", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.goToBegin.Location = new System.Drawing.Point(1503, 656);
            this.goToBegin.Margin = new System.Windows.Forms.Padding(4);
            this.goToBegin.Name = "goToBegin";
            this.goToBegin.Size = new System.Drawing.Size(253, 110);
            this.goToBegin.TabIndex = 1;
            this.goToBegin.Text = "처음으로";
            this.goToBegin.UseVisualStyleBackColor = false;
            this.goToBegin.Click += new System.EventHandler(this.goToBegin_Click);
            // 
            // blueyogurtBtn
            // 
            this.blueyogurtBtn.Font = new System.Drawing.Font("Gulim", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.blueyogurtBtn.Image = global::coffeeshop.Properties.Resources.bluberryyogurt;
            this.blueyogurtBtn.Location = new System.Drawing.Point(1494, 100);
            this.blueyogurtBtn.Margin = new System.Windows.Forms.Padding(4);
            this.blueyogurtBtn.Name = "blueyogurtBtn";
            this.blueyogurtBtn.Size = new System.Drawing.Size(276, 400);
            this.blueyogurtBtn.TabIndex = 8;
            this.blueyogurtBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.blueyogurtBtn.UseVisualStyleBackColor = true;
            this.blueyogurtBtn.Click += new System.EventHandler(this.blueyogurtBtn_Click);
            // 
            // royalBtn
            // 
            this.royalBtn.Font = new System.Drawing.Font("Gulim", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.royalBtn.Image = global::coffeeshop.Properties.Resources.roaylmilktea;
            this.royalBtn.Location = new System.Drawing.Point(939, 100);
            this.royalBtn.Margin = new System.Windows.Forms.Padding(4);
            this.royalBtn.Name = "royalBtn";
            this.royalBtn.Size = new System.Drawing.Size(276, 400);
            this.royalBtn.TabIndex = 7;
            this.royalBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.royalBtn.UseVisualStyleBackColor = true;
            this.royalBtn.Click += new System.EventHandler(this.royalBtn_Click);
            // 
            // strawberrylatteBtn
            // 
            this.strawberrylatteBtn.Font = new System.Drawing.Font("Gulim", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.strawberrylatteBtn.Image = global::coffeeshop.Properties.Resources.strawberrylatte;
            this.strawberrylatteBtn.Location = new System.Drawing.Point(1216, 100);
            this.strawberrylatteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.strawberrylatteBtn.Name = "strawberrylatteBtn";
            this.strawberrylatteBtn.Size = new System.Drawing.Size(276, 400);
            this.strawberrylatteBtn.TabIndex = 6;
            this.strawberrylatteBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.strawberrylatteBtn.UseVisualStyleBackColor = true;
            this.strawberrylatteBtn.Click += new System.EventHandler(this.strawberrylatteBtn_Click);
            // 
            // vlaBtn
            // 
            this.vlaBtn.Font = new System.Drawing.Font("Gulim", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.vlaBtn.Image = global::coffeeshop.Properties.Resources.vanilalatte;
            this.vlaBtn.Location = new System.Drawing.Point(660, 100);
            this.vlaBtn.Margin = new System.Windows.Forms.Padding(4);
            this.vlaBtn.Name = "vlaBtn";
            this.vlaBtn.Size = new System.Drawing.Size(276, 400);
            this.vlaBtn.TabIndex = 2;
            this.vlaBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.vlaBtn.UseVisualStyleBackColor = true;
            this.vlaBtn.Click += new System.EventHandler(this.vlaBtn_Click);
            // 
            // latBtn
            // 
            this.latBtn.Font = new System.Drawing.Font("Gulim", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.latBtn.Image = global::coffeeshop.Properties.Resources.latte;
            this.latBtn.Location = new System.Drawing.Point(381, 100);
            this.latBtn.Margin = new System.Windows.Forms.Padding(4);
            this.latBtn.Name = "latBtn";
            this.latBtn.Size = new System.Drawing.Size(276, 400);
            this.latBtn.TabIndex = 1;
            this.latBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.latBtn.UseVisualStyleBackColor = true;
            this.latBtn.Click += new System.EventHandler(this.latBtn_Click);
            // 
            // ameBtn
            // 
            this.ameBtn.Font = new System.Drawing.Font("Gulim", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ameBtn.Image = global::coffeeshop.Properties.Resources.americano;
            this.ameBtn.Location = new System.Drawing.Point(104, 100);
            this.ameBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ameBtn.Name = "ameBtn";
            this.ameBtn.Size = new System.Drawing.Size(276, 400);
            this.ameBtn.TabIndex = 0;
            this.ameBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ameBtn.UseVisualStyleBackColor = true;
            this.ameBtn.Click += new System.EventHandler(this.ameBtn_Click);
            // 
            // cartTab
            // 
            this.cartTab.Controls.Add(this.splitContainer1);
            this.cartTab.Location = new System.Drawing.Point(4, 28);
            this.cartTab.Margin = new System.Windows.Forms.Padding(4);
            this.cartTab.Name = "cartTab";
            this.cartTab.Size = new System.Drawing.Size(1891, 992);
            this.cartTab.TabIndex = 3;
            this.cartTab.Text = "장바구니";
            this.cartTab.UseVisualStyleBackColor = true;
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
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.cart_cancelBtn);
            this.splitContainer1.Panel2.Controls.Add(this.paymentBtn);
            this.splitContainer1.Panel2.Controls.Add(this.totalCountLb);
            this.splitContainer1.Panel2MinSize = 200;
            this.splitContainer1.Size = new System.Drawing.Size(1891, 992);
            this.splitContainer1.SplitterDistance = 599;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1891, 599);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "label6";
            // 
            // cart_cancelBtn
            // 
            this.cart_cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cart_cancelBtn.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cart_cancelBtn.Location = new System.Drawing.Point(1490, 132);
            this.cart_cancelBtn.Name = "cart_cancelBtn";
            this.cart_cancelBtn.Size = new System.Drawing.Size(283, 90);
            this.cart_cancelBtn.TabIndex = 3;
            this.cart_cancelBtn.Text = "취소하기";
            this.cart_cancelBtn.UseVisualStyleBackColor = true;
            this.cart_cancelBtn.Click += new System.EventHandler(this.cart_cancelBtn_Click);
            // 
            // paymentBtn
            // 
            this.paymentBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.paymentBtn.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.paymentBtn.Location = new System.Drawing.Point(1490, 16);
            this.paymentBtn.Name = "paymentBtn";
            this.paymentBtn.Size = new System.Drawing.Size(283, 90);
            this.paymentBtn.TabIndex = 2;
            this.paymentBtn.Text = "결제하기";
            this.paymentBtn.UseVisualStyleBackColor = true;
            this.paymentBtn.Click += new System.EventHandler(this.paymentBtn_Click);
            // 
            // totalCountLb
            // 
            this.totalCountLb.AutoSize = true;
            this.totalCountLb.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.totalCountLb.Location = new System.Drawing.Point(1083, 104);
            this.totalCountLb.Name = "totalCountLb";
            this.totalCountLb.Size = new System.Drawing.Size(336, 36);
            this.totalCountLb.TabIndex = 1;
            this.totalCountLb.Text = "총     0개/총     0원";
            // 
            // payTab
            // 
            this.payTab.Controls.Add(this.pictureBox1);
            this.payTab.Controls.Add(this.payCompleted);
            this.payTab.Controls.Add(this.pay_CancelBtn);
            this.payTab.Controls.Add(this.pay_priceLb);
            this.payTab.Location = new System.Drawing.Point(4, 28);
            this.payTab.Margin = new System.Windows.Forms.Padding(4);
            this.payTab.Name = "payTab";
            this.payTab.Size = new System.Drawing.Size(1891, 992);
            this.payTab.TabIndex = 4;
            this.payTab.Text = "결제하기";
            this.payTab.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(84, 162);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(767, 730);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // payCompleted
            // 
            this.payCompleted.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.payCompleted.Location = new System.Drawing.Point(1280, 700);
            this.payCompleted.Name = "payCompleted";
            this.payCompleted.Size = new System.Drawing.Size(299, 92);
            this.payCompleted.TabIndex = 2;
            this.payCompleted.Text = "송금(결제)완료";
            this.payCompleted.UseVisualStyleBackColor = true;
            this.payCompleted.Click += new System.EventHandler(this.payCompleted_Click);
            // 
            // pay_CancelBtn
            // 
            this.pay_CancelBtn.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pay_CancelBtn.Location = new System.Drawing.Point(930, 700);
            this.pay_CancelBtn.Name = "pay_CancelBtn";
            this.pay_CancelBtn.Size = new System.Drawing.Size(299, 92);
            this.pay_CancelBtn.TabIndex = 1;
            this.pay_CancelBtn.Text = "취소하기";
            this.pay_CancelBtn.UseVisualStyleBackColor = true;
            this.pay_CancelBtn.Click += new System.EventHandler(this.pay_CancelBtn_Click);
            // 
            // pay_priceLb
            // 
            this.pay_priceLb.AutoSize = true;
            this.pay_priceLb.Font = new System.Drawing.Font("D2Coding", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pay_priceLb.Location = new System.Drawing.Point(1074, 502);
            this.pay_priceLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pay_priceLb.Name = "pay_priceLb";
            this.pay_priceLb.Size = new System.Drawing.Size(264, 55);
            this.pay_priceLb.TabIndex = 0;
            this.pay_priceLb.Text = "총액 표시 ";
            // 
            // orderCompletedTab
            // 
            this.orderCompletedTab.Controls.Add(this.orderNumberLb2);
            this.orderCompletedTab.Controls.Add(this.completed_gotoStartBtn);
            this.orderCompletedTab.Controls.Add(this.orderNumberLb1);
            this.orderCompletedTab.Controls.Add(this.button1);
            this.orderCompletedTab.Location = new System.Drawing.Point(4, 28);
            this.orderCompletedTab.Margin = new System.Windows.Forms.Padding(4);
            this.orderCompletedTab.Name = "orderCompletedTab";
            this.orderCompletedTab.Padding = new System.Windows.Forms.Padding(4);
            this.orderCompletedTab.Size = new System.Drawing.Size(1891, 992);
            this.orderCompletedTab.TabIndex = 6;
            this.orderCompletedTab.Text = "주문완료";
            this.orderCompletedTab.UseVisualStyleBackColor = true;
            // 
            // orderNumberLb2
            // 
            this.orderNumberLb2.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.orderNumberLb2.Location = new System.Drawing.Point(621, 122);
            this.orderNumberLb2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderNumberLb2.Name = "orderNumberLb2";
            this.orderNumberLb2.Size = new System.Drawing.Size(429, 75);
            this.orderNumberLb2.TabIndex = 3;
            this.orderNumberLb2.Text = ".";
            this.orderNumberLb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // completed_gotoStartBtn
            // 
            this.completed_gotoStartBtn.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.completed_gotoStartBtn.Location = new System.Drawing.Point(743, 729);
            this.completed_gotoStartBtn.Margin = new System.Windows.Forms.Padding(4);
            this.completed_gotoStartBtn.Name = "completed_gotoStartBtn";
            this.completed_gotoStartBtn.Size = new System.Drawing.Size(214, 92);
            this.completed_gotoStartBtn.TabIndex = 2;
            this.completed_gotoStartBtn.Text = "처음으로";
            this.completed_gotoStartBtn.UseVisualStyleBackColor = true;
            this.completed_gotoStartBtn.Click += new System.EventHandler(this.completed_gotoStartBtn_Click);
            // 
            // orderNumberLb1
            // 
            this.orderNumberLb1.AutoSize = true;
            this.orderNumberLb1.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.orderNumberLb1.Location = new System.Drawing.Point(721, 50);
            this.orderNumberLb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderNumberLb1.Name = "orderNumberLb1";
            this.orderNumberLb1.Size = new System.Drawing.Size(231, 36);
            this.orderNumberLb1.TabIndex = 0;
            this.orderNumberLb1.Text = "주문대기번호";
            // 
            // button1
            // 
            this.button1.Image = global::coffeeshop.Properties.Resources.receipt;
            this.button1.Location = new System.Drawing.Point(597, 214);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(497, 506);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AdminTab
            // 
            this.AdminTab.Controls.Add(this.label7);
            this.AdminTab.Controls.Add(this.idLB);
            this.AdminTab.Controls.Add(this.pwBox);
            this.AdminTab.Controls.Add(this.idBox);
            this.AdminTab.Controls.Add(this.adminLogin);
            this.AdminTab.Location = new System.Drawing.Point(4, 28);
            this.AdminTab.Margin = new System.Windows.Forms.Padding(4);
            this.AdminTab.Name = "AdminTab";
            this.AdminTab.Size = new System.Drawing.Size(1891, 992);
            this.AdminTab.TabIndex = 5;
            this.AdminTab.Text = "관리자모드";
            this.AdminTab.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gulim", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(357, 388);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(361, 60);
            this.label7.TabIndex = 4;
            this.label7.Text = "PASSWORD";
            // 
            // idLB
            // 
            this.idLB.AutoSize = true;
            this.idLB.Font = new System.Drawing.Font("Gulim", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.idLB.Location = new System.Drawing.Point(620, 276);
            this.idLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLB.Name = "idLB";
            this.idLB.Size = new System.Drawing.Size(84, 60);
            this.idLB.TabIndex = 3;
            this.idLB.Text = "ID";
            // 
            // pwBox
            // 
            this.pwBox.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pwBox.Location = new System.Drawing.Point(749, 388);
            this.pwBox.Margin = new System.Windows.Forms.Padding(4);
            this.pwBox.Name = "pwBox";
            this.pwBox.Size = new System.Drawing.Size(390, 49);
            this.pwBox.TabIndex = 2;
            // 
            // idBox
            // 
            this.idBox.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.idBox.Location = new System.Drawing.Point(749, 276);
            this.idBox.Margin = new System.Windows.Forms.Padding(4);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(390, 49);
            this.idBox.TabIndex = 1;
            // 
            // adminLogin
            // 
            this.adminLogin.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.adminLogin.Location = new System.Drawing.Point(899, 514);
            this.adminLogin.Margin = new System.Windows.Forms.Padding(4);
            this.adminLogin.Name = "adminLogin";
            this.adminLogin.Size = new System.Drawing.Size(241, 72);
            this.adminLogin.TabIndex = 0;
            this.adminLogin.Text = "로그인";
            this.adminLogin.UseVisualStyleBackColor = true;
            this.adminLogin.Click += new System.EventHandler(this.adminLogin_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1899, 1024);
            this.Controls.Add(this.orderTabCtrl);
            this.Location = new System.Drawing.Point(10, 10);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "유동 커피숍";
            this.orderTabCtrl.ResumeLayout(false);
            this.welcomeTab.ResumeLayout(false);
            this.welcomeTab.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.orderCompletedTab.ResumeLayout(false);
            this.orderCompletedTab.PerformLayout();
            this.AdminTab.ResumeLayout(false);
            this.AdminTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl orderTabCtrl;
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
        private System.Windows.Forms.Button goToBegin;
        private System.Windows.Forms.Button menu_cart;
        private System.Windows.Forms.Label menuListLb;
        private System.Windows.Forms.Label pay_priceLb;
        private System.Windows.Forms.Button royalBtn;
        private System.Windows.Forms.Button strawberrylatteBtn;
        private System.Windows.Forms.Button blueyogurtBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label latteLb;
        private System.Windows.Forms.Label ameLb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cart_cancelBtn;
        private System.Windows.Forms.Button paymentBtn;
        private System.Windows.Forms.Label totalCountLb;
        private System.Windows.Forms.Button payCompleted;
        private System.Windows.Forms.Button pay_CancelBtn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button adminLogin;
        private System.Windows.Forms.TabPage orderCompletedTab;
        private System.Windows.Forms.Label orderNumberLb1;
        private System.Windows.Forms.Button completed_gotoStartBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label orderNumberLb2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox pwBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label idLB;
    }
}

