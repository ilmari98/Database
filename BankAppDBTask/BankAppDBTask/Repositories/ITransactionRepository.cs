using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace BankAppDBTask.Repositories
{
    interface ITransactionRepository
    {
        List<Transaction> Read();
    }
}
