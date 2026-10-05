using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B10 RID: 15120
	[Token(Token = "0x2003B10")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RoguelikeSanDecreaseTrigger
	{
		// Token: 0x06017CFC RID: 97532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017CFC")]
		[Address(RVA = "0x100D990", Offset = "0x100C590", VA = "0x18100D990")]
		private static void _HandleSingleMessage(RoguelikeSanDecreasePushMsg msg)
		{
		}

		// Token: 0x06017CFD RID: 97533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017CFD")]
		[Address(RVA = "0x100D8E0", Offset = "0x100C4E0", VA = "0x18100D8E0")]
		private static void _HandleMessage(List<RoguelikeSanDecreasePushMsg> msgList)
		{
		}

		// Token: 0x06017CFE RID: 97534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017CFE")]
		[Address(RVA = "0x100D800", Offset = "0x100C400", VA = "0x18100D800")]
		public static void HandleMessage(List<RoguelikeSanDecreasePushMsg> msgList)
		{
		}

		// Token: 0x0401CC30 RID: 117808
		[Token(Token = "0x401CC30")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__HandleSingleMessage;

		// Token: 0x0401CC31 RID: 117809
		[Token(Token = "0x401CC31")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__HandleMessage;

		// Token: 0x0401CC32 RID: 117810
		[Token(Token = "0x401CC32")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
