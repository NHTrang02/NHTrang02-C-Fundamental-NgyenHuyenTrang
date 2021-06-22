using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Member;

namespace Member
{
    public class Program
    {
        public int getAge(int year)
        {
            int age = DateTime.Now.Year - year;
            return age;
        }
        static List<Member> members = new List<Member>
        {
                new Member()
                {
                    FName = "Trang ",
                    LName = "Nguyen Huyen",
                    gender = "famela",
                    DateOfBirth = new DateTime(2002,7,14),
                    BirthPlace = "Hai Duong",
                    Age = 19,
                    IsGraduated = false
                },
                new Member()
                {
                    FName = "Hoang",
                    LName = "Nguyen",
                    gender = "Male",
                    DateOfBirth = new DateTime(2000,1,1),
                    BirthPlace = "Ha Noi",
                    Age = 21,
                    IsGraduated = false
                },
                new Member()
                {
                    FName = "Hoa",
                    LName = "Nguyen",
                    gender = "famela",
                    DateOfBirth = new DateTime(1999,1,1),
                    BirthPlace = "Ha Noi",
                    Age = 21,
                    IsGraduated = false
                },
                new Member(){
                    FName = "Vy",
                    LName = "Tran Thi",
                    gender = "famela",
                    DateOfBirth = new DateTime(1999,2,12),
                    BirthPlace = "Ha Noi",
                    Age = 22,
                    IsGraduated = false
                },
        };

        public static List<Member> Members { get => members; set => members = value; }
        public static List<Member> Members1 { get => members; set => members = value; }

        static void PrintList(List<Member> list)
        {
            for (int i = 1; i<=list.Count; i++)
            {
                Member member =list[i-1];
                Console.WriteLine(i +":" + member.FullName + "(" + member.Age + ")");
            }
        }

        //BR1
        static void PrintMaleMember(List<Member> members)
        {
            var list = members.Where(member => member.gender == "Male").ToList();
            PrintList(list);
        }

        //BR2
        static void PrintOldesMember(List<Member> list)
        {
            var max = list.Max(member => member.FullName + member.Age);
            Console.WriteLine(max);
            var results = list.Where(member =>member.FullName + member.Age == max).ToList();
            var result = results.FirstOrDefault();

        }

        //BR3
        static void PrintFullName(List<Member> list)
        {
            var results = list.Select(member => $"{member.LName} {member.FName} {member.Age}").ToList();
            Console.WriteLine(string.Join('\n', results));
        }

        // //BR4
        // static void CompareMembersYearOfBirth(List<Member> list, int yearOfBirth)
        // {
        //     IEnumerable<Member> enumerable = members.Where(member => member.DateOfBirth.Year < yearOfBirth);
        //     List<Member> list1 = enumerable;
        //     Console.Write("Members who has birth year lesser than 2000: ");
        //     PrintList(list1);
        //     List<Member> list2 = list.Where(member => member.DateOfBirth.Year == yearOfBirth);
        //     Console.Write("Members who has bir yeathr is 2000: ");
        //     PrintList(list2);
        //     List<Member> list3 = list.Where(member => member.DateOfBirth.Year > yearOfBirth);
        //     Console.Write("Members who has birth year greate than 2000: ");
        //     PrintList(list3);
        // }

        //BR5
        static void PrinFirstByBirthPlace(List<Member> list, string place)
        {
            var results = members.Where(member => member.BirthPlace.Equals(place, StringComparison.OrdinalIgnoreCase));
            // PrintList(results);
            Console.WriteLine(Environment.NewLine);
            var result = results.FirstOrDefault();

        }
        static void Main(string[] args)
        {
            PrintMaleMember(members);
            PrintOldesMember(members);
            // CompareMembersYearOfBirth(members, 2000);
            PrintFullName(members);
            // PrinFirstByBirthPlace(members, "Hai Duong");
        }
    }
}