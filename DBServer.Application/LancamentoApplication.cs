using DBServer.Domain;
using DBServer.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBServer.Application
{
    public class LancamentoApplication
    {
        LancamentosRepository lancamentosRepository = new LancamentosRepository();

        public Lancamentos Transferencia(Lancamentos lancamentos)
        {
            return lancamentosRepository.Transferencia(lancamentos);
        }
    }
}
