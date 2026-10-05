using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029C6 RID: 10694
	[Token(Token = "0x20029C6")]
	public class Whitw2S1HitBehaviour : MultiFunnelHitBehaviour
	{
		// Token: 0x06011B6C RID: 72556 RVA: 0x0006C738 File Offset: 0x0006A938
		[Token(Token = "0x6011B6C")]
		[Address(RVA = "0x992020", Offset = "0x990C20", VA = "0x180992020", Slot = "16")]
		protected override bool _CheckProjectileInValid()
		{
			return default(bool);
		}

		// Token: 0x06011B6D RID: 72557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B6D")]
		[Address(RVA = "0x9921C0", Offset = "0x990DC0", VA = "0x1809921C0")]
		public Whitw2S1HitBehaviour()
		{
		}

		// Token: 0x06011B6E RID: 72558 RVA: 0x0006C750 File Offset: 0x0006A950
		[Token(Token = "0x6011B6E")]
		[Address(RVA = "0x992010", Offset = "0x990C10", VA = "0x180992010")]
		private bool <>xLuaBaseProxy__CheckProjectileInValid()
		{
			return default(bool);
		}

		// Token: 0x04013DC6 RID: 81350
		[Token(Token = "0x4013DC6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__CheckProjectileInValid;

		// Token: 0x04013DC7 RID: 81351
		[Token(Token = "0x4013DC7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
