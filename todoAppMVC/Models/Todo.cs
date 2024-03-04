using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace todoAppMVC.Models
{
    public class Todo
    {
        private int _id;
        private string _tache;
        private string _utilisateurTache;
        private Boolean _statement;


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Tache
        {
            get { return _tache; }
            set { _tache = value; }
        }
        public string UtilisateurTache

        {
            get { return _utilisateurTache; }
            set { _utilisateurTache = value; }
        }
        public Boolean Statement
        {
            get { return _statement; }
            set { _statement = value; }
        }

        public Todo(int id, string tache, string utilisateurTache, bool statement)
        {
            _id = id;
            _tache = tache;
            _utilisateurTache = utilisateurTache;
            _statement = statement;
        }

       public Todo(string tache, string utilisateurTache, bool statement)
        {
            _tache = tache;
            _utilisateurTache = utilisateurTache;
            _statement = statement;
        }

        public Todo()
        {
        }

        public override bool Equals(object obj)
        {
            return obj is Todo todo &&
                   _id == todo._id &&
                   _tache == todo._tache &&
                   _utilisateurTache == todo._utilisateurTache &&
                   _statement == todo._statement;
        }

        public override int GetHashCode()
        {
            int hashCode = -1948483293;
            hashCode = hashCode * -1521134295 + _id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_tache);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_utilisateurTache);
            hashCode = hashCode * -1521134295 + _statement.GetHashCode();
            return hashCode;
        }
    }
}