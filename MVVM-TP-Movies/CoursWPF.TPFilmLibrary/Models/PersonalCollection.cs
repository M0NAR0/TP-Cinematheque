using CoursWPF.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursWPF.TPFilmLibrary.Models
{
    /// <summary>
    ///     Classe de données qui représente une collection personnelle.
    /// </summary>
    public class PersonalCollection : Entity
    {
        #region Fields

        /// <summary>
        ///     Structure de données de la classe <see cref="PersonalCollection"/>
        /// </summary>
        private struct PersonalCollectionData
        {
            /// <summary>
            ///     Collection de films.
            /// </summary>
            public ObservableCollection<Film> Films { get; set; }
        }

        /// <summary>
        ///     Données actuelles.
        /// </summary>
        PersonalCollectionData _CurrentData;

        /// <summary>
        ///     Sauvegarde des données au début de l'édition.
        /// </summary>
        PersonalCollectionData? _BackupData;
        #endregion

        #region Properties

        /// <summary>
        ///     Obtient ou défini la collection de films.
        /// </summary>
        public ObservableCollection<Film> Films
        {
            get => this._CurrentData.Films;
            set => this.SetProperty(nameof(this.Films), () => this._CurrentData.Films, (v) => this._CurrentData.Films = v, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        ///     Initialise une nouvelle instance de la classe <see cref="PersonalCollection"/>.
        /// </summary>
        public PersonalCollection()
        {
            this.Films = new ObservableCollection<Film>();
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Commence l'édition d'une entité.
        /// </summary>
        public override void BeginEdit()
        {
            if (this._BackupData == null)
            {
                this._BackupData = this._CurrentData;
            }
        }

        /// <summary>
        ///     Annule les modifications sur l'entité.
        /// </summary>
        public override void CancelEdit()
        {
            if (this._BackupData != null)
            {
                this._CurrentData = this._BackupData.Value;
                this.OnPropertyChanged("");
            }
        }

        /// <summary>
        ///     Valide les modifications effectuées sur l'entité.
        /// </summary>
        public override void EndEdit()
        {
            if (this._BackupData != null)
            {
                this._BackupData = null;
            }
        }

        #endregion
    }
}
