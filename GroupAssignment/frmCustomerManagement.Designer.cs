
namespace WinformPetStore
{
    partial class frmCustomerManagement
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
            this.dgvStatisticsList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatisticsList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStatisticsList
            // 
            this.dgvStatisticsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatisticsList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvStatisticsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatisticsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStatisticsList.Enabled = false;
            this.dgvStatisticsList.Location = new System.Drawing.Point(0, 0);
            this.dgvStatisticsList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvStatisticsList.Name = "dgvStatisticsList";
            this.dgvStatisticsList.RowHeadersWidth = 51;
            this.dgvStatisticsList.RowTemplate.Height = 25;
            this.dgvStatisticsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStatisticsList.Size = new System.Drawing.Size(959, 561);
            this.dgvStatisticsList.TabIndex = 1021;
            // 
            // frmCustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(959, 561);
            this.Controls.Add(this.dgvStatisticsList);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(975, 600);
            this.Name = "frmCustomerManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.frmCustomerManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatisticsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvStatisticsList;
    }
}