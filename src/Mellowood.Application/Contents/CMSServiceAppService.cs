using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.ObjectMapping;
using Abp.UI;
using Mellowood.Contents.Dto;
using Mellowood.ContentManageSystem;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mellowood.Contents
{
    public class CMSServiceAppService : MellowoodAppServiceBase, ICMSServiceAppService
    {
        private readonly IContentManager _contentManager;
        private readonly IObjectMapper _objectMapper;

        public CMSServiceAppService(IContentManager contentManager, IObjectMapper objectMapper)
        {
            _contentManager = contentManager;
            _objectMapper = objectMapper;
        }

        public async Task<ListResultDto<ContentDto>> GetAll()
        {
            var @contents = await _contentManager.GetAllAsync();
            return new ListResultDto<ContentDto>(ObjectMapper.Map<List<ContentDto>>(@contents));
        }


        public async Task<ContentDto> GetCMSContent(GetCMSContentInput input)
        {
            // get content by ContentId in input dto
            var @content = await _contentManager.GetAsync(input.Id);
            // return ContentDto
            return _objectMapper.Map<ContentDto>(@content);
        }

        public async Task<ContentDto> InsertOrUpdateCMSContent(InsertOrUpdateCMSContentInput input)
        {
            // From input dto, create a content entity
            //var @content = ObjectMapper.Map<Content>(input);
            var @content = Content.Create(input.Id, input.Title, input.Description);
            // call content manager to insert or update that content
            await _contentManager.InsertOrUpdateAsync(@content);
            // return dto to front-end
            return ObjectMapper.Map<ContentDto>(@content);
        }
    }
}
