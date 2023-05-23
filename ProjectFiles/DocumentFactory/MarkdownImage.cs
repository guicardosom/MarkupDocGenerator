using System;

namespace DocumentFactory
{
    /**
	 * Class Name: MarkdownImage
	 * Purpose: Creates a Markdown image element
	 * Coder: Gui Miranda
	 * Date: 05/23/2023
     */
    public class MarkdownImage : MarkdownElement
    {
        private string imagePath { get; set; }
        private string imageTitle { get; set; }
        private string imageAlt { get; set; }

        public MarkdownImage(string content)
        {
        }

        /*Method Name: ToString
         *Purpose: To output the image formatted as a Markdown element
         *Accepts: Nothing
         *Returns: A string containing a Markdown image element
         */
        override
        public string ToString()
        {
            return $"![{imageAlt}]({imagePath} \"{imageTitle}\")";
        }
    }
}

