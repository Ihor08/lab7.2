
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

public class Test
{

	public class StudentRating
	{

		private string lastName;
		private string group;
		private int gradebook;
		private int math;
		private int phis;
		private int chem;

		public StudentRating()
		{
			this.lastName = "none";
			this.group = "none";
			this.gradebook = 1;
			this.math = 5;
			this.phis = 5;
			this.chem = 5;
		}

		public StudentRating(string lastName, string group, int gradebook, int math, int phis, int chem)
		{
			this.lastName = lastName;
			this.group = group;
			this.gradebook = gradebook;
			this.math = math;
			this.phis = phis;
			this.chem = chem;
		}

		public void setLastName(string lastName)
		{
			this.lastName = lastName;
		}

		public string getLastName()
		{
			return this.lastName;
		}

		public void setGroup(string group)
		{
			this.group = group;
		}

		public string getGroup()
		{
			return this.group;
		}

		public void setGradebook(int gradebook)
		{
			this.gradebook = gradebook;
		}

		public int getGradebook()
		{
			return this.gradebook;
		}

		public void setMath(int math)
		{
			this.math = math;
		}

		public int getMath()
		{
			return this.math;
		}

		public void setPhis(int phis)
		{
			this.phis = phis;
		}

		public int getPhis()
		{
			return this.phis;
		}

		public void setChem(int chem)
		{
			this.chem = chem;
		}

		public int getChem()
		{
			return this.chem;
		}

		public void setParam(string lastName, string group, int gradebook, int math, int phis, int chem)
		{
			this.lastName = lastName;
			this.group = group;
			this.gradebook = gradebook;
			this.math = math;
			this.phis = phis;
			this.chem = chem;
		}

		public void info()
		{

			Console.WriteLine("LastName: " + this.lastName);
			Console.WriteLine("Group: " + this.group);
			Console.WriteLine("Gradebook: " + this.gradebook);
			Console.WriteLine("Math: " + this.math);
			Console.WriteLine("Phis: " + this.phis);
			Console.WriteLine("Chem: " + this.chem);

		}


	}

	public class StudentRatings
	{

		public int length;
		public StudentRating[] sr;

		public StudentRatings()
		{
			this.length = 10;
			sr = new StudentRating[this.length];
			std();
		}

		public StudentRatings(int length)
		{
			this.length = length;
			sr = new StudentRating[this.length];
			std(length);
		}

		public void std()
		{
			for (int i = 0; i < this.length; i++)
			{
				sr[i] = new StudentRating("null", "null", 0, 0, 0, 0);
			}
		}

		public void std(int length)
		{
			for (int i = 0; i < this.length; i++)
			{

				sr[i] = new StudentRating("null", "null", 0, 0, 0, 0);
			}
		}

		public void sortGradebook()
		{

			StudentRating tmp = new StudentRating();

			for (int i = 0; i < this.length; i++)
			{

				for (int j = i + 1; j < this.length; j++)
				{

					if (sr[i].getGradebook() > sr[j].getGradebook())
					{
						tmp = sr[i];
						sr[i] = sr[j];
						sr[j] = tmp;
					}

				}


			}

		}

		public void sortGroupMath()
		{

			StudentRating tmp = new StudentRating();

			for (int i = 0; i < this.length; i++)
			{

				for (int j = i + 1; j < this.length; j++)
				{

					if (String.Equals(sr[i].getGroup(), sr[j].getGroup()))
					{
						tmp = sr[i];
						sr[i] = sr[j];
						sr[j] = tmp;

					}

					if (sr[i].getGroup() == sr[j].getGroup())
					{

						if (sr[i].getMath() > sr[j].getMath())
						{

							tmp = sr[i];
							sr[i] = sr[j];
							sr[j] = tmp;

						}

					}

				}


			}

		}

