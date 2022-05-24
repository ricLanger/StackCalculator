using System.Threading.Tasks;
using Cake.Core;
using Cake.Core.Diagnostics;
using Cake.Frosting;
using Cake.Common.IO;
using Cake.Common.Diagnostics;
using Cake.Common.Tools.DotNet;
using Cake.Common.Tools.DotNet.Build;
using Cake.Common.Tools.DotNet.Test;


public static class Program
{
    public static int Main(string[] args)
    {
        return new CakeHost()
            .UseContext<BuildContext>()
            .Run(args);
    }
}

public class BuildContext : FrostingContext
{
    public string Config { get; set; }

    public BuildContext(ICakeContext context)
        : base(context)
    {
        this.Config = context.Arguments.GetArgument("Configuration");
    }
}

[TaskName("Clean")]
public sealed class CleanTask : FrostingTask<BuildContext>
{
    public override void Run(BuildContext context)
    {
        context.Log.Information("Clean");
        context.CleanDirectories(".\\Test\\Calculator" + context.Config);
        context.CleanDirectories(".\\Test\\Calculator\\Claculator.Test\\TestResults" + context.Config);
    }
}

[TaskName("Build")]
[IsDependentOn(typeof(CleanTask))]
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

[TaskName("Test")]
[IsDependentOn(typeof(BuildTask))]
public sealed class TestClass : FrostingTask<BuildContext>
{
    public override void Run(BuildContext context)
    {
        context.DotNetTest("./../Calculator.Test/Calculator.Test.csproj", new DotNetTestSettings
        {
            Configuration = context.Config,
            NoBuild = true,
            ArgumentCustomization = args => args
            .Append("--collect").AppendQuoted("Code Coverage")
            .Append("--logger").Append("trx"),
        });
    }
}

[TaskName("Default")]
public class DefaultTask : FrostingTask
{
    public override void Run(ICakeContext context)
    {
        context.Information("Set the task to run with --target [task]");
    }
}