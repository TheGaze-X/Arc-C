using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B26 RID: 11046
	[Token(Token = "0x2002B26")]
	public class GlobalAuraAbility : AbilityStandard, IAuraAbilityControl
	{
		// Token: 0x170028BC RID: 10428
		// (get) Token: 0x0601280B RID: 75787 RVA: 0x00071748 File Offset: 0x0006F948
		[Token(Token = "0x170028BC")]
		public override FP cooldown
		{
			[Token(Token = "0x601280B")]
			[Address(RVA = "0xA87650", Offset = "0xA86250", VA = "0x180A87650", Slot = "16")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170028BD RID: 10429
		// (get) Token: 0x0601280C RID: 75788 RVA: 0x00071760 File Offset: 0x0006F960
		[Token(Token = "0x170028BD")]
		public override Ability.Category category
		{
			[Token(Token = "0x601280C")]
			[Address(RVA = "0xA875F0", Offset = "0xA861F0", VA = "0x180A875F0", Slot = "13")]
			get
			{
				return Ability.Category.NONE;
			}
		}

		// Token: 0x170028BE RID: 10430
		// (get) Token: 0x0601280D RID: 75789 RVA: 0x00071778 File Offset: 0x0006F978
		[Token(Token = "0x170028BE")]
		public override AbilityStandard.SelectTargetSource selectTargetSource
		{
			[Token(Token = "0x601280D")]
			[Address(RVA = "0xA87790", Offset = "0xA86390", VA = "0x180A87790", Slot = "65")]
			get
			{
				return AbilityStandard.SelectTargetSource.NONE;
			}
		}

		// Token: 0x170028BF RID: 10431
		// (get) Token: 0x0601280E RID: 75790 RVA: 0x00071790 File Offset: 0x0006F990
		[Token(Token = "0x170028BF")]
		protected override bool alwaysIncludeTarget
		{
			[Token(Token = "0x601280E")]
			[Address(RVA = "0xA87590", Offset = "0xA86190", VA = "0x180A87590", Slot = "67")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170028C0 RID: 10432
		// (get) Token: 0x0601280F RID: 75791 RVA: 0x000717A8 File Offset: 0x0006F9A8
		[Token(Token = "0x170028C0")]
		private bool removeBuffWhenAbilityDetached
		{
			[Token(Token = "0x601280F")]
			[Address(RVA = "0xA87730", Offset = "0xA86330", VA = "0x180A87730")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012810 RID: 75792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012810")]
		[Address(RVA = "0xA84BC0", Offset = "0xA837C0", VA = "0x180A84BC0", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012811 RID: 75793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012811")]
		[Address(RVA = "0xA84C90", Offset = "0xA83890", VA = "0x180A84C90", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x06012812 RID: 75794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012812")]
		[Address(RVA = "0xA84C30", Offset = "0xA83830", VA = "0x180A84C30", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x06012813 RID: 75795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012813")]
		[Address(RVA = "0xA84B60", Offset = "0xA83760", VA = "0x180A84B60", Slot = "43")]
		public override IList<BuffData> GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x06012814 RID: 75796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012814")]
		[Address(RVA = "0xA84FD0", Offset = "0xA83BD0", VA = "0x180A84FD0", Slot = "75")]
		protected override IEnumerator OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x06012815 RID: 75797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012815")]
		[Address(RVA = "0xA84F40", Offset = "0xA83B40", VA = "0x180A84F40", Slot = "76")]
		protected override IEnumerator OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x170028C1 RID: 10433
		// (get) Token: 0x06012816 RID: 75798 RVA: 0x000717C0 File Offset: 0x0006F9C0
		[Token(Token = "0x170028C1")]
		protected bool forceTick
		{
			[Token(Token = "0x6012816")]
			[Address(RVA = "0xA876D0", Offset = "0xA862D0", VA = "0x180A876D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012817 RID: 75799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012817")]
		[Address(RVA = "0xA84D20", Offset = "0xA83920", VA = "0x180A84D20")]
		private void OnDestroy()
		{
		}

		// Token: 0x06012818 RID: 75800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012818")]
		[Address(RVA = "0xA84870", Offset = "0xA83470", VA = "0x180A84870", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012819 RID: 75801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012819")]
		[Address(RVA = "0xA83DD0", Offset = "0xA829D0", VA = "0x180A83DD0", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x0601281A RID: 75802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601281A")]
		[Address(RVA = "0xA84460", Offset = "0xA83060", VA = "0x180A84460", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x0601281B RID: 75803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601281B")]
		[Address(RVA = "0xA84AB0", Offset = "0xA836B0", VA = "0x180A84AB0", Slot = "46")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0601281C RID: 75804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601281C")]
		[Address(RVA = "0xA84A00", Offset = "0xA83600", VA = "0x180A84A00", Slot = "49")]
		public override void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x0601281D RID: 75805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601281D")]
		[Address(RVA = "0xA853F0", Offset = "0xA83FF0", VA = "0x180A853F0")]
		private void _ClearBuffs()
		{
		}

		// Token: 0x0601281E RID: 75806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601281E")]
		[Address(RVA = "0xA86110", Offset = "0xA84D10", VA = "0x180A86110")]
		private void _OnMapLayerChanged(object arg)
		{
		}

		// Token: 0x0601281F RID: 75807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601281F")]
		[Address(RVA = "0xA86050", Offset = "0xA84C50", VA = "0x180A86050")]
		private void _OnDisappearChanged(object arg)
		{
		}

		// Token: 0x06012820 RID: 75808 RVA: 0x000717D8 File Offset: 0x0006F9D8
		[Token(Token = "0x6012820")]
		[Address(RVA = "0xA83AD0", Offset = "0xA826D0", VA = "0x180A83AD0", Slot = "97")]
		protected virtual bool DealTarget(Entity target)
		{
			return default(bool);
		}

		// Token: 0x06012821 RID: 75809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012821")]
		[Address(RVA = "0xA866F0", Offset = "0xA852F0", VA = "0x180A866F0")]
		private void _OnUnitBornOrRallyPointReborn(object arg)
		{
		}

		// Token: 0x06012822 RID: 75810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012822")]
		[Address(RVA = "0xA86250", Offset = "0xA84E50", VA = "0x180A86250")]
		private void _OnRallyPointDead(object arg)
		{
		}

		// Token: 0x06012823 RID: 75811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012823")]
		[Address(RVA = "0xA86480", Offset = "0xA85080", VA = "0x180A86480")]
		private void _OnRallyPointLikeSwitch(object arg)
		{
		}

		// Token: 0x06012824 RID: 75812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012824")]
		[Address(RVA = "0xA85EA0", Offset = "0xA84AA0", VA = "0x180A85EA0")]
		private void _ClearEffects()
		{
		}

		// Token: 0x06012825 RID: 75813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012825")]
		[Address(RVA = "0xA869D0", Offset = "0xA855D0", VA = "0x180A869D0")]
		private void _UpdateTargetMap()
		{
		}

		// Token: 0x06012826 RID: 75814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012826")]
		[Address(RVA = "0xA86D80", Offset = "0xA85980", VA = "0x180A86D80")]
		private void _UpdateTargets()
		{
		}

		// Token: 0x06012827 RID: 75815 RVA: 0x000717F0 File Offset: 0x0006F9F0
		[Token(Token = "0x6012827")]
		[Address(RVA = "0xA851D0", Offset = "0xA83DD0", VA = "0x180A851D0", Slot = "98")]
		protected virtual bool VerityTarget(Entity target)
		{
			return default(bool);
		}

		// Token: 0x06012828 RID: 75816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012828")]
		[Address(RVA = "0xA84DC0", Offset = "0xA839C0", VA = "0x180A84DC0", Slot = "54")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012829 RID: 75817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012829")]
		[Address(RVA = "0xA85060", Offset = "0xA83C60", VA = "0x180A85060", Slot = "96")]
		public void RestartAuraBySideType(SideType sideType)
		{
		}

		// Token: 0x0601282A RID: 75818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601282A")]
		[Address(RVA = "0xA87340", Offset = "0xA85F40", VA = "0x180A87340")]
		public GlobalAuraAbility()
		{
		}

		// Token: 0x0601282B RID: 75819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601282B")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x0601282C RID: 75820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601282C")]
		[Address(RVA = "0xA64260", Offset = "0xA62E60", VA = "0x180A64260")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x0601282D RID: 75821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601282D")]
		[Address(RVA = "0xA3C270", Offset = "0xA3AE70", VA = "0x180A3C270")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x0601282E RID: 75822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601282E")]
		[Address(RVA = "0xA53380", Offset = "0xA51F80", VA = "0x180A53380")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x0601282F RID: 75823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601282F")]
		[Address(RVA = "0xA56960", Offset = "0xA55560", VA = "0x180A56960")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x06012830 RID: 75824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012830")]
		[Address(RVA = "0xA38EF0", Offset = "0xA37AF0", VA = "0x180A38EF0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04014E91 RID: 85649
		[Token(Token = "0x4014E91")]
		private const int TRIGGER_TICK = 30;

		// Token: 0x04014E92 RID: 85650
		[Token(Token = "0x4014E92")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Help("HelpAttribute.IsValueNull", HelpType.Error, "Must specified a validator.")]
		private TargetValidator _targetValidator;

		// Token: 0x04014E93 RID: 85651
		[Token(Token = "0x4014E93")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		protected BuffData[] _buffs;

		// Token: 0x04014E94 RID: 85652
		[Token(Token = "0x4014E94")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		protected BuffData[] _passiveBuffs;

		// Token: 0x04014E95 RID: 85653
		[Token(Token = "0x4014E95")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		protected AuraAbility.SelfOption _selfOption;

		// Token: 0x04014E96 RID: 85654
		[Token(Token = "0x4014E96")]
		[FieldOffset(Offset = "0x12C")]
		[SerializeField]
		private bool _removeBuffWhenAbilityDetached;

		// Token: 0x04014E97 RID: 85655
		[Token(Token = "0x4014E97")]
		[FieldOffset(Offset = "0x12D")]
		[SerializeField]
		[Inspect("removeBuffWhenAbilityDetached")]
		private bool _removeBuffIncludeReborning;

		// Token: 0x04014E98 RID: 85656
		[Token(Token = "0x4014E98")]
		[FieldOffset(Offset = "0x12E")]
		[SerializeField]
		private bool _onlyDetactTargetWhenStarted;

		// Token: 0x04014E99 RID: 85657
		[Token(Token = "0x4014E99")]
		[FieldOffset(Offset = "0x12F")]
		[SerializeField]
		[Tooltip("IMPORTANT: Only work for enemy to character & character to character.")]
		private bool _onlyDetectCurrentMapLayer;

		// Token: 0x04014E9A RID: 85658
		[Token(Token = "0x4014E9A")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		[Tooltip("IMPORTANT: Recommend to enable this after V058")]
		private bool _listenUnitRebornEvent;

		// Token: 0x04014E9B RID: 85659
		[Token(Token = "0x4014E9B")]
		[FieldOffset(Offset = "0x131")]
		[SerializeField]
		[Tooltip("IMPORTANT: Recommend to enable this after V061, will remove buffs first when rallypoint/unit reborn, then try add buffs.")]
		private bool _tryRemoveBuffFirstWhenReborn;

		// Token: 0x04014E9C RID: 85660
		[Token(Token = "0x4014E9C")]
		[FieldOffset(Offset = "0x132")]
		[SerializeField]
		[Tooltip("IMPORTANT: Recommend to enable this after V058")]
		private bool _useDurableRallyPointLikeSwitch;

		// Token: 0x04014E9D RID: 85661
		[Token(Token = "0x4014E9D")]
		[FieldOffset(Offset = "0x133")]
		[SerializeField]
		private bool _forceRemoveAllBuffsByKey;

		// Token: 0x04014E9E RID: 85662
		[Token(Token = "0x4014E9E")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private string[] _effects;

		// Token: 0x04014E9F RID: 85663
		[Token(Token = "0x4014E9F")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private bool _forceTick;

		// Token: 0x04014EA0 RID: 85664
		[Token(Token = "0x4014EA0")]
		[FieldOffset(Offset = "0x141")]
		[SerializeField]
		private bool _excludeReborningEntity;

		// Token: 0x04014EA1 RID: 85665
		[Token(Token = "0x4014EA1")]
		[FieldOffset(Offset = "0x144")]
		[SerializeField]
		[Inspect("forceTick", true)]
		private float _interval;

		// Token: 0x04014EA2 RID: 85666
		[Token(Token = "0x4014EA2")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private bool _clearBuffsWhenDisappear;

		// Token: 0x04014EA3 RID: 85667
		[Token(Token = "0x4014EA3")]
		[FieldOffset(Offset = "0x150")]
		protected Dictionary<ObjectPtr<Entity>, List<uint>> m_targetMap;

		// Token: 0x04014EA4 RID: 85668
		[Token(Token = "0x4014EA4")]
		[FieldOffset(Offset = "0x158")]
		protected List<ObjectPtr<Entity>> m_targetList;

		// Token: 0x04014EA5 RID: 85669
		[Token(Token = "0x4014EA5")]
		[FieldOffset(Offset = "0x160")]
		private List<ObjectPtr<Effect>> m_effects;

		// Token: 0x04014EA6 RID: 85670
		[Token(Token = "0x4014EA6")]
		[FieldOffset(Offset = "0x168")]
		private PeriodicTicker m_triggerTicker;

		// Token: 0x04014EA7 RID: 85671
		[Token(Token = "0x4014EA7")]
		[FieldOffset(Offset = "0x170")]
		private PeriodicTimer m_tickTimer;

		// Token: 0x04014EA8 RID: 85672
		[Token(Token = "0x4014EA8")]
		[FieldOffset(Offset = "0x178")]
		private readonly List<ObjectPtr<Entity>> m_sharedTargetList;

		// Token: 0x04014EA9 RID: 85673
		[Token(Token = "0x4014EA9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cooldown;

		// Token: 0x04014EAA RID: 85674
		[Token(Token = "0x4014EAA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x04014EAB RID: 85675
		[Token(Token = "0x4014EAB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectTargetSource;

		// Token: 0x04014EAC RID: 85676
		[Token(Token = "0x4014EAC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_alwaysIncludeTarget;

		// Token: 0x04014EAD RID: 85677
		[Token(Token = "0x4014EAD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_removeBuffWhenAbilityDetached;

		// Token: 0x04014EAE RID: 85678
		[Token(Token = "0x4014EAE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04014EAF RID: 85679
		[Token(Token = "0x4014EAF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04014EB0 RID: 85680
		[Token(Token = "0x4014EB0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x04014EB1 RID: 85681
		[Token(Token = "0x4014EB1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetActiveBuffs;

		// Token: 0x04014EB2 RID: 85682
		[Token(Token = "0x4014EB2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnWaitForPreDelay;

		// Token: 0x04014EB3 RID: 85683
		[Token(Token = "0x4014EB3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnWaitForPostDelay;

		// Token: 0x04014EB4 RID: 85684
		[Token(Token = "0x4014EB4")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_forceTick;

		// Token: 0x04014EB5 RID: 85685
		[Token(Token = "0x4014EB5")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04014EB6 RID: 85686
		[Token(Token = "0x4014EB6")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014EB7 RID: 85687
		[Token(Token = "0x4014EB7")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04014EB8 RID: 85688
		[Token(Token = "0x4014EB8")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04014EB9 RID: 85689
		[Token(Token = "0x4014EB9")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04014EBA RID: 85690
		[Token(Token = "0x4014EBA")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x04014EBB RID: 85691
		[Token(Token = "0x4014EBB")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ClearBuffs;

		// Token: 0x04014EBC RID: 85692
		[Token(Token = "0x4014EBC")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnMapLayerChanged;

		// Token: 0x04014EBD RID: 85693
		[Token(Token = "0x4014EBD")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnDisappearChanged;

		// Token: 0x04014EBE RID: 85694
		[Token(Token = "0x4014EBE")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_DealTarget;

		// Token: 0x04014EBF RID: 85695
		[Token(Token = "0x4014EBF")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnUnitBornOrRallyPointReborn;

		// Token: 0x04014EC0 RID: 85696
		[Token(Token = "0x4014EC0")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnRallyPointDead;

		// Token: 0x04014EC1 RID: 85697
		[Token(Token = "0x4014EC1")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OnRallyPointLikeSwitch;

		// Token: 0x04014EC2 RID: 85698
		[Token(Token = "0x4014EC2")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__ClearEffects;

		// Token: 0x04014EC3 RID: 85699
		[Token(Token = "0x4014EC3")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__UpdateTargetMap;

		// Token: 0x04014EC4 RID: 85700
		[Token(Token = "0x4014EC4")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__UpdateTargets;

		// Token: 0x04014EC5 RID: 85701
		[Token(Token = "0x4014EC5")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_VerityTarget;

		// Token: 0x04014EC6 RID: 85702
		[Token(Token = "0x4014EC6")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04014EC7 RID: 85703
		[Token(Token = "0x4014EC7")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_RestartAuraBySideType;

		// Token: 0x04014EC8 RID: 85704
		[Token(Token = "0x4014EC8")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
