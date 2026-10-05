using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.SDK
{
	// Token: 0x020014F9 RID: 5369
	[Token(Token = "0x20014F9")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class SDKLoginoutController
	{
		// Token: 0x06007B9C RID: 31644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B9C")]
		[Address(RVA = "0x2744BD0", Offset = "0x27437D0", VA = "0x182744BD0")]
		public static void TryToCallLogin()
		{
		}

		// Token: 0x06007B9D RID: 31645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B9D")]
		[Address(RVA = "0x2744D70", Offset = "0x2743970", VA = "0x182744D70")]
		public static void TryToCallLogout()
		{
		}

		// Token: 0x04007A01 RID: 31233
		[Token(Token = "0x4007A01")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryToCallLogin;

		// Token: 0x04007A02 RID: 31234
		[Token(Token = "0x4007A02")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TryToCallLogout;
	}
}
