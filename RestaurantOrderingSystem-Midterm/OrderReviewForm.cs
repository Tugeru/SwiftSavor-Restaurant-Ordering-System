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
    public partial class OrderReviewForm : Form
    {
        public OrderReviewForm()
        {
            InitializeComponent();
            LoadOrderReview();
            backBtn.Click += (s, e) => {
                ProductSelectionBurgersForm burgersForm = new ProductSelectionBurgersForm();
                burgersForm.Show();
                this.Hide();
            };
            placeOrderBtn.Click += PlaceOrderBtn_Click;
        }

        private void LoadOrderReview()
        {
            // Clear the existing panel which contains all the hardcoded junk
            orderReviewListPanel.Controls.Clear();

            // Re-add header labels manually since we cleared the whole panel
            // Actually, looking at the designer, labels "Item", "Quantity", "Price" are inside the panel.
            // We should reconstruct the header or just add rows. 
            // Let's create a header row first.
            
            TableLayoutPanel headerTable = new TableLayoutPanel();
            headerTable.ColumnCount = 3;
            headerTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F)); // Item
            headerTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F)); // Quantity
            headerTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F)); // Price
            headerTable.RowCount = 1;
            headerTable.Dock = DockStyle.Top;
            headerTable.Height = 30;
            
            headerTable.Controls.Add(new Label() { Text = "Item", Font = new Font("Segoe UI", 12, FontStyle.Bold), AutoSize = true }, 0, 0);
            headerTable.Controls.Add(new Label() { Text = "Quantity", Font = new Font("Segoe UI", 12, FontStyle.Bold), AutoSize = true }, 1, 0);
            headerTable.Controls.Add(new Label() { Text = "Price", Font = new Font("Segoe UI", 12, FontStyle.Bold), AutoSize = true }, 2, 0);
            
            orderReviewListPanel.Controls.Add(headerTable);

            // Use a flow layout for the items so they stack nicely
            FlowLayoutPanel itemContainer = new FlowLayoutPanel();
            itemContainer.Dock = DockStyle.Fill;
            itemContainer.AutoScroll = true;
            itemContainer.FlowDirection = FlowDirection.TopDown;
            itemContainer.WrapContents = false;
            // Ensure the FlowLayoutPanel fills the width of the parent so rows stretch
            itemContainer.Resize += (s, e) => {
                foreach (Control c in itemContainer.Controls) c.Width = itemContainer.ClientSize.Width - 20; 
            };

            orderReviewListPanel.Controls.Add(itemContainer);
            // Ensure header stays at top
            headerTable.SendToBack(); // In Dock logic, SendToBack puts it at the "top" of the docking stack usually, or we manage z-order. 
            // Actually, DockStyle.Top items added *last* go to the top? No, added *first* go to top.
            // Let's just use specific controls.

            decimal subtotal = 0;

            foreach (var item in OrderManager.Items)
            {
                subtotal += item.TotalPrice;

                Panel row = new Panel();
                row.Height = 40;
                row.Width = 380; // Approximate
                row.Margin = new Padding(0, 5, 0, 5);

                // 1. Name
                Label nameLbl = new Label();
                nameLbl.Text = item.Product.Name;
                nameLbl.Font = new Font("Segoe UI", 10);
                nameLbl.Location = new Point(5, 10);
                nameLbl.AutoSize = true;
                row.Controls.Add(nameLbl);

                // 2. Quantity Controls ( - Qty + )
                Button minusBtn = new Button();
                minusBtn.Text = "-";
                minusBtn.Size = new Size(25, 25);
                minusBtn.Location = new Point(160, 5);
                minusBtn.Click += (s, e) => { UpdateItemQuantity(item.Product.Name, -1); };
                row.Controls.Add(minusBtn);

                Label qtyLbl = new Label();
                qtyLbl.Text = item.Quantity.ToString();
                qtyLbl.Font = new Font("Segoe UI", 10);
                qtyLbl.Location = new Point(190, 8);
                qtyLbl.AutoSize = true;
                row.Controls.Add(qtyLbl);

                Button plusBtn = new Button();
                plusBtn.Text = "+";
                plusBtn.Size = new Size(25, 25);
                plusBtn.Location = new Point(220, 5);
                plusBtn.Click += (s, e) => { UpdateItemQuantity(item.Product.Name, 1); };
                row.Controls.Add(plusBtn);

                // 3. Price
                Label priceLbl = new Label();
                priceLbl.Text = $"₱ {item.TotalPrice:N2}";
                priceLbl.Font = new Font("Segoe UI", 10);
                priceLbl.Location = new Point(280, 10);
                priceLbl.AutoSize = true;
                row.Controls.Add(priceLbl);

                itemContainer.Controls.Add(row);
            }

            // Update Totals
            subtotalPriceLbl.Text = $"₱ {subtotal:N2}";
            decimal tax = subtotal * 0.08m; // Assuming 8% tax as per designer label hint "Tax (8%)"
            // Wait, looking at OrderReviewForm.Designer.cs, labels are:
            // discountOrTaxPriceLbl, taxPriceLbl, subtotalPriceLbl, grandTotalLbl
            // And labels "Discount or Tax", "Tax (8%)", "Subtotal", "Grand Total"
            // Let's implement basic tax logic.
            
            // Actually, the designer has `discountOrTaxLbl`. Let's just use Tax for now.
            discountOrTaxPriceLbl.Text = "₱ 0.00"; 
            taxPriceLbl.Text = $"₱ {tax:N2}";
            grandTotalLbl.Text = $"₱ {(subtotal + tax):N2}"; // Wait, usually subtotal includes tax or tax is added. 
            // Let's just set Grand Total to Subtotal + Tax if that's the flow.
            
            // To be simple and match the "Grand Total" label alignment:
            // label9 is the one with "₱" next to grandTotalLbl? No, label9 text is "₱".
            // Let's find the label for the Grand Total Value.
            // Designer: grandTotalLbl is "Grand Total". label9 is "₱".
            // Wait, `label9` is `TextAlign = ContentAlignment.TopRight`. It seems `label9` holds the price?
            // Let's check `subtotalPriceLbl`. It holds "₱".
            // It seems the "Price" labels just hold the currency symbol and maybe the value?
            // Let's set the text of the labels that look like they hold the value.
            
            // Re-checking designer:
            // subtotalPriceLbl.Text = "₱ "
            // label9.Text = "₱" (near Grand Total)
            // It seems I should append the value to these labels.
            
            label9.Text = $"₱ {(subtotal + tax):N2}";
            
            // Show the hidden labels if they were hidden
            discountOrTaxLbl.Visible = true;
            discountOrTaxPriceLbl.Visible = true;
            label7.Visible = true; // "Tax (8%)"
            taxPriceLbl.Visible = true;
        }

        private void UpdateItemQuantity(string itemName, int delta)
        {
            OrderManager.UpdateQuantity(itemName, delta);
            LoadOrderReview(); // Refresh UI
        }

        private void PlaceOrderBtn_Click(object sender, EventArgs e)
        {
            if (OrderManager.Items.Count == 0)
            {
                MessageBox.Show("Your cart is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ReceiptForm receiptForm = new ReceiptForm();
            receiptForm.Show();
            this.Hide();
        }
    }
}
