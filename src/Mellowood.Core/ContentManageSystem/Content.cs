using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace Mellowood.ContentManageSystem
{
    [Table("AppContents")]
    public class Content : Entity<int>//, IMustHaveTenant
    {
        public const int MaxTitleLength = 256;
        public const int MaxDescriptionLength = 64 * 1024;

        //public virtual int TenantId { get; set; } // from IMustHaveTenant

        //public virtual int Id { get; set; }

        [Required]
        [StringLength(MaxTitleLength)]
        public string Title { get; set; }

        [Required]
        [StringLength(MaxDescriptionLength)]
        public string Description { get; set; }

        protected Content(){}

        public static Content Create(int id, string title, string description)
        {
            var @content = new Content
            {
                Id = id,
                //TenantId = tenantId,
                Title = title,
                Description = description
            };

            return @content;
        }

    }
}
