using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebRunning.Core.Core;
using WebRunning.Core.Enums;
using WebRunning.Core.Models;

namespace WebRunning.API.Model
{
    [Table("Por_KhoaHocs")]
    public class Por_KhoaHoc : AuditEntity
    {
        [StringLength(200)]
        public string Ten { get; set; }
        [StringLength(200)]
        public string MoTa { get; set; }
        [MaxLength]
        public string NoiDung { get; set; }
        [StringLength(200)]
        public string URL_AnhDaiDien { get; set; }
        public Guid IdMonHoc { get; set; }
        public Core.Enums.RecordStatus TrangThai { get; set; }
        [StringLength(50)]
        public string HocPhi { get; set; }
        [StringLength(50)]
        public string HocPhiGoc { get; set; }
        [StringLength(50)]
        public string HocPhiGiamGia { get; set; }
    }
}
