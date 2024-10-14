using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiSample.Models;

namespace WebApiSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private static readonly List<Project> projects = Data.Data.ProjectDataList;

        /// <summary>
        /// Devuelve la lista de todos los projectos
        /// </summary>
        /// <returns>List de los projectos</returns>
        [HttpGet]
        public IActionResult GetList()
        {
            return Ok(projects);
        }

        [HttpGet("{projectId:int}")]
        public IActionResult GetElement(int projectId)
        {
            var project = projects.FirstOrDefault(x => x.ProjectId == projectId);

            return Ok(project);
        }

        [HttpPost]
        public IActionResult CreateElement(Project project)
        {
            var newproject = project;
            project.ProjectId = projects
                .OrderBy(p => p.ProjectId)
                .Select(x => x.ProjectId)
                .Last()  + 1 ;

            projects.Add(project);

            return Ok(newproject);
        }

        [HttpPut("Start")]
        public IActionResult StartProject([FromQuery] int projectid)
        {
            throw new NotImplementedException();
        }

        [HttpPut("End")]
        public IActionResult EndProject([FromQuery] int projectid)
        {
            throw new NotImplementedException();
        }

        [HttpPut("Pause")]
        public IActionResult PauseProject([FromQuery] int projectid)
        {
            throw new NotImplementedException();
        }


    }
}
