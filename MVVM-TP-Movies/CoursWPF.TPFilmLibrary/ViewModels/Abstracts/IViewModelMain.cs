using CoursWPF.MVVM.Abstracts;
using CoursWPF.MVVM.Models.Abstracts;
using CoursWPF.MVVM.ViewModels.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursWPF.TPFilmLibrary.ViewModels.Abstracts
{
    /// <summary>
    ///     Interface du vue-modèle principal de l'application.
    /// </summary>
    public interface IViewModelMain : IViewModelList<IObservableObject, IDataContext>
    {
        #region Properties

        #endregion
    }
}
