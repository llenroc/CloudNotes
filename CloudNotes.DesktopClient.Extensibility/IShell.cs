﻿using CloudNotes.DesktopClient.Extensibility.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudNotes.DesktopClient.Extensibility
{
    /// <summary>
    /// Represents that the implemented classes are CloudNotes Desktop Client Shell.
    /// </summary>
    public interface IShell
    {
        Task AddNoteAsync(Note note);
    }
}