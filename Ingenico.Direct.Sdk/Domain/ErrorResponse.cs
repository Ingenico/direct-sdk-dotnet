/*
 * This class was auto-generated from the API references found at
 * https://support.direct.ingenico.com/documentation/api/reference/index.html
 */
using System.Collections.Generic;

namespace Ingenico.Direct.Sdk.Domain
{
    public class ErrorResponse
    {
        public string ErrorId { get; set; } = null;

        public IList<APIError> Errors { get; set; } = null;
    }
}
