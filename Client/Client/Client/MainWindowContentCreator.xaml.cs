﻿using ControlzEx.Standard;
using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Image = System.Windows.Controls.Image;
using Orientation = System.Windows.Controls.Orientation;
using Rectangle = System.Windows.Shapes.Rectangle;

namespace Client {

    public partial class MainWindowContentCreator {

        ContentCreator thisContentCreator;
        int thisVar;

        public MainWindowContentCreator(ContentCreator contentCreator, int var) {
            thisContentCreator = contentCreator;
            thisVar = var;
            InitializeComponent();
            if (contentCreator.ImageStoragePath == null) {
                image.Fill = LoadImage("C:\\Users\\Bruno\\Desktop\\IMAGES\\DefaultCover.jpg");
            } else {
                image.Fill = LoadImage(contentCreator.ImageStoragePath);
            }
            textBlock_StageName.Text = "Hi, " + thisContentCreator.StageName;
            if (var == 0) {
                label_Title.Text = "MY ALBUMS";
                button_Add.Content = "+ Add Album";
            } else {
                label_Title.Text = "MY SINGLES";
                button_Add.Content = "+ Add Single";
            }
        }

        private void button_Albums_Click(object sender, RoutedEventArgs e) {
            LoadAlbums();
        }

        private void button_Singles_Click(object sender, RoutedEventArgs e) {
            LoadSingles();
        }

        private void button_Settings_Click(object sender, RoutedEventArgs e) {
            flyout.IsOpen = true;
        }

        private void button_Configuration_Click(object sender, RoutedEventArgs e) {

        }

        private void button_Logout_Click(object sender, RoutedEventArgs e) {
            Login loginWindow = new Login();
            this.Close();
            loginWindow.Show();
        }

        private void button_Back_Click(object sender, RoutedEventArgs e) {
            flyout.IsOpen = false;
        }

        private void button_Search_Click(object sender, RoutedEventArgs e) {

        }

        private void button_Add_Click(object sender, RoutedEventArgs e) {
            if (label_Title.Text == "MY SINGLES") {
                thisVar = 1;
            } else {
                thisVar = 0;
            }
            AddAlbum addAlbumWindow = new AddAlbum(thisContentCreator, thisVar);
            addAlbumWindow.Show();
            this.Close();
        }

        private async void LoadAlbums() {
            label_Title.Text = "MY ALBUMS";
            button_Add.Content = "+ Add Album";
            List<Album> albums = await Session.serverConnection.albumService.GetAlbumsByContentCreatorIdAsync(thisContentCreator.IdContentCreator);
            foreach (Album albumAux in albums) {
                CreateContentUI(albumAux);
            }
        }

        private async void LoadSingles() {
            label_Title.Text = "MY SINGLES";
            button_Add.Content = "+ Add Single";
            List<Album> singles = await Session.serverConnection.albumService.GetSinglesByContentCreatorIdAsync(thisContentCreator.IdContentCreator);
            foreach (Album singleAux in singles) {
                CreateContentUI(singleAux);
            }
        }

        private ImageBrush LoadImage(string path) {
            try {
                Image imageX = new Image();
                BitmapImage src = new BitmapImage();
                src.BeginInit();
                src.UriSource = new Uri(path);
                src.EndInit();
                imageX.Source = src;

                ImageBrush ib = new ImageBrush();
                ib.ImageSource = src;
                return ib;
            } catch (Exception ex) {
                Console.WriteLine(ex + " in AddAlbum LoadImage");
                return null;
            }
        }

        private void CreateContentUI(Album album) {
            StackPanel stackPanel = new StackPanel();
            stackPanel.Orientation = Orientation.Vertical;
            StackPanel albumHeaderStackPanel = new StackPanel();
            albumHeaderStackPanel.Orientation = Orientation.Horizontal;
            Rectangle albumImage = new Rectangle();
            albumImage.Fill = LoadImage(album.CoverPath);
            albumImage.Margin = new Thickness(30,30,0,0);
            albumImage.Width = 115;
            albumImage.Height = 115;
            albumHeaderStackPanel.Children.Add(albumImage);
        }
    }
}
