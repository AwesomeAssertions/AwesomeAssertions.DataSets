using AwesomeAssertions.Extensibility;
using InitializeDataSetSupport = AwesomeAssertions.DataSets.Specs.InitializeDataSetSupport;

[assembly: AssertionEngineInitializer(
    typeof(InitializeDataSetSupport),
    nameof(InitializeDataSetSupport.Initialize))]

namespace AwesomeAssertions.DataSets.Specs;

public static class InitializeDataSetSupport
{
    // ReSharper disable once UnusedMember.Global
#pragma warning disable CA1822
    public static void Initialize()
#pragma warning restore CA1822
    {
        AssertionConfiguration.Current.Equivalency.Plan.AddDataSetSupport();
    }
}
