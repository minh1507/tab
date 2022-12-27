using WebRunning.Core.Enums;
using WebRunning.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebRunning.Core.Core;

namespace WebRunning.API.Model
{
    [Table("Sys_Users")]
    public class Sys_User: AuditEntity
    {
        [StringLength(55)]
        [ColumnNameAttr("category")]
        public string FullName { get; set; }
        [StringLength(55)]
        [ColumnNameAttr("category")]
        public string UserName { get; set; }
        [StringLength(55)]
        public string PassWord { get; set; }
        [StringLength(55)]
        public string Email { get; set; }
        [StringLength(20)]
        public string Phone { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        public Core.Enums.UserType Type { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsSystem { get; set; } = false;        
    }
}
