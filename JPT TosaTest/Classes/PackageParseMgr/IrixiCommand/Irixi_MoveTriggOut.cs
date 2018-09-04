﻿using Package;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPT_TosaTest.Classes.PackageParseMgr.IrixiCommand
{
    public class Irixi_MoveTriggOut : ZigBeePackage
    {
        protected override void WriteData()
        {
            writer.Write((byte)Enumcmd.MoveTrigOut);
            writer.Write(AxisNo);
            writer.Write(Distance);
            writer.Write(SpeedPercent);
            writer.Write(TriggerInterval);
        }

        public byte AxisNo { get; set; }
        public Int32 Distance { get; set; }
        public byte SpeedPercent { get; set; }
        public UInt16 TriggerInterval { get; set; }

    }
}
