using Microsoft.AspNetCore.Mvc;

namespace tpmodul9_1302210098.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        // variabel static yang menyimpan list mahasiswa
        private static List<Mahasiswa> _mahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa ("Muhammad Alif Rasyid Ramdhani", "1302210098"),
            new Mahasiswa ("Aryasatya Pratama", "1302210082" ),
            new Mahasiswa ("Zakkiya Hakeem", "1302213025" ),
            new Mahasiswa ("Muhammad Zaidan Rafif", "1302213072" ),
            new Mahasiswa ("Hafid Naoya", "1302210129" )
        };

        // GET /api/mahasiswa
        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> GetAll()
        {
            return _mahasiswa;
        }

        // GET /api/mahasiswa/{index}
        [HttpGet("{id}")]
        public ActionResult<Mahasiswa> Get(int id)
        {
            if (id >= 0 && id < _mahasiswa.Count)
            {
                return _mahasiswa[id];
            }
            else
            {
                return NotFound();
            }
        }

        // POST /api/mahasiswa
        [HttpPost]
        public void Post(Mahasiswa mahasiswa)
        {
            _mahasiswa.Add(mahasiswa);
        }

        // DELETE /api/mahasiswa/{index}
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (id >= 0 && id < _mahasiswa.Count)
            {
                _mahasiswa.RemoveAt(id);
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
