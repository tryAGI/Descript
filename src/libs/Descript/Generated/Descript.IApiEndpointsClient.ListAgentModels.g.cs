#nullable enable

namespace Descript
{
    public partial interface IApiEndpointsClient
    {
        /// <summary>
        /// List agent models<br/>
        /// List the currently available agent models and the aliases that resolve to them.<br/>
        /// The `model` parameter on [POST /jobs/agent](#operation/agentEditJob) accepts any<br/>
        /// value listed under `availableModels[].id` or `aliases[].id`. Aliases let you target<br/>
        /// the latest<br/>
        /// recommended model for a given tier without chasing version bumps — for example,<br/>
        /// passing `claude-opus` always routes to whichever Claude Opus version Descript<br/>
        /// currently recommends.<br/>
        /// Cost tiers are coarse buckets — `low`, `medium`, `high` — useful for showing<br/>
        /// users a relative price/performance signal. Exact pricing is reported per job via<br/>
        /// the `ai_credits_used` field on [GET /jobs/{job_id}](#operation/getJob).<br/>
        /// When `model` is omitted on `POST /jobs/agent`, the request defaults to `auto`, which<br/>
        /// selects a recommended model for your account. `auto` is a `medium`-cost option. For an<br/>
        /// `auto` request, `result.resolved_model` on [GET /jobs/{job_id}](#operation/getJob) reports<br/>
        /// `auto`; for an explicit model or alias it reports the canonical id that ran.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Descript.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Descript.ListAgentModelsResponse> ListAgentModelsAsync(
            global::Descript.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List agent models<br/>
        /// List the currently available agent models and the aliases that resolve to them.<br/>
        /// The `model` parameter on [POST /jobs/agent](#operation/agentEditJob) accepts any<br/>
        /// value listed under `availableModels[].id` or `aliases[].id`. Aliases let you target<br/>
        /// the latest<br/>
        /// recommended model for a given tier without chasing version bumps — for example,<br/>
        /// passing `claude-opus` always routes to whichever Claude Opus version Descript<br/>
        /// currently recommends.<br/>
        /// Cost tiers are coarse buckets — `low`, `medium`, `high` — useful for showing<br/>
        /// users a relative price/performance signal. Exact pricing is reported per job via<br/>
        /// the `ai_credits_used` field on [GET /jobs/{job_id}](#operation/getJob).<br/>
        /// When `model` is omitted on `POST /jobs/agent`, the request defaults to `auto`, which<br/>
        /// selects a recommended model for your account. `auto` is a `medium`-cost option. For an<br/>
        /// `auto` request, `result.resolved_model` on [GET /jobs/{job_id}](#operation/getJob) reports<br/>
        /// `auto`; for an explicit model or alias it reports the canonical id that ran.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Descript.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Descript.AutoSDKHttpResponse<global::Descript.ListAgentModelsResponse>> ListAgentModelsAsResponseAsync(
            global::Descript.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}