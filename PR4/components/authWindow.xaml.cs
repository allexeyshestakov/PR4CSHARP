using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace PR4.components
{
    /// <summary>
    /// Логика взаимодействия для authWindow.xaml
    /// </summary>
    public partial class authWindow : Window
    {
        public authWindow()
        {
            InitializeComponent();
            
        }
        int invalidPassword = 0;
        
        private void auth_Click(object sender, RoutedEventArgs e)
        {
            string login = inputLogin.Text;
            string password = inputPass.Text;
            string capcha = inputCapcha.Text;
            string createCapcha = "";

            if (checkUser(login, password) && capcha == createCapcha)
            {
               
                
            }
            else
            {
                invalidPassword++;
                if (invalidPassword == 3)
                {
                    createCapcha = createCAPCHA();
                    imageCapcha.Text = createCapcha;
                    inputCapcha.Visibility = Visibility.Visible;
                    imageCapcha.Visibility = Visibility.Visible;
                }
            }
            

        }

        public Boolean checkUser(string login, string password)
        {
            //Поиск пользователя по логину
            //MessageBox.Show("Пользователь не найден");
            //return false;

            //Если нашли, то подставляем пароль
            //MessageBox.Show("Неправильный логин или пароль!");
            //return false;
            //
            //Если все хорошо перебрасываем куда-нибудь
            return true;
        }

        private string createCAPCHA()
        {
            Random rnd = new Random();
            string capchaText = "";
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";

            for(int i = 0; i < 6; i++)
            {
                capchaText += ALF[rnd.Next(ALF.Length)];
            }
            return capchaText;




        }
    }
}
