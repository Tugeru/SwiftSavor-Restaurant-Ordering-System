using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOrderingSystem_Midterm
{
    public partial class ProductSelectionDrinksForm : Form
    {
        private int cokeCount = 0;
        private int icedTeaCount = 0;
        private int icedCoffeeCount = 0;

        public ProductSelectionDrinksForm()
        {
            InitializeComponent();
            UpdateFooter();
            BindEvents();
        }

        private void BindEvents()
        {
            // Coca Cola
            addCocaColaQuantBtn.Click += (s, e) => { cokeCount++; cocaColaQuantLbl.Text = cokeCount.ToString(); };
            reduceCocaColaQuantBtn.Click += (s, e) => { if (cokeCount > 0) cokeCount--; cocaColaQuantLbl.Text = cokeCount.ToString(); };
            addOrderCokeBtn.Click += (s, e) => AddToCart("Coca Cola", 79.00m, ref cokeCount, cocaColaQuantLbl);

            // Iced Tea
            addIcedTeaQuantBtn.Click += (s, e) => { icedTeaCount++; icedTeaQuantLbl.Text = icedTeaCount.ToString(); };
            reduceIcedTeaQuantBtn.Click += (s, e) => { if (icedTeaCount > 0) icedTeaCount--; icedTeaQuantLbl.Text = icedTeaCount.ToString(); };
            addOrderIcedTeaBtn.Click += (s, e) => AddToCart("Iced Tea", 49.00m, ref icedTeaCount, icedTeaQuantLbl);

            // Iced Coffee
            addIcedCoffeeQuantBtn.Click += (s, e) => { icedCoffeeCount++; icedCoffeeQuantLbl.Text = icedCoffeeCount.ToString(); };
            reduceIcedCoffeeQuantBtn.Click += (s, e) => { if (icedCoffeeCount > 0) icedCoffeeCount--; icedCoffeeQuantLbl.Text = icedCoffeeCount.ToString(); };
            addOrderIcedCoffeeBtn.Click += (s, e) => AddToCart("Iced Coffee", 99.00m, ref icedCoffeeCount, icedCoffeeQuantLbl);

            // Navigation
            checkoutBtn.Click += (s, e) =>
            {
                OrderReviewForm reviewForm = new OrderReviewForm();
                reviewForm.Show();
                this.Hide();
            };

            viewOrderDetailsLbl.Click += (s, e) =>
            {
                ViewOrderDetailsForm detailsForm = new ViewOrderDetailsForm();
                detailsForm.ShowDialog();
            };
        }

        private void AddToCart(string name, decimal price, ref int count, Label countLabel)
        {
            if (count > 0)
            {
                OrderManager.AddItem(name, price, count);
                count = 0;
                countLabel.Text = "0";
                UpdateFooter();
                MessageBox.Show($"{name} added to cart!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a quantity first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateFooter()
        {
            itemNumLbl.Text = $"{OrderManager.GetTotalItems()} Items";
            selectedItemsPrice.Text = $"₱ {OrderManager.GetGrandTotal():N2}";
        }

        private void burgersSideBarBtn_Click(object sender, EventArgs e)
        {
            ProductSelectionBurgersForm form = new ProductSelectionBurgersForm();
            form.Show();
            this.Hide();
        }

        private void pizzaSideBarBtn_Click(object sender, EventArgs e)
        {
            ProductSelectionPizzasForm form = new ProductSelectionPizzasForm();
            form.Show();
            this.Hide();
        }

        private void sidesSideBarBtn_Click(object sender, EventArgs e)
        {
            ProductSelectionSidesForm form = new ProductSelectionSidesForm();
            form.Show();
            this.Hide();
        }

        private void sweetsSideBarBtn_Click(object sender, EventArgs e)
        {
            ProductSelectionSweetsForm form = new ProductSelectionSweetsForm();
            form.Show();
            this.Hide();
        }


    }
}
