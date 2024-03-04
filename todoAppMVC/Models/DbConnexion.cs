using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace todoAppMVC.Models
{
    public static class DbConnexion
    {
        public static NpgsqlConnection connectionString = 
            new NpgsqlConnection(ConfigurationManager.ConnectionStrings["todoConnex"].ConnectionString);
        
        public static bool VerifierUtilisateur (Utilisateur utilisateur)
        {
            var req = $"SELECT * FROM public.utilisateur WHERE nom = '{utilisateur.NonUtilisateur}' AND password = '{utilisateur.PasswordUtilisateur}'";
            var hasUser = false;

            try
            {
                connectionString.Open();
                var cmd = new NpgsqlCommand(req, connectionString);
                var reader = cmd.ExecuteReader();
                hasUser = reader.Read();
                connectionString.Close();
            }
            catch (Exception e)
            {

                throw e;
            }

            return hasUser;
        }

        public static void AjouterUtilisateur(Utilisateur utilisateur)
        {
            var req = $"INSERT INTO public.utilisateur( password, nom)	VALUES( '{utilisateur.PasswordUtilisateur}', '{utilisateur.NonUtilisateur}'); ";
            try
            {
                connectionString.Open();
                var cmd = new NpgsqlCommand (req, connectionString);
                cmd.ExecuteNonQuery();
                connectionString.Close ();

            }
            catch (Exception e)
            {

                throw e;
            }
        }

    }
}