﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyyBLL.services;
using MyyEntity;
using System.Collections.Generic;

namespace MyAPII.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorController : ControllerBase
    {
        private ColorService _ColorService;

        public ColorController(ColorService ColorService)
        {
            _ColorService = ColorService;
        }


        [HttpGet("GetColors")] //attributes called inside square brackets 
        // by default get method fires if we not specify attributes

        public IEnumerable<Colour> GetColors()
        {
            return _ColorService.Getcolors();
        }



        [HttpPost("AddColor")]
        public IActionResult AddColor([FromBody] Colour Color)
        {
            _ColorService.Addcolor(Color);
            return Ok("Color Created successfully!!");
        }

        [HttpDelete("DeleteColor")]

        public IActionResult DeleteColor(int colorId)  //iactionresult it can return anything like integer string json etc
        {
            _ColorService.Removecolor(colorId);

            return Ok("Color Deleted successfully!!");


        }

        [HttpPut("UpdateColor")]

        public IActionResult UpdateColor([FromBody] Colour Color)
        {
            _ColorService.Editcolor(Color);
            return Ok("Color updated successfully!!");
        }


        [HttpGet("GetColorbyId")]
        public Colour GetColorbyId(int colorId)
        {

            return _ColorService.GetcolorbyId(colorId);

        }
    }
}
