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

namespace Pixel_Art
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //MessageBox.Show("Elige un tamaño");
        }

        private void CrearGrid(int tamaño)
        {
            for (int i = 0; i < tamaño; i++)
            {
                RowDefinition r = new RowDefinition();
                PixelGrid.RowDefinitions.Add(r);

                ColumnDefinition c = new ColumnDefinition();
                PixelGrid.ColumnDefinitions.Add(c);

            }
            PintarGrid(tamaño);
        }

        private void PintarGrid(int tamaño)
        {
            for (int i = 0; i < tamaño; i++)
            {

                for (int j = 0; j < tamaño; j++)
                {
                    Border border = new Border();
                    border.BorderBrush = Brushes.Black;
                    border.BorderThickness = new Thickness(1);
                    border.Background = Brushes.White;
                    border.MouseLeftButtonUp += MouseLeftButtonUp(PintarGridMouseEnter);
                    border.AddHandler()

                    Grid.SetRow(border, i);
                    Grid.SetColumn(border, j);
                    PixelGrid.Children.Add(border);
                }

            }
        }

        private void PintarGridMouseEnter(Action<object, MouseButtonEventArgs> pintarGridMouseEnter)
        {
            Border b = new Border();
            //Border p = (Border)sender;
            Grid g = (Grid)sender;
            //int row = g.RowDefinitions.Count;
            //int column = g.ColumnDefinitions.;
            b.Background = Brushes.Black;
            Grid.SetColumn(b, column);
            Grid.SetRow(b, row);
            PixelGrid.Children.Add(b);
        }

        private void LimpiarGrid()
        {
            PixelGrid.RowDefinitions.Clear();
            PixelGrid.ColumnDefinitions.Clear();
            PixelGrid.Children.Clear();
        }

        private void CambiarTamañoGrid(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            switch (b.Tag)
            {
                case "Pequeño":
                    LimpiarGrid();
                    CrearGrid(10);
                    break;
                case "Mediano":
                    LimpiarGrid();
                    CrearGrid(20);
                    break;
                case "Grande":
                    LimpiarGrid();
                    CrearGrid(30);
                    break;
            }
        }

        //Botones Radio que cambian de color
        private void CambiarColorGrid(object sender, RoutedEventArgs e)
        {

        }

        //Boton Rellenar
        private void RellenarGrid(object sender, RoutedEventArgs e)
        {

        }

        private void PintarGridMouseEnter(object sender, MouseButtonEventArgs e)
        {
            Border b = new Border();
            //Border p = (Border)sender;
            Grid g = (Grid)sender;
            //int row = g.RowDefinitions.Count;
            //int column = g.ColumnDefinitions.;
            b.Background = Brushes.Black;
            Grid.SetColumn(b, column);
            Grid.SetRow(b, row);
            PixelGrid.Children.Add(b);
        }
    }
}
