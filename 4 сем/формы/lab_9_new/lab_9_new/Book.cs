using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9_new
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AuthorId { get; set; }
        [Range(0, 1000)]
        public int PageCount { get; set; }
        public int PublisherId { get; set; }
        public int YearPublished { get; set; }
        [RegularExpression(@"^(pdf|epub|txt)$", ErrorMessage = "Format must be 'pdf', 'epub', or 'txt'.")]
        public string Format { get; set; }
        public byte[] Images { get; set; }

        public Author Author { get; set; } //многое ко многим(вводит того автора, что уже есть)
        public Publisher Publisher { get; set; } //многое ко многим
        public Book()
        {
        }
        public Book( string name, int authorId, int pageCount, int publisherId, int yearPublished, string format, byte[] images)
        {
            Name = name;
            AuthorId = authorId;
            PageCount = pageCount;
            PublisherId = publisherId;
            YearPublished = yearPublished;
            Format = format;
            Images = images;
        }
    }
}
