using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Abilities;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200244E RID: 9294
	[Token(Token = "0x200244E")]
	public class BurstCastSkill : CastSkillWithLimitTimes
	{
		// Token: 0x17001EEA RID: 7914
		// (get) Token: 0x0600EE77 RID: 61047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001EEA")]
		public BurstAttackGroup burstAttackGroup
		{
			[Token(Token = "0x600EE77")]
			[Address(RVA = "0x6408D0", Offset = "0x63F4D0", VA = "0x1806408D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001EEB RID: 7915
		// (get) Token: 0x0600EE78 RID: 61048 RVA: 0x00057768 File Offset: 0x00055968
		[Token(Token = "0x17001EEB")]
		public override bool canUseDiscardAbility
		{
			[Token(Token = "0x600EE78")]
			[Address(RVA = "0x6409F0", Offset = "0x63F5F0", VA = "0x1806409F0", Slot = "79")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600EE79 RID: 61049 RVA: 0x00057780 File Offset: 0x00055980
		[Token(Token = "0x600EE79")]
		[Address(RVA = "0x640010", Offset = "0x63EC10", VA = "0x180640010", Slot = "64")]
		public override bool OnBeforeAttack(Ability ability, bool isCombat)
		{
			return default(bool);
		}

		// Token: 0x0600EE7A RID: 61050 RVA: 0x00057798 File Offset: 0x00055998
		[Token(Token = "0x600EE7A")]
		[Address(RVA = "0x63FFA0", Offset = "0x63EBA0", VA = "0x18063FFA0", Slot = "24")]
		public override bool IsDiscardable()
		{
			return default(bool);
		}

		// Token: 0x0600EE7B RID: 61051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE7B")]
		[Address(RVA = "0x6402E0", Offset = "0x63EEE0", VA = "0x1806402E0", Slot = "57")]
		public override void OnInit()
		{
		}

		// Token: 0x0600EE7C RID: 61052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE7C")]
		[Address(RVA = "0x6400D0", Offset = "0x63ECD0", VA = "0x1806400D0", Slot = "76")]
		protected override void OnCastFinish(Ability ability, Ability.FinishReason reason, bool resetCd)
		{
		}

		// Token: 0x0600EE7D RID: 61053 RVA: 0x000577B0 File Offset: 0x000559B0
		[Token(Token = "0x600EE7D")]
		[Address(RVA = "0x6404D0", Offset = "0x63F0D0", VA = "0x1806404D0", Slot = "81")]
		protected override bool UseDiscardAbility()
		{
			return default(bool);
		}

		// Token: 0x0600EE7E RID: 61054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE7E")]
		[Address(RVA = "0x63FDE0", Offset = "0x63E9E0", VA = "0x18063FDE0")]
		private void FinishCallbackDelegate(Ability ability, Ability.FinishReason reason, bool resetCd)
		{
		}

		// Token: 0x0600EE7F RID: 61055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE7F")]
		[Address(RVA = "0x640180", Offset = "0x63ED80", VA = "0x180640180", Slot = "82")]
		protected override void OnDiscard()
		{
		}

		// Token: 0x0600EE80 RID: 61056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE80")]
		[Address(RVA = "0x63FF00", Offset = "0x63EB00", VA = "0x18063FF00", Slot = "72")]
		public override void GatherBuffs(List<BuffData> result)
		{
		}

		// Token: 0x0600EE81 RID: 61057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE81")]
		[Address(RVA = "0x6406D0", Offset = "0x63F2D0", VA = "0x1806406D0")]
		public BurstCastSkill()
		{
		}

		// Token: 0x0600EE82 RID: 61058 RVA: 0x000577C8 File Offset: 0x000559C8
		[Token(Token = "0x600EE82")]
		[Address(RVA = "0x640470", Offset = "0x63F070", VA = "0x180640470")]
		private bool <>xLuaBaseProxy_get_canUseDiscardAbility()
		{
			return default(bool);
		}

		// Token: 0x0600EE83 RID: 61059 RVA: 0x000577E0 File Offset: 0x000559E0
		[Token(Token = "0x600EE83")]
		[Address(RVA = "0x640380", Offset = "0x63EF80", VA = "0x180640380")]
		private bool <>xLuaBaseProxy_OnBeforeAttack(Ability P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x0600EE84 RID: 61060 RVA: 0x000577F8 File Offset: 0x000559F8
		[Token(Token = "0x600EE84")]
		[Address(RVA = "0x640370", Offset = "0x63EF70", VA = "0x180640370")]
		private bool <>xLuaBaseProxy_IsDiscardable()
		{
			return default(bool);
		}

		// Token: 0x0600EE85 RID: 61061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE85")]
		[Address(RVA = "0x640400", Offset = "0x63F000", VA = "0x180640400")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0600EE86 RID: 61062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE86")]
		[Address(RVA = "0x640390", Offset = "0x63EF90", VA = "0x180640390")]
		private void <>xLuaBaseProxy_OnCastFinish(Ability P0, Ability.FinishReason P1, bool P2)
		{
		}

		// Token: 0x0600EE87 RID: 61063 RVA: 0x00057810 File Offset: 0x00055A10
		[Token(Token = "0x600EE87")]
		[Address(RVA = "0x640410", Offset = "0x63F010", VA = "0x180640410")]
		private bool <>xLuaBaseProxy_UseDiscardAbility()
		{
			return default(bool);
		}

		// Token: 0x0600EE88 RID: 61064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE88")]
		[Address(RVA = "0x6403A0", Offset = "0x63EFA0", VA = "0x1806403A0")]
		private void <>xLuaBaseProxy_OnDiscard()
		{
		}

		// Token: 0x0600EE89 RID: 61065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE89")]
		[Address(RVA = "0x640360", Offset = "0x63EF60", VA = "0x180640360")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x040107C5 RID: 67525
		[Token(Token = "0x40107C5")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private bool _burstOnOverload;

		// Token: 0x040107C6 RID: 67526
		[Token(Token = "0x40107C6")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private BuffData[] _buffWhenDiscardWithBullet;

		// Token: 0x040107C7 RID: 67527
		[Token(Token = "0x40107C7")]
		[FieldOffset(Offset = "0x198")]
		private bool m_isDuringBurstAttack;

		// Token: 0x040107C8 RID: 67528
		[Token(Token = "0x40107C8")]
		[FieldOffset(Offset = "0x1A0")]
		private BurstAttackGroup m_burstAttackGroup;

		// Token: 0x040107C9 RID: 67529
		[Token(Token = "0x40107C9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_burstAttackGroup;

		// Token: 0x040107CA RID: 67530
		[Token(Token = "0x40107CA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_canUseDiscardAbility;

		// Token: 0x040107CB RID: 67531
		[Token(Token = "0x40107CB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBeforeAttack;

		// Token: 0x040107CC RID: 67532
		[Token(Token = "0x40107CC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsDiscardable;

		// Token: 0x040107CD RID: 67533
		[Token(Token = "0x40107CD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040107CE RID: 67534
		[Token(Token = "0x40107CE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCastFinish;

		// Token: 0x040107CF RID: 67535
		[Token(Token = "0x40107CF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UseDiscardAbility;

		// Token: 0x040107D0 RID: 67536
		[Token(Token = "0x40107D0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_FinishCallbackDelegate;

		// Token: 0x040107D1 RID: 67537
		[Token(Token = "0x40107D1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnDiscard;

		// Token: 0x040107D2 RID: 67538
		[Token(Token = "0x40107D2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x040107D3 RID: 67539
		[Token(Token = "0x40107D3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
