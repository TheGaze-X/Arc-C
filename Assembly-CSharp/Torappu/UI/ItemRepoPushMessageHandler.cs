using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003AC8 RID: 15048
	[Token(Token = "0x2003AC8")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class ItemRepoPushMessageHandler
	{
		// Token: 0x06017BC9 RID: 97225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017BC9")]
		[Address(RVA = "0xFFD200", Offset = "0xFFBE00", VA = "0x180FFD200")]
		public static void HandleApSupplyAutoUseMessage(List<ItemRepoApSupplyAutoUsePushMessage> msgList)
		{
		}

		// Token: 0x0401CA78 RID: 117368
		[Token(Token = "0x401CA78")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleApSupplyAutoUseMessage;

		// Token: 0x02003AC9 RID: 15049
		[Token(Token = "0x2003AC9")]
		private class ApSupplyAutoUseTasks : UINotificationTasks.MainUITask
		{
			// Token: 0x06017BCA RID: 97226 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017BCA")]
			[Address(RVA = "0xFF9B20", Offset = "0xFF8720", VA = "0x180FF9B20", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x06017BCB RID: 97227 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017BCB")]
			[Address(RVA = "0xFF9BA0", Offset = "0xFF87A0", VA = "0x180FF9BA0")]
			public ApSupplyAutoUseTasks()
			{
			}

			// Token: 0x0401CA79 RID: 117369
			[Token(Token = "0x401CA79")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x0401CA7A RID: 117370
			[Token(Token = "0x401CA7A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
