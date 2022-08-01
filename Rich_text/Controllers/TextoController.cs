using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Rich_text.Models;
using Rich_text.Repositorio;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

namespace Rich_text.Controllers
{
    public class TextoController : Controller
    {
        private readonly ITextoRepositorio _textoRepositorio;

        public TextoController(ITextoRepositorio textoRepositorio)
        {
            _textoRepositorio = textoRepositorio;
        }

        
        

        public IActionResult Index(TextoModel dados)
        {
            string sessaoUsuario = HttpContext.Session.GetString("sessaoUsuarioLogado");

            if (string.IsNullOrEmpty(sessaoUsuario)) return null;

            UsuarioModel usuario = JsonConvert.DeserializeObject<UsuarioModel>(sessaoUsuario);

            dados.UsuarioId = usuario.Id;
            usuario.Perfil = usuario.Perfil;

            List<TextoModel> textos;
            textos = _textoRepositorio.BucarPorUsuarioId(usuario.Id);

            if (usuario.Perfil == 0)
            {
                textos = _textoRepositorio.BucarTodos();
            }
            else
            {
                textos = _textoRepositorio.BucarPorUsuarioId(usuario.Id);
            }






            return View(textos);

        }


        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(TextoModel dados)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //Recuperando o usuario logado 

                    #region buscando usuario da session  
                    
                    string sessaoUsuario = HttpContext.Session.GetString("sessaoUsuarioLogado");

                    if (string.IsNullOrEmpty(sessaoUsuario)) return null;

                    UsuarioModel usuario = JsonConvert.DeserializeObject<UsuarioModel>(sessaoUsuario);

                    #endregion 

                    dados.UsuarioId = usuario.Id;

                    dados = _textoRepositorio.Adicionar(dados);

                    




                    TempData["MensagemSucesso"] = "Usuário cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }
                return View(dados);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar o seu usuário, tente novamente, detalhe do erro: {erro.Message}";
                return View(dados);
            }
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


       
        public IActionResult Editar(int id)
        {
            TextoModel texto = _textoRepositorio.BuacarPorId(id);
            return View(texto);
        }

        [HttpPost]
        public IActionResult Editar(TextoModel textoModel)
        {
            try
            {
                TextoModel texto = null;

                if (ModelState.IsValid)
                {
                    texto = new TextoModel()
                    {
                        Id = textoModel.Id,
                        Titulo = textoModel.Titulo,
                        //Descricacao = textoModel.Descricacao,
                        Documento = textoModel.Documento,

                    };

                    texto = _textoRepositorio.Atualizar(texto);
                    TempData["MensagemSucesso"] = "Usuario alterado com sucesso";
                    return RedirectToAction("Editar");
                }
                return View(texto);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não apagar alterar seu usuario, tente novamente, detalhes do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }



        public IActionResult Visualizar(int id)
        {
            TextoModel texto = _textoRepositorio.BuacarPorId(id);
            return View(texto);
        }

        [HttpPost]
        public IActionResult Visualizar(TextoModel textoModel)
        {
            try
            {
                TextoModel texto = null;

                if (ModelState.IsValid)
                {
                    texto = new TextoModel()
                    {
                        Id = textoModel.Id,
                        Titulo = textoModel.Titulo,
                        Documento = textoModel.Documento,

                    };

                    
                    return RedirectToAction("Index");
                }
                return View(texto);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não apagar alterar seu usuario, tente novamente, detalhes do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }


        [HttpPost]
        public ActionResult EnviaEmail()
        {
            string emailDestinatario = Request.Form["txtEmail"];
            SendMail(emailDestinatario);
            return View();
        }

        public bool SendMail(string email)
        {
            try
            {
                // Estancia da Classe de Mensagem
                MailMessage _mailMessage = new MailMessage();
                // Remetente
                _mailMessage.From = new MailAddress("rafaeltavares462@gmail.com");

                // Destinatario seta no metodo abaixo

                //Contrói o MailMessage
                _mailMessage.CC.Add(email);
                _mailMessage.Subject = "Teste Thiago";
                _mailMessage.IsBodyHtml = true;
                _mailMessage.Body = "<b>Olá Tudo bem ??</b><p>Teste Parágrafo</p>";

                //CONFIGURAÇÃO COM PORTA
                SmtpClient _smtpClient = new SmtpClient("smtp.gmail.com", Convert.ToInt32("587"));

                //CONFIGURAÇÃO SEM PORTA
                // SmtpClient _smtpClient = new SmtpClient(UtilRsource.ConfigSmtp);

                // Credencial para envio por SMTP Seguro (Quando o servidor exige autenticação)
                _smtpClient.UseDefaultCredentials = false;
                _smtpClient.Credentials = new NetworkCredential("rafaeltavares462@gmail.com", "rafaeltavares");

                _smtpClient.EnableSsl = true;

                _smtpClient.Send(_mailMessage);

                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
