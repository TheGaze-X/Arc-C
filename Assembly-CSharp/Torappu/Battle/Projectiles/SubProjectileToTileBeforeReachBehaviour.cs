using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029BC RID: 10684
	[Token(Token = "0x20029BC")]
	public class SubProjectileToTileBeforeReachBehaviour : Projectile.Behaviour
	{
		// Token: 0x06011B14 RID: 72468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B14")]
		[Address(RVA = "0x98B920", Offset = "0x98A520", VA = "0x18098B920", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011B15 RID: 72469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B15")]
		[Address(RVA = "0x98B9F0", Offset = "0x98A5F0", VA = "0x18098B9F0", Slot = "5")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011B16 RID: 72470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B16")]
		[Address(RVA = "0x98B770", Offset = "0x98A370", VA = "0x18098B770")]
		private void EmitSubProjectile(ILocatable pos)
		{
		}

		// Token: 0x06011B17 RID: 72471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B17")]
		[Address(RVA = "0x98BD40", Offset = "0x98A940", VA = "0x18098BD40")]
		public SubProjectileToTileBeforeReachBehaviour()
		{
		}

		// Token: 0x06011B18 RID: 72472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B18")]
		[Address(RVA = "0x5EEAD0", Offset = "0x5ED6D0", VA = "0x1805EEAD0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011B19 RID: 72473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B19")]
		[Address(RVA = "0x94DC60", Offset = "0x94C860", VA = "0x18094DC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04013D52 RID: 81234
		[Token(Token = "0x4013D52")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _projectileKey;

		// Token: 0x04013D53 RID: 81235
		[Token(Token = "0x4013D53")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasFirstEmit;

		// Token: 0x04013D54 RID: 81236
		[Token(Token = "0x4013D54")]
		[FieldOffset(Offset = "0x38")]
		private HashSet<int> m_emittedTiles;

		// Token: 0x04013D55 RID: 81237
		[Token(Token = "0x4013D55")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013D56 RID: 81238
		[Token(Token = "0x4013D56")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013D57 RID: 81239
		[Token(Token = "0x4013D57")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EmitSubProjectile;

		// Token: 0x04013D58 RID: 81240
		[Token(Token = "0x4013D58")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
