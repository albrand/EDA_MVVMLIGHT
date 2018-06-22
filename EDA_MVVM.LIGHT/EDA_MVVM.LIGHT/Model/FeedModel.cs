using EDA_MVVM.LIGHT.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDA_MVVM.LIGHT.Model
{
    public class FeedModel : BaseVM
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Texto { get; set; }
    }
}
