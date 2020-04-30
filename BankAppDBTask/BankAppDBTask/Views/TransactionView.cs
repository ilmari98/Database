using BankAppDBTask.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppDBTask.Views
{
    class TransactionView : ITransactionView
    {
        private readonly ITransactionRepository transactionRepository = new TransactionRepository();
        
        public void ReadTransactions()
        {
            var transactions = transactionRepository.Read();
            return transactions;
        }
    }
}
