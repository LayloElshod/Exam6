using Microsoft.AspNetCore.Mvc;
using N_Tier.Application.Models.DepartmentDtos;
using N_Tier.Application.Services;

namespace N_Tier.API.Controllers
{
    public class DepartmentController:ApiController
    {
        private readonly IDepartmentSevice _sevice;

        public DepartmentController(IDepartmentSevice sevice)
        {
            _sevice = sevice;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
           var res= _sevice.GetAll();
            return Ok(res);
        }
        [HttpPost]
        public async Task<ActionResult> CreateAsync(DepartmentCreateModel model)
        {
            var res= await _sevice.CreateAsync(model);
            return Ok(res);
        }
        [HttpPut]
        public async Task<ActionResult> UpdateAsync(DepartmentUpdateModel model)
        {
            var res= await _sevice.UpdateAsync(model);
            return Ok(res);
        }
        [HttpDelete]
        public async Task<ActionResult> Deleteasync(Guid id)
        {
            var res=await _sevice.DeleteAsync(id);
            return Ok(res);
        }
    }
}
