using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebRunning.Core.Core;
using WebRunning.Core.Enums;
using WebRunning.Core.Models;

namespace WebRunning.API.Model
{
    [Table("Por_Menus")]
    public class Por_Menu : AuditEntity
    {
        [StringLength(55)]
        public string Ma { get; set; }
        [StringLength(55)]
        public string Ten { get; set; }
        [StringLength(55)]
        public string URL { get; set; }
        public Guid IdMenuCha { get; set; }
        public Core.Enums.RecordStatus TrangThai { get; set; }
    }
}
