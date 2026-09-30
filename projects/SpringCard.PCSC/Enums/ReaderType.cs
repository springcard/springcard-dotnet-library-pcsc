using System;

namespace SpringCard.PCSC.Enums
{
    /// <summary>
    /// Groups parameter for <see cref="SCARD.ListReaders"/>.
    /// </summary>
    public static class ReaderType
    {
        ///<summary>List all readers.<br/>Same as SCARD_ALL_READERS in winscard.</summary>
        public const string ALL_READERS = SCARD.ALL_READERS;
        ///<summary>List the readers that are not in a specific group.<br/>Same as SCARD_DEFAULT_READERS in winscard</summary>
        public const string DEFAULT_READERS = SCARD.DEFAULT_READERS;
        ///<summary>List local readers (deprecated and unused).<br/>Same as SCARD_LOCAL_READERS in winscard</summary>
        [Obsolete("This constant is deprecated and unused.")]
        public const string LOCAL_READERS = SCARD.LOCAL_READERS;
        ///<summary>List system readers (deprecated and unused).<br/>Same as SCARD_SYSTEM_READERS in winscard</summary>
        [Obsolete("This constant is deprecated and unused.")]
        public const string SYSTEM_READERS = SCARD.SYSTEM_READERS;
    }
}
