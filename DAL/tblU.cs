namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblU")]
    public partial class tblU
    {
        [Key]
        [StringLength(10)]
        public string UserID { get; set; }

        [StringLength(10)]
        public string Password { get; set; }

        [StringLength(10)]
        public string RoleID { get; set; }
    }
}
