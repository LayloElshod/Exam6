using N_Tier.Application.Models.DepartmentDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.Application.Services;

public interface IDepartmentSevice
{
    Task<DepartmentCreateReponseModel> CreateAsync(DepartmentCreateModel model);
    IEnumerable<DepartmentResponseModel> GetAll();
    Task<DepartmentUpdateResponseModel> UpdateAsync(DepartmentUpdateModel model);
    Task<Guid> DeleteAsync(Guid id);
}
