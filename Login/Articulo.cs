using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Articulo
    {
        private int _id;
        private string _codigo;
        private string _descripcion;
        private double _pesoNominal;
        private int _tolerancia;
        private int _multiplo;
        private string _aleacion;
        private string _temple;
        private string _clasificacion;
        private string _topologia;
        private string _cliente;
        private double _precio;
        private int _prensa;
        private string _ubicacion;



        public int ID { get { return this._id; } set { this._id = value; } }
        public string Codigo { get { return this._codigo; } set { this._codigo = value; } }
        public string Descripcion { get { return this._descripcion; } set { this._descripcion = value; } }
        public double PesoNominal { get { return this._pesoNominal; } set { this._pesoNominal = value; } }
        public int Tolerancia { get { return this._tolerancia; } set { this._tolerancia = value; } }
        public int Multiplo { get { return this._multiplo; } set { this._multiplo = value; } }
     
        public string Aleacion { get { return this._aleacion; } set { this._aleacion = value; } }
        public string Temple { get { return this._temple; } set { this._temple = value; } }
        public string Clasificacion { get { return this._clasificacion; } set { this._clasificacion = value; } }
        public string Topologia { get { return this._topologia; } set { this._topologia = value; } }

        public double Precio{ get { return this._precio; } set { this._precio = value; } }

        public string Cliente { get { return this._cliente; } set { this._cliente = value; } }
        public int Prensa { get { return this._prensa; } set { this._prensa = value; } }

        public string Ubicacion { get { return this._ubicacion; } set { this._ubicacion = value; } }

        public Articulo() { }


        public Articulo(string cod, string des, double peso, int tol, int mult, string ale, string tem, string top, string clas)
        {
            this.Codigo = cod;
            this.Descripcion = des;
            this.PesoNominal = peso;
            this.Tolerancia = tol;
            this.Multiplo = mult;
            this.Topologia = top;
            this.Aleacion = ale;
            this.Temple = tem;
            this.Clasificacion = clas;
        }

    }
}