namespace AutoCompleteBox.AutocompleteDAO
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Autofetch : DbContext
    {
        public Autofetch()
            : base("name=Autofetch")
        {

        }

        public virtual DbSet<AutoSuggestBox> AutoSuggestBoxes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
