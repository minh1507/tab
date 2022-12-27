using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebRunning.Core.Core;
using WebRunning.Core.Enums;
using WebRunning.Core.Models;

namespace WebRunning.API.Model
{
    [Table("Por_SuKiens")]
    public class Por_SuKien : AuditEntity
    {
        [StringLength(155)]
        public string Ten { get; set; }
        [StringLength(255)]
        public string DiaChi { get; set; }
        [MaxLength]
        public string NoiDung { get; set; }
        [StringLength(100)]
        public string GiaTien { get; set; }
        public DateTimeOffset ThoiGian { get; set; }
        [StringLength(200)]
        public string URL_AnhDaiDien { get; set; }
    }
}
