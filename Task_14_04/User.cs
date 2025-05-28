using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_04
{
    /* Определите класс User, 
     * который будет иметь статическое свойство CurrentUser, 
     * представляющее текущего пользователя, и метод для его установки.
     */
    internal class User
    {
        // Статическое свойство для хранения пользователя
        private static User currentUser;

        // Свойство для доступа к пользователю
        public static User CurrentUser
        {
            get { return currentUser; }
        }

        // Метод для установки текущего пользователя
        public static void SetCurrentUser(User user)
        {
            currentUser = user;
        }

        // Cвойства для класса User, например имя и идентификатор пользователя
        public string Name { get; set; }
        public int ID { get; set; }

        // Конструктор
        public User(string name, int id)
        {
            Name = name;
            ID = id;
        }
    }

}

