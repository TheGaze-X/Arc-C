using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200004D RID: 77
	// (Invoke) Token: 0x060002ED RID: 749
	[Token(Token = "0x200004D")]
	[Preserve]
	internal delegate TResult MethodCall<T, TResult>(T target, params object[] args);
}
