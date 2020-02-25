using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Mellowood.ContentManageSystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mellowood.CMSService.Dto
{
    [AutoMapFrom(typeof(Content))]
    public class ContentDto : EntityDto
    {
        public string Title { get; set; }

        public string Description { get; set; }
    }
}
