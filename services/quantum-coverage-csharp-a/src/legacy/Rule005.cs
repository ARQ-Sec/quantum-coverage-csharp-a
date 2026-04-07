using System;
namespace Arq.Lab.Coverage;
public static class Rule005 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0431-csharp
        // evidence_anchor: DES.Create, DESCryptoServiceProvider
        // regex_sample: DES
        // keywords: DES.Create | DESCryptoServiceProvider
        DES.Create();
    }
}
