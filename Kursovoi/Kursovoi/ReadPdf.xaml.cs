﻿using Microsoft.EntityFrameworkCore;
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
using System.Windows.Shapes;


namespace Kursovoi
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class ReadPdf : Window
    {
        public ReadPdf()
        {
            InitializeComponent();
            using (CURSOVOIContext db = new CURSOVOIContext())
            {
                var code = Application.Current.Resources["TT"];
                string shortcode = code.ToString();
                shortcode = shortcode.Remove(0, 5);

                var sourc = db.Photochepter.FirstOrDefault(p => p.CodeTitle == int.Parse(shortcode));
                var pathch = sourc.PathPhChepter;
                pdfWebViewer.Navigate(new Uri(pathch));
                //pdfWebViewer.Navigate(fullPathToPDF);
                // StorageFile file = await StorageFile.GetFileFromPathAsync(pathch);

            }

        }

        private void ButtonIMGPDF_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UserPage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
