using BE303TestDb.Context;
using BE303TestDb.Entities;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");


AppDbContext _context = new();

Student s1 = new()
{
    FullName = "Asmar Gadirli",
    Age = 19,
    Score = 88.5,
    IsActive = true,
    Group = "CS-101"
};
Student s2 = new()
{
    FullName = "Ilkin Memmedov",
    Age = 20,
    Score = 86,
    IsActive = true,
    Group = "CS-101"
};

Student s3 = new()
{
    FullName = "Nuray Tagiyeva",
    Age = 19,
    Score = 75,
    IsActive = false,
    Group = "CS-101"
};

Student s4 = new()
{
    FullName = "Aysel Memmedova",
    Age = 20,
    Score = 90,
    IsActive = true,
    Group = "CS-101"
};

Student s5 = new()
{
    FullName = "Turan Huseynli",
    Age = 18,
    Score = 74.5,
    IsActive = false,
    Group = "CS-101"
};

Student s6 = new()
{
    FullName = "Polad Gadirli",
    Age = 18,
    Score = 83.5,
    IsActive = true,
    Group = "CS-103"
};

Student s7 = new()
{
    FullName = "Nargiz Ahmedova",
    Age = 21,
    Score = 91,
    IsActive = true,
    Group = "CS-103"
};

Student s8 = new()
{
    FullName = "Yusif Memmedli",
    Age = 18,
    Score = 79,
    IsActive = false,
    Group = "CS-103"
};

Student s9 = new()
{
    FullName = "Turan Ceferov",
    Age = 19,
    Score = 88,
    IsActive = true,
    Group = "CS-103"
};

Student s10 = new()
{
    FullName = "Aydan Asgarzada",
    Age = 20,
    Score = 90.5,
    IsActive = true,
    Group = "CS-103"
};

Student s11 = new()
{
    FullName = "Nizami Hesenli",
    Age = 19,
    Score = 76,
    IsActive = false,
    Group = "CS-102"
};

Student s12 = new()
{
    FullName = "Narmin Guliyeva",
    Age = 20,
    Score = 77.5,
    IsActive = false,
    Group = "CS-102"
};

Student s13 = new()
{
    FullName = "Valeh Memmedov",
    Age = 20,
    Score = 92.5,
    IsActive = true,
    Group = "CS-102"
};

Student s14 = new()
{
    FullName = "Tavat Qasimzade",
    Age = 19,
    Score = 90,
    IsActive = true,
    Group = "CS-102"
};

Student s15 = new()
{
    FullName = "Fidan Aliyeva",
    Age = 18,
    Score = 75,
    IsActive = false,
    Group = "CS-102"
};



//_context.Students.Add(s1);
//_context.Students.Add(s2);
//_context.Students.Add(s3);
//_context.Students.Add(s4);
//_context.Students.Add(s5);
//_context.Students.Add(s6);
//_context.Students.Add(s7);
//_context.Students.Add(s8);
//_context.Students.Add(s9);
//_context.Students.Add(s10);
//_context.Students.Add(s11);
//_context.Students.Add(s12);
//_context.Students.Add(s13);
//_context.Students.Add(s14);
//_context.Students.Add(s15);

//first task
//var activeStudents = _context.Students
//    .Where(s => s.IsActive)
//    .Select(s => new { s.FullName, s.Score })
//    .ToList();


//foreach (var student in activeStudents)
//{
//    Console.WriteLine($"{student.FullName} {student.Score}");
//}
//_context.SaveChanges();


//second task
//var students= _context.Students.OrderBy(s=>s.Score)
//    .ThenByDescending(s=>s.Score)
//    .ToList();

//foreach (var s in students)
//{
//    Console.WriteLine($"{s.Group} - {s.FullName} - {s.Score}");
//}


//third task
//int pageNumber = 2;
//int pageSize = 5;

//var pagedStudents = _context.Students
//    .OrderBy(s => s.Id)
//    .Skip((pageNumber - 1) * pageSize)
//    .Take(pageSize)
//    .ToList();

//foreach (var s in pagedStudents)
//{
//    Console.WriteLine(
//        $"Id: {s.Id}, Name: {s.FullName}, Age: {s.Age}, Score: {s.Score}, Group: {s.Group}"
//    );
//}

//fourth task
//var student = _context.Students
//    .OrderByDescending(s => s.Score)
//    .First();

//Console.WriteLine($"{student.FullName} - {student.Score}");

//var student = _context.Students
//    .SingleOrDefault(s => s.Group == "CS-301");

//if (student == null)
//{
//    Console.WriteLine("There is no student for group CS-301");
//}
//else
//{
//    Console.WriteLine(student.FullName);
//}

//var student = _context.Students.Find(5);
//if (student != null)
//{
//    Console.WriteLine(student.FullName);
//}
//else
//{
//    Console.WriteLine("Student is not found");
//}


//fifth task
//bool hasHighScore = _context.Students.Any(s => s.Score > 90);

//if (hasHighScore)
//{
//    Console.WriteLine("Yes");
//}
//else
//{
//    Console.WriteLine("No");
//}

//bool allActiveAbove18 = _context.Students
//    .Where(s => s.IsActive) 
//    .All(s => s.Age > 22);

//if (allActiveAbove18)
//{
//    Console.WriteLine("There are students who have age upper 18");
//}
//else
//{
//    Console.WriteLine("There are no students who have age upper 18");
//}

//bool hasGroupB = _context.Students
//    .Select(s => s.Group)
//    .Contains("CS-301");

//if (hasGroupB)
//{
//    Console.WriteLine("There is CS-301 Group");
//}
//else
//{
//    Console.WriteLine("There is not CS-301 Group");
//}

//sixth task

//double averageScore = _context.Students.Average(s => s.Score);
//Console.WriteLine($"Avarage score of Students: {averageScore}");

//double maxScore = _context.Students.Max(s => s.Score);
//Console.WriteLine($"Max Score: {maxScore}");

//double minScore = _context.Students.Min(s => s.Score);
//Console.WriteLine($"Min Score: {minScore}");

//double totalScore = _context.Students.Sum(s => s.Score);
//Console.WriteLine($"Total Score: {totalScore}");

//7th task-Qisa cavab


//LINQ query-lərdə IQueryable hissəsi hələ DB-yə göndərilməyən əməliyyatlar üçün istifadə olunur (məs: Where, OrderBy).
//IEnumerableda isə data artıq ramda olduqdan sonra istifadə olunur (məs: ToList-dən sonra filter).
//Əgər ToList() səhv yerdə yazılsa, bütün data əvvəlcədən DB-dən rama çəkilir və sonrakı əməliyyatlar ramda icra olunur ki, bu performansı azaldır.