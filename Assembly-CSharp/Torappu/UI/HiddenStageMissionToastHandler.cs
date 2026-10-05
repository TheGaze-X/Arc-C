using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003ABA RID: 15034
	[Token(Token = "0x2003ABA")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class HiddenStageMissionToastHandler
	{
		// Token: 0x06017BAE RID: 97198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017BAE")]
		[Address(RVA = "0xFFA340", Offset = "0xFF8F40", VA = "0x180FFA340")]
		public static void HandleMessage(List<HiddenStageMissionPushMsg> msgList)
		{
		}

		// Token: 0x06017BAF RID: 97199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017BAF")]
		[Address(RVA = "0xFFA840", Offset = "0xFF9440", VA = "0x180FFA840")]
		private static string _GetRetroIdOrActId(string stageId)
		{
			return null;
		}

		// Token: 0x06017BB0 RID: 97200 RVA: 0x00097D28 File Offset: 0x00095F28
		[Token(Token = "0x6017BB0")]
		[Address(RVA = "0xFFA770", Offset = "0xFF9370", VA = "0x180FFA770")]
		public static HiddenStageMissionToastParam PopulatePendingParam()
		{
			return default(HiddenStageMissionToastParam);
		}

		// Token: 0x06017BB1 RID: 97201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017BB1")]
		[Address(RVA = "0xFFA920", Offset = "0xFF9520", VA = "0x180FFA920")]
		private static void _UpdatePointTrack(List<HiddenStageMissionPushMsg> payloads)
		{
		}

		// Token: 0x0401CA4E RID: 117326
		[Token(Token = "0x401CA4E")]
		[FieldOffset(Offset = "0x0")]
		private static HiddenStageMissionToastParam s_hidStgMisToastParam;

		// Token: 0x0401CA4F RID: 117327
		[Token(Token = "0x401CA4F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HandleMessage;

		// Token: 0x0401CA50 RID: 117328
		[Token(Token = "0x401CA50")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetRetroIdOrActId;

		// Token: 0x0401CA51 RID: 117329
		[Token(Token = "0x401CA51")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PopulatePendingParam;

		// Token: 0x0401CA52 RID: 117330
		[Token(Token = "0x401CA52")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdatePointTrack;
	}
}
