using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B27 RID: 15143
	[Token(Token = "0x2003B27")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RoguelikeGotWrathTrigger
	{
		// Token: 0x06017D22 RID: 97570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D22")]
		[Address(RVA = "0x1015F90", Offset = "0x1014B90", VA = "0x181015F90")]
		private static void _HandleMessage(List<RoguelikeGotWrathPushMsg> msgList)
		{
		}

		// Token: 0x06017D23 RID: 97571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D23")]
		[Address(RVA = "0x1015EB0", Offset = "0x1014AB0", VA = "0x181015EB0")]
		public static void HandleMessage(List<RoguelikeGotWrathPushMsg> msgList)
		{
		}

		// Token: 0x0401CC5B RID: 117851
		[Token(Token = "0x401CC5B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__HandleMessage;

		// Token: 0x0401CC5C RID: 117852
		[Token(Token = "0x401CC5C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
