using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FFE RID: 20478
	[Token(Token = "0x2004FFE")]
	public class EnemyDuelBattleStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601E65D RID: 124509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E65D")]
		[Address(RVA = "0x1812C10", Offset = "0x1811810", VA = "0x181812C10")]
		public EnemyDuelBattleStateBean()
		{
		}

		// Token: 0x04028A45 RID: 166469
		[Token(Token = "0x4028A45")]
		[FieldOffset(Offset = "0x10")]
		public EnemyDuelBattleProperty battleProp;

		// Token: 0x04028A46 RID: 166470
		[Token(Token = "0x4028A46")]
		[FieldOffset(Offset = "0x18")]
		public EnemyDuelRoundStartProperty startProp;

		// Token: 0x04028A47 RID: 166471
		[Token(Token = "0x4028A47")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
