using API.DTOs.Requests.Billing;
using API.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class TicketController : BaseController
{
    // Create a new ticket within an organization
    [Authorize(Roles = RolesConstants.User)]
    [HttpGet("{organizationId}")]
    [ProducesResponseType<bool>(StatusCodes.Status200OK)]
    [ProducesResponseType<string>(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Create([FromBody] CreateBillingRequest request)
    {
        return Ok();
    }

    // Get ticket by id

    // Get all tickets (by filter)

    // Update ticket

    // Delete ticket
}
