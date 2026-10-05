using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x02006470 RID: 25712
	[Token(Token = "0x2006470")]
	public class AutoChessBattleHomeState : PopupFadeState
	{
		// Token: 0x06024F6F RID: 151407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024F6F")]
		[Address(RVA = "0x1FC5970", Offset = "0x1FC4570", VA = "0x181FC5970", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06024F70 RID: 151408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F70")]
		[Address(RVA = "0x1FC59D0", Offset = "0x1FC45D0", VA = "0x181FC59D0")]
		public AutoChessBattleHomeState()
		{
		}

		// Token: 0x04033B9D RID: 211869
		[Token(Token = "0x4033B9D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04033B9E RID: 211870
		[Token(Token = "0x4033B9E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
