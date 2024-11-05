using Microsoft.EntityFrameworkCore;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Compatibility;
using Grid = Microsoft.Maui.Controls.Grid;

namespace Wordle
{
    public partial class MainPage : ContentPage
    {
        public MainPage(SQLiteDbContext context)
        {
            InitializeComponent();

            CreateGrid();
        }

        private void CreateGrid()
        {
            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    var frame = new Frame
                    {
                        BackgroundColor = Colors.White,
                        CornerRadius = 5,
                        HasShadow = true,
                        BorderColor = Colors.Black,
                        Shadow = new Shadow
                        {
                            Opacity = 2,
                            Radius = 5,
                            Offset = new Point(0, 0)
                        },
                        Padding = 0
                    };

                    var entry = new Entry
                    {
                        WidthRequest = 50,
                        HeightRequest = 50,
                        FontSize = 24,
                        HorizontalTextAlignment = TextAlignment.Center,
                        VerticalTextAlignment = TextAlignment.Center,
                        MaxLength = 1,
                        TextTransform = TextTransform.Uppercase
                    };

                    frame.Content = entry;

                    entry.Completed += OnEntryCompleted;
                    entry.TextChanged += OnEntryTextChanged;
                    //entry.Focused += OnEntryFocused;

                    Grid.SetRow(frame, row);
                    Grid.SetColumn(frame, col);
                    wordleGrid.Children.Add(frame);
                }
            }
        }

        //private void OnEntryFocused(object sender, System.EventArgs e)
        //{

        //}

        private void OnEntryCompleted(object sender, System.EventArgs e)
        {
            var entry = sender as Entry;

            if (IsLastInRow(entry))
            {
                HandleSubmit();
            }
        }

        private void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            var entry = sender as Entry;

            if (!IsFirstInRow(entry) && string.IsNullOrEmpty(entry.Text))
            {
                var previousEntry = GetPreviousEntry(entry);
                previousEntry?.Focus();
            }
            else
            {
                if (!IsLastInRow(entry) && !string.IsNullOrEmpty(entry.Text))
                {
                    var nextEntry = GetNextEntry(entry);
                    nextEntry?.Focus();
                }
            }
        }

        private Entry GetNextEntry(Entry currentEntry)
        {
            var currentFrame = wordleGrid.Children
                .FirstOrDefault(child => child is Frame frame && frame.Content == currentEntry) as Frame;

            if (currentFrame != null)
            {
                var currentIndex = wordleGrid.Children.IndexOf(currentFrame);

                if (currentIndex >= 0 && currentIndex + 1 < wordleGrid.Children.Count)
                {
                    var nextFrame = wordleGrid.Children[currentIndex + 1] as Frame;
                    return nextFrame?.Content as Entry;
                }
            }
            return null;
        }

        private Entry GetPreviousEntry(Entry currentEntry)
        {
            var currentFrame = wordleGrid.Children
                .FirstOrDefault(child => child is Frame frame && frame.Content == currentEntry) as Frame;

            if (currentFrame != null)
            {
                var currentIndex = wordleGrid.Children.IndexOf(currentFrame);

                if (currentIndex > 0)
                {
                    var previousFrame = wordleGrid.Children[currentIndex - 1] as Frame;
                    return previousFrame?.Content as Entry;
                }
            }
            return null;
        }

        private bool IsLastInRow(Entry currentEntry)
        {
            var currentFrame = wordleGrid.Children
                .FirstOrDefault(child => child is Frame frame && frame.Content == currentEntry) as Frame;

            if (currentFrame != null)
            {
                int currentRow = Grid.GetRow(currentFrame);
                int totalColumns = 5;
                return Grid.GetColumn(currentFrame) == totalColumns - 1;
            }
            return false;
        }

        private bool IsFirstInRow(Entry currentEntry)
        {
            var currentFrame = wordleGrid.Children
                .FirstOrDefault(child => child is Frame frame && frame.Content == currentEntry) as Frame;

            if (currentFrame != null)
            {
                int currentRow = Grid.GetRow(currentFrame);
                return Grid.GetColumn(currentFrame) == 0;
            }
            return false;
        }

        private void HandleSubmit()
        {
            var currentRowEntries = wordleGrid.Children
                .OfType<Frame>()
                .Where(f => Grid.GetRow(f) == GetCurrentRow())
                .Select(f => f.Content as Entry)
                .ToArray();

            var secretWord = App.SecretWord.Text;
            var guessedWord = string.Join("", currentRowEntries.Select(x => x.Text)).ToLower();

            var letterFrequency = new Dictionary<char, int>();

            foreach (char letter in App.SecretWord.Text)
            {
                if (letterFrequency.ContainsKey(letter))
                {
                    letterFrequency[letter]++;
                }
                else
                {
                    letterFrequency[letter] = 1;
                }
            }

            var resultColors = new List<Color>(new Color[guessedWord.Length]);

            for (int i = 0; i < guessedWord.Length; i++)
            {
                if (guessedWord[i] == secretWord[i])
                {
                    resultColors[i] = Colors.Green;
                    letterFrequency[guessedWord[i]]--;
                }
                else
                {
                    resultColors[i] = Colors.Transparent;
                }
            }

            for (int i = 0; i < guessedWord.Length; i++)
            {
                if (resultColors[i] != Colors.Green && letterFrequency.ContainsKey(guessedWord[i]) && letterFrequency[guessedWord[i]] > 0)
                {
                    resultColors[i] = Colors.Yellow;
                    letterFrequency[guessedWord[i]]--;
                }
            }

            for (int i = 0; i < currentRowEntries.Length; i++)
            {
                currentRowEntries[i].BackgroundColor = resultColors[i];
            }

            if (guessedWord == App.SecretWord.Text)
            {
                DisplayAlert("Submitted Word", $"Congratulations! Today's word was {App.SecretWord.Text}", "OK");
            }
            else
            {
                MoveToNextRow();
            }
        }

        private int GetCurrentRow()
        {
            var focusedFrame = wordleGrid.Children
                .OfType<Frame>()
                .FirstOrDefault(f => f.Content is Entry entry && entry.IsFocused);

            return focusedFrame != null ? Grid.GetRow(focusedFrame) : 0;
        }

        private void MoveToNextRow()
        {
            int currentRow = GetCurrentRow();
            int nextRow = currentRow + 1;

            if (nextRow < 6)
            {
                var firstFrameInNextRow = wordleGrid.Children
                    .OfType<Frame>()
                    .FirstOrDefault(f => Grid.GetRow(f) == nextRow);

                var firstEntryInNextRow = firstFrameInNextRow?.Content as Entry;
                firstEntryInNextRow?.Focus();
            }
            else
            {
                DisplayAlert("Game Over", "You've used up all your guesses!", "OK");
            }
        }
    }
}
