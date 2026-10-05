using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AFA RID: 11002
	[Token(Token = "0x2002AFA")]
	public class AbilityChargeableGroup : AbilityStandard, IChargeableAbilityCounter, IChargeableAbility, IMultiChargeUberEffectEmitterAbility, IChargeableSource
	{
		// Token: 0x1700284C RID: 10316
		// (get) Token: 0x06012617 RID: 75287 RVA: 0x00070878 File Offset: 0x0006EA78
		[Token(Token = "0x1700284C")]
		public override Ability.Category category
		{
			[Token(Token = "0x6012617")]
			[Address(RVA = "0xA643A0", Offset = "0xA62FA0", VA = "0x180A643A0", Slot = "13")]
			get
			{
				return Ability.Category.NONE;
			}
		}

		// Token: 0x1700284D RID: 10317
		// (get) Token: 0x06012618 RID: 75288 RVA: 0x00070890 File Offset: 0x0006EA90
		[Token(Token = "0x1700284D")]
		public override FP cooldown
		{
			[Token(Token = "0x6012618")]
			[Address(RVA = "0xA64400", Offset = "0xA63000", VA = "0x180A64400", Slot = "16")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x1700284E RID: 10318
		// (get) Token: 0x06012619 RID: 75289 RVA: 0x000708A8 File Offset: 0x0006EAA8
		[Token(Token = "0x1700284E")]
		public override bool isReady
		{
			[Token(Token = "0x6012619")]
			[Address(RVA = "0xA64480", Offset = "0xA63080", VA = "0x180A64480", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700284F RID: 10319
		// (get) Token: 0x0601261A RID: 75290 RVA: 0x000708C0 File Offset: 0x0006EAC0
		[Token(Token = "0x1700284F")]
		public override AbilityStandard.SelectTargetSource selectTargetSource
		{
			[Token(Token = "0x601261A")]
			[Address(RVA = "0xA644E0", Offset = "0xA630E0", VA = "0x180A644E0", Slot = "65")]
			get
			{
				return AbilityStandard.SelectTargetSource.NONE;
			}
		}

		// Token: 0x17002850 RID: 10320
		// (get) Token: 0x0601261B RID: 75291 RVA: 0x000708D8 File Offset: 0x0006EAD8
		[Token(Token = "0x17002850")]
		protected override bool alwaysIncludeTarget
		{
			[Token(Token = "0x601261B")]
			[Address(RVA = "0xA64340", Offset = "0xA62F40", VA = "0x180A64340", Slot = "67")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601261C RID: 75292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601261C")]
		[Address(RVA = "0xA63720", Offset = "0xA62320", VA = "0x180A63720", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x0601261D RID: 75293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601261D")]
		[Address(RVA = "0xA635A0", Offset = "0xA621A0", VA = "0x180A635A0", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x0601261E RID: 75294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601261E")]
		[Address(RVA = "0xA63670", Offset = "0xA62270", VA = "0x180A63670", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x0601261F RID: 75295 RVA: 0x000708F0 File Offset: 0x0006EAF0
		[Token(Token = "0x601261F")]
		[Address(RVA = "0xA633E0", Offset = "0xA61FE0", VA = "0x180A633E0", Slot = "32")]
		public override bool CastToTarget(Entity target, [Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x06012620 RID: 75296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012620")]
		[Address(RVA = "0xA63900", Offset = "0xA62500", VA = "0x180A63900", Slot = "99")]
		public void FinishAbility(Ability.FinishReason reason)
		{
		}

		// Token: 0x06012621 RID: 75297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012621")]
		[Address(RVA = "0xA63C40", Offset = "0xA62840", VA = "0x180A63C40", Slot = "96")]
		public void OnCastOnTargetBehaviours(Entity target)
		{
		}

		// Token: 0x06012622 RID: 75298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012622")]
		[Address(RVA = "0xA63A80", Offset = "0xA62680", VA = "0x180A63A80", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012623 RID: 75299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012623")]
		[Address(RVA = "0xA63BB0", Offset = "0xA627B0", VA = "0x180A63BB0", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x06012624 RID: 75300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012624")]
		[Address(RVA = "0xA63B50", Offset = "0xA62750", VA = "0x180A63B50", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x06012625 RID: 75301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012625")]
		[Address(RVA = "0xA639C0", Offset = "0xA625C0", VA = "0x180A639C0", Slot = "43")]
		public override IList<BuffData> GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x06012626 RID: 75302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012626")]
		[Address(RVA = "0xA63E90", Offset = "0xA62A90", VA = "0x180A63E90", Slot = "75")]
		protected override IEnumerator OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x06012627 RID: 75303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012627")]
		[Address(RVA = "0xA63E00", Offset = "0xA62A00", VA = "0x180A63E00", Slot = "76")]
		protected override IEnumerator OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x17002851 RID: 10321
		// (get) Token: 0x06012628 RID: 75304 RVA: 0x00070908 File Offset: 0x0006EB08
		[Token(Token = "0x17002851")]
		[Inspect]
		public bool IsFullCharge
		{
			[Token(Token = "0x6012628")]
			[Address(RVA = "0xA642D0", Offset = "0xA62ED0", VA = "0x180A642D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012629 RID: 75305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012629")]
		[Address(RVA = "0xA63530", Offset = "0xA62130", VA = "0x180A63530")]
		public void Charge(int times = 1)
		{
		}

		// Token: 0x0601262A RID: 75306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601262A")]
		[Address(RVA = "0xA64070", Offset = "0xA62C70", VA = "0x180A64070", Slot = "97")]
		public void SetChargeTimes(int times)
		{
		}

		// Token: 0x0601262B RID: 75307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601262B")]
		[Address(RVA = "0xA64130", Offset = "0xA62D30", VA = "0x180A64130", Slot = "98")]
		public void SetIsChargeAction(bool isChargeAction)
		{
		}

		// Token: 0x0601262C RID: 75308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601262C")]
		[Address(RVA = "0xA63D40", Offset = "0xA62940", VA = "0x180A63D40", Slot = "100")]
		public void OnChargeCastEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x0601262D RID: 75309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601262D")]
		[Address(RVA = "0xA63F20", Offset = "0xA62B20", VA = "0x180A63F20")]
		public void SetActivateAbility(Ability ability)
		{
		}

		// Token: 0x0601262E RID: 75310 RVA: 0x00070920 File Offset: 0x0006EB20
		[Token(Token = "0x601262E")]
		[Address(RVA = "0xA63A20", Offset = "0xA62620", VA = "0x180A63A20", Slot = "102")]
		public int GetChargeTimes()
		{
			return 0;
		}

		// Token: 0x0601262F RID: 75311 RVA: 0x00070938 File Offset: 0x0006EB38
		[Token(Token = "0x601262F")]
		[Address(RVA = "0xA63AF0", Offset = "0xA626F0", VA = "0x180A63AF0", Slot = "101")]
		public bool GetIsChargeAction()
		{
			return default(bool);
		}

		// Token: 0x06012630 RID: 75312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012630")]
		[Address(RVA = "0xA64270", Offset = "0xA62E70", VA = "0x180A64270")]
		public AbilityChargeableGroup()
		{
		}

		// Token: 0x06012631 RID: 75313 RVA: 0x00070950 File Offset: 0x0006EB50
		[Token(Token = "0x6012631")]
		[Address(RVA = "0xA38720", Offset = "0xA37320", VA = "0x180A38720")]
		private bool <>xLuaBaseProxy_get_isReady()
		{
			return default(bool);
		}

		// Token: 0x06012632 RID: 75314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012632")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012633 RID: 75315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012633")]
		[Address(RVA = "0xA64260", Offset = "0xA62E60", VA = "0x180A64260")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x06012634 RID: 75316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012634")]
		[Address(RVA = "0xA3C270", Offset = "0xA3AE70", VA = "0x180A3C270")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x06012635 RID: 75317 RVA: 0x00070968 File Offset: 0x0006EB68
		[Token(Token = "0x6012635")]
		[Address(RVA = "0xA38650", Offset = "0xA37250", VA = "0x180A38650")]
		private bool <>xLuaBaseProxy_CastToTarget(Entity P0, Ability.FinishCallbackDelegate P1, bool P2)
		{
			return default(bool);
		}

		// Token: 0x04014C94 RID: 85140
		[Token(Token = "0x4014C94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private int _maxChargeTimes;

		// Token: 0x04014C95 RID: 85141
		[Token(Token = "0x4014C95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Group("Abilities")]
		private AbilityStandard[] _abilities;

		// Token: 0x04014C96 RID: 85142
		[Token(Token = "0x4014C96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		[Group("Abilities")]
		private bool _feedData;

		// Token: 0x04014C97 RID: 85143
		[Token(Token = "0x4014C97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x121")]
		[SerializeField]
		[Group("Abilities")]
		private bool _attachAndDetach;

		// Token: 0x04014C98 RID: 85144
		[Token(Token = "0x4014C98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		private int m_chargeTimes;

		// Token: 0x04014C99 RID: 85145
		[Token(Token = "0x4014C99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		private int m_maxChargeTimes;

		// Token: 0x04014C9A RID: 85146
		[Token(Token = "0x4014C9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		private bool m_isChargeAction;

		// Token: 0x04014C9B RID: 85147
		[Token(Token = "0x4014C9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		private Ability m_activatedAbility;

		// Token: 0x04014C9C RID: 85148
		[Token(Token = "0x4014C9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		private IChargeableAbilityReactor m_activatedAbilityReactor;

		// Token: 0x04014C9D RID: 85149
		[Token(Token = "0x4014C9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x04014C9E RID: 85150
		[Token(Token = "0x4014C9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_cooldown;

		// Token: 0x04014C9F RID: 85151
		[Token(Token = "0x4014C9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isReady;

		// Token: 0x04014CA0 RID: 85152
		[Token(Token = "0x4014CA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_selectTargetSource;

		// Token: 0x04014CA1 RID: 85153
		[Token(Token = "0x4014CA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_alwaysIncludeTarget;

		// Token: 0x04014CA2 RID: 85154
		[Token(Token = "0x4014CA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014CA3 RID: 85155
		[Token(Token = "0x4014CA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04014CA4 RID: 85156
		[Token(Token = "0x4014CA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04014CA5 RID: 85157
		[Token(Token = "0x4014CA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CastToTarget;

		// Token: 0x04014CA6 RID: 85158
		[Token(Token = "0x4014CA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_FinishAbility;

		// Token: 0x04014CA7 RID: 85159
		[Token(Token = "0x4014CA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnCastOnTargetBehaviours;

		// Token: 0x04014CA8 RID: 85160
		[Token(Token = "0x4014CA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04014CA9 RID: 85161
		[Token(Token = "0x4014CA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04014CAA RID: 85162
		[Token(Token = "0x4014CAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x04014CAB RID: 85163
		[Token(Token = "0x4014CAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetActiveBuffs;

		// Token: 0x04014CAC RID: 85164
		[Token(Token = "0x4014CAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnWaitForPreDelay;

		// Token: 0x04014CAD RID: 85165
		[Token(Token = "0x4014CAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnWaitForPostDelay;

		// Token: 0x04014CAE RID: 85166
		[Token(Token = "0x4014CAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_IsFullCharge;

		// Token: 0x04014CAF RID: 85167
		[Token(Token = "0x4014CAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_Charge;

		// Token: 0x04014CB0 RID: 85168
		[Token(Token = "0x4014CB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_SetChargeTimes;

		// Token: 0x04014CB1 RID: 85169
		[Token(Token = "0x4014CB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_SetIsChargeAction;

		// Token: 0x04014CB2 RID: 85170
		[Token(Token = "0x4014CB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnChargeCastEvent;

		// Token: 0x04014CB3 RID: 85171
		[Token(Token = "0x4014CB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_SetActivateAbility;

		// Token: 0x04014CB4 RID: 85172
		[Token(Token = "0x4014CB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_GetChargeTimes;

		// Token: 0x04014CB5 RID: 85173
		[Token(Token = "0x4014CB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_GetIsChargeAction;

		// Token: 0x04014CB6 RID: 85174
		[Token(Token = "0x4014CB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
