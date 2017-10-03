using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using GeneratorUtils;

namespace Comment_Generator_Model
{
    public class Comments : Content<String>
    {
        Dictionary<String, String> DisplayValToFullComment;
        private static String TYPE = "Comments";

        /// <summary>
        /// Constructs a CommentContent object. This object is designed to store all the comments for this given generator.
        /// 
        /// </summary>
        /// <param name="DisplayValToFullComment">Keys are the string to display, values are the comment that is generated.</param>
        /// <param name="version">Version of this commment?</param>
        public Comments(Dictionary<string,string> DisplayValToFullComment, string version) : base(version, TYPE)
        {
            this.DisplayValToFullComment = DisplayValToFullComment;
        }

        /// <summary>
        /// Method writes all fields for all comments. 
        /// </summary>
        /// <param name="writer"></param>
        public override void WriteComponentsXml(XmlWriter writer)
        {
            foreach(KeyValuePair<string, string> comment in DisplayValToFullComment)
            {
                WriteCommentXml(writer, comment.Key, comment.Value);
            }
        }


        /// <summary>
        /// Writes the Xml for a single comment. Should look something like this:
        /// (comment)
        ///     (display)"display value"(/display)
        ///     (hidden)"comment generated"(/hidden)
        /// (/comment)
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="displayValue"></param>
        /// <param name="hiddenComment"></param>
        private void WriteCommentXml(XmlWriter writer, String displayValue, String hiddenComment)
        {
            writer.WriteStartElement("comment");
                //(display)
                writer.WriteStartElement("display");
                    writer.WriteValue(displayValue);
                writer.WriteEndElement();
                //(/display)
                //(hidden)
                writer.WriteStartElement("hidden");
                    writer.WriteValue(hiddenComment);
                writer.WriteEndElement(); 
                //(/hidden)
            writer.WriteEndElement();
        }

        /// <summary>
        /// Add the display,hidden pair to the comments. 
        /// </summary>
        /// <returns>True if added, false otherwise.</returns>
        public bool Add(string display, string hidden)
        {
            if (!Contains(display))
            {
                DisplayValToFullComment.Add(display, hidden);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Returns true if comments contains the display key already.
        /// </summary>
        public bool Contains(string display)
        {
            return DisplayValToFullComment.Keys.Contains(display);
        }

        /// <summary>
        /// Removes the given item from the Comments
        /// Returns true if removed, false otherwise. 
        /// </summary>
        public bool Remove(string display)
        {
           return DisplayValToFullComment.Remove(display);
        }
    }
    }
