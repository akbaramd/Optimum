﻿namespace Optimum.Cqrs.Contracts.Commands;

public interface ICommandDispatcher
{
    Task SendAsync<T>(T command) where T : class, ICommand;
}