using DRMusicREST.Interfaces;
using DRMusicREST.Models;
using DRMusicREST.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DRMusicREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicRecordController : ControllerBase
    {
        private readonly IRepository<MusicRecord> _musicRecordRepository;

        public MusicRecordController(IRepository<MusicRecord> musicRecordRepository)
        {
            _musicRecordRepository = musicRecordRepository;
        }
        // GET: api/<MusicRecordController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<MusicRecord>> Get()
        {
            IEnumerable<MusicRecord> records = _musicRecordRepository.GetAll();
            if (records is null) return NotFound();
            return Ok(records);
        }
         
        // GET api/<MusicRecordController>/5
        [HttpGet("{id}")]
        public ActionResult<MusicRecord> Get(int id)
        {
            throw new NotImplementedException();
        }

        // POST api/<MusicRecordController>
        [HttpPost]
        public ActionResult<MusicRecord> Post([FromBody] MusicRecord value)
        {
            throw new NotImplementedException();
        }

        // PUT api/<MusicRecordController>/5
        [HttpPut("{id}")]
        public ActionResult<MusicRecord> Put(int id, [FromBody] MusicRecord value)
        {
            throw new NotImplementedException();
        }

        // DELETE api/<MusicRecordController>/5
        [HttpDelete("{id}")]
        public ActionResult<MusicRecord> Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
