using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B83 RID: 11139
	[Token(Token = "0x2002B83")]
	public abstract class BaseTraceTargetAbility : AbilityStandard
	{
		// Token: 0x1700293C RID: 10556
		// (get) Token: 0x06012BA2 RID: 76706 RVA: 0x00072B70 File Offset: 0x00070D70
		[Token(Token = "0x1700293C")]
		public override Ability.Category category
		{
			[Token(Token = "0x6012BA2")]
			[Address(RVA = "0xAAAD80", Offset = "0xAA9980", VA = "0x180AAAD80", Slot = "13")]
			get
			{
				return Ability.Category.NONE;
			}
		}

		// Token: 0x1700293D RID: 10557
		// (get) Token: 0x06012BA3 RID: 76707 RVA: 0x00072B88 File Offset: 0x00070D88
		[Token(Token = "0x1700293D")]
		public override FP cooldown
		{
			[Token(Token = "0x6012BA3")]
			[Address(RVA = "0xAAEB30", Offset = "0xAAD730", VA = "0x180AAEB30", Slot = "16")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x1700293E RID: 10558
		// (get) Token: 0x06012BA4 RID: 76708 RVA: 0x00072BA0 File Offset: 0x00070DA0
		[Token(Token = "0x1700293E")]
		public override AbilityStandard.SelectTargetSource selectTargetSource
		{
			[Token(Token = "0x6012BA4")]
			[Address(RVA = "0xAAEEF0", Offset = "0xAADAF0", VA = "0x180AAEEF0", Slot = "65")]
			get
			{
				return AbilityStandard.SelectTargetSource.NONE;
			}
		}

		// Token: 0x1700293F RID: 10559
		// (get) Token: 0x06012BA5 RID: 76709 RVA: 0x00072BB8 File Offset: 0x00070DB8
		[Token(Token = "0x1700293F")]
		public override AbilityStandard.SelectTargetTiming selectTargetTiming
		{
			[Token(Token = "0x6012BA5")]
			[Address(RVA = "0xAAEF50", Offset = "0xAADB50", VA = "0x180AAEF50", Slot = "66")]
			get
			{
				return AbilityStandard.SelectTargetTiming.AT_BEGINING;
			}
		}

		// Token: 0x17002940 RID: 10560
		// (get) Token: 0x06012BA6 RID: 76710 RVA: 0x00072BD0 File Offset: 0x00070DD0
		[Token(Token = "0x17002940")]
		protected override bool alwaysIncludeTarget
		{
			[Token(Token = "0x6012BA6")]
			[Address(RVA = "0xAAEAD0", Offset = "0xAAD6D0", VA = "0x180AAEAD0", Slot = "67")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002941 RID: 10561
		// (get) Token: 0x06012BA7 RID: 76711 RVA: 0x00072BE8 File Offset: 0x00070DE8
		[Token(Token = "0x17002941")]
		public override bool allowNoTarget
		{
			[Token(Token = "0x6012BA7")]
			[Address(RVA = "0xAAEA70", Offset = "0xAAD670", VA = "0x180AAEA70", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012BA8 RID: 76712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012BA8")]
		[Address(RVA = "0xAAE130", Offset = "0xAACD30", VA = "0x180AAE130", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x06012BA9 RID: 76713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012BA9")]
		[Address(RVA = "0xAAE060", Offset = "0xAACC60", VA = "0x180AAE060", Slot = "43")]
		public override IList<BuffData> GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x06012BAA RID: 76714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012BAA")]
		[Address(RVA = "0xAAE0C0", Offset = "0xAACCC0", VA = "0x180AAE0C0", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012BAB RID: 76715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012BAB")]
		[Address(RVA = "0xAAE190", Offset = "0xAACD90", VA = "0x180AAE190", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x06012BAC RID: 76716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012BAC")]
		[Address(RVA = "0xAAE450", Offset = "0xAAD050", VA = "0x180AAE450", Slot = "75")]
		protected override IEnumerator OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x06012BAD RID: 76717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012BAD")]
		[Address(RVA = "0xAAE3C0", Offset = "0xAACFC0", VA = "0x180AAE3C0", Slot = "76")]
		protected override IEnumerator OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x17002942 RID: 10562
		// (get) Token: 0x06012BAE RID: 76718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002942")]
		protected Enemy ownerE
		{
			[Token(Token = "0x6012BAE")]
			[Address(RVA = "0xAAEE00", Offset = "0xAADA00", VA = "0x180AAEE00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002943 RID: 10563
		// (get) Token: 0x06012BAF RID: 76719 RVA: 0x00072C00 File Offset: 0x00070E00
		[Token(Token = "0x17002943")]
		public virtual bool usingTraceCursor
		{
			[Token(Token = "0x6012BAF")]
			[Address(RVA = "0xAAF1D0", Offset = "0xAADDD0", VA = "0x180AAF1D0", Slot = "96")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002944 RID: 10564
		// (get) Token: 0x06012BB0 RID: 76720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002944")]
		public virtual Tile traceTile
		{
			[Token(Token = "0x6012BB0")]
			[Address(RVA = "0xAAF170", Offset = "0xAADD70", VA = "0x180AAF170", Slot = "97")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002945 RID: 10565
		// (get) Token: 0x06012BB1 RID: 76721 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06012BB2 RID: 76722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002945")]
		public virtual Entity traceTarget
		{
			[Token(Token = "0x6012BB1")]
			[Address(RVA = "0xAAF110", Offset = "0xAADD10", VA = "0x180AAF110", Slot = "98")]
			get
			{
				return null;
			}
			[Token(Token = "0x6012BB2")]
			[Address(RVA = "0xAAF290", Offset = "0xAADE90", VA = "0x180AAF290", Slot = "99")]
			set
			{
			}
		}

		// Token: 0x17002946 RID: 10566
		// (get) Token: 0x06012BB3 RID: 76723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002946")]
		protected virtual TracePositionCursor tracePositionCursor
		{
			[Token(Token = "0x6012BB3")]
			[Address(RVA = "0xAAEFB0", Offset = "0xAADBB0", VA = "0x180AAEFB0", Slot = "100")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002947 RID: 10567
		// (get) Token: 0x06012BB4 RID: 76724 RVA: 0x00072C18 File Offset: 0x00070E18
		[Token(Token = "0x17002947")]
		public virtual bool hasTraceTarget
		{
			[Token(Token = "0x6012BB4")]
			[Address(RVA = "0xAAECF0", Offset = "0xAAD8F0", VA = "0x180AAECF0", Slot = "101")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002948 RID: 10568
		// (get) Token: 0x06012BB5 RID: 76725 RVA: 0x00072C30 File Offset: 0x00070E30
		[Token(Token = "0x17002948")]
		public bool enableTrace
		{
			[Token(Token = "0x6012BB5")]
			[Address(RVA = "0xAAEC90", Offset = "0xAAD890", VA = "0x180AAEC90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002949 RID: 10569
		// (get) Token: 0x06012BB6 RID: 76726 RVA: 0x00072C48 File Offset: 0x00070E48
		[Token(Token = "0x17002949")]
		public virtual bool enableTraceTarget
		{
			[Token(Token = "0x6012BB6")]
			[Address(RVA = "0xAAEC30", Offset = "0xAAD830", VA = "0x180AAEC30", Slot = "102")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700294A RID: 10570
		// (get) Token: 0x06012BB7 RID: 76727 RVA: 0x00072C60 File Offset: 0x00070E60
		[Token(Token = "0x1700294A")]
		public virtual bool enableForceTraceTile
		{
			[Token(Token = "0x6012BB7")]
			[Address(RVA = "0xAAEBC0", Offset = "0xAAD7C0", VA = "0x180AAEBC0", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012BB8 RID: 76728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BB8")]
		[Address(RVA = "0xAAE2B0", Offset = "0xAACEB0", VA = "0x180AAE2B0", Slot = "52")]
		protected override void OnAttached()
		{
		}

		// Token: 0x06012BB9 RID: 76729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BB9")]
		[Address(RVA = "0xAAE340", Offset = "0xAACF40", VA = "0x180AAE340", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x06012BBA RID: 76730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BBA")]
		[Address(RVA = "0xAADF60", Offset = "0xAACB60", VA = "0x180AADF60", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012BBB RID: 76731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BBB")]
		[Address(RVA = "0xAAE220", Offset = "0xAACE20", VA = "0x180AAE220", Slot = "104")]
		public virtual void MarkTraceReached()
		{
		}

		// Token: 0x06012BBC RID: 76732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BBC")]
		[Address(RVA = "0xAAAD10", Offset = "0xAA9910", VA = "0x180AAAD10", Slot = "105")]
		public virtual void SetEnableTrace(bool enable)
		{
		}

		// Token: 0x06012BBD RID: 76733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012BBD")]
		[Address(RVA = "0xAAE8A0", Offset = "0xAAD4A0", VA = "0x180AAE8A0", Slot = "106")]
		public virtual Entity SearchTraceTarget()
		{
			return null;
		}

		// Token: 0x06012BBE RID: 76734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BBE")]
		[Address(RVA = "0xAAE900", Offset = "0xAAD500", VA = "0x180AAE900")]
		public void SetEnableTraceTarget(bool isEnable)
		{
		}

		// Token: 0x06012BBF RID: 76735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BBF")]
		[Address(RVA = "0xAAE970", Offset = "0xAAD570", VA = "0x180AAE970")]
		public void SetEnableTraceTile(bool isEnable)
		{
		}

		// Token: 0x06012BC0 RID: 76736 RVA: 0x00072C78 File Offset: 0x00070E78
		[Token(Token = "0x6012BC0")]
		[Address(RVA = "0xAAE4E0", Offset = "0xAAD0E0", VA = "0x180AAE4E0")]
		protected bool RegisterTraceTile(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x06012BC1 RID: 76737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BC1")]
		[Address(RVA = "0xAAE9E0", Offset = "0xAAD5E0", VA = "0x180AAE9E0")]
		protected BaseTraceTargetAbility()
		{
		}

		// Token: 0x06012BC2 RID: 76738 RVA: 0x00072C90 File Offset: 0x00070E90
		[Token(Token = "0x6012BC2")]
		[Address(RVA = "0xA6E060", Offset = "0xA6CC60", VA = "0x180A6E060")]
		private AbilityStandard.SelectTargetTiming <>xLuaBaseProxy_get_selectTargetTiming()
		{
			return AbilityStandard.SelectTargetTiming.AT_BEGINING;
		}

		// Token: 0x06012BC3 RID: 76739 RVA: 0x00072CA8 File Offset: 0x00070EA8
		[Token(Token = "0x6012BC3")]
		[Address(RVA = "0xA23D10", Offset = "0xA22910", VA = "0x180A23D10")]
		private bool <>xLuaBaseProxy_get_allowNoTarget()
		{
			return default(bool);
		}

		// Token: 0x06012BC4 RID: 76740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BC4")]
		[Address(RVA = "0xA225F0", Offset = "0xA211F0", VA = "0x180A225F0")]
		private void <>xLuaBaseProxy_OnAttached()
		{
		}

		// Token: 0x06012BC5 RID: 76741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BC5")]
		[Address(RVA = "0xA22600", Offset = "0xA21200", VA = "0x180A22600")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x06012BC6 RID: 76742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BC6")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x04015297 RID: 86679
		[Token(Token = "0x4015297")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		protected float _searchCoolDown;

		// Token: 0x04015298 RID: 86680
		[Token(Token = "0x4015298")]
		[FieldOffset(Offset = "0x114")]
		[SerializeField]
		protected bool _enableTraceTarget;

		// Token: 0x04015299 RID: 86681
		[Token(Token = "0x4015299")]
		[FieldOffset(Offset = "0x115")]
		[SerializeField]
		private bool _enableForceTraceTile;

		// Token: 0x0401529A RID: 86682
		[Token(Token = "0x401529A")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		protected Vector2 _traceRandomOffset;

		// Token: 0x0401529B RID: 86683
		[Token(Token = "0x401529B")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private bool _forceTraceTarget;

		// Token: 0x0401529C RID: 86684
		[Token(Token = "0x401529C")]
		[FieldOffset(Offset = "0x128")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		protected Entity m_traceTarget;

		// Token: 0x0401529D RID: 86685
		[Token(Token = "0x401529D")]
		[FieldOffset(Offset = "0x130")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		protected Tile m_traceTile;

		// Token: 0x0401529E RID: 86686
		[Token(Token = "0x401529E")]
		[FieldOffset(Offset = "0x138")]
		protected TracePositionCursor m_tracePositionCursor;

		// Token: 0x0401529F RID: 86687
		[Token(Token = "0x401529F")]
		[FieldOffset(Offset = "0x140")]
		protected bool m_enableTraceTarget;

		// Token: 0x040152A0 RID: 86688
		[Token(Token = "0x40152A0")]
		[FieldOffset(Offset = "0x141")]
		protected bool m_enableTraceTile;

		// Token: 0x040152A1 RID: 86689
		[Token(Token = "0x40152A1")]
		[FieldOffset(Offset = "0x142")]
		protected bool m_enableTrace;

		// Token: 0x040152A2 RID: 86690
		[Token(Token = "0x40152A2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x040152A3 RID: 86691
		[Token(Token = "0x40152A3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_cooldown;

		// Token: 0x040152A4 RID: 86692
		[Token(Token = "0x40152A4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectTargetSource;

		// Token: 0x040152A5 RID: 86693
		[Token(Token = "0x40152A5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_selectTargetTiming;

		// Token: 0x040152A6 RID: 86694
		[Token(Token = "0x40152A6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_alwaysIncludeTarget;

		// Token: 0x040152A7 RID: 86695
		[Token(Token = "0x40152A7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_allowNoTarget;

		// Token: 0x040152A8 RID: 86696
		[Token(Token = "0x40152A8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x040152A9 RID: 86697
		[Token(Token = "0x40152A9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetActiveBuffs;

		// Token: 0x040152AA RID: 86698
		[Token(Token = "0x40152AA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x040152AB RID: 86699
		[Token(Token = "0x40152AB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x040152AC RID: 86700
		[Token(Token = "0x40152AC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnWaitForPreDelay;

		// Token: 0x040152AD RID: 86701
		[Token(Token = "0x40152AD")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnWaitForPostDelay;

		// Token: 0x040152AE RID: 86702
		[Token(Token = "0x40152AE")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_ownerE;

		// Token: 0x040152AF RID: 86703
		[Token(Token = "0x40152AF")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_usingTraceCursor;

		// Token: 0x040152B0 RID: 86704
		[Token(Token = "0x40152B0")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_traceTile;

		// Token: 0x040152B1 RID: 86705
		[Token(Token = "0x40152B1")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_traceTarget;

		// Token: 0x040152B2 RID: 86706
		[Token(Token = "0x40152B2")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_set_traceTarget;

		// Token: 0x040152B3 RID: 86707
		[Token(Token = "0x40152B3")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_tracePositionCursor;

		// Token: 0x040152B4 RID: 86708
		[Token(Token = "0x40152B4")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_hasTraceTarget;

		// Token: 0x040152B5 RID: 86709
		[Token(Token = "0x40152B5")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_enableTrace;

		// Token: 0x040152B6 RID: 86710
		[Token(Token = "0x40152B6")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_enableTraceTarget;

		// Token: 0x040152B7 RID: 86711
		[Token(Token = "0x40152B7")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_enableForceTraceTile;

		// Token: 0x040152B8 RID: 86712
		[Token(Token = "0x40152B8")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnAttached;

		// Token: 0x040152B9 RID: 86713
		[Token(Token = "0x40152B9")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x040152BA RID: 86714
		[Token(Token = "0x40152BA")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x040152BB RID: 86715
		[Token(Token = "0x40152BB")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_MarkTraceReached;

		// Token: 0x040152BC RID: 86716
		[Token(Token = "0x40152BC")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_SetEnableTrace;

		// Token: 0x040152BD RID: 86717
		[Token(Token = "0x40152BD")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_SearchTraceTarget;

		// Token: 0x040152BE RID: 86718
		[Token(Token = "0x40152BE")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_SetEnableTraceTarget;

		// Token: 0x040152BF RID: 86719
		[Token(Token = "0x40152BF")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_SetEnableTraceTile;

		// Token: 0x040152C0 RID: 86720
		[Token(Token = "0x40152C0")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_RegisterTraceTile;

		// Token: 0x040152C1 RID: 86721
		[Token(Token = "0x40152C1")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
