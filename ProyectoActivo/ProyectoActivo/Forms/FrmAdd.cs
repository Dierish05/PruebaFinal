using Domain.Entities.Activos;
using Infraestructure.ActivosFijos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoActivo.Forms
{
    public partial class FrmAdd : Form
    {
        private ActivoModel activoModel;
        public FrmAdd(ActivoModel activoModel)
        {
            this.activoModel = activoModel;
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            ActivoFijo p = new ActivoFijo()
            {
                Id = activoModel.GetLastId(),
            };

            activoModel.Create(p);
        
        }
    }
}
