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
	// Token: 0x02002ACE RID: 10958
	[Token(Token = "0x2002ACE")]
	public class ActiveBuffAbility : EasyToStartAbility
	{
		// Token: 0x17002806 RID: 10246
		// (get) Token: 0x0601240E RID: 74766 RVA: 0x0006FCF0 File Offset: 0x0006DEF0
		[Token(Token = "0x17002806")]
		public override FP cooldown
		{
			[Token(Token = "0x601240E")]
			[Address(RVA = "0xA4D820", Offset = "0xA4C420", VA = "0x180A4D820", Slot = "16")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17002807 RID: 10247
		// (get) Token: 0x0601240F RID: 74767 RVA: 0x0006FD08 File Offset: 0x0006DF08
		[Token(Token = "0x17002807")]
		public override FP escapeTime
		{
			[Token(Token = "0x601240F")]
			[Address(RVA = "0xA4D880", Offset = "0xA4C480", VA = "0x180A4D880", Slot = "21")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17002808 RID: 10248
		// (get) Token: 0x06012410 RID: 74768 RVA: 0x0006FD20 File Offset: 0x0006DF20
		[Token(Token = "0x17002808")]
		public override Ability.Category category
		{
			[Token(Token = "0x6012410")]
			[Address(RVA = "0xA4D7C0", Offset = "0xA4C3C0", VA = "0x180A4D7C0", Slot = "13")]
			get
			{
				return Ability.Category.NONE;
			}
		}

		// Token: 0x17002809 RID: 10249
		// (get) Token: 0x06012411 RID: 74769 RVA: 0x0006FD38 File Offset: 0x0006DF38
		[Token(Token = "0x17002809")]
		public override AbilityStandard.SelectTargetSource selectTargetSource
		{
			[Token(Token = "0x6012411")]
			[Address(RVA = "0xA4DA50", Offset = "0xA4C650", VA = "0x180A4DA50", Slot = "65")]
			get
			{
				return AbilityStandard.SelectTargetSource.NONE;
			}
		}

		// Token: 0x1700280A RID: 10250
		// (get) Token: 0x06012412 RID: 74770 RVA: 0x0006FD50 File Offset: 0x0006DF50
		[Token(Token = "0x1700280A")]
		public override bool isAffecting
		{
			[Token(Token = "0x6012412")]
			[Address(RVA = "0xA4D910", Offset = "0xA4C510", VA = "0x180A4D910", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700280B RID: 10251
		// (get) Token: 0x06012413 RID: 74771 RVA: 0x0006FD68 File Offset: 0x0006DF68
		[Token(Token = "0x1700280B")]
		protected override bool alwaysIncludeTarget
		{
			[Token(Token = "0x6012413")]
			[Address(RVA = "0xA4D760", Offset = "0xA4C360", VA = "0x180A4D760", Slot = "67")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700280C RID: 10252
		// (get) Token: 0x06012414 RID: 74772 RVA: 0x0006FD80 File Offset: 0x0006DF80
		[Token(Token = "0x1700280C")]
		public override bool allowNoTarget
		{
			[Token(Token = "0x6012414")]
			[Address(RVA = "0xA4D700", Offset = "0xA4C300", VA = "0x180A4D700", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700280D RID: 10253
		// (get) Token: 0x06012415 RID: 74773 RVA: 0x0006FD98 File Offset: 0x0006DF98
		[Token(Token = "0x1700280D")]
		public override FP preDelay
		{
			[Token(Token = "0x6012415")]
			[Address(RVA = "0xA4D9C0", Offset = "0xA4C5C0", VA = "0x180A4D9C0", Slot = "96")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x06012416 RID: 74774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012416")]
		[Address(RVA = "0xA4D0C0", Offset = "0xA4BCC0", VA = "0x180A4D0C0", Slot = "39")]
		public override void StopAffect()
		{
		}

		// Token: 0x06012417 RID: 74775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012417")]
		[Address(RVA = "0xA4C9E0", Offset = "0xA4B5E0", VA = "0x180A4C9E0", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012418 RID: 74776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012418")]
		[Address(RVA = "0xA4CAB0", Offset = "0xA4B6B0", VA = "0x180A4CAB0", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x06012419 RID: 74777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012419")]
		[Address(RVA = "0xA4D210", Offset = "0xA4BE10", VA = "0x180A4D210", Slot = "38")]
		public override void UpdateCooldown(FP newPeriod, bool waitFirstPeriod, bool keepPassedTime = false)
		{
		}

		// Token: 0x0601241A RID: 74778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601241A")]
		[Address(RVA = "0xA4CA50", Offset = "0xA4B650", VA = "0x180A4CA50", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x0601241B RID: 74779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601241B")]
		[Address(RVA = "0xA4C900", Offset = "0xA4B500", VA = "0x180A4C900", Slot = "43")]
		public override IList<BuffData> GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x0601241C RID: 74780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601241C")]
		[Address(RVA = "0xA4CCF0", Offset = "0xA4B8F0", VA = "0x180A4CCF0", Slot = "75")]
		protected override IEnumerator OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x0601241D RID: 74781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601241D")]
		[Address(RVA = "0xA4CC40", Offset = "0xA4B840", VA = "0x180A4CC40", Slot = "76")]
		protected override IEnumerator OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x0601241E RID: 74782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601241E")]
		[Address(RVA = "0xA4C840", Offset = "0xA4B440", VA = "0x180A4C840", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x0601241F RID: 74783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601241F")]
		[Address(RVA = "0xA4CDA0", Offset = "0xA4B9A0", VA = "0x180A4CDA0", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x06012420 RID: 74784 RVA: 0x0006FDB0 File Offset: 0x0006DFB0
		[Token(Token = "0x6012420")]
		[Address(RVA = "0xA4C960", Offset = "0xA4B560", VA = "0x180A4C960", Slot = "98")]
		protected override FP GetDuration()
		{
			return default(FP);
		}

		// Token: 0x06012421 RID: 74785 RVA: 0x0006FDC8 File Offset: 0x0006DFC8
		[Token(Token = "0x6012421")]
		[Address(RVA = "0xA4CB40", Offset = "0xA4B740", VA = "0x180A4CB40", Slot = "78")]
		protected override bool OnSpellStart()
		{
			return default(bool);
		}

		// Token: 0x06012422 RID: 74786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012422")]
		[Address(RVA = "0xA4CE50", Offset = "0xA4BA50", VA = "0x180A4CE50")]
		protected void SetLifeTime(BuffData[] buffs)
		{
		}

		// Token: 0x06012423 RID: 74787 RVA: 0x0006FDE0 File Offset: 0x0006DFE0
		[Token(Token = "0x6012423")]
		[Address(RVA = "0xA4C5C0", Offset = "0xA4B1C0", VA = "0x180A4C5C0")]
		protected bool DoOnSpellStart(BuffData[] buffs)
		{
			return default(bool);
		}

		// Token: 0x06012424 RID: 74788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012424")]
		[Address(RVA = "0xA4CBC0", Offset = "0xA4B7C0", VA = "0x180A4CBC0", Slot = "54")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012425 RID: 74789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012425")]
		[Address(RVA = "0xA4D420", Offset = "0xA4C020", VA = "0x180A4D420")]
		protected void _ResetCooldownTimerIfNeeded()
		{
		}

		// Token: 0x06012426 RID: 74790 RVA: 0x0006FDF8 File Offset: 0x0006DFF8
		[Token(Token = "0x6012426")]
		[Address(RVA = "0xA4D300", Offset = "0xA4BF00", VA = "0x180A4D300")]
		private bool _CheckNotAllFinished()
		{
			return default(bool);
		}

		// Token: 0x06012427 RID: 74791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012427")]
		[Address(RVA = "0xA4D5C0", Offset = "0xA4C1C0", VA = "0x180A4D5C0")]
		public ActiveBuffAbility()
		{
		}

		// Token: 0x0601242A RID: 74794 RVA: 0x0006FE10 File Offset: 0x0006E010
		[Token(Token = "0x601242A")]
		[Address(RVA = "0xA4D1F0", Offset = "0xA4BDF0", VA = "0x180A4D1F0")]
		private FP <>xLuaBaseProxy_get_escapeTime()
		{
			return default(FP);
		}

		// Token: 0x0601242B RID: 74795 RVA: 0x0006FE28 File Offset: 0x0006E028
		[Token(Token = "0x601242B")]
		[Address(RVA = "0xA4D200", Offset = "0xA4BE00", VA = "0x180A4D200")]
		private bool <>xLuaBaseProxy_get_isAffecting()
		{
			return default(bool);
		}

		// Token: 0x0601242C RID: 74796 RVA: 0x0006FE40 File Offset: 0x0006E040
		[Token(Token = "0x601242C")]
		[Address(RVA = "0xA23D10", Offset = "0xA22910", VA = "0x180A23D10")]
		private bool <>xLuaBaseProxy_get_allowNoTarget()
		{
			return default(bool);
		}

		// Token: 0x0601242D RID: 74797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601242D")]
		[Address(RVA = "0xA4D1E0", Offset = "0xA4BDE0", VA = "0x180A4D1E0")]
		private void <>xLuaBaseProxy_StopAffect()
		{
		}

		// Token: 0x0601242E RID: 74798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601242E")]
		[Address(RVA = "0xA1FD70", Offset = "0xA1E970", VA = "0x180A1FD70")]
		private void <>xLuaBaseProxy_UpdateCooldown(FP P0, bool P1, bool P2)
		{
		}

		// Token: 0x0601242F RID: 74799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601242F")]
		[Address(RVA = "0xA27560", Offset = "0xA26160", VA = "0x180A27560")]
		private IEnumerator <>xLuaBaseProxy_OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x06012430 RID: 74800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012430")]
		[Address(RVA = "0xA4B060", Offset = "0xA49C60", VA = "0x180A4B060")]
		private IEnumerator <>xLuaBaseProxy_OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x06012431 RID: 74801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012431")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012432 RID: 74802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012432")]
		[Address(RVA = "0xA4B0B0", Offset = "0xA49CB0", VA = "0x180A4B0B0")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x06012433 RID: 74803 RVA: 0x0006FE58 File Offset: 0x0006E058
		[Token(Token = "0x6012433")]
		[Address(RVA = "0xA1EDF0", Offset = "0xA1D9F0", VA = "0x180A1EDF0")]
		private bool <>xLuaBaseProxy_OnSpellStart()
		{
			return default(bool);
		}

		// Token: 0x06012434 RID: 74804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012434")]
		[Address(RVA = "0xA38EF0", Offset = "0xA37AF0", VA = "0x180A38EF0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04014A50 RID: 84560
		[Token(Token = "0x4014A50")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private BuffData[] _buffs;

		// Token: 0x04014A51 RID: 84561
		[Token(Token = "0x4014A51")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private bool _waitForCasting;

		// Token: 0x04014A52 RID: 84562
		[Token(Token = "0x4014A52")]
		[FieldOffset(Offset = "0x139")]
		[SerializeField]
		private bool _updateLifetimeWhenSpellStart;

		// Token: 0x04014A53 RID: 84563
		[Token(Token = "0x4014A53")]
		[FieldOffset(Offset = "0x13C")]
		[SerializeField]
		[Inspect("waitForAttackEvent", false)]
		private float _preDelay;

		// Token: 0x04014A54 RID: 84564
		[Token(Token = "0x4014A54")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private float _escapeTime;

		// Token: 0x04014A55 RID: 84565
		[Token(Token = "0x4014A55")]
		[FieldOffset(Offset = "0x144")]
		[SerializeField]
		private bool _checkBuffEarlyFinish;

		// Token: 0x04014A56 RID: 84566
		[Token(Token = "0x4014A56")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private BuffData[] _passiveBuffs;

		// Token: 0x04014A57 RID: 84567
		[Token(Token = "0x4014A57")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private bool _ignoreInfiniteBuffCooldown;

		// Token: 0x04014A58 RID: 84568
		[Token(Token = "0x4014A58")]
		[FieldOffset(Offset = "0x151")]
		[SerializeField]
		private bool _enableUpdateCooldown;

		// Token: 0x04014A59 RID: 84569
		[Token(Token = "0x4014A59")]
		[FieldOffset(Offset = "0x158")]
		private FP m_lifeTime;

		// Token: 0x04014A5A RID: 84570
		[Token(Token = "0x4014A5A")]
		[FieldOffset(Offset = "0x160")]
		protected List<ObjectPtr<Buff>> m_buffInsts;

		// Token: 0x04014A5B RID: 84571
		[Token(Token = "0x4014A5B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cooldown;

		// Token: 0x04014A5C RID: 84572
		[Token(Token = "0x4014A5C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_escapeTime;

		// Token: 0x04014A5D RID: 84573
		[Token(Token = "0x4014A5D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x04014A5E RID: 84574
		[Token(Token = "0x4014A5E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_selectTargetSource;

		// Token: 0x04014A5F RID: 84575
		[Token(Token = "0x4014A5F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isAffecting;

		// Token: 0x04014A60 RID: 84576
		[Token(Token = "0x4014A60")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_alwaysIncludeTarget;

		// Token: 0x04014A61 RID: 84577
		[Token(Token = "0x4014A61")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_allowNoTarget;

		// Token: 0x04014A62 RID: 84578
		[Token(Token = "0x4014A62")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_preDelay;

		// Token: 0x04014A63 RID: 84579
		[Token(Token = "0x4014A63")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_StopAffect;

		// Token: 0x04014A64 RID: 84580
		[Token(Token = "0x4014A64")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04014A65 RID: 84581
		[Token(Token = "0x4014A65")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04014A66 RID: 84582
		[Token(Token = "0x4014A66")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_UpdateCooldown;

		// Token: 0x04014A67 RID: 84583
		[Token(Token = "0x4014A67")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x04014A68 RID: 84584
		[Token(Token = "0x4014A68")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetActiveBuffs;

		// Token: 0x04014A69 RID: 84585
		[Token(Token = "0x4014A69")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnWaitForPreDelay;

		// Token: 0x04014A6A RID: 84586
		[Token(Token = "0x4014A6A")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnWaitForPostDelay;

		// Token: 0x04014A6B RID: 84587
		[Token(Token = "0x4014A6B")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014A6C RID: 84588
		[Token(Token = "0x4014A6C")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04014A6D RID: 84589
		[Token(Token = "0x4014A6D")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_GetDuration;

		// Token: 0x04014A6E RID: 84590
		[Token(Token = "0x4014A6E")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnSpellStart;

		// Token: 0x04014A6F RID: 84591
		[Token(Token = "0x4014A6F")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_SetLifeTime;

		// Token: 0x04014A70 RID: 84592
		[Token(Token = "0x4014A70")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_DoOnSpellStart;

		// Token: 0x04014A71 RID: 84593
		[Token(Token = "0x4014A71")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04014A72 RID: 84594
		[Token(Token = "0x4014A72")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__ResetCooldownTimerIfNeeded;

		// Token: 0x04014A73 RID: 84595
		[Token(Token = "0x4014A73")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__CheckNotAllFinished;

		// Token: 0x04014A74 RID: 84596
		[Token(Token = "0x4014A74")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
