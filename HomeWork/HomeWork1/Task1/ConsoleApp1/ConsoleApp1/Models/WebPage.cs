using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class WebPage : ISearchable
    {
        private string htmlContent;

        public WebPage(string htmlContent)
        {
            this.htmlContent = htmlContent;
        }

        public bool Search(string word)
        {
            Console.WriteLine("Searching in WebPage...");
            // For demo purposes, just strip tags crudely and search.
            string textOnly = System.Text.RegularExpressions.Regex.Replace(htmlContent, "<.*?>", "");
            return textOnly.Contains(word, StringComparison.OrdinalIgnoreCase);
        }
    }
}
