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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Consulta
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LogicaConsulta logicaConsulta;
        public MainWindow()
        {

            InitializeComponent();
            logicaConsulta = new LogicaConsulta();
            this.DataContext = this;
            gridConsulta.DataContext = logicaConsulta;

        }

        private void mniAgregar_Click(object sender, RoutedEventArgs e)
        {
            DialogoConsulta dialogoConsulta = new DialogoConsulta(logicaConsulta);
            dialogoConsulta.Show();
        }

        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
