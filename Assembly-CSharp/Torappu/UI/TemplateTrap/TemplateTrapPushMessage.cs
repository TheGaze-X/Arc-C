using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateTrap
{
	// Token: 0x02003D2C RID: 15660
	[Token(Token = "0x2003D2C")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class TemplateTrapPushMessage
	{
		// Token: 0x0601868A RID: 99978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601868A")]
		[Address(RVA = "0x10FC710", Offset = "0x10FB310", VA = "0x1810FC710")]
		public static void HandleTemplateTrapUnlockMessage(List<TemplateTrapUnlockPushMessage> msgList)
		{
		}

		// Token: 0x0401DDBC RID: 122300
		[Token(Token = "0x401DDBC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleTemplateTrapUnlockMessage;

		// Token: 0x02003D2D RID: 15661
		[Token(Token = "0x2003D2D")]
		private class TemplateTrapPushMessageTask : UINotificationTasks.UIAndBattleFinishTask
		{
			// Token: 0x0601868B RID: 99979 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601868B")]
			[Address(RVA = "0x10FC4C0", Offset = "0x10FB0C0", VA = "0x1810FC4C0", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x0601868C RID: 99980 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601868C")]
			[Address(RVA = "0x10FC6B0", Offset = "0x10FB2B0", VA = "0x1810FC6B0")]
			public TemplateTrapPushMessageTask()
			{
			}

			// Token: 0x0401DDBD RID: 122301
			[Token(Token = "0x401DDBD")]
			[FieldOffset(Offset = "0x20")]
			public string domainId;

			// Token: 0x0401DDBE RID: 122302
			[Token(Token = "0x401DDBE")]
			[FieldOffset(Offset = "0x28")]
			public string trapId;

			// Token: 0x0401DDBF RID: 122303
			[Token(Token = "0x401DDBF")]
			[FieldOffset(Offset = "0x30")]
			public bool isFirst;

			// Token: 0x0401DDC0 RID: 122304
			[Token(Token = "0x401DDC0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x0401DDC1 RID: 122305
			[Token(Token = "0x401DDC1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
