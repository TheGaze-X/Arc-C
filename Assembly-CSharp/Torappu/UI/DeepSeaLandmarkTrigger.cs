using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003AA9 RID: 15017
	[Token(Token = "0x2003AA9")]
	public static class DeepSeaLandmarkTrigger
	{
		// Token: 0x06017B8E RID: 97166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B8E")]
		[Address(RVA = "0xFE6440", Offset = "0xFE5040", VA = "0x180FE6440")]
		public static void HandleMessage(List<DeepSeaLandmarkPushMessage> msgList)
		{
		}

		// Token: 0x02003AAA RID: 15018
		[Token(Token = "0x2003AAA")]
		private class ToastTask : UINotificationTasks.MainUITask
		{
			// Token: 0x06017B8F RID: 97167 RVA: 0x00097CE0 File Offset: 0x00095EE0
			[Token(Token = "0x6017B8F")]
			[Address(RVA = "0xFEFC60", Offset = "0xFEE860", VA = "0x180FEFC60", Slot = "4")]
			public override bool CanConsume()
			{
				return default(bool);
			}

			// Token: 0x06017B90 RID: 97168 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017B90")]
			[Address(RVA = "0xFEFD70", Offset = "0xFEE970", VA = "0x180FEFD70", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x06017B91 RID: 97169 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017B91")]
			[Address(RVA = "0xFEFF00", Offset = "0xFEEB00", VA = "0x180FEFF00")]
			public ToastTask()
			{
			}

			// Token: 0x06017B92 RID: 97170 RVA: 0x00097CF8 File Offset: 0x00095EF8
			[Token(Token = "0x6017B92")]
			[Address(RVA = "0xDEB670", Offset = "0xDEA270", VA = "0x180DEB670")]
			private bool <>xLuaBaseProxy_CanConsume()
			{
				return default(bool);
			}

			// Token: 0x0401CA1C RID: 117276
			[Token(Token = "0x401CA1C")]
			[FieldOffset(Offset = "0x18")]
			public List<DeepSeaLandmarkPushMessage> msgList;

			// Token: 0x0401CA1D RID: 117277
			[Token(Token = "0x401CA1D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CanConsume;

			// Token: 0x0401CA1E RID: 117278
			[Token(Token = "0x401CA1E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x0401CA1F RID: 117279
			[Token(Token = "0x401CA1F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
