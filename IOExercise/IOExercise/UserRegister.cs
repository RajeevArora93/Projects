using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOExercise
{
    public class UserRegister
    {


        public void InputInfo(string path, string name, string address, string email, string mobile) 
        {
            //StreamReader read = new StreamReader(path);
            //StringBuilder builder = new StringBuilder();
            //while(read.Peek() != -1)
            //{
            //    builder.Append(read.ReadLine() + "\r\n");
            //}
            //read.Close();

            string userInfo = name + ", " + address + ", " + email + ", " + mobile;
            StreamWriter writer = new StreamWriter(path, true);                    
            writer.WriteLine(userInfo);
                                  
            writer.Close();
        }

        public void CreateUsers(string path) 
        {
            StreamReader read = new StreamReader(path);
            StringBuilder builder = new StringBuilder();
            while (read.Peek() != -1)
            {
                Console.WriteLine(builder.ToString());
                
            }
            read.Close();      
        }
    }
}
