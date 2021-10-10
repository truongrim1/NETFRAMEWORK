using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWinform.Entities
{
    public class Person
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DOB { get; set; }

        public string HomeTown { get; set; }
        public EGioiTinh Sex { get; set; }

        public string FullName
        {
            get { return $"{ FirstName} {LastName}"; }
        }
        public string IDFaculty { get; set; }
        public static List<Person> GetList()
        {
            var ls = new List<Person>();
            ls.Add(new Person
            {
                Id = "1",
                FirstName = "Trương Công",
                LastName = "Vĩ",
                DOB = new DateTime(2000, 12, 22),
                HomeTown = "Thừa Thiên Huế",
                Sex = EGioiTinh.Nam,
                IDFaculty = "1"
            });
            ls.Add(new Person
            {
                Id = "2",
                FirstName = "Nguyễn",
                LastName = "Thị Thu",
                DOB = new DateTime(2000, 5, 6),
                HomeTown = "Đà Nẵng",
                Sex = EGioiTinh.Nu,
                IDFaculty = "2"
            });
            return ls;
        }
        public static Person Get(string id)
        {
            var dbPerson = GetList();
            //Linq to SQL
            //Lamda expression
            var person = dbPerson.Where(p => p.Id == id).FirstOrDefault();
            return person;
        }

        public static List<Person> GetList(string idFaculty)
        {
            var ls = GetList();
            var rs = ls.Where(e => e.IDFaculty == idFaculty).ToList();
            return rs;
        }
    }
    public enum EGioiTinh
    {
        Nam, Nu, Khac
    }
}
