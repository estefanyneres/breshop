﻿using Breshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Breshop.Intefaces
{
    public interface IUsuarioRepository
    {
        bool ValidarUsuario(Usuario usuario);

    }
}
