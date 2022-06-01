using Rich_text.Data;
using Rich_text.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rich_text.Repositorio
{
    public class TextoRepositorio : ITextoRepositorio
    {
        private readonly BancoContext _context;

        public TextoRepositorio(BancoContext bancoContext)
        {
            _context = bancoContext;
        }


        public TextoModel Adicionar(TextoModel texto)
        {
            texto.DataDeAlteracao = DateTime.Now;
            _context.Textos.Add(texto);
            _context.SaveChanges();
            return texto;
        }

        public bool Apagar(int id)
        {
            TextoModel textoDB = BuacarPorId(id);
            if (textoDB == null) throw new Exception("Houve um erro de deleção do usuário.");

            _context.Textos.Remove(textoDB);
            _context.SaveChanges();

            return true;
        }

        public TextoModel Atualizar(TextoModel texto)
        {
            TextoModel textoDB = BuacarPorId(texto.Id);

            if (textoDB == null) throw new Exception("Houve um erro ao atualizar o Usuário.");

            textoDB.Titulo = texto.Titulo;
            textoDB.Descricacao = texto.Descricacao;
            textoDB.DataDeAlteracao = DateTime.Now;


            _context.Textos.Update(textoDB);
            _context.SaveChanges();

            return textoDB;
        }

        public TextoModel BuacarPorId(int id)
        {
            return _context.Textos.FirstOrDefault(x => x.Id == id);
        }

        public List<TextoModel> BucarTodos()
        {
            return _context.Textos.ToList();
        }
    }
}
