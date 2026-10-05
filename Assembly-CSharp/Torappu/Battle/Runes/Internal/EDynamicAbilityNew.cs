using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x02002907 RID: 10503
	[Token(Token = "0x2002907")]
	public class EDynamicAbilityNew : BasicEnemyRune
	{
		// Token: 0x060116D6 RID: 71382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116D6")]
		[Address(RVA = "0x93B2A0", Offset = "0x939EA0", VA = "0x18093B2A0", Slot = "17")]
		protected override void DoPreprocessEnemy(LevelData.EnemyData data, Enemy enemy)
		{
		}

		// Token: 0x060116D7 RID: 71383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116D7")]
		[Address(RVA = "0x93B440", Offset = "0x93A040", VA = "0x18093B440")]
		public EDynamicAbilityNew()
		{
		}

		// Token: 0x04013781 RID: 79745
		[Token(Token = "0x4013781")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoPreprocessEnemy;

		// Token: 0x04013782 RID: 79746
		[Token(Token = "0x4013782")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
