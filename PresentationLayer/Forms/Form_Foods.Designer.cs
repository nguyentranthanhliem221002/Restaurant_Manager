namespace PresentationLayer
{
    partial class frm_foods
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_foods));
            tabMenu = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            imageList1 = new ImageList(components);
            label1 = new Label();
            tabMenu.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabMenu
            // 
            tabMenu.Controls.Add(tabPage1);
            tabMenu.Controls.Add(tabPage2);
            tabMenu.Controls.Add(tabPage3);
            tabMenu.Dock = DockStyle.Fill;
            tabMenu.ImageList = imageList1;
            tabMenu.Location = new Point(0, 0);
            tabMenu.Name = "tabMenu";
            tabMenu.SelectedIndex = 0;
            tabMenu.Size = new Size(1160, 598);
            tabMenu.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(label1);
            tabPage1.ForeColor = SystemColors.ControlText;
            tabPage1.ImageIndex = 0;
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1152, 565);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Đồ ăn";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.ImageIndex = 1;
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1152, 565);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Thức uống";
            // 
            // tabPage3
            // 
            tabPage3.ImageIndex = 2;
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1152, 565);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Món thêm";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "img_food.png");
            imageList1.Images.SetKeyName(1, "img_drink.png");
            imageList1.Images.SetKeyName(2, "icon_secondOrder.png");
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(846, 120);
            label1.Name = "label1";
            label1.Size = new Size(217, 210);
            label1.TabIndex = 1;
            label1.Text = "label1a";
            // 
            // frm_foods
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1160, 598);
            Controls.Add(tabMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_foods";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "cs";
            tabMenu.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabMenu;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ImageList imageList1;
        private Label label1;
    }
}