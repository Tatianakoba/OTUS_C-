using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_Document
{
    internal class Document
    {
        //Поля
        Title title = null;
        Body body = null;
        Footer footer = null;
        void InitializeDocument()
        {
            this.title = new Title();
            this.body = new Body();
            this.footer = new Footer();
        }
        public Document(string title)
        {
            InitializeDocument();
            this.title.Content = title;
        }
        public void Show()
        {
            this.title.Show();
            this.body.Show();
            this.footer.Show();
        }
        public string Body
        {
            set
            {
                this.body.Content = value;
            }
        }
        public string Footer
        {
            set
            {
                this.footer.Content = value;
            }
        }
           


    }
}
