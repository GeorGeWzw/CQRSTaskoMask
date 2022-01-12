﻿using TaskoMask.Application.Share.Dtos.Workspace.Members;
using TaskoMask.Application.Share.Helpers;
using TaskoMask.Application.Core.Queries;

namespace TaskoMask.Application.Workspace.Members.Queries.Models
{
   public class SearchMembersQuery:BaseQuery<PaginatedListReturnType<MemberOutputDto>>
    {
        public SearchMembersQuery(int page, int recordsPerPage, string term)
        {
            Page = page;
            RecordsPerPage = recordsPerPage;
            Term = term;
        }

        public int Page { get;}
        public int RecordsPerPage { get; }
        public string Term { get; }
    }
}