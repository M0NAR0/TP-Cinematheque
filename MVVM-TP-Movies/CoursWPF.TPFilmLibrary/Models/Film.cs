using CoursWPF.MVVM.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursWPF.TPFilmLibrary.Models
{
    /// <summary>
    ///     Classe de données qui représente un film.
    /// </summary>
    [JsonObject(MemberSerialization.OptOut)]
    public class Film : Entity
    {
        #region Fields

        /// <summary>
        ///     Structure des données de la classe <see cref="Film"/>.
        /// </summary>
        private struct FilmData
        {
            /// <summary>
            ///     Titre du film.
            /// </summary>
            public string Title { get; set; }
            /// <summary>
            ///     Année du film.
            /// </summary>
            public string Year { get; set; }
            /// <summary>
            ///     Classement du film.
            /// </summary>
            public string Rated { get; set; }
            /// <summary>
            ///     Sortie du film.
            /// </summary>
            public string Released { get; set; }
            /// <summary>
            ///     Durée du film.
            /// </summary>
            public string Runtime { get; set; }
            /// <summary>
            ///     Genre(s) du film.
            /// </summary>
            public string Genre { set; get; }
            /// <summary>
            ///     Directeur du film.
            /// </summary>
            public string Director { get; set; }
            /// <summary>
            ///     Rédacteur(s) du film.
            /// </summary>
            public string Writer { get; set; }
            /// <summary>
            ///     Acteur(s) du film.
            /// </summary>
            public string Actors { get; set; }
            /// <summary>
            ///     Synopsis du film.
            /// </summary>
            public string Plot { get; set; }
            /// <summary>
            ///     Langues du film.
            /// </summary>
            public string Language { get; set; }
            /// <summary>
            ///     Pays de sortie du film.
            /// </summary>
            public string Country { get; set; }
            /// <summary>
            ///     Récompenses du film.
            /// </summary>
            public string Awards { get; set; }
            /// <summary>
            ///     Affiche du film.
            /// </summary>
            public string Poster { get; set; }
            //public string Ratings { get; set; }
            /// <summary>
            ///     Score moyen du film.
            /// </summary>
            public string Metascore { get; set; }
            /// <summary>
            ///     Note du film d'Internet Movie Database.
            /// </summary>
            public string ImdbRating { get; set; }
            /// <summary>
            ///     Nombre de votes pour le film sur Internet Movie Database.
            /// </summary>
            public string ImdbVotes { get; set; }
            /// <summary>
            ///     Identifiant du film sur Internet Movie Database.
            /// </summary>
            public string ImdbID { get; set; }
            /// <summary>
            ///     Type de média.
            /// </summary>
            public string Type { get; set; }
            /// <summary>
            ///     Sorti en DVD
            /// </summary>
            public string Dvd { get; set; }
            /// <summary>
            ///     Résultats du film au Box Office.
            /// </summary>
            public string BoxOffice { get; set; }
            /// <summary>
            ///     Studio(s) de production.
            /// </summary>
            public string Production { get; set; }
            /// <summary>
            ///     Site web du film.
            /// </summary>
            public string Website { get; set; }
            /// <summary>
            ///     État de la réponse JSON.
            /// </summary>
            public string Response { get; set; }
            /// <summary>
            ///     Ma note.
            /// </summary>
            public string MyNote { get; set; }
            /// <summary>
            ///     Statut du visionnage du film (je l'ai vu / à voir).
            /// </summary>
            public string WatchingStatus { get; set; }
            /// <summary>
            ///     Tags associés au film.
            /// </summary>
            public ObservableCollection<string> Tags { get; set; }
        }

        /// <summary>
        ///     Données actuelles.
        /// </summary>
        FilmData _CurrentData;

        /// <summary>
        ///     Sauvegarde des données au début de l'édition.
        /// </summary>
        FilmData? _BackupData;
        #endregion

        #region Properties

        /// <summary>
        ///     Obtient ou défini le titre du film.
        /// </summary>
        public string Title
        {
            get => this._CurrentData.Title;
            set => this.SetProperty(nameof(this.Title), () => this._CurrentData.Title, (v) => this._CurrentData.Title = v, value);
        }

        /// <summary>
        ///     Obtient ou défini l'année du film.
        /// </summary>
        public string Year
        {
            get => this._CurrentData.Year;
            set => this.SetProperty(nameof(this.Year), () => this._CurrentData.Year, (v) => this._CurrentData.Year = v, value);
        }

        /// <summary>
        ///     Obtient ou défini le classement du film.
        /// </summary>
        public string Rated
        {
            get => this._CurrentData.Rated;
            set => this.SetProperty(nameof(this.Rated), () => this._CurrentData.Rated, (v) => this._CurrentData.Rated = v, value);
        }

        /// <summary>
        ///     Obtient ou défini la date de sortie du film.
        /// </summary>
        public string Released
        {
            get => this._CurrentData.Released;
            set => this.SetProperty(nameof(this.Released), () => this._CurrentData.Released, (v) => this._CurrentData.Released = v, value);
        }

        /// <summary>
        ///     Obtient ou défini la durée du film.
        /// </summary>
        public string Runtime
        {
            get => this._CurrentData.Runtime;
            set => this.SetProperty(nameof(this.Runtime), () => this._CurrentData.Runtime, (v) => this._CurrentData.Runtime = v, value);
        }

        /// <summary>
        ///     Obtient ou défini le genre du film.
        /// </summary>
        public string Genre
        {
            get => this._CurrentData.Genre;
            set => this.SetProperty(nameof(this.Genre), () => this._CurrentData.Genre, (v) => this._CurrentData.Genre = v, value);
        }

        /// <summary>
        ///     Obtient ou défini le directeur du film.
        /// </summary>
        public string Director
        {
            get => this._CurrentData.Director;
            set => this.SetProperty(nameof(this.Director), () => this._CurrentData.Director, (v) => this._CurrentData.Director = v, value);
        }

        /// <summary>
        ///     Obtient ou défini le rédacteur du film.
        /// </summary>
        public string Writer
        {
            get => this._CurrentData.Writer;
            set => this.SetProperty(nameof(this.Writer), () => this._CurrentData.Writer, (v) => this._CurrentData.Writer = v, value);
        }

        /// <summary>
        ///     Obtient ou défini les acteurs du film.
        /// </summary>
        public string Actors
        {
            get => this._CurrentData.Actors;
            set => this.SetProperty(nameof(this.Actors), () => this._CurrentData.Actors, (v) => this._CurrentData.Actors = v, value);
        }

        /// <summary>
        ///     Obtient ou défini le résumé du film.
        /// </summary>
        public string Plot
        {
            get => this._CurrentData.Plot;
            set => this.SetProperty(nameof(this.Plot), () => this._CurrentData.Plot, (v) => this._CurrentData.Plot = v, value);
        }

        /// <summary>
        ///     Obtient ou défini la/les langue(s) du film.
        /// </summary>
        public string Language
        {
            get => this._CurrentData.Language;
            set => this.SetProperty(nameof(this.Language), () => this._CurrentData.Language, (v) => this._CurrentData.Language = v, value);
        }

        /// <summary>
        ///     Obtient ou défini le(s) pays de sortie du film.
        /// </summary>
        public string Country
        {
            get => this._CurrentData.Country;
            set => this.SetProperty(nameof(this.Country), () => this._CurrentData.Country, (v) => this._CurrentData.Country = v, value);
        }

        /// <summary>
        ///     Obtient ou défini la/les récompense(s) du film.
        /// </summary>
        public string Awards
        {
            get => this._CurrentData.Awards;
            set => this.SetProperty(nameof(this.Awards), () => this._CurrentData.Awards, (v) => this._CurrentData.Awards = v, value);
        }

        /// <summary>
        ///     Obtient ou défini les notes du film.
        /// </summary>
        /*public string Ratings
        {
            get => this._CurrentData.Ratings;
            set => this.SetProperty(nameof(this.Ratings), () => this._CurrentData.Ratings, (v) => this._CurrentData.Ratings = v, value);
        }*/

        /// <summary>
        ///     Obtient ou défini l'affiche du film.
        /// </summary>
        public string Poster
        {
            get => this._CurrentData.Poster;
            set => this.SetProperty(nameof(this.Poster), () => this._CurrentData.Poster, (v) => this._CurrentData.Poster = v, value);
        }

        /// <summary>
        ///     Obtient ou défini le score moyen du film.
        /// </summary>
        public string Metascore
        {
            get => this._CurrentData.Metascore;
            set => this.SetProperty(nameof(this.Metascore), () => this._CurrentData.Metascore, (v) => this._CurrentData.Metascore = v, value);
        }

        /// <summary>
        ///     Obtient ou défini la note du film d'Internet Movie Database.
        /// </summary>
        public string ImdbRating
        {
            get => this._CurrentData.ImdbRating;
            set => this.SetProperty(nameof(this.ImdbRating), () => this._CurrentData.ImdbRating, (v) => this._CurrentData.ImdbRating = v, value);
        }

        /// <summary>
        ///     Obtient ou défini le nombre de votes du film sur Internet Movie Database.
        /// </summary>
        public string ImdbVotes
        {
            get => this._CurrentData.ImdbVotes;
            set => this.SetProperty(nameof(this.ImdbVotes), () => this._CurrentData.ImdbVotes, (v) => this._CurrentData.ImdbVotes = v, value);
        }

        /// <summary>
        ///     Obtient ou défini l'ID du film sur Internet Movie Database.
        /// </summary>
        public string ImdbID
        {
            get => this._CurrentData.ImdbID;
            set => this.SetProperty(nameof(this.ImdbID), () => this._CurrentData.ImdbID, (v) => this._CurrentData.ImdbID = v, value);
        }

        /// <summary>
        ///     Obtient ou défini le type de média du film.
        /// </summary>
        public string Type
        {
            get => this._CurrentData.Type;
            set => this.SetProperty(nameof(this.Type), () => this._CurrentData.Type, (v) => this._CurrentData.Type = v, value);
        }

        /// <summary>
        ///     Obtient ou défini si le film est sorti en DVD.
        /// </summary>
        public string Dvd
        {
            get => this._CurrentData.Dvd;
            set => this.SetProperty(nameof(this.Dvd), () => this._CurrentData.Dvd, (v) => this._CurrentData.Dvd = v, value);
        }

        /// <summary>
        ///     Obtient ou défini les résultats au box office du film.
        /// </summary>
        public string BoxOffice
        {
            get => this._CurrentData.BoxOffice;
            set => this.SetProperty(nameof(this.BoxOffice), () => this._CurrentData.BoxOffice, (v) => this._CurrentData.BoxOffice = v, value);
        }

        /// <summary>
        ///     Obtient ou défini le(s) studio(s) de production du film.
        /// </summary>
        public string Production
        {
            get => this._CurrentData.Production;
            set => this.SetProperty(nameof(this.Production), () => this._CurrentData.Production, (v) => this._CurrentData.Production = v, value);
        }

        /// <summary>
        ///     Obtient ou défini le site web du film.
        /// </summary>
        public string Website
        {
            get => this._CurrentData.Website;
            set => this.SetProperty(nameof(this.Website), () => this._CurrentData.Website, (v) => this._CurrentData.Website = v, value);
        }

        /// <summary>
        ///     Obtient ou défini l'état de la réponse à l'API des films.
        /// </summary>
        public string Response
        {
            get => this._CurrentData.Response;
            set => this.SetProperty(nameof(this.Response), () => this._CurrentData.Response, (v) => this._CurrentData.Response = v, value);
        }

        /// <summary>
        ///     Obtient ou défini ma note du film.
        /// </summary>
        public string MyNote
        {
            get => this._CurrentData.MyNote;
            set => this.SetProperty(nameof(this.MyNote), () => this._CurrentData.MyNote, (v) => this._CurrentData.MyNote = v, value);
        }

        /// <summary>
        ///     Obtient ou défini le classement du film.
        /// </summary>
        public string WatchingStatus
        {
            get => this._CurrentData.WatchingStatus;
            set => this.SetProperty(nameof(this.WatchingStatus), () => this._CurrentData.WatchingStatus, (v) => this._CurrentData.WatchingStatus = v, value);
        }

        /// <summary>
        ///     Obtient ou défini les tags du film.
        /// </summary>
        [JsonIgnore]
        public ObservableCollection<string> Tags
        {
            get => this._CurrentData.Tags;
            set => this.SetProperty(nameof(this.Tags), () => this._CurrentData.Tags, (v) => this._CurrentData.Tags = v, value);
        }
        #endregion

        #region Constructors

        /// <summary>
        ///     Initialise une nouvelle instance de la classe <see cref="Film"/>.
        /// </summary>
        public Film()
        {
            this.Tags = new ObservableCollection<string>();
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
