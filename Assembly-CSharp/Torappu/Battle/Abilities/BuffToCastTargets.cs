using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BDC RID: 11228
	[Token(Token = "0x2002BDC")]
	public class BuffToCastTargets : AbilityStandard.Behaviour, IEffectSource, IBuffSource
	{
		// Token: 0x170029CA RID: 10698
		// (get) Token: 0x06012F5C RID: 77660 RVA: 0x000742B0 File Offset: 0x000724B0
		[Token(Token = "0x170029CA")]
		private bool NotFilterTypeAll
		{
			[Token(Token = "0x6012F5C")]
			[Address(RVA = "0xADCF40", Offset = "0xADBB40", VA = "0x180ADCF40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170029CB RID: 10699
		// (get) Token: 0x06012F5D RID: 77661 RVA: 0x000742C8 File Offset: 0x000724C8
		[Token(Token = "0x170029CB")]
		private bool NotFilterTypeAllAndLimitTargetNum
		{
			[Token(Token = "0x6012F5D")]
			[Address(RVA = "0xADCED0", Offset = "0xADBAD0", VA = "0x180ADCED0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170029CC RID: 10700
		// (get) Token: 0x06012F5E RID: 77662 RVA: 0x000742E0 File Offset: 0x000724E0
		[Token(Token = "0x170029CC")]
		private bool castTargetsEqualToOne
		{
			[Token(Token = "0x6012F5E")]
			[Address(RVA = "0xADCFA0", Offset = "0xADBBA0", VA = "0x180ADCFA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170029CD RID: 10701
		// (get) Token: 0x06012F5F RID: 77663 RVA: 0x000742F8 File Offset: 0x000724F8
		[Token(Token = "0x170029CD")]
		private bool clearBuffWhenChangeTarget
		{
			[Token(Token = "0x6012F5F")]
			[Address(RVA = "0xADD000", Offset = "0xADBC00", VA = "0x180ADD000")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012F60 RID: 77664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F60")]
		[Address(RVA = "0xADCAC0", Offset = "0xADB6C0", VA = "0x180ADCAC0", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x06012F61 RID: 77665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F61")]
		[Address(RVA = "0xADC7E0", Offset = "0xADB3E0", VA = "0x180ADC7E0", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06012F62 RID: 77666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F62")]
		[Address(RVA = "0xADC490", Offset = "0xADB090", VA = "0x180ADC490", Slot = "11")]
		public override void OnCastOnTarget(Entity target)
		{
		}

		// Token: 0x06012F63 RID: 77667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F63")]
		[Address(RVA = "0xADC400", Offset = "0xADB000", VA = "0x180ADC400", Slot = "9")]
		public override void OnCastFinish(Ability.FinishReason reason)
		{
		}

		// Token: 0x06012F64 RID: 77668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F64")]
		[Address(RVA = "0xADC300", Offset = "0xADAF00", VA = "0x180ADC300", Slot = "17")]
		public void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x06012F65 RID: 77669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F65")]
		[Address(RVA = "0xADC390", Offset = "0xADAF90", VA = "0x180ADC390", Slot = "16")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06012F66 RID: 77670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F66")]
		[Address(RVA = "0xADCB80", Offset = "0xADB780", VA = "0x180ADCB80")]
		private void _RemoveLastTargetBuffsAndClear()
		{
		}

		// Token: 0x06012F67 RID: 77671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F67")]
		[Address(RVA = "0xADCCC0", Offset = "0xADB8C0", VA = "0x180ADCCC0")]
		private void _ResetTarget(Entity target)
		{
		}

		// Token: 0x06012F68 RID: 77672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F68")]
		[Address(RVA = "0xADCDE0", Offset = "0xADB9E0", VA = "0x180ADCDE0")]
		public BuffToCastTargets()
		{
		}

		// Token: 0x06012F69 RID: 77673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F69")]
		[Address(RVA = "0xAC3250", Offset = "0xAC1E50", VA = "0x180AC3250")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x06012F6A RID: 77674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F6A")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x06012F6B RID: 77675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F6B")]
		[Address(RVA = "0xAC48F0", Offset = "0xAC34F0", VA = "0x180AC48F0")]
		private void <>xLuaBaseProxy_OnCastOnTarget(Entity P0)
		{
		}

		// Token: 0x06012F6C RID: 77676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F6C")]
		[Address(RVA = "0xAC3FE0", Offset = "0xAC2BE0", VA = "0x180AC3FE0")]
		private void <>xLuaBaseProxy_OnCastFinish(Ability.FinishReason P0)
		{
		}

		// Token: 0x04015663 RID: 87651
		[Token(Token = "0x4015663")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Inspect("NotFilterTypeAll")]
		private bool _limitTargetNum;

		// Token: 0x04015664 RID: 87652
		[Token(Token = "0x4015664")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Inspect("NotFilterTypeAllAndLimitTargetNum")]
		private int _maxNum;

		// Token: 0x04015665 RID: 87653
		[Token(Token = "0x4015665")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private FilterUtil.FilterType _postFilter;

		// Token: 0x04015666 RID: 87654
		[Token(Token = "0x4015666")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private BuffToCastTargets.ExtraCondition _extraCondition;

		// Token: 0x04015667 RID: 87655
		[Token(Token = "0x4015667")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _clearBuffWhenChangeTarget;

		// Token: 0x04015668 RID: 87656
		[Token(Token = "0x4015668")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		[Inspect("clearBuffWhenChangeTarget")]
		private bool _alsoClearBuffWhenCastInterrupted;

		// Token: 0x04015669 RID: 87657
		[Token(Token = "0x4015669")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BuffData[] _buffs;

		// Token: 0x0401566A RID: 87658
		[Token(Token = "0x401566A")]
		[FieldOffset(Offset = "0x40")]
		private int m_maxTargetNum;

		// Token: 0x0401566B RID: 87659
		[Token(Token = "0x401566B")]
		[FieldOffset(Offset = "0x48")]
		private readonly List<Entity> m_validCastTargets;

		// Token: 0x0401566C RID: 87660
		[Token(Token = "0x401566C")]
		[FieldOffset(Offset = "0x50")]
		private ObjectPtr<Entity> m_lastTarget;

		// Token: 0x0401566D RID: 87661
		[Token(Token = "0x401566D")]
		[FieldOffset(Offset = "0x60")]
		private List<uint> m_lastTargetBuffUids;

		// Token: 0x0401566E RID: 87662
		[Token(Token = "0x401566E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_NotFilterTypeAll;

		// Token: 0x0401566F RID: 87663
		[Token(Token = "0x401566F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_NotFilterTypeAllAndLimitTargetNum;

		// Token: 0x04015670 RID: 87664
		[Token(Token = "0x4015670")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_castTargetsEqualToOne;

		// Token: 0x04015671 RID: 87665
		[Token(Token = "0x4015671")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_clearBuffWhenChangeTarget;

		// Token: 0x04015672 RID: 87666
		[Token(Token = "0x4015672")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04015673 RID: 87667
		[Token(Token = "0x4015673")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x04015674 RID: 87668
		[Token(Token = "0x4015674")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnCastOnTarget;

		// Token: 0x04015675 RID: 87669
		[Token(Token = "0x4015675")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnCastFinish;

		// Token: 0x04015676 RID: 87670
		[Token(Token = "0x4015676")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x04015677 RID: 87671
		[Token(Token = "0x4015677")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04015678 RID: 87672
		[Token(Token = "0x4015678")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RemoveLastTargetBuffsAndClear;

		// Token: 0x04015679 RID: 87673
		[Token(Token = "0x4015679")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ResetTarget;

		// Token: 0x0401567A RID: 87674
		[Token(Token = "0x401567A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002BDD RID: 11229
		[Token(Token = "0x2002BDD")]
		public enum ExtraCondition
		{
			// Token: 0x0401567C RID: 87676
			[Token(Token = "0x401567C")]
			NONE,
			// Token: 0x0401567D RID: 87677
			[Token(Token = "0x401567D")]
			VALID_CAST_TARGETS_EQUAL_TO_ONE
		}
	}
}
