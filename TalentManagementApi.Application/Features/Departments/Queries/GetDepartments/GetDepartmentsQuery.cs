﻿using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TalentManagementApi.Application.Interfaces;
using TalentManagementApi.Application.Interfaces.Repositories;
using TalentManagementApi.Application.Parameters;

namespace TalentManagementApi.Application.Features.Departments.Queries.GetDepartments
{
    /// <summary>
    /// GetAllDepartmentsQuery - handles media IRequest
    /// BaseRequestParameter - contains paging parameters
    /// To add filter/search parameters, add search properties to the body of this class
    /// </summary>
    public class GetDepartmentsQuery : ListParameter, IRequest<IEnumerable<GetDepartmentsViewModel>>
    {
    }

    public class GetAllDepartmentsQueryHandler : IRequestHandler<GetDepartmentsQuery, IEnumerable<GetDepartmentsViewModel>>
    {
        private readonly IDepartmentRepositoryAsync _repository;
        private readonly IModelHelper _modelHelper;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor for GetAllDepartmentsQueryHandler class.
        /// </summary>
        /// <param name="repository">IDepartmentRepositoryAsync object.</param>
        /// <param name="modelHelper">IModelHelper object.</param>
        /// <returns>
        /// GetAllDepartmentsQueryHandler object.
        /// </returns>
        public GetAllDepartmentsQueryHandler(IDepartmentRepositoryAsync repository, IModelHelper modelHelper, IMapper mapper)
        {
            _repository = repository;
            _modelHelper = modelHelper;
            _mapper = mapper;
        }

        /// <summary>
        /// Handles the GetDepartmentsQuery request and returns a PagedResponse containing the requested data.
        /// </summary>
        /// <param name="request">The GetDepartmentsQuery request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A PagedResponse containing the requested data.</returns>
        public async Task<IEnumerable<GetDepartmentsViewModel>> Handle(GetDepartmentsQuery request, CancellationToken cancellationToken)
        {
            string fields = _modelHelper.GetModelFields<GetDepartmentsViewModel>();
            string defaultOrderByColumn = "Name";
            string defaultOrderTypeValue = "asc";

            string orderBy = string.Empty;
            string orderType = string.Empty;

            // if the request orderBy is not null
            if (!string.IsNullOrEmpty(request.OrderBy))
            {
                // check to make sure order by field is valid and in the view model
                orderBy = _modelHelper.ValidateModelFields<GetDepartmentsViewModel>(request.OrderBy);
            }

            // if the request orderType is not null
            if (!string.IsNullOrEmpty(request.OrderType))
            {
                // check to make sure order by field is valid
                orderType = request.OrderType;
            }

            // if the order by is invalid
            if (string.IsNullOrEmpty(orderBy))
            {
                //default fields from view model
                orderBy = defaultOrderByColumn;
            }

            // if the order type is invalid
            if (string.IsNullOrEmpty(orderType))
            {
                //default order type is 'ASC'
                orderType = defaultOrderTypeValue;
            }

            var data = await _repository.GetAllShapeAsync(orderBy, orderType, fields);

            // automap to ViewModel
            var viewModel = _mapper.Map<IEnumerable<GetDepartmentsViewModel>>(data);

            return viewModel;
        }
    }
}