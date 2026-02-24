using BAL.Services;
using DAL.Database;
using DAL.Models.Cities;
namespace UI
{
    public partial class CityForm : Form
    {
        public CityForm()
        {
            InitializeComponent();

            dgvCities.CellClick += dgvCities_CellClick;

            LoadCities();
        }

        private void CreateCityButton_Click(object sender, EventArgs e)
        {
            var cityEditForm = new CityEditForm();

            if (cityEditForm.ShowDialog() == DialogResult.OK)
            {
                LoadCities();
            }
        }

        private void LoadCities()
        {
            var service = new CityService();

            var cities = service.GetAll();

            dgvCities.DataSource = cities;

            if (dgvCities.Columns["CountryId"] is not null)
                dgvCities.Columns["CountryId"].Visible = false;

            if (!dgvCities.Columns.Contains("Update"))
            {
                var updateButton = new DataGridViewButtonColumn();

                updateButton.Text = "Update";
                updateButton.Name = "Update";
                updateButton.UseColumnTextForButtonValue = true;

                dgvCities.Columns.Add(updateButton);
            }

            if (!dgvCities.Columns.Contains("Delete"))
            {
                var deleteButton = new DataGridViewButtonColumn();

                deleteButton.Text = "Delete";
                deleteButton.Name = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;

                dgvCities.Columns.Add(deleteButton);
            }
        }

        private void dgvCities_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var cityVm = (CitiesViewModel)dgvCities.Rows[e.RowIndex].DataBoundItem;
            var city = new City();

            city.Name = cityVm.Name;
            city.Id = cityVm.Id;
            city.CountryId = cityVm.CountryId;

            switch (dgvCities.Columns[e.ColumnIndex].Name)
            {
                case "Update":
                    var form = new CityEditForm(city);
                    if (form.ShowDialog() == DialogResult.OK)
                        LoadCities();
                    break;
                case "Delete":
                    var confirm = MessageBox.Show($"Are you sure you want to delete '{city.Name}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        var service = new CityService();
                        var result = service.Delete(city.Id);
                        MessageBox.Show($"{result.Message}");
                        LoadCities();
                    }
                    break;
            }
        }
    }
}
