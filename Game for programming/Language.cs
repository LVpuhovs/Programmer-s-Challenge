using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_for_programming
{
    public class Language
    {
        public string language { get; set; }
        public Language(string defaultLanguage)
        {
            language = defaultLanguage;
        }
        public override string ToString()
        {
            return language;
        }
    }
}
