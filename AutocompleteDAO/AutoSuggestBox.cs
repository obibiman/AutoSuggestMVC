namespace AutoCompleteBox.AutocompleteDAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AutoSuggestBox")]
    public partial class AutoSuggestBox
    {
        [Key]
        public int StudentId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Class { get; set; }

        [StringLength(50)]
        public string EnrollYear { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string Country { get; set; }
    }
}
