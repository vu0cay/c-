﻿using System;
using System.Collections.Generic;

namespace BlazorStaff.Data;

public partial class Gender
{
    public int GenderId { get; set; }

    public string? GenderName { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
