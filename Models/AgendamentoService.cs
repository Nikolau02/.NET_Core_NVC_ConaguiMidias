using System.Collections.Generic;
using System.Linq;

namespace TCC_Novo.Models
{
    public class AgendamentoService
    {
        public List<Agendamento> Listar()
        {
            using (var context = new Context())
            {
                List<Agendamento> resultado = context.Agendamentos.ToList();
                return resultado;
            }
        }

        public int Agendar(Agendamento agendamento)
        {
            using (var context = new Context())
            {
                context.Agendamentos.Add(agendamento);
                context.SaveChanges();
                return agendamento.Id;
            }
        }

        public Agendamento BuscaPorId(int id)
        {
            using (var context = new Context())
            {
                return context.Agendamentos.Find(id);
            }
        }

        public void Editar(Agendamento editAgendamento)
        {
            using (var context = new Context())
            {
                Agendamento antigoAgendamento = context.Agendamentos.Find(editAgendamento.Id);

                antigoAgendamento.Nome = editAgendamento.Nome;
                antigoAgendamento.Email = editAgendamento.Email;
                antigoAgendamento.Tel = editAgendamento.Tel;
                antigoAgendamento.Negocio = editAgendamento.Negocio;
                antigoAgendamento.Redes = editAgendamento.Redes;

                context.SaveChanges();
            }
        }

        public void Excluir(int id)
        {
            using (var context = new Context())
            {
                context.Agendamentos.Remove(context.Agendamentos.Find(id));
                context.SaveChanges();
            }
        }
    }
}