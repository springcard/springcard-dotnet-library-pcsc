using System;

namespace SpringCard.PCSC.Enums
{
    /// <summary>
    /// State flags for ReaderState in <see cref="SCARD.GetStatusChange"/>.
    /// </summary>
    [Flags]
    public enum ReaderState : uint
    {
        ///<summary>No flag set.<br/></br>Same as SCARD_STATE_UNAWARE in winscard</summary>
        Unaware = SCARD.STATE_UNAWARE,
        ///<summary>No information required.<br/></br>Same as SCARD_STATE_IGNORE in winscard</summary>
        Ignore = SCARD.STATE_IGNORE,
        ///<summary>The reader's state has changed since the last call.<br/></br>Same as SCARD_STATE_CHANGED in winscard</summary>
        Changed = SCARD.STATE_CHANGED,
        ///<summary>The reader does not exist.<br/></br>Same as SCARD_STATE_UNKNOWN in winscard</summary>
        Unknown = SCARD.STATE_UNKNOWN,
        ///<summary>The reader's state is not available.<br/></br>Same as SCARD_STATE_UNAVAILABLE in winscard</summary>
        Unavailable = SCARD.STATE_UNAVAILABLE,
        ///<summary>There is no card in the reader.<br/></br>Same as SCARD_STATE_EMPTY in winscard</summary>
        Empty = SCARD.STATE_EMPTY,
        ///<summary>There is a card in the reader.<br/></br>Same as SCARD_STATE_PRESENT in winscard</summary>
        Present = SCARD.STATE_PRESENT,
        AtrMatch = SCARD.STATE_ATRMATCH,
        ///<summary>The card in the reader is reserved for exclusive use by an application.<br/></br>Same as SCARD_STATE_EXCLUSIVE in winscard</summary>
        Exclusive = SCARD.STATE_EXCLUSIVE,
        ///<summary>The card in the reader is connected by an application.<br/></br>Same as SCARD_STATE_INUSE in winscard</summary>
        InUse = SCARD.STATE_INUSE,
        ///<summary>The card in the reader is unresponsive.<br/></br>Same as SCARD_STATE_MUTE in winscard</summary>
        Mute = SCARD.STATE_MUTE,
        ///<summary>The card in the reader has been powered down.<br/></br>Same as SCARD_STATE_UNPOWERED in winscard</summary>
        Unpowered = SCARD.STATE_UNPOWERED
    }
}
