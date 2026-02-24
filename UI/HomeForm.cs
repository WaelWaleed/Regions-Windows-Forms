using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void ToCountriesFormButton_Click(object sender, EventArgs e)
        {
            using var form = new CountryForm();
            form.ShowDialog();
        }

        private void ToCitiesFormButton_Click(object sender, EventArgs e)
        {
            using var form = new CityForm();
            form.ShowDialog();
        }
    }
}
