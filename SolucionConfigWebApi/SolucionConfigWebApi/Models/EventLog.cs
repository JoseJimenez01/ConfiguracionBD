using System;
using System.Collections.Generic;

namespace SolucionConfigWebApi.Models;

public partial class EventLog
{
    public int Id { get; set; }

    public string LogDescription { get; set; } = null!;

    public DateTime PostTime { get; set; }
}
