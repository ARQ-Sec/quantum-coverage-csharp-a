using System;
using System.Security.Cryptography;
namespace Arq.Lab.Coverage;
public static class Rule022 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0413-csharp
        // evidence_anchor: RSACryptoServiceProvider(keySize)
        // regex_sample: RSACryptoServiceProvider[1024
        // keywords: RSACryptoServiceProvider | 512 | 1024
        new RSACryptoServiceProvider(1024);
    }
}
