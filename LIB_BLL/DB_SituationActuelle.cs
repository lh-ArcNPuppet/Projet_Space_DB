﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class DB_SituationActuelle
    {
        //Attributs privés
        private int id;
        private string libelle;

        //Constructeur
        public DB_SituationActuelle(int id, string lib)
        {
            this.id = id;
            this.libelle = lib;
        }

        //Accesseurs - Getter
        public int getId() { return this.id; }
        public string getLibelle() { return this.libelle; }

        //Accesseurs - Setter
        public void setCode(int id) { this.id = id; }
        public void setLibelle(string lib) { this.libelle = lib; }
    }
}
