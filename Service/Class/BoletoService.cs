using Data.Dapper.Interface;
using Model;
using Service.Interface;
using System.Collections.Generic;

namespace Service.Class
{
    public class BoletoService : IBoletoService
    {
        private IBoletoRepository _boletoRepository;

        public BoletoService(IBoletoRepository boletoRepository)
        {
            _boletoRepository = boletoRepository;
        }

        public List<Boleto> ListBoleto()
        {
            return _boletoRepository.ListBoleto();
        }

        public List<Boleto> ListBoleto(int id)
        {
            return _boletoRepository.ListBoleto(id);
        }
    }
}
