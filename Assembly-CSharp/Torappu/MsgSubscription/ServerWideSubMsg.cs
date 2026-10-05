using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.MsgSubscription
{
	// Token: 0x020015D9 RID: 5593
	[Token(Token = "0x20015D9")]
	public class ServerWideSubMsg : ISubscriptionMsg, IHotfixable
	{
		// Token: 0x06007EE5 RID: 32485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EE5")]
		[Address(RVA = "0x28A06A0", Offset = "0x289F2A0", VA = "0x1828A06A0", Slot = "4")]
		public void FlushData(string data)
		{
		}

		// Token: 0x06007EE6 RID: 32486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EE6")]
		[Address(RVA = "0x28A0820", Offset = "0x289F420", VA = "0x1828A0820")]
		public ServerWideSubMsg()
		{
		}

		// Token: 0x04008097 RID: 32919
		[Token(Token = "0x4008097")]
		public const string MSG_TYPE_NAME = "server_wide_marquee";

		// Token: 0x04008098 RID: 32920
		[Token(Token = "0x4008098")]
		[FieldOffset(Offset = "0x10")]
		public string content;

		// Token: 0x04008099 RID: 32921
		[Token(Token = "0x4008099")]
		[FieldOffset(Offset = "0x18")]
		public int loop;

		// Token: 0x0400809A RID: 32922
		[Token(Token = "0x400809A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_FlushData;

		// Token: 0x0400809B RID: 32923
		[Token(Token = "0x400809B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
