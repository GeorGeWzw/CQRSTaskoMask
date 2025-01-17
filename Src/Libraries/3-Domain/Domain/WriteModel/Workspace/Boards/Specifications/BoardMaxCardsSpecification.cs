﻿using System.Linq;
using TaskoMask.Domain.Core.Specifications;
using TaskoMask.Domain.Share.Helpers;
using TaskoMask.Domain.WriteModel.Workspace.Boards.Entities;

namespace TaskoMask.Domain.WriteModel.Workspace.Boards.Specifications
{
    internal class BoardMaxCardsSpecification : ISpecification<Board>
    {

        /// <summary>
        /// 
        /// </summary>
        public bool IsSatisfiedBy(Board board)
        {
            return board.Cards.Count <= DomainConstValues.Board_Max_Card_Count;
        }
    }
}
