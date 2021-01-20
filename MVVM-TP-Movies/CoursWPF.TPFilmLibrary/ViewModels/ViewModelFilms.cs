using CoursWPF.MVVM;
using CoursWPF.MVVM.Models.Abstracts;
using CoursWPF.MVVM.ViewModels;
using CoursWPF.TPFilmLibrary.Models;
using CoursWPF.TPFilmLibrary.ViewModels.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursWPF.TPFilmLibrary.ViewModels
{
    /// <summary>
    ///     Vue-modèle pour l'affichage des films dans la page 
    /// </summary>
    public class ViewModelFilms : ViewModelList<Film, IDataContext>, IViewModelFilms
    {
        #region Fields

        /// <summary>
        ///     Fournisseur de service de l'application.
        /// </summary>
        private readonly IServiceProvider _ServiceProvider;
        #endregion

        #region Properties

        public override RelayCommand AddCommand => base.AddCommand;

        #endregion
    }
}
