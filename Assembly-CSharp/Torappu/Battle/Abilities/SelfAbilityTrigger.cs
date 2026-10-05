using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BD4 RID: 11220
	[Token(Token = "0x2002BD4")]
	public class SelfAbilityTrigger : AbilityStandard.Behaviour, IAbilityAttachment
	{
		// Token: 0x170029C9 RID: 10697
		// (get) Token: 0x06012F2E RID: 77614 RVA: 0x00074268 File Offset: 0x00072468
		[Token(Token = "0x170029C9")]
		public Ability.FamilyGroupMask mask
		{
			[Token(Token = "0x6012F2E")]
			[Address(RVA = "0xAEB540", Offset = "0xAEA140", VA = "0x180AEB540")]
			get
			{
				return Ability.FamilyGroupMask.NONE;
			}
		}

		// Token: 0x06012F2F RID: 77615 RVA: 0x00074280 File Offset: 0x00072480
		[Token(Token = "0x6012F2F")]
		[Address(RVA = "0xAE5210", Offset = "0xAE3E10", VA = "0x180AE5210", Slot = "17")]
		protected virtual bool Preprocess(Entity target, Entity owner, Ability ability, Blackboard blackboard)
		{
			return default(bool);
		}

		// Token: 0x06012F30 RID: 77616 RVA: 0x00074298 File Offset: 0x00072498
		[Token(Token = "0x6012F30")]
		[Address(RVA = "0xAE5130", Offset = "0xAE3D30", VA = "0x180AE5130", Slot = "18")]
		protected virtual bool ApplyAttackAction(Entity target, Entity owner, Ability ability, Blackboard blackboard)
		{
			return default(bool);
		}

		// Token: 0x06012F31 RID: 77617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F31")]
		[Address(RVA = "0xAEB3F0", Offset = "0xAE9FF0", VA = "0x180AEB3F0", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06012F32 RID: 77618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F32")]
		[Address(RVA = "0xAEB300", Offset = "0xAE9F00", VA = "0x180AEB300", Slot = "16")]
		public void Apply(Entity target, Entity owner, Ability ability, Blackboard blackboard)
		{
		}

		// Token: 0x06012F33 RID: 77619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F33")]
		[Address(RVA = "0xAEB4E0", Offset = "0xAEA0E0", VA = "0x180AEB4E0")]
		public SelfAbilityTrigger()
		{
		}

		// Token: 0x06012F34 RID: 77620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F34")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x04015633 RID: 87603
		[Token(Token = "0x4015633")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SelfAbilityTrigger.TriggerTiming _timing;

		// Token: 0x04015634 RID: 87604
		[Token(Token = "0x4015634")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Ability.FamilyGroupMask _mask;

		// Token: 0x04015635 RID: 87605
		[Token(Token = "0x4015635")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_mask;

		// Token: 0x04015636 RID: 87606
		[Token(Token = "0x4015636")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Preprocess;

		// Token: 0x04015637 RID: 87607
		[Token(Token = "0x4015637")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ApplyAttackAction;

		// Token: 0x04015638 RID: 87608
		[Token(Token = "0x4015638")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x04015639 RID: 87609
		[Token(Token = "0x4015639")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Apply;

		// Token: 0x0401563A RID: 87610
		[Token(Token = "0x401563A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002BD5 RID: 11221
		[Token(Token = "0x2002BD5")]
		public enum TriggerTiming
		{
			// Token: 0x0401563C RID: 87612
			[Token(Token = "0x401563C")]
			NONE,
			// Token: 0x0401563D RID: 87613
			[Token(Token = "0x401563D")]
			ATTACK
		}
	}
}
