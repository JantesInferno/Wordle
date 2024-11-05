using Microsoft.Maui.Controls;

namespace Wordle
{
    public partial class App : Application
    {
        private SQLiteDbContext _context;

        public static Word SecretWord { get; private set; }

        public App(SQLiteDbContext context)
        {
            InitializeComponent();
            _context = context;

            Task.Run(async () =>
            {
                SecretWord = await _context.GetRandomWord();
            });

            MainPage = new AppShell();
        }
    }
}
