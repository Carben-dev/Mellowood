using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mellowood.ContentManageSystem
{
    public interface IContentManager : IDomainService
    {
        Task<Content> GetAsync(int id);

        Task<List<Content>> GetAllAsync();

        Task InsertOrUpdateAsync(Content @content);
    }
}
