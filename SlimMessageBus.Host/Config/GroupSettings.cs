﻿using System.Collections.Generic;

namespace SlimMessageBus.Host.Config
{
    public class GroupSettings
    {
        public string GroupId { get; set; }
        public IList<ConsumerSettings> SubscriberSettings { get; set; }
    }
}