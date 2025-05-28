namespace Task_20_05
{
    internal class Program
    {
        /*Напишите программу, имитирующую систему авторизации с использованием перечисления AccessLevel:
        • Guest (только чтение)
        • User (чтение + комментарии)
        • Moderator (удаление контента)
        • Admin (полный доступ)
        Создайте метод, который проверяет, может ли пользователь выполнить действие (например, удалитьпост).
        На основе уровня доступа выводите сообщение (например,
        "Ошибка: Недостаточно прав!").
         */
        static void Main(string[] args)
        {
            User user1 = new User(AccesLevel.Guest);
            user1.Reading();
            user1.DeleteContent();

            User user2 = new User(AccesLevel.User);
            user2.ReadAndWrite();
            user2.Full();

            User user3 = new User(AccesLevel.Moderator);
            user3.ReadAndWrite();
            user3.DeleteContent();
            user3.Full();

            User user4 = new User(AccesLevel.Admin);
            user4.Reading();
            user4.Full();
        }
    }
}
