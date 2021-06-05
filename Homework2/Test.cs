using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2
{
    class Test
    {
        private int _testResult = 0;
        public void FirstQuestion()
        {
            Console.WriteLine("Выберите из предложенных составных логических высказываний" +
                " только те, которые истинны. X = 10, Y = 0\n");
            Console.Write("1) X > 8 & !Y & Y > 1\n2) Y < 5 || X > 9 & X > 20\n" +
                "3) !Y || (X == Y)\n4) X < 7 & Y > 7 || Y > 5\n");
            string answer = Console.ReadLine();
            string[] subAnswer = answer.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            answer = "";
            foreach (var item in subAnswer)
            {
                answer += item;
            }
            if(answer=="23"|| answer == "32")
            {
                _testResult++;
            }
        }
        public void SecondQuestion()
        {
            Console.WriteLine("Выберите из предложенных составных логических высказываний" +
                " только те, которые ложны. X = 10, Y = 0\n");
            Console.Write("1) X > 8 || !Y & Y > 1\n2) Y = 5 || X < 3 & X < 15\n" +
                "3) X < 2 & Y < 2 || Y < 5\n4) !Y & Y > 10 & X < 15\n");
            string answer = Console.ReadLine();
            string[] subAnswer = answer.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            answer = "";
            foreach (var item in subAnswer)
            {
                answer += item;
            }
            if (answer == "24" || answer == "42")
            {
                _testResult++;
            }
        }
        public void ThridQuestion()
        {
            Console.WriteLine("Что будет выведено в консоль?\nconst int counter = 1;\n" +
                "++counter;\nConsole.WriteLine(counter);\n");
            Console.Write("1) 1\n2) 2\n" +
                "3) Не сгенерируется\n4) 0\n");
            string answer = Console.ReadLine();
            string[] subAnswer = answer.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            answer = "";
            foreach (var item in subAnswer)
            {
                answer += item;
            }
            if (answer == "3")
            {
                _testResult++;
            }
        }
        public void FourthQuestion()
        {
            Console.WriteLine("Что относится к значимым типам данных(Value Types)?\n");
            Console.Write("1) int\n2) object\n" +
                "3) string\n4) bool\n");
            string answer = Console.ReadLine();
            string[] subAnswer = answer.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            answer = "";
            foreach (var item in subAnswer)
            {
                answer += item;
            }
            if (answer == "14" || answer == "41")
            {
                _testResult++;
            }
        }
        public void FifthQuestion()
        {
            Console.WriteLine("Какая переменная будет равна 10?\nint x = 2;\nint y = 5;\n");
            Console.Write("1) int a = x + y + x + 1;\n2) int b = ++x + y + x\n" +
                "3) y-- - y + x++ + x + y\n4) 5 + --y\n");
            string answer = Console.ReadLine();
            string[] subAnswer = answer.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            answer = "";
            foreach (var item in subAnswer)
            {
                answer += item;
            }
            if (answer == "1")
            {
                _testResult++;
            }
        }
        public void SixthQuestion()
        {
            Console.WriteLine("Замените 'Ввод' так, чтобы в консоль вывелось значение 'true'\n");
            Console.Write("int x = 10;\nint y = 20;\nConsole.Write(Ввод);\n");
            string answer = Console.ReadLine();
            string[] subAnswer = answer.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            answer = "";
            foreach (var item in subAnswer)
            {
                answer += item.ToLower();
            }
            if (answer == "x!=y" || answer == "y!=x")
            {
                _testResult++;
            }
        }
        public void SeventhQuestion()
        {
            Console.WriteLine("Какая (какие) из следующих конструкций " +
                "используется (используются) для ветвления?\n");
            Console.Write("1) for\n2) do while\n3) swith case\n4) if else\n");
            string answer = Console.ReadLine();
            string[] subAnswer = answer.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            answer = "";
            foreach (var item in subAnswer)
            {
                answer += item.ToLower();
            }
            if (answer == "34" || answer == "43")
            {
                _testResult++;
            }
        }
        public void EightQuestion()
        {
            Console.WriteLine("Следующий код должен выводить в строку цифры " +
                "от 0 до 10 через пробел: '0 1 2 3 4 5 6 7 8 9 10'.\n" +
                "Какое минимальное количество исправлений нужно внести в код, чтобы получить " +
                "ожидаемый результат?\n\nstring result;\nfor ( int i = 0; i < 11; i++)\n{\n" +
                "result += i + ' ';\nConsole.WriteLine(result);\n}\n");
            Console.Write("1) 0\n2) 1\n3) 2\n4) 3\n");
            string answer = Console.ReadLine();
            string[] subAnswer = answer.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            answer = "";
            foreach (var item in subAnswer)
            {
                answer += item.ToLower();
            }
            if (answer == "3")
            {
                _testResult++;
            }
        }
        public void NinthQuestion()
        {
            Console.WriteLine("Что будет содержать переменная arg в результате " +
                "выполнения следующей программы?\n\nint arg = 5;\narg++;\nif (arg == 6)\n{" +
                "\n    for (int i = 0; int < 3; i++)\n    {\n       arg--;\n    }\n}\nelse if\n{\n  arg = 1;\n" +
                "}\n");
            Console.Write("1) 5\n2) 6\n3) 1\n4) 3\n");
            string answer = Console.ReadLine();
            string[] subAnswer = answer.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            answer = "";
            foreach (var item in subAnswer)
            {
                answer += item.ToLower();
            }
            if (answer == "4")
            {
                _testResult++;
            }
        }
        public void TenthQuestion()
        {
            Console.WriteLine("Чему будет равна переменная result после выполнения программы?\n\n" +
                "var value = \"12\";\nvar result = \"\";\n\nswitch(value)\n{\n    default:\n      " +
                "result = \"zero\";\n    case \"1\":\n      result = \"one\";\n" +
                "      break;\n    case \"2\":\n      result = \"two\";\n      break;\n}\n");
            Console.Write("1) zero\n2) one\n3) two\n4) Не скомпилируется\n");
            string answer = Console.ReadLine();
            string[] subAnswer = answer.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            answer = "";
            foreach (var item in subAnswer)
            {
                answer += item.ToLower();
            }
            if (answer == "4")
            {
                _testResult++;
            }
        }
        public void Result()
        {
            if (_testResult > 8)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Вы ответили правильно на:  " +_testResult+ " вопросов");
            }
            else if (_testResult > 5 & _testResult < 8)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Вы ответили правильно на:  " + _testResult + " вопросов");
            }
            else if (_testResult==1)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы ответили правильно на:  " + _testResult + " вопрос");
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы ответили правильно на:  " + _testResult + " вопросa");
            }
        }
    }
}
