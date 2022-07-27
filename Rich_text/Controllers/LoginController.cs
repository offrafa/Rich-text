using Microsoft.AspNetCore.Mvc;
using Rich_text.Helper;
using Rich_text.Models;
using Rich_text.Repositorio;
using System;

namespace Rich_text.Controllers
{
    public class LoginController : Controller
    {

        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly ISessao _sessao;

        public LoginController(IUsuarioRepositorio usuarioRepositorio, ISessao sessao)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _sessao = sessao;
        }

        
        public IActionResult Index()
        {
            if(_sessao.BuscarSessaoDoUsuario() != null) return RedirectToAction("Index", "Home");

            return View();
        }


        public IActionResult Sair()
        {
            _sessao.RemoverSessaoDoUsuario();
            return RedirectToAction("Index", "Login");
        }


        [HttpPost]

        public IActionResult Entrar(LoginModel loginModel)
        {
            try 
            {
                if (ModelState.IsValid)
                {
                    UsuarioModel usuario = _usuarioRepositorio.BuscarPorLogin(loginModel.Login);

                    if(usuario != null)
                    {
                        if (usuario.SenhaValida(loginModel.Senha))
                        {
                            _sessao.CriarSessaoDoUsuario(usuario);
                            return RedirectToAction("Index", "Home");
                        }

                        TempData["MensagemErro"] = $"Ops, senha invalida ";


                    }

                    TempData["MensagemErro"] = $"Ops, usuario invalido ";


                }
                return View("Index");
                   
            }catch(Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos realiza o login seu usuário, tente novamente, detalhes do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
