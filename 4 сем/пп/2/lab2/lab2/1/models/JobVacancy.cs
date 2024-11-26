using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2;

public class JobVacancy
{   
    public int Id { get; set; }
    public string Description { get; set; }
    public JobTitle Title { get; set; }

    public JobVacancy(JobTitle title, string description) { 
        Description = description;
        Title= title;
    }

    public override string ToString()
    {
        return $"айди вакансии: {Id}, название: {Title}, описание: {Description}";
    }
}
