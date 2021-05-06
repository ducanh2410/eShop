using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Core.Interfaces
{
    public interface IBaseService<T> where T : class
    {
        /// <summary>
        /// Lấy toàn bộ dự liệu
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> GetAll();

        /// <summary>
        /// Lấy bằng Id
        /// </summary>
        /// <param name="TentityId"></param>
        /// <returns></returns>
        public T GetById(Guid TentityId);

        /// <summary>
        /// Thêm mới bản ghi
        /// </summary>
        /// <param name="Tentity"></param>
        /// <returns>Trả về số bản ghi được thêm</returns>
        public int Insert(T Tentity);

        /// <summary>
        /// Chỉnh sửa bản ghi
        /// </summary>
        /// <param name="Tentity"></param>
        /// <returns>Trả về số bản ghi đã sửa</returns>
        public int Update(T Tentity);

        /// <summary>
        /// Xóa bản ghi
        /// </summary>
        /// <param name="Tentity"></param>
        /// <returns>Trả về số bản ghi đã xóa</returns>
        public int Delete(Guid TentityId);
    }
}