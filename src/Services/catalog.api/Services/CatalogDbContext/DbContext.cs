using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

using catalog.api.Models;

namespace catalog.api.Services.CatalogDbContext
{
    public class DbContext : CatalogDbContextList
    {

        internal async Task<IReadOnlyCollection<Product>> GetProducts()
        {
            try
            {
                var conn = new SqlConnection(DbContextConstant.ConnectionString);

                await conn.OpenAsync();

                var comm = new SqlCommand("select * from [dbo].[Products]", conn);

                var result = await comm.ExecuteReaderAsync();

                var hasRows = result.HasRows;

                if (hasRows)
                {
                    Products = new List<Product>();

                    Products.Clear();

                    while (await result.ReadAsync())
                    {
                        var productResult = new Product
                        {
                            Id = result.GetSqlString(0).Value,
                            Brand = result.GetSqlString(1).Value,
                            Model = result.GetSqlString(2).Value,
                            Style = result.GetSqlString(3).Value,
                            Wheels = result.GetSqlInt32(4).Value,
                            WheelSize = result.GetSqlInt32(5).Value,
                            Color = result.GetSqlString(6).Value,
                            Price = result.GetSqlMoney(7).Value
                        };
                        Products.Add(productResult);
                    }

                    return await Task.FromResult(Products);
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        internal static async Task<bool> DeleteById(string id)
        {
            try
            {
                var conn = new SqlConnection(DbContextConstant.ConnectionString);

                await conn.OpenAsync();

                var comm = new SqlCommand($"delete from Products where Id = '{id}'", conn);

                var result = await comm.ExecuteNonQueryAsync();

                if (result > 0)
                    return await Task.FromResult(true);

                return await Task.FromResult(false);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        internal static async Task<Product> AddProduct(Product product)
        {
            try
            {
                string id, brand, model, style, color;
                int wheelSize, wheels;
                decimal price;

                var conn = new SqlConnection(DbContextConstant.ConnectionString);

                await conn.OpenAsync();

                id = product.Id.Replace("-", string.Empty);
                brand = product.Brand;
                model = product.Model;
                style = product.Style;
                color = product.Color;
                wheels = product.Wheels;
                wheelSize = product.WheelSize;
                price = Convert.ToDecimal(product.Price.ToString().Replace(".", ","));

                var comm = new SqlCommand()
                {
                    CommandText = $"INSERT INTO Products VALUES('{id}','{brand}','{model}','{style}',{wheels},{wheelSize},'{color}',{price});",
                    Connection = conn,
                    CommandType = System.Data.CommandType.Text
                };

                var result = await comm.ExecuteNonQueryAsync();

                if (result > 0)
                    return await Task.FromResult(product);

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        internal async Task<IReadOnlyCollection<Product>> SearchByBrand(string brand)
        {
            try
            {
                var conn = new SqlConnection(DbContextConstant.ConnectionString);

                await conn.OpenAsync();

                var comm = new SqlCommand($"select * from Products where Brand='{brand}'", conn);

                var result = await comm.ExecuteReaderAsync();

                if (result.HasRows)
                {
                    Products = new List<Product>();

                    Products.Clear();

                    while (await result.ReadAsync())
                    {
                        var productResult = new Product
                        {
                            Id = result.GetSqlString(0).Value,
                            Brand = result.GetSqlString(1).Value,
                            Model = result.GetSqlString(2).Value,
                            Style = result.GetSqlString(3).Value,
                            Wheels = result.GetSqlInt32(4).Value,
                            WheelSize = result.GetSqlInt32(5).Value,
                            Color = result.GetSqlString(6).Value,
                            Price = result.GetSqlMoney(7).Value
                        };
                        Products.Add(productResult);
                    }

                    return await Task.FromResult(Products);
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        internal async Task<IReadOnlyCollection<Product>> SearchByWheelSize(int wheelSize)
        {
            try
            {
                var conn = new SqlConnection(DbContextConstant.ConnectionString);

                await conn.OpenAsync();

                var comm = new SqlCommand($"select * from Products where WheelSize = '{wheelSize}'", conn);

                var result = await comm.ExecuteReaderAsync();

                var hasRows = result.HasRows;

                if (hasRows)
                {
                    Products = new List<Product>();

                    Products.Clear();

                    while (await result.ReadAsync())
                    {
                        var productResult = new Product
                        {
                            Id = result.GetSqlString(0).Value,
                            Brand = result.GetSqlString(1).Value,
                            Model = result.GetSqlString(2).Value,
                            Style = result.GetSqlString(3).Value,
                            Wheels = result.GetSqlInt32(4).Value,
                            WheelSize = result.GetSqlInt32(5).Value,
                            Color = result.GetSqlString(6).Value,
                            Price = result.GetSqlMoney(7).Value
                        };
                        Products.Add(productResult);
                    }

                    return await Task.FromResult(Products);
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
