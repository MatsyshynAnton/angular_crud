using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogicLayer.Exceptions;
using BusinessLogicLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectStructureHW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollectionController : ControllerBase
    {
        private readonly ICollectionService _collectionService;

        public CollectionController(ICollectionService collectionService)
        {
            _collectionService = collectionService;
        }

        /// <summary>
        /// This is solution for 1st task from LINQ homework
        /// </summary>
        [HttpGet("ProjectIdAndTaskCount/{projectOwnerId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetProjectsIdAndTaskCount(int projectOwnerId)
        {
            return new JsonResult((await _collectionService.GetProjectsIdAndTaskCount(projectOwnerId)).Select(o => new { Key = o.Key, Value = o.Value }));
        }

        /// <summary>
        /// This is solution for 2nd task from LINQ homework
        /// </summary>
        [HttpGet("UsersTask/{userId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetUsersTask(int userId)
        {
            return new JsonResult(await _collectionService.GetUsersTask(userId));
        }

        /// <summary>
        /// This is solution for 3d task from LINQ homework
        /// </summary>
        [HttpGet("FinishedTask/{userId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetFinishedUserTasks(int userId)
        {
            return new JsonResult(await _collectionService.GetFinishedUserTasks(userId));
        }

        /// <summary>
        /// This is solution for 4th task from LINQ homework
        /// </summary>
        [HttpGet("TeamsWithUsers")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetTeamsWithUsers()
        {
            return new JsonResult(await _collectionService.GetTeamsWithUsers());
        }

        /// <summary>
        /// This is solution for 5th task from LINQ homework
        /// </summary>
        [HttpGet("UsersWithTasks")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetUsersWithTasks()
        {
            return new JsonResult(await _collectionService.GetUsersWithTasks());
        }

        /// <summary>
        /// This is solution for 6th task from LINQ homework
        /// </summary>
        [HttpGet("LastUserProject/{userId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetLastUserProject(int userId)
        {
            return new JsonResult(await _collectionService.GetLastUserProject(userId));
        }

        /// <summary>
        /// This is solution for 7th task from LINQ homework
        /// </summary>
        [HttpGet("ProjectWithTeam")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetProjectWithTeam()
        {
            return new JsonResult(await _collectionService.GetProjectWithTeam());
        }
    }
}
