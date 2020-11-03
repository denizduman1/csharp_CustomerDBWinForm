using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _customerService = new CustomerManager(new EFCustomerDal());
            _cityService = new CITY_DISTRICTManager(new EfCITY_DISTRICTDal());
        }

        ICustomerService _customerService;
        ICITY_DISTRICTService _cityService;
        private void LoadCustomer()
        {
            dgwCustomer.DataSource = _customerService.GetAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCustomer();
            CityTownCbxLoad();
        }

        private void CityTownCbxLoad()
        {
            cbxCity.DataSource = _cityService.GetCity();
            cbxCity.DisplayMember = "CITY";
            cbxUpdCity.DataSource = _cityService.GetCity();
            cbxUpdCity.DisplayMember = "CITY";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _customerService.AddCustomer(new Customer
            {
                NAMESURNAME = tbxNameSurname.Text,
                GENDER = tbxGender.Text,
                BIRTHDATE = Convert.ToDateTime(tbxBirthdate.Text),
                CITY = cbxCity.Text,
                TELNR = tbxPhoneCode.Text,
                TOWN = cbxTown.Text,
            });
            MessageBox.Show("CUSTOMER ADDED");
            LoadCustomer();
        }

        private void cbxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbxTown.DataSource = _cityService.GetTown(cbxCity.Text);
                cbxTown.DisplayMember = "TOWN";
                cbxTown.ValueMember = "TOWN";
            }
            catch (Exception)
            {
            }
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _customerService.Updated(new Customer
            {
                ID = Convert.ToInt32(dgwCustomer.CurrentRow.Cells[0].Value),
                NAMESURNAME = tbxUpdName.Text,
                GENDER = tbxUpdGender.Text,
                BIRTHDATE = Convert.ToDateTime(tbxUpdBirt.Text),
                CITY = cbxUpdCity.Text,
                TELNR = tbxUpdPhone.Text,
                TOWN = cbxUpdTown.Text,
            });
            MessageBox.Show("CUSTOMER UPDATED");
            LoadCustomer();
        }

        private void dgwCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwCustomer.CurrentRow;
            tbxUpdName.Text = row.Cells[1].Value.ToString();
            tbxUpdGender.Text = row.Cells[2].Value.ToString();
            tbxUpdBirt.Text = row.Cells[3].Value.ToString();
            cbxUpdCity.Text = row.Cells[4].Value.ToString();
            cbxUpdTown.Text = row.Cells[5].Value.ToString();
            tbxUpdPhone.Text = row.Cells[6].Value.ToString();
        }

        private void cbxUpdCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbxUpdTown.DataSource = _cityService.GetTown(cbxUpdCity.Text);
                cbxUpdTown.DisplayMember = "TOWN";
                cbxUpdTown.ValueMember = "TOWN";
            }
            catch (Exception)
            {


            }

        }
        private void tbxSearchName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxSearchName.Text))
            {
                dgwCustomer.DataSource = _customerService.GetCustomerSearch(tbxSearchName.Text);
            }
            else
            {
                LoadCustomer();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgwCustomer.CurrentRow != null)
                {
                    _customerService.Delete(
                  new Customer
                  {
                      ID = Convert.ToInt32(dgwCustomer.CurrentRow.Cells[0].Value),
                  }
                  );
                    MessageBox.Show("Customer Deleted");
                    LoadCustomer();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Hata.");
            }

            
        }
    }
}
