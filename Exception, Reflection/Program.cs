using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Exception__Reflection
{
	class Program
	{
		static void Main(string[] args)
		{
			//Assembly assembly = Assembly.GetExecutingAssembly();

			//var types = assembly.GetTypes();

			//foreach (var item in types)
			//{
			//Console.WriteLine($"{item.Name} class fields: ");

			// for Properties

			//foreach (var prop in item.GetProperties())
			//{
			//	Console.WriteLine(prop.Name);
			//}

			//for Fields
			//foreach (var field in item.GetFields())
			//{
			//	Console.WriteLine(field.Name);
			//}

			//for Methods
			//foreach (var meth in item.GetMethods())
			//{
			//	Console.WriteLine(meth.Name);
			//}
			//}
			//var student = assembly.GetType("Exception__Reflection.Student");

			//Console.WriteLine(student.Name);

			//var field = student.GetField("StudentAge");

			//Console.WriteLine(field.Name);

			//var pField = student.GetField("PrivateField",BindingFlags.NonPublic | BindingFlags.Instance);

			//Student student1 = new Student();

			//Console.WriteLine(student1);
			//Console.WriteLine(pField.GetValue(student1));

			//pField.SetValue(student1,"I can change you");

			//Console.WriteLine();
			//Console.WriteLine(pField.GetValue(student1));

			List<string> strList = new List<string>();

			strList.Add("test");
			strList.Add("okay");

			
			

			try
			{
				// Null reference exception
				Teacher teacher = new Teacher();
				//teacher.strCol.Add("Javid");

				//Index out of range exception
				//int[] arr = new int[1];

				//Console.WriteLine(arr[3]);

				// Invalid Operation exception
				//string find = strList.First(s => s == "okay");
				//Console.WriteLine(find);

				//Format exception 
				//int num = int.Parse("5a");
				//Console.WriteLine(num);

				Student student = new Student();

				student.StudentAge = 17;
				Console.WriteLine(student.CheckAge());
			}
			
			catch(InvalidOperationException e)
			{
				Console.WriteLine(e.Message);
				Console.WriteLine("okayy word does not exist in strList");
			}
			catch (NullReferenceException e)
			{
				Console.WriteLine(e.Message);
			}
			catch (FormatException e)
			{
				Console.WriteLine(e.Message);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				Console.WriteLine("Davam");
			}
			


		}
	}
	class Teacher
	{
		public List<string> strCol;
		public string TeacherFullname { get; set; }
		public int TeacherAge;
	}

	class Student
	{
		public string StudentFullname { get; set; }
		public int StudentAge;
		private string PrivateField;
		
		public Student()
		{
			PrivateField = "it is private. you can not change me";
		}

		public string CheckAge()
		{
			if (StudentAge < 18)
			{
				//throw new ArgumentOutOfRangeException("Age");
				throw new StudentAgeOutOfRangeException("Bu telebenin yashi classa daxil olmaq ucun yeterli deyil");
			}
			return "It is okay to join class";
		}
	}
}
