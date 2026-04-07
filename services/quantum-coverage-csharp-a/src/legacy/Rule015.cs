using System;
using System.Net.Http;
namespace Arq.Lab.Coverage;
public static class Rule015 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0449-csharp
        // evidence_anchor: DangerousAcceptAnyServerCertificateValidator
        // regex_sample: DangerousAcceptAnyServerCertificateValidator
        // keywords: DangerousAcceptAnyServerCertificateValidator
        handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

        // rule_key: quantum.arq-q-0424-csharp
        // evidence_anchor: HttpClientHandler.ServerCertificateCustomValidationCallback
        // regex_sample: DangerousAcceptAnyServerCertificateValidator[lZ> ".Z^MRSz[RNh13 lServerCertificateCustomValidationCallback
        // keywords: HttpClientHandler | ServerCertificateCustomValidationCallback | DangerousAcceptAnyServerCertificateValidator
        var handler = new HttpClientHandler();
        handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
    }
}
