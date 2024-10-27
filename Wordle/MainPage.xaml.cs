using Microsoft.EntityFrameworkCore;
using Microsoft.Maui.Controls;

namespace Wordle
{
    public partial class MainPage : ContentPage
    {
        public MainPage(SQLiteDbContext context)
        {
            InitializeComponent();

            TestLabel.Text = $"{App.Word.Text}";
        }

    }
}
