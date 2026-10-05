using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029ED RID: 10733
	[Token(Token = "0x20029ED")]
	public class ReboundMovement : FarthestPointMovement
	{
		// Token: 0x06011CD6 RID: 72918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CD6")]
		[Address(RVA = "0x9B39C0", Offset = "0x9B25C0", VA = "0x1809B39C0", Slot = "6")]
		public override void OnProjectileBorn()
		{
		}

		// Token: 0x06011CD7 RID: 72919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CD7")]
		[Address(RVA = "0x9B3A70", Offset = "0x9B2670", VA = "0x1809B3A70", Slot = "5")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011CD8 RID: 72920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CD8")]
		[Address(RVA = "0x9B3E40", Offset = "0x9B2A40", VA = "0x1809B3E40")]
		private void _ChangeDirection()
		{
		}

		// Token: 0x06011CD9 RID: 72921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CD9")]
		[Address(RVA = "0x9B3F00", Offset = "0x9B2B00", VA = "0x1809B3F00")]
		public ReboundMovement()
		{
		}

		// Token: 0x06011CDA RID: 72922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CDA")]
		[Address(RVA = "0x94DC40", Offset = "0x94C840", VA = "0x18094DC40")]
		private void <>xLuaBaseProxy_OnProjectileBorn()
		{
		}

		// Token: 0x06011CDB RID: 72923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CDB")]
		[Address(RVA = "0x994070", Offset = "0x992C70", VA = "0x180994070")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04013FEF RID: 81903
		[Token(Token = "0x4013FEF")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private bool _reboundWithCharSourceRoot;

		// Token: 0x04013FF0 RID: 81904
		[Token(Token = "0x4013FF0")]
		[FieldOffset(Offset = "0x151")]
		[SerializeField]
		private bool _reboundWithCharSourceClone;

		// Token: 0x04013FF1 RID: 81905
		[Token(Token = "0x4013FF1")]
		[FieldOffset(Offset = "0x154")]
		private GridPosition m_lastPos;

		// Token: 0x04013FF2 RID: 81906
		[Token(Token = "0x4013FF2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnProjectileBorn;

		// Token: 0x04013FF3 RID: 81907
		[Token(Token = "0x4013FF3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013FF4 RID: 81908
		[Token(Token = "0x4013FF4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ChangeDirection;

		// Token: 0x04013FF5 RID: 81909
		[Token(Token = "0x4013FF5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
