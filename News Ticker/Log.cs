namespace News_Ticker
{
    public static class Log
    {
        public static void AddMessage(string message)
        {
            DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Message, message);
        }

        public static void AddError(string error)
        {
            error = "[News Ticker] " + error;
            DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Error, error);
        }
    }
}
