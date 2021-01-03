using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippy.Models
{
    public class Snippet
    {
        private ICollection<Label> labels;
        private ICollection<Comment> comments;

        public Snippet()
        {
            this.labels = new HashSet<Label>();
            this.comments = new HashSet<Comment>();
        }

        public int ID
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public string CodeSnippet
        {
            get;
            set;
        }

        public string Language
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

        public ICollection<Label> Labels
        {
            get
            {
                return this.labels;
            }
            set
            {
                this.labels = value;
            }
        }

        public virtual ICollection<Comment> Comments
        {
            get
            {
                return this.comments;
            }
            set
            {
                this.comments = value;
            }
        }
    }
}
