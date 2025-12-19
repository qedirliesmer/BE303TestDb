using BE303TestDb.Context;
using BE303TestDb.Entities;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");


AppDbContext _context = new();

Student s1 = new()
{
    FullName = "Asmar Gadirli",
    Age = 19
};

Student s2 = new()
{
    FullName = "Ilkin Memmedov",
    Age = 20
};
Student s3 = new()
{
    FullName = "Aydan Asgarzade",
    Age = 21
};

Student s4 = new()
{
    FullName = "Turan Jafarov",
    Age = 18
};
//Student student = _context.Students.Find(2)!;
//student.FullName = "Tavat Qasimzade";
//_context.Students.Update(student);
//_context.SaveChanges();

//var modifiedStudent = new Student
//{
//    Id = 2,
//    FullName= "Tavat Qasimzade",
//    Age=20
//};
//_context.Entry(modifiedStudent).State = EntityState.Modified;
//_context.Update(modifiedStudent);
//_context.SaveChanges();

//_context.Students.Where(s => s.Id > 2)
//    .ExecuteUpdate(s => s.SetProperty(st => st.Age, st => 18));

//Student student = _context.Students.Find(3)!;
//_context.Students.Remove(student);
//_context.SaveChanges();

//var deletedStudent = new Student
//{
//    Id = 2,
//    FullName = "Tavat Qasimzade",
//    Age = 20
//};
//_context.Entry(deletedStudent).State = EntityState.Deleted;
//_context.Remove(deletedStudent);
//_context.SaveChanges();

_context.Students.Where(s=>s.FullName=="Aydan Asgarzade").ExecuteDelete();


//_context.Entry(s3).State = EntityState.Added;
//_context.Students.AddRange(s1, s2);
//_context.Add(s4);
//_context.SaveChanges();

//Console.WriteLine(_context.Entry(s1).State);

//_context.Students.Add(s1);

//Console.WriteLine(_context.Entry(s1).State);
//_context.SaveChanges();
//Console.WriteLine(_context.Entry(s1).State);
//Student? student = _context.Students.Find(1);
//Console.WriteLine(_context.Entry(student).State);
//_context.Students.Remove(student!);
//Console.WriteLine(_context.Entry(student).State);

//_context.SaveChanges();