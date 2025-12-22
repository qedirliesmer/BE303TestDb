using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE303TestDb.Entities;

public class Student
{
    public int Id { get; set; }
    public string FullName { get; set; } = null!;
    public int Age { get; set; }
    public double Score { get; set; }
    public bool IsActive { get; set; }
    public string Group { get; set; }

}
