using System.Text.Json.Serialization;

namespace WabApiStudy_One.Services
{
    public class DataAccess
    {
        public class MorningDto
        { 
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public class MorningData
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public MorningData GetData()
        {
            var data = new MorningData
            {
                Id = 1,
                Name = "Morning",
            };
            var jsonString = JsonConvert.SerializeObject(response);

            return data;
        }
    }
}
