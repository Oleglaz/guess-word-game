using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_word_game
{
    class NeprVidpovid
    {
        public string WrongAnswer;
        public NeprVidpovid()
        { }

        public NeprVidpovid(string Answer)
        {
            this.WrongAnswer = Answer;
        }

        public void ShowResult()
        {
            Console.WriteLine("You lose 100 points!");
        }
    }
    class NeprVidpovidpobykvax
    {
        public string WrongOneLetter;
        public NeprVidpovidpobykvax()
        { }

        public NeprVidpovidpobykvax(string WrongOneLetterAnswer)
        {
            this.WrongOneLetter = WrongOneLetterAnswer;
        }

        public void ShowResult()
        {
            Console.WriteLine("You lose 1 point!");
        }
    }
    class Nematakoividpovidi
    {
        public string WrongLetterAnswer;
        public Nematakoividpovidi()
        { }

        public Nematakoividpovidi(string WrongLetterAnswer)
        {
            this.WrongLetterAnswer = WrongLetterAnswer;
        }

        public void ShowResult()
        {
            Console.WriteLine("This letter does not exist in word!!");
        }
    }
}
