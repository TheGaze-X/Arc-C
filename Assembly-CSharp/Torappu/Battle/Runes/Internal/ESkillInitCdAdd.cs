using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x0200290E RID: 10510
	[Token(Token = "0x200290E")]
	public class ESkillInitCdAdd : BasicEnemySkillRune
	{
		// Token: 0x060116EC RID: 71404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116EC")]
		[Address(RVA = "0x93BCB0", Offset = "0x93A8B0", VA = "0x18093BCB0", Slot = "18")]
		protected override void DoPreprocessEnemySkill(LevelData.EnemyData.ESkillData skill, Enemy enemy)
		{
		}

		// Token: 0x060116ED RID: 71405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116ED")]
		[Address(RVA = "0x93BD90", Offset = "0x93A990", VA = "0x18093BD90")]
		public ESkillInitCdAdd()
		{
		}

		// Token: 0x04013793 RID: 79763
		[Token(Token = "0x4013793")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoPreprocessEnemySkill;

		// Token: 0x04013794 RID: 79764
		[Token(Token = "0x4013794")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
