using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{
    public class Ravenka
    {
        public int Operand1 { get; set; }
        public int Operand2 { get; set; }
        public int Rezultat { get; set; }
        public string[] znak = new[] { "+", "-", "/", "*" };
        public string CurrentZnak { get; set; }
        Random random = new Random();

        public Ravenka() {
            Generate();
        }

        
        public void Generate() {
            Operand1 = random.Next(0, 11);
            Operand2 = random.Next(0, 11);
            CurrentZnak = znak[random.Next(0, 4)];
            checkValues();
        }

        public void checkValues() { 
            if ((Operand1 < Operand2 && CurrentZnak=="-") || Operand2 == 0 || Operand1 % Operand2 != 0 || (CurrentZnak=="/" && Operand1==0))
                Generate();
        }
        

    }
}
