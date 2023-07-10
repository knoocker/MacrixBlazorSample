using MacrixSample.Shared.Dtos.Persons;
using System.Net.Http;
using System.Text.Json;
using System.Text;
using static System.Net.WebRequestMethods;

namespace MacrixBlazorSample.Services
{

    /// <summary>
    /// Service in "normal" way - everything in up to date in database
    /// </summary>
    public class PersonsService : ServiceBase, IPersonsService
    {
        public PersonsService(HttpClient httpClient) : base(httpClient)
        {
        }

        private readonly string CoCORSSuffix = "?access-control-allow-origin=*";

        public async Task<HttpResponseMessage> CreatePerson(PersonToAddDto personToAdd)
        {
            var personJson =
           new StringContent(JsonSerializer.Serialize(personToAdd), Encoding.UTF8, "application/json");
            return await httpClient.PostAsync("persons"+ CoCORSSuffix, personJson);
        }

        public async Task<HttpResponseMessage> DeletePerson(int id)
        {
            return await httpClient.DeleteAsync($"persons/{id}" + CoCORSSuffix);

        }

        public async Task<IEnumerable<PersonToGetDto>> GetAllPersons()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<PersonToGetDto>>
            (await httpClient.GetStreamAsync($"persons/"+ CoCORSSuffix), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

        }

        public async Task<PersonToGetDto> GetPerson(int id)
        {
            return await JsonSerializer.DeserializeAsync<PersonToGetDto>
         (await httpClient.GetStreamAsync("persons/"+id+ CoCORSSuffix), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

        }

        public async Task<HttpResponseMessage> UpdatePerson(int id, PersonToUpdateDto personToUpdateDto)
        {

            var personJson =
      new StringContent(JsonSerializer.Serialize(personToUpdateDto), Encoding.UTF8, "application/json");

            return await httpClient.PutAsync($"persons/{id}"+ CoCORSSuffix, personJson);

        }
    }
}
