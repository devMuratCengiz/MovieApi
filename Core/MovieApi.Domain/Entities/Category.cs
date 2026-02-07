using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApi.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool Status { get; set; }
        public string? Description { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
