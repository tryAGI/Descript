#nullable enable

namespace Descript
{
    public partial interface IApiEndpointsClient
    {
        /// <summary>
        /// Cancel job<br/>
        /// Cancel a running job.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Descript.ApiException"></exception>
        global::System.Threading.Tasks.Task CancelJobAsync(
            global::System.Guid jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}