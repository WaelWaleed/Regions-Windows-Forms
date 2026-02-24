using BAL.Services;
using DAL.Models.Cities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class CityEditForm : Form
    {
        private Guid? _cityId = null;

        public CityEditForm()
        {
            InitializeComponent();
            LoadCountries();
        }

        public CityEditForm(City city) : this()
        {
            _cityId = city.Id;
            CityNameInput.Text = city.Name;
            CountriesDropdownList.SelectedValue = city.CountryId;
        }

        private void LoadCountries()
        {
            var service = new CountryService();
            var countries = service.GetAll();

            CountriesDropdownList.DataSource = countries;
            CountriesDropdownList.DisplayMember = "Name";
            CountriesDropdownList.ValueMember = "Id";
        }

        private void CitySaveButton_Click(object sender, EventArgs e)
        {
            var name = CityNameInput.Text.Trim();
            if (string.IsNullOrEmpty(name))
                return;

            var countryId = (Guid)CountriesDropdownList.SelectedValue;
            if(string.IsNullOrEmpty(countryId.ToString()))
                return;

            var service = new CityService();
            
            if(_cityId is null)
            {
                var result = service.Insert(name, countryId);
                MessageBox.Show($"{result.Message}");
            }
            else
            {
                var result = service.Update(_cityId.Value, name, countryId);
                MessageBox.Show($"{result.Message}");
            }


            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
