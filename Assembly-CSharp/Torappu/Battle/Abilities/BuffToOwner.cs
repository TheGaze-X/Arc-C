using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BDE RID: 11230
	[Token(Token = "0x2002BDE")]
	public class BuffToOwner : AbilityStandard.Behaviour, IEffectSource, IBuffSource
	{
		// Token: 0x170029CE RID: 10702
		// (get) Token: 0x06012F6D RID: 77677 RVA: 0x00074310 File Offset: 0x00072510
		[Token(Token = "0x170029CE")]
		private bool ExtraConditionNotNone
		{
			[Token(Token = "0x6012F6D")]
			[Address(RVA = "0xADDDF0", Offset = "0xADC9F0", VA = "0x180ADDDF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170029CF RID: 10703
		// (get) Token: 0x06012F6E RID: 77678 RVA: 0x00074328 File Offset: 0x00072528
		[Token(Token = "0x170029CF")]
		private bool ExtraCondition1
		{
			[Token(Token = "0x6012F6E")]
			[Address(RVA = "0xADDD90", Offset = "0xADC990", VA = "0x180ADDD90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012F6F RID: 77679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F6F")]
		[Address(RVA = "0xADDA40", Offset = "0xADC640", VA = "0x180ADDA40", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x06012F70 RID: 77680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F70")]
		[Address(RVA = "0xADD820", Offset = "0xADC420", VA = "0x180ADD820", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06012F71 RID: 77681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F71")]
		[Address(RVA = "0xADDB10", Offset = "0xADC710", VA = "0x180ADDB10")]
		private void _AddBuffs()
		{
		}

		// Token: 0x06012F72 RID: 77682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F72")]
		[Address(RVA = "0xADD7C0", Offset = "0xADC3C0", VA = "0x180ADD7C0", Slot = "7")]
		public override void OnCastStart()
		{
		}

		// Token: 0x06012F73 RID: 77683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F73")]
		[Address(RVA = "0xADD6C0", Offset = "0xADC2C0", VA = "0x180ADD6C0", Slot = "17")]
		public void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x06012F74 RID: 77684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F74")]
		[Address(RVA = "0xADD750", Offset = "0xADC350", VA = "0x180ADD750", Slot = "16")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06012F75 RID: 77685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F75")]
		[Address(RVA = "0xADDCF0", Offset = "0xADC8F0", VA = "0x180ADDCF0")]
		public BuffToOwner()
		{
		}

		// Token: 0x06012F76 RID: 77686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F76")]
		[Address(RVA = "0xAC3250", Offset = "0xAC1E50", VA = "0x180AC3250")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x06012F77 RID: 77687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F77")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x06012F78 RID: 77688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F78")]
		[Address(RVA = "0xAC2A30", Offset = "0xAC1630", VA = "0x180AC2A30")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x0401567E RID: 87678
		[Token(Token = "0x401567E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuffToOwner.ExtraCondition _extraCondition;

		// Token: 0x0401567F RID: 87679
		[Token(Token = "0x401567F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Inspect("ExtraConditionNotNone")]
		private AbilityStandard.Event _extraConditionTiming;

		// Token: 0x04015680 RID: 87680
		[Token(Token = "0x4015680")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Inspect("ExtraCondition1")]
		private int _maxTarget;

		// Token: 0x04015681 RID: 87681
		[Token(Token = "0x4015681")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool _loadMaxTargetFromBlackboard;

		// Token: 0x04015682 RID: 87682
		[Token(Token = "0x4015682")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AbilityStandard.Event _runActionOnEvent;

		// Token: 0x04015683 RID: 87683
		[Token(Token = "0x4015683")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BuffData[] _buffs;

		// Token: 0x04015684 RID: 87684
		[Token(Token = "0x4015684")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _onlyRunOnce;

		// Token: 0x04015685 RID: 87685
		[Token(Token = "0x4015685")]
		[FieldOffset(Offset = "0x41")]
		private bool m_run;

		// Token: 0x04015686 RID: 87686
		[Token(Token = "0x4015686")]
		[FieldOffset(Offset = "0x44")]
		private int m_maxTargetNum;

		// Token: 0x04015687 RID: 87687
		[Token(Token = "0x4015687")]
		[FieldOffset(Offset = "0x48")]
		private bool m_extraConditionFlag;

		// Token: 0x04015688 RID: 87688
		[Token(Token = "0x4015688")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_ExtraConditionNotNone;

		// Token: 0x04015689 RID: 87689
		[Token(Token = "0x4015689")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_ExtraCondition1;

		// Token: 0x0401568A RID: 87690
		[Token(Token = "0x401568A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0401568B RID: 87691
		[Token(Token = "0x401568B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x0401568C RID: 87692
		[Token(Token = "0x401568C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__AddBuffs;

		// Token: 0x0401568D RID: 87693
		[Token(Token = "0x401568D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x0401568E RID: 87694
		[Token(Token = "0x401568E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x0401568F RID: 87695
		[Token(Token = "0x401568F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04015690 RID: 87696
		[Token(Token = "0x4015690")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002BDF RID: 11231
		[Token(Token = "0x2002BDF")]
		private enum ExtraCondition
		{
			// Token: 0x04015692 RID: 87698
			[Token(Token = "0x4015692")]
			NONE,
			// Token: 0x04015693 RID: 87699
			[Token(Token = "0x4015693")]
			VALID_CAST_TARGETS_LESS_THAN_MAX_TARGET,
			// Token: 0x04015694 RID: 87700
			[Token(Token = "0x4015694")]
			DISABLE_OVERRIDE_BUFF
		}
	}
}
