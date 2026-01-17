namespace RestaurantOrderingSystem_Midterm
{
    partial class MealTypeForm
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
            panel1 = new Panel();
            returnBtn = new Button();
            pictureBox1 = new PictureBox();
            takeOutLogo = new Label();
            dineInLogo = new Label();
            takeOutButton = new Button();
            dineInBtn = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(returnBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 75);
            panel1.TabIndex = 0;
            // 
            // returnBtn
            // 
            returnBtn.Cursor = Cursors.Hand;
            returnBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            returnBtn.Location = new Point(11, 16);
            returnBtn.Name = "returnBtn";
            returnBtn.Size = new Size(44, 45);
            returnBtn.TabIndex = 1;
            returnBtn.Text = "⬅";
            returnBtn.UseVisualStyleBackColor = true;
            returnBtn.Click += returnBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SwiftSavor_Logo1;
            pictureBox1.Location = new Point(70, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // takeOutLogo
            // 
            takeOutLogo.AutoSize = true;
            takeOutLogo.BackColor = SystemColors.ButtonHighlight;
            takeOutLogo.Cursor = Cursors.Hand;
            takeOutLogo.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            takeOutLogo.Location = new Point(288, 155);
            takeOutLogo.Name = "takeOutLogo";
            takeOutLogo.Size = new Size(69, 47);
            takeOutLogo.TabIndex = 12;
            takeOutLogo.Text = "🚗";
            takeOutLogo.Click += takeOutButton_Click;
            // 
            // dineInLogo
            // 
            dineInLogo.AutoSize = true;
            dineInLogo.BackColor = SystemColors.ButtonHighlight;
            dineInLogo.Cursor = Cursors.Hand;
            dineInLogo.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dineInLogo.Location = new Point(71, 157);
            dineInLogo.Name = "dineInLogo";
            dineInLogo.Size = new Size(69, 47);
            dineInLogo.TabIndex = 13;
            dineInLogo.Text = "🍽";
            dineInLogo.Click += dineInBtn_Click;
            // 
            // takeOutButton
            // 
            takeOutButton.BackColor = SystemColors.ButtonHighlight;
            takeOutButton.Cursor = Cursors.Hand;
            takeOutButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            takeOutButton.Location = new Point(243, 150);
            takeOutButton.Name = "takeOutButton";
            takeOutButton.Size = new Size(158, 83);
            takeOutButton.TabIndex = 10;
            takeOutButton.Text = "Take Out";
            takeOutButton.TextAlign = ContentAlignment.BottomCenter;
            takeOutButton.UseVisualStyleBackColor = false;
            takeOutButton.Click += takeOutButton_Click;
            // 
            // dineInBtn
            // 
            dineInBtn.BackColor = SystemColors.ButtonHighlight;
            dineInBtn.Cursor = Cursors.Hand;
            dineInBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dineInBtn.Location = new Point(27, 150);
            dineInBtn.Name = "dineInBtn";
            dineInBtn.Size = new Size(158, 83);
            dineInBtn.TabIndex = 11;
            dineInBtn.Text = "Dine In";
            dineInBtn.TextAlign = ContentAlignment.BottomCenter;
            dineInBtn.UseVisualStyleBackColor = false;
            dineInBtn.Click += dineInBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 93);
            label1.Name = "label1";
            label1.Size = new Size(159, 40);
            label1.TabIndex = 14;
            label1.Text = "Meal Type";
            // 
            // MealTypeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 304);
            Controls.Add(label1);
            Controls.Add(takeOutLogo);
            Controls.Add(dineInLogo);
            Controls.Add(takeOutButton);
            Controls.Add(dineInBtn);
            Controls.Add(panel1);
            Name = "MealTypeForm";
            Text = "SwiftSavor";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button returnBtn;
        private Label takeOutLogo;
        private Label dineInLogo;
        private Button takeOutButton;
        private Button dineInBtn;
        private Label label1;
    }
}