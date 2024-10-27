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
    public class CategoryRepository
    {
        private SqlDataAccess _dbConnection;

        public CategoryRepository()
        {
            _dbConnection = new SqlDataAccess();
        }

        public DataTable GetCategory()
        {
            DataTable categoryTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = "SELECT * FROM category";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                categoryTable.Load(reader);
            }
            return categoryTable;
        }

        public void AddCategory(Category category)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "INSERT INTO category VALUES (@NameCategory)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NameCategory", category.nameCategory);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdateCategory(Category category)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE category
                                SET nameCategory = @NameCategory
                                WHERE idCategory = @IdCategory";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NameCategory", category.nameCategory);
                command.Parameters.AddWithValue("@IdCategory", category.idCategory);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteCategory(int id)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "DELETE FROM category WHERE idCategory = @IdCategory";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdCategory", id);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }
    }
}

