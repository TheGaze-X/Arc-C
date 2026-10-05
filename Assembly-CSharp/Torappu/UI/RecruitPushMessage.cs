using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003AF1 RID: 15089
	[Token(Token = "0x2003AF1")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RecruitPushMessage
	{
		// Token: 0x06017C8B RID: 97419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C8B")]
		[Address(RVA = "0x100AB70", Offset = "0x1009770", VA = "0x18100AB70")]
		public static void HandleChangeTagMessage(List<RecruitOnlyChangeTagPushMsg> msgList)
		{
		}

		// Token: 0x0401CB91 RID: 117649
		[Token(Token = "0x401CB91")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleChangeTagMessage;

		// Token: 0x02003AF2 RID: 15090
		[Token(Token = "0x2003AF2")]
		private class RecruitPageTask : UINotificationTasks.MainUITask
		{
			// Token: 0x06017C8C RID: 97420 RVA: 0x00098208 File Offset: 0x00096408
			[Token(Token = "0x6017C8C")]
			[Address(RVA = "0x100A970", Offset = "0x1009570", VA = "0x18100A970", Slot = "4")]
			public override bool CanConsume()
			{
				return default(bool);
			}

			// Token: 0x06017C8D RID: 97421 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017C8D")]
			[Address(RVA = "0x100AA80", Offset = "0x1009680", VA = "0x18100AA80", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x06017C8E RID: 97422 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017C8E")]
			[Address(RVA = "0x100AB10", Offset = "0x1009710", VA = "0x18100AB10")]
			public RecruitPageTask()
			{
			}

			// Token: 0x06017C8F RID: 97423 RVA: 0x00098220 File Offset: 0x00096420
			[Token(Token = "0x6017C8F")]
			[Address(RVA = "0xDEB670", Offset = "0xDEA270", VA = "0x180DEB670")]
			private bool <>xLuaBaseProxy_CanConsume()
			{
				return default(bool);
			}

			// Token: 0x0401CB92 RID: 117650
			[Token(Token = "0x401CB92")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CanConsume;

			// Token: 0x0401CB93 RID: 117651
			[Token(Token = "0x401CB93")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x0401CB94 RID: 117652
			[Token(Token = "0x401CB94")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
