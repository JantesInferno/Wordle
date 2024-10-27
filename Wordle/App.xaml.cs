using Microsoft.Maui.Controls;

namespace Wordle
{
    public partial class App : Application
    {
        private SQLiteDbContext _context;

        public static Word Word { get; private set; }

        public App(SQLiteDbContext context)
        {
            InitializeComponent();
            _context = context;

            Task.Run(async () =>
            {
                Word = await _context.GetWordOfTheDay();
            });

            MainPage = new AppShell();
        }
    }
}
