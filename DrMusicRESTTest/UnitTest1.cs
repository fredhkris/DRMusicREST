using DRMusicREST.Interfaces;
using DRMusicREST.Models;
using DRMusicREST.Repositories;

namespace DrMusicRESTTest
{
    public class UnitTest1
    {
        private MusicRecordRepository _repo;

        public UnitTest1()  
        {
            _repo = new(mockData: false);
        }


        [Fact]
        public void GetallTest()
        {
            MusicRecordRepository repo = new(mockData: false);
            //arrange
            MusicRecord r1 = new MusicRecord("sang1", "medina", 122, 2004);
            MusicRecord r2 = new MusicRecord("sang2", "hans", 122, 2006);
            MusicRecord r3 = new MusicRecord("sang3", "mads", 122, 2008);
            //act
            _repo.Add(r1);
            _repo.Add(r2);
            _repo.Add(r3);
            //assert
            Assert.Equal(3, _repo.GetAll().Count());
        }
    }
}
