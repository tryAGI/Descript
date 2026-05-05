
#nullable enable

namespace Descript
{
    public partial class ApiEndpointsClient
    {


        private static readonly global::Descript.EndPointSecurityRequirement s_PublishJobSecurityRequirement0 =
            new global::Descript.EndPointSecurityRequirement
            {
                Authorizations = new global::Descript.EndPointAuthorizationRequirement[]
                {                    new global::Descript.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Descript.EndPointSecurityRequirement[] s_PublishJobSecurityRequirements =
            new global::Descript.EndPointSecurityRequirement[]
            {                s_PublishJobSecurityRequirement0,
            };
        partial void PreparePublishJobArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Descript.PublishJobRequest request);
        partial void PreparePublishJobRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Descript.PublishJobRequest request);
        partial void ProcessPublishJobResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPublishJobResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Publish project media<br/>
        /// Publish a project composition to create a shareable link and download the exported file.<br/>
        /// Publishes a specific composition from a project, rendering the output as video or audio<br/>
        /// at the specified resolution. When the job completes successfully the result contains both:<br/>
        /// - `share_url`: a public URL that can be used to view the published content on Descript's share site.<br/>
        /// - `download_url`: a time-limited signed URL to download the exported media file directly,<br/>
        ///   along with `download_url_expires_at` indicating when the link expires.<br/>
        /// ### Republishing<br/>
        /// Publishing the same composition a second time automatically reuses the previous share URL,<br/>
        /// overwriting its content — so bookmarks and links handed out for the first publish keep working.<br/>
        /// Republish matching is keyed on `(project_id, composition_id, media_type)`, so a Video publish<br/>
        /// and an Audio publish of the same composition produce two separate share URLs.<br/>
        /// ### Async Operations<br/>
        /// Publish jobs run in the background and return a `job_id`. Monitor progress via the [GET /jobs/{job_id}](#operation/getJob) endpoint,<br/>
        /// which returns the `share_url`, `download_url`, and `download_url_expires_at` fields once the job finishes.<br/>
        /// ### Dynamic webhook<br/>
        /// If `callback_url` is provided, Descript will POST the job status to that URL when the job completes or fails.<br/>
        /// The payload will match the format returned by [GET /jobs/{job_id}](#operation/getJob).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Descript.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Descript.PublishJobResponse> PublishJobAsync(

            global::Descript.PublishJobRequest request,
            global::Descript.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await PublishJobAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Publish project media<br/>
        /// Publish a project composition to create a shareable link and download the exported file.<br/>
        /// Publishes a specific composition from a project, rendering the output as video or audio<br/>
        /// at the specified resolution. When the job completes successfully the result contains both:<br/>
        /// - `share_url`: a public URL that can be used to view the published content on Descript's share site.<br/>
        /// - `download_url`: a time-limited signed URL to download the exported media file directly,<br/>
        ///   along with `download_url_expires_at` indicating when the link expires.<br/>
        /// ### Republishing<br/>
        /// Publishing the same composition a second time automatically reuses the previous share URL,<br/>
        /// overwriting its content — so bookmarks and links handed out for the first publish keep working.<br/>
        /// Republish matching is keyed on `(project_id, composition_id, media_type)`, so a Video publish<br/>
        /// and an Audio publish of the same composition produce two separate share URLs.<br/>
        /// ### Async Operations<br/>
        /// Publish jobs run in the background and return a `job_id`. Monitor progress via the [GET /jobs/{job_id}](#operation/getJob) endpoint,<br/>
        /// which returns the `share_url`, `download_url`, and `download_url_expires_at` fields once the job finishes.<br/>
        /// ### Dynamic webhook<br/>
        /// If `callback_url` is provided, Descript will POST the job status to that URL when the job completes or fails.<br/>
        /// The payload will match the format returned by [GET /jobs/{job_id}](#operation/getJob).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Descript.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Descript.AutoSDKHttpResponse<global::Descript.PublishJobResponse>> PublishJobAsResponseAsync(

            global::Descript.PublishJobRequest request,
            global::Descript.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePublishJobArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Descript.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_PublishJobSecurityRequirements,
                operationName: "PublishJobAsync");

            using var __timeoutCancellationTokenSource = global::Descript.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Descript.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Descript.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Descript.PathBuilder(
                                path: "/jobs/publish",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Descript.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::Descript.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PreparePublishJobRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Descript.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Descript.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PublishJob",
                                methodName: "PublishJobAsync",
                                pathTemplate: "\"/jobs/publish\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Descript.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Descript.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Descript.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PublishJob",
                                methodName: "PublishJobAsync",
                                pathTemplate: "\"/jobs/publish\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Descript.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Descript.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Descript.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Descript.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Descript.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PublishJob",
                                methodName: "PublishJobAsync",
                                pathTemplate: "\"/jobs/publish\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Descript.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessPublishJobResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Descript.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Descript.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PublishJob",
                                methodName: "PublishJobAsync",
                                pathTemplate: "\"/jobs/publish\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Descript.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Descript.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PublishJob",
                                methodName: "PublishJobAsync",
                                pathTemplate: "\"/jobs/publish\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Invalid input: - Malformed request body - Invalid project_id or composition_id format - Invalid media_type or resolution value 
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::Descript.Error400? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::Descript.Error400.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::Descript.Error400.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }

