// Name: Husayn Arafa Moussa
// Student ID: 225113749

using System;

namespace CselllTask1
{
    public class StudentList
    {
        public Student? First;
        public Student? Last;
        public int Count;

        public StudentList()
        {
            First = null;
            Last = null;
            Count = 0;
        }

        public void AddFront(int id)
        {
            Student newStudent = new Student(id);
            if (First == null)
            {
                First = newStudent;
                Last = newStudent;
            }
            else
            {
                newStudent.Next = First;
                First = newStudent;
            }
            Count++;
        }

        public void AddEnd(int id)
        {
            Student newStudent = new Student(id);
            if (Last == null)
            {
                First = newStudent;
                Last = newStudent;
            }
            else
            {
                Last.Next = newStudent;
                Last = newStudent;
            }
            Count++;
        }

        public bool Remove(int id)
        {
            if (First == null) return false;

            if (First.Id == id)
            {
                First = First.Next;
                if (First == null)
                {
                    Last = null;
                }
                Count--;
                return true;
            }

            Student current = First;
            while (current.Next != null)
            {
                if (current.Next.Id == id)
                {
                    current.Next = current.Next.Next;
                    if (current.Next == null)
                    {
                        Last = current;
                    }
                    Count--;
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void Reverse()
        {
            if (First == null || First == Last) return;

            Student? prev = null;
            Student? current = First;
            Student? next = null;

            Last = First;

            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            First = prev;
        }

        public void Print()
        {
            Student? current = First;
            while (current != null)
            {
                Console.Write(current.Id + (current.Next != null ? " " : ""));
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
