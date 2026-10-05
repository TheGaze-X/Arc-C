using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029D2 RID: 10706
	[Token(Token = "0x20029D2")]
	public class BouncedAdvancedMovement : AdvancedMovement
	{
		// Token: 0x17002724 RID: 10020
		// (get) Token: 0x06011BEE RID: 72686 RVA: 0x0006CB28 File Offset: 0x0006AD28
		// (set) Token: 0x06011BEF RID: 72687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002724")]
		protected bool checkReachInNextTick
		{
			[Token(Token = "0x6011BEE")]
			[Address(RVA = "0x998290", Offset = "0x996E90", VA = "0x180998290")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6011BEF")]
			[Address(RVA = "0x9982F0", Offset = "0x996EF0", VA = "0x1809982F0")]
			set
			{
			}
		}

		// Token: 0x06011BF0 RID: 72688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BF0")]
		[Address(RVA = "0x997C70", Offset = "0x996870", VA = "0x180997C70", Slot = "21")]
		protected override void DealReached()
		{
		}

		// Token: 0x06011BF1 RID: 72689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BF1")]
		[Address(RVA = "0x997B70", Offset = "0x996770", VA = "0x180997B70")]
		public void ChangeTraceTarget(Entity target)
		{
		}

		// Token: 0x06011BF2 RID: 72690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BF2")]
		[Address(RVA = "0x997FD0", Offset = "0x996BD0", VA = "0x180997FD0")]
		public void EndBounce()
		{
		}

		// Token: 0x06011BF3 RID: 72691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BF3")]
		[Address(RVA = "0x998190", Offset = "0x996D90", VA = "0x180998190", Slot = "5")]
		public override void OnTick(FP deltaTimeFp)
		{
		}

		// Token: 0x06011BF4 RID: 72692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BF4")]
		[Address(RVA = "0x997D90", Offset = "0x996990", VA = "0x180997D90", Slot = "19")]
		protected override void DoCheckReached()
		{
		}

		// Token: 0x06011BF5 RID: 72693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BF5")]
		[Address(RVA = "0x998050", Offset = "0x996C50", VA = "0x180998050", Slot = "17")]
		protected override void OnInit(ILocatable start, ILocatable target)
		{
		}

		// Token: 0x06011BF6 RID: 72694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BF6")]
		[Address(RVA = "0x998120", Offset = "0x996D20", VA = "0x180998120", Slot = "7")]
		public override void OnProjectileStop()
		{
		}

		// Token: 0x06011BF7 RID: 72695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BF7")]
		[Address(RVA = "0x997E20", Offset = "0x996A20", VA = "0x180997E20")]
		public void DoComeBack()
		{
		}

		// Token: 0x06011BF8 RID: 72696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BF8")]
		[Address(RVA = "0x998230", Offset = "0x996E30", VA = "0x180998230")]
		public BouncedAdvancedMovement()
		{
		}

		// Token: 0x06011BF9 RID: 72697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BF9")]
		[Address(RVA = "0x998210", Offset = "0x996E10", VA = "0x180998210")]
		private void <>xLuaBaseProxy_DealReached()
		{
		}

		// Token: 0x06011BFA RID: 72698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BFA")]
		[Address(RVA = "0x994070", Offset = "0x992C70", VA = "0x180994070")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06011BFB RID: 72699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BFB")]
		[Address(RVA = "0x998220", Offset = "0x996E20", VA = "0x180998220")]
		private void <>xLuaBaseProxy_DoCheckReached()
		{
		}

		// Token: 0x06011BFC RID: 72700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BFC")]
		[Address(RVA = "0x9936D0", Offset = "0x9922D0", VA = "0x1809936D0")]
		private void <>xLuaBaseProxy_OnInit(ILocatable P0, ILocatable P1)
		{
		}

		// Token: 0x06011BFD RID: 72701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BFD")]
		[Address(RVA = "0x9973C0", Offset = "0x995FC0", VA = "0x1809973C0")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x04013E85 RID: 81541
		[Token(Token = "0x4013E85")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private float _speedAfterFirstReach;

		// Token: 0x04013E86 RID: 81542
		[Token(Token = "0x4013E86")]
		[FieldOffset(Offset = "0x144")]
		private bool m_firstReachFlag;

		// Token: 0x04013E87 RID: 81543
		[Token(Token = "0x4013E87")]
		[FieldOffset(Offset = "0x145")]
		private bool m_checkReachInNextTick;

		// Token: 0x04013E88 RID: 81544
		[Token(Token = "0x4013E88")]
		[FieldOffset(Offset = "0x148")]
		private float m_originSpeed;

		// Token: 0x04013E89 RID: 81545
		[Token(Token = "0x4013E89")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_checkReachInNextTick;

		// Token: 0x04013E8A RID: 81546
		[Token(Token = "0x4013E8A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_checkReachInNextTick;

		// Token: 0x04013E8B RID: 81547
		[Token(Token = "0x4013E8B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DealReached;

		// Token: 0x04013E8C RID: 81548
		[Token(Token = "0x4013E8C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ChangeTraceTarget;

		// Token: 0x04013E8D RID: 81549
		[Token(Token = "0x4013E8D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EndBounce;

		// Token: 0x04013E8E RID: 81550
		[Token(Token = "0x4013E8E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013E8F RID: 81551
		[Token(Token = "0x4013E8F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DoCheckReached;

		// Token: 0x04013E90 RID: 81552
		[Token(Token = "0x4013E90")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04013E91 RID: 81553
		[Token(Token = "0x4013E91")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04013E92 RID: 81554
		[Token(Token = "0x4013E92")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_DoComeBack;

		// Token: 0x04013E93 RID: 81555
		[Token(Token = "0x4013E93")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
