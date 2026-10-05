using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x0200290C RID: 10508
	[Token(Token = "0x200290C")]
	public class ESkillSpCostAdd : BasicEnemySkillRune
	{
		// Token: 0x17002688 RID: 9864
		// (get) Token: 0x060116E4 RID: 71396 RVA: 0x0006B388 File Offset: 0x00069588
		[Token(Token = "0x17002688")]
		public override int priorityQueue
		{
			[Token(Token = "0x60116E4")]
			[Address(RVA = "0x93C320", Offset = "0x93AF20", VA = "0x18093C320", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060116E5 RID: 71397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116E5")]
		[Address(RVA = "0x93C1F0", Offset = "0x93ADF0", VA = "0x18093C1F0", Slot = "18")]
		protected override void DoPreprocessEnemySkill(LevelData.EnemyData.ESkillData skill, Enemy enemy)
		{
		}

		// Token: 0x060116E6 RID: 71398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116E6")]
		[Address(RVA = "0x93C2C0", Offset = "0x93AEC0", VA = "0x18093C2C0")]
		public ESkillSpCostAdd()
		{
		}

		// Token: 0x060116E7 RID: 71399 RVA: 0x0006B3A0 File Offset: 0x000695A0
		[Token(Token = "0x60116E7")]
		[Address(RVA = "0x937E80", Offset = "0x936A80", VA = "0x180937E80")]
		private int <>xLuaBaseProxy_get_priorityQueue()
		{
			return 0;
		}

		// Token: 0x0401378D RID: 79757
		[Token(Token = "0x401378D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_priorityQueue;

		// Token: 0x0401378E RID: 79758
		[Token(Token = "0x401378E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoPreprocessEnemySkill;

		// Token: 0x0401378F RID: 79759
		[Token(Token = "0x401378F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
