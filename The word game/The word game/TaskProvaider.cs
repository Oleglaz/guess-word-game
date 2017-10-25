using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_word_game
{
    class TaskProvaider
    {
        
        const string Gamequestion = @"Gamequestions.txt";

        StreamReader gq = new StreamReader(Gamequestion, System.Text.Encoding.Default);
        
        public GameP GetTask()
        {
            var line = gq.ReadLine();

            const char delimiter = '|';
            String[] substring = line.Split(delimiter);
            
            return new GameP(substring[0].Trim(), substring[1].Trim());
            //відслідкувати кінець файла 
            
        }    

    }
    
}
