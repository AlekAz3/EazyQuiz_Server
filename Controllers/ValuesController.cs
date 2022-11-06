using EazyQuiz_Server.Data;
using EazyQuiz_Server.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using System.Net.Http.Json;
using System.Text.Json;

namespace EazyQuiz_Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ApiContext _context;

        public ValuesController(ApiContext context)
        {
            _context = context;
        }


        [HttpGet()]
        public JsonResult GetAll()
        {
            var result = _context.league.ToList();
            return new JsonResult(Ok(result));
        }

        [HttpGet()]
        public JsonResult GetLeague(int id)
        {
            var result = _context.league.Find(id);

            if (result == null)
            {
                return new JsonResult(NotFound());
            }

            return new JsonResult(Ok(result));
        }

        [HttpGet()]
        public JsonResult Check_User(string login, string password)
        {
            var result = _context.user_info.Where(x => x.login == login && x.password == password).ToList();
            if (result == null || result.Count == 0)
                return new JsonResult(NotFound());
            return new JsonResult(Ok(result));
        }

        [HttpGet]
        public JsonResult Get_Question(int id_question)
        {
            var ques = _context.questions.Find(id_question);

            return new JsonResult(ques);
        }

        [HttpGet]
        public JsonResult Get_Answer(int id_question)
        {

            var answ = _context.answers.Where(x => x.id_question == id_question).ToList();

            return new JsonResult(answ);
        }

    }
}
