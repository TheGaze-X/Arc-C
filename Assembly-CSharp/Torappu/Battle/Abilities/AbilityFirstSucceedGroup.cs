using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B00 RID: 11008
	[Token(Token = "0x2002B00")]
	public class AbilityFirstSucceedGroup : AbilityStandard
	{
		// Token: 0x1700285F RID: 10335
		// (get) Token: 0x06012662 RID: 75362 RVA: 0x00070AB8 File Offset: 0x0006ECB8
		[Token(Token = "0x1700285F")]
		public override Ability.Category category
		{
			[Token(Token = "0x6012662")]
			[Address(RVA = "0xA66330", Offset = "0xA64F30", VA = "0x180A66330", Slot = "13")]
			get
			{
				return Ability.Category.NONE;
			}
		}

		// Token: 0x17002860 RID: 10336
		// (get) Token: 0x06012663 RID: 75363 RVA: 0x00070AD0 File Offset: 0x0006ECD0
		[Token(Token = "0x17002860")]
		public override AbilityStandard.SelectTargetSource selectTargetSource
		{
			[Token(Token = "0x6012663")]
			[Address(RVA = "0xA66580", Offset = "0xA65180", VA = "0x180A66580", Slot = "65")]
			get
			{
				return AbilityStandard.SelectTargetSource.NONE;
			}
		}

		// Token: 0x17002861 RID: 10337
		// (get) Token: 0x06012664 RID: 75364 RVA: 0x00070AE8 File Offset: 0x0006ECE8
		[Token(Token = "0x17002861")]
		public override FP cooldown
		{
			[Token(Token = "0x6012664")]
			[Address(RVA = "0xA66390", Offset = "0xA64F90", VA = "0x180A66390", Slot = "16")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17002862 RID: 10338
		// (get) Token: 0x06012665 RID: 75365 RVA: 0x00070B00 File Offset: 0x0006ED00
		[Token(Token = "0x17002862")]
		public override FP escapeTime
		{
			[Token(Token = "0x6012665")]
			[Address(RVA = "0xA663F0", Offset = "0xA64FF0", VA = "0x180A663F0", Slot = "21")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17002863 RID: 10339
		// (get) Token: 0x06012666 RID: 75366 RVA: 0x00070B18 File Offset: 0x0006ED18
		[Token(Token = "0x17002863")]
		protected override bool alwaysIncludeTarget
		{
			[Token(Token = "0x6012666")]
			[Address(RVA = "0xA662D0", Offset = "0xA64ED0", VA = "0x180A662D0", Slot = "67")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002864 RID: 10340
		// (get) Token: 0x06012667 RID: 75367 RVA: 0x00070B30 File Offset: 0x0006ED30
		[Token(Token = "0x17002864")]
		public override bool isAffecting
		{
			[Token(Token = "0x6012667")]
			[Address(RVA = "0xA66450", Offset = "0xA65050", VA = "0x180A66450", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002865 RID: 10341
		// (get) Token: 0x06012668 RID: 75368 RVA: 0x00070B48 File Offset: 0x0006ED48
		[Token(Token = "0x17002865")]
		public bool needUpdateAttackTime
		{
			[Token(Token = "0x6012668")]
			[Address(RVA = "0xA66510", Offset = "0xA65110", VA = "0x180A66510")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012669 RID: 75369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012669")]
		[Address(RVA = "0xA658D0", Offset = "0xA644D0", VA = "0x180A658D0", Slot = "43")]
		public override IList<BuffData> GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x0601266A RID: 75370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601266A")]
		[Address(RVA = "0xA65A00", Offset = "0xA64600", VA = "0x180A65A00", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x0601266B RID: 75371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601266B")]
		[Address(RVA = "0xA65930", Offset = "0xA64530", VA = "0x180A65930", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x0601266C RID: 75372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601266C")]
		[Address(RVA = "0xA659A0", Offset = "0xA645A0", VA = "0x180A659A0", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x0601266D RID: 75373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601266D")]
		[Address(RVA = "0xA65590", Offset = "0xA64190", VA = "0x180A65590", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x0601266E RID: 75374 RVA: 0x00070B60 File Offset: 0x0006ED60
		[Token(Token = "0x601266E")]
		[Address(RVA = "0xA65180", Offset = "0xA63D80", VA = "0x180A65180", Slot = "32")]
		public override bool CastToTarget(Entity target, [Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x0601266F RID: 75375 RVA: 0x00070B78 File Offset: 0x0006ED78
		[Token(Token = "0x601266F")]
		[Address(RVA = "0xA64FA0", Offset = "0xA63BA0", VA = "0x180A64FA0", Slot = "33")]
		public override bool CastDirectly([Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x06012670 RID: 75376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012670")]
		[Address(RVA = "0xA65360", Offset = "0xA63F60", VA = "0x180A65360", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x06012671 RID: 75377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012671")]
		[Address(RVA = "0xA654D0", Offset = "0xA640D0", VA = "0x180A654D0", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x06012672 RID: 75378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012672")]
		[Address(RVA = "0xA65DB0", Offset = "0xA649B0", VA = "0x180A65DB0", Slot = "75")]
		protected override IEnumerator OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x06012673 RID: 75379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012673")]
		[Address(RVA = "0xA65D20", Offset = "0xA64920", VA = "0x180A65D20", Slot = "76")]
		protected override IEnumerator OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x06012674 RID: 75380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012674")]
		[Address(RVA = "0xA65B70", Offset = "0xA64770", VA = "0x180A65B70", Slot = "51")]
		protected override void OnCastEnd(Ability.FinishReason reason)
		{
		}

		// Token: 0x06012675 RID: 75381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012675")]
		[Address(RVA = "0xA65A90", Offset = "0xA64690", VA = "0x180A65A90", Slot = "56")]
		public override void OnAttackTimeChanged(FP newValue)
		{
		}

		// Token: 0x06012676 RID: 75382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012676")]
		[Address(RVA = "0xA66130", Offset = "0xA64D30", VA = "0x180A66130")]
		private void _OnSubAbilityFinished(Ability ability, Ability.FinishReason reason, bool resetCd)
		{
		}

		// Token: 0x06012677 RID: 75383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012677")]
		[Address(RVA = "0xA66050", Offset = "0xA64C50", VA = "0x180A66050")]
		private void _OnSubAbilityCasted(int abilityIndex)
		{
		}

		// Token: 0x06012678 RID: 75384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012678")]
		[Address(RVA = "0xA65E40", Offset = "0xA64A40", VA = "0x180A65E40", Slot = "58")]
		public override void PreloadSpecialAudioSignals(string abilityId, string tmplId, Action<string, string> preloader)
		{
		}

		// Token: 0x06012679 RID: 75385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012679")]
		[Address(RVA = "0xA661F0", Offset = "0xA64DF0", VA = "0x180A661F0")]
		public AbilityFirstSucceedGroup()
		{
		}

		// Token: 0x0601267A RID: 75386 RVA: 0x00070B90 File Offset: 0x0006ED90
		[Token(Token = "0x601267A")]
		[Address(RVA = "0xA4D1F0", Offset = "0xA4BDF0", VA = "0x180A4D1F0")]
		private FP <>xLuaBaseProxy_get_escapeTime()
		{
			return default(FP);
		}

		// Token: 0x0601267B RID: 75387 RVA: 0x00070BA8 File Offset: 0x0006EDA8
		[Token(Token = "0x601267B")]
		[Address(RVA = "0xA4D200", Offset = "0xA4BE00", VA = "0x180A4D200")]
		private bool <>xLuaBaseProxy_get_isAffecting()
		{
			return default(bool);
		}

		// Token: 0x0601267C RID: 75388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601267C")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x0601267D RID: 75389 RVA: 0x00070BC0 File Offset: 0x0006EDC0
		[Token(Token = "0x601267D")]
		[Address(RVA = "0xA38650", Offset = "0xA37250", VA = "0x180A38650")]
		private bool <>xLuaBaseProxy_CastToTarget(Entity P0, Ability.FinishCallbackDelegate P1, bool P2)
		{
			return default(bool);
		}

		// Token: 0x0601267E RID: 75390 RVA: 0x00070BD8 File Offset: 0x0006EDD8
		[Token(Token = "0x601267E")]
		[Address(RVA = "0xA225E0", Offset = "0xA211E0", VA = "0x180A225E0")]
		private bool <>xLuaBaseProxy_CastDirectly(Ability.FinishCallbackDelegate P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x0601267F RID: 75391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601267F")]
		[Address(RVA = "0xA64260", Offset = "0xA62E60", VA = "0x180A64260")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x06012680 RID: 75392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012680")]
		[Address(RVA = "0xA3C270", Offset = "0xA3AE70", VA = "0x180A3C270")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x06012681 RID: 75393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012681")]
		[Address(RVA = "0xA66030", Offset = "0xA64C30", VA = "0x180A66030")]
		private void <>xLuaBaseProxy_OnCastEnd(Ability.FinishReason P0)
		{
		}

		// Token: 0x06012682 RID: 75394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012682")]
		[Address(RVA = "0xA66020", Offset = "0xA64C20", VA = "0x180A66020")]
		private void <>xLuaBaseProxy_OnAttackTimeChanged(FP P0)
		{
		}

		// Token: 0x06012683 RID: 75395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012683")]
		[Address(RVA = "0xA66040", Offset = "0xA64C40", VA = "0x180A66040")]
		private void <>xLuaBaseProxy_PreloadSpecialAudioSignals(string P0, string P1, Action<string, string> P2)
		{
		}

		// Token: 0x04014CD4 RID: 85204
		[Token(Token = "0x4014CD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Ability.Category _category;

		// Token: 0x04014CD5 RID: 85205
		[Token(Token = "0x4014CD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		[SerializeField]
		private int _coolDownAbilityIndex;

		// Token: 0x04014CD6 RID: 85206
		[Token(Token = "0x4014CD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private bool _fixAffectingAbilityParam;

		// Token: 0x04014CD7 RID: 85207
		[Token(Token = "0x4014CD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x119")]
		[SerializeField]
		private bool _alsoInterruptCurrentSubAbility;

		// Token: 0x04014CD8 RID: 85208
		[Token(Token = "0x4014CD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11A")]
		[SerializeField]
		private bool _clearInternalCooldownWhenFinish;

		// Token: 0x04014CD9 RID: 85209
		[Token(Token = "0x4014CD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11B")]
		[SerializeField]
		private bool _useEscaptime;

		// Token: 0x04014CDA RID: 85210
		[Token(Token = "0x4014CDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private Ability[] _abilities;

		// Token: 0x04014CDB RID: 85211
		[Token(Token = "0x4014CDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		private AbstractAnimatedAbility.TimeMode _timeMode;

		// Token: 0x04014CDC RID: 85212
		[Token(Token = "0x4014CDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private FP m_cooldown;

		// Token: 0x04014CDD RID: 85213
		[Token(Token = "0x4014CDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private FP m_escapeTime;

		// Token: 0x04014CDE RID: 85214
		[Token(Token = "0x4014CDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private int m_affectingAbilityIndex;

		// Token: 0x04014CDF RID: 85215
		[Token(Token = "0x4014CDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x04014CE0 RID: 85216
		[Token(Token = "0x4014CE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_selectTargetSource;

		// Token: 0x04014CE1 RID: 85217
		[Token(Token = "0x4014CE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_cooldown;

		// Token: 0x04014CE2 RID: 85218
		[Token(Token = "0x4014CE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_escapeTime;

		// Token: 0x04014CE3 RID: 85219
		[Token(Token = "0x4014CE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_alwaysIncludeTarget;

		// Token: 0x04014CE4 RID: 85220
		[Token(Token = "0x4014CE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isAffecting;

		// Token: 0x04014CE5 RID: 85221
		[Token(Token = "0x4014CE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_needUpdateAttackTime;

		// Token: 0x04014CE6 RID: 85222
		[Token(Token = "0x4014CE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetActiveBuffs;

		// Token: 0x04014CE7 RID: 85223
		[Token(Token = "0x4014CE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04014CE8 RID: 85224
		[Token(Token = "0x4014CE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04014CE9 RID: 85225
		[Token(Token = "0x4014CE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x04014CEA RID: 85226
		[Token(Token = "0x4014CEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014CEB RID: 85227
		[Token(Token = "0x4014CEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CastToTarget;

		// Token: 0x04014CEC RID: 85228
		[Token(Token = "0x4014CEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CastDirectly;

		// Token: 0x04014CED RID: 85229
		[Token(Token = "0x4014CED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04014CEE RID: 85230
		[Token(Token = "0x4014CEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04014CEF RID: 85231
		[Token(Token = "0x4014CEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnWaitForPreDelay;

		// Token: 0x04014CF0 RID: 85232
		[Token(Token = "0x4014CF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnWaitForPostDelay;

		// Token: 0x04014CF1 RID: 85233
		[Token(Token = "0x4014CF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnCastEnd;

		// Token: 0x04014CF2 RID: 85234
		[Token(Token = "0x4014CF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnAttackTimeChanged;

		// Token: 0x04014CF3 RID: 85235
		[Token(Token = "0x4014CF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnSubAbilityFinished;

		// Token: 0x04014CF4 RID: 85236
		[Token(Token = "0x4014CF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnSubAbilityCasted;

		// Token: 0x04014CF5 RID: 85237
		[Token(Token = "0x4014CF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_PreloadSpecialAudioSignals;

		// Token: 0x04014CF6 RID: 85238
		[Token(Token = "0x4014CF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
