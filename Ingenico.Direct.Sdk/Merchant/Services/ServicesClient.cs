/*
 * This class was auto-generated from the API references found at
 * https://support.direct.ingenico.com/documentation/api/reference
 */
using Ingenico.Direct.Sdk.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ingenico.Direct.Sdk.Merchant.Services
{
    /// <inheritdoc/>
    public class ServicesClient : ApiResource, IServicesClient
    {
        public ServicesClient(ApiResource parent, IDictionary<string, string> pathContext) :
            base(parent, pathContext)
        {
        }

        /// <inheritdoc/>
        public async Task<TestConnection> TestConnection(CallContext context = null)
        {
            string uri = InstantiateUri("/v2/{merchantId}/services/testconnection", null);
            try
            {
                return await _communicator.Get<TestConnection>(
                        uri,
                        ClientHeaders,
                        null,
                        context)
                    .ConfigureAwait(false);
            }
            catch (ResponseException e)
            {
                object errorObject = _communicator.Unmarshal<ErrorResponse>(e.Body);
                throw CreateException(e.StatusCode, e.Body, errorObject, context);
            }
        }

        /// <inheritdoc/>
        public async Task<GetIINDetailsResponse> GetIINDetails(GetIINDetailsRequest body, CallContext context = null)
        {
            string uri = InstantiateUri("/v2/{merchantId}/services/getIINdetails", null);
            try
            {
                return await _communicator.Post<GetIINDetailsResponse>(
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
