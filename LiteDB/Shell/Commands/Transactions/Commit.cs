﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace LiteDB.Shell.Commands
{
    internal class Commit : ICommand
    {
        public bool IsCommand(StringScanner s)
        {
            return s.Scan(@"commit(\s+trans)?$").Length > 0;
        }

        public void Execute(ref LiteEngine db, StringScanner s, Display display)
        {
            if (db == null) throw new ArgumentException("No database");

            db.Commit();
        }
    }
}
