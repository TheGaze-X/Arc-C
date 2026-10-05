using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x02006443 RID: 25667
	[Token(Token = "0x2006443")]
	public abstract class AutoChessServiceBattleRequest : AutoChessServiceRequest
	{
		// Token: 0x06024EE7 RID: 151271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EE7")]
		[Address(RVA = "0x1FD67A0", Offset = "0x1FD53A0", VA = "0x181FD67A0")]
		protected AutoChessServiceBattleRequest(uint pid)
		{
		}

		// Token: 0x17005723 RID: 22307
		// (get) Token: 0x06024EE8 RID: 151272 RVA: 0x000C5C40 File Offset: 0x000C3E40
		[Token(Token = "0x17005723")]
		public sealed override AutoChessServiceRequestTarget target
		{
			[Token(Token = "0x6024EE8")]
			[Address(RVA = "0x1FD6850", Offset = "0x1FD5450", VA = "0x181FD6850", Slot = "7")]
			get
			{
				return AutoChessServiceRequestTarget.TEAM;
			}
		}

		// Token: 0x04033A9E RID: 211614
		[Token(Token = "0x4033A9E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04033A9F RID: 211615
		[Token(Token = "0x4033A9F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_target;
	}
}
