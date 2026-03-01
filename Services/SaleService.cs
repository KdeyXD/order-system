using DrinkOrderSystem.Data;
using DrinkOrderSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkOrderSystem.Services
{
    public class SaleService
    {
        private readonly SaleRepository _repository;

        public SaleService()
        {
            _repository = new SaleRepository();
        }

        public List<SaleHistory> GetSalesHistory()
        {
            return _repository.GetAllSales();
        }
    }
}
