using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpConsoleApplication
{
    public class SetStudentDetail
    {
        private string identificationCard;

        public decimal Mark { get; }

        public SetStudentDetail(string StudentName, 
                               string StudentId, 
                               string IdentificationCard, 
                               decimal Mark)
        {
            this.StudentName = StudentName;
            this.StudentId = StudentId;
            this.identificationCard = IdentificationCard;
            this.Mark = Mark;
        }

        public string StudentName { get; }
        public string StudentId { get; }

        public class Student
        {
            static void Main(string[] args)
            {

                void DisplayAllStudentDetails(List<SetStudentDetail> person)
                {

                    person.Sort((p1, p2) => string.Compare(p1.StudentName, p2.StudentName));

                    foreach (SetStudentDetail p in person)
                    {
                        Console.WriteLine("\t" + p.StudentName + "\t\t\t" + p.StudentId + "\t\t\t" + p.identificationCard);
                    }

                }

                void DisplayAllStudentRanking(List<SetStudentDetail> person)
                {

                    person.Sort((p1, p2) => p2.Mark.CompareTo(p1.Mark));

                    foreach (SetStudentDetail p in person)
                    {
                        Console.WriteLine("\t" + p.Mark + "\t\t\t" + p.StudentName);
                    }

                }

                List<SetStudentDetail> person = new List<SetStudentDetail>(5);

                person.Add(new SetStudentDetail("Alexander", "BDM1201", "123456789012", 76));
                person.Add(new SetStudentDetail("Brendon ", "BDM1202", "102938475625", 90));
                person.Add(new SetStudentDetail("Cassi", "BDM1203", "564789320578", 65));
                person.Add(new SetStudentDetail("Ketty", "BDM1204", "5647385002845", 45));
                person.Add(new SetStudentDetail("Lauren", "BDM1205", "223409867340", 55));

                Console.WriteLine("\t\t\tStudent Details:");
                DisplayAllStudentDetails(person);

                Console.WriteLine("\n\t\t\tStudent Ranking:");
                DisplayAllStudentRanking(person);

                Console.ReadLine();

            }

        }

    }

}