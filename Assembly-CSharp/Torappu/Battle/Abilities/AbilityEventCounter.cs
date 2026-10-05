using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BE5 RID: 11237
	[Token(Token = "0x2002BE5")]
	public class AbilityEventCounter : AbilityStandard.Behaviour
	{
		// Token: 0x170029D2 RID: 10706
		// (get) Token: 0x06012F94 RID: 77716 RVA: 0x00074370 File Offset: 0x00072570
		[Token(Token = "0x170029D2")]
		protected AbilityStandard.Event countEvent
		{
			[Token(Token = "0x6012F94")]
			[Address(RVA = "0xADA750", Offset = "0xAD9350", VA = "0x180ADA750")]
			get
			{
				return AbilityStandard.Event.ON_ATTACHED;
			}
		}

		// Token: 0x170029D3 RID: 10707
		// (get) Token: 0x06012F95 RID: 77717 RVA: 0x00074388 File Offset: 0x00072588
		[Token(Token = "0x170029D3")]
		public int maxCount
		{
			[Token(Token = "0x6012F95")]
			[Address(RVA = "0xADA870", Offset = "0xAD9470", VA = "0x180ADA870")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170029D4 RID: 10708
		// (get) Token: 0x06012F96 RID: 77718 RVA: 0x000743A0 File Offset: 0x000725A0
		[Token(Token = "0x170029D4")]
		public int remainingCount
		{
			[Token(Token = "0x6012F96")]
			[Address(RVA = "0xADAC60", Offset = "0xAD9860", VA = "0x180ADAC60")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170029D5 RID: 10709
		// (get) Token: 0x06012F97 RID: 77719 RVA: 0x000743B8 File Offset: 0x000725B8
		[Token(Token = "0x170029D5")]
		public int progressCount
		{
			[Token(Token = "0x6012F97")]
			[Address(RVA = "0xADA940", Offset = "0xAD9540", VA = "0x180ADA940")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170029D6 RID: 10710
		// (get) Token: 0x06012F98 RID: 77720 RVA: 0x000743D0 File Offset: 0x000725D0
		[Token(Token = "0x170029D6")]
		public bool readyToReset
		{
			[Token(Token = "0x6012F98")]
			[Address(RVA = "0xADAB30", Offset = "0xAD9730", VA = "0x180ADAB30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170029D7 RID: 10711
		// (get) Token: 0x06012F99 RID: 77721 RVA: 0x000743E8 File Offset: 0x000725E8
		[Token(Token = "0x170029D7")]
		protected bool reachEnd
		{
			[Token(Token = "0x6012F99")]
			[Address(RVA = "0xADA9A0", Offset = "0xAD95A0", VA = "0x180ADA9A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170029D8 RID: 10712
		// (get) Token: 0x06012F9A RID: 77722 RVA: 0x00074400 File Offset: 0x00072600
		[Token(Token = "0x170029D8")]
		public int recoverCountLimit
		{
			[Token(Token = "0x6012F9A")]
			[Address(RVA = "0xADAB90", Offset = "0xAD9790", VA = "0x180ADAB90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170029D9 RID: 10713
		// (get) Token: 0x06012F9B RID: 77723 RVA: 0x00074418 File Offset: 0x00072618
		[Token(Token = "0x170029D9")]
		public int remainRecoverCnt
		{
			[Token(Token = "0x6012F9B")]
			[Address(RVA = "0xADAC00", Offset = "0xAD9800", VA = "0x180ADAC00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170029DA RID: 10714
		// (get) Token: 0x06012F9C RID: 77724 RVA: 0x00074430 File Offset: 0x00072630
		[Token(Token = "0x170029DA")]
		public bool canRecoverCnt
		{
			[Token(Token = "0x6012F9C")]
			[Address(RVA = "0xADA690", Offset = "0xAD9290", VA = "0x180ADA690")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170029DB RID: 10715
		// (get) Token: 0x06012F9D RID: 77725 RVA: 0x00074448 File Offset: 0x00072648
		[Token(Token = "0x170029DB")]
		protected bool ignoreTriggerOnce
		{
			[Token(Token = "0x6012F9D")]
			[Address(RVA = "0xADA7B0", Offset = "0xAD93B0", VA = "0x180ADA7B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170029DC RID: 10716
		// (get) Token: 0x06012F9E RID: 77726 RVA: 0x00074460 File Offset: 0x00072660
		[Token(Token = "0x170029DC")]
		public int originalMaxCount
		{
			[Token(Token = "0x6012F9E")]
			[Address(RVA = "0xADA8E0", Offset = "0xAD94E0", VA = "0x180ADA8E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170029DD RID: 10717
		// (get) Token: 0x06012F9F RID: 77727 RVA: 0x00074478 File Offset: 0x00072678
		[Token(Token = "0x170029DD")]
		public bool isNotCountNext
		{
			[Token(Token = "0x6012F9F")]
			[Address(RVA = "0xADA810", Offset = "0xAD9410", VA = "0x180ADA810")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012FA0 RID: 77728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FA0")]
		[Address(RVA = "0xADA470", Offset = "0xAD9070", VA = "0x180ADA470", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x06012FA1 RID: 77729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FA1")]
		[Address(RVA = "0xAD9DE0", Offset = "0xAD89E0", VA = "0x180AD9DE0", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06012FA2 RID: 77730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FA2")]
		[Address(RVA = "0xADA140", Offset = "0xAD8D40", VA = "0x180ADA140", Slot = "13")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012FA3 RID: 77731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FA3")]
		[Address(RVA = "0xAD9BB0", Offset = "0xAD87B0", VA = "0x180AD9BB0", Slot = "16")]
		protected virtual void OnCountEvent(AbilityStandard.Event ev, int triggerTimeCount, bool notCount)
		{
		}

		// Token: 0x06012FA4 RID: 77732 RVA: 0x00074490 File Offset: 0x00072690
		[Token(Token = "0x6012FA4")]
		[Address(RVA = "0xADA400", Offset = "0xAD9000", VA = "0x180ADA400")]
		public bool ResetCount()
		{
			return default(bool);
		}

		// Token: 0x06012FA5 RID: 77733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FA5")]
		[Address(RVA = "0xAD97F0", Offset = "0xAD83F0", VA = "0x180AD97F0")]
		private void DoResetCount()
		{
		}

		// Token: 0x06012FA6 RID: 77734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FA6")]
		[Address(RVA = "0xAD9C40", Offset = "0xAD8840", VA = "0x180AD9C40", Slot = "17")]
		protected virtual void OnCountReset()
		{
		}

		// Token: 0x06012FA7 RID: 77735 RVA: 0x000744A8 File Offset: 0x000726A8
		[Token(Token = "0x6012FA7")]
		[Address(RVA = "0xAD9880", Offset = "0xAD8480", VA = "0x180AD9880", Slot = "18")]
		public virtual FP GetProgress()
		{
			return default(FP);
		}

		// Token: 0x06012FA8 RID: 77736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FA8")]
		[Address(RVA = "0xAD96E0", Offset = "0xAD82E0", VA = "0x180AD96E0")]
		public void DiscardRemainingCount(bool discardSoft = false, bool triggerConsumeEvent = false)
		{
		}

		// Token: 0x06012FA9 RID: 77737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FA9")]
		[Address(RVA = "0xAD9A30", Offset = "0xAD8630", VA = "0x180AD9A30")]
		public void NotCountTimes(bool notCount)
		{
		}

		// Token: 0x06012FAA RID: 77738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FAA")]
		[Address(RVA = "0xAD9AF0", Offset = "0xAD86F0", VA = "0x180AD9AF0")]
		public void NotEmitSpareShotAudioNext(bool notEmit = true)
		{
		}

		// Token: 0x06012FAB RID: 77739 RVA: 0x000744C0 File Offset: 0x000726C0
		[Token(Token = "0x6012FAB")]
		[Address(RVA = "0xADA2B0", Offset = "0xAD8EB0", VA = "0x180ADA2B0")]
		public int RecoverEventCount(int count, bool skipRecoverLimitCheck = false)
		{
			return 0;
		}

		// Token: 0x06012FAC RID: 77740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FAC")]
		[Address(RVA = "0xAD9520", Offset = "0xAD8120", VA = "0x180AD9520")]
		public void ConsumeEventCount(int count, bool triggerConsumeEvt = true)
		{
		}

		// Token: 0x06012FAD RID: 77741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FAD")]
		[Address(RVA = "0xADA590", Offset = "0xAD9190", VA = "0x180ADA590")]
		public void SetMaxAdditionCount(int count)
		{
		}

		// Token: 0x06012FAE RID: 77742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FAE")]
		[Address(RVA = "0xAD9CA0", Offset = "0xAD88A0", VA = "0x180AD9CA0")]
		protected void OnEventCountConsumed(int count)
		{
		}

		// Token: 0x06012FAF RID: 77743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FAF")]
		[Address(RVA = "0xADA1D0", Offset = "0xAD8DD0", VA = "0x180ADA1D0", Slot = "15")]
		public override void PreloadSpecialAudioSignals(string abilityId, string tmplId, Action<string, string> preloader)
		{
		}

		// Token: 0x06012FB0 RID: 77744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FB0")]
		[Address(RVA = "0xADA620", Offset = "0xAD9220", VA = "0x180ADA620")]
		public AbilityEventCounter()
		{
		}

		// Token: 0x06012FB1 RID: 77745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FB1")]
		[Address(RVA = "0xAC3250", Offset = "0xAC1E50", VA = "0x180AC3250")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x06012FB2 RID: 77746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FB2")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x06012FB3 RID: 77747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FB3")]
		[Address(RVA = "0xADA600", Offset = "0xAD9200", VA = "0x180ADA600")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06012FB4 RID: 77748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FB4")]
		[Address(RVA = "0xADA610", Offset = "0xAD9210", VA = "0x180ADA610")]
		private void <>xLuaBaseProxy_PreloadSpecialAudioSignals(string P0, string P1, Action<string, string> P2)
		{
		}

		// Token: 0x040156C8 RID: 87752
		[Token(Token = "0x40156C8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AbilityStandard.Event _countEvent;

		// Token: 0x040156C9 RID: 87753
		[Token(Token = "0x40156C9")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _useAnotherBBKey;

		// Token: 0x040156CA RID: 87754
		[Token(Token = "0x40156CA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _triggerTimeCount;

		// Token: 0x040156CB RID: 87755
		[Token(Token = "0x40156CB")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int _expendPerTrigger;

		// Token: 0x040156CC RID: 87756
		[Token(Token = "0x40156CC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _resetAfterEnd;

		// Token: 0x040156CD RID: 87757
		[Token(Token = "0x40156CD")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		private bool _resetImmediatelyWhenProgressEnd;

		// Token: 0x040156CE RID: 87758
		[Token(Token = "0x40156CE")]
		[FieldOffset(Offset = "0x32")]
		[SerializeField]
		private bool _resetWhenAttackFinished;

		// Token: 0x040156CF RID: 87759
		[Token(Token = "0x40156CF")]
		[FieldOffset(Offset = "0x33")]
		[SerializeField]
		private bool _ignoreTriggerOnce;

		// Token: 0x040156D0 RID: 87760
		[Token(Token = "0x40156D0")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool _overrideRecoverCountLimit;

		// Token: 0x040156D1 RID: 87761
		[Token(Token = "0x40156D1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int _recoverCountLimit;

		// Token: 0x040156D2 RID: 87762
		[Token(Token = "0x40156D2")]
		[FieldOffset(Offset = "0x3C")]
		private int m_eventCount;

		// Token: 0x040156D3 RID: 87763
		[Token(Token = "0x40156D3")]
		[FieldOffset(Offset = "0x40")]
		private int m_maxCount;

		// Token: 0x040156D4 RID: 87764
		[Token(Token = "0x40156D4")]
		[FieldOffset(Offset = "0x44")]
		private int m_originalMaxCount;

		// Token: 0x040156D5 RID: 87765
		[Token(Token = "0x40156D5")]
		[FieldOffset(Offset = "0x48")]
		private int m_maxAdditionCount;

		// Token: 0x040156D6 RID: 87766
		[Token(Token = "0x40156D6")]
		[FieldOffset(Offset = "0x4C")]
		private bool m_readyToReset;

		// Token: 0x040156D7 RID: 87767
		[Token(Token = "0x40156D7")]
		[FieldOffset(Offset = "0x4D")]
		private bool m_notCountNext;

		// Token: 0x040156D8 RID: 87768
		[Token(Token = "0x40156D8")]
		[FieldOffset(Offset = "0x4E")]
		private bool m_notEmitSpareEffectNext;

		// Token: 0x040156D9 RID: 87769
		[Token(Token = "0x40156D9")]
		[FieldOffset(Offset = "0x4F")]
		private bool m_triggerOnce;

		// Token: 0x040156DA RID: 87770
		[Token(Token = "0x40156DA")]
		[FieldOffset(Offset = "0x50")]
		private int m_recoverCountLimitOverride;

		// Token: 0x040156DB RID: 87771
		[Token(Token = "0x40156DB")]
		[FieldOffset(Offset = "0x54")]
		private int m_recoverCount;

		// Token: 0x040156DC RID: 87772
		[Token(Token = "0x40156DC")]
		[FieldOffset(Offset = "0x58")]
		private AbilityEventCounter.EventCounterInfo m_eventInfo;

		// Token: 0x040156DD RID: 87773
		[Token(Token = "0x40156DD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_countEvent;

		// Token: 0x040156DE RID: 87774
		[Token(Token = "0x40156DE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_maxCount;

		// Token: 0x040156DF RID: 87775
		[Token(Token = "0x40156DF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_remainingCount;

		// Token: 0x040156E0 RID: 87776
		[Token(Token = "0x40156E0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_progressCount;

		// Token: 0x040156E1 RID: 87777
		[Token(Token = "0x40156E1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_readyToReset;

		// Token: 0x040156E2 RID: 87778
		[Token(Token = "0x40156E2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_reachEnd;

		// Token: 0x040156E3 RID: 87779
		[Token(Token = "0x40156E3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_recoverCountLimit;

		// Token: 0x040156E4 RID: 87780
		[Token(Token = "0x40156E4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_remainRecoverCnt;

		// Token: 0x040156E5 RID: 87781
		[Token(Token = "0x40156E5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_canRecoverCnt;

		// Token: 0x040156E6 RID: 87782
		[Token(Token = "0x40156E6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_ignoreTriggerOnce;

		// Token: 0x040156E7 RID: 87783
		[Token(Token = "0x40156E7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_originalMaxCount;

		// Token: 0x040156E8 RID: 87784
		[Token(Token = "0x40156E8")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_isNotCountNext;

		// Token: 0x040156E9 RID: 87785
		[Token(Token = "0x40156E9")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x040156EA RID: 87786
		[Token(Token = "0x40156EA")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x040156EB RID: 87787
		[Token(Token = "0x40156EB")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040156EC RID: 87788
		[Token(Token = "0x40156EC")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnCountEvent;

		// Token: 0x040156ED RID: 87789
		[Token(Token = "0x40156ED")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_ResetCount;

		// Token: 0x040156EE RID: 87790
		[Token(Token = "0x40156EE")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_DoResetCount;

		// Token: 0x040156EF RID: 87791
		[Token(Token = "0x40156EF")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnCountReset;

		// Token: 0x040156F0 RID: 87792
		[Token(Token = "0x40156F0")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GetProgress;

		// Token: 0x040156F1 RID: 87793
		[Token(Token = "0x40156F1")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_DiscardRemainingCount;

		// Token: 0x040156F2 RID: 87794
		[Token(Token = "0x40156F2")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_NotCountTimes;

		// Token: 0x040156F3 RID: 87795
		[Token(Token = "0x40156F3")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_NotEmitSpareShotAudioNext;

		// Token: 0x040156F4 RID: 87796
		[Token(Token = "0x40156F4")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_RecoverEventCount;

		// Token: 0x040156F5 RID: 87797
		[Token(Token = "0x40156F5")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_ConsumeEventCount;

		// Token: 0x040156F6 RID: 87798
		[Token(Token = "0x40156F6")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_SetMaxAdditionCount;

		// Token: 0x040156F7 RID: 87799
		[Token(Token = "0x40156F7")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnEventCountConsumed;

		// Token: 0x040156F8 RID: 87800
		[Token(Token = "0x40156F8")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_PreloadSpecialAudioSignals;

		// Token: 0x040156F9 RID: 87801
		[Token(Token = "0x40156F9")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002BE6 RID: 11238
		[Token(Token = "0x2002BE6")]
		public struct EventCounterInfo
		{
			// Token: 0x06012FB5 RID: 77749 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6012FB5")]
			[Address(RVA = "0xAE2E10", Offset = "0xAE1A10", VA = "0x180AE2E10")]
			public EventCounterInfo(Entity entity, int consumeCnt)
			{
			}

			// Token: 0x040156FA RID: 87802
			[Token(Token = "0x40156FA")]
			[FieldOffset(Offset = "0x0")]
			public ObjectPtr<Entity> entity;

			// Token: 0x040156FB RID: 87803
			[Token(Token = "0x40156FB")]
			[FieldOffset(Offset = "0x10")]
			public int consumeCnt;
		}
	}
}
