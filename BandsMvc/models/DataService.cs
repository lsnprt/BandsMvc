namespace BandsMvc.Models
{
    public class DataService
    {
        List<Band> bands = new List<Band>
        {
            new Band{ Name = "Bad Bunny", Id = 1, Description="Bad Bunny is a reggaeton band from Puerto Rico."},
            new Band{ Name = "Vulfpeck", Id = 1612, Description="Vulfpeck is a funk band from USA."},
            new Band{ Name = "Jay Balvin", Id = 29, Description="Jay Balvin is a reggaeton band from Colombia."},
        };

        public Band[] GetAll()
        {
            return bands
                .OrderBy(o => o.Name)
                .ToArray();
        }
        public Band GetBandById(int id)
        {
            var q = bands
                .Where(o => o.Id == id).First();
            return q;
        }
    }
}
