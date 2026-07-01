
#nullable enable

namespace Descript
{
    /// <summary>
    /// Relative cost tier for this model.<br/>
    /// Example: high
    /// </summary>
    public enum ListAgentModelsResponseAvailableModelCost
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
    public static class ListAgentModelsResponseAvailableModelCostExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAgentModelsResponseAvailableModelCost value)
        {
            return value switch
            {
                ListAgentModelsResponseAvailableModelCost.High => "high",
                ListAgentModelsResponseAvailableModelCost.Low => "low",
                ListAgentModelsResponseAvailableModelCost.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAgentModelsResponseAvailableModelCost? ToEnum(string value)
        {
            return value switch
            {
                "high" => ListAgentModelsResponseAvailableModelCost.High,
                "low" => ListAgentModelsResponseAvailableModelCost.Low,
                "medium" => ListAgentModelsResponseAvailableModelCost.Medium,
                _ => null,
            };
        }
    }
}