using DRMusicREST.Interfaces;
using DRMusicREST.Models;
using System.Xml.Linq;

namespace DRMusicREST.Repositories
{
    public class MusicRecordRepository : IRepository<MusicRecord>
    {

        private List<MusicRecord> _records;
        private static int _nextid;


        public MusicRecordRepository(bool mockData = true)
        {
            _nextid = 0;
            _records = new();
            // Mock data
            if (mockData)
            {
                _records = new()
                {
                    new MusicRecord("Record1", "Artist1", 1200, 2000 ),
                    new MusicRecord("Record2", "Artist2", 1800, 2005 ),
                };
            }
        }

        public MusicRecord Add(MusicRecord obj)
        {
            if (obj == null)
            {
                return null;
            }

            obj.Id = _nextid++;
            _records.Add(obj);
            return obj;

        }

        public MusicRecord Delete(MusicRecord obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MusicRecord> GetAll()
        {
            return _records;
        }

        public MusicRecord GetById(int id)
        {
            throw new NotImplementedException();
        }

        public MusicRecord Update(int id, MusicRecord obj)
        {
            throw new NotImplementedException();
        }
    }
}
