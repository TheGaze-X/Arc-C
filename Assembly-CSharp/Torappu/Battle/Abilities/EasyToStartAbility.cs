using System;
using System.Collections;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B12 RID: 11026
	[Token(Token = "0x2002B12")]
	public abstract class EasyToStartAbility : AbilityStandard
	{
		// Token: 0x170028A6 RID: 10406
		// (get) Token: 0x0601277C RID: 75644 RVA: 0x000714D8 File Offset: 0x0006F6D8
		[Token(Token = "0x170028A6")]
		public bool waitForAttackEvent
		{
			[Token(Token = "0x601277C")]
			[Address(RVA = "0xA73100", Offset = "0xA71D00", VA = "0x180A73100")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170028A7 RID: 10407
		// (get) Token: 0x0601277D RID: 75645
		[Token(Token = "0x170028A7")]
		public abstract FP preDelay { [Token(Token = "0x601277D")] get; }

		// Token: 0x170028A8 RID: 10408
		// (get) Token: 0x0601277E RID: 75646 RVA: 0x000714F0 File Offset: 0x0006F6F0
		[Token(Token = "0x170028A8")]
		protected virtual FP postDelay
		{
			[Token(Token = "0x601277E")]
			[Address(RVA = "0xA72FE0", Offset = "0xA71BE0", VA = "0x180A72FE0", Slot = "97")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x0601277F RID: 75647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601277F")]
		[Address(RVA = "0xA72880", Offset = "0xA71480", VA = "0x180A72880", Slot = "50")]
		protected override void OnCastStart()
		{
		}

		// Token: 0x06012780 RID: 75648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012780")]
		[Address(RVA = "0xA727E0", Offset = "0xA713E0", VA = "0x180A727E0", Slot = "51")]
		protected override void OnCastEnd(Ability.FinishReason reason)
		{
		}

		// Token: 0x06012781 RID: 75649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012781")]
		[Address(RVA = "0xA72AE0", Offset = "0xA716E0", VA = "0x180A72AE0")]
		protected IEnumerator WaitForNextEvent(Entity.Event ev, FP maxWaitingTime)
		{
			return null;
		}

		// Token: 0x06012782 RID: 75650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012782")]
		[Address(RVA = "0xA729C0", Offset = "0xA715C0", VA = "0x180A729C0", Slot = "75")]
		protected override IEnumerator OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x06012783 RID: 75651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012783")]
		[Address(RVA = "0xA72910", Offset = "0xA71510", VA = "0x180A72910", Slot = "76")]
		protected override IEnumerator OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x06012784 RID: 75652
		[Token(Token = "0x6012784")]
		protected abstract FP GetDuration();

		// Token: 0x06012785 RID: 75653 RVA: 0x00071508 File Offset: 0x0006F708
		[Token(Token = "0x6012785")]
		[Address(RVA = "0xA72BC0", Offset = "0xA717C0", VA = "0x180A72BC0")]
		private bool _CheckNeedResetCooldown()
		{
			return default(bool);
		}

		// Token: 0x06012786 RID: 75654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012786")]
		[Address(RVA = "0xA72ED0", Offset = "0xA71AD0", VA = "0x180A72ED0")]
		private void _OnReceiveEvent(object arg)
		{
		}

		// Token: 0x06012787 RID: 75655 RVA: 0x00071520 File Offset: 0x0006F720
		[Token(Token = "0x6012787")]
		[Address(RVA = "0xA72E70", Offset = "0xA71A70", VA = "0x180A72E70")]
		private bool _CheckNotReceiveEvent()
		{
			return default(bool);
		}

		// Token: 0x06012788 RID: 75656 RVA: 0x00071538 File Offset: 0x0006F738
		[Token(Token = "0x6012788")]
		[Address(RVA = "0xA72DD0", Offset = "0xA719D0", VA = "0x180A72DD0")]
		private bool _CheckNotReceiveEventAndTargetAlive()
		{
			return default(bool);
		}

		// Token: 0x06012789 RID: 75657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012789")]
		[Address(RVA = "0xA72F40", Offset = "0xA71B40", VA = "0x180A72F40")]
		protected EasyToStartAbility()
		{
		}

		// Token: 0x0601278B RID: 75659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601278B")]
		[Address(RVA = "0xA72AD0", Offset = "0xA716D0", VA = "0x180A72AD0")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x0601278C RID: 75660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601278C")]
		[Address(RVA = "0xA66030", Offset = "0xA64C30", VA = "0x180A66030")]
		private void <>xLuaBaseProxy_OnCastEnd(Ability.FinishReason P0)
		{
		}

		// Token: 0x04014DFE RID: 85502
		[Token(Token = "0x4014DFE")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private bool _waitForAttackEvent;

		// Token: 0x04014DFF RID: 85503
		[Token(Token = "0x4014DFF")]
		[FieldOffset(Offset = "0x111")]
		[SerializeField]
		[Inspect("waitForAttackEvent")]
		private bool _interuptIfTargetDead;

		// Token: 0x04014E00 RID: 85504
		[Token(Token = "0x4014E00")]
		[FieldOffset(Offset = "0x114")]
		[SerializeField]
		private EasyToStartAbility.ResetCooldownStrategy _resetCdStrategy;

		// Token: 0x04014E01 RID: 85505
		[Token(Token = "0x4014E01")]
		[FieldOffset(Offset = "0x118")]
		protected FP m_cachedDuration;

		// Token: 0x04014E02 RID: 85506
		[Token(Token = "0x4014E02")]
		[FieldOffset(Offset = "0x120")]
		private bool m_receivedEvent;

		// Token: 0x04014E03 RID: 85507
		[Token(Token = "0x4014E03")]
		[FieldOffset(Offset = "0x128")]
		protected FP m_realStartTime;

		// Token: 0x04014E04 RID: 85508
		[Token(Token = "0x4014E04")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_waitForAttackEvent;

		// Token: 0x04014E05 RID: 85509
		[Token(Token = "0x4014E05")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_postDelay;

		// Token: 0x04014E06 RID: 85510
		[Token(Token = "0x4014E06")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x04014E07 RID: 85511
		[Token(Token = "0x4014E07")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCastEnd;

		// Token: 0x04014E08 RID: 85512
		[Token(Token = "0x4014E08")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_WaitForNextEvent;

		// Token: 0x04014E09 RID: 85513
		[Token(Token = "0x4014E09")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnWaitForPreDelay;

		// Token: 0x04014E0A RID: 85514
		[Token(Token = "0x4014E0A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnWaitForPostDelay;

		// Token: 0x04014E0B RID: 85515
		[Token(Token = "0x4014E0B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CheckNeedResetCooldown;

		// Token: 0x04014E0C RID: 85516
		[Token(Token = "0x4014E0C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnReceiveEvent;

		// Token: 0x04014E0D RID: 85517
		[Token(Token = "0x4014E0D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CheckNotReceiveEvent;

		// Token: 0x04014E0E RID: 85518
		[Token(Token = "0x4014E0E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CheckNotReceiveEventAndTargetAlive;

		// Token: 0x04014E0F RID: 85519
		[Token(Token = "0x4014E0F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002B13 RID: 11027
		[Token(Token = "0x2002B13")]
		private enum ResetCooldownStrategy
		{
			// Token: 0x04014E11 RID: 85521
			[Token(Token = "0x4014E11")]
			NONE,
			// Token: 0x04014E12 RID: 85522
			[Token(Token = "0x4014E12")]
			HALF_FRAME,
			// Token: 0x04014E13 RID: 85523
			[Token(Token = "0x4014E13")]
			ONE_FRAME,
			// Token: 0x04014E14 RID: 85524
			[Token(Token = "0x4014E14")]
			EPSILON
		}
	}
}