		public void add()
		{

			Console.WriteLine("Add new student:");

			for (int i = 0; i < this.length; i++)
			{

				if (sr[i].getLastName() == "null")
				{

					Console.WriteLine("Add new student LastName:");
					sr[i].setLastName(Console.ReadLine());

					Console.WriteLine("Add new student Group:");
					sr[i].setGroup(Console.ReadLine());

					Console.WriteLine("Add new student Gradebook:");
					sr[i].setGradebook(Int32.Parse(Console.ReadLine()));

					Console.WriteLine("Add new student Math:");
					sr[i].setMath(Int32.Parse(Console.ReadLine()));

					Console.WriteLine("Add new student Phis:");
					sr[i].setPhis(Int32.Parse(Console.ReadLine()));

					Console.WriteLine("Add new student Chem:");
					sr[i].setChem(Int32.Parse(Console.ReadLine()));

					break;
				}
			}

		}

		public void edit()
		{

			Console.WriteLine("Edit student, enter LastName:");

			string ln = Console.ReadLine();

			for (int i = 0; i < this.length; i++)
			{

				if (sr[i].getLastName() == ln)
				{

					Console.WriteLine("Edit student LastName:");
					sr[i].setLastName(Console.ReadLine());

					Console.WriteLine("Edit student Group:");
					sr[i].setGroup(Console.ReadLine());

					Console.WriteLine("Edit student Gradebook:");
					sr[i].setGradebook(Int32.Parse(Console.ReadLine()));

					Console.WriteLine("Edit student Math:");
					sr[i].setMath(Int32.Parse(Console.ReadLine()));

					Console.WriteLine("Edit student Phis:");
					sr[i].setPhis(Int32.Parse(Console.ReadLine()));

					Console.WriteLine("Edit student Chem:");
					sr[i].setChem(Int32.Parse(Console.ReadLine()));

					break;
				}

				if (i == this.length - 1)
				{
					Console.WriteLine("Student whith that LastName not found !");
				}
			}


		}

		public void del()
		{

			Console.WriteLine("Delete student, enter LastName:");

			string ln = Console.ReadLine();

			for (int i = 0; i < this.length; i++)
			{

				if (sr[i].getLastName() == ln)
				{

					sr[i].setLastName("null");

					sr[i].setGroup("null");

					sr[i].setGradebook(0);

					sr[i].setMath(0);

					sr[i].setPhis(0);

					sr[i].setChem(0);

					break;
				}

				if (i == this.length - 1)
				{
					Console.WriteLine("Student whith that LastName not found !");
				}
			}


		}

		public void find()
		{

			Console.WriteLine("Find student, enter LastName:");

			string ln = Console.ReadLine();

			for (int i = 0; i < this.length; i++)
			{

				if (sr[i].getLastName() == ln)
				{

					Console.WriteLine("Student whith that LastName found !");

					break;
				}

				if (i == this.length - 1)
				{
					Console.WriteLine("Student whith that LastName not found !");
				}
			}

		}

		public void print()
		{
			for (int i = 0; i < this.length; i++)
			{
				sr[i].info();
				Console.WriteLine("-------------------------");
			}
		}

	}


	public static void Main()
	{

		Console.WriteLine("Enter number of students in array:");
		Console.WriteLine("Press - t - if you whant 10 students.");
		Console.WriteLine("Press - n - if you whant n students.");
		string n = Console.ReadLine();
		int m = 0;

		if (n == "t")
		{
			m = 10;
		}
		else
		{
			Console.WriteLine("Enter number of students:");
			m = Int32.Parse(Console.ReadLine());
		}
		StudentRatings st1 = new StudentRatings(m);

		Console.WriteLine("Press - a - if you whant add student.");
		Console.WriteLine("Press - f - if you whant find student.");
		Console.WriteLine("Press - d - if you whant delete student.");
		Console.WriteLine("Press - e - if you whant add student.");
		Console.WriteLine("Press - x - if you whant exit.");

		string x = Console.ReadLine();

		switch (x)
		{
			case "a":
				st1.add();
				break;
			case "f":
				st1.find();
				break;
			case "d":
				st1.del();
				break;
			case "e":
				st1.edit();
				break;
			case "x":
				Console.WriteLine("Exit.");
				break;
		}


		//st1.print();

	}
}