using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards
{
    public class FlashCard
    {
        private string title, text;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Text
        {
            get { return text; }
            set { text = value; }
        }
    }
}
