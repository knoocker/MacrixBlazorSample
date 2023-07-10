using AutoMapper;
using MacrixSample.Database.Entities.Persons;
using MacrixSample.Shared.Dtos.Persons;

namespace MacrixSample.Server.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<PersonToAddDto, Person>();
            CreateMap<PersonToGetDto, Person>();
            CreateMap<PersonToUpdateDto, Person>();

            CreateMap<Person, PersonToAddDto>();
            CreateMap<Person, PersonToGetDto>();
            CreateMap<Person, PersonToUpdateDto>();

        }
    }
}
