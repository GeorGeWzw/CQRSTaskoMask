﻿using AutoMapper;
using TaskoMask.Application.Core.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TaskoMask.Application.Organizations.Commands.Models;
using TaskoMask.Application.Organizations.Queries.Models;
using TaskoMask.Application.Core.Dtos.Organizations;
using TaskoMask.Application.Core.Commands;
using TaskoMask.Domain.Data;
using TaskoMask.Application.Core.Services;
using TaskoMask.Application.BaseEntities.Services;
using TaskoMask.Domain.Entities;
using TaskoMask.Domain.Core.Notifications;

namespace TaskoMask.Application.Organizations.Services
{
    public class OrganizationService : BaseEntityService<Organization>, IOrganizationService
    {
        #region Fields

        #endregion

        #region Ctor

        public OrganizationService(IMediator mediator, IMapper mapper, INotificationHandler<DomainNotification> notifications) : base(mediator, mapper, notifications)
        { }

        #endregion

        #region Command Services



        public async Task<Result<CommandResult>> CreateAsync(OrganizationInputDto input)
        {
            var createCommand = _mapper.Map<CreateOrganizationCommand>(input);
            return await SendCommandAsync(createCommand);
        }



        public async Task<Result<CommandResult>> UpdateAsync(OrganizationInputDto input)
        {
            var updateCommand = _mapper.Map<UpdateOrganizationCommand>(input);
            return await SendCommandAsync(updateCommand);
        }


        #endregion

        #region Query Services

        public async Task<OrganizationOutputDto> GetByIdAsync(string id)
        {
            var query = new GetOrganizationByIdQuery(id);
            return await SendQueryAsync<GetOrganizationByIdQuery, OrganizationOutputDto>(query);
        }


        public async Task<OrganizationInputDto> GetByIdToUpdateAsync(string id)
        {
            var organization = await GetByIdAsync(id);
            return _mapper.Map<OrganizationInputDto>(organization);
        }


        public async Task<IEnumerable<OrganizationOutputDto>> GetListByUserIdAsync(string userId)
        {
            var query = new GetOrganizationsByUserIdQuery(userId: userId);
            return await SendQueryAsync<GetOrganizationsByUserIdQuery, IEnumerable<OrganizationOutputDto>>(query);
        }


        #endregion
    }
}