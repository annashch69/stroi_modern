namespace stroi_modern
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            admin_btn = new Button();
            goods_btn = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // admin_btn
            // 
            admin_btn.BackColor = Color.SandyBrown;
            admin_btn.Location = new Point(30, 82);
            admin_btn.Margin = new Padding(3, 4, 3, 4);
            admin_btn.Name = "admin_btn";
            admin_btn.Size = new Size(418, 45);
            admin_btn.TabIndex = 9;
            admin_btn.Text = "Добавление новой учетной записи";
            admin_btn.UseVisualStyleBackColor = false;
            admin_btn.Click += cart_btn_Click;
            // 
            // goods_btn
            // 
            goods_btn.BackColor = Color.SandyBrown;
            goods_btn.Location = new Point(30, 159);
            goods_btn.Margin = new Padding(3, 4, 3, 4);
            goods_btn.Name = "goods_btn";
            goods_btn.Size = new Size(418, 45);
            goods_btn.TabIndex = 11;
            goods_btn.Text = "Список товаров";
            goods_btn.UseVisualStyleBackColor = false;
            goods_btn.Click += goods_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(88, 9);
            label1.Name = "label1";
            label1.Size = new Size(293, 35);
            label1.TabIndex = 12;
            label1.Text = "Администрирование";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(470, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(499, 222);
            button1.Name = "button1";
            button1.Size = new Size(135, 60);
            button1.TabIndex = 14;
            button1.Text = "Рассылка ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(644, 294);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(goods_btn);
            Controls.Add(admin_btn);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "СтройМодерн";
            FormClosing += Admin_form_FormClosing;
            Load += Admin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button admin_btn;
        private Button goods_btn;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
    }
}