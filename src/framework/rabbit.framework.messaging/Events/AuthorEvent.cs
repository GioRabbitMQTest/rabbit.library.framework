namespace rabbit.framework.messaging.Events;
public record AuthorEvent : IntegrationEvent
{
  public string FirtName { get; set; }
  public string LastName { get; set; }
  public string PhoneNumber { get; set; }
  public string Email { get; set; }
  public bool IsActive { get; set; }
}