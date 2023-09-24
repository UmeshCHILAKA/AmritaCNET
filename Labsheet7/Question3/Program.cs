using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
Store the student name and their mark percentage of a batch using Hash table. 
            Name should bethe key of hash table. 
            Perform the operations to perform
 Search for a mark percentage of specified student (Take the user input )
 Remove specified student’s entry from the hash table.
 Find the total number of data in the hash table
 Sort the data based on the mark percentage of the students
             
             */
            Hashtable students = new Hashtable();
            students.Add("Student1", "50");
            students.Add("Student2", "70");
            students.Add("Student3", "90");
            students.Add("Student4", "95");
            students.Add("Student5", "55");
            students.Add("Student6", "65");

            Console.WriteLine($"Current student record includes ");
            foreach (string key in students.Keys)
            {
                Console.WriteLine($"{key}'s score is: {students[key]}");
            }

            Console.WriteLine($"\r\nEnter the name of the student to check marks %");
            var studentName = Console.ReadLine();
            // CHeck if student exists in record before checking for marks
            if (students.ContainsKey(studentName))
            {
                Console.WriteLine($"{studentName} has achieved {students[studentName]}% of marks");
            }
            else
            {
                Console.WriteLine($"Student \"{studentName}\" does not exists in records");
            }

            Console.WriteLine($"Total number of students in record are {students.Count}");

            Console.WriteLine($"Enter the name of the student to remove from records");
            studentName = Console.ReadLine();
            // CHeck if student exists in record before checking for marks
            if (students.ContainsKey(studentName))
            {
                students.Remove(studentName);
                Console.WriteLine($"{studentName} has been removed from records");
            }
            else
            {
                Console.WriteLine($"Student \"{studentName}\" does not exists in records");
            }

            Console.WriteLine($"Total number of students in record are {students.Count}");


            // sort by values

            string[] names = new string[students.Count];
            string[] scores = new string[students.Count];

            students.Keys.CopyTo(names, 0);
            students.Values.CopyTo(scores, 0);

            Array.Sort(scores, names);//Sort by HashTable value
            for (int i = 0; i < names.Length; i++)
                Console.WriteLine($"{names[i].ToString()}'s score is: {scores[i]}");
  

              Console.ReadLine();
        }
    }
}
