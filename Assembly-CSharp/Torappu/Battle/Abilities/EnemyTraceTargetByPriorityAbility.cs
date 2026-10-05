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
	// Token: 0x02002B9A RID: 11162
	[Token(Token = "0x2002B9A")]
	public class EnemyTraceTargetByPriorityAbility : BaseTraceTargetAbility
	{
		// Token: 0x1700297D RID: 10621
		// (get) Token: 0x06012CE3 RID: 77027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700297D")]
		protected override TracePositionCursor tracePositionCursor
		{
			[Token(Token = "0x6012CE3")]
			[Address(RVA = "0xABC650", Offset = "0xABB250", VA = "0x180ABC650", Slot = "100")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700297E RID: 10622
		// (get) Token: 0x06012CE4 RID: 77028 RVA: 0x000732F0 File Offset: 0x000714F0
		[Token(Token = "0x1700297E")]
		public override Ability.Category category
		{
			[Token(Token = "0x6012CE4")]
			[Address(RVA = "0xABC4A0", Offset = "0xABB0A0", VA = "0x180ABC4A0", Slot = "13")]
			get
			{
				return Ability.Category.NONE;
			}
		}

		// Token: 0x1700297F RID: 10623
		// (get) Token: 0x06012CE5 RID: 77029 RVA: 0x00073308 File Offset: 0x00071508
		[Token(Token = "0x1700297F")]
		public override FP cooldown
		{
			[Token(Token = "0x6012CE5")]
			[Address(RVA = "0xABC500", Offset = "0xABB100", VA = "0x180ABC500", Slot = "16")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17002980 RID: 10624
		// (get) Token: 0x06012CE6 RID: 77030 RVA: 0x00073320 File Offset: 0x00071520
		[Token(Token = "0x17002980")]
		public override AbilityStandard.SelectTargetSource selectTargetSource
		{
			[Token(Token = "0x6012CE6")]
			[Address(RVA = "0xABC590", Offset = "0xABB190", VA = "0x180ABC590", Slot = "65")]
			get
			{
				return AbilityStandard.SelectTargetSource.NONE;
			}
		}

		// Token: 0x17002981 RID: 10625
		// (get) Token: 0x06012CE7 RID: 77031 RVA: 0x00073338 File Offset: 0x00071538
		[Token(Token = "0x17002981")]
		public override AbilityStandard.SelectTargetTiming selectTargetTiming
		{
			[Token(Token = "0x6012CE7")]
			[Address(RVA = "0xABC5F0", Offset = "0xABB1F0", VA = "0x180ABC5F0", Slot = "66")]
			get
			{
				return AbilityStandard.SelectTargetTiming.AT_BEGINING;
			}
		}

		// Token: 0x17002982 RID: 10626
		// (get) Token: 0x06012CE8 RID: 77032 RVA: 0x00073350 File Offset: 0x00071550
		[Token(Token = "0x17002982")]
		protected override bool alwaysIncludeTarget
		{
			[Token(Token = "0x6012CE8")]
			[Address(RVA = "0xABC440", Offset = "0xABB040", VA = "0x180ABC440", Slot = "67")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002983 RID: 10627
		// (get) Token: 0x06012CE9 RID: 77033 RVA: 0x00073368 File Offset: 0x00071568
		[Token(Token = "0x17002983")]
		public override bool allowNoTarget
		{
			[Token(Token = "0x6012CE9")]
			[Address(RVA = "0xABC3E0", Offset = "0xABAFE0", VA = "0x180ABC3E0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012CEA RID: 77034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012CEA")]
		[Address(RVA = "0xABA310", Offset = "0xAB8F10", VA = "0x180ABA310", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x06012CEB RID: 77035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012CEB")]
		[Address(RVA = "0xABA240", Offset = "0xAB8E40", VA = "0x180ABA240", Slot = "43")]
		public override IList<BuffData> GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x06012CEC RID: 77036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012CEC")]
		[Address(RVA = "0xABA2A0", Offset = "0xAB8EA0", VA = "0x180ABA2A0", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012CED RID: 77037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012CED")]
		[Address(RVA = "0xABA370", Offset = "0xAB8F70", VA = "0x180ABA370", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x06012CEE RID: 77038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012CEE")]
		[Address(RVA = "0xABACD0", Offset = "0xAB98D0", VA = "0x180ABACD0", Slot = "75")]
		protected override IEnumerator OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x06012CEF RID: 77039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012CEF")]
		[Address(RVA = "0xABAC40", Offset = "0xAB9840", VA = "0x180ABAC40", Slot = "76")]
		protected override IEnumerator OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x06012CF0 RID: 77040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012CF0")]
		[Address(RVA = "0xABA000", Offset = "0xAB8C00", VA = "0x180ABA000", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012CF1 RID: 77041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012CF1")]
		[Address(RVA = "0xABAD60", Offset = "0xAB9960", VA = "0x180ABAD60", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x06012CF2 RID: 77042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012CF2")]
		[Address(RVA = "0xABA400", Offset = "0xAB9000", VA = "0x180ABA400", Slot = "52")]
		protected override void OnAttached()
		{
		}

		// Token: 0x06012CF3 RID: 77043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012CF3")]
		[Address(RVA = "0xABA510", Offset = "0xAB9110", VA = "0x180ABA510", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x06012CF4 RID: 77044 RVA: 0x00073380 File Offset: 0x00071580
		[Token(Token = "0x6012CF4")]
		[Address(RVA = "0xAB9C50", Offset = "0xAB8850", VA = "0x180AB9C50", Slot = "33")]
		public override bool CastDirectly([Optional] Ability.FinishCallbackDelegate finishCb, bool isFirstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x06012CF5 RID: 77045 RVA: 0x00073398 File Offset: 0x00071598
		[Token(Token = "0x6012CF5")]
		[Address(RVA = "0xAB9DA0", Offset = "0xAB89A0", VA = "0x180AB9DA0", Slot = "32")]
		public override bool CastToTarget(Entity target, [Optional] Ability.FinishCallbackDelegate finishCb, bool isFirstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x06012CF6 RID: 77046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012CF6")]
		[Address(RVA = "0xABA620", Offset = "0xAB9220", VA = "0x180ABA620", Slot = "54")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012CF7 RID: 77047 RVA: 0x000733B0 File Offset: 0x000715B0
		[Token(Token = "0x6012CF7")]
		[Address(RVA = "0xAB9EF0", Offset = "0xAB8AF0", VA = "0x180AB9EF0")]
		public bool CheckTraceTargetInAttackRange()
		{
			return default(bool);
		}

		// Token: 0x06012CF8 RID: 77048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012CF8")]
		[Address(RVA = "0xABB7E0", Offset = "0xABA3E0", VA = "0x180ABB7E0")]
		private void _DoFindTargetByPriority()
		{
		}

		// Token: 0x06012CF9 RID: 77049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012CF9")]
		[Address(RVA = "0xABB9A0", Offset = "0xABA5A0", VA = "0x180ABB9A0")]
		private void _DoFindTileByDefault()
		{
		}

		// Token: 0x06012CFA RID: 77050 RVA: 0x000733C8 File Offset: 0x000715C8
		[Token(Token = "0x6012CFA")]
		[Address(RVA = "0xABB710", Offset = "0xABA310", VA = "0x180ABB710")]
		private bool _CheckCurrentTraceTile()
		{
			return default(bool);
		}

		// Token: 0x06012CFB RID: 77051 RVA: 0x000733E0 File Offset: 0x000715E0
		[Token(Token = "0x6012CFB")]
		[Address(RVA = "0xABB2D0", Offset = "0xAB9ED0", VA = "0x180ABB2D0")]
		private bool _CheckCurrentTraceTarget()
		{
			return default(bool);
		}

		// Token: 0x06012CFC RID: 77052 RVA: 0x000733F8 File Offset: 0x000715F8
		[Token(Token = "0x6012CFC")]
		[Address(RVA = "0xABAFC0", Offset = "0xAB9BC0", VA = "0x180ABAFC0")]
		private bool _CanUseAttack(Entity entity)
		{
			return default(bool);
		}

		// Token: 0x06012CFD RID: 77053 RVA: 0x00073410 File Offset: 0x00071610
		[Token(Token = "0x6012CFD")]
		[Address(RVA = "0xABBF60", Offset = "0xABAB60", VA = "0x180ABBF60")]
		private bool _SelectorVerifyTarget(TargetSelector targetSelector, Entity entity)
		{
			return default(bool);
		}

		// Token: 0x06012CFE RID: 77054 RVA: 0x00073428 File Offset: 0x00071628
		[Token(Token = "0x6012CFE")]
		[Address(RVA = "0xABAEE0", Offset = "0xAB9AE0", VA = "0x180ABAEE0")]
		private bool _CanTargetBeTraced(Entity entity)
		{
			return default(bool);
		}

		// Token: 0x06012CFF RID: 77055 RVA: 0x00073440 File Offset: 0x00071640
		[Token(Token = "0x6012CFF")]
		[Address(RVA = "0xABBB30", Offset = "0xABA730", VA = "0x180ABBB30")]
		private bool _IsTraceTileReachable()
		{
			return default(bool);
		}

		// Token: 0x06012D00 RID: 77056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D00")]
		[Address(RVA = "0xABBCD0", Offset = "0xABA8D0", VA = "0x180ABBCD0")]
		private void _OnUnitFinish(object arg)
		{
		}

		// Token: 0x06012D01 RID: 77057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D01")]
		[Address(RVA = "0xABBE60", Offset = "0xABAA60", VA = "0x180ABBE60")]
		private void _RegisterTraceTarget(Entity entity)
		{
		}

		// Token: 0x06012D02 RID: 77058 RVA: 0x00073458 File Offset: 0x00071658
		[Token(Token = "0x6012D02")]
		[Address(RVA = "0xABC090", Offset = "0xABAC90", VA = "0x180ABC090")]
		private bool _UpdateTraceTargetRoute(Entity candidate)
		{
			return default(bool);
		}

		// Token: 0x06012D03 RID: 77059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D03")]
		[Address(RVA = "0xABC2F0", Offset = "0xABAEF0", VA = "0x180ABC2F0")]
		public EnemyTraceTargetByPriorityAbility()
		{
		}

		// Token: 0x06012D04 RID: 77060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012D04")]
		[Address(RVA = "0xAB8190", Offset = "0xAB6D90", VA = "0x180AB8190")]
		private TracePositionCursor <>xLuaBaseProxy_get_tracePositionCursor()
		{
			return null;
		}

		// Token: 0x06012D05 RID: 77061 RVA: 0x00073470 File Offset: 0x00071670
		[Token(Token = "0x6012D05")]
		[Address(RVA = "0xAAAD80", Offset = "0xAA9980", VA = "0x180AAAD80")]
		private Ability.Category <>xLuaBaseProxy_get_category()
		{
			return Ability.Category.NONE;
		}

		// Token: 0x06012D06 RID: 77062 RVA: 0x00073488 File Offset: 0x00071688
		[Token(Token = "0x6012D06")]
		[Address(RVA = "0xAB8060", Offset = "0xAB6C60", VA = "0x180AB8060")]
		private FP <>xLuaBaseProxy_get_cooldown()
		{
			return default(FP);
		}

		// Token: 0x06012D07 RID: 77063 RVA: 0x000734A0 File Offset: 0x000716A0
		[Token(Token = "0x6012D07")]
		[Address(RVA = "0xAAEEF0", Offset = "0xAADAF0", VA = "0x180AAEEF0")]
		private AbilityStandard.SelectTargetSource <>xLuaBaseProxy_get_selectTargetSource()
		{
			return AbilityStandard.SelectTargetSource.NONE;
		}

		// Token: 0x06012D08 RID: 77064 RVA: 0x000734B8 File Offset: 0x000716B8
		[Token(Token = "0x6012D08")]
		[Address(RVA = "0xAAEF50", Offset = "0xAADB50", VA = "0x180AAEF50")]
		private AbilityStandard.SelectTargetTiming <>xLuaBaseProxy_get_selectTargetTiming()
		{
			return AbilityStandard.SelectTargetTiming.AT_BEGINING;
		}

		// Token: 0x06012D09 RID: 77065 RVA: 0x000734D0 File Offset: 0x000716D0
		[Token(Token = "0x6012D09")]
		[Address(RVA = "0xAAEAD0", Offset = "0xAAD6D0", VA = "0x180AAEAD0")]
		private bool <>xLuaBaseProxy_get_alwaysIncludeTarget()
		{
			return default(bool);
		}

		// Token: 0x06012D0A RID: 77066 RVA: 0x000734E8 File Offset: 0x000716E8
		[Token(Token = "0x6012D0A")]
		[Address(RVA = "0xAAEA70", Offset = "0xAAD670", VA = "0x180AAEA70")]
		private bool <>xLuaBaseProxy_get_allowNoTarget()
		{
			return default(bool);
		}

		// Token: 0x06012D0B RID: 77067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012D0B")]
		[Address(RVA = "0xAAE130", Offset = "0xAACD30", VA = "0x180AAE130")]
		private IList<BuffData> <>xLuaBaseProxy_GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x06012D0C RID: 77068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012D0C")]
		[Address(RVA = "0xAAE060", Offset = "0xAACC60", VA = "0x180AAE060")]
		private IList<BuffData> <>xLuaBaseProxy_GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x06012D0D RID: 77069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012D0D")]
		[Address(RVA = "0xAAE0C0", Offset = "0xAACCC0", VA = "0x180AAE0C0")]
		private IList<ActionNode> <>xLuaBaseProxy_GetEventActions(AbilityStandard.Event P0)
		{
			return null;
		}

		// Token: 0x06012D0E RID: 77070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012D0E")]
		[Address(RVA = "0xAB8030", Offset = "0xAB6C30", VA = "0x180AB8030")]
		private IList<ActionNode> <>xLuaBaseProxy_GetProjectileActions(Projectile.Event P0, Projectile P1)
		{
			return null;
		}

		// Token: 0x06012D0F RID: 77071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012D0F")]
		[Address(RVA = "0xAB8050", Offset = "0xAB6C50", VA = "0x180AB8050")]
		private IEnumerator <>xLuaBaseProxy_OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x06012D10 RID: 77072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012D10")]
		[Address(RVA = "0xAB8040", Offset = "0xAB6C40", VA = "0x180AB8040")]
		private IEnumerator <>xLuaBaseProxy_OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x06012D11 RID: 77073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D11")]
		[Address(RVA = "0xAB8000", Offset = "0xAB6C00", VA = "0x180AB8000")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012D12 RID: 77074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D12")]
		[Address(RVA = "0xA4B0B0", Offset = "0xA49CB0", VA = "0x180A4B0B0")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x06012D13 RID: 77075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D13")]
		[Address(RVA = "0xAAACF0", Offset = "0xAA98F0", VA = "0x180AAACF0")]
		private void <>xLuaBaseProxy_OnAttached()
		{
		}

		// Token: 0x06012D14 RID: 77076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D14")]
		[Address(RVA = "0xAAAD00", Offset = "0xAA9900", VA = "0x180AAAD00")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x06012D15 RID: 77077 RVA: 0x00073500 File Offset: 0x00071700
		[Token(Token = "0x6012D15")]
		[Address(RVA = "0xA225E0", Offset = "0xA211E0", VA = "0x180A225E0")]
		private bool <>xLuaBaseProxy_CastDirectly(Ability.FinishCallbackDelegate P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x06012D16 RID: 77078 RVA: 0x00073518 File Offset: 0x00071718
		[Token(Token = "0x6012D16")]
		[Address(RVA = "0xA38650", Offset = "0xA37250", VA = "0x180A38650")]
		private bool <>xLuaBaseProxy_CastToTarget(Entity P0, Ability.FinishCallbackDelegate P1, bool P2)
		{
			return default(bool);
		}

		// Token: 0x06012D17 RID: 77079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D17")]
		[Address(RVA = "0xA38EF0", Offset = "0xA37AF0", VA = "0x180A38EF0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x040153B0 RID: 86960
		[Token(Token = "0x40153B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[SerializeField]
		private float _defaultSearchCoolDown;

		// Token: 0x040153B1 RID: 86961
		[Token(Token = "0x40153B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[SerializeField]
		private string _defaultCooldownKey;

		// Token: 0x040153B2 RID: 86962
		[Token(Token = "0x40153B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[SerializeField]
		private GroupSelector _traceTargetSelectors;

		// Token: 0x040153B3 RID: 86963
		[Token(Token = "0x40153B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[SerializeField]
		private TileSelector _defaultTileSelector;

		// Token: 0x040153B4 RID: 86964
		[Token(Token = "0x40153B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[SerializeField]
		private bool _removeTraceTargetWhenReached;

		// Token: 0x040153B5 RID: 86965
		[Token(Token = "0x40153B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		protected PeriodicTimer m_defaultTracingCooldownTimer;

		// Token: 0x040153B6 RID: 86966
		[Token(Token = "0x40153B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private readonly List<Entity> m_candidateEntities;

		// Token: 0x040153B7 RID: 86967
		[Token(Token = "0x40153B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private bool isDefaultTracing;

		// Token: 0x040153B8 RID: 86968
		[Token(Token = "0x40153B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_tracePositionCursor;

		// Token: 0x040153B9 RID: 86969
		[Token(Token = "0x40153B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x040153BA RID: 86970
		[Token(Token = "0x40153BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_cooldown;

		// Token: 0x040153BB RID: 86971
		[Token(Token = "0x40153BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_selectTargetSource;

		// Token: 0x040153BC RID: 86972
		[Token(Token = "0x40153BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_selectTargetTiming;

		// Token: 0x040153BD RID: 86973
		[Token(Token = "0x40153BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_alwaysIncludeTarget;

		// Token: 0x040153BE RID: 86974
		[Token(Token = "0x40153BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_allowNoTarget;

		// Token: 0x040153BF RID: 86975
		[Token(Token = "0x40153BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x040153C0 RID: 86976
		[Token(Token = "0x40153C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetActiveBuffs;

		// Token: 0x040153C1 RID: 86977
		[Token(Token = "0x40153C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x040153C2 RID: 86978
		[Token(Token = "0x40153C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x040153C3 RID: 86979
		[Token(Token = "0x40153C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnWaitForPreDelay;

		// Token: 0x040153C4 RID: 86980
		[Token(Token = "0x40153C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnWaitForPostDelay;

		// Token: 0x040153C5 RID: 86981
		[Token(Token = "0x40153C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x040153C6 RID: 86982
		[Token(Token = "0x40153C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x040153C7 RID: 86983
		[Token(Token = "0x40153C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnAttached;

		// Token: 0x040153C8 RID: 86984
		[Token(Token = "0x40153C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x040153C9 RID: 86985
		[Token(Token = "0x40153C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_CastDirectly;

		// Token: 0x040153CA RID: 86986
		[Token(Token = "0x40153CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_CastToTarget;

		// Token: 0x040153CB RID: 86987
		[Token(Token = "0x40153CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040153CC RID: 86988
		[Token(Token = "0x40153CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_CheckTraceTargetInAttackRange;

		// Token: 0x040153CD RID: 86989
		[Token(Token = "0x40153CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__DoFindTargetByPriority;

		// Token: 0x040153CE RID: 86990
		[Token(Token = "0x40153CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__DoFindTileByDefault;

		// Token: 0x040153CF RID: 86991
		[Token(Token = "0x40153CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__CheckCurrentTraceTile;

		// Token: 0x040153D0 RID: 86992
		[Token(Token = "0x40153D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__CheckCurrentTraceTarget;

		// Token: 0x040153D1 RID: 86993
		[Token(Token = "0x40153D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__CanUseAttack;

		// Token: 0x040153D2 RID: 86994
		[Token(Token = "0x40153D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__SelectorVerifyTarget;

		// Token: 0x040153D3 RID: 86995
		[Token(Token = "0x40153D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__CanTargetBeTraced;

		// Token: 0x040153D4 RID: 86996
		[Token(Token = "0x40153D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__IsTraceTileReachable;

		// Token: 0x040153D5 RID: 86997
		[Token(Token = "0x40153D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__OnUnitFinish;

		// Token: 0x040153D6 RID: 86998
		[Token(Token = "0x40153D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__RegisterTraceTarget;

		// Token: 0x040153D7 RID: 86999
		[Token(Token = "0x40153D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__UpdateTraceTargetRoute;

		// Token: 0x040153D8 RID: 87000
		[Token(Token = "0x40153D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
