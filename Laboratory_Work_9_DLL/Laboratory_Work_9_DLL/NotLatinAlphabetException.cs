﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_9_DLL
{
	class NotLatinAlphabetException : Exception
	{
		public NotLatinAlphabetException()
			: base("Сообщение должно содержать только символы латиницы!")
		{ }
	}
}
