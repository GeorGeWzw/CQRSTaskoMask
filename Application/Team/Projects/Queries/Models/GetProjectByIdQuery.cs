﻿using TaskoMask.Application.Core.Dtos.Projects;
using TaskoMask.Application.Core.Queries;

namespace TaskoMask.Application.Team.Projects.Queries.Models
{
    public class GetProjectByIdQuery : BaseQuery<ProjectBasicInfoDto>
    {
        public GetProjectByIdQuery(string id)
        {
            Id = id;
        }

        public string Id { get; }
    }
}