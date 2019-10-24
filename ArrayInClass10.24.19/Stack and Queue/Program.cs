using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //stacks
            //declaration
            Stack<Student> stackOfStudents = new Stack<Student>();

            //push objects onto stack
            stackOfStudents.Push(new Student("Bill"));
            stackOfStudents.Push(new Student("Jill"));
            stackOfStudents.Push(new Student("Jack"));

            //traversal
            foreach(Student s in stackOfStudents)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine(stackOfStudents.Count);
            Console.WriteLine();

            //pops
            int size = stackOfStudents.Count;
            for(int i=0; i<size; i++)
            {
                Console.WriteLine(stackOfStudents.Pop().Name);

            }
            Console.WriteLine(stackOfStudents.Count);
            Console.WriteLine();

            //queue
            Queue<Student> studentQueue = new Queue<Student>();

            //put items in the queue
            studentQueue.Enqueue(new Student("Bill"));
            studentQueue.Enqueue(new Student("Jill"));
            studentQueue.Enqueue(new Student("Jack"));

            //traversal
            foreach(Student s in studentQueue)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine(studentQueue.Count);
            Console.WriteLine();

            size = studentQueue.Count;
            for (int i=0; i<size; i++)
            {
                Console.WriteLine(studentQueue.Dequeue().Name);
            }
            Console.WriteLine(studentQueue.Count);
            Console.WriteLine();
        }
    }
}
