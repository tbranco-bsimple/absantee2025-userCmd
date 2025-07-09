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
        var userDto = new UserDTO(msg.Names, msg.Surnames, msg.Email, msg.DeactivationDate);
        await _userService.Add(userDto);
    }
}
