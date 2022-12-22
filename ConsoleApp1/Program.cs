using ConsoleApp1.Data.Model;
using ConsoleApp1.Data.Static;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1=new User();
            user1.Name = "Zaminali";
            user1.Surname = "Rustemov";
            user1.Username = "zaminalirustemov";
            user1.Phone = "050 484 21 98";
            user1.Status=UserStatusEnum.Admin;

            User user2 = new User();
            user2.Name = "Namiq";
            user2.Surname = "Mikayilov";
            user2.Username = "nmik";
            user2.Phone = "050 484 34 54";
            user2.Status = UserStatusEnum.Mediatr;

            User user3 = new User();
            user3.Name = "Ali";
            user3.Surname = "Ibrahimov";
            user3.Username = "ibrakadabra";
            user3.Phone = "077 465 78 32";
            user3.Status = UserStatusEnum.Customer;

            User user4= new User();
            user4.Name = "Nicat";
            user4.Surname = "Abdullayev";
            user4.Username = "niko";
            user4.Phone = "051 432 56 65";
            user4.Status = UserStatusEnum.Customer;

            //////adduser-----------------------------------------------------------
            //user1.AddUser(user1);
            //user2.AddUser(user2);
            //user3.AddUser(user3);
            //user4.AddUser(user4);

            //////GETBYID------------------------------------------------------------------
            //Console.WriteLine(user1.GetById(1));
            //Console.WriteLine(user1.GetById(4));

            //////GETaLLL-----------------------------------------------------------------------
            //foreach (var item in user1.GetAll())
            //{
            //    Console.WriteLine(item);
            //}

            //////EditUserById----------------------------------------------------------------------------

            //string name = "Aghamali";
            //string surname = "Bedelov";

            //user1.EditUserById(4,name,surname);

            //////Edit----------------------------------------------------------------------------------------------------

            //////RemoveById------------------------------------------------------------------------------------------------------------

            //user1.RemoveById(5);

            //////RemoveAll--------------------------------------------------------------------------------------------------------------------------
            ///
            //user1.RemoveAll();
        }
    }
}