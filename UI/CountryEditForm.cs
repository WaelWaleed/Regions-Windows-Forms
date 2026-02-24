using BAL.Services;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class CountryEditForm : Form
    {
        private Guid? _countryId = null;
        public CountryEditForm()
        {
            InitializeComponent();
        }

        public CountryEditForm(Country country) : this() 
        {
            _countryId = country.Id;
            CountryName.Text = country.Name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var name = CountryName.Text.Trim();
            if (string.IsNullOrEmpty(name)) 
            {
                MessageBox.Show("Please Enter a Country Name.");
                return;
            }

            var service = new CountryService();

            if (_countryId is null)
            {
                var result = service.Insert(name);
                MessageBox.Show(result.Message);
            }
            else
            {
                var result = service.Update(_countryId.Value, name);
                MessageBox.Show(result.Message);
            }


            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
