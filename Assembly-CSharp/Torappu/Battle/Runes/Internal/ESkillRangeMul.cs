using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x0200290A RID: 10506
	[Token(Token = "0x200290A")]
	public class ESkillRangeMul : BasicEnemySkillRune
	{
		// Token: 0x17002686 RID: 9862
		// (get) Token: 0x060116DC RID: 71388 RVA: 0x0006B328 File Offset: 0x00069528
		[Token(Token = "0x17002686")]
		public override int priorityQueue
		{
			[Token(Token = "0x60116DC")]
			[Address(RVA = "0x93C190", Offset = "0x93AD90", VA = "0x18093C190", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060116DD RID: 71389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116DD")]
		[Address(RVA = "0x93BF90", Offset = "0x93AB90", VA = "0x18093BF90", Slot = "18")]
		protected override void DoPreprocessEnemySkill(LevelData.EnemyData.ESkillData skill, Enemy enemy)
		{
		}

		// Token: 0x060116DE RID: 71390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116DE")]
		[Address(RVA = "0x93C130", Offset = "0x93AD30", VA = "0x18093C130")]
		public ESkillRangeMul()
		{
		}

		// Token: 0x060116DF RID: 71391 RVA: 0x0006B340 File Offset: 0x00069540
		[Token(Token = "0x60116DF")]
		[Address(RVA = "0x937E80", Offset = "0x936A80", VA = "0x180937E80")]
		private int <>xLuaBaseProxy_get_priorityQueue()
		{
			return 0;
		}

		// Token: 0x04013787 RID: 79751
		[Token(Token = "0x4013787")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_priorityQueue;

		// Token: 0x04013788 RID: 79752
		[Token(Token = "0x4013788")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoPreprocessEnemySkill;

		// Token: 0x04013789 RID: 79753
		[Token(Token = "0x4013789")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
