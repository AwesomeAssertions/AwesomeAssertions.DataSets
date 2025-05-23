using System.Globalization;
using AwesomeAssertions.Equivalency;

namespace AwesomeAssertions.DataSets.Common;

internal static class EquivalencyValidationContextExtensions
{
    public static IEquivalencyValidationContext AsCollectionItem<TItem>(this IEquivalencyValidationContext context, int index) =>
        context.AsCollectionItem<TItem>(index.ToString(CultureInfo.InvariantCulture));
}
