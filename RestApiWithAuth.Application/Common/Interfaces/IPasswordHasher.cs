﻿namespace RestApiWithAuth.Application.Common.Interfaces
{
    public interface IPasswordHasher
    {
        public string Hash(string password);
    }
}
