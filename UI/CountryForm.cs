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
    public partial class CountryForm : Form
    {
        public CountryForm()
        {
            InitializeComponent();

            dgvCountries.CellClick += dgvCountries_CellClick;

            LoadCountries();
        }

        private void LoadCountries()
        {
            var service = new CountryService();

            var countries = service.GetAll();

            dgvCountries.DataSource = countries;

            if (!dgvCountries.Columns.Contains("Update"))
            {
                var updateButton = new DataGridViewButtonColumn();

                updateButton.Name = "Update";
                updateButton.Text = "Update";
                updateButton.UseColumnTextForButtonValue = true;

                dgvCountries.Columns.Add(updateButton);
            }
            if (!dgvCountries.Columns.Contains("Delete"))
            {
                var delteButton = new DataGridViewButtonColumn();

                delteButton.Name = "Delete";
                delteButton.Text = "Delete";
                delteButton.UseColumnTextForButtonValue = true;

                dgvCountries.Columns.Add(delteButton);
            }
        }

        private void CreateCountryButton_Click(object sender, EventArgs e)
        {
            var form = new CountryEditForm();
            if (form.ShowDialog() == DialogResult.OK) 
            {
                LoadCountries();
            }
        }

        private void dgvCountries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var country = (Country)dgvCountries.Rows[e.RowIndex].DataBoundItem;

            switch (dgvCountries.Columns[e.ColumnIndex].Name)
            {
                case "Update":
                    var form = new CountryEditForm(country);
                    if (form.ShowDialog() == DialogResult.OK)
                        LoadCountries();
                    break;
                case "Delete":
                    var confirm = MessageBox.Show($"Are you sure you want to delete '{country.Name}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes) 
                    {
                        var service = new CountryService();
                        DbResult result = service.Delete(country.Id);

                        MessageBox.Show(result.Message);

                        LoadCountries();
                    }
                    break;
            }
        }
    }
}
