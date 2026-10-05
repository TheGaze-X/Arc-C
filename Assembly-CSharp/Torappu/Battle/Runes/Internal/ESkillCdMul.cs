using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x0200290B RID: 10507
	[Token(Token = "0x200290B")]
	public class ESkillCdMul : BasicEnemySkillRune
	{
		// Token: 0x17002687 RID: 9863
		// (get) Token: 0x060116E0 RID: 71392 RVA: 0x0006B358 File Offset: 0x00069558
		[Token(Token = "0x17002687")]
		public override int priorityQueue
		{
			[Token(Token = "0x60116E0")]
			[Address(RVA = "0x93BC50", Offset = "0x93A850", VA = "0x18093BC50", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060116E1 RID: 71393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116E1")]
		[Address(RVA = "0x93BB10", Offset = "0x93A710", VA = "0x18093BB10", Slot = "18")]
		protected override void DoPreprocessEnemySkill(LevelData.EnemyData.ESkillData skill, Enemy enemy)
		{
		}

		// Token: 0x060116E2 RID: 71394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116E2")]
		[Address(RVA = "0x93BBF0", Offset = "0x93A7F0", VA = "0x18093BBF0")]
		public ESkillCdMul()
		{
		}

		// Token: 0x060116E3 RID: 71395 RVA: 0x0006B370 File Offset: 0x00069570
		[Token(Token = "0x60116E3")]
		[Address(RVA = "0x937E80", Offset = "0x936A80", VA = "0x180937E80")]
		private int <>xLuaBaseProxy_get_priorityQueue()
		{
			return 0;
		}

		// Token: 0x0401378A RID: 79754
		[Token(Token = "0x401378A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_priorityQueue;

		// Token: 0x0401378B RID: 79755
		[Token(Token = "0x401378B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoPreprocessEnemySkill;

		// Token: 0x0401378C RID: 79756
		[Token(Token = "0x401378C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
