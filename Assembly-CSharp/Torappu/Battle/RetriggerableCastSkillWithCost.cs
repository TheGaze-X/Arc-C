using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200245E RID: 9310
	[Token(Token = "0x200245E")]
	public class RetriggerableCastSkillWithCost : CastSkillWithCost
	{
		// Token: 0x17001F0C RID: 7948
		// (get) Token: 0x0600EF5D RID: 61277 RVA: 0x00058158 File Offset: 0x00056358
		[Token(Token = "0x17001F0C")]
		public int retriggerCost
		{
			[Token(Token = "0x600EF5D")]
			[Address(RVA = "0x67ACE0", Offset = "0x6798E0", VA = "0x18067ACE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001F0D RID: 7949
		// (get) Token: 0x0600EF5E RID: 61278 RVA: 0x00058170 File Offset: 0x00056370
		[Token(Token = "0x17001F0D")]
		public bool isTriggerCntUsedUp
		{
			[Token(Token = "0x600EF5E")]
			[Address(RVA = "0x67AA60", Offset = "0x679660", VA = "0x18067AA60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F0E RID: 7950
		// (get) Token: 0x0600EF5F RID: 61279 RVA: 0x00058188 File Offset: 0x00056388
		[Token(Token = "0x17001F0E")]
		public FP retriggerCooldownProgress
		{
			[Token(Token = "0x600EF5F")]
			[Address(RVA = "0x67AC20", Offset = "0x679820", VA = "0x18067AC20")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001F0F RID: 7951
		// (get) Token: 0x0600EF60 RID: 61280 RVA: 0x000581A0 File Offset: 0x000563A0
		[Token(Token = "0x17001F0F")]
		public bool isCooldown
		{
			[Token(Token = "0x600EF60")]
			[Address(RVA = "0x67A9B0", Offset = "0x6795B0", VA = "0x18067A9B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600EF61 RID: 61281 RVA: 0x000581B8 File Offset: 0x000563B8
		[Token(Token = "0x600EF61")]
		[Address(RVA = "0x67AD90", Offset = "0x679990", VA = "0x18067AD90", Slot = "23")]
		public override bool isRetriggerable()
		{
			return default(bool);
		}

		// Token: 0x17001F10 RID: 7952
		// (get) Token: 0x0600EF62 RID: 61282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F10")]
		public Ability currentRetriggerAbility
		{
			[Token(Token = "0x600EF62")]
			[Address(RVA = "0x67A950", Offset = "0x679550", VA = "0x18067A950")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F11 RID: 7953
		// (get) Token: 0x0600EF63 RID: 61283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F11")]
		public override IDrawableRange rangeToShow
		{
			[Token(Token = "0x600EF63")]
			[Address(RVA = "0x67AAD0", Offset = "0x6796D0", VA = "0x18067AAD0", Slot = "36")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600EF64 RID: 61284 RVA: 0x000581D0 File Offset: 0x000563D0
		[Token(Token = "0x600EF64")]
		[Address(RVA = "0x679A20", Offset = "0x678620", VA = "0x180679A20", Slot = "22")]
		public override bool IsRetriggerAvailable(PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EF65 RID: 61285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF65")]
		[Address(RVA = "0x679CE0", Offset = "0x6788E0", VA = "0x180679CE0", Slot = "58")]
		public override void OnBorn()
		{
		}

		// Token: 0x0600EF66 RID: 61286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF66")]
		[Address(RVA = "0x679D70", Offset = "0x678970", VA = "0x180679D70", Slot = "57")]
		public override void OnInit()
		{
		}

		// Token: 0x0600EF67 RID: 61287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF67")]
		[Address(RVA = "0x679470", Offset = "0x678070", VA = "0x180679470", Slot = "48")]
		public override void AssignData(SkillData data, Character owner, Blackboard externalBlackboard, UnitDataFlowConfig.Delta modifier)
		{
		}

		// Token: 0x0600EF68 RID: 61288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF68")]
		[Address(RVA = "0x67A000", Offset = "0x678C00", VA = "0x18067A000", Slot = "74")]
		protected override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600EF69 RID: 61289 RVA: 0x000581E8 File Offset: 0x000563E8
		[Token(Token = "0x600EF69")]
		[Address(RVA = "0x679960", Offset = "0x678560", VA = "0x180679960", Slot = "49")]
		protected override bool DoCast([Optional] Ability.FinishCallbackDelegate finishCb, PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EF6A RID: 61290 RVA: 0x00058200 File Offset: 0x00056400
		[Token(Token = "0x600EF6A")]
		[Address(RVA = "0x67A1D0", Offset = "0x678DD0", VA = "0x18067A1D0", Slot = "52")]
		public override bool RetriggerSkill(PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EF6B RID: 61291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF6B")]
		[Address(RVA = "0x679F50", Offset = "0x678B50", VA = "0x180679F50", Slot = "50")]
		protected override void OnSkillEnd()
		{
		}

		// Token: 0x0600EF6C RID: 61292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF6C")]
		[Address(RVA = "0x679E70", Offset = "0x678A70", VA = "0x180679E70", Slot = "61")]
		public override void OnOwnerFinish(Entity.FinishReason reason)
		{
		}

		// Token: 0x0600EF6D RID: 61293 RVA: 0x00058218 File Offset: 0x00056418
		[Token(Token = "0x600EF6D")]
		[Address(RVA = "0x67A0D0", Offset = "0x678CD0", VA = "0x18067A0D0", Slot = "80")]
		protected override bool ReduceCost(int cost, PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EF6E RID: 61294 RVA: 0x00058230 File Offset: 0x00056430
		[Token(Token = "0x600EF6E")]
		[Address(RVA = "0x67A350", Offset = "0x678F50", VA = "0x18067A350")]
		private bool _DoRetrigger(PlayerSide operationSide)
		{
			return default(bool);
		}

		// Token: 0x0600EF6F RID: 61295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EF6F")]
		[Address(RVA = "0x67A730", Offset = "0x679330", VA = "0x18067A730")]
		private string _GenerateRetriggerSignalId()
		{
			return null;
		}

		// Token: 0x0600EF70 RID: 61296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF70")]
		[Address(RVA = "0x67A820", Offset = "0x679420", VA = "0x18067A820")]
		public RetriggerableCastSkillWithCost()
		{
		}

		// Token: 0x0600EF71 RID: 61297 RVA: 0x00058248 File Offset: 0x00056448
		[Token(Token = "0x600EF71")]
		[Address(RVA = "0x67A340", Offset = "0x678F40", VA = "0x18067A340")]
		private bool <>xLuaBaseProxy_isRetriggerable()
		{
			return default(bool);
		}

		// Token: 0x0600EF72 RID: 61298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EF72")]
		[Address(RVA = "0x67A330", Offset = "0x678F30", VA = "0x18067A330")]
		private IDrawableRange <>xLuaBaseProxy_get_rangeToShow()
		{
			return null;
		}

		// Token: 0x0600EF73 RID: 61299 RVA: 0x00058260 File Offset: 0x00056460
		[Token(Token = "0x600EF73")]
		[Address(RVA = "0x67A2E0", Offset = "0x678EE0", VA = "0x18067A2E0")]
		private bool <>xLuaBaseProxy_IsRetriggerAvailable(PlayerSide P0)
		{
			return default(bool);
		}

		// Token: 0x0600EF74 RID: 61300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF74")]
		[Address(RVA = "0x634E00", Offset = "0x633A00", VA = "0x180634E00")]
		private void <>xLuaBaseProxy_OnBorn()
		{
		}

		// Token: 0x0600EF75 RID: 61301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF75")]
		[Address(RVA = "0x67A2F0", Offset = "0x678EF0", VA = "0x18067A2F0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0600EF76 RID: 61302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF76")]
		[Address(RVA = "0x6432F0", Offset = "0x641EF0", VA = "0x1806432F0")]
		private void <>xLuaBaseProxy_AssignData(SkillData P0, Character P1, Blackboard P2, UnitDataFlowConfig.Delta P3)
		{
		}

		// Token: 0x0600EF77 RID: 61303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF77")]
		[Address(RVA = "0x636850", Offset = "0x635450", VA = "0x180636850")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600EF78 RID: 61304 RVA: 0x00058278 File Offset: 0x00056478
		[Token(Token = "0x600EF78")]
		[Address(RVA = "0x67A2D0", Offset = "0x678ED0", VA = "0x18067A2D0")]
		private bool <>xLuaBaseProxy_DoCast(Ability.FinishCallbackDelegate P0, PlayerSide P1)
		{
			return default(bool);
		}

		// Token: 0x0600EF79 RID: 61305 RVA: 0x00058290 File Offset: 0x00056490
		[Token(Token = "0x600EF79")]
		[Address(RVA = "0x67A320", Offset = "0x678F20", VA = "0x18067A320")]
		private bool <>xLuaBaseProxy_RetriggerSkill(PlayerSide P0)
		{
			return default(bool);
		}

		// Token: 0x0600EF7A RID: 61306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF7A")]
		[Address(RVA = "0x67A300", Offset = "0x678F00", VA = "0x18067A300")]
		private void <>xLuaBaseProxy_OnSkillEnd()
		{
		}

		// Token: 0x0600EF7B RID: 61307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF7B")]
		[Address(RVA = "0x635EF0", Offset = "0x634AF0", VA = "0x180635EF0")]
		private void <>xLuaBaseProxy_OnOwnerFinish(Entity.FinishReason P0)
		{
		}

		// Token: 0x0600EF7C RID: 61308 RVA: 0x000582A8 File Offset: 0x000564A8
		[Token(Token = "0x600EF7C")]
		[Address(RVA = "0x67A310", Offset = "0x678F10", VA = "0x18067A310")]
		private bool <>xLuaBaseProxy_ReduceCost(int P0, PlayerSide P1)
		{
			return default(bool);
		}

		// Token: 0x040108AC RID: 67756
		[Token(Token = "0x40108AC")]
		private const string RETRIGGER_SIGNAL_ID_FORMAT = "{0}.retrigger.{1}";

		// Token: 0x040108AD RID: 67757
		[Token(Token = "0x40108AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[SerializeField]
		private string _retriggerCostKey;

		// Token: 0x040108AE RID: 67758
		[Token(Token = "0x40108AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[SerializeField]
		private Ability _retriggerAbility;

		// Token: 0x040108AF RID: 67759
		[Token(Token = "0x40108AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[SerializeField]
		private int _maxRetriggerCount;

		// Token: 0x040108B0 RID: 67760
		[Token(Token = "0x40108B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		[SerializeField]
		private int _retriggerInterval;

		// Token: 0x040108B1 RID: 67761
		[Token(Token = "0x40108B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[SerializeField]
		private bool _emitRetriggerSignal;

		// Token: 0x040108B2 RID: 67762
		[Token(Token = "0x40108B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x161")]
		[SerializeField]
		private bool _showRetriggerAbilityRange;

		// Token: 0x040108B3 RID: 67763
		[Token(Token = "0x40108B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x162")]
		[SerializeField]
		private bool _allowRetriggerOutsideSkill;

		// Token: 0x040108B4 RID: 67764
		[Token(Token = "0x40108B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x163")]
		[SerializeField]
		private bool _canRetriggerInSpecificMode;

		// Token: 0x040108B5 RID: 67765
		[Token(Token = "0x40108B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[SerializeField]
		private List<int> _modes;

		// Token: 0x040108B6 RID: 67766
		[Token(Token = "0x40108B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[SerializeField]
		private bool _logSimpleEventWhenRetrigger;

		// Token: 0x040108B7 RID: 67767
		[Token(Token = "0x40108B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private int m_retriggerCost;

		// Token: 0x040108B8 RID: 67768
		[Token(Token = "0x40108B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private int m_triggeredCnt;

		// Token: 0x040108B9 RID: 67769
		[Token(Token = "0x40108B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private int m_maxTriggerCnt;

		// Token: 0x040108BA RID: 67770
		[Token(Token = "0x40108BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private FP m_retiggerCooldown;

		// Token: 0x040108BB RID: 67771
		[Token(Token = "0x40108BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private PeriodicTimer m_retriggerCooldownTimer;

		// Token: 0x040108BC RID: 67772
		[Token(Token = "0x40108BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private bool m_needCastRetrigger;

		// Token: 0x040108BD RID: 67773
		[Token(Token = "0x40108BD")]
		private const string SIMPLE_EVENT_KEY = "retrigger_skill";

		// Token: 0x040108BE RID: 67774
		[Token(Token = "0x40108BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_retriggerCost;

		// Token: 0x040108BF RID: 67775
		[Token(Token = "0x40108BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isTriggerCntUsedUp;

		// Token: 0x040108C0 RID: 67776
		[Token(Token = "0x40108C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_retriggerCooldownProgress;

		// Token: 0x040108C1 RID: 67777
		[Token(Token = "0x40108C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isCooldown;

		// Token: 0x040108C2 RID: 67778
		[Token(Token = "0x40108C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_isRetriggerable;

		// Token: 0x040108C3 RID: 67779
		[Token(Token = "0x40108C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_currentRetriggerAbility;

		// Token: 0x040108C4 RID: 67780
		[Token(Token = "0x40108C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_rangeToShow;

		// Token: 0x040108C5 RID: 67781
		[Token(Token = "0x40108C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_IsRetriggerAvailable;

		// Token: 0x040108C6 RID: 67782
		[Token(Token = "0x40108C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnBorn;

		// Token: 0x040108C7 RID: 67783
		[Token(Token = "0x40108C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040108C8 RID: 67784
		[Token(Token = "0x40108C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x040108C9 RID: 67785
		[Token(Token = "0x40108C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040108CA RID: 67786
		[Token(Token = "0x40108CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_DoCast;

		// Token: 0x040108CB RID: 67787
		[Token(Token = "0x40108CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_RetriggerSkill;

		// Token: 0x040108CC RID: 67788
		[Token(Token = "0x40108CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnSkillEnd;

		// Token: 0x040108CD RID: 67789
		[Token(Token = "0x40108CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnOwnerFinish;

		// Token: 0x040108CE RID: 67790
		[Token(Token = "0x40108CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_ReduceCost;

		// Token: 0x040108CF RID: 67791
		[Token(Token = "0x40108CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__DoRetrigger;

		// Token: 0x040108D0 RID: 67792
		[Token(Token = "0x40108D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__GenerateRetriggerSignalId;

		// Token: 0x040108D1 RID: 67793
		[Token(Token = "0x40108D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
