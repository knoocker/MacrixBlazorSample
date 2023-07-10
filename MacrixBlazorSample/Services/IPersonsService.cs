using MacrixSample.Shared.Dtos.Persons;

namespace MacrixBlazorSample.Services
{
    public interface IPersonsService
    {
        Task<IEnumerable<PersonToGetDto>> GetAllPersons();
        Task<HttpResponseMessage> CreatePerson(PersonToAddDto carToAdd);
        Task<HttpResponseMessage> UpdatePerson(int id, PersonToUpdateDto personToAddDto);
        Task<HttpResponseMessage> DeletePerson(int id);
        Task<PersonToGetDto> GetPerson(int id);
    }
}
