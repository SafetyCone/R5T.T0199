using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.N0003
{
    /// <inheritdoc cref="ICompanyName"/>
    [StrongTypeImplementationMarker]
    public sealed class CompanyName : TypedBase<string>, IStrongTypeMarker,
        ICompanyName
    {
        public CompanyName(string value)
            : base(value)
        {
        }
    }
}
