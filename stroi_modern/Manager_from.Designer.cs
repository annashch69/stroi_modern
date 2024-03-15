namespace stroi_modern
{
    partial class Manager_from
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager_from));
            panel1 = new Panel();
            price1 = new Label();
            prod_name1 = new Label();
            article1 = new Label();
            pic1 = new PictureBox();
            prev_page = new Button();
            next_page = new Button();
            search = new TextBox();
            sort = new ComboBox();
            filter = new ComboBox();
            login_lbl = new Label();
            panel2 = new Panel();
            price2 = new Label();
            prod_name2 = new Label();
            article2 = new Label();
            pic2 = new PictureBox();
            panel3 = new Panel();
            price3 = new Label();
            prod_name3 = new Label();
            article3 = new Label();
            pic3 = new PictureBox();
            panel4 = new Panel();
            price4 = new Label();
            prod_name4 = new Label();
            article4 = new Label();
            pic4 = new PictureBox();
            panel5 = new Panel();
            price5 = new Label();
            prod_name5 = new Label();
            article5 = new Label();
            pic5 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            распечататьШтрихкодToolStripMenuItem = new ToolStripMenuItem();
            cart_btn = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic5).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(price1);
            panel1.Controls.Add(prod_name1);
            panel1.Controls.Add(article1);
            panel1.Controls.Add(pic1);
            panel1.Location = new Point(57, 94);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1110, 115);
            panel1.TabIndex = 0;
            // 
            // price1
            // 
            price1.AutoSize = true;
            price1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            price1.Location = new Point(941, 39);
            price1.Name = "price1";
            price1.Size = new Size(59, 28);
            price1.TabIndex = 3;
            price1.Text = "Цена";
            // 
            // prod_name1
            // 
            prod_name1.AutoSize = true;
            prod_name1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prod_name1.Location = new Point(585, 39);
            prod_name1.Name = "prod_name1";
            prod_name1.Size = new Size(241, 28);
            prod_name1.TabIndex = 2;
            prod_name1.Text = "Наименование продукта";
            // 
            // article1
            // 
            article1.AutoSize = true;
            article1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            article1.Location = new Point(253, 39);
            article1.Name = "article1";
            article1.Size = new Size(88, 28);
            article1.TabIndex = 1;
            article1.Text = "Артикул";
            // 
            // pic1
            // 
            pic1.Location = new Point(3, 4);
            pic1.Margin = new Padding(3, 4, 3, 4);
            pic1.Name = "pic1";
            pic1.Size = new Size(123, 107);
            pic1.TabIndex = 0;
            pic1.TabStop = false;
            // 
            // prev_page
            // 
            prev_page.BackColor = Color.SandyBrown;
            prev_page.Location = new Point(1088, 701);
            prev_page.Margin = new Padding(3, 4, 3, 4);
            prev_page.Name = "prev_page";
            prev_page.Size = new Size(35, 36);
            prev_page.TabIndex = 1;
            prev_page.Text = "<";
            prev_page.UseVisualStyleBackColor = false;
            prev_page.Click += prev_page_Click;
            // 
            // next_page
            // 
            next_page.BackColor = Color.SandyBrown;
            next_page.Location = new Point(1129, 701);
            next_page.Margin = new Padding(3, 4, 3, 4);
            next_page.Name = "next_page";
            next_page.Size = new Size(38, 36);
            next_page.TabIndex = 2;
            next_page.Text = ">";
            next_page.UseVisualStyleBackColor = false;
            next_page.Click += next_page_Click;
            // 
            // search
            // 
            search.BackColor = Color.Linen;
            search.Location = new Point(14, 59);
            search.Margin = new Padding(3, 4, 3, 4);
            search.Name = "search";
            search.Size = new Size(506, 27);
            search.TabIndex = 3;
            search.TextChanged += search_TextChanged;
            // 
            // sort
            // 
            sort.BackColor = Color.Linen;
            sort.FormattingEnabled = true;
            sort.Location = new Point(599, 59);
            sort.Margin = new Padding(3, 4, 3, 4);
            sort.Name = "sort";
            sort.Size = new Size(214, 28);
            sort.TabIndex = 4;
            sort.Text = "Сортировка";
            sort.SelectedIndexChanged += sort_SelectedIndexChanged;
            // 
            // filter
            // 
            filter.BackColor = Color.Linen;
            filter.FormattingEnabled = true;
            filter.Location = new Point(909, 59);
            filter.Margin = new Padding(3, 4, 3, 4);
            filter.Name = "filter";
            filter.Size = new Size(214, 28);
            filter.TabIndex = 5;
            filter.Text = "Фильтрация";
            filter.SelectedIndexChanged += filter_SelectedIndexChanged;
            // 
            // login_lbl
            // 
            login_lbl.AutoSize = true;
            login_lbl.Location = new Point(1208, 9);
            login_lbl.Name = "login_lbl";
            login_lbl.Size = new Size(50, 20);
            login_lbl.TabIndex = 6;
            login_lbl.Text = "логин";
            login_lbl.Click += login_lbl_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(price2);
            panel2.Controls.Add(prod_name2);
            panel2.Controls.Add(article2);
            panel2.Controls.Add(pic2);
            panel2.Location = new Point(57, 217);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1110, 115);
            panel2.TabIndex = 4;
            // 
            // price2
            // 
            price2.AutoSize = true;
            price2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            price2.Location = new Point(941, 39);
            price2.Name = "price2";
            price2.Size = new Size(59, 28);
            price2.TabIndex = 3;
            price2.Text = "Цена";
            // 
            // prod_name2
            // 
            prod_name2.AutoSize = true;
            prod_name2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prod_name2.Location = new Point(585, 39);
            prod_name2.Name = "prod_name2";
            prod_name2.Size = new Size(241, 28);
            prod_name2.TabIndex = 2;
            prod_name2.Text = "Наименование продукта";
            // 
            // article2
            // 
            article2.AutoSize = true;
            article2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            article2.Location = new Point(253, 39);
            article2.Name = "article2";
            article2.Size = new Size(88, 28);
            article2.TabIndex = 1;
            article2.Text = "Артикул";
            // 
            // pic2
            // 
            pic2.Location = new Point(3, 4);
            pic2.Margin = new Padding(3, 4, 3, 4);
            pic2.Name = "pic2";
            pic2.Size = new Size(123, 107);
            pic2.TabIndex = 0;
            pic2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(price3);
            panel3.Controls.Add(prod_name3);
            panel3.Controls.Add(article3);
            panel3.Controls.Add(pic3);
            panel3.Location = new Point(57, 336);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1110, 115);
            panel3.TabIndex = 5;
            // 
            // price3
            // 
            price3.AutoSize = true;
            price3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            price3.Location = new Point(941, 39);
            price3.Name = "price3";
            price3.Size = new Size(59, 28);
            price3.TabIndex = 3;
            price3.Text = "Цена";
            // 
            // prod_name3
            // 
            prod_name3.AutoSize = true;
            prod_name3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prod_name3.Location = new Point(585, 39);
            prod_name3.Name = "prod_name3";
            prod_name3.Size = new Size(241, 28);
            prod_name3.TabIndex = 2;
            prod_name3.Text = "Наименование продукта";
            // 
            // article3
            // 
            article3.AutoSize = true;
            article3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            article3.Location = new Point(253, 39);
            article3.Name = "article3";
            article3.Size = new Size(88, 28);
            article3.TabIndex = 1;
            article3.Text = "Артикул";
            // 
            // pic3
            // 
            pic3.Location = new Point(3, 4);
            pic3.Margin = new Padding(3, 4, 3, 4);
            pic3.Name = "pic3";
            pic3.Size = new Size(123, 107);
            pic3.TabIndex = 0;
            pic3.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(price4);
            panel4.Controls.Add(prod_name4);
            panel4.Controls.Add(article4);
            panel4.Controls.Add(pic4);
            panel4.Location = new Point(57, 455);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1110, 115);
            panel4.TabIndex = 5;
            // 
            // price4
            // 
            price4.AutoSize = true;
            price4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            price4.Location = new Point(941, 39);
            price4.Name = "price4";
            price4.Size = new Size(59, 28);
            price4.TabIndex = 3;
            price4.Text = "Цена";
            // 
            // prod_name4
            // 
            prod_name4.AutoSize = true;
            prod_name4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prod_name4.Location = new Point(585, 39);
            prod_name4.Name = "prod_name4";
            prod_name4.Size = new Size(241, 28);
            prod_name4.TabIndex = 2;
            prod_name4.Text = "Наименование продукта";
            // 
            // article4
            // 
            article4.AutoSize = true;
            article4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            article4.Location = new Point(253, 39);
            article4.Name = "article4";
            article4.Size = new Size(88, 28);
            article4.TabIndex = 1;
            article4.Text = "Артикул";
            // 
            // pic4
            // 
            pic4.Location = new Point(3, 4);
            pic4.Margin = new Padding(3, 4, 3, 4);
            pic4.Name = "pic4";
            pic4.Size = new Size(123, 107);
            pic4.TabIndex = 0;
            pic4.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(price5);
            panel5.Controls.Add(prod_name5);
            panel5.Controls.Add(article5);
            panel5.Controls.Add(pic5);
            panel5.Location = new Point(57, 578);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(1110, 115);
            panel5.TabIndex = 7;
            panel5.Paint += panel5_Paint;
            // 
            // price5
            // 
            price5.AutoSize = true;
            price5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            price5.Location = new Point(941, 39);
            price5.Name = "price5";
            price5.Size = new Size(59, 28);
            price5.TabIndex = 3;
            price5.Text = "Цена";
            // 
            // prod_name5
            // 
            prod_name5.AutoSize = true;
            prod_name5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prod_name5.Location = new Point(585, 39);
            prod_name5.Name = "prod_name5";
            prod_name5.Size = new Size(241, 28);
            prod_name5.TabIndex = 2;
            prod_name5.Text = "Наименование продукта";
            // 
            // article5
            // 
            article5.AutoSize = true;
            article5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            article5.Location = new Point(253, 39);
            article5.Name = "article5";
            article5.Size = new Size(88, 28);
            article5.TabIndex = 1;
            article5.Text = "Артикул";
            // 
            // pic5
            // 
            pic5.Location = new Point(3, 4);
            pic5.Margin = new Padding(3, 4, 3, 4);
            pic5.Name = "pic5";
            pic5.Size = new Size(123, 107);
            pic5.TabIndex = 0;
            pic5.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, распечататьШтрихкодToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(240, 52);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(239, 24);
            toolStripMenuItem1.Text = "Добавить в корзину";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // распечататьШтрихкодToolStripMenuItem
            // 
            распечататьШтрихкодToolStripMenuItem.Name = "распечататьШтрихкодToolStripMenuItem";
            распечататьШтрихкодToolStripMenuItem.Size = new Size(239, 24);
            распечататьШтрихкодToolStripMenuItem.Text = "Распечатать штрих-код";
            распечататьШтрихкодToolStripMenuItem.Click += распечататьШтрихкодToolStripMenuItem_Click;
            // 
            // cart_btn
            // 
            cart_btn.BackColor = Color.SandyBrown;
            cart_btn.Location = new Point(14, 711);
            cart_btn.Margin = new Padding(3, 4, 3, 4);
            cart_btn.Name = "cart_btn";
            cart_btn.Size = new Size(274, 45);
            cart_btn.TabIndex = 8;
            cart_btn.Text = "Корзина";
            cart_btn.UseVisualStyleBackColor = false;
            cart_btn.Visible = false;
            cart_btn.Click += cart_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(509, 12);
            label1.Name = "label1";
            label1.Size = new Size(241, 35);
            label1.TabIndex = 9;
            label1.Text = "Каталог товаров";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1173, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Manager_from
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1290, 779);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(cart_btn);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(login_lbl);
            Controls.Add(filter);
            Controls.Add(sort);
            Controls.Add(search);
            Controls.Add(next_page);
            Controls.Add(prev_page);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Manager_from";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "СтройМодерн";
            Activated += Manager_from_Activated;
            FormClosing += Manager_from_FormClosing;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic5).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label price1;
        private Label prod_name1;
        private Label article1;
        private PictureBox pic1;
        private Button prev_page;
        private Button next_page;
        private TextBox search;
        private ComboBox sort;
        private ComboBox filter;
        private Label login_lbl;
        private Panel panel2;
        private Label price2;
        private Label prod_name2;
        private Label article2;
        private PictureBox pic2;
        private Panel panel3;
        private Label price3;
        private Label prod_name3;
        private Label article3;
        private PictureBox pic3;
        private Panel panel4;
        private Label price4;
        private Label prod_name4;
        private Label article4;
        private PictureBox pic4;
        private Panel panel5;
        private Label price5;
        private Label prod_name5;
        private Label article5;
        private PictureBox pic5;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem распечататьШтрихкодToolStripMenuItem;
        private Button cart_btn;
        private Label label1;
        private PictureBox pictureBox1;
    }
}