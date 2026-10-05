using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x0200503F RID: 20543
	[Token(Token = "0x200503F")]
	public class EnemyDuelPrepareRoomStateBean : IHotfixable, IStateBean
	{
		// Token: 0x0601E770 RID: 124784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E770")]
		[Address(RVA = "0x18297B0", Offset = "0x18283B0", VA = "0x1818297B0")]
		public EnemyDuelPrepareRoomStateBean()
		{
		}

		// Token: 0x04028C8E RID: 167054
		[Token(Token = "0x4028C8E")]
		[FieldOffset(Offset = "0x10")]
		public EnemyDuelPrepareRoomProperty prop;

		// Token: 0x04028C8F RID: 167055
		[Token(Token = "0x4028C8F")]
		[FieldOffset(Offset = "0x18")]
		public EnemyDuelPrepareBannerView.Param initBannerViewParam;

		// Token: 0x04028C90 RID: 167056
		[Token(Token = "0x4028C90")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
