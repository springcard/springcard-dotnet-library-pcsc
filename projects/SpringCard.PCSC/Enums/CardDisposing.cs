namespace SpringCard.PCSC.Enums;

/// <summary>
/// Disposition parameter for <see cref="SCARD.Disconnect"/> and <see cref="SCARD.Reconnect"/>.
/// </summary>
public enum CardDisposing : uint
{
    ///<summary>Leave the card as is.<br/>Same as SCARD_LEAVE_CARD in winscard.</summary>
    Leave = SCARD.LEAVE_CARD,
    ///<summary>Warm reset the card.<br/>Same as SCARD_RESET_CARD in winscard.</summary>
    Reset = SCARD.RESET_CARD,
    ///<summary>Power down the card.<br/>Same as SCARD_UNPOWER_CARD in winscard.</summary>
    Unpower = SCARD.UNPOWER_CARD,
    ///<summary>Power down the card and eject it in case of a motorized reader.<br/>Same as SCARD_EJECT_CARD in winscard.</summary>
    Eject = SCARD.EJECT_CARD
}
