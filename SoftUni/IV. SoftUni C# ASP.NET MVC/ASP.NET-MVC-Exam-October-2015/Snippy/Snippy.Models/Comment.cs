using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippy.Models
{
    public class Comment
    {
        public int ID
        {
            get;
            set;
        }

        public string UserId
        {
            get;
            set;
        }

        public virtual User User
        {
            get;
            set;
        }

        public DateTime PublishedOn
        {
            get;
            set;
        }

        public string Content
        {
            get;
            set;
        }

        public int SnippetId
        {
            get;
            set;
        }

        public virtual Snippet Snippet
        {
            get;
            set;
        }
    }
}
