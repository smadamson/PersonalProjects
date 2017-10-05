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

        /// <summary>
        /// Updates a comment's hidden value or display.
        /// </summary>
        /// <param name="oldDisplay">old string being displayed</param>
        /// <param name="newDisplay">new string being displayed</param>
        /// <param name="hidden">new content for the comment.</param>
        /// <returns></returns>
        public bool UpdateComment(string oldDisplay, string newDisplay, string hidden)
        {
            if (comments.Contains(newDisplay))
            {
                //bad news! A comment with this display value already exists!
                throw new ArgumentException("A comment with this display value alread exists!");
            }
            else
            {
                comments.Remove(oldDisplay);
                return comments.Add(newDisplay, hidden);
            }
        }

        /// <summary>
        /// Returns the hidden comment associated with the display value. 
        /// If it does not exist, an exception is throw?
        /// </summary>
        public string GetComment(string display)
        {
            return comments.Get(display);
        }
    }
}
