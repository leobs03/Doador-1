﻿using Doador.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doador.Domain.Interface
{
    public interface IDoadorService
    {
       Task<string> PostAsync(DoadorCommand command);
    }
}
