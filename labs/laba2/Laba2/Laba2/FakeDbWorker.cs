﻿using WinFormsApp.Services.Interfaces;

namespace WinFormsApp.Services.Implementations;

public class FakeDbWorker : IDbWorker
{
    public bool Authenticate(string login, string password)
    {
        return true;
    }

    public bool IsLoginAlreadyTaken(string login)
    {
        return false;
    }

    public void RegisterNewUser(string login, string password)
    {
        return;
    }
}