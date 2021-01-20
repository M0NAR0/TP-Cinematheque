using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursWPF.TPFilmLibrary.ViewModels
{
    public class ViewModelSearching
    {
        #region Fields

        /// <summary>
        ///     Url de Omdbapi.
        /// </summary>
        const string API_URL = "http://www.omdbapi.com/";
        /// <summary>
        ///     Clé personelle d'utilisation d'omdbapi (à ajouter en fin d'url, ex: http://www.omdbapi.com/?i=tt3896198&apikey=4a49a57b)
        /// </summary>
        const string API_KEY = "apikey=4a49a57b";

        #endregion
    }
}
