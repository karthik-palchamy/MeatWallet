using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.Specifications
{
    public class BaseSpecification<T> : ISpecification<T>
    {
        public BaseSpecification()
        {
         
        }
        //Func<T, bool>---> represents a function that takes an object of type T and returns a bool.
        // It's commonly referred to as a "predicate",  and is used to verify a condition on an object.
        public BaseSpecification(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
        }

        public Expression<Func<T, bool>> Criteria { get; }

        public List<Expression<Func<T, object>>> Includes {get; } = new List<Expression<Func<T, object>>>();
        protected void AddInclude(Expression<Func<T, object>> includeExpression){
            Includes.Add(includeExpression);
        }
    }
}
