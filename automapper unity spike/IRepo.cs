using System.Collections.Generic;

namespace automapper_unity_spike
{
    public interface IRepo
    {
        List<string> Get();
    }

    public class Repo : IRepo
    {
        public List<string> Get()
        {
            return new List<string>
            {
                "Hello", "World", "!"
            };
        }
    }
}