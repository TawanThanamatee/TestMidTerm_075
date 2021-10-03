using System;
using System.Collections.Generic;

namespace TestMidTerm_01
{
    enum Menu //สร้างEnumเพื่อนำไปเป็นทางเลือกของInputMenu
    {
        Play_game = 1,
        Exit
    }
    class Program
    {
        static void Main(string[] args)
        {
            PrintHeader();
            InputMenu();
           
        }
        static void PrintHeader() //แสงข้อความFirstSreen
        {
            Console.WriteLine("Welcome to Hangman Game");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1. Play game \n2. Exit");
        }
        static void InputMenu() //แสดงข้อความและInputค่า
        {
            Console.Write("Please Select Menu : ");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));
            ShowMenu(menu);
        }
        static void ShowMenu(Menu menu) //ทำเงื่อนไขเมื่อInputค่าว่าแต่ละหมายเลขจะทำเงื่อนไขอะไรบ้าง
        {
            if (menu == Menu.Play_game)
            {
                PrintHeader_PlayGame();
                ListWords();
            }
            else if (menu == Menu.Exit) ;
            else
            {
                Console.WriteLine("Plese input menu agian.");
                InputMenu(); //เมื่อInputค่าที่ไม่มีอยูในEnumจะให้Inputค่าใหม่
            }
        }
        static void PrintHeader_PlayGame() //Printข้อความตอนเริ่มเกม
        {
            Console.Clear();
            Console.WriteLine("Play Game Hangman");
            Console.WriteLine("-----------------");
        }
        static void ListWords() //นำชื่อMethodในclass listWords มารวมเพื่อนำไปใช้งานใน void Main
        {
            listWords listwords = new listWords();

            listwords.Listwords();
            listwords.Position();
        }
    }
    class listWords  //classเก็บข้อมูลและคำศัพที่นำมาใช้เล่นเกม
    {
        public string RandomWord;
        public char[] Many_Words;
        public string ListWords01;
        public void Listwords()
        { 
            string[] listWords = new string[3];
            listWords[0] = "Tennis";
            listWords[1] = "Football";
            listWords[2] = "Badminton";
            Random random = new Random();
            int resultRandom = random.Next(0, 2);

            RandomWord = listWords[resultRandom];
            Many_Words = new char[RandomWord.Length];
        }
        public void Position() //กระบวนการขั้นตอนของระบบในเกม
        {
            int Incorrect_Score = 0;
            int Check_Collect = 0;
            bool check = false;
            for (int position = 0; position < RandomWord.Length; position++)
            {
                Many_Words[position] = '-';
            }
            do  //do...While วนจนกว่าจะInputเสร็จ
            {
                int Check_HP = RandomWord.Length;

                for (int i = 0; i < 1; i++)
                {
                    
                    char PlayerMany_Words = char.Parse(Console.ReadLine());

                    for (int j = 0; j < RandomWord.Length; j++) //for loopเช็คInputในแต่ละช่อง
                    {
                        if (PlayerMany_Words == RandomWord[j]) //เงื่อนไขเมื่อInputถูก
                        {
                            Many_Words[j] = PlayerMany_Words;
                            if (Many_Words[j] != '-')
                            {
                                
                                Check_Collect++;
                                if (Check_Collect == RandomWord.Length)//เมื่อเงื่อนไขตรงกันจะสามารถออกloopได้
                                {
                                    check = true; 
                                }
                            }
                        }
                        else if (PlayerMany_Words != RandomWord[j]) //เงื่อนไขเมื่อInputผิด
                        {
                            Check_HP--;
                            if (Check_HP == 0)
                            {
                                Console.Clear();
                                Incorrect_Score++;
                                Console.WriteLine("Incorrect Score : " + Incorrect_Score);
                                if (Incorrect_Score == 6)//เมื่อเงื่อนไขตรงกันจะสามารถออกloopได้
                                {
                                    check = true;
                                }
                            }
                        }
                    }
                    Console.WriteLine(Many_Words);//แสดงคำศัพตามที่เราInput
                }
            } while (true != check) ; 
            if(Incorrect_Score == 6) //เมื่อIncorrect_Score = 6จะตรงเงื่อไขและGameOver
            {
                Console.WriteLine("Game Over");
            }
            else {
                Console.WriteLine("Your Win!!!"); //เมื่อIncorrect_Score != 6จะไม่ตรงเงื่อไขและขนะ
            };
            
        }
     
    }
}
