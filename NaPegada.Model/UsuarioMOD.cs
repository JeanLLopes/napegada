﻿using System.Collections.Generic;
using System;

namespace NaPegada.Model
{
    public class UsuarioMOD : ObjectMongo
    {
        private IList<TelefoneMOD> _telefones;
        private IList<DoacaoMOD> _doacoes;
        private IList<InteresseMOD> _interesses;

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Reputacao { get; set; }
        public string NomeFotoPerfil { get; set; }
        public IEnumerable<InteresseMOD> Interesses 
        {
            get { return _interesses; }
            protected set { _interesses = (IList<InteresseMOD>)value; }
        }
        public EnderecoMOD Endereco { get; set; }
        public IEnumerable<TelefoneMOD> Telefones 
        {
            get { return _telefones; } 
            protected set {_telefones = (IList<TelefoneMOD>) value;} 
        }
        public IEnumerable<DoacaoMOD> Doacoes 
        {
            get { return _doacoes; }
            protected set { _doacoes = (IList<DoacaoMOD>)value; }
        }

        public UsuarioMOD()
        {
            //E quando não for utilizado ? Serão instanciados ?
            //Toda vez que chamamos a classe UsuarioMOD isso esta sendo instanciado mesmo sem usar ?
            //Podemos colocar esta logica na camada de negocio e utilizar quando realmente for necessário ?
            _telefones = new List<TelefoneMOD>();
            _doacoes = new List<DoacaoMOD>();
            _interesses = new List<InteresseMOD>();
        }

        public void AdicionarTelefone(TelefoneMOD telefone)
        {
            if (telefone == null)
                throw new ArgumentNullException("telefone");

            _telefones.Add(telefone);
        }

        public void AdicionarDoacao(DoacaoMOD doacao)
        {
            if (doacao == null)
                throw new ArgumentNullException("doacao");

            _doacoes.Add(doacao);
        }

        public void ExcluirDoacao(DoacaoMOD doacao)
        {
            _doacoes.Remove(doacao);
        }
    }
}
