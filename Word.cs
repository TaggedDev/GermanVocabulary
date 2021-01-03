using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Word
    {
        public int id { get; set; }
        public string original, translate, theme;

        public Word() { }
        public Word(int id, string original, string translate, string theme) {
            this.id = id;
            this.original = original;
            this.translate = translate;
            this.theme = theme;
        }

    }
}
