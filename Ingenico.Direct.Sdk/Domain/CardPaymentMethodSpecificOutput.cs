/*
 * This class was auto-generated from the API references found at
 * https://support.direct.ingenico.com/documentation/api/reference
 */
namespace Ingenico.Direct.Sdk.Domain
{
    public class CardPaymentMethodSpecificOutput
    {
        /// <summary>
        /// Card Authorization code as returned by the acquirer<para />
        /// </summary>
        public string AuthorisationCode { get; set; } = null;

        /// <summary>
        /// Object containing card details<para />
        /// </summary>
        public CardEssentials Card { get; set; } = null;

        /// <summary>
        /// Fraud results contained in the CardFraudResults object<para />
        /// </summary>
        public CardFraudResults FraudResults { get; set; } = null;

        /// <summary>
        /// The unique scheme transactionId of the initial transaction that was performed with SCA. In case this is unknown a scheme transactionId of an earlier transaction part of the same sequence can be used as a fall-back. Strongly advised to be submitted for any MerchantInitiated or recurring transaction (a subsequent one).<para />
        /// </summary>
        public string InitialSchemeTransactionId { get; set; } = null;

        /// <summary>
        /// The specific payment option for the payment. To be used as a complement of the more generic paymentProductId (oney, banquecasino, cofidis), which allows to define a variation of the selected paymentProductId (ex: facilypay3x, banquecasino4x, cofidis3x-sansfrais, ...). List of modalities included in the payment product page.<para />
        /// </summary>
        public string PaymentOption { get; set; } = null;

        /// <summary>
        /// Payment product identifier - Please see [payment products](https://support.direct.ingenico.com/documentation/api/reference/index.html#tag/Products) for a full overview of possible values.<para />
        /// </summary>
        public int? PaymentProductId { get; set; } = null;

        /// <summary>
        /// 3D Secure results object<para />
        /// </summary>
        public ThreeDSecureResults ThreeDSecureResults { get; set; } = null;

        /// <summary>
        /// ID of the token. This property is populated when the payment was done with a token or when the payment was tokenized.<para />
        /// </summary>
        public string Token { get; set; } = null;
    }
}
