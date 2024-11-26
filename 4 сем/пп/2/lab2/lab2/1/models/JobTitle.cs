using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2;

public class JobTitle
{   
    public int Id { get; set; }
    public string Title { get; set; }

    public JobTitle (string title, int id)
    {
        Title = title;
    }

    public override string ToString()
    {
        return $"навзание работы: {Title}";
    }
}
