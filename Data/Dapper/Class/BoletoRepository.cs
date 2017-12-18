using Dapper;
using Data.Dapper.Interface;
using Model;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Data.Dapper.Class
{
    public class BoletoRepository : BaseRepository, IBoletoRepository
    {
        public List<Boleto> ListBoleto()
        {
            List<Boleto> ret;
            using (var db = GetMySqlConnection())
            {
                const string sql = @"select IdPendencia,DescrPendencia,Valor,DataVencimento,DataPagamento from pendfin ";

                ret = db.Query<Boleto>(sql, commandType: CommandType.Text).ToList();
            }

            return ret;
        }

        public List<Boleto> ListBoleto(int id)
        {
            List<Boleto> ret;
            using (var db = GetMySqlConnection())
            {
                const string sql = @"select idmsg, nomemsg, datamsg, imagemsg, checkmsg, textmsg from appmensagens where id_usuario = @Id";

                ret = db.Query<Boleto>(sql, new { Id = id }, commandType: CommandType.Text).ToList();
            }

            return ret;
        }
    }
}
