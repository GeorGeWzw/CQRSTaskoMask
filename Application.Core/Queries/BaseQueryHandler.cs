﻿using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TaskoMask.Domain.Core.Notifications;

namespace TaskoMask.Application.Core.Queries
{
    public abstract class BaseQueryHandler
    {
        #region Fields


        protected readonly IMediator _mediator;
        protected readonly IMapper _mapper;


        #endregion


        #region constructors


        protected BaseQueryHandler(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }


        #endregion


        #region Protected Methods


        protected Task PublishErrorAsync(string errorMessage, CancellationToken cancellationToken, string key = "")
        {
            return _mediator.Publish(new DomainNotification(key, errorMessage), cancellationToken);
        }


        #endregion
    }
}