namespace RestaurantOrderingSystem_Midterm
{
    partial class LandingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingForm));
            touchStartBtn = new Button();
            hungryLbl = new Label();
            orderNowLbl = new Label();
            taglineLbl = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // touchStartBtn
            // 
            touchStartBtn.BackColor = Color.Firebrick;
            touchStartBtn.Cursor = Cursors.Hand;
            touchStartBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            touchStartBtn.ForeColor = Color.White;
            touchStartBtn.Location = new Point(12, 582);
            touchStartBtn.Name = "touchStartBtn";
            touchStartBtn.Size = new Size(410, 117);
            touchStartBtn.TabIndex = 0;
            touchStartBtn.Text = "👆 TOUCH TO START";
            touchStartBtn.UseVisualStyleBackColor = false;
            touchStartBtn.Click += touchStartBtn_Click;
            // 
            // hungryLbl
            // 
            hungryLbl.AutoSize = true;
            hungryLbl.BackColor = Color.Transparent;
            hungryLbl.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hungryLbl.Location = new Point(107, 347);
            hungryLbl.Name = "hungryLbl";
            hungryLbl.Size = new Size(221, 65);
            hungryLbl.TabIndex = 2;
            hungryLbl.Text = "Hungry?";
            hungryLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // orderNowLbl
            // 
            orderNowLbl.AutoSize = true;
            orderNowLbl.BackColor = Color.Transparent;
            orderNowLbl.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderNowLbl.Location = new Point(74, 424);
            orderNowLbl.Name = "orderNowLbl";
            orderNowLbl.Size = new Size(292, 65);
            orderNowLbl.TabIndex = 3;
            orderNowLbl.Text = "Order Now!";
            orderNowLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // taglineLbl
            // 
            taglineLbl.AutoSize = true;
            taglineLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taglineLbl.ForeColor = SystemColors.AppWorkspace;
            taglineLbl.Location = new Point(136, 504);
            taglineLbl.Name = "taglineLbl";
            taglineLbl.Size = new Size(166, 21);
            taglineLbl.TabIndex = 4;
            taglineLbl.Text = "Order Fresh, Eat Fresh.";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-62, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(530, 324);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(147, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(155, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // LandingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 761);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(taglineLbl);
            Controls.Add(orderNowLbl);
            Controls.Add(hungryLbl);
            Controls.Add(touchStartBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LandingForm";
            Text = "SwiftSavor ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button touchStartBtn;
        private Label hungryLbl;
        private Label orderNowLbl;
        private Label taglineLbl;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
