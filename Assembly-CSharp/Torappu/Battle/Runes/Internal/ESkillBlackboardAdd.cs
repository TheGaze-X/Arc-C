using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x02002910 RID: 10512
	[Token(Token = "0x2002910")]
	public class ESkillBlackboardAdd : BasicEnemySkillRune
	{
		// Token: 0x060116F2 RID: 71410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116F2")]
		[Address(RVA = "0x93B8B0", Offset = "0x93A4B0", VA = "0x18093B8B0", Slot = "18")]
		protected override void DoPreprocessEnemySkill(LevelData.EnemyData.ESkillData skill, Enemy enemy)
		{
		}

		// Token: 0x060116F3 RID: 71411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116F3")]
		[Address(RVA = "0x93B950", Offset = "0x93A550", VA = "0x18093B950")]
		public ESkillBlackboardAdd()
		{
		}

		// Token: 0x04013798 RID: 79768
		[Token(Token = "0x4013798")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoPreprocessEnemySkill;

		// Token: 0x04013799 RID: 79769
		[Token(Token = "0x4013799")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
