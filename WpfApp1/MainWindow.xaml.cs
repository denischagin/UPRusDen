﻿using ClassLibrary;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            using (var db = new DBContext()) db.Database.Delete();
                        
            User.CreateAdmin();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("login_TextBox.Text => " + login_TextBox.Text + ".");
            Console.WriteLine("password_PasswordBox.Password => " + password_PasswordBox.Password + ".");
            User user = User.LogIn(login_TextBox.Text, password_PasswordBox.Password);

            //Console.WriteLine("user.Login => " + user.Login);
            //Console.WriteLine("user.PasswordHash => " + user.PasswordHash);

            if (user == null)
                MessageBox.Show("Неверный логин или пароль");
            else
            {
                Hide();
                Log log = new Log();
                log.ShowDialog();
                Show();
            }
        }
    }
}
