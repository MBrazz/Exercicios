using System;
using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class ReservaRepository  : RepositoryBase{
        private const string PATH = "Database/Reserva.csv";

        public ReservaRepository () {
            if (!File.Exists (PATH)) {

                File.Create (PATH).Close ();
            }
        }
        public bool Inserir (Reserva reserva) {
            var quantidadeReservas = File.ReadAllLines(PATH).Length;
            reserva.Id = (ulong) ++quantidadeReservas;
            var linha = new string[] { PrepararPedidoCSV (reserva) };
            File.AppendAllLines (PATH, linha);

            return true;
        }

        public List<Reserva> ObterTodosPorCliente(string emailCliente)
        {
        List<Reserva> reservasCliente = new List<Reserva>();
            var reservas = ObterTodos();
            foreach (var reserva in reservas)
            {
                if(reserva.Cliente.Email.Equals(emailCliente))
                {
                    reservasCliente.Add(reserva);
                }
            }
            return reservasCliente;
        }

        public List<Reserva> ObterTodos()
        {
            var linhas = File.ReadAllLines(PATH);
            List<Reserva> reservas = new List<Reserva>();

            foreach (var linha in linhas)
            {
                Reserva reserva = new Reserva();
                
                reserva.Id = ulong.Parse(ExtrairValorDoCampo("id", linha));
                reserva.Status = uint.Parse(ExtrairValorDoCampo("status_pedido", linha));
                reserva.Cliente.Nome = ExtrairValorDoCampo("cliente_nome", linha);
                reserva.Cliente.Email = ExtrairValorDoCampo("cliente_email", linha);
                reserva.PrecoTotal = double.Parse(ExtrairValorDoCampo("preco_total", linha));
                reserva.DataDaReserva = DateTime.Parse(ExtrairValorDoCampo("data_pedido", linha));

                reservas.Add(reserva);
            }
            return reservas;
        }

        public Reserva ObterPor(ulong id)
        {
            var reservasTotais = ObterTodos();
            foreach (var reserva in reservasTotais)
            {
                if(id.Equals(reserva.Id))
                {
                    return reserva;
                }
            }
            return null;
        }

        public bool Atualizar(Reserva reserva)
        {
            var reservasTotais = File.ReadAllLines(PATH);
            var pedidoCSV =  PrepararPedidoCSV(reserva);
            var linhaPedido = -1;
            var resultado = false;

            for (int i = 0; i < reservasTotais.Length; i++)
            {
                var idConvertido =  ulong.Parse(ExtrairValorDoCampo("id", reservasTotais[i]));
                if(reserva.Id.Equals(idConvertido))
                {
                    linhaPedido = i;
                    resultado = true;
                    break;
                }
            }

            if(resultado)
            {
                reservasTotais[linhaPedido] = pedidoCSV;
                File.WriteAllLines(PATH, reservasTotais);
            }

            return resultado;
        }


        private string PrepararPedidoCSV (Reserva reserva) {

            Cliente c = reserva.Cliente;
            return $"id={reserva.Id};status_reserva={reserva.Status};cliente_nome={c.Nome};cliente_email={c.Email};data_pedido={reserva.DataDaReserva};preco_total={reserva.PrecoTotal}";
        }
    }
}