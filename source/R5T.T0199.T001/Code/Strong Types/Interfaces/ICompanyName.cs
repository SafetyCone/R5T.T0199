using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.N0003
{
    /// <summary>
    /// The name of a company.
    /// </summary>
    [StrongTypeMarker]
    public interface ICompanyName : IStrongTypeMarker,
        ITyped<string>
    {

    }
}
