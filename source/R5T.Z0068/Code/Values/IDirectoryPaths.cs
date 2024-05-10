using System;

using R5T.T0131;


namespace R5T.Z0068
{
    /// <summary>
    /// Raw, system-typed directory path values.
    /// </summary>
    /// <remarks>
    /// Note: directory paths should end with a directory path separator character ('\' for Windows, or '/' for non-Windows).
    /// </remarks>
    [ValuesMarker]
    public partial interface IDirectoryPaths : IValuesMarker
    {
        
    }
}
