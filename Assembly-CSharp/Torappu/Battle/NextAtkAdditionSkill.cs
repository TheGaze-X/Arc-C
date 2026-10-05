using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002459 RID: 9305
	[Token(Token = "0x2002459")]
	public class NextAtkAdditionSkill : NextAttackOrCombatSkill
	{
		// Token: 0x0600EF31 RID: 61233 RVA: 0x00058020 File Offset: 0x00056220
		[Token(Token = "0x600EF31")]
		[Address(RVA = "0x6760B0", Offset = "0x674CB0", VA = "0x1806760B0", Slot = "80")]
		protected override bool CheckIfToModify(Ability atkOrCbt, bool isCombat)
		{
			return default(bool);
		}

		// Token: 0x0600EF32 RID: 61234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF32")]
		[Address(RVA = "0x675EF0", Offset = "0x674AF0", VA = "0x180675EF0", Slot = "81")]
		protected override void ApplyModification()
		{
		}

		// Token: 0x0600EF33 RID: 61235 RVA: 0x00058038 File Offset: 0x00056238
		[Token(Token = "0x600EF33")]
		[Address(RVA = "0x675FE0", Offset = "0x674BE0", VA = "0x180675FE0", Slot = "82")]
		protected override bool CancelAfterAttack(Ability atkOrCbt, bool isCombat, Ability.FinishReason reason)
		{
			return default(bool);
		}

		// Token: 0x0600EF34 RID: 61236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF34")]
		[Address(RVA = "0x676160", Offset = "0x674D60", VA = "0x180676160")]
		public NextAtkAdditionSkill()
		{
		}

		// Token: 0x04010889 RID: 67721
		[Token(Token = "0x4010889")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckIfToModify;

		// Token: 0x0401088A RID: 67722
		[Token(Token = "0x401088A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ApplyModification;

		// Token: 0x0401088B RID: 67723
		[Token(Token = "0x401088B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CancelAfterAttack;

		// Token: 0x0401088C RID: 67724
		[Token(Token = "0x401088C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
