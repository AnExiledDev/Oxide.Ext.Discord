﻿namespace Oxide.Ext.Discord.DiscordObjects
{
    using System.Collections.Generic;

    public class Emoji
    {
        public List<Role> roles { get; set; }

        public bool? require_colons { get; set; }

        public string name { get; set; }

        public bool? managed { get; set; }

        public string id { get; set; }
    }
}
