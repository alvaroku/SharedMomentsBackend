﻿using System.Linq.Expressions;

namespace SharedMomentsBackend.App.Extensions
{

    public static class ExpressionExtensions
    {
        public static Expression<Func<T, bool>> And<T>(
            this Expression<Func<T, bool>> first,
            Expression<Func<T, bool>> second)
        {
            var parameter = Expression.Parameter(typeof(T), "x");

            var body = Expression.AndAlso(
                Expression.Invoke(first, parameter),
                Expression.Invoke(second, parameter));

            return Expression.Lambda<Func<T, bool>>(body, parameter);
        }
    }
}
