using Application.DTO;
using Domain.Commands;
using MassTransit;

public class CreateUserFromCollaboratorConsumer : IConsumer<CreateUserFromCollaboratorCommand>
{
    private readonly IUserService _userService;

    public CreateUserFromCollaboratorConsumer(IUserService userService)
    {
        _userService = userService;
    }
    public async Task Consume(ConsumeContext<CreateUserFromCollaboratorCommand> context)
    {
        var msg = context.Message;
        Console.WriteLine("[DEBUG] CreateUserFromCollaboratorConsumer : " + msg.CorrelationId);
        var userDto = new UserFromCollabDTO(msg.Names, msg.Surnames, msg.Email, msg.DeactivationDate);
        await _userService.AddFromCollab(userDto, msg.Id, msg.CorrelationId, msg.InstanceId);
    }
}
