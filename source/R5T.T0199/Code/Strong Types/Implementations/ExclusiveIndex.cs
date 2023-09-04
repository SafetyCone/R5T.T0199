using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0199
{
    /// <inheritdoc cref="IExclusiveIndex"/>
    [StrongTypeImplementationMarker]
    public class ExclusiveIndex : TypedBase<int>, IStrongTypeMarker,
        IExclusiveIndex
    {
        public ExclusiveIndex(int value)
            : base(value)
        {
        }
    }
}