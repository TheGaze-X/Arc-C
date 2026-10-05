using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200350A RID: 13578
	[Token(Token = "0x200350A")]
	public class CharPushMsgHandler : Singleton<CharPushMsgHandler>
	{
		// Token: 0x06015A9A RID: 88730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015A9A")]
		[Address(RVA = "0xE30430", Offset = "0xE2F030", VA = "0x180E30430")]
		private CharPushMsgHandler()
		{
		}

		// Token: 0x06015A9B RID: 88731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015A9B")]
		[Address(RVA = "0xE302F0", Offset = "0xE2EEF0", VA = "0x180E302F0")]
		public static void HandleTmplUnlockMsg(List<CharTmplUnlockPushMsg> msgList)
		{
		}

		// Token: 0x06015A9C RID: 88732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015A9C")]
		[Address(RVA = "0xE303C0", Offset = "0xE2EFC0", VA = "0x180E303C0")]
		public List<CharTmplUnlockPushMsg> PopulatePendingUnlockTmplMsg()
		{
			return null;
		}

		// Token: 0x04019F98 RID: 106392
		[Token(Token = "0x4019F98")]
		[FieldOffset(Offset = "0x10")]
		private List<CharTmplUnlockPushMsg> m_pendingTmplUnlockMsg;

		// Token: 0x04019F99 RID: 106393
		[Token(Token = "0x4019F99")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04019F9A RID: 106394
		[Token(Token = "0x4019F9A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleTmplUnlockMsg;

		// Token: 0x04019F9B RID: 106395
		[Token(Token = "0x4019F9B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PopulatePendingUnlockTmplMsg;
	}
}
