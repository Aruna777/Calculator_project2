using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ExerciseController : ControllerBase
{
    [HttpPost]
    public Response Get([FromBody] Request request)
    {
        try
        {
            var data = WebAPI.Data.Data.Excercises.FirstOrDefault(x => x.Id == request.Id);
            return new Response
            {
                Message = "Success",
                Data = data
            };
        }catch(Exception ex)
        {
            return new Response
            {
                Message = ex.Message,
                Data = null
            }; 
        }
    }
}

