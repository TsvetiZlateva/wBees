using System;
using System.Collections.Generic;
using System.Text;

namespace wBees.Data.Models
{
    public class JobKeyword
    {
        public Guid JobId { get; set; }
        public virtual Job Job { get; set; }

        public Guid KeywordId { get; set; }
        public virtual Keyword Keyword { get; set; }
    }
}
