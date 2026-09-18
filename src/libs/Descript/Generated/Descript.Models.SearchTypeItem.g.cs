
#nullable enable

namespace Descript
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchTypeItem
    {
        /// <summary>
        ///
        /// </summary>
        Audio,
        /// <summary>
        ///
        /// </summary>
        Image,
        /// <summary>
        ///
        /// </summary>
        LayoutPack,
        /// <summary>
        ///
        /// </summary>
        MediaLibraryFolder,
        /// <summary>
        ///
        /// </summary>
        Project,
        /// <summary>
        ///
        /// </summary>
        ProjectFolder,
        /// <summary>
        ///
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchTypeItem value)
        {
            return value switch
            {
                SearchTypeItem.Audio => "audio",
                SearchTypeItem.Image => "image",
                SearchTypeItem.LayoutPack => "layout_pack",
                SearchTypeItem.MediaLibraryFolder => "media_library_folder",
                SearchTypeItem.Project => "project",
                SearchTypeItem.ProjectFolder => "project_folder",
                SearchTypeItem.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "audio" => SearchTypeItem.Audio,
                "image" => SearchTypeItem.Image,
                "layout_pack" => SearchTypeItem.LayoutPack,
                "media_library_folder" => SearchTypeItem.MediaLibraryFolder,
                "project" => SearchTypeItem.Project,
                "project_folder" => SearchTypeItem.ProjectFolder,
                "video" => SearchTypeItem.Video,
                _ => null,
            };
        }
    }
}