namespace RestaurantOrderingSystem_Midterm

{
    public partial class LandingForm : Form
    {
        public LandingForm()
        {
            InitializeComponent();
        }
        private void touchStartBtn_Click(object sender, EventArgs e)
        {
            ProductSelectionBurgersForm productSelectionBurgersForm = new ProductSelectionBurgersForm();

            productSelectionBurgersForm.Show();
            this.Hide();
        }

        private void dineInBtn_Click(object sender, EventArgs e)
        {
            ProductSelectionBurgersForm productSelectionBurgersForm = new ProductSelectionBurgersForm();

            productSelectionBurgersForm.Show();
            this.Hide();

        }

        private void takeOutButton_Click(object sender, EventArgs e)
        {
            ProductSelectionBurgersForm productSelectionBurgersForm = new ProductSelectionBurgersForm();

            productSelectionBurgersForm.Show();
            this.Hide();

        }
    }
}
