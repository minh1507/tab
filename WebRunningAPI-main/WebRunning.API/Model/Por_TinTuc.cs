using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebRunning.Core.Core;
using WebRunning.Core.Enums;
using WebRunning.Core.Models;

namespace WebRunning.API.Model
{
    [Table("Por_TinTucs")]
    public class Por_TinTuc : AuditEntity
    {
        [StringLength(200)]
        public string TieuDe { get; set; }
        [StringLength(200)]
        public string MoTa { get; set; }
        [MaxLength]
        public string NoiDung { get; set; }
        [StringLength(200)]
        public string URL_AnhDaiDien { get; set; }
        public DateTimeOffset NgayXuatBan { get; set; }
        public Core.Enums.RecordStatus TrangThai { get; set; }
        public bool TinNoiBat { get; set; }
        public bool TinMoi { get; set; }
        public int LuotXem { get; set; }
    }
}
