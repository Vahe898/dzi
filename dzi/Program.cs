namespace dzi
{
    internal class Program
    {
        public static int mtdFibonacci(int number)
        {
            if (number == 1) return 1;
            if (number == 2) return 1;

            return mtdFibonacci(number - 1) + mtdFibonacci(number - 2);
        }
        class night
        {
            public int numberForNight;
            public char letterForNight;
            public char[] letterSForNight = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            public void NightIsMoving(ref int inputNum, ref char inputLet)
            {
                do /*tivy kara  lini baci irranic 2 hat verev 2 hat nerqev*/
                {
                    Console.WriteLine("Enter number where to move ");
                    if (!int.TryParse(Console.ReadLine(), out numberForNight))
                    {
                        Console.WriteLine("enter right number");
                    }

                } while (numberForNight == inputNum || Math.Abs(numberForNight - inputNum) > 2);
                do
                {
                    Console.WriteLine("enter letter where to move");
                    letterForNight = Console.ReadKey().KeyChar;

                    if (Math.Abs(numberForNight - inputNum) == 2 && Math.Abs(Array.IndexOf(letterSForNight, letterForNight) - Array.IndexOf(letterSForNight, inputLet)) == 1)
                    {
                        Console.WriteLine();
                        break;
                    }
                    if (Math.Abs(numberForNight - inputNum) == 1 && Math.Abs(Array.IndexOf(letterSForNight, letterForNight) - Array.IndexOf(letterSForNight, inputLet)) == 2)
                    {
                        Console.WriteLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        do
                        {
                            Console.WriteLine("Enter number where to move ");
                            numberForNight = int.Parse(Console.ReadLine());
                        } while (numberForNight == inputNum || Math.Abs(numberForNight - inputNum) > 2);
                    }
                } while (true);
                inputNum = numberForNight;
                inputLet = letterForNight;
            }
        }
        static void enterringMyFigur(string firstPoint)
        {
            int inputNum = 0;
            char inputLet = 'a';
            char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            if (firstPoint.Length > 2)
            {
                Console.WriteLine("you were wrong");
            }
            else if (int.TryParse(firstPoint.Substring(0), out inputNum) && inputNum > 0 && inputNum < 9) /*ete arajiny tiva*/
            {
                for (int i = 0; i < letters.Length; i++)
                {
                    if (char.ToUpper(firstPoint[1]) == letters[i])
                    {
                        inputLet = char.ToUpper(firstPoint[1]);/*vercnuma dra mecatary hetgayi hamar*/
                    }
                    else if (char.ToLower(firstPoint[1]) == letters[i])
                    {
                        inputLet = char.ToUpper(firstPoint[1]);
                    }
                }
            }
            else if (int.TryParse(firstPoint.Substring(1), out inputNum) && inputNum > 0 && inputNum < 9)
            {
                for (int i = 0; i < letters.Length; i++)
                {
                    if (char.ToUpper(firstPoint[0]) == letters[i])
                    {
                        inputLet = char.ToUpper(firstPoint[0]);
                        break;
                    }
                    else if (char.ToLower(firstPoint[0]) == letters[i])
                    {
                        inputLet = char.ToUpper(firstPoint[0]);
                        break;

                    }
                }
            }
            else
            {
                Console.WriteLine("you were wrong");
            }
        }
        public struct Point
        {
            public int Num;
            public char Lett;
            public string point;


            public Point(int number,char letter)
            {
                Num = number;
                Lett = letter;
                point = number.ToString()+letter;

            }
            
        }

        public static void nightCan(int startNum,char startLet,int lastNum,char lastChar)
        {
            int nextNum1 =0; /*verevi tivna taxtaki vri 2 ov verev*/
            int nextNum2 =0; /*nerqevi tivna 2 ov nerqev*/
            char nextChar1= ' ';/*caxi tarna 1 cax*/
            char nextChar2 = ' ';/*aji tarna 1 aj*/
            int next1Num1 = 0; /*verevi tivna taxtaki vri 1 ov*/
            int next1Num2 = 0; /*nerqevi tivna 1 ov*/
            char next1Char1 = ' ';/*caxi tarna 2 ov*/
            char next1Char2 = ' ';/*aji tarna 2 ov*/
            int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8];
            char[] letters = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h'];
            

            for (int i = 0; i < numbers.Length; i++)
            {
                if (startNum - numbers[i] == 2)/*e ify u else ify nayuma dzin kara gna et tvi vra (2hat verev kam nergev)*/
                {
                    nextNum1 = numbers[i];
                    if (nextNum1 + 4 < 9)
                    {
                        nextNum2 = nextNum1 + 4;
                    }
                    break;
                }
                else if (numbers[i] - startNum == 2)
                {
                    nextNum1 = numbers[i];
                }
                
            }
            for(int i = 0; i < numbers.Length; i++)
            {
                if (startNum - numbers[i] == 1)/*e ify u else ify nayuma dzin kara gna et tvi vra (1hat verev kam nergev)*/
                {
                    next1Num1 = numbers[i];
                    if (next1Num1 + 2 < 9)
                    {
                        next1Num2 = next1Num1 + 2;
                    }
                    break;
                }
                else if (numbers[i] - startNum == 2)
                {
                    next1Num1 = numbers[i];
                }
            }
            for(int i = 0; i < letters.Length; i++)
            {
                if (Array.IndexOf(letters, startLet) - Array.IndexOf(letters, letters[i]) == 1)/*es if y else if y nayuma kara gna et tari vra (mi hat aj caxov)*/
                {
                    nextChar1 = letters[i];
                    if (Array.IndexOf(letters, nextChar1) + 2 < 8)
                    {
                        nextChar2 = letters[i + 2];
                    }
                    break;


                }
                else if (Array.IndexOf(letters, letters[i]) - Array.IndexOf(letters, startLet) == 2)
                {
                    next1Char1 = letters[i];
                }
                
            }
            for(int i = 0; i < letters.Length; i++)
            {
                if (Array.IndexOf(letters, startLet) - Array.IndexOf(letters, letters[i]) == 2)/*es if y else if y nayuma kara gna et tari vra (erku hat aj caxov)*/
                {
                    next1Char1 = letters[i];
                    if (Array.IndexOf(letters, next1Char1) + 4 < 8)
                    {
                        next1Char2 = letters[i + 4];
                    }
                    break;


                }
                else if (Array.IndexOf(letters, letters[i]) - Array.IndexOf(letters, startLet) == 2)
                {
                    next1Char1 = letters[i];
                }
            }
            Point upPointLeft2 = new Point(nextNum1,nextChar1);
            Point upPointRight2 = new Point(nextNum1, nextChar2);
            Point downPointLeft2 = new Point(nextNum2, nextChar1);
            Point downPointRight2 = new Point(nextNum2, nextChar2);
            Point upPointLeft1 = new Point(next1Num1, next1Char1);
            Point upPointRight1 = new Point(next1Num1, next1Char2);
            Point downPointLeft1 = new Point(next1Num2, next1Char1);
            Point downPointRight1 = new Point(next1Num2, next1Char2);
            Point Reched = new Point(lastNum, lastChar);
            int count = 1;
            
            Point[] arr = { upPointLeft2, upPointRight2, downPointLeft2, downPointRight2, upPointLeft1, upPointRight2, downPointLeft1, downPointRight1 };
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i].point == Reched.point)
                {
                    Console.WriteLine(count);
                    break;
                }
                else if (arr[i].Num != 0 && arr[i].Lett != ' ')/*nayuma uni et koordinaty te che*/
                {
                    count++;
                }
            }



            
            Console.WriteLine($"nextNum1 {next1Num1}, nextNum2 {next1Num2} ");
            Console.WriteLine($"nextChar1 {nextChar1}, nextChar2 {nextChar2} ");
        }
        


        static void Main(string[] args)
        {
            nightCan(3, 'c',2,'d');
            
        }
    }
}
