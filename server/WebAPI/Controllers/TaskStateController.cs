using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogicLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectStructureHW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskStateController : ControllerBase
    {
        private readonly ITaskStateService _taskStateService;

        public TaskStateController(ITaskStateService taskStateService)
        {
            _taskStateService = taskStateService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetTaskStates()
        {
            return new JsonResult(await _taskStateService.GetTaskStates());
        }
    }
}
