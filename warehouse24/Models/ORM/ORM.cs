using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using warehouse24.Models.Classes;
using static System.Windows.Forms.LinkLabel;

namespace warehouse24.Models.ORM
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
            using (SqlConnection cnn = new SqlConnection(cnnString))
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
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                cnn.Open();
                string request = "select id, name from dbo.Supplier";
                SqlCommand cmd = new SqlCommand(request, cnn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
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

            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                cnn.Open();
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

        public void EditWarehouse(int idWarehouse, string newName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cnnString))
                {
                    connection.Open();
                    string query = "UPDATE Warehouse SET Name = @NewName WHERE id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", idWarehouse);
                        command.Parameters.AddWithValue("@NewName", newName);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AddConsumer(string consumerName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cnnString))
                {
                    connection.Open();
                    string query = "INSERT INTO Consumer (Name) VALUES (@Name)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", consumerName);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteConsumer(string consumerName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cnnString))
                {
                    connection.Open();
                    string query = "DELETE FROM Consumer WHERE Name = @Name";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", consumerName);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void EditConsumer(int idconsumer, string newName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cnnString))
                {
                    connection.Open();
                    string query = "UPDATE Consumer SET Name = @NewName WHERE id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", idconsumer);
                        command.Parameters.AddWithValue("@NewName", newName);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AddGoods(string goodsName, decimal goodsCost)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cnnString))
                {
                    connection.Open();
                    string query = "INSERT INTO Goods (Name, Cost) VALUES (@Name, @Cost)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", goodsName);
                        command.Parameters.AddWithValue("@Cost", goodsCost);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteGoods(string goodsName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cnnString))
                {
                    connection.Open();
                    string query = "DELETE FROM Goods WHERE Name = @Name";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", goodsName);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void EditGoods(int idgoods, string newName, float newCost)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cnnString))
                {
                    connection.Open();
                    string query = "UPDATE Goods SET Name = @NewName, Cost = @NewCost WHERE id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", idgoods);
                        command.Parameters.AddWithValue("@NewName", newName);
                        command.Parameters.AddWithValue("@NewCost", newCost);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AddShipmentCompany(string shipmentcompanyName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cnnString))
                {
                    connection.Open();
                    string query = "INSERT INTO ShipmentCompany (Name) VALUES (@Name)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", shipmentcompanyName);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteShipmentCompany(string shipmentcompanyName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cnnString))
                {
                    connection.Open();
                    string query = "DELETE FROM Shipment Company WHERE Name = @Name";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", shipmentcompanyName);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void EditShipmentCompany(int idshipmentcompany, string newName)

        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cnnString))
                {
                    connection.Open();
                    string query = "UPDATE Warehouse SET Name = @NewName WHERE id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", idshipmentcompany);
                        command.Parameters.AddWithValue("@NewName", newName);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AddShippment(string shippmentName, float tarrif, float cost, DateTime time)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cnnString))
                {
                    connection.Open();
                    string query = "INSERT INTO Shippment (Name, Id_com, Tariff, Time, Cost) VALUES (@Name, @Id_com)" +
                        "(@Tariff, @Time, @Cost)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", shippmentName);
                        command.Parameters.AddWithValue("@Id_com", shippmentName);
                        command.Parameters.AddWithValue("@Tariff", shippmentName);
                        command.Parameters.AddWithValue("@Time", shippmentName);
                        command.Parameters.AddWithValue("@Cost", shippmentName);




                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteShippment(string shippmentName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cnnString))
                {
                    connection.Open();
                    string query = "DELETE FROM Shippment WHERE Name = @Name";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", shippmentName);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void EditShippment(int idshippment, string newName, float newtariff, float newcost, DateTime newtime, int newIdCom)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cnnString))
                {
                    connection.Open();
                    string query = @"
                            UPDATE Shippment
                            SET Name = @NewName,
                                tariff = @NewTariff,
                                time = @NewTime,
                                cost = @NewCost,
                                id_com = @NewId_com
                            WHERE id = @Id
                            ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", idshippment);
                        command.Parameters.AddWithValue("@NewName", newName);
                        command.Parameters.AddWithValue("@NewId_com", newIdCom);
                        command.Parameters.AddWithValue("@NewTariff", newtariff);
                        command.Parameters.AddWithValue("@NewCost", newcost);
                        command.Parameters.AddWithValue("@NewTime", newtime);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AddSupplier(string supplierName, string filePath)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cnnString))
                {
                    connection.Open();
                    string query = "INSERT INTO Supplier (Name, Photo) VALUES (@Name, @Photo)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", supplierName);
                        command.Parameters.AddWithValue("@Photo", GetImageBytes(filePath)); // Convert image to byte array

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private byte[] GetImageBytes(string filePath)
        {
            using (Image image = Image.FromFile(filePath))
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, image.RawFormat);
                return memoryStream.ToArray();
            }
        }
        public void DeleteSupplier(string supplierName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cnnString))
                {
                    connection.Open();
                    string query = "DELETE FROM Supplier WHERE Name = @Name";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", supplierName);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void EditSupplier(int idsupplier, string newName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cnnString))
                {
                    connection.Open();
                    string query = "UPDATE Supplier SET Name = @NewName WHERE id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", idsupplier);
                        command.Parameters.AddWithValue("@NewName", newName);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<ShippmentCompany> SelectCompanyNames()
        {
            List<ShippmentCompany> companies = new List<ShippmentCompany>();

            try
            {
                using (SqlConnection connection = new SqlConnection(cnnString))
                {
                    connection.Open();
                    string query = "SELECT Id, Name FROM Shipment_co";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ShippmentCompany company = new ShippmentCompany
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1)
                                };
                                companies.Add(company);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return companies;
        }
        public List<Goods> SelectGoodsNames()
        {
            List<Goods> goods = new List<Goods>();

            try
            {
                using (SqlConnection connection = new SqlConnection(cnnString))
                {
                    connection.Open();
                    string query = "SELECT Id, Name,Cost FROM Goods";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Goods good = new Goods
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Cost = reader.GetDouble(2)
                                };
                                goods.Add(good);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return goods;
        }
        public List<FromWarehouse> SelectWarehouseNames()
        {
            List<FromWarehouse> warehouses = new List<FromWarehouse>();

            try
            {

                using (SqlConnection connection = new SqlConnection(cnnString))
                {
                    connection.Open();
                    string query = "SELECT Id, Name FROM WareHouse";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                FromWarehouse warehouse = new FromWarehouse
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1)
                                };
                                warehouses.Add(warehouse);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return warehouses;
        }


    }
}

