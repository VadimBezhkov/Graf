using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class User
    {
        public int value { get; set; }
        public static User operator ++(User user)
        {
            return new User { value = user.value + 10 };
        }
        public static User operator + (User user,User user1)
        {
            return new User {value = user.value+user1.value };
        }
        public static int operator +(User user, int x)
        {
            return user.value + x ;
        }
        public static bool operator > (User user, User user1)
        {
            if (user.value > user1.value)
                return true;
            else
                return false;
        }
        public static bool operator <(User user, User user1)
        {
            if (user.value < user1.value)
                return true;
            else
                return false;
        }
        public static int operator+(int y,User user1)
        {
            return y + user1.value;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User {value = 12};
            User user1 = new User {value = 15};
            User user2 = user + user1;
            User user3 = new User { value = 1 };
            user++;
            Console.WriteLine("sdads"+user.value);
            Console.WriteLine(user.value);
            Console.WriteLine(user2.value);
            bool result = user > user1;
            Console.WriteLine(result) ;
            user1 = user1++;
        
            int x = user + 40;
            int y = 99 + user1;
            Console.WriteLine(y);
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
