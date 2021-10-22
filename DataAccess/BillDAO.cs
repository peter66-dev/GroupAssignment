using Business_Object;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;

namespace DataAccess
{
    public class BillDAO
    {
        private static BillDAO instance = null;
        private static readonly object instanceLock = new object();
        private BillDAO()
        {

        }
        public static BillDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new BillDAO();
                    }
                    return instance;
                }
            }
        }

        static string GetConnectionString()
        {
            string connection = "";
            IConfiguration config = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("connectionString.json", true, true)
                                .Build();
            connection = config["ConnectionString:PetStoreDB"];
            return connection;
        }
        SqlConnection connection;
        SqlCommand command;
        public List<BillObject> GetBillList()
        {
            connection = new SqlConnection(GetConnectionString());
            List<BillObject> list = new List<BillObject>();
            command = new SqlCommand("select BillID, Total, Date, Status from tblBills", connection);
            try
            {
                connection.Open();
                SqlDataReader rs = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (rs.HasRows)
                {
                    while (rs.Read())
                    {
                        BillObject bill = new BillObject();
                        bill.BillID = rs.GetInt32("BillID");
                        bill.Total = Math.Round(rs.GetDecimal("Total"));
                        bill.Date = rs.GetDateTime("Date");
                        bill.Status = rs.GetBoolean("Status");
                        list.Add(bill);
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return list;
        }

        public BillObject GetBillByID(int id)
        {
            connection = new SqlConnection(GetConnectionString());
            BillObject bill = new BillObject();
            command = new SqlCommand("select Total, Date, Status from tblBills where BillID = @BillID", connection);
            command.Parameters.AddWithValue("@BillID", id);
            try
            {
                connection.Open();
                SqlDataReader rs = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (rs.HasRows)
                {
                    if (rs.Read())
                    {
                        bill.BillID = id;
                        bill.Total = rs.GetDecimal("Total");
                        bill.Date = rs.GetDateTime("Date");
                        bill.Status = rs.GetBoolean("Status");
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return bill;
        }

        public void InsertBill(int id, decimal total)// không nên để khóa chính tự tăng ở đây
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("Insert into tblBills (BillID, Total, Date, Status) " +
                "values(@BillID, @Total, getdate(), 1)", connection);
            command.Parameters.AddWithValue("@BillID", id);
            command.Parameters.AddWithValue("@Total", total);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void UpdateBill(int id, decimal total)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("update tblBills set Total = @Total where BillID = @BillID", connection);
            command.Parameters.AddWithValue("@Total", total);
            command.Parameters.AddWithValue("@BillID", id);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void RemoveBill(int id)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("update tblBills set Status = 0 where BillID = @BillID", connection);
            command.Parameters.AddWithValue("@BillID", id);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
