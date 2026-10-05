using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x0200290F RID: 10511
	[Token(Token = "0x200290F")]
	public class ESkillBlackboardMul : BasicEnemySkillRune
	{
		// Token: 0x1700268A RID: 9866
		// (get) Token: 0x060116EE RID: 71406 RVA: 0x0006B3E8 File Offset: 0x000695E8
		[Token(Token = "0x1700268A")]
		public override int priorityQueue
		{
			[Token(Token = "0x60116EE")]
			[Address(RVA = "0x93BAB0", Offset = "0x93A6B0", VA = "0x18093BAB0", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060116EF RID: 71407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116EF")]
		[Address(RVA = "0x93B9B0", Offset = "0x93A5B0", VA = "0x18093B9B0", Slot = "18")]
		protected override void DoPreprocessEnemySkill(LevelData.EnemyData.ESkillData skill, Enemy enemy)
		{
		}

		// Token: 0x060116F0 RID: 71408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116F0")]
		[Address(RVA = "0x93BA50", Offset = "0x93A650", VA = "0x18093BA50")]
		public ESkillBlackboardMul()
		{
		}

		// Token: 0x060116F1 RID: 71409 RVA: 0x0006B400 File Offset: 0x00069600
		[Token(Token = "0x60116F1")]
		[Address(RVA = "0x937E80", Offset = "0x936A80", VA = "0x180937E80")]
		private int <>xLuaBaseProxy_get_priorityQueue()
		{
			return 0;
		}

		// Token: 0x04013795 RID: 79765
		[Token(Token = "0x4013795")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_priorityQueue;

		// Token: 0x04013796 RID: 79766
		[Token(Token = "0x4013796")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoPreprocessEnemySkill;

		// Token: 0x04013797 RID: 79767
		[Token(Token = "0x4013797")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
