namespace stroi_modern
{
    partial class dobav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dobav));
            label1 = new Label();
            name_lbl = new Label();
            name_ = new TextBox();
            price_lbl = new Label();
            article_ = new TextBox();
            article_lbl = new Label();
            price_ = new TextBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            real_acc_create = new Button();
            back_btn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(272, 35);
            label1.TabIndex = 11;
            label1.Text = "Добавление товара";
            label1.Click += label1_Click;
            // 
            // name_lbl
            // 
            name_lbl.AutoSize = true;
            name_lbl.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            name_lbl.Location = new Point(14, 63);
            name_lbl.Name = "name_lbl";
            name_lbl.Size = new Size(124, 17);
            name_lbl.TabIndex = 20;
            name_lbl.Text = "Название товара";
            name_lbl.Click += name_lbl_Click;
            // 
            // name_
            // 
            name_.BackColor = Color.Linen;
            name_.Location = new Point(14, 87);
            name_.Margin = new Padding(3, 4, 3, 4);
            name_.Name = "name_";
            name_.Size = new Size(279, 27);
            name_.TabIndex = 19;
            name_.TextChanged += name__TextChanged;
            // 
            // price_lbl
            // 
            price_lbl.AutoSize = true;
            price_lbl.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            price_lbl.Location = new Point(14, 127);
            price_lbl.Name = "price_lbl";
            price_lbl.Size = new Size(68, 17);
            price_lbl.TabIndex = 22;
            price_lbl.Text = "Артикул";
            price_lbl.Click += price_lbl_Click;
            // 
            // article_
            // 
            article_.BackColor = Color.Linen;
            article_.Location = new Point(14, 151);
            article_.Margin = new Padding(3, 4, 3, 4);
            article_.MaxLength = 13;
            article_.Name = "article_";
            article_.Size = new Size(279, 27);
            article_.TabIndex = 21;
            article_.TextChanged += article__TextChanged;
            // 
            // article_lbl
            // 
            article_lbl.AutoSize = true;
            article_lbl.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            article_lbl.Location = new Point(14, 193);
            article_lbl.Name = "article_lbl";
            article_lbl.Size = new Size(44, 17);
            article_lbl.TabIndex = 24;
            article_lbl.Text = "Цена";
            article_lbl.Click += article_lbl_Click;
            // 
            // price_
            // 
            price_.BackColor = Color.Linen;
            price_.Location = new Point(14, 217);
            price_.Margin = new Padding(3, 4, 3, 4);
            price_.Name = "price_";
            price_.Size = new Size(279, 27);
            price_.TabIndex = 23;
            price_.TextChanged += price__TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Linen;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(15, 269);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(279, 28);
            comboBox1.TabIndex = 25;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 248);
            label2.Name = "label2";
            label2.Size = new Size(86, 17);
            label2.TabIndex = 26;
            label2.Text = "Тип товара";
            label2.Click += label2_Click;
            // 
            // real_acc_create
            // 
            real_acc_create.BackColor = Color.SandyBrown;
            real_acc_create.Location = new Point(14, 361);
            real_acc_create.Margin = new Padding(3, 4, 3, 4);
            real_acc_create.Name = "real_acc_create";
            real_acc_create.Size = new Size(280, 68);
            real_acc_create.TabIndex = 29;
            real_acc_create.Text = "Добавить";
            real_acc_create.UseVisualStyleBackColor = false;
            real_acc_create.Click += real_acc_create_Click;
            // 
            // back_btn
            // 
            back_btn.BackColor = Color.SandyBrown;
            back_btn.Location = new Point(387, 401);
            back_btn.Margin = new Padding(3, 4, 3, 4);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(176, 39);
            back_btn.TabIndex = 30;
            back_btn.Text = "Назад";
            back_btn.UseVisualStyleBackColor = false;
            back_btn.Click += back_btn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(441, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // dobav
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(575, 453);
            Controls.Add(pictureBox1);
            Controls.Add(back_btn);
            Controls.Add(real_acc_create);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(article_lbl);
            Controls.Add(price_);
            Controls.Add(price_lbl);
            Controls.Add(article_);
            Controls.Add(name_lbl);
            Controls.Add(name_);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "dobav";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "СтройМодерн";
            FormClosing += Goods_add_FormClosing;
            Load += Goods_add_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label name_lbl;
        private TextBox name_;
        private Label price_lbl;
        private TextBox article_;
        private Label article_lbl;
        private TextBox price_;
        private ComboBox comboBox1;
        private Label label2;
        private Button real_acc_create;
        private Button back_btn;
        private PictureBox pictureBox1;
    }
}