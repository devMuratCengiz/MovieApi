using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApi.Domain.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public int UserRating { get; set; }
        public DateTime ReviewDate{ get; set; }
        public bool Status { get; set; }
    }
}
