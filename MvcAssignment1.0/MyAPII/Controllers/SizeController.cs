using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyyBLL.services;
using MyyEntity;
using System.Collections.Generic;

namespace MyAPII.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SizeController : ControllerBase
    {
        private SizeService _SizeService;

        public SizeController(SizeService SizeService)
        {
            _SizeService = SizeService;
        }


        [HttpGet("GetSizes")] //attributes called inside square brackets 
        // by default get method fires if we not specify attributes

        public IEnumerable<Sizee> GetSizes()
        {
            return _SizeService.Getsizes();
        }


        /// <summary>
        /// Size controller-  Register action
        /// </summary>
        /// Connect Diff service to fetch productcode
        /// <param name="Size"></param>
        /// <returns>Message</returns>
        [HttpPost("Addsize")]
        public IActionResult Register([FromBody] Sizee Size)
        {
            _SizeService.Addsize(Size);
            return Ok("size added successfully!!");
        }

        [HttpDelete("DeleteSize")]

        public IActionResult DeleteSize(int sizeId)  //iactionresult it can return anything like integer string json etc
        {
            _SizeService.Removesize(sizeId);

            return Ok("Size Deleted successfully!!");


        }

        [HttpPut("UpdateSize")]

        public IActionResult UpdateSize([FromBody] Sizee Size)
        {
            _SizeService.Editsize(Size);
            return Ok("Size updated successfully!!");
        }


        [HttpGet("GetSizebyId")]
        public Sizee GetSizebyId(int sizeId)
        {

            return _SizeService.GetsizebyId(sizeId);

        }
    }
}
