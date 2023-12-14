﻿using System;

using R5T.T0178;


namespace R5T.N0003
{
    /// <summary>
    /// Typed string for <see cref="DateTime"/> format strings.
    /// (Example: "yyyyMMdd HHmmss" for "20230331 144120".)
    /// </summary>
    [StrongTypeMarker]
    public interface IFormattedDateTime : IStrongTypeMarker,
        IFormatted
    {
    }
}
