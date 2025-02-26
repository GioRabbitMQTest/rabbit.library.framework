namespace rabbit.framework.messaging.Events;
public record IntegrationEvent
{
  public Guid Id => Guid.NewGuid();
  public DateTime OcurrendOn => DateTime.Now;
  public string EventType => GetType().AssemblyQualifiedName;
}