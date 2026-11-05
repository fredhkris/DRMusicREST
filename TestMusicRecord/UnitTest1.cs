using DRMusicREST.Models;
using DRMusicREST.Repositories;

namespace TestMusicRecord
{
    public class UnitTest1
    {
        [Fact]
        public void GetAllTest()
        {
            //Arrange
        
            var repo = new MusicRecordRepository();

            MusicRecord song1 = new MusicRecord("Barbie girl", "Aqua", 12, 1997);
            MusicRecord song2 = new MusicRecord("it's my life", "Aqua", 12, 1997);


            

            repo.Add(song1);           
            repo.Add(song2);


            //Act
            repo.GetAll();

            //Assert
            Assert.Equal(2, repo.GetAll().Count());
        }
    }
}
