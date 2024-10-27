using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordle.Data.Domain.Entities
{
    public class Word
    {
        public Word() { }
        public Word(string text)
        {
            Text = text;
        }

        public Guid Id { get; set; } = Guid.NewGuid();
        public string Text { get; set; } = null!;
        public bool HasBeenPicked { get; set; } = false;
        public DateTime LastDatePicked { get; set; } = DateTime.Now;
    }
}
