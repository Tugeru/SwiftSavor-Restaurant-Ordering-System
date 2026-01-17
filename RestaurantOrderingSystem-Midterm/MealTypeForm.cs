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
    public partial class MealTypeForm : Form
    {
        public MealTypeForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            ProductSelectionBurgersForm burgersForm = new ProductSelectionBurgersForm();
            burgersForm.Show();
            this.Hide();
        }

        private void dineInBtn_Click(object sender, EventArgs e)
        {
            SetMealTypeAndProceed("Dine In");
        }

        private void takeOutButton_Click(object sender, EventArgs e)
        {
            SetMealTypeAndProceed("Take Out");
        }

        private void SetMealTypeAndProceed(string type)
        {
            OrderManager.MealType = type;
            OrderReviewForm reviewForm = new OrderReviewForm();
            reviewForm.Show();
            this.Hide();
        }
    }
}
