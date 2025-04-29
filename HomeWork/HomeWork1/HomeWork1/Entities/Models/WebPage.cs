using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1.Entities.Models
{
    public class WebPage : Searchable
    {
        private string htmlContent;

        public WebPage(string htmlContent)
        {
            this.htmlContent = htmlContent;
        }

        public bool Search(string word)
        {
            Console.WriteLine("Searching in WebPage...");
            return htmlContent.Contains(word, StringComparison.OrdinalIgnoreCase);
        }
    }
}
