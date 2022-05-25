using Cake.Common.Tools.DotNet;
using Cake.Common.Tools.DotNet.Build;
using Cake.Frosting;

namespace Build
{
    [TaskName("Build")]
    [IsDependentOn(typeof(CleanTask))]
    [IsDependentOn(typeof(RestoreTask))]
    public sealed class BuildTask : FrostingTask<BuildContext>
    {
        public override void Run(BuildContext context)
        {
            context.DotNetBuild("./../Calculator.Konsole/Calculator.Konsole.csproj", new DotNetBuildSettings
            {
                Configuration = context.Config,
                Verbosity = DotNetVerbosity.Normal,
            });
        }
    }
}
