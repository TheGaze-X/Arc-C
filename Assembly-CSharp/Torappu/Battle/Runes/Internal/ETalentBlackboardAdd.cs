using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x02002904 RID: 10500
	[Token(Token = "0x2002904")]
	public class ETalentBlackboardAdd : BasicEnemyRune
	{
		// Token: 0x060116CC RID: 71372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116CC")]
		[Address(RVA = "0x93C590", Offset = "0x93B190", VA = "0x18093C590", Slot = "17")]
		protected override void DoPreprocessEnemy(LevelData.EnemyData data, Enemy enemy)
		{
		}

		// Token: 0x060116CD RID: 71373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116CD")]
		[Address(RVA = "0x93C630", Offset = "0x93B230", VA = "0x18093C630")]
		public ETalentBlackboardAdd()
		{
		}

		// Token: 0x04013779 RID: 79737
		[Token(Token = "0x4013779")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoPreprocessEnemy;

		// Token: 0x0401377A RID: 79738
		[Token(Token = "0x401377A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
