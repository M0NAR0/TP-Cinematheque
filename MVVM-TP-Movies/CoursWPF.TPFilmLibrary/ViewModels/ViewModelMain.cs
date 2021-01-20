using CoursWPF.MVVM;
using CoursWPF.MVVM.Abstracts;
using CoursWPF.MVVM.Models.Abstracts;
using CoursWPF.MVVM.ViewModels;
using CoursWPF.MVVM.ViewModels.Abstracts;
using CoursWPF.TPFilmLibrary.ViewModels.Abstracts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursWPF.TPFilmLibrary.ViewModels
{
    /// <summary>
    ///     Vue-modèle principal de l'application.
    /// </summary>
    public class ViewModelMain : ViewModelList<IObservableObject, IDataContext>, IViewModelMain
    {
        #region Fields

        /// <summary>
        ///     Fournisseur de service de l'application.
        /// </summary>
        private readonly IServiceProvider _ServiceProvider;

        /// <summary>
        ///     Vue-modèle de la page de détail d'un film.
        /// </summary>
        private IViewModelFilmDetails _ViewModelFilmDetails;

        /// <summary>
        ///     Commande pour fermer l'application.
        /// </summary>
        private readonly RelayCommand _ExitCommand;
        #endregion

        #region Properties

        /// <summary>
        ///     Obtient ou défini le vue-modèle de la page de détail d'un film.
        /// </summary>
        public IViewModelFilmDetails ViewModelFilmDetails { get => this._ViewModelFilmDetails; private set => this.SetProperty(nameof(this.ViewModelFilmDetails), ref this._ViewModelFilmDetails, value); }

        /// <summary>
        ///     Obtient la commande pour fermer l'application.
        /// </summary>
        public RelayCommand ExitCommand => this._ExitCommand;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initialise une nouvelle instance de la classe <see cref="ViewModelMain"/>.
        /// </summary>
        /// <param name="serviceProvider">Fournisseur de service de l'application.</param>
        public ViewModelMain(IServiceProvider serviceProvider)
            : base(serviceProvider.GetService<IDataContext>())
        {
            this._ServiceProvider = serviceProvider;

            this._ViewModelFilmDetails = this._ServiceProvider.GetService<IViewModelFilmDetails>();

            this._ExitCommand = new RelayCommand(this.Exit, this.CanExit);
        }
        #endregion

        #region Methods

        public override void LoadData()
        {
            this.ItemsSource = new ObservableCollection<IObservableObject>(new IObservableObject[] { this._ViewModelFilmDetails });
            this.SelectedItem = this._ViewModelFilmDetails;
        }

        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);

            switch (propertyName)
            {
                case nameof(this.SelectedItem):
                    (this.SelectedItem as IViewModelList<IDataContext>)?.LoadData();
                    break;
                default:
                    break;
            }
        }

        #region ExitCommand

        /// <summary>
        ///     Méthode qui détermine si la commande <see cref="ExitCommand"/> peut être exécutée.
        /// </summary>
        /// <param name="parameter">Paramètre de la commande.</param>
        /// <returns>Détermine si la commande peut être exécutée.</returns>
        protected virtual bool CanExit(object parameter) => true;

        /// <summary>
        ///     Méthode d'exécution de la commande <see cref="ExitCommand"/>.
        /// </summary>
        /// <param name="parameter">Paramètre de la commande.</param>
        protected virtual void Exit(object parameter)
        {
            App.Current.Shutdown(0);
        }
        #endregion

        #endregion
    }
}
