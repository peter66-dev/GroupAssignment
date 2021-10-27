﻿
namespace WinformPetStore
{
    partial class frmStatistics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTotalPayment = new System.Windows.Forms.Label();
            this.dgvStatisticsList = new System.Windows.Forms.DataGridView();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.dtkStart = new System.Windows.Forms.DateTimePicker();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.dtkEnd = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbTotalMoney = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.lbIncome = new System.Windows.Forms.Label();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatisticsList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTotalPayment
            // 
            this.lbTotalPayment.AutoSize = true;
            this.lbTotalPayment.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTotalPayment.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbTotalPayment.Location = new System.Drawing.Point(12, 79);
            this.lbTotalPayment.Name = "lbTotalPayment";
            this.lbTotalPayment.Size = new System.Drawing.Size(82, 15);
            this.lbTotalPayment.TabIndex = 1003;
            this.lbTotalPayment.Text = "Total payment";
            // 
            // dgvStatisticsList
            // 
            this.dgvStatisticsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatisticsList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvStatisticsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatisticsList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvStatisticsList.Enabled = false;
            this.dgvStatisticsList.Location = new System.Drawing.Point(0, 169);
            this.dgvStatisticsList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvStatisticsList.Name = "dgvStatisticsList";
            this.dgvStatisticsList.RowHeadersWidth = 51;
            this.dgvStatisticsList.RowTemplate.Height = 25;
            this.dgvStatisticsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStatisticsList.Size = new System.Drawing.Size(959, 392);
            this.dgvStatisticsList.TabIndex = 1021;
            // 
            // txtPayment
            // 
            this.txtPayment.Enabled = false;
            this.txtPayment.Location = new System.Drawing.Point(125, 76);
            this.txtPayment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(167, 22);
            this.txtPayment.TabIndex = 1022;
            this.txtPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbStartDate
            // 
            this.lbStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbStartDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbStartDate.Location = new System.Drawing.Point(334, 21);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(60, 15);
            this.lbStartDate.TabIndex = 1023;
            this.lbStartDate.Text = "Start date";
            // 
            // dtkStart
            // 
            this.dtkStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtkStart.Location = new System.Drawing.Point(418, 15);
            this.dtkStart.Name = "dtkStart";
            this.dtkStart.Size = new System.Drawing.Size(250, 22);
            this.dtkStart.TabIndex = 1024;
            // 
            // lbEndDate
            // 
            this.lbEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEndDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbEndDate.Location = new System.Drawing.Point(334, 79);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(52, 15);
            this.lbEndDate.TabIndex = 1025;
            this.lbEndDate.Text = "End date";
            // 
            // dtkEnd
            // 
            this.dtkEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtkEnd.Location = new System.Drawing.Point(418, 73);
            this.dtkEnd.Name = "dtkEnd";
            this.dtkEnd.Size = new System.Drawing.Size(250, 22);
            this.dtkEnd.TabIndex = 1026;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BackColor = System.Drawing.Color.DarkGray;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(418, 115);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 46);
            this.btnSearch.TabIndex = 1027;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbTotalMoney
            // 
            this.lbTotalMoney.AutoSize = true;
            this.lbTotalMoney.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTotalMoney.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbTotalMoney.Location = new System.Drawing.Point(12, 21);
            this.lbTotalMoney.Name = "lbTotalMoney";
            this.lbTotalMoney.Size = new System.Drawing.Size(72, 15);
            this.lbTotalMoney.TabIndex = 1028;
            this.lbTotalMoney.Text = "Total money";
            // 
            // txtMoney
            // 
            this.txtMoney.Enabled = false;
            this.txtMoney.Location = new System.Drawing.Point(125, 18);
            this.txtMoney.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(166, 22);
            this.txtMoney.TabIndex = 1029;
            this.txtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbIncome
            // 
            this.lbIncome.AutoSize = true;
            this.lbIncome.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbIncome.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbIncome.Location = new System.Drawing.Point(12, 139);
            this.lbIncome.Name = "lbIncome";
            this.lbIncome.Size = new System.Drawing.Size(76, 15);
            this.lbIncome.TabIndex = 1030;
            this.lbIncome.Text = "Total income";
            // 
            // txtIncome
            // 
            this.txtIncome.Enabled = false;
            this.txtIncome.Location = new System.Drawing.Point(125, 136);
            this.txtIncome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(166, 22);
            this.txtIncome.TabIndex = 1031;
            this.txtIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSort
            // 
            this.btnSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSort.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSort.Location = new System.Drawing.Point(832, 115);
            this.btnSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(115, 46);
            this.btnSort.TabIndex = 1032;
            this.btnSort.Text = "SORT BY TOTAL";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(297, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 1033;
            this.label1.Text = "(VND)";
            // 
            // frmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(959, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.txtIncome);
            this.Controls.Add(this.lbIncome);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.lbTotalMoney);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtkEnd);
            this.Controls.Add(this.lbEndDate);
            this.Controls.Add(this.dtkStart);
            this.Controls.Add(this.lbStartDate);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.dgvStatisticsList);
            this.Controls.Add(this.lbTotalPayment);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(975, 600);
            this.Name = "frmStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatisticsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTotalPayment;
        private System.Windows.Forms.DataGridView dgvStatisticsList;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.DateTimePicker dtkStart;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.DateTimePicker dtkEnd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbTotalMoney;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label lbIncome;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label label1;
    }
}