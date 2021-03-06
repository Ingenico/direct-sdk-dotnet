/*
 * This class was auto-generated from the API references found at
 * https://support.direct.ingenico.com/documentation/api/reference
 */
namespace Ingenico.Direct.Sdk.Domain
{
    public class MobilePaymentMethodSpecificOutput
    {
        /// <summary>
        /// Card Authorization code as returned by the acquirer<para />
        /// </summary>
        public string AuthorisationCode { get; set; } = null;

        /// <summary>
        /// Fraud results contained in the CardFraudResults object<para />
        /// </summary>
        public CardFraudResults FraudResults { get; set; } = null;

        /// <summary>
        /// Deprecated: This field is not used by any payment product<para />
        /// </summary>
        public string Network { get; set; } = null;

        /// <summary>
        /// Object containing payment details<para />
        /// </summary>
        public MobilePaymentData PaymentData { get; set; } = null;

        /// <summary>
        /// Payment product identifier - Please see [payment products](https://support.direct.ingenico.com/documentation/api/reference/index.html#tag/Products) for a full overview of possible values.<para />
        /// </summary>
        public int? PaymentProductId { get; set; } = null;

        /// <summary>
        /// 3D Secure results object<para />
        /// </summary>
        public ThreeDSecureResults ThreeDSecureResults { get; set; } = null;
    }
}
