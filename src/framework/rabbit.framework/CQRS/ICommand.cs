using MediatR; 

namespace rabbit.framework.CQRS;
public interface ICommand : IRequest<Unit>
{
}

public interface ICommand<out TResponse> : IRequest<TResponse> { }