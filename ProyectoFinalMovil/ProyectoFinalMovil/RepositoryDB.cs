﻿using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace ProyectoFinalMovil
{
    public class RepositoryDB
    {
        FirebaseClient firebaseClient = new
            FirebaseClient("https://proyectofinalmovil-ed3f4-default-rtdb.firebaseio.com");
    }
}
