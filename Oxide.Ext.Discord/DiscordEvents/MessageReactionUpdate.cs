﻿namespace Oxide.Ext.Discord.DiscordEvents
{
    using Oxide.Ext.Discord.DiscordObjects;

    public class MessageReactionUpdate
    {
        public string user_id { get; set; }

        public string channel_id { get; set; }

        public string message_id { get; set; }

        public Emoji emoji { get; set; }
    }
}
