using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  public class BuggyController : BaseApiController
  {
    [HttpGet("not-found")]
    public ActionResult GetNotFoundRequest()
    {
      return NotFound("This is not found");
    }

    [HttpGet("bad-request")]
    public ActionResult GetBadRequest()
    {
      return BadRequest(new ProblemDetails { Title = "This is a bad request" });
    }
    [HttpGet("unauthorized")]
    public ActionResult GetUnauthorized()
    {
      return Unauthorized("This is an unauthorized request");
    }
    [HttpGet("server-error")]
    public ActionResult GetServerError()
    {
      throw new Exception("This is a server error");
    }
  }
}
