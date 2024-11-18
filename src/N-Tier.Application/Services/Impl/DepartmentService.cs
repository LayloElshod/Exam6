using AutoMapper;
using N_Tier.Application.Models.DepartmentDtos;
using N_Tier.Core.Entities;
using N_Tier.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.Application.Services.Impl
{
    public class DepartmentService : IDepartmentSevice
    {
        private readonly IDepartmentRepository _repository;
        private readonly IMapper _mapper;

        public DepartmentService(IDepartmentRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<DepartmentCreateReponseModel> CreateAsync(DepartmentCreateModel model)
        {
            var department = _mapper.Map<Department>(model);
            var res=await _repository.AddAsync(department);
            var result=_mapper.Map<DepartmentCreateReponseModel>(model);
            return result;
        }

        public async Task<Guid> DeleteAsync(Guid id)
        {
            var department=await _repository.GetFirstAsync(x=>x.Id==id);
            var result = await _repository.DeleteAsync(department);
            return id;
        }

        public IEnumerable<DepartmentResponseModel> GetAll()
        {
            var list=_repository.GetAllAsEnumurable();
            var departments=_mapper.Map<IEnumerable<DepartmentResponseModel>>(list);
            return departments;
        }

        public async Task<DepartmentUpdateResponseModel> UpdateAsync(DepartmentUpdateModel model)
        {
            var department=_mapper.Map<Department>(model);
            var res=await _repository.UpdateAsync(department);
            var result = _mapper.Map<DepartmentUpdateResponseModel>(model);
            return result;
        }
    }
}
