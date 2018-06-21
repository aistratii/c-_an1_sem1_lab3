using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3 {
    class Program {
        static void Main(string[] args) {
            Song song = "ana,maria,22-Jun-2018";// new Song("jora", "cardan", DateTime.Now);
            Console.WriteLine(song);

            Console.ReadKey();
        }
    }

    public class Song {
        private string author;
        private string songName;
        private DateTime released;

        public string Author {
            get => author; set => author = value;
        }

        public string SongName {
            get => songName; set => songName = value;
        }

        public DateTime Released {
            get => released; set => released = value;
        }


        public Song(string author, string songName, DateTime released) {
            this.author = author;
            this.songName = songName;
            this.released = released;
        }

        Song(string author, string songName) {
            this.author = author;
            this.songName = songName;
        }

        Song(DateTime released) {
            this.released = released;
        }

        Song() {
            author = "";
            songName = "";
            released = DateTime.Now;
        }

        public override string ToString() {
            return "(Song:{" +
                "author: " + author +
                ", songName: " + songName +
                ", released: " + released +
                "})";
        }

        public void fromAuthor(Author author) {
            this.author = author.authorName;
        }

        public static implicit operator Song(Author author) {
            return new Song(author.authorName, "");
        }

        public static implicit operator Song(String csv) {
            return new Song(csv.Split(',')[0], csv.Split(',')[1], DateTime.Parse(csv.Split(',')[2]));
        }

    }

    public class Author {
        public readonly string authorName;

        public Author(string authorName) {
            this.authorName = authorName;
        }
    }
};