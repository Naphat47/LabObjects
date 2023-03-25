using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Student
    {
        private string name;
        private string _id;
        private int _age;
        private int _birthYear;
        private string _height;
        private string grade;
        private string major;


        public string Name {
            get { return this.name; }
        }
        public int Birthyear {
            get { return this._birthYear; }
        }
        public string Id {
            get { return this._id; }    
        }
        public string Height {
            get { return this._height; }
        }
        public string Grade {
            get { return this.grade; }
        }
        public string Major { 
            get { return this.major; }
        }

        //constructor = ตัวสร้าง
        public Student(string name, int birthYear, string id, string height, string grade, string major)
        {
            this.name = name;
            this._birthYear = birthYear;
            this._id = id;
            this._height = height; 
            this.grade = grade;
            this.major = major;
        }
        public int myAge() {
            int age = 2023 - _birthYear;
            return age;
        }
    }
}
