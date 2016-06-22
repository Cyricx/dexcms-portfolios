﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DexCMS.Portfolios.Models
{
    public class PortfolioCategory
    {
        [Key]
        public int PortfolioCategoryID { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }


        [Required]
        public bool IsActive { get; set; }

        public virtual ICollection<Portfolio> Portfolios { get; set; }
        
    }
}
