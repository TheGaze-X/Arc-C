using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FF2 RID: 20466
	[Token(Token = "0x2004FF2")]
	public class EnemyDuelBattleGiveUpViewModel : IHotfixable
	{
		// Token: 0x0601E611 RID: 124433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E611")]
		[Address(RVA = "0x1810B90", Offset = "0x180F790", VA = "0x181810B90")]
		public void LoadData()
		{
		}

		// Token: 0x0601E612 RID: 124434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E612")]
		[Address(RVA = "0x1810D50", Offset = "0x180F950", VA = "0x181810D50")]
		public EnemyDuelBattleGiveUpViewModel()
		{
		}

		// Token: 0x040289DA RID: 166362
		[Token(Token = "0x40289DA")]
		[FieldOffset(Offset = "0x10")]
		public string textGiveUp;

		// Token: 0x040289DB RID: 166363
		[Token(Token = "0x40289DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040289DC RID: 166364
		[Token(Token = "0x40289DC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
