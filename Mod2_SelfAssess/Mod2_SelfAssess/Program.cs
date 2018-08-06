using System;

namespace Mod2_SelfAssess
{
	class Program
	{
		static void Main(string[] args)
		{
			var aTeacher = new Teacher("Ena", "McQuinn");

			aTeacher.Dob = DateTime.Parse("1967-01-13");
			Console.WriteLine($"DoB: {aTeacher.Dob:dd-MMMM-yyyy}");

			Console.WriteLine(aTeacher.ToString());
		}
	}
}
