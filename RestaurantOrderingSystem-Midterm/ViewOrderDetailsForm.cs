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
    public partial class ViewOrderDetailsForm : Form
    {
        public ViewOrderDetailsForm()
        {
            InitializeComponent();
            LoadOrderDetails();
            closeBtn.Click += (s, e) => this.Close();
        }

        private void LoadOrderDetails()
        {
            // Clear existing controls from the panel - wait, the designer has labels inside flow layouts inside the panel. 
            // To be safe and clean, we will clear the FlowLayoutPanels if we were using them, or just use the main panel.
            // The designer has `receiptItemListFlowLayout`, `flowLayoutPanel1` (quantity), and `receiptPriceFlowLayout`.
            // We will clear these specific flow layouts and populate them.

            receiptItemListFlowLayout.Controls.Clear();
            flowLayoutPanel1.Controls.Clear();
            receiptPriceFlowLayout.Controls.Clear();

            // Make them visible if they were hidden
            receiptItemListFlowLayout.Visible = true;
            flowLayoutPanel1.Visible = true;
            receiptPriceFlowLayout.Visible = true;

            decimal subtotal = 0;

            foreach (var item in OrderManager.Items)
            {
                // Item Name
                Label nameLabel = new Label();
                nameLabel.Text = item.Product.Name;
                nameLabel.AutoSize = true;
                nameLabel.Font = new Font("Segoe UI", 10F);
                nameLabel.Margin = new Padding(0, 0, 0, 10); // Spacing
                receiptItemListFlowLayout.Controls.Add(nameLabel);

                // Quantity
                Label quantLabel = new Label();
                quantLabel.Text = item.Quantity.ToString();
                quantLabel.AutoSize = true;
                quantLabel.Font = new Font("Segoe UI", 10F);
                quantLabel.Margin = new Padding(0, 0, 0, 10);
                flowLayoutPanel1.Controls.Add(quantLabel);

                // Price
                Label priceLabel = new Label();
                priceLabel.Text = $"₱ {item.TotalPrice:N2}";
                priceLabel.AutoSize = true;
                priceLabel.Font = new Font("Segoe UI", 10F);
                priceLabel.Margin = new Padding(0, 0, 0, 10);
                receiptPriceFlowLayout.Controls.Add(priceLabel);

                subtotal += item.TotalPrice;
            }

            subtotalPriceLbl.Text = $"₱ {subtotal:N2}";
        }
    }
}
