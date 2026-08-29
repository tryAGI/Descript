
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Descript
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Descript.JsonConverters.PublishedProjectMetadataPublishTypeJsonConverter),

            typeof(global::Descript.JsonConverters.PublishedProjectMetadataPublishTypeNullableJsonConverter),

            typeof(global::Descript.JsonConverters.PublishedProjectMetadataPrivacyJsonConverter),

            typeof(global::Descript.JsonConverters.PublishedProjectMetadataPrivacyNullableJsonConverter),

            typeof(global::Descript.JsonConverters.PublishedProjectErrorErrorJsonConverter),

            typeof(global::Descript.JsonConverters.PublishedProjectErrorErrorNullableJsonConverter),

            typeof(global::Descript.JsonConverters.PublishedProjectPrivateErrorErrorJsonConverter),

            typeof(global::Descript.JsonConverters.PublishedProjectPrivateErrorErrorNullableJsonConverter),

            typeof(global::Descript.JsonConverters.PublishedProjectForbiddenErrorErrorJsonConverter),

            typeof(global::Descript.JsonConverters.PublishedProjectForbiddenErrorErrorNullableJsonConverter),

            typeof(global::Descript.JsonConverters.PublishedProjectConflictErrorErrorJsonConverter),

            typeof(global::Descript.JsonConverters.PublishedProjectConflictErrorErrorNullableJsonConverter),

            typeof(global::Descript.JsonConverters.PublishedProjectConflictErrorStateJsonConverter),

            typeof(global::Descript.JsonConverters.PublishedProjectConflictErrorStateNullableJsonConverter),

            typeof(global::Descript.JsonConverters.ImportSuccessResultStatusJsonConverter),

            typeof(global::Descript.JsonConverters.ImportSuccessResultStatusNullableJsonConverter),

            typeof(global::Descript.JsonConverters.ImportSuccessResultMediaStatusStatusJsonConverter),

            typeof(global::Descript.JsonConverters.ImportSuccessResultMediaStatusStatusNullableJsonConverter),

            typeof(global::Descript.JsonConverters.ImportErrorResultStatusJsonConverter),

            typeof(global::Descript.JsonConverters.ImportErrorResultStatusNullableJsonConverter),

            typeof(global::Descript.JsonConverters.ImportJobStatusJobTypeJsonConverter),

            typeof(global::Descript.JsonConverters.ImportJobStatusJobTypeNullableJsonConverter),

            typeof(global::Descript.JsonConverters.ImportJobStatusJobStateJsonConverter),

            typeof(global::Descript.JsonConverters.ImportJobStatusJobStateNullableJsonConverter),

            typeof(global::Descript.JsonConverters.ImportJobStatusResultDiscriminatorStatusJsonConverter),

            typeof(global::Descript.JsonConverters.ImportJobStatusResultDiscriminatorStatusNullableJsonConverter),

            typeof(global::Descript.JsonConverters.AgentSuccessResultStatusJsonConverter),

            typeof(global::Descript.JsonConverters.AgentSuccessResultStatusNullableJsonConverter),

            typeof(global::Descript.JsonConverters.AgentErrorResultStatusJsonConverter),

            typeof(global::Descript.JsonConverters.AgentErrorResultStatusNullableJsonConverter),

            typeof(global::Descript.JsonConverters.AgentJobStatusJobTypeJsonConverter),

            typeof(global::Descript.JsonConverters.AgentJobStatusJobTypeNullableJsonConverter),

            typeof(global::Descript.JsonConverters.AgentJobStatusJobStateJsonConverter),

            typeof(global::Descript.JsonConverters.AgentJobStatusJobStateNullableJsonConverter),

            typeof(global::Descript.JsonConverters.AgentJobStatusResultDiscriminatorStatusJsonConverter),

            typeof(global::Descript.JsonConverters.AgentJobStatusResultDiscriminatorStatusNullableJsonConverter),

            typeof(global::Descript.JsonConverters.PublishSuccessResultStatusJsonConverter),

            typeof(global::Descript.JsonConverters.PublishSuccessResultStatusNullableJsonConverter),

            typeof(global::Descript.JsonConverters.PublishSuccessResultMediaTypeJsonConverter),

            typeof(global::Descript.JsonConverters.PublishSuccessResultMediaTypeNullableJsonConverter),

            typeof(global::Descript.JsonConverters.PublishErrorResultStatusJsonConverter),

            typeof(global::Descript.JsonConverters.PublishErrorResultStatusNullableJsonConverter),

            typeof(global::Descript.JsonConverters.PublishJobStatusJobTypeJsonConverter),

            typeof(global::Descript.JsonConverters.PublishJobStatusJobTypeNullableJsonConverter),

            typeof(global::Descript.JsonConverters.PublishJobStatusJobStateJsonConverter),

            typeof(global::Descript.JsonConverters.PublishJobStatusJobStateNullableJsonConverter),

            typeof(global::Descript.JsonConverters.PublishJobStatusResultDiscriminatorStatusJsonConverter),

            typeof(global::Descript.JsonConverters.PublishJobStatusResultDiscriminatorStatusNullableJsonConverter),

            typeof(global::Descript.JsonConverters.JobStatusDiscriminatorJobTypeJsonConverter),

            typeof(global::Descript.JsonConverters.JobStatusDiscriminatorJobTypeNullableJsonConverter),

            typeof(global::Descript.JsonConverters.ImportProjectMediaRequestTeamAccessJsonConverter),

            typeof(global::Descript.JsonConverters.ImportProjectMediaRequestTeamAccessNullableJsonConverter),

            typeof(global::Descript.JsonConverters.AgentEditJobRequestTeamAccessJsonConverter),

            typeof(global::Descript.JsonConverters.AgentEditJobRequestTeamAccessNullableJsonConverter),

            typeof(global::Descript.JsonConverters.PublishJobRequestMediaTypeJsonConverter),

            typeof(global::Descript.JsonConverters.PublishJobRequestMediaTypeNullableJsonConverter),

            typeof(global::Descript.JsonConverters.PublishJobRequestResolutionJsonConverter),

            typeof(global::Descript.JsonConverters.PublishJobRequestResolutionNullableJsonConverter),

            typeof(global::Descript.JsonConverters.PublishJobRequestAccessLevelJsonConverter),

            typeof(global::Descript.JsonConverters.PublishJobRequestAccessLevelNullableJsonConverter),

            typeof(global::Descript.JsonConverters.ExportTranscriptRequestFormatJsonConverter),

            typeof(global::Descript.JsonConverters.ExportTranscriptRequestFormatNullableJsonConverter),

            typeof(global::Descript.JsonConverters.ExportTranscriptRequestIncludeSpeakerLabelsJsonConverter),

            typeof(global::Descript.JsonConverters.ExportTranscriptRequestIncludeSpeakerLabelsNullableJsonConverter),

            typeof(global::Descript.JsonConverters.ListJobsTypeJsonConverter),

            typeof(global::Descript.JsonConverters.ListJobsTypeNullableJsonConverter),

            typeof(global::Descript.JsonConverters.ListProjectsSortJsonConverter),

            typeof(global::Descript.JsonConverters.ListProjectsSortNullableJsonConverter),

            typeof(global::Descript.JsonConverters.ListProjectsDirectionJsonConverter),

            typeof(global::Descript.JsonConverters.ListProjectsDirectionNullableJsonConverter),

            typeof(global::Descript.JsonConverters.ListAgentModelsResponseAvailableModelCostJsonConverter),

            typeof(global::Descript.JsonConverters.ListAgentModelsResponseAvailableModelCostNullableJsonConverter),

            typeof(global::Descript.JsonConverters.ListAgentModelsResponseAliaseCostJsonConverter),

            typeof(global::Descript.JsonConverters.ListAgentModelsResponseAliaseCostNullableJsonConverter),

            typeof(global::Descript.JsonConverters.GetProjectResponseMediaFilesTypeJsonConverter),

            typeof(global::Descript.JsonConverters.GetProjectResponseMediaFilesTypeNullableJsonConverter),

            typeof(global::Descript.JsonConverters.GetProjectResponsePublisheAccessLevelJsonConverter),

            typeof(global::Descript.JsonConverters.GetProjectResponsePublisheAccessLevelNullableJsonConverter),

            typeof(global::Descript.JsonConverters.GetProjectResponsePublisheMediaTypeJsonConverter),

            typeof(global::Descript.JsonConverters.GetProjectResponsePublisheMediaTypeNullableJsonConverter),

            typeof(global::Descript.JsonConverters.ResultJsonConverter),

            typeof(global::Descript.JsonConverters.Result2JsonConverter),

            typeof(global::Descript.JsonConverters.Result3JsonConverter),

            typeof(global::Descript.JsonConverters.JobStatusJsonConverter),

            typeof(global::Descript.JsonConverters.OneOfJsonConverter<global::Descript.ImportProjectMediaRequestAddMediaUrlImport, global::Descript.ImportProjectMediaRequestAddMediaDirectUpload, global::Descript.ImportProjectMediaRequestAddMediaMultitrackSequence>),

            typeof(global::Descript.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.Error400))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.Error401))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.Error402))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.Error403))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.Error404))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.Error429))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.EditInDescriptSchemaPostBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.EditInDescriptSchemaPostBodyProjectSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Descript.EditInDescriptSchemaPostBodyProjectSchemaFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.EditInDescriptSchemaPostBodyProjectSchemaFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.EditInDescriptSchemaPostBodyProjectSchemaFileStartOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.EditInDescriptSchemaPostResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectMetadataPublishType), TypeInfoPropertyName = "PublishedProjectMetadataPublishType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectMetadataPrivacy), TypeInfoPropertyName = "PublishedProjectMetadataPrivacy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectMetadataMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectMetadataMetadataPublishedBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectErrorError), TypeInfoPropertyName = "PublishedProjectErrorError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectPrivateError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectPrivateErrorError), TypeInfoPropertyName = "PublishedProjectPrivateErrorError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectForbiddenError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectForbiddenErrorError), TypeInfoPropertyName = "PublishedProjectForbiddenErrorError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectConflictError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectConflictErrorError), TypeInfoPropertyName = "PublishedProjectConflictErrorError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishedProjectConflictErrorState), TypeInfoPropertyName = "PublishedProjectConflictErrorState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ImportSuccessResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ImportSuccessResultStatus), TypeInfoPropertyName = "ImportSuccessResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Descript.ImportSuccessResultMediaStatus2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ImportSuccessResultMediaStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ImportSuccessResultMediaStatusStatus), TypeInfoPropertyName = "ImportSuccessResultMediaStatusStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Descript.ImportSuccessResultCreatedComposition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ImportSuccessResultCreatedComposition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ImportErrorResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ImportErrorResultStatus), TypeInfoPropertyName = "ImportErrorResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ImportJobStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ImportJobStatusJobType), TypeInfoPropertyName = "ImportJobStatusJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ImportJobStatusJobState), TypeInfoPropertyName = "ImportJobStatusJobState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ImportJobStatusProgress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.Result), TypeInfoPropertyName = "Result2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ImportJobStatusResultDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ImportJobStatusResultDiscriminatorStatus), TypeInfoPropertyName = "ImportJobStatusResultDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.AgentSuccessResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.AgentSuccessResultStatus), TypeInfoPropertyName = "AgentSuccessResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.AgentErrorResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.AgentErrorResultStatus), TypeInfoPropertyName = "AgentErrorResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.AgentJobStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.AgentJobStatusJobType), TypeInfoPropertyName = "AgentJobStatusJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.AgentJobStatusJobState), TypeInfoPropertyName = "AgentJobStatusJobState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.AgentJobStatusProgress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.Result2), TypeInfoPropertyName = "Result22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.AgentJobStatusResultDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.AgentJobStatusResultDiscriminatorStatus), TypeInfoPropertyName = "AgentJobStatusResultDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishSuccessResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishSuccessResultStatus), TypeInfoPropertyName = "PublishSuccessResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishSuccessResultMediaType), TypeInfoPropertyName = "PublishSuccessResultMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishErrorResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishErrorResultStatus), TypeInfoPropertyName = "PublishErrorResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishJobStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishJobStatusJobType), TypeInfoPropertyName = "PublishJobStatusJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishJobStatusJobState), TypeInfoPropertyName = "PublishJobStatusJobState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishJobStatusProgress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.Result3), TypeInfoPropertyName = "Result32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishJobStatusResultDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishJobStatusResultDiscriminatorStatus), TypeInfoPropertyName = "PublishJobStatusResultDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.JobStatus), TypeInfoPropertyName = "JobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.JobStatusDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.JobStatusDiscriminatorJobType), TypeInfoPropertyName = "JobStatusDiscriminatorJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ImportProjectMediaRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ImportProjectMediaRequestTeamAccess), TypeInfoPropertyName = "ImportProjectMediaRequestTeamAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Descript.OneOf<global::Descript.ImportProjectMediaRequestAddMediaUrlImport, global::Descript.ImportProjectMediaRequestAddMediaDirectUpload, global::Descript.ImportProjectMediaRequestAddMediaMultitrackSequence>>), TypeInfoPropertyName = "ImportProjectMediaRequestAddMediaMultitrackSequence_be431db9011ff791")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.OneOf<global::Descript.ImportProjectMediaRequestAddMediaUrlImport, global::Descript.ImportProjectMediaRequestAddMediaDirectUpload, global::Descript.ImportProjectMediaRequestAddMediaMultitrackSequence>), TypeInfoPropertyName = "ImportProjectMediaRequestAddMediaMultitrackSequence_dc92f0bae16ba1fc")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ImportProjectMediaRequestAddMediaUrlImport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ImportProjectMediaRequestAddMediaDirectUpload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ImportProjectMediaRequestAddMediaMultitrackSequence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Descript.ImportProjectMediaRequestAddMediaMultitrackSequenceTrack>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ImportProjectMediaRequestAddMediaMultitrackSequenceTrack))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Descript.ImportProjectMediaRequestAddComposition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ImportProjectMediaRequestAddComposition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Descript.ImportProjectMediaRequestAddCompositionClip>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ImportProjectMediaRequestAddCompositionClip))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.AgentEditJobRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.AgentEditJobRequestTeamAccess), TypeInfoPropertyName = "AgentEditJobRequestTeamAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishJobRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishJobRequestMediaType), TypeInfoPropertyName = "PublishJobRequestMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishJobRequestResolution), TypeInfoPropertyName = "PublishJobRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishJobRequestAccessLevel), TypeInfoPropertyName = "PublishJobRequestAccessLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ExportTranscriptRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ExportTranscriptRequestFormat), TypeInfoPropertyName = "ExportTranscriptRequestFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ExportTranscriptRequestIncludeSpeakerLabels), TypeInfoPropertyName = "ExportTranscriptRequestIncludeSpeakerLabels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ExportTranscriptRequestTimecodes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ListJobsType), TypeInfoPropertyName = "ListJobsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ListProjectsSort), TypeInfoPropertyName = "ListProjectsSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ListProjectsDirection), TypeInfoPropertyName = "ListProjectsDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ImportProjectMediaResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Descript.ImportProjectMediaResponseUploadUrls2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ImportProjectMediaResponseUploadUrls2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.AgentEditJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ListAgentModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Descript.ListAgentModelsResponseAvailableModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ListAgentModelsResponseAvailableModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ListAgentModelsResponseAvailableModelCost), TypeInfoPropertyName = "ListAgentModelsResponseAvailableModelCost2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Descript.ListAgentModelsResponseAliase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ListAgentModelsResponseAliase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ListAgentModelsResponseAliaseCost), TypeInfoPropertyName = "ListAgentModelsResponseAliaseCost2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.PublishJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ListJobsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Descript.JobStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ListJobsResponsePagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ListProjectsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Descript.ListProjectsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ListProjectsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.ListProjectsResponsePagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.GetProjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Descript.GetProjectResponseMediaFiles2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.GetProjectResponseMediaFiles2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.GetProjectResponseMediaFilesType), TypeInfoPropertyName = "GetProjectResponseMediaFilesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Descript.GetProjectResponseComposition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.GetProjectResponseComposition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Descript.GetProjectResponsePublishe>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.GetProjectResponsePublishe))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.GetProjectResponsePublisheAccessLevel), TypeInfoPropertyName = "GetProjectResponsePublisheAccessLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.GetProjectResponsePublisheMediaType), TypeInfoPropertyName = "GetProjectResponsePublisheMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.GetStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Descript.OneOf<global::Descript.ImportProjectMediaRequestAddMediaUrlImport, global::Descript.ImportProjectMediaRequestAddMediaDirectUpload, global::Descript.ImportProjectMediaRequestAddMediaMultitrackSequence>?), TypeInfoPropertyName = "ImportProjectMediaRequestAddMediaMultitrackSequence_a84f7d44496d84a5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Descript.EditInDescriptSchemaPostBodyProjectSchemaFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Descript.ImportSuccessResultCreatedComposition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Descript.ImportProjectMediaRequestAddMediaMultitrackSequenceTrack>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Descript.ImportProjectMediaRequestAddComposition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Descript.ImportProjectMediaRequestAddCompositionClip>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Descript.ListAgentModelsResponseAvailableModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Descript.ListAgentModelsResponseAliase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Descript.JobStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Descript.ListProjectsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Descript.GetProjectResponseComposition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Descript.GetProjectResponsePublishe>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}