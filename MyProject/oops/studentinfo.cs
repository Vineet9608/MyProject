using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.oops
{
    class studentinfo
    {
        int id;
        string name;
        int marks;
        public void student_details(int id, string name, int marks)
        {
        /*    id = 101;
            name = "vineet";
            marks = 78;
            id = 102;
            name = "khusboo";
            marks = 75;
            id = 103;
            name = "kalyani";
            marks = 65;*/
        }
            void display()
            {
                Console.WriteLine(id+" "+name+" "+marks);
            }
            static void Main(string[] args)
            {
                studentinfo s = new studentinfo();
                s.student_details(101,"vineet",78);
                s.student_details(102, "kalyani", 89);
                s.student_details(103, "bebo", 56);
                s.display();
            }
        }
    }

