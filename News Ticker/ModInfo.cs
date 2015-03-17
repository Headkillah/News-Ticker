using ICities;

namespace News_Ticker
{
    public class ModInfo : IUserMod
    {
        public string Description
        {
            get { return "Show messages from the SimCity 3000 News Ticker"; }
        }

        public string Name
        {
            get { return "SimCity 3000 News Ticker"; }
        }
    }
}
