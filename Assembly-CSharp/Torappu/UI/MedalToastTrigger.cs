using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003AD4 RID: 15060
	[Token(Token = "0x2003AD4")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class MedalToastTrigger
	{
		// Token: 0x06017C00 RID: 97280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C00")]
		[Address(RVA = "0xFFEC80", Offset = "0xFFD880", VA = "0x180FFEC80")]
		public static void HandleMessage(List<MedalPushMsgPayload> msgList)
		{
		}

		// Token: 0x0401CAD8 RID: 117464
		[Token(Token = "0x401CAD8")]
		private const float MEDAL_TOAST_DUR = 5f;

		// Token: 0x0401CAD9 RID: 117465
		[Token(Token = "0x401CAD9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleMessage;

		// Token: 0x02003AD5 RID: 15061
		[Token(Token = "0x2003AD5")]
		private class MedalToastTask : UINotificationTasks.MainUITask
		{
			// Token: 0x06017C01 RID: 97281 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017C01")]
			[Address(RVA = "0xFFE940", Offset = "0xFFD540", VA = "0x180FFE940", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x06017C02 RID: 97282 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017C02")]
			[Address(RVA = "0xFFEBD0", Offset = "0xFFD7D0", VA = "0x180FFEBD0")]
			public MedalToastTask()
			{
			}

			// Token: 0x0401CADA RID: 117466
			[Token(Token = "0x401CADA")]
			[FieldOffset(Offset = "0x18")]
			public List<MedalPerData> medalList;

			// Token: 0x0401CADB RID: 117467
			[Token(Token = "0x401CADB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x0401CADC RID: 117468
			[Token(Token = "0x401CADC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
