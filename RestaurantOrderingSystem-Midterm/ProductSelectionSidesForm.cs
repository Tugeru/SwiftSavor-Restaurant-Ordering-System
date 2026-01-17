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
﻿    public partial class ProductSelectionSidesForm : Form
﻿    {
﻿        private int friesCount = 0;
﻿        private int coleslawCount = 0;
﻿        private int saladCount = 0;
﻿
﻿        public ProductSelectionSidesForm()
﻿        {
﻿            InitializeComponent();
﻿            UpdateFooter();
﻿            BindEvents();
﻿        }
﻿
﻿        private void BindEvents()
﻿        {
﻿            // French Fries
﻿            addFriesQuantBtn.Click += (s, e) => { friesCount++; friesQuantLbl.Text = friesCount.ToString(); };
﻿            reduceFriesQuantBtn.Click += (s, e) => { if (friesCount > 0) friesCount--; friesQuantLbl.Text = friesCount.ToString(); };
﻿            addOrderFriesBtn.Click += (s, e) => AddToCart("French Fries", 69.00m, ref friesCount, friesQuantLbl);
﻿
﻿            // Coleslaw
﻿            addColeslawQuantBtn.Click += (s, e) => { coleslawCount++; coleslawQuantLbl.Text = coleslawCount.ToString(); };
﻿            reduceColeslawQuantBtn.Click += (s, e) => { if (coleslawCount > 0) coleslawCount--; coleslawQuantLbl.Text = coleslawCount.ToString(); };
﻿            addOrderColeslawBtn.Click += (s, e) => AddToCart("Coleslaw", 49.00m, ref coleslawCount, coleslawQuantLbl);
﻿
﻿            // Garden Salad
﻿            addSaladQuantBtn.Click += (s, e) => { saladCount++; saladQuantLbl.Text = saladCount.ToString(); };
﻿            reduceSaladQuantBtn.Click += (s, e) => { if (saladCount > 0) saladCount--; saladQuantLbl.Text = saladCount.ToString(); };
﻿            addOrderSaladBtn.Click += (s, e) => AddToCart("Garden Salad", 89.00m, ref saladCount, saladQuantLbl);
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
﻿        private void sweetsSideBarBtn_Click(object sender, EventArgs e)
﻿        {
﻿            ProductSelectionSweetsForm form = new ProductSelectionSweetsForm();
﻿            form.Show();
﻿            this.Hide();
﻿        }
﻿    }
﻿}
