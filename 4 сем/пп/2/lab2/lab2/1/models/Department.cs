using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2;

public class Department
{
    public int Id { get; set; }
    public string Title { get; private set; }

    public Department (string title)
    {
        Title = title;
    }

    public override string ToString()
    {
        return $"айди департамента: {Id}, название: {Title}";
    }
}
