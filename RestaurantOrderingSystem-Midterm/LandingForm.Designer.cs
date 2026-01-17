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
            dineInBtn = new Button();
            dineInLogo = new Label();
            takeOutButton = new Button();
            takeOutLogo = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // touchStartBtn
            // 
            touchStartBtn.BackColor = Color.IndianRed;
            touchStartBtn.Cursor = Cursors.Hand;
            touchStartBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            touchStartBtn.ForeColor = Color.White;
            touchStartBtn.Location = new Point(29, 534);
            touchStartBtn.Name = "touchStartBtn";
            touchStartBtn.Size = new Size(379, 71);
            touchStartBtn.TabIndex = 0;
            touchStartBtn.Text = "👆 TOUCH TO START";
            touchStartBtn.UseVisualStyleBackColor = false;
            // 
            // hungryLbl
            // 
            hungryLbl.AutoSize = true;
            hungryLbl.BackColor = Color.Transparent;
            hungryLbl.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hungryLbl.Location = new Point(108, 320);
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
            orderNowLbl.Location = new Point(75, 385);
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
            taglineLbl.Location = new Point(136, 476);
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
            // dineInBtn
            // 
            dineInBtn.BackColor = SystemColors.ButtonHighlight;
            dineInBtn.Cursor = Cursors.Hand;
            dineInBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dineInBtn.Location = new Point(31, 651);
            dineInBtn.Name = "dineInBtn";
            dineInBtn.Size = new Size(158, 83);
            dineInBtn.TabIndex = 8;
            dineInBtn.Text = "Dine In";
            dineInBtn.TextAlign = ContentAlignment.BottomCenter;
            dineInBtn.UseVisualStyleBackColor = false;
            // 
            // dineInLogo
            // 
            dineInLogo.AutoSize = true;
            dineInLogo.BackColor = SystemColors.ButtonHighlight;
            dineInLogo.Cursor = Cursors.Hand;
            dineInLogo.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dineInLogo.Location = new Point(75, 658);
            dineInLogo.Name = "dineInLogo";
            dineInLogo.Size = new Size(69, 47);
            dineInLogo.TabIndex = 9;
            dineInLogo.Text = "🍽";
            // 
            // takeOutButton
            // 
            takeOutButton.BackColor = SystemColors.ButtonHighlight;
            takeOutButton.Cursor = Cursors.Hand;
            takeOutButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            takeOutButton.Location = new Point(245, 651);
            takeOutButton.Name = "takeOutButton";
            takeOutButton.Size = new Size(158, 83);
            takeOutButton.TabIndex = 8;
            takeOutButton.Text = "Take Out";
            takeOutButton.TextAlign = ContentAlignment.BottomCenter;
            takeOutButton.UseVisualStyleBackColor = false;
            // 
            // takeOutLogo
            // 
            takeOutLogo.AutoSize = true;
            takeOutLogo.BackColor = SystemColors.ButtonHighlight;
            takeOutLogo.Cursor = Cursors.Hand;
            takeOutLogo.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            takeOutLogo.Location = new Point(290, 656);
            takeOutLogo.Name = "takeOutLogo";
            takeOutLogo.Size = new Size(69, 47);
            takeOutLogo.TabIndex = 9;
            takeOutLogo.Text = "🚗";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(31, 620);
            label1.Name = "label1";
            label1.Size = new Size(378, 15);
            label1.TabIndex = 10;
            label1.Text = "---------------------------Quick Service---------------------------------";
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
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 761);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(takeOutLogo);
            Controls.Add(dineInLogo);
            Controls.Add(takeOutButton);
            Controls.Add(dineInBtn);
            Controls.Add(pictureBox1);
            Controls.Add(taglineLbl);
            Controls.Add(orderNowLbl);
            Controls.Add(hungryLbl);
            Controls.Add(touchStartBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainMenuForm";
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
        private Button dineInBtn;
        private Label dineInLogo;
        private Button takeOutButton;
        private Label takeOutLogo;
        private Label label1;
        private PictureBox pictureBox2;
    }
}
