using CleanArchMvc.Domain.Validation;
using System.Collections.Generic;

namespace CleanArchMvc.Domain.Entities
{
    public sealed class Category
    {

        public Category(string name)
        {
            ValidateDomain(name);
        }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }



        public int Id { get; private set; }

        public string Name { get; private set; }

        public ICollection<Product> Products { get; set; }



        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(name), "Invalid name, Name is required");
            DomainExceptionValidation.When(name.Length < 3, "Invalid Name, too Short, minimum 3 characters");
            Name = name;

        }


    }
}
