using System;
using System.Collections.Generic;

namespace TestMidTerm_02
{//ทำไม่ทันจริง
    enum Frist_Screen //สร้างenumเพื่อเป็นทางเลือก
    {
        Login = 1,
        Register
    }
    enum User_Type
    {
        Student = 1,
        Employee
    }
    enum Student
    {
        Borrow_book = 1
    }
    enum Employee
    {
        Show_Stock_Book = 1
    }
    enum Detail_Book
    {
        Now_I_understand = 1,
        Revolutionary_Wealth,
        Six_Degrees,
        Les_Vacances
    }
    class Program
    {
        static void Main(string[] args)
        {
            PrintHeader_FristScreen();
            InputMenuSreen();
            PrintHeader_LogIn();
        }
        static void PrintHeader_FristScreen() //แสดงข้อความ
        {
            Console.WriteLine("Welcome to Digital Library");
            Console.WriteLine("--------------------------");
            Console.WriteLine("1.Login");
            Console.WriteLine("2.Register");
            Console.Write("Select Menu : ");
        }
        static void PrintHeader_Register()
        {
            Console.WriteLine("Register new Person");
            Console.WriteLine("--------------------");
        }
        static void PrintHeader_LogIn() //แสดงLogIn Sreen
        {
            Console.WriteLine("LogIn Sreen");
            Console.WriteLine("-----------");
        }
        
        public static void Input_User_Type()
        {
            Register register = new Register();
            register.register(Name(), Password(), user_type(), ID()); 
        }
        static void LogIn()
        {
            Register login = new Register();
            //login.RegisterToLogIn(Name(), Password());
            if(Name() == "Tawan" && Password() == "5585")
            {
                Console.Clear();
                PrintHeader();
                Detail_Book();
            }
        }
        public static string LogIn_Name()
        {
            return Console.ReadLine();
        }
        public static string Name()
        {
            Console.Write("Input name : ");
            return Console.ReadLine(); 
        }
        public static string Password()
        {
            Console.Write("Input Password : ");
            return Console.ReadLine();
        }
        public static string ID()
        {
            Console.Write("Input ID : ");
            return Console.ReadLine();
        }
        static User_Type user_type()
        {
            Console.Write("Input User Type : ");
            User_Type user_type = (User_Type)(int.Parse(Console.ReadLine()));
            return user_type;
        }
        static void Detail_Book()
        {
            Detail_Book detail = (Detail_Book)(int.Parse(Console.ReadLine()));
        }
        static void PrintHeader()
        {
            Console.WriteLine("Book List");
            Console.WriteLine("---------");
        }
        static void InputMenuSreen()
        {
            Frist_Screen frist_screen = (Frist_Screen)(int.Parse(Console.ReadLine()));
            PresentMenu(frist_screen);
        }
         static void User_Type()
        {
            User_Type user_type = (User_Type)(int.Parse(Console.ReadLine()));
        }
        

        static void PresentMenu(Frist_Screen frist_screen)  //Inputชื่อ
        {
            if (frist_screen == Frist_Screen.Login)
            {
                LogIn();
               

            }
            else if (frist_screen == Frist_Screen.Register)
            {
                    PrintHeader_Register();//register
                    Input_User_Type(); //name&password&type 
                    PrintHeader_FristScreen();
                    InputMenuSreen();
               
            }
        }
    }
    class Register  //classเก็บข้อมูลต่างๆ
    {
        List<Register> rr = new List<Register>();
        public string name;
        public string password;
        public User_Type user_type;
        public string id;


        public void register(string Name,string Password,User_Type UserType,string ID)
        {
            this.name = Name;
            this.password = Password;
            this.user_type = UserType;
            this.id = ID;
        }
        public void RegisterToLogIn(string Name, string Password)
        {
        
        }
    }
    public class Login //classข้อมูลLogin
    {
        public string name;
        public string password;
        public Login(string Name,string Password)
        {
            this.name = Name;
            this.password = Password;
        }
    }

}
