using System;
using System.Collections.Generic;
using System.Text;

namespace wBees.Data.Models
{
    public class JobKeyword
    {
        public Guid JobId { get; set; }
        public Job Job { get; set; }

        public Guid KeywordId { get; set; }
        public Keyword Keyword { get; set; }
    }
}
