using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002456 RID: 9302
	[Token(Token = "0x2002456")]
	public class ContinuousSkill : CastSkill
	{
		// Token: 0x0600EF0A RID: 61194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF0A")]
		[Address(RVA = "0x66FDB0", Offset = "0x66E9B0", VA = "0x18066FDB0", Slot = "48")]
		public override void AssignData(SkillData data, Character owner, Blackboard externalBlackboard, UnitDataFlowConfig.Delta modifier)
		{
		}

		// Token: 0x0600EF0B RID: 61195 RVA: 0x00057F18 File Offset: 0x00056118
		[Token(Token = "0x600EF0B")]
		[Address(RVA = "0x66FEF0", Offset = "0x66EAF0", VA = "0x18066FEF0", Slot = "49")]
		protected override bool DoCast([Optional] Ability.FinishCallbackDelegate finishCb, PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EF0C RID: 61196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF0C")]
		[Address(RVA = "0x6700B0", Offset = "0x66ECB0", VA = "0x1806700B0", Slot = "74")]
		protected override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600EF0D RID: 61197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF0D")]
		[Address(RVA = "0x670330", Offset = "0x66EF30", VA = "0x180670330")]
		public ContinuousSkill()
		{
		}

		// Token: 0x0600EF0E RID: 61198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF0E")]
		[Address(RVA = "0x6432F0", Offset = "0x641EF0", VA = "0x1806432F0")]
		private void <>xLuaBaseProxy_AssignData(SkillData P0, Character P1, Blackboard P2, UnitDataFlowConfig.Delta P3)
		{
		}

		// Token: 0x0600EF0F RID: 61199 RVA: 0x00057F30 File Offset: 0x00056130
		[Token(Token = "0x600EF0F")]
		[Address(RVA = "0x641610", Offset = "0x640210", VA = "0x180641610")]
		private bool <>xLuaBaseProxy_DoCast(Ability.FinishCallbackDelegate P0, PlayerSide P1)
		{
			return default(bool);
		}

		// Token: 0x0600EF10 RID: 61200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF10")]
		[Address(RVA = "0x636850", Offset = "0x635450", VA = "0x180636850")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0401085A RID: 67674
		[Token(Token = "0x401085A")]
		private const float DEFAULT_SP_COST_PER_SEC = 1f;

		// Token: 0x0401085B RID: 67675
		[Token(Token = "0x401085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private PrecisePeriodicTimer m_spContinuousCostTimer;

		// Token: 0x0401085C RID: 67676
		[Token(Token = "0x401085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private FP m_spCostPerSpec;

		// Token: 0x0401085D RID: 67677
		[Token(Token = "0x401085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x0401085E RID: 67678
		[Token(Token = "0x401085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoCast;

		// Token: 0x0401085F RID: 67679
		[Token(Token = "0x401085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04010860 RID: 67680
		[Token(Token = "0x4010860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
