using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x0200298F RID: 10639
	[Token(Token = "0x200298F")]
	public class ClearTrailRenderer : Projectile.Behaviour
	{
		// Token: 0x060119A7 RID: 72103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119A7")]
		[Address(RVA = "0x96CF60", Offset = "0x96BB60", VA = "0x18096CF60", Slot = "7")]
		public override void OnProjectileStop()
		{
		}

		// Token: 0x060119A8 RID: 72104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119A8")]
		[Address(RVA = "0x96D050", Offset = "0x96BC50", VA = "0x18096D050")]
		public ClearTrailRenderer()
		{
		}

		// Token: 0x060119A9 RID: 72105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119A9")]
		[Address(RVA = "0x94DC50", Offset = "0x94C850", VA = "0x18094DC50")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x04013B0D RID: 80653
		[Token(Token = "0x4013B0D")]
		[FieldOffset(Offset = "0x28")]
		private TrailRenderer[] m_trailRenderers;

		// Token: 0x04013B0E RID: 80654
		[Token(Token = "0x4013B0E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04013B0F RID: 80655
		[Token(Token = "0x4013B0F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
