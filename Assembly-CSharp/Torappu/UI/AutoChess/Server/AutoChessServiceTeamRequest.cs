using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x02006442 RID: 25666
	[Token(Token = "0x2006442")]
	public abstract class AutoChessServiceTeamRequest : AutoChessServiceRequest
	{
		// Token: 0x06024EE5 RID: 151269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EE5")]
		[Address(RVA = "0x1FD6A50", Offset = "0x1FD5650", VA = "0x181FD6A50")]
		protected AutoChessServiceTeamRequest(uint pid)
		{
		}

		// Token: 0x17005722 RID: 22306
		// (get) Token: 0x06024EE6 RID: 151270 RVA: 0x000C5C28 File Offset: 0x000C3E28
		[Token(Token = "0x17005722")]
		public sealed override AutoChessServiceRequestTarget target
		{
			[Token(Token = "0x6024EE6")]
			[Address(RVA = "0x1FD6B00", Offset = "0x1FD5700", VA = "0x181FD6B00", Slot = "7")]
			get
			{
				return AutoChessServiceRequestTarget.TEAM;
			}
		}

		// Token: 0x04033A9C RID: 211612
		[Token(Token = "0x4033A9C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04033A9D RID: 211613
		[Token(Token = "0x4033A9D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_target;
	}
}
