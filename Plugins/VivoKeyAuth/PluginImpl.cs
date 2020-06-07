using pGina.Shared.Types;
using System;

namespace pGina.Plugin.VivoKeyAuth
{
    public class PluginImpl : pGina.Shared.Interfaces.IPluginAuthentication
    {
        public string Name
        {
            get { return "VivoKeyAuth"; }
        }
        public string Description
        {
            get { return "Authenticates users with a VivoKey Apex cryptobionic implant."; }
        }
        private static readonly Guid m_uuid = new Guid("BE7A75A9-4734-45EF-AFCE-C188248D246E");

        public Guid Uuid
        {
            get { return m_uuid; }
        }

        public string Version
        {
            get
            {
                return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public void Starting() { }

        public void Stopping() { }


        public BooleanResult AuthenticateUser(SessionProperties properties)
        {
            return new BooleanResult() { Success = true };
        }

    }
}
