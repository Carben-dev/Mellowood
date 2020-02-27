using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System.Threading.Tasks;
using Mellowood.Contents.Dto;

namespace Mellowood.Contents
{
    public interface ICMSServiceAppService : IApplicationService
    {

        Task<ContentDto> GetCMSContent(GetCMSContentInput input);

        Task<ContentDto> InsertOrUpdateCMSContent(InsertOrUpdateCMSContentInput input);

        Task<ListResultDto<ContentDto>> GetAll();

    }
}
