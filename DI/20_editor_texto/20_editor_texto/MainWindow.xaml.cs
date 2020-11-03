﻿using System.Diagnostics.Tracing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace _20_editor_texto {

    public partial class MainWindow : Window {

        public MainWindow() {

            InitializeComponent();
            fillMenuComboBox();

            // Asigna un evento cuando se pulsa una tecla
            this.PreviewKeyDown += new KeyEventHandler(HandleEsc);
        }

        // Rellena la informacion de lo ComboBox del menu
        private void fillMenuComboBox() {

            // Rellena el ComboBox del tamaño de letra
            for (int i = 4; i < 72; i = i + 4) { cbFontSize.Items.Add(i); }
            cbFontSize.Text = "4";
        }

        // Funcion para poner la ventana en FullScreen
        private void pantallaCompleta(object sender, RoutedEventArgs e) {

            // Cambia el texto del MenuItem de cambiar a pantalla completa
            miFullScreen.Header = (WindowStyle.ToString() != "None") ? "Salir de pantalla completa" : "Pantalla completa";

            // Si la ventana esta en pantalla completa lo pone en ventana con marcos y viceversa
            WindowStyle = (WindowStyle.ToString() != "None") ? WindowStyle.None : WindowStyle.SingleBorderWindow;
            Hide(); Show();
        }

        // Funcion para cerrar la aplicacion
        private void endProgram(object sender, RoutedEventArgs e) => Close();

        // Funcion para cerrar la aplicacion con el boton escape
        private void HandleEsc(object sender, KeyEventArgs e) { if (e.Key == Key.Escape) { Close(); } }
    }
}