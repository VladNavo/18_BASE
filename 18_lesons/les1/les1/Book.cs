using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les1
{
    internal class Book
    {
        private Title tit;
        private Author aut;
        private Content con;
        public Title BookTitle
        {
            get { return tit; }
            set { tit = value; }
        }


        public Author BookAuthor
        {
            get { return aut; }
            set { aut = value; }
        }



        public Content BookContent
        {
            get { return con; }
            set { con = value; }
        }
        public Book()
        {
            tit = new Title();
            aut = new Author();
            con = new Content();
        }
        

		

        public void show() 
		{
			Author.Show(  aut);
			Content.Show( con);
			Title.Show(  tit );
		
		}

	}
}
