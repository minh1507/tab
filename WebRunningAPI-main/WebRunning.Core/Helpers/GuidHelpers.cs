﻿using System;

namespace WebRunning.Core.Helpers
{
    public static class GuidHelpers
    {
        public static bool IsNullOrEmpty(this Guid? guid)
        {
            return guid == null || guid == Guid.Empty;
        }
    }
}
