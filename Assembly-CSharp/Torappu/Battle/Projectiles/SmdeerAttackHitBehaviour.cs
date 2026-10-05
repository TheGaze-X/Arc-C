using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029B7 RID: 10679
	[Token(Token = "0x20029B7")]
	public class SmdeerAttackHitBehaviour : Projectile.Behaviour
	{
		// Token: 0x06011AF0 RID: 72432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AF0")]
		[Address(RVA = "0x988590", Offset = "0x987190", VA = "0x180988590", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011AF1 RID: 72433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AF1")]
		[Address(RVA = "0x9888B0", Offset = "0x9874B0", VA = "0x1809888B0", Slot = "5")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011AF2 RID: 72434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AF2")]
		[Address(RVA = "0x988960", Offset = "0x987560", VA = "0x180988960")]
		private void _CheckDistanceToEmitProjectile()
		{
		}

		// Token: 0x06011AF3 RID: 72435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AF3")]
		[Address(RVA = "0x9883C0", Offset = "0x986FC0", VA = "0x1809883C0")]
		private void EmitSubProjectile(ILocatable pos)
		{
		}

		// Token: 0x06011AF4 RID: 72436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AF4")]
		[Address(RVA = "0x988C40", Offset = "0x987840", VA = "0x180988C40")]
		public SmdeerAttackHitBehaviour()
		{
		}

		// Token: 0x06011AF5 RID: 72437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AF5")]
		[Address(RVA = "0x5EEAD0", Offset = "0x5ED6D0", VA = "0x1805EEAD0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011AF6 RID: 72438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AF6")]
		[Address(RVA = "0x94DC60", Offset = "0x94C860", VA = "0x18094DC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04013D15 RID: 81173
		[Token(Token = "0x4013D15")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _projectileKey;

		// Token: 0x04013D16 RID: 81174
		[Token(Token = "0x4013D16")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SharedConsts.Direction _defaultDirection;

		// Token: 0x04013D17 RID: 81175
		[Token(Token = "0x4013D17")]
		[FieldOffset(Offset = "0x34")]
		private Vector2 m_startPos;

		// Token: 0x04013D18 RID: 81176
		[Token(Token = "0x4013D18")]
		[FieldOffset(Offset = "0x3C")]
		private Vector2 m_direction;

		// Token: 0x04013D19 RID: 81177
		[Token(Token = "0x4013D19")]
		[FieldOffset(Offset = "0x44")]
		private float m_bombDist;

		// Token: 0x04013D1A RID: 81178
		[Token(Token = "0x4013D1A")]
		[FieldOffset(Offset = "0x48")]
		private int m_currentBombIndex;

		// Token: 0x04013D1B RID: 81179
		[Token(Token = "0x4013D1B")]
		[FieldOffset(Offset = "0x4C")]
		private float m_subAtkScale;

		// Token: 0x04013D1C RID: 81180
		[Token(Token = "0x4013D1C")]
		[FieldOffset(Offset = "0x50")]
		private List<ActionNode> m_damageNodeReplacedActionNodes;

		// Token: 0x04013D1D RID: 81181
		[Token(Token = "0x4013D1D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013D1E RID: 81182
		[Token(Token = "0x4013D1E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013D1F RID: 81183
		[Token(Token = "0x4013D1F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckDistanceToEmitProjectile;

		// Token: 0x04013D20 RID: 81184
		[Token(Token = "0x4013D20")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EmitSubProjectile;

		// Token: 0x04013D21 RID: 81185
		[Token(Token = "0x4013D21")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
