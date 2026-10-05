using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002470 RID: 9328
	[Token(Token = "0x2002470")]
	public class ConstrainedTalent : Talent
	{
		// Token: 0x0600F034 RID: 61492 RVA: 0x00058818 File Offset: 0x00056A18
		[Token(Token = "0x600F034")]
		[Address(RVA = "0x66FBE0", Offset = "0x66E7E0", VA = "0x18066FBE0", Slot = "24")]
		public sealed override bool OnBeforeAttack(Ability ability, bool isCombat)
		{
			return default(bool);
		}

		// Token: 0x0600F035 RID: 61493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F035")]
		[Address(RVA = "0x66FB40", Offset = "0x66E740", VA = "0x18066FB40", Slot = "25")]
		public sealed override void OnAfterAttack(Ability ability, bool isCombat, Ability.FinishReason reason)
		{
		}

		// Token: 0x0600F036 RID: 61494 RVA: 0x00058830 File Offset: 0x00056A30
		[Token(Token = "0x600F036")]
		[Address(RVA = "0x66FAC0", Offset = "0x66E6C0", VA = "0x18066FAC0", Slot = "26")]
		public sealed override bool CheckReborn(out Unit.RebornData respawnData)
		{
			return default(bool);
		}

		// Token: 0x0600F037 RID: 61495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F037")]
		[Address(RVA = "0x66FC80", Offset = "0x66E880", VA = "0x18066FC80", Slot = "27")]
		public sealed override void ProcessTraitBlackboard(Blackboard blackboard)
		{
		}

		// Token: 0x0600F038 RID: 61496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F038")]
		[Address(RVA = "0x66FD50", Offset = "0x66E950", VA = "0x18066FD50")]
		public ConstrainedTalent()
		{
		}

		// Token: 0x0600F039 RID: 61497 RVA: 0x00058848 File Offset: 0x00056A48
		[Token(Token = "0x600F039")]
		[Address(RVA = "0x66FD40", Offset = "0x66E940", VA = "0x18066FD40")]
		private bool <>xLuaBaseProxy_OnBeforeAttack(Ability P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x0600F03A RID: 61498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F03A")]
		[Address(RVA = "0x66FD30", Offset = "0x66E930", VA = "0x18066FD30")]
		private void <>xLuaBaseProxy_OnAfterAttack(Ability P0, bool P1, Ability.FinishReason P2)
		{
		}

		// Token: 0x0600F03B RID: 61499 RVA: 0x00058860 File Offset: 0x00056A60
		[Token(Token = "0x600F03B")]
		[Address(RVA = "0x66FD20", Offset = "0x66E920", VA = "0x18066FD20")]
		private bool <>xLuaBaseProxy_CheckReborn(out Unit.RebornData P0)
		{
			return default(bool);
		}

		// Token: 0x0600F03C RID: 61500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F03C")]
		[Address(RVA = "0x66BC70", Offset = "0x66A870", VA = "0x18066BC70")]
		private void <>xLuaBaseProxy_ProcessTraitBlackboard(Blackboard P0)
		{
		}

		// Token: 0x0401099D RID: 67997
		[Token(Token = "0x401099D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnBeforeAttack;

		// Token: 0x0401099E RID: 67998
		[Token(Token = "0x401099E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnAfterAttack;

		// Token: 0x0401099F RID: 67999
		[Token(Token = "0x401099F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckReborn;

		// Token: 0x040109A0 RID: 68000
		[Token(Token = "0x40109A0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ProcessTraitBlackboard;

		// Token: 0x040109A1 RID: 68001
		[Token(Token = "0x40109A1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
