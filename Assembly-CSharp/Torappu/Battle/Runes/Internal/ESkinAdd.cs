using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x02002909 RID: 10505
	[Token(Token = "0x2002909")]
	public class ESkinAdd : BasicEnemyRune
	{
		// Token: 0x060116DA RID: 71386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116DA")]
		[Address(RVA = "0x93C380", Offset = "0x93AF80", VA = "0x18093C380", Slot = "17")]
		protected override void DoPreprocessEnemy(LevelData.EnemyData data, Enemy enemy)
		{
		}

		// Token: 0x060116DB RID: 71387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116DB")]
		[Address(RVA = "0x93C4F0", Offset = "0x93B0F0", VA = "0x18093C4F0")]
		public ESkinAdd()
		{
		}

		// Token: 0x04013785 RID: 79749
		[Token(Token = "0x4013785")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoPreprocessEnemy;

		// Token: 0x04013786 RID: 79750
		[Token(Token = "0x4013786")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
