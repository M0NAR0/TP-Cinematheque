using CoursWPF.MVVM.Models.Abstracts;
using CoursWPF.MVVM.ViewModels.Abstracts;
using CoursWPF.TPFilmLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursWPF.TPFilmLibrary.ViewModels.Abstracts
{
    public interface IViewModelFilms : IViewModelList<Film, IDataContext>
    {
    }
}
