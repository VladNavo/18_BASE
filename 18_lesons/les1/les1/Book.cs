using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les1
{
    internal class Book
    {

        public Book()
        {
            tit = new Title();
            aut = new Author();
            con = new Content();
        }
        private Title tit;

		public Title BookTitle
		{
			get { return tit; }
			set { tit = value; }
		}
		private Author aut;

		public Author BookAuthor
		{
			get { return aut; }
			set { aut = value; }
		}

		private Content con;

		public Content BookContent
		{
			get { return con; }
			set { con = value; }
		}

        public void show() 
		{
			Author.Show(  aut);
			Content.Show( con);
			Title.Show(  tit );
		
		}

	}
}
