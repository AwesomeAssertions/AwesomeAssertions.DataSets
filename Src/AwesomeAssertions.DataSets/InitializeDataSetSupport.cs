using AwesomeAssertions;
using AwesomeAssertions.DataSets;
using AwesomeAssertions.Extensibility;

[assembly: CustomAssertionsAssembly]

[assembly: AssertionEngineInitializer(
    typeof(InitializeDataSetSupport),
    nameof(InitializeDataSetSupport.Initialize))]

namespace AwesomeAssertions.DataSets;

public static class InitializeDataSetSupport
{
    private static readonly object SyncObject = new();

    // ReSharper disable once UnusedMember.Global
#pragma warning disable CA1822
    public static void Initialize()
#pragma warning restore CA1822
    {
        lock (SyncObject)
        {
            AssertionConfiguration.Current.Equivalency.Plan.AddDataSetSupport();
        }
    }
}
