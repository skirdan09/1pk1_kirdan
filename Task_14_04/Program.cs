namespace Task_14_04
{
    internal class Program
    {
        /* Определите класс User, 
         * который будет иметь статическое свойство CurrentUser, 
         * представляющее текущего пользователя, и метод для его установки.
         */
        static void Main(string[] args)
        {
            User user1 = new User("Влад", 2304);
            User user2 = new User("Кирилл", 228);

            User.SetCurrentUser(user1);
            User.SetCurrentUser(user2);


            Console.WriteLine($"Пользователь под ID {user1.ID}: {user1.Name}");

            Console.WriteLine($"Пользователь под ID {user2.ID}: {user2.Name}");
        }
    }
}
