using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consulta
{
    public class Consultas : INotifyPropertyChanged, ICloneable
    {
        private String paciente;
        public String Paciente
        {
            get { return paciente; }
            set
            {
                this.paciente = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("FechaEntrada"));
            }
        }
        private String padeci;
        public String Padeci
        {
            get { return padeci; }
            set
            {
                this.padeci = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("FechaEntrada"));
            }
        }
        private DateTime fecha;
        public DateTime Fecha
        {
            get { return fecha; }
            set
            {
                this.fecha = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("FechaEntrada"));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public Consultas()
        {
            this.fecha = DateTime.Now;
        }
        public Consultas(string paciente, string padeci, DateTime fecha)
        {
            this.paciente = paciente;
            this.padeci = padeci;
            this.fecha = fecha;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
