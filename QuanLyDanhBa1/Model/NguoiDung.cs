namespace QuanLyDanhBa1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiDung")]
    public partial class NguoiDung
    {
        [Key]
        public int UserID { get; set; }

        public bool? IsFavorite { get; set; }

        [Required]
        [StringLength(50)]
        public string HoTen { get; set; }

        [StringLength(15)]
        public string SoDienThoai { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(150)]
        public string Note { get; set; }

        [StringLength(255)]
        public string Avatar { get; set; }
    }
}
