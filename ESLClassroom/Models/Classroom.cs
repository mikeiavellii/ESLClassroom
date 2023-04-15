using System;
using System.Collections.Generic;

namespace ESLClassroom.Models;

public partial class Classroom
{
    public int Id { get; set; }

    public string? GoogleToken { get; set; }

    public string? ClassroomToken { get; set; }
}
