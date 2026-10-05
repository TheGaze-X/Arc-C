using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BD3 RID: 11219
	[Token(Token = "0x2002BD3")]
	public class GlazeTalentAbilityTrigger : SelfAbilityTrigger
	{
		// Token: 0x06012F29 RID: 77609 RVA: 0x00074208 File Offset: 0x00072408
		[Token(Token = "0x6012F29")]
		[Address(RVA = "0xAE4ED0", Offset = "0xAE3AD0", VA = "0x180AE4ED0", Slot = "17")]
		protected override bool Preprocess(Entity target, Entity owner, Ability ability, Blackboard blackboard)
		{
			return default(bool);
		}

		// Token: 0x06012F2A RID: 77610 RVA: 0x00074220 File Offset: 0x00072420
		[Token(Token = "0x6012F2A")]
		[Address(RVA = "0xAE4DD0", Offset = "0xAE39D0", VA = "0x180AE4DD0", Slot = "18")]
		protected override bool ApplyAttackAction(Entity target, Entity owner, Ability ability, Blackboard blackboard)
		{
			return default(bool);
		}

		// Token: 0x06012F2B RID: 77611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F2B")]
		[Address(RVA = "0xAE52B0", Offset = "0xAE3EB0", VA = "0x180AE52B0")]
		public GlazeTalentAbilityTrigger()
		{
		}

		// Token: 0x06012F2C RID: 77612 RVA: 0x00074238 File Offset: 0x00072438
		[Token(Token = "0x6012F2C")]
		[Address(RVA = "0xAE5210", Offset = "0xAE3E10", VA = "0x180AE5210")]
		private bool <>xLuaBaseProxy_Preprocess(Entity P0, Entity P1, Ability P2, Blackboard P3)
		{
			return default(bool);
		}

		// Token: 0x06012F2D RID: 77613 RVA: 0x00074250 File Offset: 0x00072450
		[Token(Token = "0x6012F2D")]
		[Address(RVA = "0xAE5130", Offset = "0xAE3D30", VA = "0x180AE5130")]
		private bool <>xLuaBaseProxy_ApplyAttackAction(Entity P0, Entity P1, Ability P2, Blackboard P3)
		{
			return default(bool);
		}

		// Token: 0x0401562F RID: 87599
		[Token(Token = "0x401562F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BuffData _buff;

		// Token: 0x04015630 RID: 87600
		[Token(Token = "0x4015630")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Preprocess;

		// Token: 0x04015631 RID: 87601
		[Token(Token = "0x4015631")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ApplyAttackAction;

		// Token: 0x04015632 RID: 87602
		[Token(Token = "0x4015632")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
