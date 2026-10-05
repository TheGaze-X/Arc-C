using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BA4 RID: 11172
	[Token(Token = "0x2002BA4")]
	public class LegionModeGlobalAuraAbility : LegionModeAbility
	{
		// Token: 0x17002995 RID: 10645
		// (get) Token: 0x06012D61 RID: 77153 RVA: 0x00073608 File Offset: 0x00071808
		[Token(Token = "0x17002995")]
		private bool removeBuffWhenAbilityDetached
		{
			[Token(Token = "0x6012D61")]
			[Address(RVA = "0xAC1900", Offset = "0xAC0500", VA = "0x180AC1900")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012D62 RID: 77154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D62")]
		[Address(RVA = "0xABFF50", Offset = "0xABEB50", VA = "0x180ABFF50", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012D63 RID: 77155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D63")]
		[Address(RVA = "0xABF880", Offset = "0xABE480", VA = "0x180ABF880", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x06012D64 RID: 77156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D64")]
		[Address(RVA = "0xAC02F0", Offset = "0xABEEF0", VA = "0x180AC02F0", Slot = "96")]
		protected override void UpdateBlackboard()
		{
		}

		// Token: 0x06012D65 RID: 77157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D65")]
		[Address(RVA = "0xABFC40", Offset = "0xABE840", VA = "0x180ABFC40", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x06012D66 RID: 77158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D66")]
		[Address(RVA = "0xAC0050", Offset = "0xABEC50", VA = "0x180AC0050", Slot = "49")]
		public override void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x06012D67 RID: 77159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D67")]
		[Address(RVA = "0xAC0890", Offset = "0xABF490", VA = "0x180AC0890")]
		private void _ClearBuffs()
		{
		}

		// Token: 0x06012D68 RID: 77160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D68")]
		[Address(RVA = "0xAC10E0", Offset = "0xABFCE0", VA = "0x180AC10E0")]
		private void _OnMapLayerChanged(object arg)
		{
		}

		// Token: 0x06012D69 RID: 77161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D69")]
		[Address(RVA = "0xAC01D0", Offset = "0xABEDD0", VA = "0x180AC01D0", Slot = "97")]
		public override void RefreshLegionBuff()
		{
		}

		// Token: 0x06012D6A RID: 77162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012D6A")]
		[Address(RVA = "0xAC0F10", Offset = "0xABFB10", VA = "0x180AC0F10")]
		private IList<BuffData> _GetBuffs()
		{
			return null;
		}

		// Token: 0x06012D6B RID: 77163 RVA: 0x00073620 File Offset: 0x00071820
		[Token(Token = "0x6012D6B")]
		[Address(RVA = "0xAC0BC0", Offset = "0xABF7C0", VA = "0x180AC0BC0")]
		private bool _DealTarget(Entity target)
		{
			return default(bool);
		}

		// Token: 0x06012D6C RID: 77164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D6C")]
		[Address(RVA = "0xAC1640", Offset = "0xAC0240", VA = "0x180AC1640")]
		private void _OnUnitBornOrRallyPointReborn(object arg)
		{
		}

		// Token: 0x06012D6D RID: 77165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D6D")]
		[Address(RVA = "0xAC11E0", Offset = "0xABFDE0", VA = "0x180AC11E0")]
		private void _OnRallyPointDead(object arg)
		{
		}

		// Token: 0x06012D6E RID: 77166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D6E")]
		[Address(RVA = "0xAC1410", Offset = "0xAC0010", VA = "0x180AC1410")]
		private void _OnRallyPointLikeSwitch(object arg)
		{
		}

		// Token: 0x06012D6F RID: 77167 RVA: 0x00073638 File Offset: 0x00071838
		[Token(Token = "0x6012D6F")]
		[Address(RVA = "0xAC0790", Offset = "0xABF390", VA = "0x180AC0790", Slot = "98")]
		protected virtual bool VerityTarget(Entity target)
		{
			return default(bool);
		}

		// Token: 0x06012D70 RID: 77168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D70")]
		[Address(RVA = "0xAC17D0", Offset = "0xAC03D0", VA = "0x180AC17D0")]
		public LegionModeGlobalAuraAbility()
		{
		}

		// Token: 0x06012D71 RID: 77169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D71")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012D72 RID: 77170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D72")]
		[Address(RVA = "0xA64260", Offset = "0xA62E60", VA = "0x180A64260")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x06012D73 RID: 77171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D73")]
		[Address(RVA = "0xABEED0", Offset = "0xABDAD0", VA = "0x180ABEED0")]
		private void <>xLuaBaseProxy_UpdateBlackboard()
		{
		}

		// Token: 0x06012D74 RID: 77172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D74")]
		[Address(RVA = "0xA3C270", Offset = "0xA3AE70", VA = "0x180A3C270")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x06012D75 RID: 77173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D75")]
		[Address(RVA = "0xA56960", Offset = "0xA55560", VA = "0x180A56960")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x06012D76 RID: 77174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D76")]
		[Address(RVA = "0xABD960", Offset = "0xABC560", VA = "0x180ABD960")]
		private void <>xLuaBaseProxy_RefreshLegionBuff()
		{
		}

		// Token: 0x04015417 RID: 87063
		[Token(Token = "0x4015417")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		[Help("HelpAttribute.IsValueNull", HelpType.Error, "Must specified a validator.")]
		private TargetValidator _targetValidator;

		// Token: 0x04015418 RID: 87064
		[Token(Token = "0x4015418")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private AuraAbility.SelfOption _selfOption;

		// Token: 0x04015419 RID: 87065
		[Token(Token = "0x4015419")]
		[FieldOffset(Offset = "0x144")]
		[SerializeField]
		private bool _removeBuffWhenAbilityDetached;

		// Token: 0x0401541A RID: 87066
		[Token(Token = "0x401541A")]
		[FieldOffset(Offset = "0x145")]
		[SerializeField]
		[Inspect("removeBuffWhenAbilityDetached")]
		private bool _removeBuffIncludeReborning;

		// Token: 0x0401541B RID: 87067
		[Token(Token = "0x401541B")]
		[FieldOffset(Offset = "0x146")]
		[SerializeField]
		private bool _onlyDetectTargetWhenStarted;

		// Token: 0x0401541C RID: 87068
		[Token(Token = "0x401541C")]
		[FieldOffset(Offset = "0x147")]
		[SerializeField]
		private bool _onlyDetectCurrentMapLayer;

		// Token: 0x0401541D RID: 87069
		[Token(Token = "0x401541D")]
		[FieldOffset(Offset = "0x148")]
		private Dictionary<ObjectPtr<Entity>, List<uint>> m_targetMap;

		// Token: 0x0401541E RID: 87070
		[Token(Token = "0x401541E")]
		[FieldOffset(Offset = "0x150")]
		private List<ObjectPtr<Entity>> m_targetList;

		// Token: 0x0401541F RID: 87071
		[Token(Token = "0x401541F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_removeBuffWhenAbilityDetached;

		// Token: 0x04015420 RID: 87072
		[Token(Token = "0x4015420")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04015421 RID: 87073
		[Token(Token = "0x4015421")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04015422 RID: 87074
		[Token(Token = "0x4015422")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateBlackboard;

		// Token: 0x04015423 RID: 87075
		[Token(Token = "0x4015423")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04015424 RID: 87076
		[Token(Token = "0x4015424")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x04015425 RID: 87077
		[Token(Token = "0x4015425")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ClearBuffs;

		// Token: 0x04015426 RID: 87078
		[Token(Token = "0x4015426")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnMapLayerChanged;

		// Token: 0x04015427 RID: 87079
		[Token(Token = "0x4015427")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RefreshLegionBuff;

		// Token: 0x04015428 RID: 87080
		[Token(Token = "0x4015428")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetBuffs;

		// Token: 0x04015429 RID: 87081
		[Token(Token = "0x4015429")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__DealTarget;

		// Token: 0x0401542A RID: 87082
		[Token(Token = "0x401542A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnUnitBornOrRallyPointReborn;

		// Token: 0x0401542B RID: 87083
		[Token(Token = "0x401542B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnRallyPointDead;

		// Token: 0x0401542C RID: 87084
		[Token(Token = "0x401542C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnRallyPointLikeSwitch;

		// Token: 0x0401542D RID: 87085
		[Token(Token = "0x401542D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_VerityTarget;

		// Token: 0x0401542E RID: 87086
		[Token(Token = "0x401542E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
