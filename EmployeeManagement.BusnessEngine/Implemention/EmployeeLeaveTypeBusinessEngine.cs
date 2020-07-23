using System;
using EmployeeManagement.BusnessEngine.Contracts;
using EmployeeManagement.BusnessEngine.ResultModels;
using EmployeeManagement.Common.ConstantsModels;
using EmployeeManagement.Data.DbModels;
using EmployeeManagement.Data.DbModels.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using AutoMapper;
using EmployeeManagement.Common.ViewModels;

namespace EmployeeManagement.BusnessEngine.Implemention
{
    public class EmployeeLeaveTypeBusinessEngine : IEmployeeLeaveTypeBusinessEngine
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        #region Constructor
        public EmployeeLeaveTypeBusinessEngine(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        #endregion

        #region CustomMethods
        public Result<List<EmployeeLeaveTypeVM>> GetAllEmployeeLeaveTypes()
        {
            var data = _unitOfWork.employeeLeaveTypeRepository.GetAll(e=>e.IsActive == true).ToList();
            #region 1.Yontem
            //if (data != null)
            //{
            //    List<EmployeeLeaveType> returnData = new List<EmployeeLeaveType>();
            //    foreach (var item in data)
            //    {
            //        returnData.Add(new EmployeeLeaveType()
            //        {
            //            ID = item.ID,
            //            DateCreated = item.DateCreated,
            //            Name = item.Name,
            //            DefaultDays = item.DefaultDays
            //        });
            //    }
            //    return new Result<List<EmployeeLeaveType>>(true, ResultConstant.RecordFound, returnData);
            //}
            //else
            //{
            //    return new Result<List<EmployeeLeaveType>>(false, ResultConstant.RecordNotFound);
            //} 
            #endregion
            
            #region 2.Yontem
            var leaveTypes = _mapper.Map<List<EmployeeLeaveType>, List<EmployeeLeaveTypeVM>>(data);
            return new Result<List<EmployeeLeaveTypeVM>>(true, ResultConstant.RecordNotFound, leaveTypes); 
            #endregion
        }

        public Result<EmployeeLeaveTypeVM> CreateEmployeeLeaveType(EmployeeLeaveTypeVM model)
        {
            if (model != null)
            {
                try
                {
                    var leaveType = _mapper.Map<EmployeeLeaveTypeVM, EmployeeLeaveType>(model);
                    leaveType.DateCreated = DateTime.Now;
                    leaveType.IsActive = true;
                    _unitOfWork.employeeLeaveTypeRepository.Add(leaveType);
                    _unitOfWork.Save();
                    return new Result<EmployeeLeaveTypeVM>(true, ResultConstant.RecordCreateSuccessfully);
                }
                catch (Exception ex)
                {
                    return new Result<EmployeeLeaveTypeVM>(false, ResultConstant.RecordCreateNotSuccessfully + "=>" + ex.Message);
                }
            }
            else
            {
                return new Result<EmployeeLeaveTypeVM>(false, "Parametre olarak geçilen data boş bırakılamaz.");
            }
        }

        public Result<EmployeeLeaveTypeVM> GetAllEmployeeLeaveType(int id)
        {
            var data = _unitOfWork.employeeLeaveTypeRepository.Get(id);
            if (data != null)
            {
                var leaveType = _mapper.Map<EmployeeLeaveType, EmployeeLeaveTypeVM>(data);
                return  new Result<EmployeeLeaveTypeVM>(true,ResultConstant.RecordNotFound,leaveType);
            }
            else
                return new Result<EmployeeLeaveTypeVM>(false,ResultConstant.RecordNotFound);
        }

        public Result<EmployeeLeaveTypeVM> EditEmployeeLeaveType(EmployeeLeaveTypeVM model)
        {
            if (model != null)
            {
                try
                {
                    var leaveType = _mapper.Map<EmployeeLeaveTypeVM, EmployeeLeaveType>(model);
                    leaveType.DateCreated = DateTime.Now;
                    _unitOfWork.employeeLeaveTypeRepository.Update(leaveType);
                    _unitOfWork.Save();
                    return new Result<EmployeeLeaveTypeVM>(true, ResultConstant.RecordUpdateSuccessfully);
                }
                catch (Exception ex)
                {

                    return new Result<EmployeeLeaveTypeVM>(false,ResultConstant.RecordNotUpdateSuccessfully + " => " + ex.Message);
                }
            }
            else
                return new Result<EmployeeLeaveTypeVM>(false,"Parametre Olarak Geçilen Değer Boş Olamaz!");
        }

        
        public Result<EmployeeLeaveTypeVM> RemoveEmployeeLeaveType(int id)
        {
            var data = _unitOfWork.employeeLeaveTypeRepository.Get(id);
            if (data != null)
            {
                data.IsActive = false;
                _unitOfWork.employeeLeaveTypeRepository.Update(data);
                _unitOfWork.Save();
                return new Result<EmployeeLeaveTypeVM>(true,ResultConstant.RecordCreateSuccessfully);
            }
            else
                return new Result<EmployeeLeaveTypeVM>(false,ResultConstant.RecordCreateNotSuccessfully);
        }
        #endregion



    }
}
