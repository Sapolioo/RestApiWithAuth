﻿using MediatR;

namespace RestApiWithAuth.Application.Users.Commands
{
    public record RegisterUserCommand(string Email, string Password, string FullName) : IRequest<Guid>;
}
