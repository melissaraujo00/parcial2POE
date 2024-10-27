using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;
using DataAccessLayer.DBConnection;
using Microsoft.Data.SqlClient;

namespace DataAccessLayer.Repositories
{
    public class ProductRepository
    {
        private SqlDataAccess _dbConnection;

        public ProductRepository()
        {
            _dbConnection = new SqlDataAccess();
        }

        public DataTable GetProduct()
        {
            DataTable ProductTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = "SELECT p.idProduct N, p.nameProducto Nombre , p.stock, p.price Precio, c.nameCategory categoria FROM product p INNER JOIN category c ON p.idCategory = c.idCategory";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                ProductTable.Load(reader);
            }
            return ProductTable;
        }

        public void AddProduct(Product product)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "INSERT INTO product VALUES (@NameProducto, @Stock, @Price, @IdCategory)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NameProducto", product.nameProducto);
                command.Parameters.AddWithValue("@Stock", product.stock);
                command.Parameters.AddWithValue("@Price", product.price);
                command.Parameters.AddWithValue("@IdCategory", product.idCategory);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdateProduct(Product product)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE product
                                SET nameProducto = @NameProducto,
                                    stock = @Stock,
                                    price = @Price,
                                    idCategory = @IdCategory
                                WHERE idProduct = @IdProduct";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NameProducto", product.nameProducto);
                command.Parameters.AddWithValue("@Stock", product.stock);
                command.Parameters.AddWithValue("@Price", product.price);
                command.Parameters.AddWithValue("@IdCategory", product.idCategory);
                command.Parameters.AddWithValue("@IdProduct", product.idProduct);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteProduct(int id)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "DELETE FROM product WHERE idProduct = @@IdProduct";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdProduct", id);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }
    }
}

