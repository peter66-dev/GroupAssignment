﻿using Business_Object;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformPetStore
{
    public partial class frmCustomerDetails : Form
    {
        public ICustomerRepository customerRepository { get; set; }
        public bool InsertOrUpdate;
        public CustomerObject CustomerInfo { get; set; }
        public frmCustomerDetails()
        {
            InitializeComponent();
        }
        private void frmCustomerDetails_Load(object sender, EventArgs e)
        {
            try
            {
                cboGender.SelectedIndex = 0;
                if (InsertOrUpdate) // update
                {
                    txtCusID.Text = CustomerInfo.CustomerID.ToString();
                    txtCusName.Text = CustomerInfo.CustomerName;
                    txtEmail.Text = CustomerInfo.Email;
                    txtPhone.Text = CustomerInfo.Phone;
                    cboGender.Text = CustomerInfo.Gender ? "Male" : "Female";
                    txtAddress.Text = CustomerInfo.Address;
                    txtPoint.Text = CustomerInfo.AccumulatedPoint.ToString();
                }
                else
                {
                    txtCusID.Text = "xxx";
                }
            }
            catch (Exception ex)
            {

            }
        }
        private bool CheckForm()
        {
            bool check = true;
            try
            {
                if (txtCusName.Text.Trim().Length == 0)
                {
                    txtCusName.Focus();
                    MessageBox.Show("Sorry, you must full fill in customer name field please!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    check = false;
                }
                else if (!(txtEmail.Text.Contains("@gmail.com") || txtEmail.Text.Contains("@fpt.edu.vn")))
                {
                    txtEmail.Focus();
                    MessageBox.Show("Sorry, email must be xxx@gmail.com or xxx@fpt.edu.vn.\n" +
                        "Please, try again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    check = false;
                }
                else if (!(cboGender.Text.Equals("female", StringComparison.OrdinalIgnoreCase) ||
                    cboGender.Text.Equals("male", StringComparison.OrdinalIgnoreCase)))
                {
                    cboGender.Focus();
                    MessageBox.Show("Sorry, gender must be Male or Female please!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    check = false;
                }
                else if (!(txtPhone.Text.Trim().Length >= 10 && txtPhone.Text.Trim().Length <= 12 && decimal.Parse(txtPhone.Text) > 0))
                {
                    txtPhone.Focus();
                    MessageBox.Show("Sorry, phone must have [10-12] numbers please!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    check = false;
                }
                else if (txtAddress.Text.Trim().Length < 10)
                {
                    txtAddress.Focus();
                    MessageBox.Show("Sorry, address is not enough information. Give me more, please!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    check = false;
                }
                else if (Decimal.ToInt32(txtPoint.Value) < 0)
                {
                    txtPoint.Focus();
                    MessageBox.Show("Sorry, accumulated point must be more 0 please!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    check = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry, data input is not valid. Check again, please! " + ex.Message,
                    "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return check;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckForm())
                {
                    if (InsertOrUpdate) // update
                    {
                        CustomerObject cus = new CustomerObject();
                        cus.CustomerID = int.Parse(txtCusID.Text);
                        cus.CustomerName = txtCusName.Text.Trim();
                        cus.Gender = cboGender.Text.Equals("male", StringComparison.OrdinalIgnoreCase) ? true : false;
                        cus.Phone = txtPhone.Text.Trim();
                        cus.Email = txtEmail.Text.Trim();
                        cus.Address = txtAddress.Text.Trim();
                        cus.AccumulatedPoint = Decimal.ToInt32(txtPoint.Value);
                        cus.Status = true;
                        customerRepository.UpdateCustomer(cus);
                        MessageBox.Show("Updating a customer successfully!\n" +
                            "Load again to see new list!", "Message", MessageBoxButtons.OK);
                        Close();
                    }
                    else
                    {
                        CustomerObject cus = new CustomerObject();
                        cus.CustomerID = 0;
                        cus.CustomerName = txtCusName.Text.Trim();
                        cus.Gender = cboGender.Text.Equals("male", StringComparison.OrdinalIgnoreCase) ? true : false;
                        cus.Phone = txtPhone.Text.Trim();
                        cus.Email = txtEmail.Text.Trim();
                        cus.Address = txtAddress.Text.Trim();
                        cus.AccumulatedPoint = Decimal.ToInt32(txtPoint.Value);
                        cus.Status = true;
                        customerRepository.InsertCustomer(cus);
                        MessageBox.Show("Adding a new customer successfully!\n" +
                            "Load again to see new list!", "Message", MessageBoxButtons.OK);
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adding a new customer failed! Check all information again, please! " + ex.Message,
                    "Customer information", MessageBoxButtons.OK);
            }

        }

        private void frmCustomerDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to quit?", "Message", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
