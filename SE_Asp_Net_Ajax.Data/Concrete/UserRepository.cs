using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using SE_Asp_Net_Ajax.Data.Abstract;
using SE_Asp_Net_Ajax.Data.Entities;

namespace SE_Asp_Net_Ajax.Data.Concrete
{
    public class UserRepository : IUserRepository
    {
        private UserContext context;

        public UserRepository(UserContext context)
        {
            this.context = context;
        }

        public async Task DeleteUserAsync(int id)
        {
            User user = await context.Users.FindAsync(id);
            context.Users.Remove(user);
        }

        public User GetUserById(Guid? id)
        {
            return context.Users.Find(id);
        }

        public IEnumerable<User> GetUsers()
        {
            return context.Users.ToList();
        }

        public IEnumerable<User> GetUsers(int start, int count)
        {
            return context.Users.Skip(count * (start - 1)).Take(start).AsEnumerable();
        }

        public void Add(User user)
        {
            context.Users.Add(user);
        }

        public void EditUser(User user)
        {
            context.Entry(user).State = EntityState.Modified;
        }

        public int Count()
        {
            return context.Users.Count();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~UserRepository() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion

        public void DeleteUser(int id)
        {
            User note = context.Users.Find(id);
            if (note != null)
                context.Users.Remove(note);
        }

        public async Task<User> GetUserByIdAsynk(Guid id)
        {
            return await context.Users.FindAsync(id);
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await context.Users.ToListAsync();
        }

        public async Task<List<User>> GetUsersAsync(int pageIndex, int pageSize)
        {
            var users = context.Users.OrderBy(p => p.Id);// I think you don't need to call AsQueryable(), you already are working with IQueryable
            return await users.Skip(pageIndex * pageSize).Take(pageSize).ToListAsync();
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }

        public async Task<User> GetUserById(int id)
        {
            return await context.Users.FindAsync(id);
        }

        public async Task<int> CountAsynk()
        {
            return await context.Users.CountAsync();
        }
    }
}
