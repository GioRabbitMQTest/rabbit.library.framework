using MediatR;

namespace rabbit.framework.CQRS;
public interface IQuery<out TResponse>
: IRequest<TResponse>
where TResponse : notnull
{
}