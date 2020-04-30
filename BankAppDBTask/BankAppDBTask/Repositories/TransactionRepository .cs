using System.Collections.Generic;
using BankAppDBTask.Data;
using System.Linq;
using System.Transactions;

namespace BankAppDBTask.Repositories
{
    class TransactionRepository : ITransactionRepository
    {
        private readonly BankappContext _context = new BankappContext();

        public List<Transaction> Read()
        {
            var transaction = _context.Transaction.ToList();
            return transaction;
        }
    }
}
