using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02005052 RID: 20562
	[Token(Token = "0x2005052")]
	public class EnemyDuelPrepareSelectModeStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601E7B5 RID: 124853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7B5")]
		[Address(RVA = "0x182C1B0", Offset = "0x182ADB0", VA = "0x18182C1B0")]
		public EnemyDuelPrepareSelectModeStateBean()
		{
		}

		// Token: 0x04028D43 RID: 167235
		[Token(Token = "0x4028D43")]
		[FieldOffset(Offset = "0x10")]
		public EnemyDuelPrepareSelectModeProperty prop;

		// Token: 0x04028D44 RID: 167236
		[Token(Token = "0x4028D44")]
		[FieldOffset(Offset = "0x18")]
		public ActivityEnemyDuelModeData cacheConfirmedModeData;

		// Token: 0x04028D45 RID: 167237
		[Token(Token = "0x4028D45")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
