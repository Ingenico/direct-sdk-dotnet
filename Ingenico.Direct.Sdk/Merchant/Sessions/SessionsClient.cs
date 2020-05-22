/*
 * This class was auto-generated from the API references found at
 * https://support.direct.ingenico.com/documentation/api/reference/index.html
 */
using Ingenico.Direct.Sdk.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ingenico.Direct.Sdk.Merchant.Sessions
{
    /// <summary>
    /// Sessions client. Thread-safe.
    /// </summary>
    public class SessionsClient : ApiResource, ISessionsClient
    {
        public SessionsClient(ApiResource parent, IDictionary<string, string> pathContext) :
            base(parent, pathContext)
        {
        }

        /// <summary>
        /// Resource /v2/{merchantId}/sessions
        /// - <a href="https://support.direct.ingenico.com/documentation/api/reference/index.html#operation/CreateSessionApi">Create session</a>
        /// </summary>
        /// <param name="body">SessionRequest</param>
        /// <param name="context">CallContext</param>
        /// <returns>SessionResponse</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="DirectException">if something went wrong at the Ingenico ePayments platform,
        ///            the Ingenico ePayments platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the Ingenico ePayments platform returned any other error</exception>
        public async Task<SessionResponse> CreateSession(SessionRequest body, CallContext context = null)
        {
            string uri = InstantiateUri("/v2/{merchantId}/sessions", null);
            try
            {
                return await _communicator.Post<SessionResponse>(
                        uri,
                        ClientHeaders,
                        null,
                        body,
                        context)
                    .ConfigureAwait(false);
            }
            catch (ResponseException e)
            {
                object errorObject = _communicator.Unmarshal<ErrorResponse>(e.Body);
                throw CreateException(e.StatusCode, e.Body, errorObject, context);
            }
        }
    }
}
