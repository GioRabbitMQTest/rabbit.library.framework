using MediatR;

namespace rabbit.framework.CQRS;
public interface IQueryHandler<in TQuery, TResponse>
: IRequestHandler<TQuery, TResponse>
  where TQuery : IQuery<TResponse>
  where TResponse : notnull
{
}