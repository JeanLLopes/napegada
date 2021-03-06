﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaPegada.Model
{
    public class DoacaoMOD : ObjectMongo
    {
        private IList<string> _pathsFotos;

        public IEnumerable<string> Fotos 
        { 
            get
            {
                return _pathsFotos;
            } 
            protected set
            {
                _pathsFotos = (IList<string>)value;
            }
        }

        public AnimalPorte PorteAnimal { get; set; }
        public string RacaAnimal { get; set; }
        public AnimalEspecie EspecieAnimal { get; set; }
        public DateTime DataCadastro { get; set; }
        public string NomeAnimal { get; set; }
        public string Caracteristicas { get; set; }
        public bool EhVacinado { get; set; }
        public bool TomouVermifugo { get; set; }
        public bool EhCastrado { get; set; }
        public AnimalIdadeMOD IdadeAnimal { get; set; }
        public RelatorioDoacaoMOD Relatorio { get; set; }

        public DoacaoMOD()
        {
            Fotos = new List<string>();
            DataCadastro = DateTime.Today;
        }

        public void AdicionarFoto(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException("path");

            _pathsFotos.Add(path);
        }
    }
}
