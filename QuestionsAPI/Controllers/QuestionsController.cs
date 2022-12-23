using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuestionsAPI.Models;
using QuestionsAPI.Services;

namespace QuestionsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : Controller
    {
        private readonly QuestionsRepository questionsRepository;
        public QuestionsController()
        {
            this.questionsRepository = new QuestionsRepository();
        }

        // GET: QuestionsController
        [HttpGet]
        public List<Questions> Get()
        {
            return questionsRepository.GetAllQuestions();
        }

        // GET: QuestionsController/Details/5
        [HttpGet("{id}")]
        public Questions Get(int id)
        {
            return questionsRepository.GetQuestionsByID(id);
        }

        // POST: QuestionsController/Create
        [HttpPost]
        public Questions Post([FromBody] Questions question)
        {
            return question;
        }

        // PUT QuestionsController/5
        [HttpPut("id")]
        public int Put(int id, [FromBody] Questions question)
        {
            return questionsRepository.EditQuesionsByID(id, question);
        }

        [HttpDelete("id")]
        public List<Questions> Delete(int id)
        {
            return questionsRepository.DeleteQuestion(id);
        }

    }
}
