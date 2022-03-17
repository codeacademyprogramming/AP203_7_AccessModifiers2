using System;
using _17032022.Classes.School;
using _17032022.Classes.Courses;
using _17032022.Classes;
using School;
using Library;

namespace _17032022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Name = "Ali ve Nino";
            Student student = new Student();    
            Console.WriteLine("Hello World!");
            Group group = new Group();

            _17032022.Classes.Book book1 = new Classes.Book();
            book1.Author = "";

            Classes.Courses.Teacher teacher = new Classes.Courses.Teacher();
            Classes.School.Teacher teacher1 = new Classes.School.Teacher();

            Human human = new Human();
            human.Name = "Hikmet";
            human.Surname = "Abbasov";

            Employeer employeer = new Employeer(1990);

        }
    }
}
