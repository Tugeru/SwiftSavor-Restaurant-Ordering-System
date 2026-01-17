using System;
﻿using System.Collections.Generic;
﻿using System.ComponentModel;
﻿using System.Data;
﻿using System.Drawing;
﻿using System.Linq;
﻿using System.Text;
﻿using System.Threading.Tasks;
﻿using System.Windows.Forms;
﻿
﻿namespace RestaurantOrderingSystem_Midterm
﻿{
﻿    public partial class ProductSelectionSweetsForm : Form
﻿    {
﻿        private int iceCreamCount = 0;
﻿        private int cheesecakeCount = 0;
﻿        private int tiramisuCount = 0;
﻿
﻿        public ProductSelectionSweetsForm()
﻿        {
﻿            InitializeComponent();
﻿            UpdateFooter();
﻿            BindEvents();
﻿        }
﻿
﻿        private void BindEvents()
﻿        {
﻿            // Ice Cream
﻿            addIceCreamQuantBtn.Click += (s, e) => { iceCreamCount++; iceCreamQuantLbl.Text = iceCreamCount.ToString(); };
﻿            reduceIceCreamQuantBtn.Click += (s, e) => { if (iceCreamCount > 0) iceCreamCount--; iceCreamQuantLbl.Text = iceCreamCount.ToString(); };
﻿            addOrderIceCreamBtn.Click += (s, e) => AddToCart("Ice Cream", 49.00m, ref iceCreamCount, iceCreamQuantLbl);
﻿
﻿            // Cheesecake
﻿            addCheesecakeQuantBtn.Click += (s, e) => { cheesecakeCount++; cheesecakeQuantLbl.Text = cheesecakeCount.ToString(); };
﻿            reduceCheesecakeQuantBtn.Click += (s, e) => { if (cheesecakeCount > 0) cheesecakeCount--; cheesecakeQuantLbl.Text = cheesecakeCount.ToString(); };
﻿            addOrderCheesecakeBtn.Click += (s, e) => AddToCart("Cheesecake", 99.00m, ref cheesecakeCount, cheesecakeQuantLbl);
﻿
﻿            // Strawberry Tiramisu
﻿            addTiramisuQuantBtn.Click += (s, e) => { tiramisuCount++; tiramisuQuantLbl.Text = tiramisuCount.ToString(); };
﻿            reduceTiramisuQuantBtn.Click += (s, e) => { if (tiramisuCount > 0) tiramisuCount--; tiramisuQuantLbl.Text = tiramisuCount.ToString(); };
﻿            addOrderTiramisuBtn.Click += (s, e) => AddToCart("Strawberry Tiramisu", 149.00m, ref tiramisuCount, tiramisuQuantLbl);
﻿
﻿            // Navigation
﻿            checkoutBtn.Click += (s, e) => {
﻿                OrderReviewForm reviewForm = new OrderReviewForm();
﻿                reviewForm.Show();
﻿                this.Hide();
﻿            };
﻿
﻿            viewOrderDetailsLbl.Click += (s, e) => {
﻿                ViewOrderDetailsForm detailsForm = new ViewOrderDetailsForm();
﻿                detailsForm.ShowDialog();
﻿            };
﻿        }
﻿
﻿        private void AddToCart(string name, decimal price, ref int count, Label countLabel)
﻿        {
﻿            if (count > 0)
﻿            {
﻿                OrderManager.AddItem(name, price, count);
﻿                count = 0;
﻿                countLabel.Text = "0";
﻿                UpdateFooter();
﻿                MessageBox.Show($"{name} added to cart!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
﻿            }
﻿            else
﻿            {
﻿                MessageBox.Show("Please select a quantity first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
﻿            }
﻿        }
﻿
﻿        private void UpdateFooter()
﻿        {
﻿            itemNumLbl.Text = $"{OrderManager.GetTotalItems()} Items";
﻿            selectedItemsPrice.Text = $"₱ {OrderManager.GetGrandTotal():N2}";
﻿        }
﻿
﻿        private void burgersSideBarBtn_Click(object sender, EventArgs e)
﻿        {
﻿            ProductSelectionBurgersForm form = new ProductSelectionBurgersForm();
﻿            form.Show();
﻿            this.Hide();
﻿        }
﻿
﻿        private void pizzaSideBarBtn_Click(object sender, EventArgs e)
﻿        {
﻿            ProductSelectionPizzasForm form = new ProductSelectionPizzasForm();
﻿            form.Show();
﻿            this.Hide();
﻿        }
﻿
﻿        private void drinksSideBarBtn_Click(object sender, EventArgs e)
﻿        {
﻿            ProductSelectionDrinksForm form = new ProductSelectionDrinksForm();
﻿            form.Show();
﻿            this.Hide();
﻿        }
﻿
﻿        private void sidesSideBarBtn_Click(object sender, EventArgs e)
﻿        {
﻿            ProductSelectionSidesForm form = new ProductSelectionSidesForm();
﻿            form.Show();
﻿            this.Hide();
﻿        }
﻿    }
﻿}
