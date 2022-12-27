using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebRunning.Core.Core;
using WebRunning.Core.Enums;
using WebRunning.Core.Models;

namespace WebRunning.API.Model
{
    [Table("Por_DangKyTuVans")]
    public class Por_DangKyTuVan : AuditEntity
    {
        [StringLength(155)]
        public string Ten { get; set; }
        [StringLength(20)]
        public string Sdt { get; set; }
        [StringLength(55)]
        public string Email { get; set; }
        [StringLength(255)]
        public string DiaChi { get; set; }
        [StringLength(500)]
        public string NoiDung { get; set; }
    }
}
