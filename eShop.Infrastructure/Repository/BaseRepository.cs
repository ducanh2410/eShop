using Dapper;
using eShop.Core.Interfaces.Repository;
using Microsoft.Extensions.Configuration;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace eShop.Infrastructure.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private IConfiguration configuration;
        protected IDbConnection dbConnection;
        private String tableName = typeof(T).Name;

        public BaseRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
            dbConnection = new SqlConnection(this.configuration.GetConnectionString("Connection"));
        }

        /// <summary>
        /// Lấy toàn bộ dự liệu
        /// </summary>
        /// <returns>T</returns>
        public IEnumerable<T> GetAll()
        {
            var customers = dbConnection.Query<T>($"Proc_Get{tableName}s", commandType: CommandType.StoredProcedure);
            return customers;
        }

        /// <summary>
        /// Lấy bằng Id
        /// </summary>
        /// <param name="TentityId"></param>
        /// <returns>Trả về bản ghi</returns>
        public T GetById(Guid TentityId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("ID", TentityId);
            var customer = dbConnection.QueryFirstOrDefault<T>($"Proc_Get{tableName}ById", param: parameters, commandType: CommandType.StoredProcedure);
            return customer;
        }

        /// <summary>
        /// Thêm mới bản ghi
        /// </summary>
        /// <param name="Tentity"></param>
        /// <returns>Trả về bản ghi được thêm</returns>
        public int Insert(T Tentity)
        {
            var rowAffects = dbConnection.Execute($"Proc_Insert{tableName}", Tentity, commandType: CommandType.StoredProcedure);
            return rowAffects;
        }

        /// <summary>
        /// Chỉnh sửa bản ghi
        /// </summary>
        /// <param name="Tentity"></param>
        /// <returns>Trả về số bản ghi đã sửa</returns>
        public int Update(T Tentity)
        {
            var rowAffects = dbConnection.Execute($"Proc_Update{tableName}", Tentity, commandType: CommandType.StoredProcedure);
            return rowAffects;
        }

        /// <summary>
        /// Xóa bản ghi
        /// </summary>
        /// <param name="TentityId"></param>
        /// <returns>Trả về số bản ghi đã xóa</returns>
        public int Delete(Guid TentityId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add($"ID", TentityId);
            var rowAffects = dbConnection.Execute($"Proc_Delete{tableName}", parameters, commandType: CommandType.StoredProcedure);
            return rowAffects;
        }
    }
}