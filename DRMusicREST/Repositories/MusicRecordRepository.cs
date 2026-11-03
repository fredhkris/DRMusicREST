using DRMusicREST.Interfaces;
using DRMusicREST.Models;

namespace DRMusicREST.Repositories
{
    public class MusicRecordRepository : IRepository<MusicRecord>
    {

        private List<MusicRecord> _records;
        private static int _nextid;
        public MusicRecordRepository()
        {
            _nextid = 0;
            _records = new List<MusicRecord>();
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
