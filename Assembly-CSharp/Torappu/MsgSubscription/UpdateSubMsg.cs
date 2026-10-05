using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.MsgSubscription
{
	// Token: 0x020015DB RID: 5595
	[Token(Token = "0x20015DB")]
	public class UpdateSubMsg : ISubscriptionMsg, IHotfixable
	{
		// Token: 0x06007EE9 RID: 32489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EE9")]
		[Address(RVA = "0x28A27B0", Offset = "0x28A13B0", VA = "0x1828A27B0", Slot = "4")]
		public void FlushData(string data)
		{
		}

		// Token: 0x06007EEA RID: 32490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EEA")]
		[Address(RVA = "0x28A2960", Offset = "0x28A1560", VA = "0x1828A2960")]
		public UpdateSubMsg()
		{
		}

		// Token: 0x0400809E RID: 32926
		[Token(Token = "0x400809E")]
		public const string MSG_TYPE_NAME = "update_marquee";

		// Token: 0x0400809F RID: 32927
		[Token(Token = "0x400809F")]
		[FieldOffset(Offset = "0x10")]
		public string content;

		// Token: 0x040080A0 RID: 32928
		[Token(Token = "0x40080A0")]
		[FieldOffset(Offset = "0x18")]
		public int loop;

		// Token: 0x040080A1 RID: 32929
		[Token(Token = "0x40080A1")]
		[FieldOffset(Offset = "0x20")]
		public string majorVersion;

		// Token: 0x040080A2 RID: 32930
		[Token(Token = "0x40080A2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_FlushData;

		// Token: 0x040080A3 RID: 32931
		[Token(Token = "0x40080A3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
