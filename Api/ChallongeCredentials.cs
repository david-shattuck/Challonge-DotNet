﻿namespace Challonge.Api
{
    public class ChallongeCredentials : IChallongeCredentials
    {
        public string Username { get; set; }
        public string ApiKey { get; set; }

        public ChallongeCredentials(string username, string apiKey)
        {
            Username = username;
            ApiKey = apiKey;
        }
    }
}
