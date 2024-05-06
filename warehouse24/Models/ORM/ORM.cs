using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using warehouse24.Models.Classes;
using warehouse24.Models.Interfaces;

namespace warehouse24
{
    public class ORM
    {
        public readonly string cnnString = ConfigurationManager.ConnectionStrings["warehouse24.Properties.Settings.warehouse24ConnectionString"].ToString();

        public List<Goods> GetGoods()
        {
            List<Goods> list = new List<Goods>();

            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                cnn.Open();
                string request = "select id,name,cost,image from dbo.Goods ";
                SqlCommand cmd = new SqlCommand(request, cnn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        double cost = Convert.ToDouble(reader.GetValue(2));
                        byte[] imagebyte = (byte[])reader["image"];
                        MemoryStream mn = new MemoryStream(imagebyte);
                        Image image = Image.FromStream(mn);
                        Goods goods = new Goods(id, name, cost, image);
                        list.Add(goods);
                    }
                }


            }
            return list;
        }
        public List<Warehouse> GetWarehouse()
        {
            List<Warehouse> list = new List<Warehouse>();
            using (SqlConnection cnn = new SqlConnection( cnnString))
            {
                cnn.Open();
                string request = "selecte id , name ,  from dbo.Warehouse";
                SqlCommand cmd = new SqlCommand(request, cnn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        Warehouse warehouse = new Warehouse(id, name);
                        list.Add(warehouse);
                    }

                }
            }
            return list;
        }

        public List<Consumer> GetConsumer()

        {
            List<Consumer> list = new List<Consumer>();
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                cnn.Open();
                string request = "selecte id , name , image from dbo.Consumer";
                SqlCommand cmd = new SqlCommand(request, cnn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        Consumer consumer = new Consumer(id, name);
                        list.Add(consumer);

                    }
                }
            }

            return list;
        }
        public List<Supplier> GetSupplier()

        {
            List<Supplier> list = new List<Supplier>();
            using ( SqlConnection cnn = new SqlConnection( cnnString)) 
            {
                cnn.Open();
                string request = "select id, name from dbo.Supplier";
                SqlCommand cmd = new SqlCommand(request, cnn);
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows) 
                {
                    while (reader.Read()) 
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        Supplier supplier = new Supplier(id, name);
                        list.Add(supplier);
                    
                    }
                
                }
            
            }
            return list;
        
        }
        
        public List<Invoice> GetInvoicesList() 
        {
            List<Invoice> list = new List<Invoice>();
            FromWarehouse fromWarehouse = null;
            ToWarehouse toWarehouse = null;
            ToConsumer toConsumer = null;
            Shippment shippment = null;
            FromSupplier fromSupplier = null;

            using (SqlConnection cnn = new SqlConnection( cnnString)) 
            {
                cnn.Open() ;
                string request = "SELECT I.id,I.date,I.type_invo, W1.name AS from_warehouse_name," +
                                "W2.name AS to_warehouse_name," +
                                "S1.name As from_Supplier," +
                                "C1.name AS to_Consumer," +
                                "SH1.name As Shippment," +
                                "ShipCo.name As ShippmentCom" +
                                "FROM dbo.Invoices I" +
                                "INNER JOIN dbo.Warehouse W1 ON I.[from] = W1.id" +
                                "INNER JOIN dbo.Warehouse W2 ON I.[to] = W2.id" +
                                "INNER JOIN dbo.Consumer C1 ON I.[to] = C1.id" +
                                "INNER JOIN dbo.Supplier S1 ON I.[from] = S1.id" +
                                "INNER JOIN dbo.Shipment SH1 ON I.id_ship = SH1.id" +
                                "INNER JOIN dbo.[Shipment-co]  ShipCo ON SH1.id_com = ShipCo.id  ";

                SqlCommand cmd = new SqlCommand(request, cnn);  
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) 
                {
                    while (reader.Read())
                    
                    {
                        int id = reader.GetInt32(0);
                        DateTime date = reader.GetDateTime(1);
                        string type_invo = reader.GetString(2);
                        fromWarehouse.Name = reader.GetString(3);
                        toWarehouse.Name = reader.GetString(4);
                        fromSupplier.Name = reader.GetString(5);
                        toConsumer.Name = reader.GetString(6);
                        shippment.Name = reader.GetString(7);

                        
                        int id_ship = reader.GetInt32(5);
                        Invoice invoices = new Invoice(id,date,fromWarehouse,toWarehouse,toConsumer,fromSupplier,type_invo,shippment);
                        list.Add(invoices);

                    }
                
                }
            
            }
            return list;
        
        }

        public void AddWareHouse(string WareHouseName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cnnString))
                {
                    connection.Open();
                    string query = "INSERT INTO Warehouse (Name) VALUES (@Name)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", WareHouseName);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteWareHouse(string WareHouseName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cnnString))
                {
                    connection.Open();
                    string query = "DELETE FROM Warehouse WHERE Name = @Name";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", WareHouseName);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }  
   
}
    

