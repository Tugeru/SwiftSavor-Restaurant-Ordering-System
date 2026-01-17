namespace RestaurantOrderingSystem_Midterm
{
    partial class ProductSelectionPizzasForm
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
            topHeaderPanel = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            viewOrderDetailsLbl = new Label();
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
            addOrderPepperoniBtn = new Button();
            pepperoniQuantLbl = new Label();
            reducePepperoniQuantBtn = new Button();
            addPepperoniQuantBtn = new Button();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            addOrderHawaiianBtn = new Button();
            hawaiianQuantLbl = new Label();
            reduceHawaiianQuantBtn = new Button();
            addHawaiianQuantBtn = new Button();
            labe3 = new Label();
            pictureBox3 = new PictureBox();
            groupBox2 = new GroupBox();
            addOrderMushroomBtn = new Button();
            mushroomQuantLbl = new Label();
            reduceMushroomQuantBtn = new Button();
            addMushroomQuantBtn = new Button();
            label9 = new Label();
            pictureBox4 = new PictureBox();
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
            pizzasLogoLbl.BackColor = Color.Brown;
            pizzasLogoLbl.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pizzasLogoLbl.ForeColor = Color.White;
            pizzasLogoLbl.Location = new Point(34, 126);
            pizzasLogoLbl.Name = "pizzasLogoLbl";
            pizzasLogoLbl.Size = new Size(37, 30);
            pizzasLogoLbl.TabIndex = 9;
            pizzasLogoLbl.Text = "🍕";
            // 
            // pizzaSideBarBtn
            // 
            pizzaSideBarBtn.BackColor = Color.Brown;
            pizzaSideBarBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pizzaSideBarBtn.ForeColor = Color.White;
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
            drinksLogoLbl.ForeColor = Color.Black;
            drinksLogoLbl.Location = new Point(31, 226);
            drinksLogoLbl.Name = "drinksLogoLbl";
            drinksLogoLbl.Size = new Size(39, 30);
            drinksLogoLbl.TabIndex = 5;
            drinksLogoLbl.Text = "\U0001f964";
            // 
            // burgerLogoLbl
            // 
            burgerLogoLbl.AutoSize = true;
            burgerLogoLbl.BackColor = Color.Gainsboro;
            burgerLogoLbl.Cursor = Cursors.Hand;
            burgerLogoLbl.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            burgerLogoLbl.ForeColor = Color.Black;
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
            drinksSideBarBtn.ForeColor = Color.Black;
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
            burgersSideBarBtn.BackColor = Color.Gainsboro;
            burgersSideBarBtn.Cursor = Cursors.Hand;
            burgersSideBarBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            burgersSideBarBtn.ForeColor = Color.Black;
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
            classicCheeseBurgerGrpBox.Controls.Add(addOrderPepperoniBtn);
            classicCheeseBurgerGrpBox.Controls.Add(pepperoniQuantLbl);
            classicCheeseBurgerGrpBox.Controls.Add(reducePepperoniQuantBtn);
            classicCheeseBurgerGrpBox.Controls.Add(addPepperoniQuantBtn);
            classicCheeseBurgerGrpBox.Controls.Add(label4);
            classicCheeseBurgerGrpBox.Controls.Add(pictureBox2);
            classicCheeseBurgerGrpBox.Location = new Point(104, 115);
            classicCheeseBurgerGrpBox.Name = "classicCheeseBurgerGrpBox";
            classicCheeseBurgerGrpBox.Size = new Size(152, 255);
            classicCheeseBurgerGrpBox.TabIndex = 4;
            classicCheeseBurgerGrpBox.TabStop = false;
            // 
            // addOrderPepperoniBtn
            // 
            addOrderPepperoniBtn.BackColor = Color.Firebrick;
            addOrderPepperoniBtn.Cursor = Cursors.Hand;
            addOrderPepperoniBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addOrderPepperoniBtn.ForeColor = SystemColors.Control;
            addOrderPepperoniBtn.Location = new Point(7, 203);
            addOrderPepperoniBtn.Name = "addOrderPepperoniBtn";
            addOrderPepperoniBtn.Size = new Size(139, 46);
            addOrderPepperoniBtn.TabIndex = 5;
            addOrderPepperoniBtn.Text = "Add Order";
            addOrderPepperoniBtn.UseVisualStyleBackColor = false;
            // 
            // pepperoniQuantLbl
            // 
            pepperoniQuantLbl.AutoSize = true;
            pepperoniQuantLbl.BackColor = Color.DimGray;
            pepperoniQuantLbl.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pepperoniQuantLbl.ForeColor = SystemColors.Control;
            pepperoniQuantLbl.Location = new Point(67, 170);
            pepperoniQuantLbl.Name = "pepperoniQuantLbl";
            pepperoniQuantLbl.Size = new Size(17, 20);
            pepperoniQuantLbl.TabIndex = 4;
            pepperoniQuantLbl.Text = "0";
            // 
            // reducePepperoniQuantBtn
            // 
            reducePepperoniQuantBtn.BackColor = Color.Orange;
            reducePepperoniQuantBtn.Cursor = Cursors.Hand;
            reducePepperoniQuantBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reducePepperoniQuantBtn.Location = new Point(113, 164);
            reducePepperoniQuantBtn.Name = "reducePepperoniQuantBtn";
            reducePepperoniQuantBtn.Size = new Size(33, 33);
            reducePepperoniQuantBtn.TabIndex = 3;
            reducePepperoniQuantBtn.Text = "-";
            reducePepperoniQuantBtn.UseVisualStyleBackColor = false;
            // 
            // addPepperoniQuantBtn
            // 
            addPepperoniQuantBtn.BackColor = Color.Orange;
            addPepperoniQuantBtn.Cursor = Cursors.Hand;
            addPepperoniQuantBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addPepperoniQuantBtn.Location = new Point(6, 164);
            addPepperoniQuantBtn.Name = "addPepperoniQuantBtn";
            addPepperoniQuantBtn.Size = new Size(33, 33);
            addPepperoniQuantBtn.TabIndex = 2;
            addPepperoniQuantBtn.Text = "+";
            addPepperoniQuantBtn.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 135);
            label4.Name = "label4";
            label4.Size = new Size(104, 17);
            label4.TabIndex = 1;
            label4.Text = "Pepperoni Pizza";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pepperoni_pizza;
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
            label2.Size = new Size(100, 40);
            label2.TabIndex = 5;
            label2.Text = "Pizzas";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(addOrderHawaiianBtn);
            groupBox1.Controls.Add(hawaiianQuantLbl);
            groupBox1.Controls.Add(reduceHawaiianQuantBtn);
            groupBox1.Controls.Add(addHawaiianQuantBtn);
            groupBox1.Controls.Add(labe3);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Location = new Point(273, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(152, 255);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // addOrderHawaiianBtn
            // 
            addOrderHawaiianBtn.BackColor = Color.Firebrick;
            addOrderHawaiianBtn.Cursor = Cursors.Hand;
            addOrderHawaiianBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addOrderHawaiianBtn.ForeColor = SystemColors.Control;
            addOrderHawaiianBtn.Location = new Point(7, 203);
            addOrderHawaiianBtn.Name = "addOrderHawaiianBtn";
            addOrderHawaiianBtn.Size = new Size(139, 46);
            addOrderHawaiianBtn.TabIndex = 5;
            addOrderHawaiianBtn.Text = "Add Order";
            addOrderHawaiianBtn.UseVisualStyleBackColor = false;
            // 
            // hawaiianQuantLbl
            // 
            hawaiianQuantLbl.AutoSize = true;
            hawaiianQuantLbl.BackColor = Color.DimGray;
            hawaiianQuantLbl.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hawaiianQuantLbl.ForeColor = SystemColors.Control;
            hawaiianQuantLbl.Location = new Point(67, 170);
            hawaiianQuantLbl.Name = "hawaiianQuantLbl";
            hawaiianQuantLbl.Size = new Size(17, 20);
            hawaiianQuantLbl.TabIndex = 4;
            hawaiianQuantLbl.Text = "0";
            // 
            // reduceHawaiianQuantBtn
            // 
            reduceHawaiianQuantBtn.BackColor = Color.Orange;
            reduceHawaiianQuantBtn.Cursor = Cursors.Hand;
            reduceHawaiianQuantBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reduceHawaiianQuantBtn.Location = new Point(113, 164);
            reduceHawaiianQuantBtn.Name = "reduceHawaiianQuantBtn";
            reduceHawaiianQuantBtn.Size = new Size(33, 33);
            reduceHawaiianQuantBtn.TabIndex = 3;
            reduceHawaiianQuantBtn.Text = "-";
            reduceHawaiianQuantBtn.UseVisualStyleBackColor = false;
            // 
            // addHawaiianQuantBtn
            // 
            addHawaiianQuantBtn.BackColor = Color.Orange;
            addHawaiianQuantBtn.Cursor = Cursors.Hand;
            addHawaiianQuantBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addHawaiianQuantBtn.Location = new Point(6, 164);
            addHawaiianQuantBtn.Name = "addHawaiianQuantBtn";
            addHawaiianQuantBtn.Size = new Size(33, 33);
            addHawaiianQuantBtn.TabIndex = 2;
            addHawaiianQuantBtn.Text = "+";
            addHawaiianQuantBtn.UseVisualStyleBackColor = false;
            // 
            // labe3
            // 
            labe3.AutoSize = true;
            labe3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labe3.Location = new Point(25, 135);
            labe3.Name = "labe3";
            labe3.Size = new Size(97, 17);
            labe3.TabIndex = 1;
            labe3.Text = "Hawaiian Pizza";
            labe3.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.hawaiian_pizza;
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
            groupBox2.Controls.Add(addOrderMushroomBtn);
            groupBox2.Controls.Add(mushroomQuantLbl);
            groupBox2.Controls.Add(reduceMushroomQuantBtn);
            groupBox2.Controls.Add(addMushroomQuantBtn);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(pictureBox4);
            groupBox2.Location = new Point(104, 395);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(152, 255);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // addOrderMushroomBtn
            // 
            addOrderMushroomBtn.BackColor = Color.Firebrick;
            addOrderMushroomBtn.Cursor = Cursors.Hand;
            addOrderMushroomBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addOrderMushroomBtn.ForeColor = SystemColors.Control;
            addOrderMushroomBtn.Location = new Point(7, 203);
            addOrderMushroomBtn.Name = "addOrderMushroomBtn";
            addOrderMushroomBtn.Size = new Size(139, 46);
            addOrderMushroomBtn.TabIndex = 5;
            addOrderMushroomBtn.Text = "Add Order";
            addOrderMushroomBtn.UseVisualStyleBackColor = false;
            // 
            // mushroomQuantLbl
            // 
            mushroomQuantLbl.AutoSize = true;
            mushroomQuantLbl.BackColor = Color.DimGray;
            mushroomQuantLbl.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mushroomQuantLbl.ForeColor = SystemColors.Control;
            mushroomQuantLbl.Location = new Point(67, 170);
            mushroomQuantLbl.Name = "mushroomQuantLbl";
            mushroomQuantLbl.Size = new Size(17, 20);
            mushroomQuantLbl.TabIndex = 4;
            mushroomQuantLbl.Text = "0";
            // 
            // reduceMushroomQuantBtn
            // 
            reduceMushroomQuantBtn.BackColor = Color.Orange;
            reduceMushroomQuantBtn.Cursor = Cursors.Hand;
            reduceMushroomQuantBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reduceMushroomQuantBtn.Location = new Point(113, 164);
            reduceMushroomQuantBtn.Name = "reduceMushroomQuantBtn";
            reduceMushroomQuantBtn.Size = new Size(33, 33);
            reduceMushroomQuantBtn.TabIndex = 3;
            reduceMushroomQuantBtn.Text = "-";
            reduceMushroomQuantBtn.UseVisualStyleBackColor = false;
            // 
            // addMushroomQuantBtn
            // 
            addMushroomQuantBtn.BackColor = Color.Orange;
            addMushroomQuantBtn.Cursor = Cursors.Hand;
            addMushroomQuantBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addMushroomQuantBtn.Location = new Point(6, 164);
            addMushroomQuantBtn.Name = "addMushroomQuantBtn";
            addMushroomQuantBtn.Size = new Size(33, 33);
            addMushroomQuantBtn.TabIndex = 2;
            addMushroomQuantBtn.Text = "+";
            addMushroomQuantBtn.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(23, 134);
            label9.Name = "label9";
            label9.Size = new Size(109, 17);
            label9.TabIndex = 1;
            label9.Text = "Mushroom Pizza";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.mushroom_pizza;
            pictureBox4.Location = new Point(7, 10);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(139, 121);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // ProductSelectionPizzasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(434, 761);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(classicCheeseBurgerGrpBox);
            Controls.Add(sidebarPanel);
            Controls.Add(panel2);
            Controls.Add(topHeaderPanel);
            Name = "ProductSelectionPizzasForm";
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
        private Label viewOrderDetailsLbl;
        private Label label2;
        private Label pizzasLogoLbl;
        private Button pizzaSideBarBtn;
        private PictureBox pictureBox2;
        private Button addPepperoniQuantBtn;
        private Label label4;
        private Button reducePepperoniQuantBtn;
        private GroupBox groupBox1;
        private Button addOrderHawaiianBtn;
        private Label hawaiianQuantLbl;
        private Button reduceHawaiianQuantBtn;
        private Button addHawaiianQuantBtn;
        private Label labe3;
        private Button addOrderPepperoniBtn;
        private Label pepperoniQuantLbl;
        private PictureBox pictureBox3;
        private GroupBox groupBox2;
        private Button addOrderMushroomBtn;
        private Label mushroomQuantLbl;
        private Button reduceMushroomQuantBtn;
        private Button addMushroomQuantBtn;
        private Label label9;
        private PictureBox pictureBox4;
#endregion
    }
}