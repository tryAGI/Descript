
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Descript
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Descript.Error400? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.Error401? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.Error402? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.Error403? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.Error404? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.Error429? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.SearchResponse? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.SearchResponseResultProjectSearchResult? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.SearchResponseResultProjectSearchResultType? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.SearchOwner? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.SearchResponseResultMediaSearchResult? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.SearchResponseResultMediaSearchResultType? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.SearchResponseResultMediaSearchResultLocation? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.SearchResponseResultMediaSearchResultMoment? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.SearchResponseResultLayoutPackSearchResult? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.SearchResponseResultLayoutPackSearchResultType? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.SearchResponseResultProjectFolderSearchResult? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.SearchResponseResultProjectFolderSearchResultType? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.SearchResponseResultMediaLibraryFolderSearchResult? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.SearchResponseResultMediaLibraryFolderSearchResultType? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.SearchResponseResultMediaLibraryFolderSearchResultLocation? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.EditInDescriptSchemaPostBody? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.EditInDescriptSchemaPostBodyProjectSchema? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Descript.EditInDescriptSchemaPostBodyProjectSchemaFile>? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.EditInDescriptSchemaPostBodyProjectSchemaFile? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.EditInDescriptSchemaPostBodyProjectSchemaFileStartOffset? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.EditInDescriptSchemaPostResponse? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishedProjectMetadata? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishedProjectMetadataPublishType? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishedProjectMetadataPrivacy? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishedProjectMetadataMetadata? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishedProjectMetadataMetadataPublishedBy? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishedProjectError? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishedProjectErrorError? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishedProjectPrivateError? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishedProjectPrivateErrorError? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishedProjectForbiddenError? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishedProjectForbiddenErrorError? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishedProjectConflictError? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishedProjectConflictErrorError? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishedProjectConflictErrorState? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportSuccessResult? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportSuccessResultStatus? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Descript.ImportSuccessResultMediaStatus2>? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportSuccessResultMediaStatus2? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportSuccessResultMediaStatusStatus? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Descript.ImportSuccessResultCreatedComposition>? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportSuccessResultCreatedComposition? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportErrorResult? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportErrorResultStatus? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportJobStatus? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportJobStatusJobType? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportJobStatusJobState? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportJobStatusProgress? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.Result? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportJobStatusResultDiscriminator? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportJobStatusResultDiscriminatorStatus? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.AgentSuccessResult? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.AgentSuccessResultStatus? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.AgentErrorResult? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.AgentErrorResultStatus? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.AgentJobStatus? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.AgentJobStatusJobType? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.AgentJobStatusJobState? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.AgentJobStatusProgress? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.Result2? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.AgentJobStatusResultDiscriminator? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.AgentJobStatusResultDiscriminatorStatus? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishSuccessResult? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishSuccessResultStatus? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishSuccessResultMediaType? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishErrorResult? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishErrorResultStatus? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishJobStatus? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishJobStatusJobType? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishJobStatusJobState? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishJobStatusProgress? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.Result3? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishJobStatusResultDiscriminator? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishJobStatusResultDiscriminatorStatus? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.JobStatus? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.JobStatusDiscriminator? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.JobStatusDiscriminatorJobType? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportProjectMediaRequest? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportProjectMediaRequestTeamAccess? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportProjectMediaRequestAddMediaUrlImport? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportProjectMediaRequestAddMediaDirectUpload? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportProjectMediaRequestAddMediaMultitrackSequence? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Descript.ImportProjectMediaRequestAddMediaMultitrackSequenceTrack>? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportProjectMediaRequestAddMediaMultitrackSequenceTrack? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Descript.ImportProjectMediaRequestAddComposition>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportProjectMediaRequestAddComposition? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Descript.ImportProjectMediaRequestAddCompositionClip>? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportProjectMediaRequestAddCompositionClip? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.AgentEditJobRequest? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.AgentEditJobRequestTeamAccess? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishJobRequest? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishJobRequestMediaType? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishJobRequestResolution? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishJobRequestAccessLevel? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ExportTranscriptRequest? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ExportTranscriptRequestFormat? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ExportTranscriptRequestIncludeSpeakerLabels? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ExportTranscriptRequestTimecodes? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ListJobsType? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ListProjectsSort? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ListProjectsDirection? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Descript.SearchTypeItem>? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.SearchTypeItem? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Descript.SearchMatchItem>? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.SearchMatchItem? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.SearchSort? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportProjectMediaResponse? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Descript.ImportProjectMediaResponseUploadUrls2>? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportProjectMediaResponseUploadUrls2? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.AgentEditJobResponse? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ListAgentModelsResponse? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Descript.ListAgentModelsResponseAvailableModel>? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ListAgentModelsResponseAvailableModel? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ListAgentModelsResponseAvailableModelCost? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Descript.ListAgentModelsResponseAliase>? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ListAgentModelsResponseAliase? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ListAgentModelsResponseAliaseCost? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishJobResponse? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ListJobsResponse? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Descript.JobStatus>? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ListJobsResponsePagination? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ListProjectsResponse? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Descript.ListProjectsResponseDataItem>? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ListProjectsResponseDataItem? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ListProjectsResponsePagination? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.GetProjectResponse? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Descript.GetProjectResponseMediaFiles2>? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.GetProjectResponseMediaFiles2? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.GetProjectResponseMediaFilesType? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Descript.GetProjectResponseComposition>? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.GetProjectResponseComposition? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Descript.GetProjectResponsePublishe>? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.GetProjectResponsePublishe? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.GetProjectResponsePublisheAccessLevel? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.GetProjectResponsePublisheMediaType? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.GetStatusResponse? Type150 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Descript.EditInDescriptSchemaPostBodyProjectSchemaFile>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Descript.ImportSuccessResultCreatedComposition>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Descript.ImportProjectMediaRequestAddMediaMultitrackSequenceTrack>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Descript.ImportProjectMediaRequestAddComposition>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Descript.ImportProjectMediaRequestAddCompositionClip>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Guid>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Descript.SearchTypeItem>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Descript.SearchMatchItem>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Descript.ListAgentModelsResponseAvailableModel>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Descript.ListAgentModelsResponseAliase>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Descript.JobStatus>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Descript.ListProjectsResponseDataItem>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Descript.GetProjectResponseComposition>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Descript.GetProjectResponsePublishe>? ListType13 { get; set; }
    }
}