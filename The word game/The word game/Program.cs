using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
namespace The_word_game
{

    class Program
    {

        TaskProvaider TaskProvaider = new TaskProvaider();

        static void Main(string[] args)
        {
            new Program().Run();
        }

        void Run()
        {
            string Score_path = @"Score.data";
            string Usernickname = @"Nickname.txt";
            string Nickname = "";
            string GameAnswer;
            string Answer = "";
            string WrongAnswer = "";
            int Uscore = 0;



            using (StreamWriter sp = new StreamWriter(Usernickname, false, System.Text.Encoding.Default))
            {
                Nickname = Console.ReadLine();
                sp.WriteLine(Nickname);
            }

            Console.Clear();

            var task = TaskProvaider.GetTask();

            Console.WriteLine(task.question);



            Console.WriteLine("Enter answer: ");
            GameAnswer = Console.ReadLine();
            if (GameAnswer == task.answer)
            {
                Answers gameanswer = new Answers(Answer);
                gameanswer.ShowResult();
                Uscore = 100;
                Console.ReadKey();

            }
            else
            {
                NeprVidpovid gameanswer = new NeprVidpovid(WrongAnswer);
                gameanswer.ShowResult();

                Console.ReadKey();
            }


            string text = Answer;
            Console.WriteLine("Enter: ");
            string search = Console.ReadLine();
            Console.WriteLine("Word " + search + (text.Split(' ').Select(x => x == search).Count() > 0 ? " Існує " : "Не існує"));

            using (System.IO.StreamWriter file = new StreamWriter(Score_path, true, Encoding.Default))
            {
                file.WriteLine(Nickname + " got " + Uscore + " points");
            }
            Console.ReadKey();

        }

    }
}
                       

                       
                       
                      