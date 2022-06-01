using Microsoft.AspNetCore.Mvc;
using Rich_text.Models;
using Rich_text.Repositorio;
using System;
using System.Collections.Generic;

namespace Rich_text.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public IActionResult Index()
        {
            List<UsuarioModel> usuarios = _usuarioRepositorio.BucarTodos();

            return View(usuarios);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(UsuarioModel usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    usuario = _usuarioRepositorio.Adicionar(usuario);

                    TempData["MensagemSucesso"] = "Usuário cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }
                return View(usuario);
            }
            catch(Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar o seu usuário, tente novamente, detalhe do erro: { erro.Message}";
                return View(usuario);
            }
        }


        public IActionResult ApagarConfirmacao(int id)
        {
            UsuarioModel usuario = _usuarioRepositorio.BuacarPorId(id);
            return View(usuario);
        }


        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _usuarioRepositorio.Apagar(id);

                if (apagado) TempData["MensagemSucesso"] = "Usuário apagado com sucesso."; else TempData["MensagemErro"] = "Ops, não conseguimos apagar seu usuário, tente novamente.";
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar seu usuário, tente novamente, detalhes do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        // Aqui é onde tras de volta o usuario
        public IActionResult Editar(int id)
        {
            UsuarioModel usuario = _usuarioRepositorio.BuacarPorId(id);
            return View(usuario);
        }


        [HttpPost]
        public IActionResult Editar(UsuarioSemSenhaModel usuarioSemSenhaModel)
        {
            try
            {
                UsuarioModel usuario = null;

                if (ModelState.IsValid)
                {
                    usuario = new UsuarioModel()
                    {
                        Id = usuarioSemSenhaModel.Id,
                        Nome = usuarioSemSenhaModel.Nome,
                        Login = usuarioSemSenhaModel.Login,
                        Email = usuarioSemSenhaModel.Email,
                        Perfil = usuarioSemSenhaModel.Perfil

                    };

                    usuario = _usuarioRepositorio.Atualizar(usuario);
                    TempData["MensagemSucesso"] = "Usuario alterado com sucesso";
                    return RedirectToAction("Index");
                }
                return View(usuario);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não apagar alterar seu usuario, tente novamente, detalhes do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        } 

    }
}
