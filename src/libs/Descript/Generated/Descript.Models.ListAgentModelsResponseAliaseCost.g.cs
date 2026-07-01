
#nullable enable

namespace Descript
{
    /// <summary>
    /// Relative cost tier of the model this alias resolves to.<br/>
    /// Example: high
    /// </summary>
    public enum ListAgentModelsResponseAliaseCost
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListAgentModelsResponseAliaseCostExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAgentModelsResponseAliaseCost value)
        {
            return value switch
            {
                ListAgentModelsResponseAliaseCost.High => "high",
                ListAgentModelsResponseAliaseCost.Low => "low",
                ListAgentModelsResponseAliaseCost.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAgentModelsResponseAliaseCost? ToEnum(string value)
        {
            return value switch
            {
                "high" => ListAgentModelsResponseAliaseCost.High,
                "low" => ListAgentModelsResponseAliaseCost.Low,
                "medium" => ListAgentModelsResponseAliaseCost.Medium,
                _ => null,
            };
        }
    }
}