using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestAPI.Models;
//using TestAPI.Repository.IRepostiory;
using System.Net;
using System.Text.Json;

namespace TestAPI.Controllers.v1
{
    [Route("api/v{version:apiVersion}/CategoryAPI")]
    [ApiController]
    //[ApiVersion("1.0")]
    public class CategoryAPIController : ControllerBase
    {
        //protected APIResponse _response;
        //private readonly ICategoryRepository _dbCategory;
        //private readonly IMapper _mapper;

        //public CategoryAPIController(ICategoryRepository dbCategory, IMapper mapper)
        //{
        //    _dbCategory = dbCategory;
        //    _mapper = mapper;
        //    _response = new();
        //}

        //[HttpGet]
        //[ResponseCache(CacheProfileName = "Default30")]
        //[ProducesResponseType(StatusCodes.Status403Forbidden)]
        //[ProducesResponseType(StatusCodes.Status401Unauthorized)]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //public async Task<ActionResult<APIResponse>> GetCategories(int pageSize = 0, int pageNumber = 1)
        //{
        //    try
        //    {

        //        IEnumerable<Category> categoryList;

        //        categoryList = await _dbCategory.GetAllAsync(pageSize: pageSize,
        //                pageNumber: pageNumber);
                
               
        //        Pagination pagination = new() { PageNumber = pageNumber, PageSize = pageSize };

        //        Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(pagination));
        //        _response.Result = _mapper.Map<List<VillaDTO>>(categoryList);
        //        _response.StatusCode = HttpStatusCode.OK;
        //        return Ok(_response);

        //    }
        //    catch (Exception ex)
        //    {
        //        _response.IsSuccess = false;
        //        _response.ErrorMessages
        //             = new List<string>() { ex.ToString() };
        //    }
        //    return _response;

        //}

    }
}
