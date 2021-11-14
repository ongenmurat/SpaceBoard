﻿using System;

namespace SpaceBoard.Core.Exceptions
{
    /// <summary>
    /// Represents the expcetion type of point validation exception
    /// </summary>
    public class PointValidationException : Exception
    {
        public PointValidationException(string message) : base(message)
        {
        }
    }
}
