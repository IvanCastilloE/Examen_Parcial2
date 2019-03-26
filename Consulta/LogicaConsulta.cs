using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consulta
{
    public partial class LogicaConsulta
    {
        public ObservableCollection<Consultas> ListaConsulta { get; set; }

        public LogicaConsulta()
        {
            ListaConsulta = new ObservableCollection<Consultas>();
            ListaConsulta.Add(new Consultas("EL Babo", "Gastritis", DateTime.Now));
        }
        public void agregarConsulta(Consultas consulta)
        {
            ListaConsulta.Add(consulta);
        }
        public void ModificarConsulta(Consultas consulta, int posicion) 
        {
            ListaConsulta[posicion] = consulta;
        }
    }
}
