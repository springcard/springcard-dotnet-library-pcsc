using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpringCard.PCSC.UI.Controls.ReaderSelect;

public class ReaderSelectConfiguration
{
    public bool IsRememberChecked { get; set; } = false;
    public string? SelectedReader { get; set; }
}
