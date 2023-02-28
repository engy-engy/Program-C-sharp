﻿using System;
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
using System.Windows.Shapes;
namespace BotInterfaceWPF
{
    /// <summary>
    /// Логика взаимодействия для WindowForMessage.xaml
    /// Окно для развернутого сообщения
    /// </summary>
    public partial class WindowForMessage : Window
    {
        public WindowForMessage()
        {
            InitializeComponent();
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
