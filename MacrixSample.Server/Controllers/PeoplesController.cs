using AutoMapper;
using MacrixSample.Database;
using MacrixSample.Database.Entities.Persons;
using MacrixSample.Shared.Dtos.Persons;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.EntityFrameworkCore;
using System;

namespace MacrixSample.Server.Controllers
{


    [Route("api/")]
    [ApiController]
    public class PeoplesController : ControllerBase
    {
        private readonly MacrixDbContext context;
        private readonly IMapper mapper;

        public PeoplesController(MacrixDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }


        [HttpPost("persons")]
        public IActionResult AddPerson(PersonToAddDto personToAdd)
        {

            Person person = mapper.Map<Person>(personToAdd);
            context.Persons.Add(person);
            context.SaveChanges();
            return CreatedAtAction(nameof(AddPerson), new { id = person.Id }, person.Id);
        }

        [HttpGet("persons")]
        public IActionResult GetAllPerson()
        {
            List<Person> persons = context.Persons.Where(p => p.IsDeleted == false).ToList();
            return Ok(mapper.Map<List<PersonToGetDto>>(persons));
        }



        [HttpGet("persons/{id}")]
        public IActionResult GetPerson(int id)
        {

            Person person = context.Persons.AsNoTracking().SingleOrDefault(p => p.Id == id);
            if (person == null)
                return NotFound();


            return Ok(mapper.Map<PersonToGetDto>(person));
        }

        [HttpPut("persons/{id}")]
        public IActionResult EditPerson(int id, PersonToUpdateDto PersonToUpdate)
        {
            Person person = context.Persons.SingleOrDefault(p => p.Id == id);
            if (person == null)
                return NotFound();

            mapper.Map(PersonToUpdate,person );
            context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("persons/{id}")]
        public IActionResult DeletePerson(int id)
        {
            Person person = context.Persons.SingleOrDefault(p => p.Id == id);
            if (person == null)
                return NotFound();

            person.IsDeleted = true;
            context.SaveChanges();

            return NoContent();
        }



    }


}
