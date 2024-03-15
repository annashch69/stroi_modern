namespace stroi_modern
{
    partial class oform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oform));
            label1 = new Label();
            full_name = new TextBox();
            adress_of_building = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cart_btn = new Button();
            login_lbl = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(113, 12);
            label1.Name = "label1";
            label1.Size = new Size(278, 35);
            label1.TabIndex = 11;
            label1.Text = "Оформление заказа";
            // 
            // full_name
            // 
            full_name.BackColor = Color.Linen;
            full_name.Location = new Point(14, 79);
            full_name.Margin = new Padding(3, 4, 3, 4);
            full_name.Name = "full_name";
            full_name.Size = new Size(463, 27);
            full_name.TabIndex = 12;
            // 
            // adress_of_building
            // 
            adress_of_building.BackColor = Color.Linen;
            adress_of_building.Location = new Point(14, 147);
            adress_of_building.Margin = new Padding(3, 4, 3, 4);
            adress_of_building.Name = "adress_of_building";
            adress_of_building.Size = new Size(463, 27);
            adress_of_building.TabIndex = 13;
            adress_of_building.TextChanged += adress_of_building_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 55);
            label2.Name = "label2";
            label2.Size = new Size(130, 17);
            label2.TabIndex = 14;
            label2.Text = "Ф.И.О. заказчика";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(14, 123);
            label3.Name = "label3";
            label3.Size = new Size(118, 17);
            label3.TabIndex = 15;
            label3.Text = "Адрес доставки";
            // 
            // cart_btn
            // 
            cart_btn.BackColor = Color.SandyBrown;
            cart_btn.Location = new Point(106, 197);
            cart_btn.Margin = new Padding(3, 4, 3, 4);
            cart_btn.Name = "cart_btn";
            cart_btn.Size = new Size(274, 45);
            cart_btn.TabIndex = 16;
            cart_btn.Text = "Оформить ";
            cart_btn.UseVisualStyleBackColor = false;
            cart_btn.Click += cart_btn_Click;
            // 
            // login_lbl
            // 
            login_lbl.AutoSize = true;
            login_lbl.Dock = DockStyle.Right;
            login_lbl.Location = new Point(688, 0);
            login_lbl.Name = "login_lbl";
            login_lbl.Size = new Size(50, 20);
            login_lbl.TabIndex = 19;
            login_lbl.Text = "логин";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(594, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // oform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(738, 266);
            Controls.Add(pictureBox1);
            Controls.Add(login_lbl);
            Controls.Add(cart_btn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(adress_of_building);
            Controls.Add(full_name);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "oform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "СтройМодерн";
            FormClosing += Order_form_FormClosing;
            Load += Order_form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox full_name;
        private TextBox adress_of_building;
        private Label label2;
        private Label label3;
        private Button cart_btn;
        private Label login_lbl;
        private PictureBox pictureBox1;
    }
}