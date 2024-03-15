namespace stroi_modern
{
    partial class dobavakk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dobavakk));
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            pass_ = new TextBox();
            login_ = new TextBox();
            acc_create = new Button();
            back_btn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(118, 9);
            label1.Name = "label1";
            label1.Size = new Size(388, 35);
            label1.TabIndex = 10;
            label1.Text = "Добавление учетной записи\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(14, 133);
            label3.Name = "label3";
            label3.Size = new Size(76, 23);
            label3.TabIndex = 19;
            label3.Text = "Пароль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 65);
            label2.Name = "label2";
            label2.Size = new Size(68, 23);
            label2.TabIndex = 18;
            label2.Text = "Логин";
            // 
            // pass_
            // 
            pass_.BackColor = Color.Linen;
            pass_.Location = new Point(14, 157);
            pass_.Margin = new Padding(3, 4, 3, 4);
            pass_.Name = "pass_";
            pass_.Size = new Size(330, 27);
            pass_.TabIndex = 17;
            // 
            // login_
            // 
            login_.BackColor = Color.Linen;
            login_.Location = new Point(14, 89);
            login_.Margin = new Padding(3, 4, 3, 4);
            login_.Name = "login_";
            login_.Size = new Size(330, 27);
            login_.TabIndex = 16;
            // 
            // acc_create
            // 
            acc_create.BackColor = Color.SandyBrown;
            acc_create.Location = new Point(29, 192);
            acc_create.Margin = new Padding(3, 4, 3, 4);
            acc_create.Name = "acc_create";
            acc_create.Size = new Size(298, 38);
            acc_create.TabIndex = 20;
            acc_create.Text = "Применить";
            acc_create.UseVisualStyleBackColor = false;
            acc_create.Click += acc_create_Click;
            // 
            // back_btn
            // 
            back_btn.BackColor = Color.SandyBrown;
            back_btn.Location = new Point(419, 263);
            back_btn.Margin = new Padding(3, 4, 3, 4);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(210, 35);
            back_btn.TabIndex = 21;
            back_btn.Text = "Вернуться назад";
            back_btn.UseVisualStyleBackColor = false;
            back_btn.Click += back_btn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(509, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // dobavakk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(629, 311);
            Controls.Add(pictureBox1);
            Controls.Add(back_btn);
            Controls.Add(acc_create);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pass_);
            Controls.Add(login_);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "dobavakk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "СтройМодерн";
            FormClosing += Add_acc_form_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox pass_;
        private TextBox login_;
        private Button acc_create;
        private Button back_btn;
        private PictureBox pictureBox1;
    }
}