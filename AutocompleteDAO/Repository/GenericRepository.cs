using System.Collections.Generic;
using System.Linq;

namespace AutoCompleteBox.AutocompleteDAO.Repository
{
    public class GenericRepository : IGenericRepository<AutoSuggestBox>
    {
        protected Autofetch _context;

        public GenericRepository(Autofetch context)
        {
            _context = context;
        }

        public void Dispose()
        {
            Dispose();
        }

        public ICollection<AutoSuggestBox> GetAll()
        {
            return _context.AutoSuggestBoxes.ToList();
        }
    }
}