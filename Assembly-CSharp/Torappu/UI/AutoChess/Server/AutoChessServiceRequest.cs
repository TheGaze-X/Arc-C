using System;
using Il2CppDummyDll;
using Torappu.SocketNetwork;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x02006440 RID: 25664
	[Token(Token = "0x2006440")]
	public abstract class AutoChessServiceRequest : Protocol
	{
		// Token: 0x06024EE2 RID: 151266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EE2")]
		[Address(RVA = "0x1FD6980", Offset = "0x1FD5580", VA = "0x181FD6980")]
		protected AutoChessServiceRequest(uint pid)
		{
		}

		// Token: 0x17005720 RID: 22304
		// (get) Token: 0x06024EE3 RID: 151267 RVA: 0x000C5C10 File Offset: 0x000C3E10
		[Token(Token = "0x17005720")]
		public int requestId
		{
			[Token(Token = "0x6024EE3")]
			[Address(RVA = "0x1FD69F0", Offset = "0x1FD55F0", VA = "0x181FD69F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005721 RID: 22305
		// (get) Token: 0x06024EE4 RID: 151268
		[Token(Token = "0x17005721")]
		public abstract AutoChessServiceRequestTarget target { [Token(Token = "0x6024EE4")] get; }

		// Token: 0x04033A97 RID: 211607
		[Token(Token = "0x4033A97")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04033A98 RID: 211608
		[Token(Token = "0x4033A98")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_requestId;
	}
}
