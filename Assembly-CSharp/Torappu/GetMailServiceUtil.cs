using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x020007BC RID: 1980
	[Token(Token = "0x20007BC")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class GetMailServiceUtil
	{
		// Token: 0x0600643A RID: 25658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600643A")]
		[Address(RVA = "0x1EEA850", Offset = "0x1EE9450", VA = "0x181EEA850")]
		public static ReceiveAllCommonMailRequest GetReceiveAllMailRequest(List<long> idList, List<long> systemList)
		{
			return null;
		}

		// Token: 0x0600643B RID: 25659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600643B")]
		[Address(RVA = "0x1EEAAC0", Offset = "0x1EE96C0", VA = "0x181EEAAC0")]
		public static RemoveAllCommonRecievedMailRequest GetRemoveAllMailRequest(List<long> idList, List<long> systemList, List<string> surveyList)
		{
			return null;
		}

		// Token: 0x0600643C RID: 25660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600643C")]
		[Address(RVA = "0x1EEA990", Offset = "0x1EE9590", VA = "0x181EEA990")]
		public static ReceiveCommonMailRequest GetReceiveMailRequest(long id, MailFromInfo type)
		{
			return null;
		}

		// Token: 0x0600643D RID: 25661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600643D")]
		[Address(RVA = "0x1EEA6E0", Offset = "0x1EE92E0", VA = "0x181EEA6E0")]
		public static ListMailBoxCommonRequest GetListMailBoxRequest(List<long> idList, List<long> systemList, List<string> surveyList)
		{
			return null;
		}

		// Token: 0x040030CD RID: 12493
		[Token(Token = "0x40030CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetReceiveAllMailRequest;

		// Token: 0x040030CE RID: 12494
		[Token(Token = "0x40030CE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetRemoveAllMailRequest;

		// Token: 0x040030CF RID: 12495
		[Token(Token = "0x40030CF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetReceiveMailRequest;

		// Token: 0x040030D0 RID: 12496
		[Token(Token = "0x40030D0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetListMailBoxRequest;
	}
}
