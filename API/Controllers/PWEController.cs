using Application.Common.Constant;
using Application.Common.Enums;
using Application.Common.Extensions;
using Application.Common.Models;
using Application.Common.Models.ProfileDTO;
using Application.UseCases.AudienceCase.Commands;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace API.Controllers
{
    public class PWEController : ApiControllerBase
    {

        [HttpPost]
        [Route("profile/create")]
        [ProducesResponseType(typeof(ResponseModel<CreateProfileResponseModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseModel), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateProfile([FromBody] CreateProfileCommand command)
        {
           
            var result = await Mediator.Send(command);
            return result.Code.Equals(ResponseCode.Success) ? Ok(result) : (IActionResult)BadRequest(result);
        }
        [HttpPost]
        [Route("profile/update")]
        [ProducesResponseType(typeof(ResponseModel<CreateProfileResponseModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseModel), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateProfile([FromBody] UpdateProfileCommand command)
        {

            var result = await Mediator.Send(command);
            return result.Code.Equals(ResponseCode.Success) ? Ok(result) : (IActionResult)BadRequest(result);
        }
    }
}
