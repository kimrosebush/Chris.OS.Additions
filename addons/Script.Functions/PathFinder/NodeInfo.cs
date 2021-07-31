﻿using OpenMetaverse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chris.OS.Additions.Script.Functions.PathFinder
{
    class NodeInfo
    {
        public UUID ID = UUID.Zero;
        public String Name = null;
        public List<UUID> Connections = new List<UUID>();

        public Boolean AlreadyChecked = false;
        public NodeInfo ParentNode = null;
        public Boolean ConnectedToTarget = false;
    }
}
