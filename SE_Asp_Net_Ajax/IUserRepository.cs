using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using SE_Asp_Net_Ajax.Models;

namespace SE_Asp_Net_Ajax
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllAsync(CancellationToken cancellationToken = default(CancellationToken));
        Task CreateAsync(User contact, CancellationToken cancellationToken = default(CancellationToken));
        Task DeleteAsync(int id, CancellationToken cancellationToken = default(CancellationToken));
    }
}