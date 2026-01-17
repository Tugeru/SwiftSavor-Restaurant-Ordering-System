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
    public partial class ProductSelectionBurgersForm : Form
    {
        // Local state for quantities
        private int classicBurgerCount = 0;
        private int doubleCheeseBurgerCount = 0;
        private int chickenBurgerCount = 0;
        private int doubleChickenBurgerCount = 0;

        public ProductSelectionBurgersForm()
        {
            InitializeComponent();
            UpdateFooter();
            BindEvents();
        }

        private void BindEvents()
        {
            // Classic Cheese Burger
            addClassicQuantBtn.Click += (s, e) => { classicBurgerCount++; classicBurgerQuantLbl.Text = classicBurgerCount.ToString(); };
            reduceClassicQuantBtn.Click += (s, e) => { if (classicBurgerCount > 0) classicBurgerCount--; classicBurgerQuantLbl.Text = classicBurgerCount.ToString(); };
            addOrderClassicCheeseBurgerBtn.Click += (s, e) => AddToCart("Classic Cheese Burger", 59.00m, ref classicBurgerCount, classicBurgerQuantLbl);

            // Double Cheese Burger
            addDoubleCheeseQuantBtn.Click += (s, e) => { doubleCheeseBurgerCount++; doubleCheeseQuantLbl.Text = doubleCheeseBurgerCount.ToString(); };
            reduceDoubleCheeseQuantBtn.Click += (s, e) => { if (doubleCheeseBurgerCount > 0) doubleCheeseBurgerCount--; doubleCheeseQuantLbl.Text = doubleCheeseBurgerCount.ToString(); };
            addOrderDoubleCheeseBtn.Click += (s, e) => AddToCart("Double Cheese Burger", 79.00m, ref doubleCheeseBurgerCount, doubleCheeseQuantLbl);

            // Chicken Burger
            addChickenQuantBtn.Click += (s, e) => { chickenBurgerCount++; chickenQuantLbl.Text = chickenBurgerCount.ToString(); };
            reduceChickenQuantBtn.Click += (s, e) => { if (chickenBurgerCount > 0) chickenBurgerCount--; chickenQuantLbl.Text = chickenBurgerCount.ToString(); };
            addOrderChickenBtn.Click += (s, e) => AddToCart("Chicken Burger", 69.00m, ref chickenBurgerCount, chickenQuantLbl);

            // Double Chicken Burger
            button10.Click += (s, e) => { doubleChickenBurgerCount++; doubleChickenQuantLbl.Text = doubleChickenBurgerCount.ToString(); }; // + button
            button9.Click += (s, e) => { if (doubleChickenBurgerCount > 0) doubleChickenBurgerCount--; doubleChickenQuantLbl.Text = doubleChickenBurgerCount.ToString(); }; // - button
            addOrderDoubleChickenBtn.Click += (s, e) => AddToCart("Double Chicken Burger", 89.00m, ref doubleChickenBurgerCount, doubleChickenQuantLbl);

            // Navigation
            checkoutBtn.Click += (s, e) => {
                OrderReviewForm reviewForm = new OrderReviewForm();
                reviewForm.Show();
                this.Hide();
            };

            viewOrderDetailsLbl.Click += (s, e) => {
                ViewOrderDetailsForm detailsForm = new ViewOrderDetailsForm();
                detailsForm.ShowDialog(); // Show as modal
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

        private void pizzaSideBarBtn_Click(object sender, EventArgs e)
        {
            ProductSelectionPizzasForm form = new ProductSelectionPizzasForm();
            form.Show();
            this.Hide();
        }

        private void drinksSideBarBtn_Click(object sender, EventArgs e)
        {
            ProductSelectionDrinksForm form = new ProductSelectionDrinksForm();
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
