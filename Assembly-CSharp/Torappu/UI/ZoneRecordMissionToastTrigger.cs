using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B72 RID: 15218
	[Token(Token = "0x2003B72")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class ZoneRecordMissionToastTrigger
	{
		// Token: 0x06017DCE RID: 97742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DCE")]
		[Address(RVA = "0x1028070", Offset = "0x1026C70", VA = "0x181028070")]
		public static void HandleMessage(List<ZoneRecordMissionCompleteMsg> msgList)
		{
		}

		// Token: 0x0401CD4F RID: 118095
		[Token(Token = "0x401CD4F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleMessage;

		// Token: 0x02003B73 RID: 15219
		[Token(Token = "0x2003B73")]
		public class ZoneRecordMissionToastTask : UINotificationTasks.MainUITask
		{
			// Token: 0x06017DCF RID: 97743 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017DCF")]
			[Address(RVA = "0x1027CD0", Offset = "0x10268D0", VA = "0x181027CD0", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x06017DD0 RID: 97744 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017DD0")]
			[Address(RVA = "0x1027FC0", Offset = "0x1026BC0", VA = "0x181027FC0")]
			public ZoneRecordMissionToastTask()
			{
			}

			// Token: 0x0401CD50 RID: 118096
			[Token(Token = "0x401CD50")]
			[FieldOffset(Offset = "0x18")]
			public List<StageData> stageDatas;

			// Token: 0x0401CD51 RID: 118097
			[Token(Token = "0x401CD51")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x0401CD52 RID: 118098
			[Token(Token = "0x401CD52")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
