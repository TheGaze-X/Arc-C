using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.MsgSubscription
{
	// Token: 0x020015DA RID: 5594
	[Token(Token = "0x20015DA")]
	public class ServerWideSubMsgCenter : SubscriptionMsgCenter<ServerWideSubMsg>
	{
		// Token: 0x17000F16 RID: 3862
		// (get) Token: 0x06007EE7 RID: 32487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F16")]
		protected override string msgType
		{
			[Token(Token = "0x6007EE7")]
			[Address(RVA = "0x28A0630", Offset = "0x289F230", VA = "0x1828A0630", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007EE8 RID: 32488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EE8")]
		[Address(RVA = "0x28A05C0", Offset = "0x289F1C0", VA = "0x1828A05C0")]
		public ServerWideSubMsgCenter()
		{
		}

		// Token: 0x0400809C RID: 32924
		[Token(Token = "0x400809C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_msgType;

		// Token: 0x0400809D RID: 32925
		[Token(Token = "0x400809D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
