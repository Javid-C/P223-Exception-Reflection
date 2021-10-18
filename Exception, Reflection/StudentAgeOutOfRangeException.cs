using System;
using System.Collections.Generic;
using System.Text;

namespace Exception__Reflection
{
	class StudentAgeOutOfRangeException : Exception
	{
		private string _message;
		public override string Message => _message;

		//public override string Message => base.Message;

		//public string Message
		//{
		//	get
		//	{
		//		return _message;
		//	}
		//}

		public StudentAgeOutOfRangeException(string message)
		{
			_message = message;
		}
	}
}
