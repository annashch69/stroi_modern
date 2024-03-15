namespace stroi_modern
{
    partial class obnovtov
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(obnovtov));
            back_btn = new Button();
            real_acc_create = new Button();
            label2 = new Label();
            comboBox1 = new ComboBox();
            article_lbl = new Label();
            price_ = new TextBox();
            price_lbl = new Label();
            article_ = new TextBox();
            name_lbl = new Label();
            name_ = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // back_btn
            // 
            back_btn.BackColor = Color.SandyBrown;
            back_btn.Location = new Point(346, 395);
            back_btn.Margin = new Padding(3, 4, 3, 4);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(172, 42);
            back_btn.TabIndex = 41;
            back_btn.Text = "Назад";
            back_btn.UseVisualStyleBackColor = false;
            back_btn.Click += back_btn_Click;
            // 
            // real_acc_create
            // 
            real_acc_create.BackColor = Color.SandyBrown;
            real_acc_create.Location = new Point(14, 328);
            real_acc_create.Margin = new Padding(3, 4, 3, 4);
            real_acc_create.Name = "real_acc_create";
            real_acc_create.Size = new Size(280, 68);
            real_acc_create.TabIndex = 40;
            real_acc_create.Text = "Применить";
            real_acc_create.UseVisualStyleBackColor = false;
            real_acc_create.Click += real_acc_create_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 252);
            label2.Name = "label2";
            label2.Size = new Size(86, 17);
            label2.TabIndex = 39;
            label2.Text = "Тип товара";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Linen;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(14, 276);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(279, 28);
            comboBox1.TabIndex = 38;
            // 
            // article_lbl
            // 
            article_lbl.AutoSize = true;
            article_lbl.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            article_lbl.Location = new Point(14, 191);
            article_lbl.Name = "article_lbl";
            article_lbl.Size = new Size(44, 17);
            article_lbl.TabIndex = 37;
            article_lbl.Text = "Цена";
            // 
            // price_
            // 
            price_.BackColor = Color.Linen;
            price_.Location = new Point(14, 215);
            price_.Margin = new Padding(3, 4, 3, 4);
            price_.Name = "price_";
            price_.Size = new Size(279, 27);
            price_.TabIndex = 36;
            // 
            // price_lbl
            // 
            price_lbl.AutoSize = true;
            price_lbl.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            price_lbl.Location = new Point(14, 124);
            price_lbl.Name = "price_lbl";
            price_lbl.Size = new Size(68, 17);
            price_lbl.TabIndex = 35;
            price_lbl.Text = "Артикул";
            // 
            // article_
            // 
            article_.BackColor = Color.Linen;
            article_.Location = new Point(14, 148);
            article_.Margin = new Padding(3, 4, 3, 4);
            article_.MaxLength = 13;
            article_.Name = "article_";
            article_.Size = new Size(279, 27);
            article_.TabIndex = 34;
            // 
            // name_lbl
            // 
            name_lbl.AutoSize = true;
            name_lbl.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            name_lbl.Location = new Point(14, 60);
            name_lbl.Name = "name_lbl";
            name_lbl.Size = new Size(74, 17);
            name_lbl.TabIndex = 33;
            name_lbl.Text = "Название";
            // 
            // name_
            // 
            name_.BackColor = Color.Linen;
            name_.Location = new Point(14, 84);
            name_.Margin = new Padding(3, 4, 3, 4);
            name_.Name = "name_";
            name_.Size = new Size(279, 27);
            name_.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 9);
            label1.Name = "label1";
            label1.Size = new Size(406, 35);
            label1.TabIndex = 31;
            label1.Text = "Обновление данных о товаре";
            // 
            // obnovtov
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(530, 450);
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
            Name = "obnovtov";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "СтройМодерн";
            FormClosing += Upd_goods_FormClosing;
            Load += Upd_goods_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back_btn;
        private Button real_acc_create;
        private Label label2;
        private ComboBox comboBox1;
        private Label article_lbl;
        private TextBox price_;
        private Label price_lbl;
        private TextBox article_;
        private Label name_lbl;
        private TextBox name_;
        private Label label1;
    }
}