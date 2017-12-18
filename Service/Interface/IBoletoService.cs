using Model;
using System.Collections.Generic;

namespace Service.Interface
{
    public interface IBoletoService
    {
        List<Boleto> ListBoleto();

        List<Boleto> ListBoleto(int id);
    }
}
