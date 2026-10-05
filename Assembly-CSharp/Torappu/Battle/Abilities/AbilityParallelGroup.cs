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
	// Token: 0x02002B03 RID: 11011
	[Token(Token = "0x2002B03")]
	public class AbilityParallelGroup : AbilityStandard
	{
		// Token: 0x1700286A RID: 10346
		// (get) Token: 0x06012690 RID: 75408 RVA: 0x00070C20 File Offset: 0x0006EE20
		[Token(Token = "0x1700286A")]
		public bool finishAllAbilitiesIfOneFinish
		{
			[Token(Token = "0x6012690")]
			[Address(RVA = "0xA67E80", Offset = "0xA66A80", VA = "0x180A67E80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700286B RID: 10347
		// (get) Token: 0x06012691 RID: 75409 RVA: 0x00070C38 File Offset: 0x0006EE38
		[Token(Token = "0x1700286B")]
		public override bool isAffecting
		{
			[Token(Token = "0x6012691")]
			[Address(RVA = "0xA67EE0", Offset = "0xA66AE0", VA = "0x180A67EE0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700286C RID: 10348
		// (get) Token: 0x06012692 RID: 75410 RVA: 0x00070C50 File Offset: 0x0006EE50
		[Token(Token = "0x1700286C")]
		public override FP cooldown
		{
			[Token(Token = "0x6012692")]
			[Address(RVA = "0xA67D10", Offset = "0xA66910", VA = "0x180A67D10", Slot = "16")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x1700286D RID: 10349
		// (get) Token: 0x06012693 RID: 75411 RVA: 0x00070C68 File Offset: 0x0006EE68
		[Token(Token = "0x1700286D")]
		public override FP escapeTime
		{
			[Token(Token = "0x6012693")]
			[Address(RVA = "0xA67E20", Offset = "0xA66A20", VA = "0x180A67E20", Slot = "21")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x1700286E RID: 10350
		// (get) Token: 0x06012694 RID: 75412 RVA: 0x00070C80 File Offset: 0x0006EE80
		[Token(Token = "0x1700286E")]
		public override Ability.Category category
		{
			[Token(Token = "0x6012694")]
			[Address(RVA = "0xA67CB0", Offset = "0xA668B0", VA = "0x180A67CB0", Slot = "13")]
			get
			{
				return Ability.Category.NONE;
			}
		}

		// Token: 0x1700286F RID: 10351
		// (get) Token: 0x06012695 RID: 75413 RVA: 0x00070C98 File Offset: 0x0006EE98
		[Token(Token = "0x1700286F")]
		public override AbilityStandard.SelectTargetSource selectTargetSource
		{
			[Token(Token = "0x6012695")]
			[Address(RVA = "0xA67FF0", Offset = "0xA66BF0", VA = "0x180A67FF0", Slot = "65")]
			get
			{
				return AbilityStandard.SelectTargetSource.NONE;
			}
		}

		// Token: 0x17002870 RID: 10352
		// (get) Token: 0x06012696 RID: 75414 RVA: 0x00070CB0 File Offset: 0x0006EEB0
		[Token(Token = "0x17002870")]
		protected override bool alwaysIncludeTarget
		{
			[Token(Token = "0x6012696")]
			[Address(RVA = "0xA67C50", Offset = "0xA66850", VA = "0x180A67C50", Slot = "67")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012697 RID: 75415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012697")]
		[Address(RVA = "0xA67350", Offset = "0xA65F50", VA = "0x180A67350", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012698 RID: 75416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012698")]
		[Address(RVA = "0xA67420", Offset = "0xA66020", VA = "0x180A67420", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x06012699 RID: 75417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012699")]
		[Address(RVA = "0xA673C0", Offset = "0xA65FC0", VA = "0x180A673C0", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x0601269A RID: 75418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601269A")]
		[Address(RVA = "0xA672F0", Offset = "0xA65EF0", VA = "0x180A672F0", Slot = "43")]
		public override IList<BuffData> GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x0601269B RID: 75419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601269B")]
		[Address(RVA = "0xA67710", Offset = "0xA66310", VA = "0x180A67710", Slot = "75")]
		protected override IEnumerator OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x0601269C RID: 75420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601269C")]
		[Address(RVA = "0xA67680", Offset = "0xA66280", VA = "0x180A67680", Slot = "76")]
		protected override IEnumerator OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x0601269D RID: 75421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601269D")]
		[Address(RVA = "0xA66F90", Offset = "0xA65B90", VA = "0x180A66F90", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x0601269E RID: 75422 RVA: 0x00070CC8 File Offset: 0x0006EEC8
		[Token(Token = "0x601269E")]
		[Address(RVA = "0xA669E0", Offset = "0xA655E0", VA = "0x180A669E0", Slot = "32")]
		public override bool CastToTarget(Entity target, [Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x0601269F RID: 75423 RVA: 0x00070CE0 File Offset: 0x0006EEE0
		[Token(Token = "0x601269F")]
		[Address(RVA = "0xA66730", Offset = "0xA65330", VA = "0x180A66730", Slot = "33")]
		public override bool CastDirectly([Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x060126A0 RID: 75424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60126A0")]
		[Address(RVA = "0xA66D80", Offset = "0xA65980", VA = "0x180A66D80", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x060126A1 RID: 75425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60126A1")]
		[Address(RVA = "0xA66ED0", Offset = "0xA65AD0", VA = "0x180A66ED0", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x060126A2 RID: 75426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60126A2")]
		[Address(RVA = "0xA67550", Offset = "0xA66150", VA = "0x180A67550", Slot = "51")]
		protected override void OnCastEnd(Ability.FinishReason reason)
		{
		}

		// Token: 0x060126A3 RID: 75427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60126A3")]
		[Address(RVA = "0xA665E0", Offset = "0xA651E0", VA = "0x180A665E0", Slot = "95")]
		protected override void Awake()
		{
		}

		// Token: 0x060126A4 RID: 75428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60126A4")]
		[Address(RVA = "0xA67990", Offset = "0xA66590", VA = "0x180A67990")]
		private void _OnSubAbilityFinished(Ability ability, Ability.FinishReason reason, bool resetCd)
		{
		}

		// Token: 0x060126A5 RID: 75429 RVA: 0x00070CF8 File Offset: 0x0006EEF8
		[Token(Token = "0x60126A5")]
		[Address(RVA = "0xA66C90", Offset = "0xA65890", VA = "0x180A66C90", Slot = "59")]
		public override bool CheckAtPreCastPhase()
		{
			return default(bool);
		}

		// Token: 0x060126A6 RID: 75430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60126A6")]
		[Address(RVA = "0xA677A0", Offset = "0xA663A0", VA = "0x180A677A0", Slot = "58")]
		public override void PreloadSpecialAudioSignals(string abilityId, string tmplId, Action<string, string> preloader)
		{
		}

		// Token: 0x060126A7 RID: 75431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60126A7")]
		[Address(RVA = "0xA674B0", Offset = "0xA660B0", VA = "0x180A674B0", Slot = "56")]
		public override void OnAttackTimeChanged(FP newValue)
		{
		}

		// Token: 0x060126A8 RID: 75432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60126A8")]
		[Address(RVA = "0xA67B80", Offset = "0xA66780", VA = "0x180A67B80")]
		public AbilityParallelGroup()
		{
		}

		// Token: 0x060126A9 RID: 75433 RVA: 0x00070D10 File Offset: 0x0006EF10
		[Token(Token = "0x60126A9")]
		[Address(RVA = "0xA4D200", Offset = "0xA4BE00", VA = "0x180A4D200")]
		private bool <>xLuaBaseProxy_get_isAffecting()
		{
			return default(bool);
		}

		// Token: 0x060126AA RID: 75434 RVA: 0x00070D28 File Offset: 0x0006EF28
		[Token(Token = "0x60126AA")]
		[Address(RVA = "0xA4D1F0", Offset = "0xA4BDF0", VA = "0x180A4D1F0")]
		private FP <>xLuaBaseProxy_get_escapeTime()
		{
			return default(FP);
		}

		// Token: 0x060126AB RID: 75435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60126AB")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x060126AC RID: 75436 RVA: 0x00070D40 File Offset: 0x0006EF40
		[Token(Token = "0x60126AC")]
		[Address(RVA = "0xA38650", Offset = "0xA37250", VA = "0x180A38650")]
		private bool <>xLuaBaseProxy_CastToTarget(Entity P0, Ability.FinishCallbackDelegate P1, bool P2)
		{
			return default(bool);
		}

		// Token: 0x060126AD RID: 75437 RVA: 0x00070D58 File Offset: 0x0006EF58
		[Token(Token = "0x60126AD")]
		[Address(RVA = "0xA225E0", Offset = "0xA211E0", VA = "0x180A225E0")]
		private bool <>xLuaBaseProxy_CastDirectly(Ability.FinishCallbackDelegate P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x060126AE RID: 75438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60126AE")]
		[Address(RVA = "0xA64260", Offset = "0xA62E60", VA = "0x180A64260")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x060126AF RID: 75439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60126AF")]
		[Address(RVA = "0xA3C270", Offset = "0xA3AE70", VA = "0x180A3C270")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x060126B0 RID: 75440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60126B0")]
		[Address(RVA = "0xA66030", Offset = "0xA64C30", VA = "0x180A66030")]
		private void <>xLuaBaseProxy_OnCastEnd(Ability.FinishReason P0)
		{
		}

		// Token: 0x060126B1 RID: 75441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60126B1")]
		[Address(RVA = "0xA4FF40", Offset = "0xA4EB40", VA = "0x180A4FF40")]
		private void <>xLuaBaseProxy_Awake()
		{
		}

		// Token: 0x060126B2 RID: 75442 RVA: 0x00070D70 File Offset: 0x0006EF70
		[Token(Token = "0x60126B2")]
		[Address(RVA = "0xA67980", Offset = "0xA66580", VA = "0x180A67980")]
		private bool <>xLuaBaseProxy_CheckAtPreCastPhase()
		{
			return default(bool);
		}

		// Token: 0x060126B3 RID: 75443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60126B3")]
		[Address(RVA = "0xA66040", Offset = "0xA64C40", VA = "0x180A66040")]
		private void <>xLuaBaseProxy_PreloadSpecialAudioSignals(string P0, string P1, Action<string, string> P2)
		{
		}

		// Token: 0x060126B4 RID: 75444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60126B4")]
		[Address(RVA = "0xA66020", Offset = "0xA64C20", VA = "0x180A66020")]
		private void <>xLuaBaseProxy_OnAttackTimeChanged(FP P0)
		{
		}

		// Token: 0x04014CFB RID: 85243
		[Token(Token = "0x4014CFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		protected Ability[] _abilities;

		// Token: 0x04014CFC RID: 85244
		[Token(Token = "0x4014CFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Ability.Category m_category;

		// Token: 0x04014CFD RID: 85245
		[Token(Token = "0x4014CFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private FP m_cooldown;

		// Token: 0x04014CFE RID: 85246
		[Token(Token = "0x4014CFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private int m_remainingJobCnt;

		// Token: 0x04014CFF RID: 85247
		[Token(Token = "0x4014CFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private int m_jobCntThisTime;

		// Token: 0x04014D00 RID: 85248
		[Token(Token = "0x4014D00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		private bool _alsoInterruptSubAbilities;

		// Token: 0x04014D01 RID: 85249
		[Token(Token = "0x4014D01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x131")]
		[SerializeField]
		private bool _useEscaptime;

		// Token: 0x04014D02 RID: 85250
		[Token(Token = "0x4014D02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x132")]
		[SerializeField]
		private bool _alsoCheckChildrenAffecting;

		// Token: 0x04014D03 RID: 85251
		[Token(Token = "0x4014D03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x133")]
		[SerializeField]
		private bool _finishAllAbilitiesIfOneFinish;

		// Token: 0x04014D04 RID: 85252
		[Token(Token = "0x4014D04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		[Inspect("finishAllAbilitiesIfOneFinish")]
		private Ability _mainAbility;

		// Token: 0x04014D05 RID: 85253
		[Token(Token = "0x4014D05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		private AbstractAnimatedAbility.TimeMode _timeMode;

		// Token: 0x04014D06 RID: 85254
		[Token(Token = "0x4014D06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private FP m_escapeTime;

		// Token: 0x04014D07 RID: 85255
		[Token(Token = "0x4014D07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_finishAllAbilitiesIfOneFinish;

		// Token: 0x04014D08 RID: 85256
		[Token(Token = "0x4014D08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isAffecting;

		// Token: 0x04014D09 RID: 85257
		[Token(Token = "0x4014D09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_cooldown;

		// Token: 0x04014D0A RID: 85258
		[Token(Token = "0x4014D0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_escapeTime;

		// Token: 0x04014D0B RID: 85259
		[Token(Token = "0x4014D0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x04014D0C RID: 85260
		[Token(Token = "0x4014D0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_selectTargetSource;

		// Token: 0x04014D0D RID: 85261
		[Token(Token = "0x4014D0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_alwaysIncludeTarget;

		// Token: 0x04014D0E RID: 85262
		[Token(Token = "0x4014D0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04014D0F RID: 85263
		[Token(Token = "0x4014D0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04014D10 RID: 85264
		[Token(Token = "0x4014D10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x04014D11 RID: 85265
		[Token(Token = "0x4014D11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetActiveBuffs;

		// Token: 0x04014D12 RID: 85266
		[Token(Token = "0x4014D12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnWaitForPreDelay;

		// Token: 0x04014D13 RID: 85267
		[Token(Token = "0x4014D13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnWaitForPostDelay;

		// Token: 0x04014D14 RID: 85268
		[Token(Token = "0x4014D14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014D15 RID: 85269
		[Token(Token = "0x4014D15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_CastToTarget;

		// Token: 0x04014D16 RID: 85270
		[Token(Token = "0x4014D16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_CastDirectly;

		// Token: 0x04014D17 RID: 85271
		[Token(Token = "0x4014D17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04014D18 RID: 85272
		[Token(Token = "0x4014D18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04014D19 RID: 85273
		[Token(Token = "0x4014D19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnCastEnd;

		// Token: 0x04014D1A RID: 85274
		[Token(Token = "0x4014D1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04014D1B RID: 85275
		[Token(Token = "0x4014D1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnSubAbilityFinished;

		// Token: 0x04014D1C RID: 85276
		[Token(Token = "0x4014D1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_CheckAtPreCastPhase;

		// Token: 0x04014D1D RID: 85277
		[Token(Token = "0x4014D1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_PreloadSpecialAudioSignals;

		// Token: 0x04014D1E RID: 85278
		[Token(Token = "0x4014D1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnAttackTimeChanged;

		// Token: 0x04014D1F RID: 85279
		[Token(Token = "0x4014D1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
