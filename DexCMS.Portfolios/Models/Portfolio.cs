using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DexCMS.Base.Models;

namespace DexCMS.Portfolios.Models
{
    public class Portfolio
    {
        [Key, ForeignKey("PageContent")]
        public int PortfolioID { get; set; }

        [Required]
        public int PortfolioCategoryID { get; set; }

        [Required]
        public int PortfolioStatusID { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? CompletionDate { get; set; }

        [Required]
        public bool IsPublic { get; set; }

        //Relationships
        public virtual PortfolioCategory PortfolioCategory { get; set; }
        public virtual ICollection<PortfolioSkill> PortfolioSkills { get; set; }
        public virtual PageContent PageContent { get; set; }
        public virtual PortfolioStatus PortfolioStatus { get; set; }

    }
}
