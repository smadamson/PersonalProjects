using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comment_Generator_Model
{
    class CommentGenerator
    {
        Comments comments;

        public CommentGenerator()
        {
            comments = new Comments(new Dictionary<string, string>(), "1.0");
        }

        public bool AddComment(string display, string hidden)
        {
            return comments.Add(display, hidden);
        }

        public bool UpdateComment(string oldDisplay, string newDisplay, string hidden)
        {
            if (comments.Contains(newDisplay))
            {
                //bad news...
                throw new Exception();
            }
            else
            {
                comments.Remove(oldDisplay);
                return comments.Add(newDisplay, hidden);
            }
        }
    }
}
