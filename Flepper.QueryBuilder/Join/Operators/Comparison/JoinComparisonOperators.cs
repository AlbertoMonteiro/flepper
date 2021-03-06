﻿using System.Collections.Generic;
using System.Text;
using Flepper.QueryBuilder.Base;

namespace Flepper.QueryBuilder
{
    internal class JoinComparisonOperators : BaseQueryBuilder, IJoinComparisonOperators
    {
        public JoinComparisonOperators(StringBuilder command, IDictionary<string, object> parameters) : base(command, parameters)
        {
        }

        public IJoinComparisonOperators Equal(string tableAlias, string column)
        {
            Command.AppendFormat("= {0}.[{1}] ", tableAlias, column);
            return this;
        }

        public IJoinComparisonOperators NotEqual(string tableAlias, string column)
        {
            Command.AppendFormat("<> {0}.[{1}] ", tableAlias, column);
            return this;
        }
    }
}
