using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketApi.Model
{
    public class Show
    {
        public int ShowId { get; set; }
        public string Duretion { get; set; }
        [ForeignKey("TheaterId")]
        public int TheaterId { get; set; }
        public virtual Theater Theater { get; set; }
        [ForeignKey("MovieId")]
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
