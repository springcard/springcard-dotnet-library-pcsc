namespace SpringCard.PCSC.Enums
{
    /// <summary>
    /// Protocol parameter for <see cref="SCARD.Connect"/> and <see cref="SCARD.Status"/>.
    /// </summary>
    public enum ReaderProtocol : uint
    {
        ///<summary>No active protocol (no card, direct access to the reader).<br/>Same as SCARD_PROTOCOL_UNSET in winscard.</summary>
        None = SCARD.PROTOCOL_NONE,
        ///<summary>Protocol is T=0.<br/>Same as SCARD_PROTOCOL_T0 in winscard.</summary>
        T0 = SCARD.PROTOCOL_T0,
        ///<summary>Protocol is T=1.<br/>Same as SCARD_PROTOCOL_T1 in winscard.</summary>
        T1 = SCARD.PROTOCOL_T1,
        ///<summary>Protocol is RAW.<br/>Same as SCARD_PROTOCOL_RAW in winscard.</summary>
        Raw = SCARD.PROTOCOL_RAW
    }
}