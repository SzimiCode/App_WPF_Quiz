﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using App_WPF_Quiz.Views;

namespace App_WPF_Quiz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            // Po kliknięciu przycisku Start przełącz na QuizSelectionView
            MessageBox.Show("Eo");
            MainContent.Content = new QuizSelectionView();
        }
    }
}