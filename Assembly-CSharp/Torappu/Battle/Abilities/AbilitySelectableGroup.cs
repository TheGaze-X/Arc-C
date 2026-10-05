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
	// Token: 0x02002B76 RID: 11126
	[Token(Token = "0x2002B76")]
	public class AbilitySelectableGroup : AbilityStandard
	{
		// Token: 0x17002922 RID: 10530
		// (get) Token: 0x06012AF2 RID: 76530 RVA: 0x000727B0 File Offset: 0x000709B0
		[Token(Token = "0x17002922")]
		private bool useSubAbilityEscapeTime
		{
			[Token(Token = "0x6012AF2")]
			[Address(RVA = "0xA95AF0", Offset = "0xA946F0", VA = "0x180A95AF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002923 RID: 10531
		// (get) Token: 0x06012AF3 RID: 76531 RVA: 0x000727C8 File Offset: 0x000709C8
		[Token(Token = "0x17002923")]
		public override FP escapeTime
		{
			[Token(Token = "0x6012AF3")]
			[Address(RVA = "0xA958F0", Offset = "0xA944F0", VA = "0x180A958F0", Slot = "21")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17002924 RID: 10532
		// (get) Token: 0x06012AF4 RID: 76532 RVA: 0x000727E0 File Offset: 0x000709E0
		[Token(Token = "0x17002924")]
		public override Ability.Category category
		{
			[Token(Token = "0x6012AF4")]
			[Address(RVA = "0xA95830", Offset = "0xA94430", VA = "0x180A95830", Slot = "13")]
			get
			{
				return Ability.Category.NONE;
			}
		}

		// Token: 0x17002925 RID: 10533
		// (get) Token: 0x06012AF5 RID: 76533 RVA: 0x000727F8 File Offset: 0x000709F8
		[Token(Token = "0x17002925")]
		public override AbilityStandard.SelectTargetSource selectTargetSource
		{
			[Token(Token = "0x6012AF5")]
			[Address(RVA = "0xA95A90", Offset = "0xA94690", VA = "0x180A95A90", Slot = "65")]
			get
			{
				return AbilityStandard.SelectTargetSource.NONE;
			}
		}

		// Token: 0x17002926 RID: 10534
		// (get) Token: 0x06012AF6 RID: 76534 RVA: 0x00072810 File Offset: 0x00070A10
		[Token(Token = "0x17002926")]
		public override FP cooldown
		{
			[Token(Token = "0x6012AF6")]
			[Address(RVA = "0xA95890", Offset = "0xA94490", VA = "0x180A95890", Slot = "16")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17002927 RID: 10535
		// (get) Token: 0x06012AF7 RID: 76535 RVA: 0x00072828 File Offset: 0x00070A28
		[Token(Token = "0x17002927")]
		protected override bool alwaysIncludeTarget
		{
			[Token(Token = "0x6012AF7")]
			[Address(RVA = "0xA957D0", Offset = "0xA943D0", VA = "0x180A957D0", Slot = "67")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002928 RID: 10536
		// (get) Token: 0x06012AF8 RID: 76536 RVA: 0x00072840 File Offset: 0x00070A40
		[Token(Token = "0x17002928")]
		public bool needUpdateAttackTime
		{
			[Token(Token = "0x6012AF8")]
			[Address(RVA = "0xA95A20", Offset = "0xA94620", VA = "0x180A95A20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002929 RID: 10537
		// (get) Token: 0x06012AF9 RID: 76537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002929")]
		public AbilitySelectableGroup.AbilityConfigs[] UBPGetConfigs
		{
			[Token(Token = "0x6012AF9")]
			[Address(RVA = "0xA95770", Offset = "0xA94370", VA = "0x180A95770")]
			get
			{
				return null;
			}
		}

		// Token: 0x06012AFA RID: 76538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012AFA")]
		[Address(RVA = "0xA94480", Offset = "0xA93080", VA = "0x180A94480", Slot = "43")]
		public override IList<BuffData> GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x06012AFB RID: 76539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012AFB")]
		[Address(RVA = "0xA945B0", Offset = "0xA931B0", VA = "0x180A945B0", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x06012AFC RID: 76540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012AFC")]
		[Address(RVA = "0xA944E0", Offset = "0xA930E0", VA = "0x180A944E0", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012AFD RID: 76541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012AFD")]
		[Address(RVA = "0xA94550", Offset = "0xA93150", VA = "0x180A94550", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x06012AFE RID: 76542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012AFE")]
		[Address(RVA = "0xA95010", Offset = "0xA93C10", VA = "0x180A95010", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x06012AFF RID: 76543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012AFF")]
		[Address(RVA = "0xA94160", Offset = "0xA92D60", VA = "0x180A94160", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012B00 RID: 76544 RVA: 0x00072858 File Offset: 0x00070A58
		[Token(Token = "0x6012B00")]
		[Address(RVA = "0xA93D50", Offset = "0xA92950", VA = "0x180A93D50", Slot = "32")]
		public override bool CastToTarget(Entity target, [Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x06012B01 RID: 76545 RVA: 0x00072870 File Offset: 0x00070A70
		[Token(Token = "0x6012B01")]
		[Address(RVA = "0xA93CB0", Offset = "0xA928B0", VA = "0x180A93CB0", Slot = "33")]
		public override bool CastDirectly([Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x06012B02 RID: 76546 RVA: 0x00072888 File Offset: 0x00070A88
		[Token(Token = "0x6012B02")]
		[Address(RVA = "0xA950E0", Offset = "0xA93CE0", VA = "0x180A950E0")]
		private bool _DoCastInternal(bool isCastToTarget, [Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true, [Optional] Entity target)
		{
			return default(bool);
		}

		// Token: 0x06012B03 RID: 76547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B03")]
		[Address(RVA = "0xA94E20", Offset = "0xA93A20", VA = "0x180A94E20", Slot = "37")]
		public override void ResetCooldown(bool waitFirstPeriod)
		{
		}

		// Token: 0x06012B04 RID: 76548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B04")]
		[Address(RVA = "0xA93EC0", Offset = "0xA92AC0", VA = "0x180A93EC0", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x06012B05 RID: 76549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B05")]
		[Address(RVA = "0xA94070", Offset = "0xA92C70", VA = "0x180A94070", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x06012B06 RID: 76550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012B06")]
		[Address(RVA = "0xA94BB0", Offset = "0xA937B0", VA = "0x180A94BB0", Slot = "75")]
		protected override IEnumerator OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x06012B07 RID: 76551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012B07")]
		[Address(RVA = "0xA94B20", Offset = "0xA93720", VA = "0x180A94B20", Slot = "76")]
		protected override IEnumerator OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x06012B08 RID: 76552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B08")]
		[Address(RVA = "0xA94950", Offset = "0xA93550", VA = "0x180A94950", Slot = "51")]
		protected override void OnCastEnd(Ability.FinishReason reason)
		{
		}

		// Token: 0x06012B09 RID: 76553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B09")]
		[Address(RVA = "0xA947C0", Offset = "0xA933C0", VA = "0x180A947C0", Slot = "56")]
		public override void OnAttackTimeChanged(FP newValue)
		{
		}

		// Token: 0x06012B0A RID: 76554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B0A")]
		[Address(RVA = "0xA94640", Offset = "0xA93240", VA = "0x180A94640", Slot = "57")]
		public override void OnAbilityExtendUpdated(FP extend)
		{
		}

		// Token: 0x06012B0B RID: 76555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B0B")]
		[Address(RVA = "0xA95550", Offset = "0xA94150", VA = "0x180A95550")]
		private void _OnSubAbilityFinished(Ability ability, Ability.FinishReason reason, bool resetCd)
		{
		}

		// Token: 0x06012B0C RID: 76556 RVA: 0x000728A0 File Offset: 0x00070AA0
		[Token(Token = "0x6012B0C")]
		[Address(RVA = "0xA93DF0", Offset = "0xA929F0", VA = "0x180A93DF0", Slot = "59")]
		public override bool CheckAtPreCastPhase()
		{
			return default(bool);
		}

		// Token: 0x06012B0D RID: 76557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B0D")]
		[Address(RVA = "0xA94C40", Offset = "0xA93840", VA = "0x180A94C40", Slot = "58")]
		public override void PreloadSpecialAudioSignals(string abilityId, string tmplId, Action<string, string> preloader)
		{
		}

		// Token: 0x06012B0E RID: 76558 RVA: 0x000728B8 File Offset: 0x00070AB8
		[Token(Token = "0x6012B0E")]
		[Address(RVA = "0xA95480", Offset = "0xA94080", VA = "0x180A95480")]
		private bool _IsFirstAttack(int currentAbilityIndex, bool isFirstAttack)
		{
			return default(bool);
		}

		// Token: 0x06012B0F RID: 76559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B0F")]
		[Address(RVA = "0xA95610", Offset = "0xA94210", VA = "0x180A95610")]
		private void _SyncCooldownOnCastStartByOption()
		{
		}

		// Token: 0x06012B10 RID: 76560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B10")]
		[Address(RVA = "0xA95700", Offset = "0xA94300", VA = "0x180A95700")]
		public AbilitySelectableGroup()
		{
		}

		// Token: 0x06012B11 RID: 76561 RVA: 0x000728D0 File Offset: 0x00070AD0
		[Token(Token = "0x6012B11")]
		[Address(RVA = "0xA4D1F0", Offset = "0xA4BDF0", VA = "0x180A4D1F0")]
		private FP <>xLuaBaseProxy_get_escapeTime()
		{
			return default(FP);
		}

		// Token: 0x06012B12 RID: 76562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B12")]
		[Address(RVA = "0xA4B0B0", Offset = "0xA49CB0", VA = "0x180A4B0B0")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x06012B13 RID: 76563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B13")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012B14 RID: 76564 RVA: 0x000728E8 File Offset: 0x00070AE8
		[Token(Token = "0x6012B14")]
		[Address(RVA = "0xA38650", Offset = "0xA37250", VA = "0x180A38650")]
		private bool <>xLuaBaseProxy_CastToTarget(Entity P0, Ability.FinishCallbackDelegate P1, bool P2)
		{
			return default(bool);
		}

		// Token: 0x06012B15 RID: 76565 RVA: 0x00072900 File Offset: 0x00070B00
		[Token(Token = "0x6012B15")]
		[Address(RVA = "0xA225E0", Offset = "0xA211E0", VA = "0x180A225E0")]
		private bool <>xLuaBaseProxy_CastDirectly(Ability.FinishCallbackDelegate P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x06012B16 RID: 76566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B16")]
		[Address(RVA = "0xA6BF30", Offset = "0xA6AB30", VA = "0x180A6BF30")]
		private void <>xLuaBaseProxy_ResetCooldown(bool P0)
		{
		}

		// Token: 0x06012B17 RID: 76567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B17")]
		[Address(RVA = "0xA64260", Offset = "0xA62E60", VA = "0x180A64260")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x06012B18 RID: 76568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B18")]
		[Address(RVA = "0xA3C270", Offset = "0xA3AE70", VA = "0x180A3C270")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x06012B19 RID: 76569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B19")]
		[Address(RVA = "0xA66030", Offset = "0xA64C30", VA = "0x180A66030")]
		private void <>xLuaBaseProxy_OnCastEnd(Ability.FinishReason P0)
		{
		}

		// Token: 0x06012B1A RID: 76570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B1A")]
		[Address(RVA = "0xA66020", Offset = "0xA64C20", VA = "0x180A66020")]
		private void <>xLuaBaseProxy_OnAttackTimeChanged(FP P0)
		{
		}

		// Token: 0x06012B1B RID: 76571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B1B")]
		[Address(RVA = "0xA718F0", Offset = "0xA704F0", VA = "0x180A718F0")]
		private void <>xLuaBaseProxy_OnAbilityExtendUpdated(FP P0)
		{
		}

		// Token: 0x06012B1C RID: 76572 RVA: 0x00072918 File Offset: 0x00070B18
		[Token(Token = "0x6012B1C")]
		[Address(RVA = "0xA67980", Offset = "0xA66580", VA = "0x180A67980")]
		private bool <>xLuaBaseProxy_CheckAtPreCastPhase()
		{
			return default(bool);
		}

		// Token: 0x06012B1D RID: 76573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B1D")]
		[Address(RVA = "0xA66040", Offset = "0xA64C40", VA = "0x180A66040")]
		private void <>xLuaBaseProxy_PreloadSpecialAudioSignals(string P0, string P1, Action<string, string> P2)
		{
		}

		// Token: 0x040151DB RID: 86491
		[Token(Token = "0x40151DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Ability.Category _category;

		// Token: 0x040151DC RID: 86492
		[Token(Token = "0x40151DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		[SerializeField]
		private int _coolDownAbilityIndex;

		// Token: 0x040151DD RID: 86493
		[Token(Token = "0x40151DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private bool _clearInternalCooldownWhenFinish;

		// Token: 0x040151DE RID: 86494
		[Token(Token = "0x40151DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x119")]
		[SerializeField]
		private bool _updateCooldownBySubAbilityCooldownDuringCasting;

		// Token: 0x040151DF RID: 86495
		[Token(Token = "0x40151DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11A")]
		[SerializeField]
		private bool _updateSubAbilitiesWhenExtendUpdated;

		// Token: 0x040151E0 RID: 86496
		[Token(Token = "0x40151E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private AbilitySelectableGroup.AbilityConfigs[] _abilityConfigs;

		// Token: 0x040151E1 RID: 86497
		[Token(Token = "0x40151E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		private AbstractAnimatedAbility.TimeMode _timeMode;

		// Token: 0x040151E2 RID: 86498
		[Token(Token = "0x40151E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		[SerializeField]
		private bool _selectAbilitySequentially;

		// Token: 0x040151E3 RID: 86499
		[Token(Token = "0x40151E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12D")]
		[SerializeField]
		private bool _useSubAbilityEscapeTime;

		// Token: 0x040151E4 RID: 86500
		[Token(Token = "0x40151E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		[Inspect("useSubAbilityEscapeTime")]
		private int _escapeTimeAbilityIndex;

		// Token: 0x040151E5 RID: 86501
		[Token(Token = "0x40151E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		[SerializeField]
		private bool _firstAttackIfAbilityChanged;

		// Token: 0x040151E6 RID: 86502
		[Token(Token = "0x40151E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x135")]
		[SerializeField]
		private bool _resetSubAbilities;

		// Token: 0x040151E7 RID: 86503
		[Token(Token = "0x40151E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x136")]
		[SerializeField]
		private bool _resetSubAbilityCooldown;

		// Token: 0x040151E8 RID: 86504
		[Token(Token = "0x40151E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x137")]
		[SerializeField]
		private bool _useCurAbCheckAtPreCastPhase;

		// Token: 0x040151E9 RID: 86505
		[Token(Token = "0x40151E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private int m_curAbilityIndex;

		// Token: 0x040151EA RID: 86506
		[Token(Token = "0x40151EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private int m_lastAbilityIndex;

		// Token: 0x040151EB RID: 86507
		[Token(Token = "0x40151EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private FP m_cooldown;

		// Token: 0x040151EC RID: 86508
		[Token(Token = "0x40151EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_useSubAbilityEscapeTime;

		// Token: 0x040151ED RID: 86509
		[Token(Token = "0x40151ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_escapeTime;

		// Token: 0x040151EE RID: 86510
		[Token(Token = "0x40151EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x040151EF RID: 86511
		[Token(Token = "0x40151EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_selectTargetSource;

		// Token: 0x040151F0 RID: 86512
		[Token(Token = "0x40151F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_cooldown;

		// Token: 0x040151F1 RID: 86513
		[Token(Token = "0x40151F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_alwaysIncludeTarget;

		// Token: 0x040151F2 RID: 86514
		[Token(Token = "0x40151F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_needUpdateAttackTime;

		// Token: 0x040151F3 RID: 86515
		[Token(Token = "0x40151F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_UBPGetConfigs;

		// Token: 0x040151F4 RID: 86516
		[Token(Token = "0x40151F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetActiveBuffs;

		// Token: 0x040151F5 RID: 86517
		[Token(Token = "0x40151F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x040151F6 RID: 86518
		[Token(Token = "0x40151F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x040151F7 RID: 86519
		[Token(Token = "0x40151F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x040151F8 RID: 86520
		[Token(Token = "0x40151F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x040151F9 RID: 86521
		[Token(Token = "0x40151F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x040151FA RID: 86522
		[Token(Token = "0x40151FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_CastToTarget;

		// Token: 0x040151FB RID: 86523
		[Token(Token = "0x40151FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_CastDirectly;

		// Token: 0x040151FC RID: 86524
		[Token(Token = "0x40151FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__DoCastInternal;

		// Token: 0x040151FD RID: 86525
		[Token(Token = "0x40151FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_ResetCooldown;

		// Token: 0x040151FE RID: 86526
		[Token(Token = "0x40151FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x040151FF RID: 86527
		[Token(Token = "0x40151FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04015200 RID: 86528
		[Token(Token = "0x4015200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnWaitForPreDelay;

		// Token: 0x04015201 RID: 86529
		[Token(Token = "0x4015201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnWaitForPostDelay;

		// Token: 0x04015202 RID: 86530
		[Token(Token = "0x4015202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnCastEnd;

		// Token: 0x04015203 RID: 86531
		[Token(Token = "0x4015203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnAttackTimeChanged;

		// Token: 0x04015204 RID: 86532
		[Token(Token = "0x4015204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnAbilityExtendUpdated;

		// Token: 0x04015205 RID: 86533
		[Token(Token = "0x4015205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__OnSubAbilityFinished;

		// Token: 0x04015206 RID: 86534
		[Token(Token = "0x4015206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_CheckAtPreCastPhase;

		// Token: 0x04015207 RID: 86535
		[Token(Token = "0x4015207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_PreloadSpecialAudioSignals;

		// Token: 0x04015208 RID: 86536
		[Token(Token = "0x4015208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__IsFirstAttack;

		// Token: 0x04015209 RID: 86537
		[Token(Token = "0x4015209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__SyncCooldownOnCastStartByOption;

		// Token: 0x0401520A RID: 86538
		[Token(Token = "0x401520A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002B77 RID: 11127
		[Token(Token = "0x2002B77")]
		[Serializable]
		public class AbilityConfigs
		{
			// Token: 0x1700292A RID: 10538
			// (get) Token: 0x06012B1E RID: 76574 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700292A")]
			public Ability ability
			{
				[Token(Token = "0x6012B1E")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700292B RID: 10539
			// (get) Token: 0x06012B1F RID: 76575 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700292B")]
			public TargetTrigger trigger
			{
				[Token(Token = "0x6012B1F")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				get
				{
					return null;
				}
			}

			// Token: 0x06012B20 RID: 76576 RVA: 0x00072930 File Offset: 0x00070B30
			[Token(Token = "0x6012B20")]
			[Address(RVA = "0xA938F0", Offset = "0xA924F0", VA = "0x180A938F0")]
			public bool TryCastToTarget([Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true, [Optional] Entity inputTarget)
			{
				return default(bool);
			}

			// Token: 0x06012B21 RID: 76577 RVA: 0x00072948 File Offset: 0x00070B48
			[Token(Token = "0x6012B21")]
			[Address(RVA = "0xA937E0", Offset = "0xA923E0", VA = "0x180A937E0")]
			public bool TryCastDirectly([Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
			{
				return default(bool);
			}

			// Token: 0x06012B22 RID: 76578 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6012B22")]
			[Address(RVA = "0xA93730", Offset = "0xA92330", VA = "0x180A93730")]
			public void DoSetData(Entity owner, Ability.Options options)
			{
			}

			// Token: 0x06012B23 RID: 76579 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6012B23")]
			[Address(RVA = "0xA937C0", Offset = "0xA923C0", VA = "0x180A937C0")]
			public void Reset()
			{
			}

			// Token: 0x06012B24 RID: 76580 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6012B24")]
			[Address(RVA = "0xA93B40", Offset = "0xA92740", VA = "0x180A93B40")]
			private Entity _GetTarget(Entity inputTarget)
			{
				return null;
			}

			// Token: 0x06012B25 RID: 76581 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6012B25")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AbilityConfigs()
			{
			}

			// Token: 0x0401520B RID: 86539
			[Token(Token = "0x401520B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Ability _ability;

			// Token: 0x0401520C RID: 86540
			[Token(Token = "0x401520C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private TargetTrigger _trigger;

			// Token: 0x0401520D RID: 86541
			[Token(Token = "0x401520D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private bool _alwaysUseTrigger;

			// Token: 0x0401520E RID: 86542
			[Token(Token = "0x401520E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
			[SerializeField]
			private bool _useInputTarget;
		}
	}
}
