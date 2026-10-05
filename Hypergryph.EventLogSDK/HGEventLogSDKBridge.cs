using System;
using Il2CppDummyDll;

namespace Hypergryph.SDK
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	internal static class HGEventLogSDKBridge
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000001")]
		public static IEventLogSDK eventLogSdk
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x4A031F0", Offset = "0x4A01DF0", VA = "0x184A031F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x0")]
		private static IEventLogSDK s_el;
	}
}
