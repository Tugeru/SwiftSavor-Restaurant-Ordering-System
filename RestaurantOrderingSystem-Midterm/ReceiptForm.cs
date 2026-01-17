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
    public partial class ReceiptForm : Form
    {
        public ReceiptForm()
        {
            InitializeComponent();
            LoadReceipt();
            startNewOrderBtn.Click += StartNewOrderBtn_Click;
        }

        private void LoadReceipt()
        {
            // Set Date/Time
            dateTimeLbl.Text = DateTime.Now.ToString("MMM dd, yyyy | h:mm tt").ToUpper();

            // Generate Random Order Number
            Random rnd = new Random();
            orderNumLbl.Text = $"ORDER # {rnd.Next(100, 999)}";

            // Clear designer junk
            receiptItemListFlowLayout.Controls.Clear();
            receiptPriceFlowLayout.Controls.Clear();
            // The designer seems to split item names and prices into two flow layouts.
            // We will stick to that structure to maintain the layout alignment.

            receiptItemListFlowLayout.Visible = true;
            receiptPriceFlowLayout.Visible = true;

            foreach (var item in OrderManager.Items)
            {
                // Item Name + Qty (e.g., "Classic Cheese Burger x2")
                Label nameLbl = new Label();
                nameLbl.Text = $"{item.Product.Name} x{item.Quantity}";
                nameLbl.AutoSize = true;
                nameLbl.Font = new Font("Segoe UI", 10);
                nameLbl.Margin = new Padding(0, 0, 0, 5);
                receiptItemListFlowLayout.Controls.Add(nameLbl);

                // Price
                Label priceLbl = new Label();
                priceLbl.Text = $"₱ {item.TotalPrice:N2}";
                priceLbl.AutoSize = true;
                priceLbl.Font = new Font("Segoe UI", 10);
                priceLbl.Margin = new Padding(0, 0, 0, 5);
                receiptPriceFlowLayout.Controls.Add(priceLbl);
            }

            // Calculations
            decimal subtotal = OrderManager.GetSubtotal();
            decimal bundleDiscount = OrderManager.GetBundleDiscount();
            decimal volumeDiscount = OrderManager.GetVolumeDiscount();
            decimal tax = OrderManager.GetTax();
            decimal grandTotal = OrderManager.GetGrandTotal();

            // Set Labels
            subtotalAmountLbl.Text = $"₱ {subtotal:N2}";

            // Bundle Discount
            if (bundleDiscount > 0)
            {
                comboDiscountLbl.Visible = true;
                discountAmountLbl.Visible = true;
                discountAmountLbl.Text = $"- ₱ {bundleDiscount:N2}";
            }
            else
            {
                comboDiscountLbl.Visible = false;
                discountAmountLbl.Visible = false;
            }

            // Volume Discount
            if (volumeDiscount > 0)
            {
                percentBasedDiscount.Visible = true;
                percentBasedDiscountAmountLbl.Visible = true;
                percentBasedDiscountAmountLbl.Text = $"- ₱ {volumeDiscount:N2}";
            }
            else
            {
                percentBasedDiscount.Visible = false;
                percentBasedDiscountAmountLbl.Visible = false;
            }

            // Tax
            receiptTaxLbl.Visible = true;
            taxAmountLbl.Visible = true;
            taxAmountLbl.Text = $"₱ {tax:N2}";

            receiptTotalOrderAmountLbl.Text = $"₱ {grandTotal:N2}";
        }

        private void StartNewOrderBtn_Click(object sender, EventArgs e)
        {
            OrderManager.ClearOrder();
            LandingForm landing = new LandingForm();
            landing.Show();
            this.Close();
        }

    }
}
