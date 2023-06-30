using System;
using System.Security.Cryptography.X509Certificates;

namespace HolyGrail
{
    public class Program
    {
        public class Students
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int grade { get; set; }

            public List<Students> Records()
            {
                List<Students> students = new List<Students>();
                students.Add(new Students { Id = 1, Name = "Bill", grade = 450 });
                students.Add(new Students { Id = 2, Name = "Steve", grade = 760 });
                students.Add(new Students { Id = 3, Name = "Ram", grade = 600 });
                students.Add(new Students { Id = 4, Name = "Abdul", grade = 200 });
                return students;
            }
            static void Main(string[] args)
            {
                //int[] numbers = { 1, 2, 3, 5, 6, 7, 8, 9, 10 };
                //var numQuery =
                //    from num in numbers
                //    where num % 2 == 0
                //    select num;
                //foreach (int num in numQuery)
                //{
                //    //Console.WriteLine( num );
                //}

                //int[] numbers2 = { 1, 2, -5, -7, -22, -77, 293, 6, 8, -9, -10 };
                //var numQuery2 = from num in numbers2
                //                where num > 0
                //                where num < 12
                //                select num;
                //foreach (int num in numQuery2)
                //{
                //    //Console.WriteLine(num);
                //}

                //int[] numbers3 = { 1, 2, 3, 4, 5, 6, 7 };
                //var numQuery3 = from int num in numbers3
                //                let square = num * num
                //                select new { num, square };
                //foreach (var num in numQuery3)
                //{
                //    //Console.WriteLine(num);
                //}

                //int[] numbers4 = { 1, 3, 3, 56, 7, 9, 0, 82, 67, 99, 9, 3, 6, 7 };
                //var num = from x in numbers4
                //          group x by x into y
                //          select y;
                //
                //foreach (var n in num)
                //{
                //    Console.WriteLine($"Number {n.Key} appears {n.Count()} times");
                //}

                //    string word =  Console.ReadLine() ;
                //    var count = word.GroupBy(x => x)
                //        .Select(x => new
                //        {
                //            Character = x.Key,
                //            Count = x.Count()
                //        });
                //    foreach (var x in count) 
                //    {

                //        Console.WriteLine($"Letter {x} appears {x.Count} times");
                //    }
                //}


                //int[] numbers7 = { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };
                //var num = from x in numbers7
                //          group x by x into y
                //          select y;


                //foreach (var n in num)
                //{
                //    Console.WriteLine($"{n.Key} {n.Sum()} {n.Count()}");
                //}

                //}
                //string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
                //char start = 'A';
                //char end = 'M';
                //var city = from x in cities
                //           where x.StartsWith(start) && x.EndsWith(end)
                //           select x;
                //foreach (var c in city)
                //{
                //    Console.WriteLine(c);
                //}

                //int[] numbers = { 1, 2, 55, 200, 740, 76, 230, 482, 95 };
                //var num = from x in numbers
                //          where x > 80
                //          select x;
                //foreach ( var number in num )
                //{
                //    Console.WriteLine(number);
                //}
                // List <int> numbers = new List <int> (5);
                //numbers.Add (Convert.ToInt32(Console.ReadLine()));
                //numbers.Add(Convert.ToInt32(Console.ReadLine()));
                //numbers.Add(Convert.ToInt32(Console.ReadLine()));
                //numbers.Add(Convert.ToInt32(Console.ReadLine()));
                //numbers.Add(Convert.ToInt32(Console.ReadLine()));
                //Console.WriteLine("Input the value");
                //int value = Convert.ToInt32(Console.ReadLine());
                //var greater = from x in numbers
                //              where x > value
                //              select x;
                //foreach (int num in greater) 
                //{
                //    Console.WriteLine($"{num} is greater than {value}");
                ////}
                //List<int> records = new List<int>();
                //records.Add(1);
                //records.Add(2);
                //records.Add(3);
                //records.Add(4);
                //records.Add(5);
                //records.Add(6);
                //records.Add(7);
                //foreach (var num in records)
                //{
                //    Console.WriteLine(num + " ");
                //}

                //Console.WriteLine("How many  records you want to display ? ");
                //int value = Convert.ToInt32(Console.ReadLine());
                //records.Sort();
                //records.Reverse();
                //foreach (int record in records.Take(value)) 
                //{
                //    Console.WriteLine($"Top records are: {record}");
                ////}
                //string[] array;
                //int n, i;
                //n=Convert.ToInt32(Console.ReadLine());
                //array = new string[n];
                //for (i=0; i<n;i++)
                //{
                //    array[i] = Console.ReadLine();
                //}
                //string newelement = String.Join(",", array
                //    .Select(s => s.ToString())
                //    .ToArray());
                //Console.WriteLine(newelement);


                //Students s = new Students();
                //int grPointRank = Convert.ToInt32(Console.ReadLine());
                //var students = s.Records();
                //var fin = (from dent in students
                //                group dent by dent.grade into g
                //                orderby g.Key descending
                //                select new
                //                {
                //                    Records = g.ToList()
                //                }).ToList();
                //fin[grPointRank - 1].Records
                //.ForEach(i => Console.WriteLine(" Id : {0},  Name : {1},  achieved Grade Point : {2}", i.Id , i.Name, i.grade));

                //Console.ReadKey();
            }
        }
    }
}
 
