using System;
using System.Collections.Generic;

namespace ESLClassroom.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? StudentName { get; set; }

    public int? StudentId { get; set; }

    public int? Grade { get; set; }

    public string? ClassroomToken { get; set; }
}
