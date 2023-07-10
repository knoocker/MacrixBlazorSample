using AutoMapper;
using MacrixSample.Shared.Dtos.Persons;

namespace MacrixBlazorSample.AutoMapper
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<PersonToUpdateDto, PersonToGetDto>();
            CreateMap<PersonToGetDto,PersonToUpdateDto>();
        }
    }
}
