﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    

    public class Student
    {  
        public int studentId { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string state { get; set; }
        public int grade { get; set; }
         public List<Lesson> lessons { get; set; }
        private Random rnd = new Random();
        public Student(int studentId, string name, string surname, string phone, string email, string state, int grade)
        {
            this.studentId = studentId;
            this.name = name;
            this.surname = surname;
            this.phone = phone;
            this.email = email;
            this.state = state;
            this.grade = grade;
            var lesson = new Lesson();
            var lessons = new List<Lesson>();
            lessons = lesson.GenerateLesson(studentId,3,rnd);
            this.lessons = lessons;
        }
        public Student()
        {

        }
        public Student GenerateStudent(int studentId)
        {
            return new Student(studentId, FakeData.NameData.GetFirstName(),
                FakeData.NameData.GetSurname(), 
                FakeData.PhoneNumberData.GetPhoneNumber(),
                FakeData.NetworkData.GetEmail(), 
                FakeData.PlaceData.GetState(),
                rnd.Next(0, 100));
        }
        public List<Student> GenerateStudents(int studentCount)
        {
            var students = new List<Student>();
            for (int i = 1; i <= studentCount; i++)
            {
                students.Add(GenerateStudent(i));
            }
            return students;
        }
    }
}
