using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoCompleteBox.AutocompleteDAO;
using AutoCompleteBox.AutocompleteDAO.Repository;

namespace AutoCompleteBox.Controllers
{
    public class StudentApiController : ApiController
    {
        private readonly GenericRepository _repository;

        public StudentApiController()
        {
            
        }

        public StudentApiController(Autofetch context)
        {
            _repository = new GenericRepository(context);
        }

        public IEnumerable<AutoSuggestBox> Get(string searchText)
        {
            var authors = _repository.GetAll().Where(y=>y.Name.ToLower().StartsWith(searchText.ToLower())).AsEnumerable();
            return authors;
        }
    }
}
