using HotellZininaMatveeva.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HotellZininaMatveeva
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Представляет контекст данных для взаимодействия с базой данных.
        /// </summary>
        public static ZininaMatveevaHotelEntities context = new ZininaMatveevaHotelEntities();

        /// <summary>
        /// Представляет поле для хранения пользователя вошедшего в систему.
        /// </summary>
        public static User currentUser;
    }
}
