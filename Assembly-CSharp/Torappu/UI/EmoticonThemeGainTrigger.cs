using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003AAD RID: 15021
	[Token(Token = "0x2003AAD")]
	[Hotfix(HotfixFlag.Stateless)]
	public class EmoticonThemeGainTrigger
	{
		// Token: 0x06017B96 RID: 97174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B96")]
		[Address(RVA = "0xFE9C40", Offset = "0xFE8840", VA = "0x180FE9C40")]
		public static void HandleMessage(List<EmoticonThemeGainPushMessage> msgList)
		{
		}

		// Token: 0x06017B97 RID: 97175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B97")]
		[Address(RVA = "0xFE9D20", Offset = "0xFE8920", VA = "0x180FE9D20")]
		public EmoticonThemeGainTrigger()
		{
		}

		// Token: 0x0401CA25 RID: 117285
		[Token(Token = "0x401CA25")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleMessage;

		// Token: 0x0401CA26 RID: 117286
		[Token(Token = "0x401CA26")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
