using Domain.Entities.Activos;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.ActivosFijos
{
    public class ActivoModel : IActivoModel
    {

        private ActivoFijo[] activoFijos;
        public void Add(ActivoFijo t, ref ActivoFijo[] data)
        {
            if (activoFijos == null)
            {
                activoFijos = new ActivoFijo[1];
                activoFijos[activoFijos.Length - 1] = t;
                return;
            }

            ActivoFijo[] temp = new ActivoFijo[activoFijos.Length + 1];
            Array.Copy(activoFijos, temp, activoFijos.Length);

            temp[temp.Length - 1] = t;
            activoFijos = temp;
        }

        public void Create(ActivoFijo t)
        {
            Add(t, ref activoFijos);
        }

        public ActivoFijo[] FindAll()
        {
            return activoFijos;
        }

        public int GetLastId()
        {
            return (activoFijos == null) ? 0 = activoFijos[activoFijos.Length - 1].Id;
        }
    }
}
