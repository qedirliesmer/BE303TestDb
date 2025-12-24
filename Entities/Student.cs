using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
    public int? StudentDetailId { get; set; }
    public StudentDetail StudentDetail { get; set; }=null!;
    public ICollection<Payment> Payments { get; set; }
    public ICollection<Group> Groups { get; set; }

}
