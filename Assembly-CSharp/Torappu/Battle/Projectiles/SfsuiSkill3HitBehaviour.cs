using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029B3 RID: 10675
	[Token(Token = "0x20029B3")]
	[RequireComponent(typeof(BoxCollider2D))]
	public class SfsuiSkill3HitBehaviour : Projectile.Behaviour
	{
		// Token: 0x06011ADC RID: 72412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011ADC")]
		[Address(RVA = "0x987200", Offset = "0x985E00", VA = "0x180987200", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011ADD RID: 72413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011ADD")]
		[Address(RVA = "0x9872E0", Offset = "0x985EE0", VA = "0x1809872E0", Slot = "9")]
		public override void OnProjectileReached()
		{
		}

		// Token: 0x06011ADE RID: 72414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011ADE")]
		[Address(RVA = "0x987350", Offset = "0x985F50", VA = "0x180987350", Slot = "7")]
		public override void OnProjectileStop()
		{
		}

		// Token: 0x06011ADF RID: 72415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011ADF")]
		[Address(RVA = "0x9874D0", Offset = "0x9860D0", VA = "0x1809874D0")]
		private void _EmitProjectileToRightmostTile()
		{
		}

		// Token: 0x06011AE0 RID: 72416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AE0")]
		[Address(RVA = "0x987790", Offset = "0x986390", VA = "0x180987790")]
		public SfsuiSkill3HitBehaviour()
		{
		}

		// Token: 0x06011AE1 RID: 72417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AE1")]
		[Address(RVA = "0x5EEAD0", Offset = "0x5ED6D0", VA = "0x1805EEAD0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011AE2 RID: 72418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AE2")]
		[Address(RVA = "0x970BF0", Offset = "0x96F7F0", VA = "0x180970BF0")]
		private void <>xLuaBaseProxy_OnProjectileReached()
		{
		}

		// Token: 0x06011AE3 RID: 72419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AE3")]
		[Address(RVA = "0x94DC50", Offset = "0x94C850", VA = "0x18094DC50")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x04013CFD RID: 81149
		[Token(Token = "0x4013CFD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<SfsuiSkill3HitBehaviour.SfsuiEmitProjectiles> _emitProjectiles;

		// Token: 0x04013CFE RID: 81150
		[Token(Token = "0x4013CFE")]
		[FieldOffset(Offset = "0x30")]
		private List<Projectile> m_subProjectiles;

		// Token: 0x04013CFF RID: 81151
		[Token(Token = "0x4013CFF")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isReached;

		// Token: 0x04013D00 RID: 81152
		[Token(Token = "0x4013D00")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013D01 RID: 81153
		[Token(Token = "0x4013D01")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnProjectileReached;

		// Token: 0x04013D02 RID: 81154
		[Token(Token = "0x4013D02")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04013D03 RID: 81155
		[Token(Token = "0x4013D03")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EmitProjectileToRightmostTile;

		// Token: 0x04013D04 RID: 81156
		[Token(Token = "0x4013D04")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020029B4 RID: 10676
		[Token(Token = "0x20029B4")]
		[Serializable]
		private struct SfsuiEmitProjectiles
		{
			// Token: 0x04013D05 RID: 81157
			[Token(Token = "0x4013D05")]
			[FieldOffset(Offset = "0x0")]
			public bool isGraphicProjectile;

			// Token: 0x04013D06 RID: 81158
			[Token(Token = "0x4013D06")]
			[FieldOffset(Offset = "0x8")]
			public string projectileKey;
		}
	}
}
