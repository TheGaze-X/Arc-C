using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028FC RID: 10492
	[Token(Token = "0x20028FC")]
	public abstract class BasicEnemySkillRune : BasicEnemyRune
	{
		// Token: 0x060116B4 RID: 71348 RVA: 0x0006B220 File Offset: 0x00069420
		[Token(Token = "0x60116B4")]
		[Address(RVA = "0x935BD0", Offset = "0x9347D0", VA = "0x180935BD0")]
		protected bool Verify(LevelData.EnemyData.ESkillData skill)
		{
			return default(bool);
		}

		// Token: 0x060116B5 RID: 71349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116B5")]
		[Address(RVA = "0x935A30", Offset = "0x934630", VA = "0x180935A30", Slot = "17")]
		protected sealed override void DoPreprocessEnemy(LevelData.EnemyData data, Enemy enemy)
		{
		}

		// Token: 0x060116B6 RID: 71350
		[Token(Token = "0x60116B6")]
		protected abstract void DoPreprocessEnemySkill(LevelData.EnemyData.ESkillData skill, Enemy enemy);

		// Token: 0x060116B7 RID: 71351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116B7")]
		[Address(RVA = "0x935C80", Offset = "0x934880", VA = "0x180935C80")]
		protected BasicEnemySkillRune()
		{
		}

		// Token: 0x04013765 RID: 79717
		[Token(Token = "0x4013765")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Verify;

		// Token: 0x04013766 RID: 79718
		[Token(Token = "0x4013766")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoPreprocessEnemy;

		// Token: 0x04013767 RID: 79719
		[Token(Token = "0x4013767")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
