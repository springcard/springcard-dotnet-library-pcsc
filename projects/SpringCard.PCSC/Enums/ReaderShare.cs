namespace SpringCard.PCSC.Enums
{
    /// <summary>
    /// Share mode parameter for <see cref="SCARD.Connect"/>.
    /// </summary>
    public enum ReaderShare : uint
    {
        ///<summary>Take an exclusive access to the card.<br/>Same as SCARD_SHARE_EXCLUSIVE in winscard.</summary>
        Exclusive = SCARD.SHARE_EXCLUSIVE,
        ///<summary>Accept to share the access to the card.<br/>Same as SCARD_SHARE_SHARED in winscard.</summary>
        Shared = SCARD.SHARE_SHARED,
        ///<summary>Take a direct access to the reader (even if there is no card in the reader).<br/>Same as SCARD_SHARE_DIRECT in winscard.</summary>
        Direct = SCARD.SHARE_DIRECT
    }
}
