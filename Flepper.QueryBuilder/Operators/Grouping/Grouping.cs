﻿using Flepper.QueryBuilder.Base;
using Flepper.QueryBuilder.Operators.Grouping.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace Flepper.QueryBuilder.Operators.Grouping
{
    internal class Grouping : BaseQueryBuilder, IGrouping
    {

        public Grouping(StringBuilder command, IDictionary<string, object> parameters) : base(command, parameters)
        {

        }

        /// <summary>
        /// Group select statement by column
        /// </summary>
        /// <param name="column">grouped column</param>
        /// <returns></returns>
        public IGrouping GroupBy(string column)
        {
            Command.AppendFormat("GROUP BY [{0}]", column);
            return this;
        }
    }
}
