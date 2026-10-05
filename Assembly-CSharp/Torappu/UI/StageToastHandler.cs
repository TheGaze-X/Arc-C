using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B6F RID: 15215
	[Token(Token = "0x2003B6F")]
	public static class StageToastHandler
	{
		// Token: 0x06017DCB RID: 97739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DCB")]
		[Address(RVA = "0x101D230", Offset = "0x101BE30", VA = "0x18101D230")]
		public static void HandleSpecialStageUnlockMessage(List<SpecialStageUnlockPushMsg> msgList)
		{
		}

		// Token: 0x02003B70 RID: 15216
		[Token(Token = "0x2003B70")]
		private class SpecialStageUnlockToastTask : UINotificationTasks.StagePageUITask
		{
			// Token: 0x06017DCC RID: 97740 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017DCC")]
			[Address(RVA = "0x101CB10", Offset = "0x101B710", VA = "0x18101CB10", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x06017DCD RID: 97741 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017DCD")]
			[Address(RVA = "0x101CB90", Offset = "0x101B790", VA = "0x18101CB90")]
			public SpecialStageUnlockToastTask()
			{
			}

			// Token: 0x0401CD4B RID: 118091
			[Token(Token = "0x401CD4B")]
			[FieldOffset(Offset = "0x18")]
			public List<SpecialStageUnlockPushMsg> msgList;

			// Token: 0x0401CD4C RID: 118092
			[Token(Token = "0x401CD4C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x0401CD4D RID: 118093
			[Token(Token = "0x401CD4D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
