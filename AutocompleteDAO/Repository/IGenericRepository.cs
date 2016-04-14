using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using AutoCompleteBox.Models;

namespace AutoCompleteBox.AutocompleteDAO.Repository
{
    public interface IGenericRepository<T> : IDisposable where T : class
    {
        ICollection<T> GetAll();
    }
}