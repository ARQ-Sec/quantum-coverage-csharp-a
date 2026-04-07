using System;
namespace Arq.Lab.Coverage;
public static class Rule007 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0412-csharp
        // evidence_anchor: RC2CryptoServiceProvider
        // regex_sample: RC4
        // keywords: RC2CryptoServiceProvider | RC2.Create
        new RC2CryptoServiceProvider();
    }
}
