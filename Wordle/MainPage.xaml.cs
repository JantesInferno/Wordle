using Microsoft.EntityFrameworkCore;
using Microsoft.Maui.Controls;

namespace Wordle
{
    public partial class MainPage : ContentPage
    {
        private SQLiteDbContext _context;

        public MainPage(SQLiteDbContext context)
        {
            InitializeComponent();
            _context = context;

            var wotd = _context.GetWordOfTheDay().Result;
            TestLabel.Text = $"{wotd.Text}";
        }

    }
}
