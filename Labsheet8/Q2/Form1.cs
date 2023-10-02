using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        Database db;
        AddressDetails details;
        public Form1()
        {
            InitializeComponent();
            db = new Database("Data Source=localhost\sqlexpress;Initial Catalog=AddressBook;Integrated Security=True");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            db.DeleteData(details);
        }

        private void UpdateAddressObj()
        {
            details = new AddressDetails
            {
                Name = txtName.Text,
                HouseName = txtHouseName.Text,
                City = txtCity.Text,
                HouseNumber = txtHnum.Text,
                Locality = txtLocality.Text,
                MobileNum = txtMNum.Text,
                Postoffice = txtPO.Text,
            };

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.AddData(details);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            db.EditData(details);
            txtName.Text = string.Empty;
            txtHouseName.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtHnum.Text = string.Empty;
            txtLocality.Text = string.Empty;
            txtMNum.Text = string.Empty;
            txtPO.Text = string.Empty;
        }
    }
}
