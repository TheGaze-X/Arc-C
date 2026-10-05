using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02005005 RID: 20485
	[Token(Token = "0x2005005")]
	public class EnemyDuelRoundStartViewModel : IHotfixable
	{
		// Token: 0x0601E670 RID: 124528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E670")]
		[Address(RVA = "0x1820130", Offset = "0x181ED30", VA = "0x181820130")]
		public void LoadData()
		{
		}

		// Token: 0x0601E671 RID: 124529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E671")]
		[Address(RVA = "0x1820220", Offset = "0x181EE20", VA = "0x181820220")]
		public EnemyDuelRoundStartViewModel()
		{
		}

		// Token: 0x04028A85 RID: 166533
		[Token(Token = "0x4028A85")]
		[FieldOffset(Offset = "0x10")]
		public bool isStandMode;

		// Token: 0x04028A86 RID: 166534
		[Token(Token = "0x4028A86")]
		[FieldOffset(Offset = "0x14")]
		public int curWave;

		// Token: 0x04028A87 RID: 166535
		[Token(Token = "0x4028A87")]
		[FieldOffset(Offset = "0x18")]
		public int totalWave;

		// Token: 0x04028A88 RID: 166536
		[Token(Token = "0x4028A88")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04028A89 RID: 166537
		[Token(Token = "0x4028A89")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
