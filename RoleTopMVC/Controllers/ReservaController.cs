using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Enums;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class ReservaController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        ReservaRepository reservaRepository = new ReservaRepository();
        public IActionResult Index()
        {
            ReservaViewModel pvm = new ReservaViewModel();

            var emailCliente = ObterUsuarioSession();
            if(!string.IsNullOrEmpty(emailCliente))
            {
                pvm.Cliente = clienteRepository.ObterPor(emailCliente);
            }

            var nomeUsuario = ObterUsuarioNomeSession();
            if(!string.IsNullOrEmpty(nomeUsuario))
            {
                pvm.NomeCliente = nomeUsuario;
            }

                pvm.NomeView = "Reserva";
                pvm.UsuarioEmail = emailCliente;
                pvm.UsuarioNome = nomeUsuario;

                return View(pvm);

        }

        public IActionResult Registrar(IFormCollection form){
            ViewData["Action"]= "Reserva";
            Reserva reserva = new Reserva();


            Cliente cliente = new Cliente();
            cliente.Nome = form["nome"];
            cliente.Email = form["email"];

            reserva.Cliente = cliente;
            reserva.DataDaReserva = DateTime.Now;

            if(reservaRepository.Inserir(reserva))
            {
                return View ("Sucesso", new RespostaViewModel()
                {
                    NomeView = "Reserva",
                    Mensagem = $"{cliente.Nome} seu reserva foi concluída!"
                });
                
            } else {
                return View ("Erro", new RespostaViewModel()
                {
                    NomeView = "Reserva",
                    Mensagem = $"{cliente.Nome} seu reserva não foi concluída!"
                });
            }


        }
    
        public IActionResult Aprovar(ulong id)
        {
            var reserva = reservaRepository.ObterPor(id);
            reserva.Status = (uint) StatusReserva.APROVADO;

            if(reservaRepository.Atualizar(reserva))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else {
                return View("Erro", new RespostaViewModel("Não foi possível aprovar este reserva")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()                   
                 });
                
            }

        }

        public IActionResult Reprovar(ulong id)
        {
            var reserva = reservaRepository.ObterPor(id);
            reserva.Status = (uint) StatusReserva.REPROVADO;

            if(reservaRepository.Atualizar(reserva))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else {
                return View("Erro", new RespostaViewModel("Não foi possível reprovar este reserva")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()                   
                 });
                
            }

        }
    
    }
}