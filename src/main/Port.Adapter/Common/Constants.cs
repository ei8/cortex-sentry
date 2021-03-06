﻿using System;

namespace ei8.Avatar.Port.Adapter.Common
{
    public struct EnvironmentVariableKeys
    {
        public const string ResourceDatabasePath = "RESOURCE_DATABASE_PATH";
        public const string AnonymousUserId = "ANONYMOUS_USER_ID";
        public const string ProxyUserId = "PROXY_USER_ID";
        public const string RequireAuthentication = "REQUIRE_AUTHENTICATION";
        public const string TokenIssuerAddress = "TOKEN_ISSUER_ADDRESS";
        public const string ApiSecret = "API_SECRET";
    }

    public struct LoggerProperties
    {
        public const string UserId = "UserId";
    }
}
