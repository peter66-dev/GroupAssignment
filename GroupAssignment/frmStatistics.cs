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
    public partial class frmStatistics : Form
    {
        IBillRepository billRepository = new BillRepository();
        BindingSource source;
        bool asc = true;


        public frmStatistics()
        {
            InitializeComponent();
        }

        void LoadListView(List<BillObject> list)
        {
            try
            {
                source = new BindingSource();
                decimal payment = 0;
                decimal income = 0;
                source.DataSource = list;
                foreach (var bill in list)
                {
                    payment += bill.Total;
                }

                txtMoney.Text = billRepository.GetTotalImportMoney().ToString();
                txtPayment.Text = Math.Round(payment, 2).ToString();
                income = decimal.Parse(txtMoney.Text) - payment;
                txtIncome.Text = Math.Round(income, 2).ToString();
                dgvStatisticsList.DataSource = null;
                dgvStatisticsList.DataSource = source;

                dgvStatisticsList.Columns["BillID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvStatisticsList.Columns["Date"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvStatisticsList.Columns["Total"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvStatisticsList.Columns["Status"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvStatisticsList.Columns["BillID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvStatisticsList.Columns["Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvStatisticsList.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvStatisticsList.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Load bill list");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadListView(billRepository.GetBillListByDate(dtkStart.Value, dtkEnd.Value));
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (asc) // nhỏ tới lớn
            {
                LoadListView(billRepository.SortByTotalAscending());
                asc = false;
            }
            else
            {
                LoadListView(billRepository.SortByTotalDescending());
                asc = true;
            }
        }
    }
}
