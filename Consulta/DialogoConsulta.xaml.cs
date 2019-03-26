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

namespace Consulta
{
    /// <summary>
    /// Lógica de interacción para DialogoConsulta.xaml
    /// </summary>
    public partial class DialogoConsulta : Window
    {
        private LogicaConsulta logicaConsulta;
        public Consultas consulta;

        public DialogoConsulta(LogicaConsulta logicaConsulta)
        {
            InitializeComponent();
            this.logicaConsulta = logicaConsulta;
            consulta = new Consultas();
            this.DataContext = consulta;
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            logicaConsulta.agregarConsulta(consulta);
            this.Close();
        }
    }
}
