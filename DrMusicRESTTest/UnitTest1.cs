using DRMusicREST.Repositories;
using Xunit;
using DRMusicREST.Models;
using DRMusicREST.Interfaces;



namespace DrMusicRESTTest
{
    public class UnitTest1
    {
        private readonly MusicRecordRepository _musicRecordsRepo;

        public UnitTest1()
        {
            _musicRecordsRepo = new MusicRecordRepository(includeSampleData: false);
            // for db test use dummy table
        }

        [Fact]
        public void GetAllMusicRecords_ShouldReturnListOfMusicRecords()
        {
            //Arrange
            //var expected = new List<MusicRecord>
            //{
            //    new MusicRecord { Id = 1, Title = "Album 1", Artist = "Artist 1", Year = 2020, Duration = 60 },
            //    new MusicRecord { Id = 2, Title = "Album 2", Artist = "Artist 2", Year = 2021, Duration = 45 },
            //    new MusicRecord { Id = 3, Title = "Album 3", Artist = "Artist 3", Year = 2022, Duration = 50 }
            //};

            //Act
            var actual = _musicRecordsRepo.GetAll();


            //Assert
            Assert.IsType<List<MusicRecord>>(actual);
            //Assert.Equal(expected.Count, actual.Count());
        }

        [Fact]
        public void AddRecord_ValidInput()
        {
            // Arrange
            var expected = new List<MusicRecord>
            {
                new MusicRecord { Title = "Album 1", Artist = "Artist 1", Year = 2020, Duration = 60 },
                new MusicRecord { Title = "Album 2", Artist = "Artist 2", Year = 2021, Duration = 45 },
                new MusicRecord { Title = "Album 3", Artist = "Artist 3", Year = 2022, Duration = 50 }
            };

            // Act
            _musicRecordsRepo.Add(expected[0]);
            _musicRecordsRepo.Add(expected[1]);
            _musicRecordsRepo.Add(expected[2]);

            var actual = _musicRecordsRepo.GetAll();
            // Assert
            Assert.Equal(actual.Count(), expected.Count());
        }
        [Fact]
        public void DeleteRecordTest()
        {
            //Arrange
            MusicRecord music1 = new MusicRecord { Title = "Album 1", Artist = "Artist 1", Year = 2020, Duration = 60 };
            MusicRecord music2 = new MusicRecord { Title = "Album 2", Artist = "Artist 2", Year = 2021, Duration = 45 };
            MusicRecord music3 = new MusicRecord { Title = "Album 3", Artist = "Artist 3", Year = 2022, Duration = 50 };





            //Act
            _musicRecordsRepo.Add(music1);
            _musicRecordsRepo.Add(music2);
            _musicRecordsRepo.Add(music3);

            MusicRecord deleted = _musicRecordsRepo.Delete(music2);

            //Assert
            Assert.NotNull(deleted);

            IEnumerable<MusicRecord> records = _musicRecordsRepo.GetAll();
            Assert.True(records.Count() == 2);
            Assert.Contains(music1, records);
            Assert.Contains(music3, records);
            
        }
    }
}
