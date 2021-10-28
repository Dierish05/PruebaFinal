using Domain.Entities.Activos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IActivoModel : IModel<ActivoFijo>
    {
        int GetLastId();
    }
}
