namespace TheReallyOldEFSample
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Book
    {
        public int BookId { get; set; }

        [Required]
        [StringLength(25)]
        public string Publisher { get; set; }

        [StringLength(60)]
        public string Title { get; set; }

        [StringLength(20)]
        public string Isbn { get; set; }
    }
}
