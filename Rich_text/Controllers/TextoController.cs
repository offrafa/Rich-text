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
                    return RedirectToAction("Index");
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
