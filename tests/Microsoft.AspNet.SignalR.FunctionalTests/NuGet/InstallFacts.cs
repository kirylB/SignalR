using System;
using System.IO;
using Microsoft.AspNet.SignalR.Tests.Common.Infrastructure;
using Xunit.Extensions;

namespace Microsoft.AspNet.SignalR.FunctionalTests.NuGet
{
    public class InstallFacts
    {
        private string NuGetExe
        {
            get
            {
                return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\..", @".nuget\NuGet.exe"));
            }
        }

        private void Run(string package, string name)
        {
            string paths = null;
            if (name == "TeamCityDev")
            {
                paths = @"\\wsr-teamcity\Drops\SignalR.Main.Signed.AllLanguages\latest-successful\Signed\Dev\packages;\\wsr-teamcity\drops\Katana.Dev.Signed\latest\Release;https://nuget.org/api/v2/";
            }
            else if (name == "TeamCityRelease")
            {
                paths = @"\\wsr-teamcity\Drops\SignalR.Main.Signed.AllLanguages\latest-successful\Signed\Release\packages;\\wsr-teamcity\drops\Katana.Release.Signed\latest-successful\Release;https://nuget.org/api/v2/";
            }
            else if (name == "aspnetwebstacknightly")
            {
                paths = @"http://myget.org/F/aspnetwebstacknightly/;https://nuget.org/api/v2/";
            }
            else if (name == "aspnetwebstacknightlyrelease")
            {
                paths = @"http://myget.org/F/aspnetwebstacknightlyrelease/;https://nuget.org/api/v2/";
            }
            else if (name == "Staging")
            {
                paths = @"http://staging.nuget.org/api/v2/;https://nuget.org/api/v2/";
            }
            else if (name == "Production")
            {
                paths = @"https://nuget.org/api/v2/";
            }

            if(Directory.Exists("packages"))
            {
                Directory.Delete("packages", recursive: true);
            }

            CommonCommandLine process = new CommonCommandLine();
            process.FileName = this.NuGetExe;
            process.Arguments = string.Format("install -Prerelease -NoCache -Source {0} -OutputDirectory packages {1}", paths, package);
            process.Run();
        }

        [Theory]
        [InlineData("TeamCityDev")]
        [InlineData("TeamCityRelease")]
        [InlineData("aspnetwebstacknightly")]
        [InlineData("aspnetwebstacknightlyrelease")]
        [InlineData("Staging")]
        [InlineData("Production")]
        public void SignalR(string name)
        {
            this.Run("Microsoft.AspNet.SignalR", name);
        }

        [Theory]
        [InlineData("TeamCityDev")]
        [InlineData("TeamCityRelease")]
        [InlineData("aspnetwebstacknightly")]
        [InlineData("aspnetwebstacknightlyrelease")]
        [InlineData("Staging")]
        [InlineData("Production")]
        public void SignalRClient(string name)
        {
            this.Run("Microsoft.AspNet.SignalR.Client", name);
        }

        [Theory]
        [InlineData("TeamCityDev")]
        [InlineData("TeamCityRelease")]
        [InlineData("aspnetwebstacknightly")]
        [InlineData("aspnetwebstacknightlyrelease")]
        [InlineData("Staging")]
        [InlineData("Production")]
        public void SignalRCore(string name)
        {
            this.Run("Microsoft.AspNet.SignalR.Core", name);
        }

        [Theory]
        [InlineData("TeamCityDev")]
        [InlineData("TeamCityRelease")]
        [InlineData("aspnetwebstacknightly")]
        [InlineData("aspnetwebstacknightlyrelease")]
        [InlineData("Staging")]
        [InlineData("Production")]
        public void SignalRi18n(string name)
        {
            this.Run("Microsoft.AspNet.SignalR.i18n", name);
        }

        [Theory]
        [InlineData("TeamCityDev")]
        [InlineData("TeamCityRelease")]
        [InlineData("aspnetwebstacknightly")]
        [InlineData("aspnetwebstacknightlyrelease")]
        [InlineData("Staging")]
        [InlineData("Production")]
        public void SignalRJS(string name)
        {
            this.Run("Microsoft.AspNet.SignalR.JS", name);
        }

        [Theory]
        [InlineData("TeamCityDev")]
        [InlineData("TeamCityRelease")]
        [InlineData("aspnetwebstacknightly")]
        [InlineData("aspnetwebstacknightlyrelease")]
        [InlineData("Staging")]
        [InlineData("Production")]
        public void SignalRRedis(string name)
        {
            this.Run("Microsoft.AspNet.SignalR.Redis", name);
        }

        [Theory]
        [InlineData("TeamCityDev")]
        [InlineData("TeamCityRelease")]
        [InlineData("aspnetwebstacknightly")]
        [InlineData("aspnetwebstacknightlyrelease")]
        [InlineData("Staging")]
        [InlineData("Production")]
        public void SignalRSample(string name)
        {
            this.Run("Microsoft.AspNet.SignalR.Sample", name);
        }

        [Theory]
        [InlineData("TeamCityDev")]
        [InlineData("TeamCityRelease")]
        [InlineData("aspnetwebstacknightly")]
        [InlineData("aspnetwebstacknightlyrelease")]
        [InlineData("Staging")]
        [InlineData("Production")]
        public void SignalRSelfHost(string name)
        {
            this.Run("Microsoft.AspNet.SignalR.SelfHost", name);
        }

        [Theory]
        [InlineData("TeamCityDev")]
        [InlineData("TeamCityRelease")]
        [InlineData("aspnetwebstacknightly")]
        [InlineData("aspnetwebstacknightlyrelease")]
        [InlineData("Staging")]
        [InlineData("Production")]
        public void SignalRServiceBus(string name)
        {
            this.Run("Microsoft.AspNet.SignalR.ServiceBus", name);
        }

        [Theory]
        [InlineData("TeamCityDev")]
        [InlineData("TeamCityRelease")]
        [InlineData("aspnetwebstacknightly")]
        [InlineData("aspnetwebstacknightlyrelease")]
        [InlineData("Staging")]
        [InlineData("Production")]
        public void SignalRSqlServer(string name)
        {
            this.Run("Microsoft.AspNet.SignalR.SqlServer", name);
        }

        [Theory]
        [InlineData("TeamCityDev")]
        [InlineData("TeamCityRelease")]
        [InlineData("aspnetwebstacknightly")]
        [InlineData("aspnetwebstacknightlyrelease")]
        [InlineData("Staging")]
        [InlineData("Production")]
        public void SignalRSystemWeb(string name)
        {
            this.Run("Microsoft.AspNet.SignalR.SystemWeb", name);
        }

        [Theory]
        [InlineData("TeamCityDev")]
        [InlineData("TeamCityRelease")]
        [InlineData("aspnetwebstacknightly")]
        [InlineData("aspnetwebstacknightlyrelease")]
        [InlineData("Staging")]
        [InlineData("Production")]
        public void SignalRUtils(string name)
        {
            this.Run("Microsoft.AspNet.SignalR.Utils", name);
        }
    }
}
