﻿using System;


namespace x42Client.Utils.Logging
{
    public interface ILogProvider
    {
        void Trace(string message);
        void Trace(string message, Exception exception);
        void Debug(string message);
        void Debug(string message, Exception exception);
        void Info(string message);
        void Info(string message, Exception exception);
        void Warn(string message);
        void Warn(string message, Exception exception);
        void Error(string message);
        void Error(string message, Exception exception);
        void Fatal(string message);
        void Fatal(string message, Exception exception);
    }
}
