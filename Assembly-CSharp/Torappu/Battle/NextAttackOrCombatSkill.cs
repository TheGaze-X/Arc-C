using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200245A RID: 9306
	[Token(Token = "0x200245A")]
	public abstract class NextAttackOrCombatSkill : BasicSkill
	{
		// Token: 0x17001F09 RID: 7945
		// (get) Token: 0x0600EF35 RID: 61237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F09")]
		public TargetTrigger trigger
		{
			[Token(Token = "0x600EF35")]
			[Address(RVA = "0x676AC0", Offset = "0x6756C0", VA = "0x180676AC0", Slot = "79")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F0A RID: 7946
		// (get) Token: 0x0600EF36 RID: 61238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F0A")]
		public override IDrawableRange rangeToShow
		{
			[Token(Token = "0x600EF36")]
			[Address(RVA = "0x676980", Offset = "0x675580", VA = "0x180676980", Slot = "36")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600EF37 RID: 61239
		[Token(Token = "0x600EF37")]
		protected abstract bool CheckIfToModify(Ability atkOrCbt, bool isCombat);

		// Token: 0x0600EF38 RID: 61240
		[Token(Token = "0x600EF38")]
		protected abstract void ApplyModification();

		// Token: 0x0600EF39 RID: 61241
		[Token(Token = "0x600EF39")]
		protected abstract bool CancelAfterAttack(Ability atkOrCbt, bool isCombat, Ability.FinishReason reason);

		// Token: 0x0600EF3A RID: 61242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF3A")]
		[Address(RVA = "0x676200", Offset = "0x674E00", VA = "0x180676200", Slot = "48")]
		public override void AssignData(SkillData data, Character owner, Blackboard externalBlackboard, UnitDataFlowConfig.Delta modifier)
		{
		}

		// Token: 0x0600EF3B RID: 61243 RVA: 0x00058050 File Offset: 0x00056250
		[Token(Token = "0x600EF3B")]
		[Address(RVA = "0x676660", Offset = "0x675260", VA = "0x180676660", Slot = "64")]
		public override bool OnBeforeAttack(Ability oldAbility, bool isCombat)
		{
			return default(bool);
		}

		// Token: 0x0600EF3C RID: 61244 RVA: 0x00058068 File Offset: 0x00056268
		[Token(Token = "0x600EF3C")]
		[Address(RVA = "0x6768B0", Offset = "0x6754B0", VA = "0x1806768B0", Slot = "51")]
		public override bool UseSkill(PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EF3D RID: 61245 RVA: 0x00058080 File Offset: 0x00056280
		[Token(Token = "0x600EF3D")]
		[Address(RVA = "0x676350", Offset = "0x674F50", VA = "0x180676350", Slot = "49")]
		protected override bool DoCast(Ability.FinishCallbackDelegate finishCb, PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EF3E RID: 61246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF3E")]
		[Address(RVA = "0x676570", Offset = "0x675170", VA = "0x180676570", Slot = "65")]
		public override void OnAfterAttack(Ability oldAbility, bool isCombat, Ability.FinishReason reason)
		{
		}

		// Token: 0x0600EF3F RID: 61247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF3F")]
		[Address(RVA = "0x676800", Offset = "0x675400", VA = "0x180676800", Slot = "74")]
		protected override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600EF40 RID: 61248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF40")]
		[Address(RVA = "0x676440", Offset = "0x675040", VA = "0x180676440", Slot = "83")]
		protected virtual void DoTick()
		{
		}

		// Token: 0x0600EF41 RID: 61249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF41")]
		[Address(RVA = "0x676920", Offset = "0x675520", VA = "0x180676920")]
		protected NextAttackOrCombatSkill()
		{
		}

		// Token: 0x0600EF42 RID: 61250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EF42")]
		[Address(RVA = "0x6462D0", Offset = "0x644ED0", VA = "0x1806462D0")]
		private IDrawableRange <>xLuaBaseProxy_get_rangeToShow()
		{
			return null;
		}

		// Token: 0x0600EF43 RID: 61251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF43")]
		[Address(RVA = "0x635EA0", Offset = "0x634AA0", VA = "0x180635EA0")]
		private void <>xLuaBaseProxy_AssignData(SkillData P0, Character P1, Blackboard P2, UnitDataFlowConfig.Delta P3)
		{
		}

		// Token: 0x0600EF44 RID: 61252 RVA: 0x00058098 File Offset: 0x00056298
		[Token(Token = "0x600EF44")]
		[Address(RVA = "0x640380", Offset = "0x63EF80", VA = "0x180640380")]
		private bool <>xLuaBaseProxy_OnBeforeAttack(Ability P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x0600EF45 RID: 61253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF45")]
		[Address(RVA = "0x6768A0", Offset = "0x6754A0", VA = "0x1806768A0")]
		private void <>xLuaBaseProxy_OnAfterAttack(Ability P0, bool P1, Ability.FinishReason P2)
		{
		}

		// Token: 0x0600EF46 RID: 61254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF46")]
		[Address(RVA = "0x635F00", Offset = "0x634B00", VA = "0x180635F00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0401088D RID: 67725
		[Token(Token = "0x401088D")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private TargetTrigger _trigger;

		// Token: 0x0401088E RID: 67726
		[Token(Token = "0x401088E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_trigger;

		// Token: 0x0401088F RID: 67727
		[Token(Token = "0x401088F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_rangeToShow;

		// Token: 0x04010890 RID: 67728
		[Token(Token = "0x4010890")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x04010891 RID: 67729
		[Token(Token = "0x4010891")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBeforeAttack;

		// Token: 0x04010892 RID: 67730
		[Token(Token = "0x4010892")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UseSkill;

		// Token: 0x04010893 RID: 67731
		[Token(Token = "0x4010893")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoCast;

		// Token: 0x04010894 RID: 67732
		[Token(Token = "0x4010894")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnAfterAttack;

		// Token: 0x04010895 RID: 67733
		[Token(Token = "0x4010895")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04010896 RID: 67734
		[Token(Token = "0x4010896")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_DoTick;

		// Token: 0x04010897 RID: 67735
		[Token(Token = "0x4010897")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
