using automapper_unity_spike.Models;
using AutoMapper;

namespace automapper_unity_spike
{
    public static class AutoMapperConfiguration
    {
        public static IMapper AutoMapperInit()
        {
            return new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PersonBase, Superhero>();
            }));
        }
    }
}