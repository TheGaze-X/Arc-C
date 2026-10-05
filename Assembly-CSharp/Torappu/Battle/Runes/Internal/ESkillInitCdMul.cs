using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x0200290D RID: 10509
	[Token(Token = "0x200290D")]
	public class ESkillInitCdMul : BasicEnemySkillRune
	{
		// Token: 0x17002689 RID: 9865
		// (get) Token: 0x060116E8 RID: 71400 RVA: 0x0006B3B8 File Offset: 0x000695B8
		[Token(Token = "0x17002689")]
		public override int priorityQueue
		{
			[Token(Token = "0x60116E8")]
			[Address(RVA = "0x93BF30", Offset = "0x93AB30", VA = "0x18093BF30", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060116E9 RID: 71401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116E9")]
		[Address(RVA = "0x93BDF0", Offset = "0x93A9F0", VA = "0x18093BDF0", Slot = "18")]
		protected override void DoPreprocessEnemySkill(LevelData.EnemyData.ESkillData skill, Enemy enemy)
		{
		}

		// Token: 0x060116EA RID: 71402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116EA")]
		[Address(RVA = "0x93BED0", Offset = "0x93AAD0", VA = "0x18093BED0")]
		public ESkillInitCdMul()
		{
		}

		// Token: 0x060116EB RID: 71403 RVA: 0x0006B3D0 File Offset: 0x000695D0
		[Token(Token = "0x60116EB")]
		[Address(RVA = "0x937E80", Offset = "0x936A80", VA = "0x180937E80")]
		private int <>xLuaBaseProxy_get_priorityQueue()
		{
			return 0;
		}

		// Token: 0x04013790 RID: 79760
		[Token(Token = "0x4013790")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_priorityQueue;

		// Token: 0x04013791 RID: 79761
		[Token(Token = "0x4013791")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoPreprocessEnemySkill;

		// Token: 0x04013792 RID: 79762
		[Token(Token = "0x4013792")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
