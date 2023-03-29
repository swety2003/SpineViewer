using MyWidgets.SDK;
using MyWidgets.SDK.Core.Card;
using MyWidgets.SDK.Core.SideBar;
using SpineViewer.View;
using System;
using System.Collections.Generic;

namespace SpineViewer
{
    public class PluginInfo : IPlugin
    {
        public string name => "Spine�鿴��";

        public Version version => new Version();

        public string url => "";

        public string author => "SwetyCore";

        public IEnumerable<object> GetAllTypeInfo()
        {
            return new List<CardInfo>
            {
                SpinePlayer.info,
            };
        }
    }
}
