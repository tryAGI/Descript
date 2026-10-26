
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
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

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
        public global::Descript.MediaUrlReference? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.MediaUploadReference? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.DriveMediaImportRequest? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.OneOf<global::Descript.MediaUrlReference, global::Descript.MediaUploadReference>? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.DriveMediaImportResponse? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Descript.DriveMediaImportResponseUploadUrls2>? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.DriveMediaImportResponseUploadUrls2? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportSuccessResult? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportSuccessResultStatus? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Descript.ImportSuccessResultMediaStatus2>? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportSuccessResultMediaStatus2? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportSuccessResultMediaStatusStatus? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Descript.ImportSuccessResultCreatedComposition>? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportSuccessResultCreatedComposition? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportErrorResult? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportErrorResultStatus? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportJobStatus? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportJobStatusJobType? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportJobStatusJobState? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportJobStatusProgress? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.Result? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportJobStatusResultDiscriminator? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportJobStatusResultDiscriminatorStatus? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.DriveMediaImportJobStatus? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.DriveMediaImportJobStatusJobType? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.DriveMediaImportJobStatusJobState? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.DriveMediaImportJobStatusProgress? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.OneOf<global::Descript.DriveMediaImportJobStatusResultVariant1, global::Descript.DriveMediaImportJobStatusResultVariant2>? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.DriveMediaImportJobStatusResultVariant1? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.DriveMediaImportJobStatusResultVariant1Status? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Descript.DriveMediaImportJobStatusResultVariant1MediaStatus2>? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.DriveMediaImportJobStatusResultVariant1MediaStatus2? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.DriveMediaImportJobStatusResultVariant1MediaStatusStatus? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.DriveMediaImportJobStatusResultVariant2? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.DriveMediaImportJobStatusResultVariant2Status? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.AgentSuccessResult? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.AgentSuccessResultStatus? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.AgentErrorResult? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.AgentErrorResultStatus? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.AgentJobStatus? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.AgentJobStatusJobType? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.AgentJobStatusJobState? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.AgentJobStatusProgress? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.Result3? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.AgentJobStatusResultDiscriminator? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.AgentJobStatusResultDiscriminatorStatus? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishSuccessResult? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishSuccessResultStatus? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishSuccessResultMediaType? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishErrorResult? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishErrorResultStatus? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishJobStatus? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishJobStatusJobType? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishJobStatusJobState? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishJobStatusProgress? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.Result4? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishJobStatusResultDiscriminator? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishJobStatusResultDiscriminatorStatus? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.JobStatus? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.JobStatusDiscriminator? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.JobStatusDiscriminatorJobType? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportProjectMediaRequest? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportProjectMediaRequestTeamAccess? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportProjectMediaRequestAddMediaUrlImport? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportProjectMediaRequestAddMediaDirectUpload? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportProjectMediaRequestAddMediaMultitrackSequence? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Descript.ImportProjectMediaRequestAddMediaMultitrackSequenceTrack>? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportProjectMediaRequestAddMediaMultitrackSequenceTrack? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Descript.ImportProjectMediaRequestAddComposition>? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportProjectMediaRequestAddComposition? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Descript.ImportProjectMediaRequestAddCompositionClip>? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportProjectMediaRequestAddCompositionClip? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.AgentEditJobRequest? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.AgentEditJobRequestTeamAccess? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishJobRequest? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishJobRequestMediaType? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishJobRequestResolution? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishJobRequestAccessLevel? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ExportTranscriptRequest? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ExportTranscriptRequestFormat? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ExportTranscriptRequestIncludeSpeakerLabels? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ExportTranscriptRequestTimecodes? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ListJobsType? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ListProjectsSort? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ListProjectsDirection? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Descript.SearchTypeItem>? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.SearchTypeItem? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Descript.SearchMatchItem>? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.SearchMatchItem? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.SearchSort? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportProjectMediaResponse? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Descript.ImportProjectMediaResponseUploadUrls2>? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportProjectMediaResponseUploadUrls2? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.AgentEditJobResponse? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ListAgentModelsResponse? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Descript.ListAgentModelsResponseAvailableModel>? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ListAgentModelsResponseAvailableModel? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ListAgentModelsResponseAvailableModelCost? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Descript.ListAgentModelsResponseAliase>? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ListAgentModelsResponseAliase? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ListAgentModelsResponseAliaseCost? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishJobResponse? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ListJobsResponse? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Descript.JobStatus>? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ListJobsResponsePagination? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ListProjectsResponse? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Descript.ListProjectsResponseDataItem>? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ListProjectsResponseDataItem? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ListProjectsResponsePagination? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.GetProjectResponse? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Descript.GetProjectResponseMediaFiles2>? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.GetProjectResponseMediaFiles2? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.GetProjectResponseMediaFilesType? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Descript.GetProjectResponseComposition>? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.GetProjectResponseComposition? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Descript.GetProjectResponsePublishe>? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.GetProjectResponsePublishe? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.GetProjectResponsePublisheAccessLevel? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.GetProjectResponsePublisheMediaType? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Descript.GetStatusResponse? Type171 { get; set; }

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