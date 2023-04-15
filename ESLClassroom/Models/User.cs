using System;
using System.Collections.Generic;

namespace ESLClassroom.Models;

public partial class User
{
    public int Id { get; set; }

    public string? GoogleToken { get; set; }

    public string? GoogleName { get; set; }

    public int? TeacherId { get; set; }
}
