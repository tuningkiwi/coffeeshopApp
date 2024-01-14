using System.Drawing;

namespace coffeeshop
{
    partial class menuSelected
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.HOT = new System.Windows.Forms.Button();
            this.COLD = new System.Windows.Forms.Button();
            this.LARGE = new System.Windows.Forms.Button();
            this.SMALL = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            this.cart_menuSelected = new System.Windows.Forms.Button();
            this.cancel_menuSelected = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(29, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 276);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("D2Coding ligature", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nameLabel.Location = new System.Drawing.Point(71, 60);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nameLabel.Size = new System.Drawing.Size(180, 41);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "nameLabel";
            // 
            // HOT
            // 
            this.HOT.BackColor = System.Drawing.Color.LightCoral;
            this.HOT.Location = new System.Drawing.Point(375, 145);
            this.HOT.Name = "HOT";
            this.HOT.Size = new System.Drawing.Size(103, 41);
            this.HOT.TabIndex = 2;
            this.HOT.Text = "HOT";
            this.HOT.UseVisualStyleBackColor = false;
            this.HOT.Click += new System.EventHandler(this.HOT_Click);
            // 
            // COLD
            // 
            this.COLD.BackColor = System.Drawing.Color.LightBlue;
            this.COLD.Location = new System.Drawing.Point(503, 145);
            this.COLD.Name = "COLD";
            this.COLD.Size = new System.Drawing.Size(103, 41);
            this.COLD.TabIndex = 3;
            this.COLD.Text = "COLD";
            this.COLD.UseVisualStyleBackColor = false;
            this.COLD.Click += new System.EventHandler(this.COLD_Click);
            // 
            // LARGE
            // 
            this.LARGE.BackColor = System.Drawing.Color.Gainsboro;
            this.LARGE.Location = new System.Drawing.Point(503, 215);
            this.LARGE.Name = "LARGE";
            this.LARGE.Size = new System.Drawing.Size(103, 41);
            this.LARGE.TabIndex = 5;
            this.LARGE.Text = "LARGE";
            this.LARGE.UseVisualStyleBackColor = false;
            this.LARGE.Click += new System.EventHandler(this.LARGE_Click);
            // 
            // SMALL
            // 
            this.SMALL.BackColor = System.Drawing.Color.Gainsboro;
            this.SMALL.Location = new System.Drawing.Point(375, 215);
            this.SMALL.Name = "SMALL";
            this.SMALL.Size = new System.Drawing.Size(103, 41);
            this.SMALL.TabIndex = 4;
            this.SMALL.Text = "SMALL";
            this.SMALL.UseVisualStyleBackColor = false;
            this.SMALL.Click += new System.EventHandler(this.SMALL_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Gainsboro;
            this.add.Font = new System.Drawing.Font("D2Coding", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.add.Location = new System.Drawing.Point(556, 289);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(50, 41);
            this.add.TabIndex = 7;
            this.add.Text = "+++";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // subtract
            // 
            this.subtract.BackColor = System.Drawing.Color.Gainsboro;
            this.subtract.Font = new System.Drawing.Font("D2Coding", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.subtract.Location = new System.Drawing.Point(375, 289);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(52, 41);
            this.subtract.TabIndex = 6;
            this.subtract.Text = "---";
            this.subtract.UseVisualStyleBackColor = false;
            this.subtract.Click += new System.EventHandler(this.subtract_Click);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("D2Coding", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.countLabel.Location = new System.Drawing.Point(475, 289);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(36, 41);
            this.countLabel.TabIndex = 8;
            this.countLabel.Text = "0";
            // 
            // cart_menuSelected
            // 
            this.cart_menuSelected.Location = new System.Drawing.Point(615, 381);
            this.cart_menuSelected.Name = "cart_menuSelected";
            this.cart_menuSelected.Size = new System.Drawing.Size(126, 23);
            this.cart_menuSelected.TabIndex = 9;
            this.cart_menuSelected.Text = "장바구니 담기";
            this.cart_menuSelected.UseVisualStyleBackColor = true;
            this.cart_menuSelected.Click += new System.EventHandler(this.cart_menuSelected_Click);
            // 
            // cancel_menuSelected
            // 
            this.cancel_menuSelected.Location = new System.Drawing.Point(464, 381);
            this.cancel_menuSelected.Name = "cancel_menuSelected";
            this.cancel_menuSelected.Size = new System.Drawing.Size(126, 23);
            this.cancel_menuSelected.TabIndex = 10;
            this.cancel_menuSelected.Text = "취소하기";
            this.cancel_menuSelected.UseVisualStyleBackColor = true;
            // 
            // menuSelected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancel_menuSelected);
            this.Controls.Add(this.cart_menuSelected);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.add);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.LARGE);
            this.Controls.Add(this.SMALL);
            this.Controls.Add(this.COLD);
            this.Controls.Add(this.HOT);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "menuSelected";
            this.Text = "메뉴세부사항";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button HOT;
        private System.Windows.Forms.Button COLD;
        private System.Windows.Forms.Button LARGE;
        private System.Windows.Forms.Button SMALL;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Button cart_menuSelected;
        private System.Windows.Forms.Button cancel_menuSelected;
    }
}