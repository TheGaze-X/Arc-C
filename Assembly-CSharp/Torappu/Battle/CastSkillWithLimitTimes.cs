using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Abilities;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002452 RID: 9298
	[Token(Token = "0x2002452")]
	public class CastSkillWithLimitTimes : CastSkill
	{
		// Token: 0x17001EF8 RID: 7928
		// (get) Token: 0x0600EECB RID: 61131 RVA: 0x00057BD0 File Offset: 0x00055DD0
		[Token(Token = "0x17001EF8")]
		public override bool isOverloadSkill
		{
			[Token(Token = "0x600EECB")]
			[Address(RVA = "0x644970", Offset = "0x643570", VA = "0x180644970", Slot = "47")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EF9 RID: 7929
		// (get) Token: 0x0600EECC RID: 61132 RVA: 0x00057BE8 File Offset: 0x00055DE8
		[Token(Token = "0x17001EF9")]
		protected bool fetchFromMainAttack
		{
			[Token(Token = "0x600EECC")]
			[Address(RVA = "0x644880", Offset = "0x643480", VA = "0x180644880")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EFA RID: 7930
		// (get) Token: 0x0600EECD RID: 61133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001EFA")]
		public AbilityEventCounter currentProgressSource
		{
			[Token(Token = "0x600EECD")]
			[Address(RVA = "0x644720", Offset = "0x643320", VA = "0x180644720")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001EFB RID: 7931
		// (get) Token: 0x0600EECE RID: 61134 RVA: 0x00057C00 File Offset: 0x00055E00
		[Token(Token = "0x17001EFB")]
		public override FP remainingProgress
		{
			[Token(Token = "0x600EECE")]
			[Address(RVA = "0x645010", Offset = "0x643C10", VA = "0x180645010", Slot = "30")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001EFC RID: 7932
		// (get) Token: 0x0600EECF RID: 61135 RVA: 0x00057C18 File Offset: 0x00055E18
		[Token(Token = "0x17001EFC")]
		public int progressCount
		{
			[Token(Token = "0x600EECF")]
			[Address(RVA = "0x644CC0", Offset = "0x6438C0", VA = "0x180644CC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001EFD RID: 7933
		// (get) Token: 0x0600EED0 RID: 61136 RVA: 0x00057C30 File Offset: 0x00055E30
		[Token(Token = "0x17001EFD")]
		public int remainingCount
		{
			[Token(Token = "0x600EED0")]
			[Address(RVA = "0x644F20", Offset = "0x643B20", VA = "0x180644F20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001EFE RID: 7934
		// (get) Token: 0x0600EED1 RID: 61137 RVA: 0x00057C48 File Offset: 0x00055E48
		[Token(Token = "0x17001EFE")]
		public int maxCount
		{
			[Token(Token = "0x600EED1")]
			[Address(RVA = "0x6449D0", Offset = "0x6435D0", VA = "0x1806449D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001EFF RID: 7935
		// (get) Token: 0x0600EED2 RID: 61138 RVA: 0x00057C60 File Offset: 0x00055E60
		[Token(Token = "0x17001EFF")]
		public int originalMaxCount
		{
			[Token(Token = "0x600EED2")]
			[Address(RVA = "0x644A90", Offset = "0x643690", VA = "0x180644A90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001F00 RID: 7936
		// (get) Token: 0x0600EED3 RID: 61139 RVA: 0x00057C78 File Offset: 0x00055E78
		[Token(Token = "0x17001F00")]
		public override bool hideProgressFlag
		{
			[Token(Token = "0x600EED3")]
			[Address(RVA = "0x6448E0", Offset = "0x6434E0", VA = "0x1806448E0", Slot = "42")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F01 RID: 7937
		// (get) Token: 0x0600EED4 RID: 61140 RVA: 0x00057C90 File Offset: 0x00055E90
		[Token(Token = "0x17001F01")]
		public virtual bool canUseDiscardAbility
		{
			[Token(Token = "0x600EED4")]
			[Address(RVA = "0x640470", Offset = "0x63F070", VA = "0x180640470", Slot = "79")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600EED5 RID: 61141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EED5")]
		[Address(RVA = "0x642C80", Offset = "0x641880", VA = "0x180642C80", Slot = "57")]
		public override void OnInit()
		{
		}

		// Token: 0x0600EED6 RID: 61142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EED6")]
		[Address(RVA = "0x642360", Offset = "0x640F60", VA = "0x180642360", Slot = "48")]
		public override void AssignData(SkillData data, Character owner, Blackboard externalBlackboard, UnitDataFlowConfig.Delta modifier)
		{
		}

		// Token: 0x0600EED7 RID: 61143 RVA: 0x00057CA8 File Offset: 0x00055EA8
		[Token(Token = "0x600EED7")]
		[Address(RVA = "0x643D10", Offset = "0x642910", VA = "0x180643D10")]
		private FP _GetProgress()
		{
			return default(FP);
		}

		// Token: 0x0600EED8 RID: 61144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EED8")]
		[Address(RVA = "0x6435B0", Offset = "0x6421B0", VA = "0x1806435B0")]
		private void _FetchCounterSource()
		{
		}

		// Token: 0x0600EED9 RID: 61145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EED9")]
		[Address(RVA = "0x644190", Offset = "0x642D90", VA = "0x180644190")]
		private void _UpdateMaxAdditionCount()
		{
		}

		// Token: 0x0600EEDA RID: 61146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EEDA")]
		[Address(RVA = "0x643770", Offset = "0x642370", VA = "0x180643770")]
		private void _FetchExtraCounter()
		{
		}

		// Token: 0x0600EEDB RID: 61147 RVA: 0x00057CC0 File Offset: 0x00055EC0
		[Token(Token = "0x600EEDB")]
		[Address(RVA = "0x643E70", Offset = "0x642A70", VA = "0x180643E70")]
		private bool _ResetExtraModeCount()
		{
			return default(bool);
		}

		// Token: 0x0600EEDC RID: 61148 RVA: 0x00057CD8 File Offset: 0x00055ED8
		[Token(Token = "0x600EEDC")]
		[Address(RVA = "0x6433F0", Offset = "0x641FF0", VA = "0x1806433F0")]
		private bool _ExtraModeCanReset()
		{
			return default(bool);
		}

		// Token: 0x17001F02 RID: 7938
		// (get) Token: 0x0600EEDD RID: 61149 RVA: 0x00057CF0 File Offset: 0x00055EF0
		[Token(Token = "0x17001F02")]
		protected bool ownerIsInBulletMode
		{
			[Token(Token = "0x600EEDD")]
			[Address(RVA = "0x644B50", Offset = "0x643750", VA = "0x180644B50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600EEDE RID: 61150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EEDE")]
		[Address(RVA = "0x642D70", Offset = "0x641970", VA = "0x180642D70", Slot = "74")]
		protected override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600EEDF RID: 61151 RVA: 0x00057D08 File Offset: 0x00055F08
		[Token(Token = "0x600EEDF")]
		[Address(RVA = "0x642B00", Offset = "0x641700", VA = "0x180642B00", Slot = "24")]
		public override bool IsDiscardable()
		{
			return default(bool);
		}

		// Token: 0x0600EEE0 RID: 61152 RVA: 0x00057D20 File Offset: 0x00055F20
		[Token(Token = "0x600EEE0")]
		[Address(RVA = "0x643320", Offset = "0x641F20", VA = "0x180643320", Slot = "51")]
		public override bool UseSkill(PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EEE1 RID: 61153 RVA: 0x00057D38 File Offset: 0x00055F38
		[Token(Token = "0x600EEE1")]
		[Address(RVA = "0x642560", Offset = "0x641160", VA = "0x180642560", Slot = "80")]
		protected virtual bool DiscardRemainingCountInternal()
		{
			return default(bool);
		}

		// Token: 0x0600EEE2 RID: 61154 RVA: 0x00057D50 File Offset: 0x00055F50
		[Token(Token = "0x600EEE2")]
		[Address(RVA = "0x640410", Offset = "0x63F010", VA = "0x180640410", Slot = "81")]
		protected virtual bool UseDiscardAbility()
		{
			return default(bool);
		}

		// Token: 0x0600EEE3 RID: 61155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EEE3")]
		[Address(RVA = "0x6403A0", Offset = "0x63EFA0", VA = "0x1806403A0", Slot = "82")]
		protected virtual void OnDiscard()
		{
		}

		// Token: 0x0600EEE4 RID: 61156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EEE4")]
		[Address(RVA = "0x6429D0", Offset = "0x6415D0", VA = "0x1806429D0")]
		public string GetCountProgress()
		{
			return null;
		}

		// Token: 0x0600EEE5 RID: 61157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EEE5")]
		[Address(RVA = "0x642BE0", Offset = "0x6417E0", VA = "0x180642BE0", Slot = "83")]
		public virtual void NotCountTimes(bool notCount)
		{
		}

		// Token: 0x0600EEE6 RID: 61158 RVA: 0x00057D68 File Offset: 0x00055F68
		[Token(Token = "0x600EEE6")]
		[Address(RVA = "0x642F70", Offset = "0x641B70", VA = "0x180642F70")]
		public int RecoverEventCount(int count, bool skipRecoverLimitCheck = false)
		{
			return 0;
		}

		// Token: 0x0600EEE7 RID: 61159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EEE7")]
		[Address(RVA = "0x6424B0", Offset = "0x6410B0", VA = "0x1806424B0")]
		public void ConsumeEventCount(int count, bool triggerConsumeEvent = true)
		{
		}

		// Token: 0x0600EEE8 RID: 61160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EEE8")]
		[Address(RVA = "0x642920", Offset = "0x641520", VA = "0x180642920")]
		public void DiscardRemainingCount(bool discardSoft, bool triggerConsumeEvent)
		{
		}

		// Token: 0x0600EEE9 RID: 61161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EEE9")]
		[Address(RVA = "0x643190", Offset = "0x641D90", VA = "0x180643190")]
		public void SetMaxAdditionCount(Buff buff, int count)
		{
		}

		// Token: 0x0600EEEA RID: 61162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EEEA")]
		[Address(RVA = "0x643030", Offset = "0x641C30", VA = "0x180643030")]
		public void SetMaxAdditionCountPercent(Buff buff, float percent)
		{
		}

		// Token: 0x0600EEEB RID: 61163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EEEB")]
		[Address(RVA = "0x644590", Offset = "0x643190", VA = "0x180644590")]
		public CastSkillWithLimitTimes()
		{
		}

		// Token: 0x0600EEEC RID: 61164 RVA: 0x00057D80 File Offset: 0x00055F80
		[Token(Token = "0x600EEEC")]
		[Address(RVA = "0x63D7A0", Offset = "0x63C3A0", VA = "0x18063D7A0")]
		private bool <>xLuaBaseProxy_get_isOverloadSkill()
		{
			return default(bool);
		}

		// Token: 0x0600EEED RID: 61165 RVA: 0x00057D98 File Offset: 0x00055F98
		[Token(Token = "0x600EEED")]
		[Address(RVA = "0x6346D0", Offset = "0x6332D0", VA = "0x1806346D0")]
		private FP <>xLuaBaseProxy_get_remainingProgress()
		{
			return default(FP);
		}

		// Token: 0x0600EEEE RID: 61166 RVA: 0x00057DB0 File Offset: 0x00055FB0
		[Token(Token = "0x600EEEE")]
		[Address(RVA = "0x63D480", Offset = "0x63C080", VA = "0x18063D480")]
		private bool <>xLuaBaseProxy_get_hideProgressFlag()
		{
			return default(bool);
		}

		// Token: 0x0600EEEF RID: 61167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EEEF")]
		[Address(RVA = "0x641620", Offset = "0x640220", VA = "0x180641620")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0600EEF0 RID: 61168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EEF0")]
		[Address(RVA = "0x6432F0", Offset = "0x641EF0", VA = "0x1806432F0")]
		private void <>xLuaBaseProxy_AssignData(SkillData P0, Character P1, Blackboard P2, UnitDataFlowConfig.Delta P3)
		{
		}

		// Token: 0x0600EEF1 RID: 61169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EEF1")]
		[Address(RVA = "0x636850", Offset = "0x635450", VA = "0x180636850")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600EEF2 RID: 61170 RVA: 0x00057DC8 File Offset: 0x00055FC8
		[Token(Token = "0x600EEF2")]
		[Address(RVA = "0x6345F0", Offset = "0x6331F0", VA = "0x1806345F0")]
		private bool <>xLuaBaseProxy_IsDiscardable()
		{
			return default(bool);
		}

		// Token: 0x0600EEF3 RID: 61171 RVA: 0x00057DE0 File Offset: 0x00055FE0
		[Token(Token = "0x600EEF3")]
		[Address(RVA = "0x641630", Offset = "0x640230", VA = "0x180641630")]
		private bool <>xLuaBaseProxy_UseSkill(PlayerSide P0)
		{
			return default(bool);
		}

		// Token: 0x04010813 RID: 67603
		[Token(Token = "0x4010813")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private AbilityEventCounter _progressSource;

		// Token: 0x04010814 RID: 67604
		[Token(Token = "0x4010814")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private bool _fetchFromMainAttack;

		// Token: 0x04010815 RID: 67605
		[Token(Token = "0x4010815")]
		[FieldOffset(Offset = "0x149")]
		[SerializeField]
		[Inspect("fetchFromMainAttack")]
		private bool _fromMainRawAttack;

		// Token: 0x04010816 RID: 67606
		[Token(Token = "0x4010816")]
		[FieldOffset(Offset = "0x14C")]
		[SerializeField]
		[Inspect("fetchFromMainAttack")]
		private int _modeIndex;

		// Token: 0x04010817 RID: 67607
		[Token(Token = "0x4010817")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		[Inspect("fetchFromMainAttack")]
		private int[] _extraModeIndex;

		// Token: 0x04010818 RID: 67608
		[Token(Token = "0x4010818")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		[Inspect("fetchFromMainAttack")]
		private bool _useExtraModeProgress;

		// Token: 0x04010819 RID: 67609
		[Token(Token = "0x4010819")]
		[FieldOffset(Offset = "0x159")]
		[SerializeField]
		private bool _finishSkillWithProgress;

		// Token: 0x0401081A RID: 67610
		[Token(Token = "0x401081A")]
		[FieldOffset(Offset = "0x15A")]
		[SerializeField]
		private bool _canDiscardRemainingCount;

		// Token: 0x0401081B RID: 67611
		[Token(Token = "0x401081B")]
		[FieldOffset(Offset = "0x15B")]
		[SerializeField]
		private bool _hideProgressOnAffect;

		// Token: 0x0401081C RID: 67612
		[Token(Token = "0x401081C")]
		[FieldOffset(Offset = "0x15C")]
		[SerializeField]
		private bool _isOverloadSkill;

		// Token: 0x0401081D RID: 67613
		[Token(Token = "0x401081D")]
		[FieldOffset(Offset = "0x160")]
		private AbilityEventCounter m_progressSource;

		// Token: 0x0401081E RID: 67614
		[Token(Token = "0x401081E")]
		[FieldOffset(Offset = "0x168")]
		private Dictionary<int, AbilityEventCounter> m_extraProgressSources;

		// Token: 0x0401081F RID: 67615
		[Token(Token = "0x401081F")]
		[FieldOffset(Offset = "0x170")]
		private Dictionary<uint, int> m_eventCounterMaxCountModifier;

		// Token: 0x04010820 RID: 67616
		[Token(Token = "0x4010820")]
		[FieldOffset(Offset = "0x178")]
		private Dictionary<uint, float> m_eventCounterMaxCountPerCentModifier;

		// Token: 0x04010821 RID: 67617
		[Token(Token = "0x4010821")]
		[FieldOffset(Offset = "0x180")]
		private int m_discardCnt;

		// Token: 0x04010822 RID: 67618
		[Token(Token = "0x4010822")]
		[FieldOffset(Offset = "0x184")]
		private int m_maxDiscardCnt;

		// Token: 0x04010823 RID: 67619
		[Token(Token = "0x4010823")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isOverloadSkill;

		// Token: 0x04010824 RID: 67620
		[Token(Token = "0x4010824")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_fetchFromMainAttack;

		// Token: 0x04010825 RID: 67621
		[Token(Token = "0x4010825")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_currentProgressSource;

		// Token: 0x04010826 RID: 67622
		[Token(Token = "0x4010826")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_remainingProgress;

		// Token: 0x04010827 RID: 67623
		[Token(Token = "0x4010827")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_progressCount;

		// Token: 0x04010828 RID: 67624
		[Token(Token = "0x4010828")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_remainingCount;

		// Token: 0x04010829 RID: 67625
		[Token(Token = "0x4010829")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_maxCount;

		// Token: 0x0401082A RID: 67626
		[Token(Token = "0x401082A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_originalMaxCount;

		// Token: 0x0401082B RID: 67627
		[Token(Token = "0x401082B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_hideProgressFlag;

		// Token: 0x0401082C RID: 67628
		[Token(Token = "0x401082C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_canUseDiscardAbility;

		// Token: 0x0401082D RID: 67629
		[Token(Token = "0x401082D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401082E RID: 67630
		[Token(Token = "0x401082E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x0401082F RID: 67631
		[Token(Token = "0x401082F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GetProgress;

		// Token: 0x04010830 RID: 67632
		[Token(Token = "0x4010830")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__FetchCounterSource;

		// Token: 0x04010831 RID: 67633
		[Token(Token = "0x4010831")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__UpdateMaxAdditionCount;

		// Token: 0x04010832 RID: 67634
		[Token(Token = "0x4010832")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__FetchExtraCounter;

		// Token: 0x04010833 RID: 67635
		[Token(Token = "0x4010833")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ResetExtraModeCount;

		// Token: 0x04010834 RID: 67636
		[Token(Token = "0x4010834")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ExtraModeCanReset;

		// Token: 0x04010835 RID: 67637
		[Token(Token = "0x4010835")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_ownerIsInBulletMode;

		// Token: 0x04010836 RID: 67638
		[Token(Token = "0x4010836")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04010837 RID: 67639
		[Token(Token = "0x4010837")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_IsDiscardable;

		// Token: 0x04010838 RID: 67640
		[Token(Token = "0x4010838")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_UseSkill;

		// Token: 0x04010839 RID: 67641
		[Token(Token = "0x4010839")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_DiscardRemainingCountInternal;

		// Token: 0x0401083A RID: 67642
		[Token(Token = "0x401083A")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_UseDiscardAbility;

		// Token: 0x0401083B RID: 67643
		[Token(Token = "0x401083B")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnDiscard;

		// Token: 0x0401083C RID: 67644
		[Token(Token = "0x401083C")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_GetCountProgress;

		// Token: 0x0401083D RID: 67645
		[Token(Token = "0x401083D")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_NotCountTimes;

		// Token: 0x0401083E RID: 67646
		[Token(Token = "0x401083E")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_RecoverEventCount;

		// Token: 0x0401083F RID: 67647
		[Token(Token = "0x401083F")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_ConsumeEventCount;

		// Token: 0x04010840 RID: 67648
		[Token(Token = "0x4010840")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_DiscardRemainingCount;

		// Token: 0x04010841 RID: 67649
		[Token(Token = "0x4010841")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_SetMaxAdditionCount;

		// Token: 0x04010842 RID: 67650
		[Token(Token = "0x4010842")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_SetMaxAdditionCountPercent;

		// Token: 0x04010843 RID: 67651
		[Token(Token = "0x4010843")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
