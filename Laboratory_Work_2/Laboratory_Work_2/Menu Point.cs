using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_2
{
	class Menu_Point
	{
		string name;
		public string Name
		{
			get { return name;}
			set { name = value; }
		}

		public delegate void callback();
		callback handler;
		public callback Handler
		{
			get { return handler; }
			set { handler = value; }
		}

		public Menu_Point ( string _name, callback _handler )
		{
			Name = _name;
			Handler = _handler;
		}

		public void Call ()
		{
			Handler();
		}

	}
}
