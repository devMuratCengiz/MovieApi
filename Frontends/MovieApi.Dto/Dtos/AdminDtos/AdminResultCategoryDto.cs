using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApi.Dto.Dtos.AdminDtos
{
    public class AdminResultCategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MovieCount { get; set; }
        public int ReviewCount { get; set; }
        public double AvgRating{ get; set; }
        public bool IsActive { get; set; }
    }
}
