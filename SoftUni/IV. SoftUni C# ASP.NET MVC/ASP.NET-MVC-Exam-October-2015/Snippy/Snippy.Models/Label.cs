using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippy.Models
{
    public class Label
    {
        private ICollection<Snippet> snippets;

        public Label()
        {
            this.snippets = new HashSet<Snippet>();
        }
        public int ID
        {
            get;
            set;
        }

        public string Text
        {
            get;
            set;
        }

        public virtual ICollection<Snippet> Snippets
        {
            get
            {
                return this.snippets;
            }
            set
            {
                this.snippets = value;
            }
        }
    }
}
