using Service.Interface;
using Swashbuckle.Swagger.Annotations;
using System.Net;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebAPI.Controllers
{
    [RoutePrefix("api/user")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class BoletoController : ApiController
    {
        protected readonly IBoletoService _boletoService;

        public BoletoController(IBoletoService boletoService)
        {
            _boletoService = boletoService;
        }

        /// <summary>
        /// Retorna Lista de Mensagens
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet]
        [Route("boletolist")]
        [SwaggerResponse(HttpStatusCode.OK, type: typeof(string), description: "Retorna Lista de Boletos")]
        public IHttpActionResult GetBoletoList()
        {
            var ret = _boletoService.ListBoleto();

            if (ret == null)
                throw new HttpResponseException(HttpStatusCode.Unauthorized);

            return Json(ret);
        }

        /// <summary>
        /// Retorna Lista de Mensagens por UserId
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet]
        [Route("boletolistbyuserid")]
        [SwaggerResponse(HttpStatusCode.OK, type: typeof(string), description: "Retorna Lista de Boletos por UserId")]
        public IHttpActionResult GetBoletoList(int userId)
        {
            var ret = _boletoService.ListBoleto(userId);

            if (ret == null)
                throw new HttpResponseException(HttpStatusCode.Unauthorized);

            return Json(ret);
        }
    }
}