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

[TaskName("Default")]
public class DefaultTask : FrostingTask
{
    public override void Run(ICakeContext context)
    {
        context.Information("Set the task to run with --target [task]");
    }
}