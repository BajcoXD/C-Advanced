using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1.Entities.Models
{
    public class Document : Searchable
    {
        private string content;

        public Document(string content)
        {
            this.content = content;
        }

        public bool Search(string word)
        {
            Console.WriteLine("Searching in Document...");
            return content.Contains(word, StringComparison.OrdinalIgnoreCase);
        }
    }
}
