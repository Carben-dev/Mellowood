using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.UI;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Mellowood.ContentManageSystem
{
    public class ContentManager : IContentManager
    {
        private readonly IRepository<Content, int> _contentRepository;

        public ContentManager(IRepository<Content, int> contentRepository)
        {
            _contentRepository = contentRepository;
        }

        public async Task<List<Content>> GetAllAsync()
        {
            List<Content> contents = await _contentRepository
            .GetAll()
            .ToListAsync();

            //if (contents.Count == 0) throw new UserFriendlyException("There is no content at all, try add some!");

            return contents;
        }

        public async Task<Content> GetAsync(int id)
        {
            var @content = await _contentRepository.FirstOrDefaultAsync(id);
            if (@content == null) throw new Abp.UI.UserFriendlyException("Could not found the content, try another id!");
            return @content;
        }

        public async Task InsertOrUpdateAsync(Content @content)
        {
            await _contentRepository.InsertOrUpdateAsync(@content);
        }
    }
}
