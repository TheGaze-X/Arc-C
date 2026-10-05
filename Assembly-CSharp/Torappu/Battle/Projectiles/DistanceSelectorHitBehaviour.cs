using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x02002991 RID: 10641
	[Token(Token = "0x2002991")]
	public class DistanceSelectorHitBehaviour : SelectorHitBehaviour
	{
		// Token: 0x060119BC RID: 72124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119BC")]
		[Address(RVA = "0x96EBE0", Offset = "0x96D7E0", VA = "0x18096EBE0", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x060119BD RID: 72125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119BD")]
		[Address(RVA = "0x96EDA0", Offset = "0x96D9A0", VA = "0x18096EDA0", Slot = "5")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x060119BE RID: 72126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119BE")]
		[Address(RVA = "0x96EFC0", Offset = "0x96DBC0", VA = "0x18096EFC0")]
		public DistanceSelectorHitBehaviour()
		{
		}

		// Token: 0x060119BF RID: 72127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119BF")]
		[Address(RVA = "0x9693E0", Offset = "0x967FE0", VA = "0x1809693E0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x060119C0 RID: 72128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119C0")]
		[Address(RVA = "0x96EFB0", Offset = "0x96DBB0", VA = "0x18096EFB0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04013B31 RID: 80689
		[Token(Token = "0x4013B31")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private FP _distanceInterval;

		// Token: 0x04013B32 RID: 80690
		[Token(Token = "0x4013B32")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private FP _distanceMax;

		// Token: 0x04013B33 RID: 80691
		[Token(Token = "0x4013B33")]
		[FieldOffset(Offset = "0xB8")]
		private FP m_distance;

		// Token: 0x04013B34 RID: 80692
		[Token(Token = "0x4013B34")]
		[FieldOffset(Offset = "0xC0")]
		private int m_selectCount;

		// Token: 0x04013B35 RID: 80693
		[Token(Token = "0x4013B35")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013B36 RID: 80694
		[Token(Token = "0x4013B36")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013B37 RID: 80695
		[Token(Token = "0x4013B37")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
