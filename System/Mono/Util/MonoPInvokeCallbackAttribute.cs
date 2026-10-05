using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Mono.Util
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	[Conditional("FULL_AOT_RUNTIME")]
	[Conditional("UNITY")]
	[AttributeUsage(AttributeTargets.Method)]
	[Conditional("MONOTOUCH")]
	internal sealed class MonoPInvokeCallbackAttribute : Attribute
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public MonoPInvokeCallbackAttribute(Type t)
		{
		}
	}
}
