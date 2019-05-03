using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos1;
using CapaEntidad;
using System.Data;
namespace CapaNegocio
{
    public class N_empleados
    {
        D_Empleados objdato = new D_Empleados();

        public DataTable N_listado()
        {
            return objdato.D_listado();
        }

    }
}
