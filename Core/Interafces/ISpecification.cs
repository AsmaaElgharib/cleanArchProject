using System;
using System.Linq.Expressions;

namespace Core.Interafces;

public interface ISpecification<T>
{
    // Specification interface for filtering and sorting entities
    Expression<Func<T, bool>>? Criteria { get;}
    Expression<Func<T, object>>? OrderBy { get; }
    Expression<Func<T, object>>? OrderByDescending { get; }
    bool IsDistinct { get; }
}

public interface ISpecification<T, TResult> : ISpecification<T>
{
    Expression<Func<T, TResult>>? Select { get; }
}
