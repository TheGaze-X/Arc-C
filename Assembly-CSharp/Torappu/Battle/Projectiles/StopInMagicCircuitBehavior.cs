using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029BA RID: 10682
	[Token(Token = "0x20029BA")]
	public class StopInMagicCircuitBehavior : Projectile.Behaviour
	{
		// Token: 0x06011B0B RID: 72459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B0B")]
		[Address(RVA = "0x98B070", Offset = "0x989C70", VA = "0x18098B070", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011B0C RID: 72460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B0C")]
		[Address(RVA = "0x98B160", Offset = "0x989D60", VA = "0x18098B160", Slot = "5")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011B0D RID: 72461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B0D")]
		[Address(RVA = "0x98B480", Offset = "0x98A080", VA = "0x18098B480")]
		private void _StopInMagicCircuit()
		{
		}

		// Token: 0x06011B0E RID: 72462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B0E")]
		[Address(RVA = "0x98B580", Offset = "0x98A180", VA = "0x18098B580")]
		public StopInMagicCircuitBehavior()
		{
		}

		// Token: 0x06011B0F RID: 72463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B0F")]
		[Address(RVA = "0x5EEAD0", Offset = "0x5ED6D0", VA = "0x1805EEAD0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011B10 RID: 72464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B10")]
		[Address(RVA = "0x94DC60", Offset = "0x94C860", VA = "0x18094DC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04013D45 RID: 81221
		[Token(Token = "0x4013D45")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _stopEffectKey;

		// Token: 0x04013D46 RID: 81222
		[Token(Token = "0x4013D46")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _delayStop;

		// Token: 0x04013D47 RID: 81223
		[Token(Token = "0x4013D47")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _delayCheck;

		// Token: 0x04013D48 RID: 81224
		[Token(Token = "0x4013D48")]
		[FieldOffset(Offset = "0x38")]
		private Tile m_currentTile;

		// Token: 0x04013D49 RID: 81225
		[Token(Token = "0x4013D49")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasStopInMagicCircuit;

		// Token: 0x04013D4A RID: 81226
		[Token(Token = "0x4013D4A")]
		[FieldOffset(Offset = "0x48")]
		private FP m_delayCheckTicker;

		// Token: 0x04013D4B RID: 81227
		[Token(Token = "0x4013D4B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013D4C RID: 81228
		[Token(Token = "0x4013D4C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013D4D RID: 81229
		[Token(Token = "0x4013D4D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__StopInMagicCircuit;

		// Token: 0x04013D4E RID: 81230
		[Token(Token = "0x4013D4E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
