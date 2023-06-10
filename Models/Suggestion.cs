using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuggestionApp.Models
{
    public class Suggestion
    {
        public int Id { get; set; }
        public string SuggestionQuestion { get; set; }
        public string SuggestionAnswer { get; set; }
        public Suggestion()
        {

        }
    }
}
