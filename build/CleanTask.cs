using Cake.Common.IO;
using Cake.Common.Tools.DotNet;
using Cake.Core.Diagnostics;
using Cake.Frosting;

namespace Build
{
    [TaskName("Clean")]
    public sealed class CleanTask : FrostingTask<BuildContext>
    {
        public override void Run(BuildContext context)
        {
            context.Log.Information("Clean");
            context.CleanDirectories("../**/Calculator.Test/TestResults" + context.Config);
            context.CleanDirectories("../**/Claculator.Konsole/bin" + context.Config);

        }
    }

    [TaskName("Restore")]
    [IsDependentOn(typeof(CleanTask))]
    public sealed class RestoreTask : FrostingTask<BuildContext>
    {
        public override void Run(BuildContext context)
        {
            context.DotNetRestore();
        }
    }
}
