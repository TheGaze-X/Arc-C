using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B4B RID: 15179
	[Token(Token = "0x2003B4B")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class SandboxV2CookRecipeTrigger
	{
		// Token: 0x06017D70 RID: 97648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D70")]
		[Address(RVA = "0x10176E0", Offset = "0x10162E0", VA = "0x1810176E0")]
		private static void _HandleMessage(List<SandboxV2CookRecipePushMsg> msgList)
		{
		}

		// Token: 0x06017D71 RID: 97649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D71")]
		[Address(RVA = "0x10175C0", Offset = "0x10161C0", VA = "0x1810175C0")]
		public static void HandleMessage(List<SandboxV2CookRecipePushMsg> msgList)
		{
		}

		// Token: 0x0401CCAC RID: 117932
		[Token(Token = "0x401CCAC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__HandleMessage;

		// Token: 0x0401CCAD RID: 117933
		[Token(Token = "0x401CCAD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
