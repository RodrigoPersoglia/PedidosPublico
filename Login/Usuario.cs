using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Usuario    {
        
        private string _user;

      
    
        private bool _tablaArchivos;
        private bool _tablaArticulos;
        private bool _tablaCliente;
        private bool _tablaPedidos;
        private bool _tablaMatrices;
        private bool _tablaUsuario;
        private bool _tablaReportes;





        public string User { get { return this._user; } set { this._user = value; } }
        public bool TablaArchivos { get { return this._tablaArchivos; }  set { this._tablaArchivos = value; } }
        public bool TablaArticulos { get { return this._tablaArticulos; }  set { this._tablaArticulos = value; } }
        public bool TablaCliente { get { return this._tablaCliente; }  set { this._tablaCliente = value; } }
        public bool TablaPedidos { get { return this._tablaPedidos; }  set { this._tablaPedidos = value; } }
        public bool TablaMatrices { get { return this._tablaMatrices; } set { this._tablaMatrices = value; } }
        public bool Tablausuario { get { return this._tablaUsuario; } set { this._tablaUsuario = value; } }
        public bool TablaReporte { get { return this._tablaReportes; } set { this._tablaReportes = value; } }

        public Usuario() { }




    }
}