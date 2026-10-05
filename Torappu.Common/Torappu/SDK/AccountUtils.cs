using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.SDK
{
	// Token: 0x0200019D RID: 413
	[Token(Token = "0x200019D")]
	public class AccountUtils : IHotfixable
	{
		// Token: 0x060009CF RID: 2511 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x5549C00", Offset = "0x5548800", VA = "0x185549C00")]
		public static string GetU8DeviceID()
		{
			return null;
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x5549D80", Offset = "0x5548980", VA = "0x185549D80")]
		public AccountUtils()
		{
		}

		// Token: 0x04000930 RID: 2352
		[Token(Token = "0x4000930")]
		[FieldOffset(Offset = "0x0")]
		private static string s_U8DeviceID;

		// Token: 0x04000931 RID: 2353
		[Token(Token = "0x4000931")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate210 __Hotfix0_GetU8DeviceID;

		// Token: 0x04000932 RID: 2354
		[Token(Token = "0x4000932")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;
	}
}
