using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyyEntity
{
    public class Article
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ArticleId { get; set; }

        public string ArticleName { get; set; }
        
        [ForeignKey("colour")]
        public int colourId { get; set; }

        public Colour colour { get; set; }
    }
}
