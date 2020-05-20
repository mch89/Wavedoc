
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace WaveDock_Xamarin.Models
{
    public class JsonResponse
    {
        public List<InfoCancionLetra> Result { get; set; }
        public String Status { get; set; }
    }
}
