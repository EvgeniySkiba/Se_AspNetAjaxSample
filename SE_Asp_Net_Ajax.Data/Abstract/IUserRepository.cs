using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SE_Asp_Net_Ajax.Data.Entities;

namespace SE_Asp_Net_Ajax.Data.Abstract
{
    public interface IUserRepository
        : IDisposable
    {
        IEnumerable<User> GetUsers();
        IEnumerable<User> GetUsers(int start, int count);
        User GetUserById(Guid? id);
        void Add(User user);
        void DeleteUser(int id);
        void EditUser(User user);
        void Save();
        int Count();

        Task DeleteUserAsync(int id);
        Task<User> GetUserByIdAsynk(Guid id);
        Task<List<User>> GetUsersAsync();
        Task CreateAsync(User user);
        Task<List<User>> GetUsersAsync(int pageIndex, int pageSize);
        Task SaveAsync();
        Task<User> GetUserById(int id);
        Task<int> CountAsynk();
    }
}
