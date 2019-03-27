using DBServer.Domain;
using DBServer.Infra.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBServer.Infra.Repository
{
    public class LancamentosRepository : ILancamentos
    {
        
        public Lancamentos Transferencia(Lancamentos operation)
        {
            Lancamentos operationReturn = operation;
            operationReturn.AccountSource.amount = operation.AccountSource.amount - operation.valueTransaction;
            operationReturn.AccountTarget.amount = operation.AccountTarget.amount + operation.valueTransaction;
            return operationReturn;
        }
    }
}
