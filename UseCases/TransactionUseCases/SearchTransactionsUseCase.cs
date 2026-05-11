using CoreBusiness;
using System;
using System.Collections.Generic;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    // Define the interface right here if it doesn't exist elsewhere
    public interface IViewTransactionsUseCase
    {
        IEnumerable<Transaction> Execute(string cashierName, DateTime startDate, DateTime endDate);
    }

    public class SearchTransactionsUseCase : ISearchTransactionsUseCase, IViewTransactionsUseCase
    {
        private readonly ITransactionRepository transactionRepository;

        public SearchTransactionsUseCase(ITransactionRepository transactionRepository)
        {
            this.transactionRepository = transactionRepository;
        }

        public IEnumerable<Transaction> Execute(string cashierName, DateTime startDate, DateTime endDate)
        {
            return transactionRepository.Search(cashierName, startDate, endDate);
        }
    }
}