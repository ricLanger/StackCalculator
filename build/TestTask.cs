using Cake.Common.Build;
using Cake.Common.Tools.DotNet;
using Cake.Common.Tools.DotNet.Test;
using Cake.Core;
using Cake.Core.IO;
using Cake.Core.IO.Arguments;
using Cake.Frosting;

namespace Build
{
    [TaskName("Test")]
    [IsDependentOn(typeof(BuildTask))]
    public sealed class TestTask : FrostingTask<BuildContext>
    {
        public override void Run(BuildContext context)
        {
            context.DotNetTest("./../Calculator.Test/Calculator.Test.csproj", new DotNetTestSettings
            {
                Configuration = context.Config,
                NoBuild = true,
                ArgumentCustomization = argument =>
                {
                    argument.Append(new TextArgument(" /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura"));
                    return argument;
                },
            });
            context.AzurePipelines().Commands.PublishTestResults(
                new Cake.Common.Build.AzurePipelines.Data.AzurePipelinesPublishTestResultsData
                {
                    TestResultsFiles = 
                })
        }
    }
}
