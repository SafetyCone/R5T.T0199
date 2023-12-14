﻿using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.N0003
{
    /// <summary>
    /// Typed string for format strings, for use in <see cref="String.Format(string, object)"/>.
    /// (Example: "yyyyMMdd HHmmss" for "20230331 144120".)
    /// </summary>
    [StrongTypeMarker]
    public interface IFormat : IStrongTypeMarker,
        ITyped<string>
    {
    }
}
