using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SQLite.Net.Interop;

namespace xamarin_empleados
{
    public interface IConfig
    {
       string DirectoryDB { get; }

        ISQLitePlatform Platforma { get; }

    }
}
