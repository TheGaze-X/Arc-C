using System;
using Il2CppDummyDll;

namespace Hypergryph.SDK
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	internal static class HGUniWebviewBridge
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000028 RID: 40 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000003")]
		public static IUniWebview uniWebview
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x4A2EE80", Offset = "0x4A2DA80", VA = "0x184A2EE80")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x0")]
		private static IUniWebview s_uw;
	}
}
