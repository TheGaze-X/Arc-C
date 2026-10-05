using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002491 RID: 9361
	[Token(Token = "0x2002491")]
	public class ProbAdditionNextAtkTalent : Talent
	{
		// Token: 0x0600F0AE RID: 61614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0AE")]
		[Address(RVA = "0x677200", Offset = "0x675E00", VA = "0x180677200", Slot = "21")]
		public override void AssignData(TalentData data, Unit owner, UnitDataFlowConfig.Delta modifier)
		{
		}

		// Token: 0x0600F0AF RID: 61615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0AF")]
		[Address(RVA = "0x677320", Offset = "0x675F20", VA = "0x180677320", Slot = "29")]
		protected override void DoAttach()
		{
		}

		// Token: 0x0600F0B0 RID: 61616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0B0")]
		[Address(RVA = "0x677380", Offset = "0x675F80", VA = "0x180677380", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x0600F0B1 RID: 61617 RVA: 0x00058B48 File Offset: 0x00056D48
		[Token(Token = "0x600F0B1")]
		[Address(RVA = "0x6775E0", Offset = "0x6761E0", VA = "0x1806775E0", Slot = "24")]
		public override bool OnBeforeAttack(Ability nextAbility, bool isCombat)
		{
			return default(bool);
		}

		// Token: 0x0600F0B2 RID: 61618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0B2")]
		[Address(RVA = "0x677490", Offset = "0x676090", VA = "0x180677490", Slot = "25")]
		public override void OnAfterAttack(Ability lastAbility, bool isCombat, Ability.FinishReason reason)
		{
		}

		// Token: 0x0600F0B3 RID: 61619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0B3")]
		[Address(RVA = "0x677780", Offset = "0x676380", VA = "0x180677780")]
		public ProbAdditionNextAtkTalent()
		{
		}

		// Token: 0x0600F0B4 RID: 61620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0B4")]
		[Address(RVA = "0x671580", Offset = "0x670180", VA = "0x180671580")]
		private void <>xLuaBaseProxy_AssignData(TalentData P0, Unit P1, UnitDataFlowConfig.Delta P2)
		{
		}

		// Token: 0x0600F0B5 RID: 61621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0B5")]
		[Address(RVA = "0x66A3B0", Offset = "0x668FB0", VA = "0x18066A3B0")]
		private void <>xLuaBaseProxy_DoAttach()
		{
		}

		// Token: 0x0600F0B6 RID: 61622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0B6")]
		[Address(RVA = "0x66A420", Offset = "0x669020", VA = "0x18066A420")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x0600F0B7 RID: 61623 RVA: 0x00058B60 File Offset: 0x00056D60
		[Token(Token = "0x600F0B7")]
		[Address(RVA = "0x66FD40", Offset = "0x66E940", VA = "0x18066FD40")]
		private bool <>xLuaBaseProxy_OnBeforeAttack(Ability P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x0600F0B8 RID: 61624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0B8")]
		[Address(RVA = "0x66FD30", Offset = "0x66E930", VA = "0x18066FD30")]
		private void <>xLuaBaseProxy_OnAfterAttack(Ability P0, bool P1, Ability.FinishReason P2)
		{
		}

		// Token: 0x04010A33 RID: 68147
		[Token(Token = "0x4010A33")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Ability.FamilyGroupMask _familyMask;

		// Token: 0x04010A34 RID: 68148
		[Token(Token = "0x4010A34")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private string _probKey;

		// Token: 0x04010A35 RID: 68149
		[Token(Token = "0x4010A35")]
		[FieldOffset(Offset = "0xA0")]
		private float m_prob;

		// Token: 0x04010A36 RID: 68150
		[Token(Token = "0x4010A36")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x04010A37 RID: 68151
		[Token(Token = "0x4010A37")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04010A38 RID: 68152
		[Token(Token = "0x4010A38")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04010A39 RID: 68153
		[Token(Token = "0x4010A39")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBeforeAttack;

		// Token: 0x04010A3A RID: 68154
		[Token(Token = "0x4010A3A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnAfterAttack;

		// Token: 0x04010A3B RID: 68155
		[Token(Token = "0x4010A3B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
