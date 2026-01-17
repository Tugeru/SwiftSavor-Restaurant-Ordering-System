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
    public partial class ProductSelectionPizzasForm : Form
    {
        private int pepperoniCount = 0;
        private int hawaiianCount = 0;
        private int mushroomCount = 0;

        public ProductSelectionPizzasForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            UpdateFooter();
            BindEvents();
        }

        private void BindEvents()
        {
            // Pepperoni Pizza
            addPepperoniQuantBtn.Click += (s, e) => { pepperoniCount++; pepperoniQuantLbl.Text = pepperoniCount.ToString(); };
            reducePepperoniQuantBtn.Click += (s, e) => { if (pepperoniCount > 0) pepperoniCount--; pepperoniQuantLbl.Text = pepperoniCount.ToString(); };
            addOrderPepperoniBtn.Click += (s, e) => AddToCart("Pepperoni Pizza", 149.00m, ref pepperoniCount, pepperoniQuantLbl);

            // Hawaiian Pizza
            addHawaiianQuantBtn.Click += (s, e) => { hawaiianCount++; hawaiianQuantLbl.Text = hawaiianCount.ToString(); };
            reduceHawaiianQuantBtn.Click += (s, e) => { if (hawaiianCount > 0) hawaiianCount--; hawaiianQuantLbl.Text = hawaiianCount.ToString(); };
            addOrderHawaiianBtn.Click += (s, e) => AddToCart("Hawaiian Pizza", 199.00m, ref hawaiianCount, hawaiianQuantLbl);

            // Mushroom Pizza
            addMushroomQuantBtn.Click += (s, e) => { mushroomCount++; mushroomQuantLbl.Text = mushroomCount.ToString(); };
            reduceMushroomQuantBtn.Click += (s, e) => { if (mushroomCount > 0) mushroomCount--; mushroomQuantLbl.Text = mushroomCount.ToString(); };
            addOrderMushroomBtn.Click += (s, e) => AddToCart("Mushroom Pizza", 249.00m, ref mushroomCount, mushroomQuantLbl);

            // Navigation
            checkoutBtn.Click += (s, e) => {
                if (OrderManager.GetTotalItems() == 0)
                {
                    MessageBox.Show("You have not added any order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MealTypeForm mealTypeForm = new MealTypeForm();
                mealTypeForm.Show();
                this.Hide();
            };

            viewOrderDetailsLbl.Click += (s, e) => {
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
            selectedItemsPrice.Text = $"₱ {OrderManager.GetSubtotal():N2}";
        }

        private void burgersSideBarBtn_Click(object sender, EventArgs e)
        {
            ProductSelectionBurgersForm form = new ProductSelectionBurgersForm();
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
