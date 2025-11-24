using BLL.Abstract;
using ENTITY;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {

        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }
        [HttpGet]
        public async Task<IEnumerable<Project>> GetProjectsAsync()
        {
            var project = await _projectService.GetAllAsync();
            return project;
        }
      
    }
    
}
