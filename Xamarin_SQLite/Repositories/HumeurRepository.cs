using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinForms_SQLite.Models;

namespace XamarinForms_SQLite.Repositories
{

    public class HumeurRepository

    {
        protected SQLiteAsyncConnection _connection;
        public HumeurRepository(string dbPath) { }

        public async Task AjouterHumeurAsync(string commentaire, int note, DateTime dateAjout)
        {
            Humeur monHumeur;
            try
            {
                int nbHumeurs = await _connection.InsertAsync(monHumeur = new Humeur { Commentaire = commentaire, Note = note, DateAjout = dateAjout });
                // Gestion d'un message à afficher
                string Message = $"Humeur du jour ajoutée : {commentaire}.\n {monHumeur}.\n {dateAjout}";
            }
            catch (Exception e)
            {
                string Message = $"Impossible d'ajouter l'humeur : {commentaire}.\n Erreur : {e.Message}";
            }
        }
    }
}
