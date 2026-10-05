using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B2B RID: 15147
	[Token(Token = "0x2003B2B")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RoguelikeDrawCopperExtraTrigger
	{
		// Token: 0x06017D28 RID: 97576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D28")]
		[Address(RVA = "0x1014A60", Offset = "0x1013660", VA = "0x181014A60")]
		private static void _HandleMessage(List<RoguelikeDrawCopperExtraPushMsg> msgList)
		{
		}

		// Token: 0x06017D29 RID: 97577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D29")]
		[Address(RVA = "0x1014980", Offset = "0x1013580", VA = "0x181014980")]
		public static void HandleMessage(List<RoguelikeDrawCopperExtraPushMsg> msgList)
		{
		}

		// Token: 0x0401CC62 RID: 117858
		[Token(Token = "0x401CC62")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__HandleMessage;

		// Token: 0x0401CC63 RID: 117859
		[Token(Token = "0x401CC63")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
