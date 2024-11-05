using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Maui.Storage;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordle
{
    [Table("words")]
    public class Word
    {
        public Word() { }
        public Word(string text)
        {
            Text = text;
        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Text { get; set; } = null!;
        public bool HasBeenPicked { get; set; } = false;
        public DateTime LastDatePicked { get; set; } = DateTime.Now;
    }
    public class SQLiteDbContext
    {
        const string DbFileName = "sqlitedb.db3";

        static string DbPath => Path.Combine(FileSystem.AppDataDirectory, DbFileName);

        //const SQLite.SQLiteOpenFlags Flags =
        //        SQLite.SQLiteOpenFlags.ReadWrite |
        //        SQLite.SQLiteOpenFlags.Create |
        //        SQLite.SQLiteOpenFlags.SharedCache;

        private SQLiteAsyncConnection _conn;


        async Task Init()
        {
            if (_conn is not null)
            {
                return;
            }

            _conn = new SQLiteAsyncConnection(DbPath);
            await _conn.CreateTableAsync<Word>();

            var words = await _conn.Table<Word>().ToListAsync();
            if (words == null || words.Count == 0)
            {
                List<Word> list = new List<Word>
                {
                    new Word("apple"),
                    new Word("broke"),
                    new Word("chair"),
                    new Word("donut"),
                    new Word("elder"),
                    new Word("found"),
                    new Word("ghoul"),
                    new Word("harsh"),
                    new Word("index"),
                    new Word("juice"),
                    new Word("karma"),
                    new Word("liver"),
                    new Word("mount"),
                    new Word("novel"),
                    new Word("offer"),
                    new Word("query"),
                    new Word("round"),
                    new Word("south"),
                    new Word("timer"),
                    new Word("under"),
                    new Word("vocal"),
                    new Word("worth"),
                    new Word("xerox"),
                    new Word("yield"),
                    new Word("zebra")
                };

                await AddWords(list);
            }
        }

        public async Task<Word> GetRandomWord()
        {
            await Init();

            var result = await _conn.Table<Word>().ToListAsync();

            var unpickedWords = result.Where(x => !x.HasBeenPicked).ToList();

            if (unpickedWords.Count == 0)
            {
                foreach (var word in result)
                {
                    word.HasBeenPicked = false;
                }

                await _conn.UpdateAllAsync(result);
            }

            var random = new Random();
            var randomIndex = random.Next(unpickedWords.Count);
            var randomWord = unpickedWords[randomIndex];

            randomWord.HasBeenPicked = true;
            
            await _conn.UpdateAsync(randomWord);

            return randomWord;
        }

        public async Task<int> AddWords(List<Word> words)
        {
            if (words != null)
            {
                return await _conn.InsertAllAsync(words);
            }
            return 0;
        }
    }
}
