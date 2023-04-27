/*
//[?] 개체 이니셜라이저(C# 3.0 특징) 
using System;

namespace ObjectInitializer
{
    class Course
    {
        public int Id { get; set; } // Id 속성
        public string Title { get; set; } // Title 속성
    }

    class ObjectInitializer
    {
        static void Main()
        {
            //[1] 속성을 사용하여 개체 초기화
            Course csharp = new Course(); csharp.Id = 1; csharp.Title = "C#";
            Console.WriteLine($"{csharp.Id} - {csharp.Title}");

            //[2] 개체 이니셜라이저를 사용하여 개체 초기화
            Course aspnet = new Course() { Id = 2, Title = "ASP.NET" };
            Console.WriteLine($"{aspnet.Id} - {aspnet.Title}");
        }
    }
}
*/

/*
using System;

class AnonymousType
{
    static void Main()
    {
        var data = new { Id = 1, Name = "익명 형식" };
        Console.WriteLine($"{data.Id} - {data.Name}");
    }
}
*/

/*
using System.Collections.Generic;
using static System.Console;

namespace NullWithObject
{
    class Person
    {
        public string Name { get; set; }
        public Address Address { get; set; }
    }

    class Address
    {
        public string Street { get; set; } = "알 수 없음";
    }

    class NullWithObject
    {
        static void Main()
        {
            var people = new Person[] { new Person { Name = "RedPlus" }, null };

            ProcessPeople(people);

            void ProcessPeople(IEnumerable<Person> peopleArray)
            {
                foreach (var person in peopleArray)
                {
                    // [1] ?.로 널 확인 후 널이면 ?? 이후의 문자열로 초기화 
                    WriteLine($"{person?.Name ?? "아무개"}은(는) " +
                        $"{person?.Address?.Street ?? "아무곳"}에 삽니다.");
                }
            }

            var otherPeople = null as Person[];

            // [2] ?[0] 형태로 인덱서에 대해서 널 값 확인 가능
            WriteLine($"첫 번째 사람: {otherPeople?[0]?.Name ?? "없음"}");
        }
    }
}
*/


//[?] yield return을 사용하여 이터레이터 구현하기
using System;
using System.Collections;

class YieldReturn
{
    //[1] 반복기(이터레이터) 구현: MultiData() 메서드는 3번 반복해서 문자열이 반환됨
    static IEnumerable MultiData()
    {
        yield return "Hello";
        yield return "World";
        yield return "C#";
    }

    static void Main()
    {
        //[2] 반복기를 foreach 문으로 호출해서 사용 
        foreach (var item in MultiData())
        {
            Console.WriteLine(item);
        }
    }
}
