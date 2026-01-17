namespace RestaurantOrderingSystem_Midterm

{
    public partial class LandingForm : Form
    {
        public LandingForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void touchStartBtn_Click(object sender, EventArgs e)
        {
            ProductSelectionBurgersForm productSelectionBurgersForm = new ProductSelectionBurgersForm();

            productSelectionBurgersForm.Show();
            this.Hide();
        }

        private void dineInBtn_Click(object sender, EventArgs e)
        {
            OrderManager.MealType = "Dine In";
            ProductSelectionBurgersForm productSelectionBurgersForm = new ProductSelectionBurgersForm();

            productSelectionBurgersForm.Show();
            this.Hide();

        }

        private void takeOutButton_Click(object sender, EventArgs e)
        {
            OrderManager.MealType = "Take Out";
            ProductSelectionBurgersForm productSelectionBurgersForm = new ProductSelectionBurgersForm();

            productSelectionBurgersForm.Show();
            this.Hide();

        }
    }
}
