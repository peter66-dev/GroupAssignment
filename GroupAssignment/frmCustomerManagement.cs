using System;
using Business_Object;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
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
    public partial class frmCustomerManagement : Form
    {
        ICustomerRepository cusRepository = new CustomerRepository();
        BindingSource source = new BindingSource();
        IEnumerable<CustomerObject> customers = new List<CustomerObject>();
        bool asc = true;
        public frmCustomerManagement()
        {
            InitializeComponent();
        }

        private void frmCustomerManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnSort.Enabled = false;
        }
        private void ClearText()
        {
            txtCusID.Clear();
            txtCusName.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            cboGender.Text = string.Empty;
            txtPhone.Clear();
            txtStatus.Clear();
            txtPoint.Clear();
        }
        private void LoadCustomerList(IEnumerable<CustomerObject> list)
        {
            try
            {
                if (list.Count() == 0)
                {
                    ClearText();
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSort.Enabled = false;
                    MessageBox.Show("Sorry, we can't show result you want!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (list.Count() == 1)
                {
                    btnDelete.Enabled = false;
                    btnSort.Enabled = false;
                    dgvCustomerList.Rows.Clear();
                    CustomerObject cus = list.ElementAt(0);
                    string gender = cus.Gender ? "Male" : " Female";
                    string status = cus.Status ? "Actived" : "Deactived";
                    dgvCustomerList.Rows.Add(cus.CustomerID, cus.CustomerName, gender, cus.Email, cus.Phone, cus.Address, cus.AccumulatedPoint, status);
                }
                else
                {
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnSort.Enabled = true;
                    dgvCustomerList.Rows.Clear();
                    foreach (var cus in list)
                    {
                        string gender = cus.Gender ? "Male" : " Female";
                        string status = cus.Status ? "Actived" : "Deactived";
                        dgvCustomerList.Rows.Add(cus.CustomerID, cus.CustomerName, gender, cus.Email, cus.Phone, cus.Address, cus.AccumulatedPoint, status);
                    }
                }
                source.DataSource = list;
                ClearText();

                txtCusID.DataBindings.Add("Text", source, "CustomerID");
                txtCusName.DataBindings.Add("Text", source, "CustomerName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtAddress.DataBindings.Add("Text", source, "Address");
                txtPhone.DataBindings.Add("Text", source, "Phone");
                txtStatus.DataBindings.Add("Text", source, "Status");
                txtPoint.DataBindings.Add("Text", source, "AccumulatedPoint");
                cboGender.DataBindings.Add("Text", source, "Gender");

                dgvCustomerList.Columns["CustomerID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCustomerList.Columns["CustomerName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCustomerList.Columns["Address"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvCustomerList.Columns["Phone"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvCustomerList.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCustomerList.Columns["AccumulatedPoint"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCustomerList.Columns["Gender"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCustomerList.Columns["Email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvCustomerList.Columns["CustomerID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCustomerList.Columns["CustomerName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvCustomerList.Columns["Email"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvCustomerList.Columns["Address"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvCustomerList.Columns["Phone"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvCustomerList.Columns["Status"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCustomerList.Columns["AccumulatedPoint"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCustomerList.Columns["Gender"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvCustomerList.Columns["CustomerID"].ReadOnly = true;
                dgvCustomerList.Columns["CustomerName"].ReadOnly = true;
                dgvCustomerList.Columns["Email"].ReadOnly = true;
                dgvCustomerList.Columns["Address"].ReadOnly = true;
                dgvCustomerList.Columns["Phone"].ReadOnly = true;
                dgvCustomerList.Columns["Status"].ReadOnly = true;
                dgvCustomerList.Columns["AccumulatedPoint"].ReadOnly = true;
                dgvCustomerList.Columns["Gender"].ReadOnly = true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Load member list", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private CustomerObject GetCustomerObject()
        {
            CustomerObject cus = null;
            try
            {
                cus = new CustomerObject
                {
                    CustomerID = int.Parse(txtCusID.Text),
                    CustomerName = txtCusName.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text,
                    Address = txtAddress.Text,
                    Status = bool.Parse(txtStatus.Text),
                    Gender = cboGender.SelectedItem.Equals("Male") ? true : false,
                    AccumulatedPoint = int.Parse(txtPoint.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member Object", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return cus;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtEmailSearch.Clear();
            customers = cusRepository.GetCustomerList();
            LoadCustomerList(customers);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var cus = GetCustomerObject();
            if (MessageBox.Show($"Are you sure to delete member name: {cus.Email}?", "Confirm message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (cusRepository.GetCustomerForeignKey(cus.CustomerID).CustomerID == 0) // Không bị ảnh hưởng khóa ngoại với bảng Order
                {
                    try
                    {
                        source.Position = 0;
                        cusRepository.DeleteCustomer(cus.CustomerID);
                        customers = cusRepository.GetCustomerList();
                        LoadCustomerList(customers);
                        if (cusRepository.GetCustomerList().Count() == 1)
                        {
                            btnDelete.Enabled = false;
                            MessageBox.Show("We have only 1 customer existing in list, now. Please don't remove it!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Delete a customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Can delete this Customer because it's foreign key of Order table in sql server!",
                                        "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // KHÔNG CHO DELETE VÌ MEMBER ĐANG LÀM KHÓA NGOẠI BÊN ORDER
                }

            }
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            txtEmailSearch.Clear();
            if (asc)
            {
                LoadCustomerList(cusRepository.SortCustomerAscendingName());
            }
            else
            {
                LoadCustomerList(cusRepository.SortCustomerDescendingName());
            }
            asc = !asc;
        }
        private void txtEmailSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim().Length != 0)
            {
                List<CustomerObject> list = cusRepository.GetCustomerByEmail(txtEmail.Text.Trim());
                if (list.Count == 0)
                {
                    MessageBox.Show("Sorry, we can't find this customer is system!\nPlease, try again", "Message", MessageBoxButtons.OK);
                }
                else
                {
                    LoadCustomerList(list);
                }
            }
        }
    }
}