                                throw new global::Descript.ApiException<global::Descript.Error400>(
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_400,
                                    ResponseObject = __value_400,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // Unauthorized - missing or invalid authentication token
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::Descript.Error401? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::Descript.Error401.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::Descript.Error401.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }

                                throw new global::Descript.ApiException<global::Descript.Error401>(
                                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_401,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_401,
                                    ResponseObject = __value_401,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // Forbidden: - User doesn't have write access to the project - Project doesn't belong to the token's drive - Requested `access_level` is not permitted by the drive's publish settings 
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                global::Descript.Error403? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = global::Descript.Error403.FromJson(__content_403, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = global::Descript.Error403.FromJson(__content_403, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }

                                throw new global::Descript.ApiException<global::Descript.Error403>(
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_403,
                                    ResponseObject = __value_403,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // 
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }

                                throw new global::Descript.ApiException(
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_422,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // Too many requests - rate limit exceeded. Use the `Retry-After` header to determine when to retry. 
                            if ((int)__response.StatusCode == 429)
                            {
                                string? __content_429 = null;
                                global::System.Exception? __exception_429 = null;
                                global::Descript.Error429? __value_429 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_429 = global::Descript.Error429.FromJson(__content_429, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_429 = global::Descript.Error429.FromJson(__content_429, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_429 = __ex;
                                }

                                throw new global::Descript.ApiException<global::Descript.Error429>(
                                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_429,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_429,
                                    ResponseObject = __value_429,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessPublishJobResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Descript.PublishJobResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Descript.AutoSDKHttpResponse<global::Descript.PublishJobResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Descript.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw new global::Descript.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Descript.PublishJobResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Descript.AutoSDKHttpResponse<global::Descript.PublishJobResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Descript.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw new global::Descript.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Publish project media<br/>
        /// Publish a project composition to create a shareable link and download the exported file.<br/>
        /// Publishes a specific composition from a project, rendering the output as video or audio<br/>
        /// at the specified resolution. When the job completes successfully the result contains both:<br/>
        /// - `share_url`: a public URL that can be used to view the published content on Descript's share site.<br/>
        /// - `download_url`: a time-limited signed URL to download the exported media file directly,<br/>
        ///   along with `download_url_expires_at` indicating when the link expires.<br/>
        /// ### Republishing<br/>
        /// Publishing the same composition a second time automatically reuses the previous share URL,<br/>
        /// overwriting its content — so bookmarks and links handed out for the first publish keep working.<br/>
        /// Republish matching is keyed on `(project_id, composition_id, media_type)`, so a Video publish<br/>
        /// and an Audio publish of the same composition produce two separate share URLs.<br/>
        /// ### Async Operations<br/>
        /// Publish jobs run in the background and return a `job_id`. Monitor progress via the [GET /jobs/{job_id}](#operation/getJob) endpoint,<br/>
        /// which returns the `share_url`, `download_url`, and `download_url_expires_at` fields once the job finishes.<br/>
        /// ### Dynamic webhook<br/>
        /// If `callback_url` is provided, Descript will POST the job status to that URL when the job completes or fails.<br/>
        /// The payload will match the format returned by [GET /jobs/{job_id}](#operation/getJob).
        /// </summary>
        /// <param name="projectId">
        /// The ID of the project to publish.<br/>
        /// Example: 9f36ee32-5a2c-47e7-b1a3-94991d3e3ddb
        /// </param>
        /// <param name="compositionId">
        /// The ID of the composition within the project to publish.<br/>
        /// Example: 39677a40-1c43-4c36-8449-46cfbc4de2b5
        /// </param>
        /// <param name="mediaType">
        /// Media type of the published output.<br/>
        /// Default Value: Video
        /// </param>
        /// <param name="resolution">
        /// Resolution for the published output. Only applicable when media_type is Video.
        /// </param>
        /// <param name="callbackUrl">
        /// Optional webhook URL to call when the job completes or fails.<br/>
        /// Descript will POST the job status (same format as [GET /jobs/{job_id}](#operation/getJob)) to this URL.<br/>
        /// Example: https://example.com/webhooks/descript/job_callback
        /// </param>
        /// <param name="accessLevel">
        /// Desired access level for the published share page.<br/>
        /// If omitted, the drive's configured default is used.<br/>
        /// Returns 403 if the requested level is not permitted by the drive's publish settings<br/>
        /// (e.g. requesting `public` when search engine indexing is disabled).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Descript.PublishJobResponse> PublishJobAsync(
            global::System.Guid projectId,
            global::System.Guid? compositionId = default,
            global::Descript.PublishJobRequestMediaType? mediaType = default,
            global::Descript.PublishJobRequestResolution? resolution = default,
            string? callbackUrl = default,
            global::Descript.PublishJobRequestAccessLevel? accessLevel = default,
            global::Descript.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Descript.PublishJobRequest
            {
                ProjectId = projectId,
                CompositionId = compositionId,
                MediaType = mediaType,
                Resolution = resolution,
                CallbackUrl = callbackUrl,
                AccessLevel = accessLevel,
            };

            return await PublishJobAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}