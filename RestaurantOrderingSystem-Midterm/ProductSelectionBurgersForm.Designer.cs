namespace RestaurantOrderingSystem_Midterm
{
    partial class ProductSelectionBurgersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductSelectionBurgersForm));
            topHeaderPanel = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            selectedItemsPrice = new Label();
            itemNumLbl = new Label();
            checkoutBtn = new Button();
            sidebarPanel = new Panel();
            pizzasLogoLbl = new Label();
            pizzaSideBarBtn = new Button();
            sweetsLogoLabel = new Label();
            sidesLogoLbl = new Label();
            drinksLogoLbl = new Label();
            burgerLogoLbl = new Label();
            sweetsSideBarBtn = new Button();
            sidesSideBarBtn = new Button();
            drinksSideBarBtn = new Button();
            burgersSideBarBtn = new Button();
            classicCheeseBurgerGrpBox = new GroupBox();
            addOrderClassicCheeseBurgerBtn = new Button();
            classicBurgerQuantLbl = new Label();
            reduceClassicQuantBtn = new Button();
            addClassicQuantBtn = new Button();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            addOrderDoubleCheeseBtn = new Button();
            doubleCheeseQuantLbl = new Label();
            reduceDoubleCheeseQuantBtn = new Button();
            addDoubleCheeseQuantBtn = new Button();
            labe3 = new Label();
            pictureBox3 = new PictureBox();
            groupBox2 = new GroupBox();
            addOrderChickenBtn = new Button();
            chickenQuantLbl = new Label();
            reduceChickenQuantBtn = new Button();
            addChickenQuantBtn = new Button();
            label9 = new Label();
            pictureBox4 = new PictureBox();
            groupBox3 = new GroupBox();
            addOrderDoubleChickenBtn = new Button();
            doubleChickenQuantLbl = new Label();
            button9 = new Button();
            button10 = new Button();
            label11 = new Label();
            pictureBox5 = new PictureBox();
            viewOrderDetailsLbl = new Label();
            topHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            sidebarPanel.SuspendLayout();
            classicCheeseBurgerGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // topHeaderPanel
            // 
            topHeaderPanel.BackColor = Color.WhiteSmoke;
            topHeaderPanel.Controls.Add(pictureBox1);
            topHeaderPanel.Dock = DockStyle.Top;
            topHeaderPanel.Location = new Point(0, 0);
            topHeaderPanel.Name = "topHeaderPanel";
            topHeaderPanel.Size = new Size(434, 57);
            topHeaderPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SwiftSavor_Logo1;
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(viewOrderDetailsLbl);
            panel2.Controls.Add(selectedItemsPrice);
            panel2.Controls.Add(itemNumLbl);
            panel2.Controls.Add(checkoutBtn);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 692);
            panel2.Name = "panel2";
            panel2.Size = new Size(434, 69);
            panel2.TabIndex = 2;
            // 
            // selectedItemsPrice
            // 
            selectedItemsPrice.AutoSize = true;
            selectedItemsPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectedItemsPrice.ForeColor = Color.DarkOrange;
            selectedItemsPrice.Location = new Point(99, 9);
            selectedItemsPrice.Name = "selectedItemsPrice";
            selectedItemsPrice.Size = new Size(55, 21);
            selectedItemsPrice.TabIndex = 2;
            selectedItemsPrice.Text = "₱ 0.00";
            // 
            // itemNumLbl
            // 
            itemNumLbl.AutoSize = true;
            itemNumLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemNumLbl.Location = new Point(31, 9);
            itemNumLbl.Name = "itemNumLbl";
            itemNumLbl.Size = new Size(58, 21);
            itemNumLbl.TabIndex = 1;
            itemNumLbl.Text = "0 Item";
            // 
            // checkoutBtn
            // 
            checkoutBtn.BackColor = Color.Firebrick;
            checkoutBtn.Cursor = Cursors.Hand;
            checkoutBtn.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkoutBtn.ForeColor = Color.White;
            checkoutBtn.Location = new Point(251, 9);
            checkoutBtn.Name = "checkoutBtn";
            checkoutBtn.Size = new Size(174, 50);
            checkoutBtn.TabIndex = 0;
            checkoutBtn.Text = "Checkout➡";
            checkoutBtn.UseVisualStyleBackColor = false;
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.WhiteSmoke;
            sidebarPanel.Controls.Add(pizzasLogoLbl);
            sidebarPanel.Controls.Add(pizzaSideBarBtn);
            sidebarPanel.Controls.Add(sweetsLogoLabel);
            sidebarPanel.Controls.Add(sidesLogoLbl);
            sidebarPanel.Controls.Add(drinksLogoLbl);
            sidebarPanel.Controls.Add(burgerLogoLbl);
            sidebarPanel.Controls.Add(sweetsSideBarBtn);
            sidebarPanel.Controls.Add(sidesSideBarBtn);
            sidebarPanel.Controls.Add(drinksSideBarBtn);
            sidebarPanel.Controls.Add(burgersSideBarBtn);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.ForeColor = SystemColors.ControlText;
            sidebarPanel.Location = new Point(0, 57);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(98, 635);
            sidebarPanel.TabIndex = 3;
            // 
            // pizzasLogoLbl
            // 
            pizzasLogoLbl.AutoSize = true;
            pizzasLogoLbl.BackColor = Color.Gainsboro;
            pizzasLogoLbl.Cursor = Cursors.Hand;
            pizzasLogoLbl.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pizzasLogoLbl.Location = new Point(34, 126);
            pizzasLogoLbl.Name = "pizzasLogoLbl";
            pizzasLogoLbl.Size = new Size(37, 30);
            pizzasLogoLbl.TabIndex = 9;
            pizzasLogoLbl.Text = "🍕";
            // 
            // pizzaSideBarBtn
            // 
            pizzaSideBarBtn.BackColor = Color.Gainsboro;
            pizzaSideBarBtn.Cursor = Cursors.Hand;
            pizzaSideBarBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pizzaSideBarBtn.Location = new Point(13, 116);
            pizzaSideBarBtn.Name = "pizzaSideBarBtn";
            pizzaSideBarBtn.Size = new Size(75, 61);
            pizzaSideBarBtn.TabIndex = 8;
            pizzaSideBarBtn.Text = "Pizzas";
            pizzaSideBarBtn.TextAlign = ContentAlignment.BottomCenter;
            pizzaSideBarBtn.UseVisualStyleBackColor = false;
            // 
            // sweetsLogoLabel
            // 
            sweetsLogoLabel.AutoSize = true;
            sweetsLogoLabel.BackColor = Color.Gainsboro;
            sweetsLogoLabel.Cursor = Cursors.Hand;
            sweetsLogoLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sweetsLogoLabel.Location = new Point(28, 420);
            sweetsLogoLabel.Name = "sweetsLogoLabel";
            sweetsLogoLabel.Size = new Size(43, 30);
            sweetsLogoLabel.TabIndex = 7;
            sweetsLogoLabel.Text = "🍰";
            // 
            // sidesLogoLbl
            // 
            sidesLogoLbl.AutoSize = true;
            sidesLogoLbl.BackColor = Color.Gainsboro;
            sidesLogoLbl.Cursor = Cursors.Hand;
            sidesLogoLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sidesLogoLbl.ForeColor = Color.Black;
            sidesLogoLbl.Location = new Point(28, 326);
            sidesLogoLbl.Name = "sidesLogoLbl";
            sidesLogoLbl.Size = new Size(41, 30);
            sidesLogoLbl.TabIndex = 6;
            sidesLogoLbl.Text = "🍟";
            // 
            // drinksLogoLbl
            // 
            drinksLogoLbl.AutoSize = true;
            drinksLogoLbl.BackColor = Color.Gainsboro;
            drinksLogoLbl.Cursor = Cursors.Hand;
            drinksLogoLbl.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            drinksLogoLbl.Location = new Point(31, 226);
            drinksLogoLbl.Name = "drinksLogoLbl";
            drinksLogoLbl.Size = new Size(39, 30);
            drinksLogoLbl.TabIndex = 5;
            drinksLogoLbl.Text = "\U0001f964";
            // 
            // burgerLogoLbl
            // 
            burgerLogoLbl.AutoSize = true;
            burgerLogoLbl.BackColor = Color.Brown;
            burgerLogoLbl.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            burgerLogoLbl.ForeColor = Color.White;
            burgerLogoLbl.Location = new Point(28, 34);
            burgerLogoLbl.Name = "burgerLogoLbl";
            burgerLogoLbl.Size = new Size(43, 30);
            burgerLogoLbl.TabIndex = 4;
            burgerLogoLbl.Text = "🍔";
            // 
            // sweetsSideBarBtn
            // 
            sweetsSideBarBtn.BackColor = Color.Gainsboro;
            sweetsSideBarBtn.Cursor = Cursors.Hand;
            sweetsSideBarBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sweetsSideBarBtn.Location = new Point(12, 414);
            sweetsSideBarBtn.Name = "sweetsSideBarBtn";
            sweetsSideBarBtn.Size = new Size(75, 61);
            sweetsSideBarBtn.TabIndex = 3;
            sweetsSideBarBtn.Text = "Sweets";
            sweetsSideBarBtn.TextAlign = ContentAlignment.BottomCenter;
            sweetsSideBarBtn.UseVisualStyleBackColor = false;
            // 
            // sidesSideBarBtn
            // 
            sidesSideBarBtn.BackColor = Color.Gainsboro;
            sidesSideBarBtn.Cursor = Cursors.Hand;
            sidesSideBarBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sidesSideBarBtn.Location = new Point(12, 315);
            sidesSideBarBtn.Name = "sidesSideBarBtn";
            sidesSideBarBtn.Size = new Size(75, 61);
            sidesSideBarBtn.TabIndex = 2;
            sidesSideBarBtn.Text = "Sides";
            sidesSideBarBtn.TextAlign = ContentAlignment.BottomCenter;
            sidesSideBarBtn.UseVisualStyleBackColor = false;
            // 
            // drinksSideBarBtn
            // 
            drinksSideBarBtn.BackColor = Color.Gainsboro;
            drinksSideBarBtn.Cursor = Cursors.Hand;
            drinksSideBarBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            drinksSideBarBtn.Location = new Point(13, 219);
            drinksSideBarBtn.Name = "drinksSideBarBtn";
            drinksSideBarBtn.Size = new Size(75, 61);
            drinksSideBarBtn.TabIndex = 1;
            drinksSideBarBtn.Text = "Drinks";
            drinksSideBarBtn.TextAlign = ContentAlignment.BottomCenter;
            drinksSideBarBtn.UseVisualStyleBackColor = false;
            // 
            // burgersSideBarBtn
            // 
            burgersSideBarBtn.BackColor = Color.Brown;
            burgersSideBarBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            burgersSideBarBtn.ForeColor = Color.White;
            burgersSideBarBtn.Location = new Point(12, 24);
            burgersSideBarBtn.Name = "burgersSideBarBtn";
            burgersSideBarBtn.Size = new Size(75, 61);
            burgersSideBarBtn.TabIndex = 0;
            burgersSideBarBtn.Text = "Burgers";
            burgersSideBarBtn.TextAlign = ContentAlignment.BottomCenter;
            burgersSideBarBtn.UseVisualStyleBackColor = false;
            // 
            // classicCheeseBurgerGrpBox
            // 
            classicCheeseBurgerGrpBox.BackColor = Color.WhiteSmoke;
            classicCheeseBurgerGrpBox.Controls.Add(addOrderClassicCheeseBurgerBtn);
            classicCheeseBurgerGrpBox.Controls.Add(classicBurgerQuantLbl);
            classicCheeseBurgerGrpBox.Controls.Add(reduceClassicQuantBtn);
            classicCheeseBurgerGrpBox.Controls.Add(addClassicQuantBtn);
            classicCheeseBurgerGrpBox.Controls.Add(label4);
            classicCheeseBurgerGrpBox.Controls.Add(pictureBox2);
            classicCheeseBurgerGrpBox.Location = new Point(104, 115);
            classicCheeseBurgerGrpBox.Name = "classicCheeseBurgerGrpBox";
            classicCheeseBurgerGrpBox.Size = new Size(152, 255);
            classicCheeseBurgerGrpBox.TabIndex = 4;
            classicCheeseBurgerGrpBox.TabStop = false;
            // 
            // addOrderClassicCheeseBurgerBtn
            // 
            addOrderClassicCheeseBurgerBtn.BackColor = Color.Firebrick;
            addOrderClassicCheeseBurgerBtn.Cursor = Cursors.Hand;
            addOrderClassicCheeseBurgerBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addOrderClassicCheeseBurgerBtn.ForeColor = SystemColors.Control;
            addOrderClassicCheeseBurgerBtn.Location = new Point(7, 203);
            addOrderClassicCheeseBurgerBtn.Name = "addOrderClassicCheeseBurgerBtn";
            addOrderClassicCheeseBurgerBtn.Size = new Size(139, 46);
            addOrderClassicCheeseBurgerBtn.TabIndex = 5;
            addOrderClassicCheeseBurgerBtn.Text = "Add Order";
            addOrderClassicCheeseBurgerBtn.UseVisualStyleBackColor = false;
            // 
            // classicBurgerQuantLbl
            // 
            classicBurgerQuantLbl.AutoSize = true;
            classicBurgerQuantLbl.BackColor = Color.DimGray;
            classicBurgerQuantLbl.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            classicBurgerQuantLbl.ForeColor = SystemColors.Control;
            classicBurgerQuantLbl.Location = new Point(67, 170);
            classicBurgerQuantLbl.Name = "classicBurgerQuantLbl";
            classicBurgerQuantLbl.Size = new Size(17, 20);
            classicBurgerQuantLbl.TabIndex = 4;
            classicBurgerQuantLbl.Text = "0";
            // 
            // reduceClassicQuantBtn
            // 
            reduceClassicQuantBtn.BackColor = Color.Orange;
            reduceClassicQuantBtn.Cursor = Cursors.Hand;
            reduceClassicQuantBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reduceClassicQuantBtn.Location = new Point(113, 164);
            reduceClassicQuantBtn.Name = "reduceClassicQuantBtn";
            reduceClassicQuantBtn.Size = new Size(33, 33);
            reduceClassicQuantBtn.TabIndex = 3;
            reduceClassicQuantBtn.Text = "-";
            reduceClassicQuantBtn.UseVisualStyleBackColor = false;
            // 
            // addClassicQuantBtn
            // 
            addClassicQuantBtn.BackColor = Color.Orange;
            addClassicQuantBtn.Cursor = Cursors.Hand;
            addClassicQuantBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addClassicQuantBtn.Location = new Point(6, 164);
            addClassicQuantBtn.Name = "addClassicQuantBtn";
            addClassicQuantBtn.Size = new Size(33, 33);
            addClassicQuantBtn.TabIndex = 2;
            addClassicQuantBtn.Text = "+";
            addClassicQuantBtn.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(7, 135);
            label4.Name = "label4";
            label4.Size = new Size(139, 17);
            label4.TabIndex = 1;
            label4.Text = "Classic Cheese Burger";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.classic_cheese_burger;
            pictureBox2.Location = new Point(7, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(139, 121);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(99, 60);
            label2.Name = "label2";
            label2.Size = new Size(125, 40);
            label2.TabIndex = 5;
            label2.Text = "Burgers";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(addOrderDoubleCheeseBtn);
            groupBox1.Controls.Add(doubleCheeseQuantLbl);
            groupBox1.Controls.Add(reduceDoubleCheeseQuantBtn);
            groupBox1.Controls.Add(addDoubleCheeseQuantBtn);
            groupBox1.Controls.Add(labe3);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Location = new Point(273, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(152, 255);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // addOrderDoubleCheeseBtn
            // 
            addOrderDoubleCheeseBtn.BackColor = Color.Firebrick;
            addOrderDoubleCheeseBtn.Cursor = Cursors.Hand;
            addOrderDoubleCheeseBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addOrderDoubleCheeseBtn.ForeColor = SystemColors.Control;
            addOrderDoubleCheeseBtn.Location = new Point(7, 203);
            addOrderDoubleCheeseBtn.Name = "addOrderDoubleCheeseBtn";
            addOrderDoubleCheeseBtn.Size = new Size(139, 46);
            addOrderDoubleCheeseBtn.TabIndex = 5;
            addOrderDoubleCheeseBtn.Text = "Add Order";
            addOrderDoubleCheeseBtn.UseVisualStyleBackColor = false;
            // 
            // doubleCheeseQuantLbl
            // 
            doubleCheeseQuantLbl.AutoSize = true;
            doubleCheeseQuantLbl.BackColor = Color.DimGray;
            doubleCheeseQuantLbl.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            doubleCheeseQuantLbl.ForeColor = SystemColors.Control;
            doubleCheeseQuantLbl.Location = new Point(67, 170);
            doubleCheeseQuantLbl.Name = "doubleCheeseQuantLbl";
            doubleCheeseQuantLbl.Size = new Size(17, 20);
            doubleCheeseQuantLbl.TabIndex = 4;
            doubleCheeseQuantLbl.Text = "0";
            // 
            // reduceDoubleCheeseQuantBtn
            // 
            reduceDoubleCheeseQuantBtn.BackColor = Color.Orange;
            reduceDoubleCheeseQuantBtn.Cursor = Cursors.Hand;
            reduceDoubleCheeseQuantBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reduceDoubleCheeseQuantBtn.Location = new Point(113, 164);
            reduceDoubleCheeseQuantBtn.Name = "reduceDoubleCheeseQuantBtn";
            reduceDoubleCheeseQuantBtn.Size = new Size(33, 33);
            reduceDoubleCheeseQuantBtn.TabIndex = 3;
            reduceDoubleCheeseQuantBtn.Text = "-";
            reduceDoubleCheeseQuantBtn.UseVisualStyleBackColor = false;
            // 
            // addDoubleCheeseQuantBtn
            // 
            addDoubleCheeseQuantBtn.BackColor = Color.Orange;
            addDoubleCheeseQuantBtn.Cursor = Cursors.Hand;
            addDoubleCheeseQuantBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addDoubleCheeseQuantBtn.Location = new Point(6, 164);
            addDoubleCheeseQuantBtn.Name = "addDoubleCheeseQuantBtn";
            addDoubleCheeseQuantBtn.Size = new Size(33, 33);
            addDoubleCheeseQuantBtn.TabIndex = 2;
            addDoubleCheeseQuantBtn.Text = "+";
            addDoubleCheeseQuantBtn.UseVisualStyleBackColor = false;
            // 
            // labe3
            // 
            labe3.AutoSize = true;
            labe3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labe3.Location = new Point(7, 135);
            labe3.Name = "labe3";
            labe3.Size = new Size(143, 17);
            labe3.TabIndex = 1;
            labe3.Text = "Double Cheese Burger";
            labe3.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.double_cheese_burger;
            pictureBox3.Location = new Point(7, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(139, 121);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.WhiteSmoke;
            groupBox2.Controls.Add(addOrderChickenBtn);
            groupBox2.Controls.Add(chickenQuantLbl);
            groupBox2.Controls.Add(reduceChickenQuantBtn);
            groupBox2.Controls.Add(addChickenQuantBtn);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(pictureBox4);
            groupBox2.Location = new Point(104, 395);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(152, 255);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // addOrderChickenBtn
            // 
            addOrderChickenBtn.BackColor = Color.Firebrick;
            addOrderChickenBtn.Cursor = Cursors.Hand;
            addOrderChickenBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addOrderChickenBtn.ForeColor = SystemColors.Control;
            addOrderChickenBtn.Location = new Point(7, 203);
            addOrderChickenBtn.Name = "addOrderChickenBtn";
            addOrderChickenBtn.Size = new Size(139, 46);
            addOrderChickenBtn.TabIndex = 5;
            addOrderChickenBtn.Text = "Add Order";
            addOrderChickenBtn.UseVisualStyleBackColor = false;
            // 
            // chickenQuantLbl
            // 
            chickenQuantLbl.AutoSize = true;
            chickenQuantLbl.BackColor = Color.DimGray;
            chickenQuantLbl.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chickenQuantLbl.ForeColor = SystemColors.Control;
            chickenQuantLbl.Location = new Point(67, 170);
            chickenQuantLbl.Name = "chickenQuantLbl";
            chickenQuantLbl.Size = new Size(17, 20);
            chickenQuantLbl.TabIndex = 4;
            chickenQuantLbl.Text = "0";
            // 
            // reduceChickenQuantBtn
            // 
            reduceChickenQuantBtn.BackColor = Color.Orange;
            reduceChickenQuantBtn.Cursor = Cursors.Hand;
            reduceChickenQuantBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reduceChickenQuantBtn.Location = new Point(113, 164);
            reduceChickenQuantBtn.Name = "reduceChickenQuantBtn";
            reduceChickenQuantBtn.Size = new Size(33, 33);
            reduceChickenQuantBtn.TabIndex = 3;
            reduceChickenQuantBtn.Text = "-";
            reduceChickenQuantBtn.UseVisualStyleBackColor = false;
            // 
            // addChickenQuantBtn
            // 
            addChickenQuantBtn.BackColor = Color.Orange;
            addChickenQuantBtn.Cursor = Cursors.Hand;
            addChickenQuantBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addChickenQuantBtn.Location = new Point(6, 164);
            addChickenQuantBtn.Name = "addChickenQuantBtn";
            addChickenQuantBtn.Size = new Size(33, 33);
            addChickenQuantBtn.TabIndex = 2;
            addChickenQuantBtn.Text = "+";
            addChickenQuantBtn.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(27, 135);
            label9.Name = "label9";
            label9.Size = new Size(100, 17);
            label9.TabIndex = 1;
            label9.Text = "Chicken Burger";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.chicken_burger;
            pictureBox4.Location = new Point(7, 10);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(139, 121);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.WhiteSmoke;
            groupBox3.Controls.Add(addOrderDoubleChickenBtn);
            groupBox3.Controls.Add(doubleChickenQuantLbl);
            groupBox3.Controls.Add(button9);
            groupBox3.Controls.Add(button10);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(pictureBox5);
            groupBox3.Location = new Point(273, 395);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(152, 255);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            // 
            // addOrderDoubleChickenBtn
            // 
            addOrderDoubleChickenBtn.BackColor = Color.Firebrick;
            addOrderDoubleChickenBtn.Cursor = Cursors.Hand;
            addOrderDoubleChickenBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addOrderDoubleChickenBtn.ForeColor = SystemColors.Control;
            addOrderDoubleChickenBtn.Location = new Point(7, 203);
            addOrderDoubleChickenBtn.Name = "addOrderDoubleChickenBtn";
            addOrderDoubleChickenBtn.Size = new Size(139, 46);
            addOrderDoubleChickenBtn.TabIndex = 5;
            addOrderDoubleChickenBtn.Text = "Add Order";
            addOrderDoubleChickenBtn.UseVisualStyleBackColor = false;
            // 
            // doubleChickenQuantLbl
            // 
            doubleChickenQuantLbl.AutoSize = true;
            doubleChickenQuantLbl.BackColor = Color.DimGray;
            doubleChickenQuantLbl.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            doubleChickenQuantLbl.ForeColor = SystemColors.Control;
            doubleChickenQuantLbl.Location = new Point(67, 170);
            doubleChickenQuantLbl.Name = "doubleChickenQuantLbl";
            doubleChickenQuantLbl.Size = new Size(17, 20);
            doubleChickenQuantLbl.TabIndex = 4;
            doubleChickenQuantLbl.Text = "0";
            // 
            // button9
            // 
            button9.BackColor = Color.Orange;
            button9.Cursor = Cursors.Hand;
            button9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(113, 164);
            button9.Name = "button9";
            button9.Size = new Size(33, 33);
            button9.TabIndex = 3;
            button9.Text = "-";
            button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = Color.Orange;
            button10.Cursor = Cursors.Hand;
            button10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(6, 164);
            button10.Name = "button10";
            button10.Size = new Size(33, 33);
            button10.TabIndex = 2;
            button10.Text = "+";
            button10.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(3, 135);
            label11.Name = "label11";
            label11.Size = new Size(147, 17);
            label11.TabIndex = 1;
            label11.Text = "Double Chicken Burger";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(7, 10);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(139, 121);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // viewOrderDetailsLbl
            // 
            viewOrderDetailsLbl.AutoSize = true;
            viewOrderDetailsLbl.BackColor = Color.LightGray;
            viewOrderDetailsLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewOrderDetailsLbl.Location = new Point(31, 42);
            viewOrderDetailsLbl.Name = "viewOrderDetailsLbl";
            viewOrderDetailsLbl.Size = new Size(117, 17);
            viewOrderDetailsLbl.TabIndex = 3;
            viewOrderDetailsLbl.Text = "View Order Details";
            // 
            // ProductSelectionBurgersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(434, 761);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(classicCheeseBurgerGrpBox);
            Controls.Add(sidebarPanel);
            Controls.Add(panel2);
            Controls.Add(topHeaderPanel);
            Name = "ProductSelectionBurgersForm";
            Text = "SwiftSavor";
            topHeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            sidebarPanel.ResumeLayout(false);
            sidebarPanel.PerformLayout();
            classicCheeseBurgerGrpBox.ResumeLayout(false);
            classicCheeseBurgerGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel topHeaderPanel;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel sidebarPanel;
        private Button checkoutBtn;
        private Button sweetsSideBarBtn;
        private Button sidesSideBarBtn;
        private Button drinksSideBarBtn;
        private Button burgersSideBarBtn;
        private Label sweetsLogoLabel;
        private Label sidesLogoLbl;
        private Label drinksLogoLbl;
        private Label burgerLogoLbl;
        private GroupBox classicCheeseBurgerGrpBox;
        private Label selectedItemsPrice;
        private Label itemNumLbl;
        private Label label2;
        private Label pizzasLogoLbl;
        private Button pizzaSideBarBtn;
        private PictureBox pictureBox2;
        private Button addClassicQuantBtn;
        private Label label4;
        private Button reduceClassicQuantBtn;
        private GroupBox groupBox1;
        private Button addOrderDoubleCheeseBtn;
        private Label doubleCheeseQuantLbl;
        private Button reduceDoubleCheeseQuantBtn;
        private Button addDoubleCheeseQuantBtn;
        private Label labe3;
        private Button addOrderClassicCheeseBurgerBtn;
        private Label classicBurgerQuantLbl;
        private PictureBox pictureBox3;
        private GroupBox groupBox2;
        private Button addOrderChickenBtn;
        private Label chickenQuantLbl;
        private Button reduceChickenQuantBtn;
        private Button addChickenQuantBtn;
        private Label label9;
        private PictureBox pictureBox4;
        private GroupBox groupBox3;
        private Button addOrderDoubleChickenBtn;
        private Label doubleChickenQuantLbl;
        private Button button9;
        private Button button10;
        private Label label11;
        private PictureBox pictureBox5;
        private Label viewOrderDetailsLbl;
    }
}