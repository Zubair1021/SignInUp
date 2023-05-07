using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace signupsignin
{
    class Program
    {
        static void Main(string[] args)
        {
            string username, password;
            string choice,key;
        z: d: v:
            Console.WriteLine("1-----Sign in");
            Console.WriteLine("2-----Sign up");
            Console.WriteLine("3-----Exit");
            Console.WriteLine("");
            Console.WriteLine(">>>>>>>>>>>>>>>>Select one of them ");
        
            
            Console.Write("Enter your choice :  ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Write("......Enter your username : ");
                username = Console.ReadLine();
                Console.Write("......Enter your password : ");
                password = Console.ReadLine();
                signin(username, password);
                Console.Write("Press any Key: ");
                key = Console.ReadLine();
                Console.Clear();
                goto v;
            }
            else if (choice == "2")
            {
                Console.Write("......Enter your username : ");
                username = Console.ReadLine();
                Console.Write("......Enter your password : ");
                password = Console.ReadLine();
                signup(username, password);
                Console.WriteLine("-------------Successfully sign up !------------------");
                Console.Write("Press any Key: ");
                key = Console.ReadLine();
                Console.Clear();
                goto d;
            }
            else if(choice=="3")
            {
                Console.Clear();
                Console.WriteLine("<<<<<<<<<<<<<<Program End!>>>>>>>>>>>>>>>");
            }
            else
            {
                Console.WriteLine(">>>>>>>>>>>>>>>Invalid choice");
                Console.Write("Press any Key: ");
                key = Console.ReadLine();
                Console.Clear();
                goto z;
            }


            Console.ReadKey();


        }
        public static void signup(string username , string password)
        {
            string path = "E:\\signupsignin\\data.txt";
            StreamWriter filevariable = new StreamWriter(path, true);
            filevariable.WriteLine(username);
            filevariable.WriteLine(password);
            filevariable.Flush();
            filevariable.Close();
        }
        public static void signin(string username, string password)
        {
            string path = "E:\\signupsignin\\data.txt";
            string record;
            string fileusername,filepassword;
            int flag = 0;
            if (File.Exists(path))
            {
                StreamReader filevariable = new StreamReader(path);
                while ((record = filevariable.ReadLine()) != null)
                {
                    fileusername = record;
                    if (fileusername == username)
                    {
                        flag++;
                    }
                }
                filevariable.Close();
                StreamReader file = new StreamReader(path);
                while ((record = file.ReadLine()) != null)
                {
                    filepassword = record;
                    if (filepassword==password)
                    {
                        flag++;
                    }
                }
                file.Close();

            }
            else
                Console.Write("NOT EXISTS");
            if (flag == 2)
            {
                Console.WriteLine("--------WELCOME (- _ -)---------- ");
            }
            else
                Console.WriteLine("Invalid username and password");
          


        }

    }
}
