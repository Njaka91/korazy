using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace todoAppMVC.Models
{
    public class Utilisateur
    {
        private int _idUtilisateur;
        private string _nomUtilisateur;

        public int IdUtilisateur
        {
            get { return _idUtilisateur; }
            set { _idUtilisateur = value; }
        }
        
        public string NonUtilisateur
        {
            get { return _nomUtilisateur; }
            set { _nomUtilisateur = value; }
        }

        private string _passwordUtilisateur;

        public string PasswordUtilisateur
        {
            get { return _passwordUtilisateur; }
            set { _passwordUtilisateur = value; }
        }

        public Utilisateur(int idUtilisateur, string nomUtilisateur, string passwordUtilisateur)
        {
            _idUtilisateur = idUtilisateur;
            _nomUtilisateur = nomUtilisateur;
            _passwordUtilisateur = passwordUtilisateur;
        }

        public Utilisateur(string nomUtilisateur, string passwordUtilisateur)
        {
            _nomUtilisateur = nomUtilisateur;
            _passwordUtilisateur = passwordUtilisateur;
        }

        public Utilisateur(  )
        {
        }

        public override bool Equals(object obj)
        {
            return obj is Utilisateur utilisateur &&
                   _idUtilisateur == utilisateur._idUtilisateur &&
                   _nomUtilisateur == utilisateur._nomUtilisateur &&
                   _passwordUtilisateur == utilisateur._passwordUtilisateur;
        }
    }
}