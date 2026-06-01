#nullable enable

namespace Descript
{
    public partial interface IApiEndpointsClient
    {
        /// <summary>
        /// Export project transcript<br/>
        /// Export the transcript from a project composition.<br/>
        /// Supports plain text, Markdown, HTML, RTF, and DOCX formats.<br/>
        /// Options include speaker labels, timecodes, and markers.<br/>
        /// The response body is the raw transcript file (binary for `docx`,<br/>
        /// text otherwise) with a `Content-Disposition: attachment` header and<br/>
        /// an `X-Composition-Id` header identifying the exported composition.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Descript.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ExportTranscriptAsync(

            global::Descript.ExportTranscriptRequest request,
            global::Descript.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export project transcript<br/>
        /// Export the transcript from a project composition.<br/>
        /// Supports plain text, Markdown, HTML, RTF, and DOCX formats.<br/>
        /// Options include speaker labels, timecodes, and markers.<br/>
        /// The response body is the raw transcript file (binary for `docx`,<br/>
        /// text otherwise) with a `Content-Disposition: attachment` header and<br/>
        /// an `X-Composition-Id` header identifying the exported composition.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Descript.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Descript.AutoSDKHttpResponse<string>> ExportTranscriptAsResponseAsync(

            global::Descript.ExportTranscriptRequest request,
            global::Descript.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export project transcript<br/>
        /// Export the transcript from a project composition.<br/>
        /// Supports plain text, Markdown, HTML, RTF, and DOCX formats.<br/>
        /// Options include speaker labels, timecodes, and markers.<br/>
        /// The response body is the raw transcript file (binary for `docx`,<br/>
        /// text otherwise) with a `Content-Disposition: attachment` header and<br/>
        /// an `X-Composition-Id` header identifying the exported composition.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the project to export from.<br/>
        /// Example: 9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb
        /// </param>
        /// <param name="compositionId">
        /// The ID of the composition to export. Defaults to the first composition.<br/>
        /// Example: 39677a40-1c43-4c36-8449-46cfbc4de2b5
        /// </param>
        /// <param name="format">
        /// Transcript file format. For `docx`, the response `content` field<br/>
        /// contains the base64-encoded binary file.
        /// </param>
        /// <param name="includeSpeakerLabels">
        /// Speaker label mode.<br/>
        /// - `off`: No speaker labels<br/>
        /// - `changes`: Show speaker label when the speaker changes<br/>
        /// - `every_paragraph`: Show speaker label on every paragraph<br/>
        /// Default Value: changes
        /// </param>
        /// <param name="includeMarkers">
        /// Include markers in the transcript.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="timecodes">
        /// Timecode options. When provided, timecodes are included in<br/>
        /// the output.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ExportTranscriptAsync(
            global::System.Guid projectId,
            global::Descript.ExportTranscriptRequestFormat format,
            global::System.Guid? compositionId = default,
            global::Descript.ExportTranscriptRequestIncludeSpeakerLabels? includeSpeakerLabels = default,
            bool? includeMarkers = default,
            global::Descript.ExportTranscriptRequestTimecodes? timecodes = default,
            global::Descript.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}