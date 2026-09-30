namespace SpringCard.PCSC.Enums
{
    /// <summary>
    /// Scope parameter for <see cref="SCARD.EstablishContext"/>.
    /// </summary>
    public enum ReaderScope : uint
    {
        ///<summary>Scope is User space.<br/>Same as SCARD_SCOPE_USER in winscard.</summary>
        User = SCARD.SCOPE_USER,
        ///<summary>Scope is the Terminal.<br/>Same as SCARD_SCOPE_TERMINAL in winscard.</summary>
        Terminal = SCARD.SCOPE_TERMINAL,
        ///<summary>Scope is System.<br/>Same as SCARD_SCOPE_SYSTEM in winscard.</summary>
        System = SCARD.SCOPE_SYSTEM
    }
}
