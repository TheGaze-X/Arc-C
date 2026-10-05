using System;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200244F RID: 9295
	[Token(Token = "0x200244F")]
	public class CastSkill : BasicSkill
	{
		// Token: 0x17001EEC RID: 7916
		// (get) Token: 0x0600EE8A RID: 61066 RVA: 0x00057828 File Offset: 0x00055A28
		[Token(Token = "0x17001EEC")]
		private bool NotHideRangeToShow
		{
			[Token(Token = "0x600EE8A")]
			[Address(RVA = "0x6469F0", Offset = "0x6455F0", VA = "0x1806469F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EED RID: 7917
		// (get) Token: 0x0600EE8B RID: 61067 RVA: 0x00057840 File Offset: 0x00055A40
		[Token(Token = "0x17001EED")]
		private bool switchToState
		{
			[Token(Token = "0x600EE8B")]
			[Address(RVA = "0x6472B0", Offset = "0x645EB0", VA = "0x1806472B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EEE RID: 7918
		// (get) Token: 0x0600EE8C RID: 61068 RVA: 0x00057858 File Offset: 0x00055A58
		[Token(Token = "0x17001EEE")]
		public override bool stateUninterruptible
		{
			[Token(Token = "0x600EE8C")]
			[Address(RVA = "0x6471A0", Offset = "0x645DA0", VA = "0x1806471A0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600EE8D RID: 61069 RVA: 0x00057870 File Offset: 0x00055A70
		[Token(Token = "0x600EE8D")]
		[Address(RVA = "0x6459A0", Offset = "0x6445A0", VA = "0x1806459A0", Slot = "19")]
		public override bool IsAvailable(PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EE8E RID: 61070 RVA: 0x00057888 File Offset: 0x00055A88
		[Token(Token = "0x600EE8E")]
		[Address(RVA = "0x646600", Offset = "0x645200", VA = "0x180646600")]
		private bool _IsTokenValid()
		{
			return default(bool);
		}

		// Token: 0x17001EEF RID: 7919
		// (get) Token: 0x0600EE8F RID: 61071 RVA: 0x000578A0 File Offset: 0x00055AA0
		[Token(Token = "0x17001EEF")]
		public override bool shouldCastLikeAttack
		{
			[Token(Token = "0x600EE8F")]
			[Address(RVA = "0x646EC0", Offset = "0x645AC0", VA = "0x180646EC0", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EF0 RID: 7920
		// (get) Token: 0x0600EE90 RID: 61072 RVA: 0x000578B8 File Offset: 0x00055AB8
		[Token(Token = "0x17001EF0")]
		public override bool shouldChangeToChargeColor
		{
			[Token(Token = "0x600EE90")]
			[Address(RVA = "0x646F40", Offset = "0x645B40", VA = "0x180646F40", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EF1 RID: 7921
		// (get) Token: 0x0600EE91 RID: 61073 RVA: 0x000578D0 File Offset: 0x00055AD0
		[Token(Token = "0x17001EF1")]
		public override bool isRemoteControlled
		{
			[Token(Token = "0x600EE91")]
			[Address(RVA = "0x646CB0", Offset = "0x6458B0", VA = "0x180646CB0", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EF2 RID: 7922
		// (get) Token: 0x0600EE92 RID: 61074 RVA: 0x000578E8 File Offset: 0x00055AE8
		[Token(Token = "0x17001EF2")]
		protected override bool forceUseBaseShowRange
		{
			[Token(Token = "0x600EE92")]
			[Address(RVA = "0x646B80", Offset = "0x645780", VA = "0x180646B80", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EF3 RID: 7923
		// (get) Token: 0x0600EE93 RID: 61075 RVA: 0x00057900 File Offset: 0x00055B00
		[Token(Token = "0x17001EF3")]
		public override bool canCastCheck
		{
			[Token(Token = "0x600EE93")]
			[Address(RVA = "0x646A70", Offset = "0x645670", VA = "0x180646A70", Slot = "45")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600EE94 RID: 61076 RVA: 0x00057918 File Offset: 0x00055B18
		[Token(Token = "0x600EE94")]
		[Address(RVA = "0x645370", Offset = "0x643F70", VA = "0x180645370", Slot = "56")]
		public override bool CanCastCheckBeforeStart()
		{
			return default(bool);
		}

		// Token: 0x17001EF4 RID: 7924
		// (get) Token: 0x0600EE95 RID: 61077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001EF4")]
		public override IDrawableRange rangeToShow
		{
			[Token(Token = "0x600EE95")]
			[Address(RVA = "0x646D30", Offset = "0x645930", VA = "0x180646D30", Slot = "36")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600EE96 RID: 61078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE96")]
		[Address(RVA = "0x645F10", Offset = "0x644B10", VA = "0x180645F10", Slot = "57")]
		public override void OnInit()
		{
		}

		// Token: 0x0600EE97 RID: 61079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE97")]
		[Address(RVA = "0x645200", Offset = "0x643E00", VA = "0x180645200", Slot = "48")]
		public override void AssignData(SkillData data, Character owner, Blackboard externalBlackboard, UnitDataFlowConfig.Delta modifier)
		{
		}

		// Token: 0x0600EE98 RID: 61080 RVA: 0x00057930 File Offset: 0x00055B30
		[Token(Token = "0x600EE98")]
		[Address(RVA = "0x645490", Offset = "0x644090", VA = "0x180645490", Slot = "49")]
		protected override bool DoCast([Optional] Ability.FinishCallbackDelegate finishCb, PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EE99 RID: 61081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE99")]
		[Address(RVA = "0x645C10", Offset = "0x644810", VA = "0x180645C10", Slot = "76")]
		protected override void OnCastFinish(Ability ability, Ability.FinishReason reason, bool resetCd)
		{
		}

		// Token: 0x0600EE9A RID: 61082 RVA: 0x00057948 File Offset: 0x00055B48
		[Token(Token = "0x600EE9A")]
		[Address(RVA = "0x6462E0", Offset = "0x644EE0", VA = "0x1806462E0", Slot = "51")]
		public override bool UseSkill(PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EE9B RID: 61083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE9B")]
		[Address(RVA = "0x646140", Offset = "0x644D40", VA = "0x180646140", Slot = "74")]
		protected override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600EE9C RID: 61084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE9C")]
		[Address(RVA = "0x646740", Offset = "0x645340", VA = "0x180646740")]
		private void _RecoverSp(int delta)
		{
		}

		// Token: 0x0600EE9D RID: 61085 RVA: 0x00057960 File Offset: 0x00055B60
		[Token(Token = "0x600EE9D")]
		[Address(RVA = "0x646540", Offset = "0x645140", VA = "0x180646540")]
		private bool _CheckIfSkillStateUninterruptible()
		{
			return default(bool);
		}

		// Token: 0x17001EF5 RID: 7925
		// (get) Token: 0x0600EE9E RID: 61086 RVA: 0x00057978 File Offset: 0x00055B78
		[Token(Token = "0x17001EF5")]
		public override bool isAvailableToShowStackCount
		{
			[Token(Token = "0x600EE9E")]
			[Address(RVA = "0x646C00", Offset = "0x645800", VA = "0x180646C00", Slot = "78")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600EE9F RID: 61087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE9F")]
		[Address(RVA = "0x645920", Offset = "0x644520", VA = "0x180645920")]
		public void ForceHideRangeToShow()
		{
		}

		// Token: 0x0600EEA0 RID: 61088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EEA0")]
		[Address(RVA = "0x646960", Offset = "0x645560", VA = "0x180646960")]
		public CastSkill()
		{
		}

		// Token: 0x0600EEA2 RID: 61090 RVA: 0x00057990 File Offset: 0x00055B90
		[Token(Token = "0x600EEA2")]
		[Address(RVA = "0x63F0D0", Offset = "0x63DCD0", VA = "0x18063F0D0")]
		private bool <>xLuaBaseProxy_get_stateUninterruptible()
		{
			return default(bool);
		}

		// Token: 0x0600EEA3 RID: 61091 RVA: 0x000579A8 File Offset: 0x00055BA8
		[Token(Token = "0x600EEA3")]
		[Address(RVA = "0x634DF0", Offset = "0x6339F0", VA = "0x180634DF0")]
		private bool <>xLuaBaseProxy_IsAvailable(PlayerSide P0)
		{
			return default(bool);
		}

		// Token: 0x0600EEA4 RID: 61092 RVA: 0x000579C0 File Offset: 0x00055BC0
		[Token(Token = "0x600EEA4")]
		[Address(RVA = "0x63ECB0", Offset = "0x63D8B0", VA = "0x18063ECB0")]
		private bool <>xLuaBaseProxy_get_shouldCastLikeAttack()
		{
			return default(bool);
		}

		// Token: 0x0600EEA5 RID: 61093 RVA: 0x000579D8 File Offset: 0x00055BD8
		[Token(Token = "0x600EEA5")]
		[Address(RVA = "0x63ED10", Offset = "0x63D910", VA = "0x18063ED10")]
		private bool <>xLuaBaseProxy_get_shouldChangeToChargeColor()
		{
			return default(bool);
		}

		// Token: 0x0600EEA6 RID: 61094 RVA: 0x000579F0 File Offset: 0x00055BF0
		[Token(Token = "0x600EEA6")]
		[Address(RVA = "0x63D860", Offset = "0x63C460", VA = "0x18063D860")]
		private bool <>xLuaBaseProxy_get_isRemoteControlled()
		{
			return default(bool);
		}

		// Token: 0x0600EEA7 RID: 61095 RVA: 0x00057A08 File Offset: 0x00055C08
		[Token(Token = "0x600EEA7")]
		[Address(RVA = "0x63D140", Offset = "0x63BD40", VA = "0x18063D140")]
		private bool <>xLuaBaseProxy_get_forceUseBaseShowRange()
		{
			return default(bool);
		}

		// Token: 0x0600EEA8 RID: 61096 RVA: 0x00057A20 File Offset: 0x00055C20
		[Token(Token = "0x600EEA8")]
		[Address(RVA = "0x63CC40", Offset = "0x63B840", VA = "0x18063CC40")]
		private bool <>xLuaBaseProxy_get_canCastCheck()
		{
			return default(bool);
		}

		// Token: 0x0600EEA9 RID: 61097 RVA: 0x00057A38 File Offset: 0x00055C38
		[Token(Token = "0x600EEA9")]
		[Address(RVA = "0x637710", Offset = "0x636310", VA = "0x180637710")]
		private bool <>xLuaBaseProxy_CanCastCheckBeforeStart()
		{
			return default(bool);
		}

		// Token: 0x0600EEAA RID: 61098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EEAA")]
		[Address(RVA = "0x6462D0", Offset = "0x644ED0", VA = "0x1806462D0")]
		private IDrawableRange <>xLuaBaseProxy_get_rangeToShow()
		{
			return null;
		}

		// Token: 0x0600EEAB RID: 61099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EEAB")]
		[Address(RVA = "0x634E10", Offset = "0x633A10", VA = "0x180634E10")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0600EEAC RID: 61100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EEAC")]
		[Address(RVA = "0x635EA0", Offset = "0x634AA0", VA = "0x180635EA0")]
		private void <>xLuaBaseProxy_AssignData(SkillData P0, Character P1, Blackboard P2, UnitDataFlowConfig.Delta P3)
		{
		}

		// Token: 0x0600EEAD RID: 61101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EEAD")]
		[Address(RVA = "0x6462C0", Offset = "0x644EC0", VA = "0x1806462C0")]
		private void <>xLuaBaseProxy_OnCastFinish(Ability P0, Ability.FinishReason P1, bool P2)
		{
		}

		// Token: 0x0600EEAE RID: 61102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EEAE")]
		[Address(RVA = "0x635F00", Offset = "0x634B00", VA = "0x180635F00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600EEAF RID: 61103 RVA: 0x00057A50 File Offset: 0x00055C50
		[Token(Token = "0x600EEAF")]
		[Address(RVA = "0x63D5C0", Offset = "0x63C1C0", VA = "0x18063D5C0")]
		private bool <>xLuaBaseProxy_get_isAvailableToShowStackCount()
		{
			return default(bool);
		}

		// Token: 0x040107D4 RID: 67540
		[Token(Token = "0x40107D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		protected TargetTrigger _trigger;

		// Token: 0x040107D5 RID: 67541
		[Token(Token = "0x40107D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private bool _switchToState;

		// Token: 0x040107D6 RID: 67542
		[Token(Token = "0x40107D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x121")]
		[SerializeField]
		[Inspect("switchToState")]
		private bool _uninterruptibleOnAbilityPredelay;

		// Token: 0x040107D7 RID: 67543
		[Token(Token = "0x40107D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x122")]
		[SerializeField]
		private bool _canSwitchDuringBorn;

		// Token: 0x040107D8 RID: 67544
		[Token(Token = "0x40107D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x123")]
		[SerializeField]
		private bool _canCastDuringBorn;

		// Token: 0x040107D9 RID: 67545
		[Token(Token = "0x40107D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[SerializeField]
		private bool _checkHasTargetBeforeDoCast;

		// Token: 0x040107DA RID: 67546
		[Token(Token = "0x40107DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x125")]
		[SerializeField]
		[Group("Trigger")]
		protected bool _useTriggerInManualMode;

		// Token: 0x040107DB RID: 67547
		[Token(Token = "0x40107DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x126")]
		[SerializeField]
		[Group("Trigger")]
		protected bool _allowNoTarget;

		// Token: 0x040107DC RID: 67548
		[Token(Token = "0x40107DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x127")]
		[SerializeField]
		[Group("Internal")]
		private bool _shouldCastLikeAttack;

		// Token: 0x040107DD RID: 67549
		[Token(Token = "0x40107DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		private bool _isRemoteControlled;

		// Token: 0x040107DE RID: 67550
		[Token(Token = "0x40107DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
		[SerializeField]
		[Group("Range")]
		private bool _hideRangeToShow;

		// Token: 0x040107DF RID: 67551
		[Token(Token = "0x40107DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12A")]
		[SerializeField]
		[Group("Range")]
		[Inspect("NotHideRangeToShow")]
		private bool _forceUseBaseShowRange;

		// Token: 0x040107E0 RID: 67552
		[Token(Token = "0x40107E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		[Group("Range")]
		[Inspect("NotHideRangeToShow")]
		private TargetSelector _rangeToShow;

		// Token: 0x040107E1 RID: 67553
		[Token(Token = "0x40107E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		private bool _recoverSpIfNoTarget;

		// Token: 0x040107E2 RID: 67554
		[Token(Token = "0x40107E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x139")]
		[SerializeField]
		private bool _resetAbilityCooldownWhenCastEnd;

		// Token: 0x040107E3 RID: 67555
		[Token(Token = "0x40107E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13A")]
		[SerializeField]
		private bool _onlyAvailableWhenTokenValid;

		// Token: 0x040107E4 RID: 67556
		[Token(Token = "0x40107E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13B")]
		[SerializeField]
		private bool _hasUniStackColor;

		// Token: 0x040107E5 RID: 67557
		[Token(Token = "0x40107E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int MIN_STACK_COUNT_TO_CHANGE_COLOR;

		// Token: 0x040107E6 RID: 67558
		[Token(Token = "0x40107E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private bool m_hideRangeToShow;

		// Token: 0x040107E7 RID: 67559
		[Token(Token = "0x40107E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_NotHideRangeToShow;

		// Token: 0x040107E8 RID: 67560
		[Token(Token = "0x40107E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_switchToState;

		// Token: 0x040107E9 RID: 67561
		[Token(Token = "0x40107E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_stateUninterruptible;

		// Token: 0x040107EA RID: 67562
		[Token(Token = "0x40107EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IsAvailable;

		// Token: 0x040107EB RID: 67563
		[Token(Token = "0x40107EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__IsTokenValid;

		// Token: 0x040107EC RID: 67564
		[Token(Token = "0x40107EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_shouldCastLikeAttack;

		// Token: 0x040107ED RID: 67565
		[Token(Token = "0x40107ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_shouldChangeToChargeColor;

		// Token: 0x040107EE RID: 67566
		[Token(Token = "0x40107EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_isRemoteControlled;

		// Token: 0x040107EF RID: 67567
		[Token(Token = "0x40107EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_forceUseBaseShowRange;

		// Token: 0x040107F0 RID: 67568
		[Token(Token = "0x40107F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_canCastCheck;

		// Token: 0x040107F1 RID: 67569
		[Token(Token = "0x40107F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CanCastCheckBeforeStart;

		// Token: 0x040107F2 RID: 67570
		[Token(Token = "0x40107F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_rangeToShow;

		// Token: 0x040107F3 RID: 67571
		[Token(Token = "0x40107F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040107F4 RID: 67572
		[Token(Token = "0x40107F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x040107F5 RID: 67573
		[Token(Token = "0x40107F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_DoCast;

		// Token: 0x040107F6 RID: 67574
		[Token(Token = "0x40107F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnCastFinish;

		// Token: 0x040107F7 RID: 67575
		[Token(Token = "0x40107F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_UseSkill;

		// Token: 0x040107F8 RID: 67576
		[Token(Token = "0x40107F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040107F9 RID: 67577
		[Token(Token = "0x40107F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__RecoverSp;

		// Token: 0x040107FA RID: 67578
		[Token(Token = "0x40107FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__CheckIfSkillStateUninterruptible;

		// Token: 0x040107FB RID: 67579
		[Token(Token = "0x40107FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_isAvailableToShowStackCount;

		// Token: 0x040107FC RID: 67580
		[Token(Token = "0x40107FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_ForceHideRangeToShow;

		// Token: 0x040107FD RID: 67581
		[Token(Token = "0x40107FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
