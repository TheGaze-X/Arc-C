using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x02002994 RID: 10644
	[Token(Token = "0x2002994")]
	public class FaceProjectileRotationToTargetDirection : Projectile.Behaviour
	{
		// Token: 0x060119D9 RID: 72153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119D9")]
		[Address(RVA = "0x9714F0", Offset = "0x9700F0", VA = "0x1809714F0", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x060119DA RID: 72154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119DA")]
		[Address(RVA = "0x971740", Offset = "0x970340", VA = "0x180971740", Slot = "5")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x060119DB RID: 72155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119DB")]
		[Address(RVA = "0x971860", Offset = "0x970460", VA = "0x180971860")]
		public FaceProjectileRotationToTargetDirection()
		{
		}

		// Token: 0x060119DC RID: 72156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119DC")]
		[Address(RVA = "0x5EEAD0", Offset = "0x5ED6D0", VA = "0x1805EEAD0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x060119DD RID: 72157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119DD")]
		[Address(RVA = "0x94DC60", Offset = "0x94C860", VA = "0x18094DC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04013B6A RID: 80746
		[Token(Token = "0x4013B6A")]
		[FieldOffset(Offset = "0x28")]
		private BasicMovement m_movement;

		// Token: 0x04013B6B RID: 80747
		[Token(Token = "0x4013B6B")]
		[FieldOffset(Offset = "0x30")]
		private Vector2 m_direction;

		// Token: 0x04013B6C RID: 80748
		[Token(Token = "0x4013B6C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013B6D RID: 80749
		[Token(Token = "0x4013B6D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013B6E RID: 80750
		[Token(Token = "0x4013B6E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
