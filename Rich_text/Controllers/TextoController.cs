using Microsoft.AspNetCore.Mvc;
using Rich_text.Models;
using Rich_text.Repositorio;
using System;
using System.Collections.Generic;

namespace Rich_text.Controllers
{
    public class TextoController : Controller
    {
        private readonly ITextoRepositorio _textoRepositorio;

        public TextoController(ITextoRepositorio textoRepositorio)
        {
            _textoRepositorio = textoRepositorio;
        }

        public IActionResult Index()
        {
            List<TextoModel> textos = _textoRepositorio.BucarTodos();


            return View(textos);
        }


        public IActionResult ApagarConfirmacao(int id)
        {
            TextoModel texto = _textoRepositorio.BuacarPorId(id);
            return View(texto);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _textoRepositorio.Apagar(id);

                if (apagado) TempData["MensagemSucesso"] = "Usuário apagado com sucesso."; else TempData["MensagemErro"] = "Ops, não conseguimos apagar seu usuário, tente novamente.";
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar seu usuário, tente novamente, detalhes do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }


        public IActionResult Criar()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Criar(TextoModel texto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    texto = _textoRepositorio.Adicionar(texto);

                    TempData["MensagemSucesso"] = "Usuário cadastrado com sucesso!";
                    return RedirectToAction("Criar");
                }
                return View(texto);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar o seu usuário, tente novamente, detalhe do erro: {erro.Message}";
                return View(texto);
            }
        }

        public IActionResult Documento()
        {
            return View();
        }


        
    }
}
