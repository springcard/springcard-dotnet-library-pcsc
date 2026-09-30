using System.Collections.Generic;

namespace SpringCard.PCSC.UI.Controls.ReaderSelect;

public class ReaderSelectParams
{
    public string? LastReaderName { get; set; }
    public bool CanRemember { get; set; }
    public string? PreselectReaderName { get; set; }
    public IEnumerable<string> ReadersToIgnore { get; set; } = [];
}
