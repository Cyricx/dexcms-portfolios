using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DexCMS.Portfolios.Models
{
    public class PortfolioStatus
    {
        [Key]
        public int PortfolioStatusID { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public virtual ICollection<Portfolio> Portfolios { get; set; }
    }
}
