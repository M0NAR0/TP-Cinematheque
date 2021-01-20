using CoursWPF.MVVM;
using CoursWPF.TPFilmLibrary.ViewModels.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursWPF.TPFilmLibrary.ViewModels
{
    public class ViewModelFilmDetails : ObservableObject, IViewModelFilmDetails
    {
        /// <summary>
        ///     Obtient le titre du vue-modèle
        /// </summary>
        public string Title => "Détails";
    }
}
