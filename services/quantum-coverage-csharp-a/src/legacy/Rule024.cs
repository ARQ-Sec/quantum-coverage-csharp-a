using System;
using System.Security.Cryptography;
namespace Arq.Lab.Coverage;
public static class Rule024 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0414-csharp
        // evidence_anchor: DSACryptoServiceProvider
        // regex_sample: DSACryptoServiceProvider8GECDSA
        // keywords: DSACryptoServiceProvider | DSA.Create
        new DSACryptoServiceProvider();
    }
}
