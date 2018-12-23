using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devdas_Chatterjee_EX03
{
    class Program
    {
        // private static string id, name;

        private static LinkedList<Student> linkStudent = new LinkedList<Student>();
        static void Main(string[] args)
        {
            //Add 5 students
            linkStudent.AddFirst(new Student("1111", "Felix"));
            linkStudent.AddFirst(new Student("2222", "Max"));
            linkStudent.AddFirst(new Student("3333", "Jojo"));
            linkStudent.AddFirst(new Student("4444", "Karina"));
            linkStudent.AddFirst(new Student("5555", "Alexei"));
            PrintLinkedList(linkStudent);

            //Add student using method
            Console.WriteLine("\nEnter ID and Student Name to Add a new student Student");

            Console.Write("\nID: ");
            string InsertID = Console.ReadLine();
            Console.Write("\nName: ");
            string InsertName = Console.ReadLine();
            Student student = new Student(InsertID, InsertName);

            AddLinkedListItem(linkStudent, student);
            
            PrintLinkedList(linkStudent);

            //Search a student
            Console.WriteLine("\nEnter ID and Student Name to Search Student");

            Console.Write("\nID: ");
            string searchid = Console.ReadLine().ToString();
            Console.Write("\nName: ");
            string searchname = Console.ReadLine().ToString();
            Student searchStudent = new Student(searchid, searchname);

            SearchLinkedListItem(linkStudent, searchStudent);

            //Delete a student
            Console.WriteLine("\nEnter ID and Student Name to Remove a Student");

            Console.Write("\nID: ");
            string deleteid = Console.ReadLine().ToString();
            Console.Write("\nName: ");
            string deletename = Console.ReadLine().ToString();
            Student deletStudent = new Student(deleteid, deletename);

            RemoveLinkedListItem(linkStudent, deletStudent);

            PrintLinkedList(linkStudent);

            //Remove all student
            Console.Write("\nStudent Count: " + linkStudent.Count.ToString());
            RemoveAllLinkedListItems(linkStudent);
            Console.Write("\nRemoving all students--------------------");
            Console.Write("\nStudent Count(After Removing): " + linkStudent.Count.ToString());

            Console.ReadKey();
        }
        private static void AddLinkedListItem(LinkedList<Student> list, Student students)
        {
            list.AddFirst(students);
            
        }
        private static void PrintLinkedList<T>(LinkedList<T> list)
        {
            Console.WriteLine("Student list: ");

            foreach (var value in list)
            {
                Console.Write($"{value} ");
            }

            Console.WriteLine();
        }
        private static void RemoveLinkedListItem(LinkedList<Student> list, Student students)
        {
            LinkedListNode<Student> currentNode = list.Find(students);
            try
            {
                if (currentNode.Value != null)
                {
                    list.Remove(currentNode.Value);

                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Student not found. " + e.ToString());
            }
        }
        private static void RemoveAllLinkedListItems(LinkedList<Student> list)
        {
            list.Clear();
        }

        private static void SearchLinkedListItem(LinkedList<Student> list, Student students)
        {
            LinkedListNode<Student> currentNode = list.Find(students);

            try
            {

                if (currentNode.Value != null)
                {
                    Console.WriteLine("Student Found");
                }
                else
                {
                    Console.WriteLine("Student Not Found");
                }
            }

            catch (NullReferenceException e)
            {
                Console.WriteLine("Student not found. " + e.ToString());
            }


        }
    }
    
}
