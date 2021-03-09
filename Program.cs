using System;

namespace İnterfaces
{
	class Program
	{
		static void Main(string[] args)
		{

			

			PersonManager personManager = new PersonManager();
			


			Costomer costomer = new Costomer() {Id=1, FirstName="Murat", LastName="Karagöz", CostomerNo="5" };

			Workerr workerr = new Workerr() { Id = 2, FirstName = "Fırat", LastName = "Demir", PersonalityNo = "7" };

			personManager.Add(workerr);
			personManager.Add(costomer);
			}
			interface IPerson
			{
			  int Id { get; set; }
				 string FirstName { get; set; }
				 string LastName { get; set; }
			}
			class Costomer : IPerson
			{
				public int Id { get ; set ; }
				public string FirstName { get ; set ; }
				public string LastName { get ; set ; }
				public string CostomerNo { get; set; }
			}
			class Workerr : IPerson
			{
				public int Id { get; set; }
				public string FirstName { get; set; }
				public string LastName { get; set; }
				public string PersonalityNo { get; set; }
			}
			class PersonManager
			{
				public void Add(IPerson person)
				{
					Console.WriteLine(person.FirstName);
				}
			
		
		}
	}
}
