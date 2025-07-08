using Domain.Messages;
using Domain.Models;

namespace Application.IPublishers;

public interface IMessagePublisher
{
    Task PublishCreatedUserMessageAsync(Guid id, string names, string surnames, string email, PeriodDateTime periodDateTime);
    Task SendCreatedUserFromCollabMessageAsync(Guid CorrelationId, string InstanceId, Guid userId, Guid collaboratorId, string names, string surnames, string email, PeriodDateTime periodDateTime);

}
