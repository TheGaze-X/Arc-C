using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AAF RID: 10927
	[Token(Token = "0x2002AAF")]
	public class FuzeSkill2RangedAttack : MultiRangedAttack
	{
		// Token: 0x170027E1 RID: 10209
		// (get) Token: 0x060122BF RID: 74431 RVA: 0x0006F5A0 File Offset: 0x0006D7A0
		[Token(Token = "0x170027E1")]
		public override bool allowNoTarget
		{
			[Token(Token = "0x60122BF")]
			[Address(RVA = "0xA3D670", Offset = "0xA3C270", VA = "0x180A3D670", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060122C0 RID: 74432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122C0")]
		[Address(RVA = "0xA3C730", Offset = "0xA3B330", VA = "0x180A3C730", Slot = "50")]
		protected override void OnCastStart()
		{
		}

		// Token: 0x060122C1 RID: 74433 RVA: 0x0006F5B8 File Offset: 0x0006D7B8
		[Token(Token = "0x60122C1")]
		[Address(RVA = "0xA3C560", Offset = "0xA3B160", VA = "0x180A3C560", Slot = "85")]
		protected override bool DoCastOnTargets(IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
			return default(bool);
		}

		// Token: 0x060122C2 RID: 74434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60122C2")]
		[Address(RVA = "0xA3C350", Offset = "0xA3AF50", VA = "0x180A3C350", Slot = "113")]
		protected override Projectile CreateProjectile(ILocatable target, out Projectile fakeProjectile)
		{
			return null;
		}

		// Token: 0x060122C3 RID: 74435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122C3")]
		[Address(RVA = "0xA3CF00", Offset = "0xA3BB00", VA = "0x180A3CF00")]
		private void _CreateProjectiles(int i)
		{
		}

		// Token: 0x060122C4 RID: 74436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122C4")]
		[Address(RVA = "0xA3D010", Offset = "0xA3BC10", VA = "0x180A3D010")]
		public FuzeSkill2RangedAttack()
		{
		}

		// Token: 0x060122C5 RID: 74437 RVA: 0x0006F5D0 File Offset: 0x0006D7D0
		[Token(Token = "0x60122C5")]
		[Address(RVA = "0xA3CEF0", Offset = "0xA3BAF0", VA = "0x180A3CEF0")]
		private bool <>xLuaBaseProxy_get_allowNoTarget()
		{
			return default(bool);
		}

		// Token: 0x060122C6 RID: 74438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122C6")]
		[Address(RVA = "0xA3CEE0", Offset = "0xA3BAE0", VA = "0x180A3CEE0")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x060122C7 RID: 74439 RVA: 0x0006F5E8 File Offset: 0x0006D7E8
		[Token(Token = "0x60122C7")]
		[Address(RVA = "0xA3CED0", Offset = "0xA3BAD0", VA = "0x180A3CED0")]
		private bool <>xLuaBaseProxy_DoCastOnTargets(IList<ActionNode> P0, IList<BuffData> P1, IList<IAbilityAttachment> P2)
		{
			return default(bool);
		}

		// Token: 0x060122C8 RID: 74440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60122C8")]
		[Address(RVA = "0xA3CEC0", Offset = "0xA3BAC0", VA = "0x180A3CEC0")]
		private Projectile <>xLuaBaseProxy_CreateProjectile(ILocatable P0, out Projectile P1)
		{
			return null;
		}

		// Token: 0x040148E3 RID: 84195
		[Token(Token = "0x40148E3")]
		[FieldOffset(Offset = "0x2D8")]
		[SerializeField]
		[Group("Fuze")]
		private float _offset;

		// Token: 0x040148E4 RID: 84196
		[Token(Token = "0x40148E4")]
		[FieldOffset(Offset = "0x2DC")]
		[SerializeField]
		[Group("Fuze")]
		private float _beginOffset;

		// Token: 0x040148E5 RID: 84197
		[Token(Token = "0x40148E5")]
		[FieldOffset(Offset = "0x2E0")]
		[SerializeField]
		[Group("Fuze")]
		private string _effectKey;

		// Token: 0x040148E6 RID: 84198
		[Token(Token = "0x40148E6")]
		[FieldOffset(Offset = "0x2E8")]
		private List<Tile> m_targetTiles;

		// Token: 0x040148E7 RID: 84199
		[Token(Token = "0x40148E7")]
		[FieldOffset(Offset = "0x2F0")]
		private readonly GridPosition[,] TARGET_GRIDPOSITION_LIST;

		// Token: 0x040148E8 RID: 84200
		[Token(Token = "0x40148E8")]
		[FieldOffset(Offset = "0x2F8")]
		private readonly Vector2[] PROJEJCTILE_OFFSET_DIRECTION;

		// Token: 0x040148E9 RID: 84201
		[Token(Token = "0x40148E9")]
		[FieldOffset(Offset = "0x300")]
		private readonly Vector3[] BEGIN_OFFSET_POSITION;

		// Token: 0x040148EA RID: 84202
		[Token(Token = "0x40148EA")]
		[FieldOffset(Offset = "0x308")]
		private readonly int MAX_TARGET_TILE_COUNT;

		// Token: 0x040148EB RID: 84203
		[Token(Token = "0x40148EB")]
		[FieldOffset(Offset = "0x30C")]
		private int m_hitTime;

		// Token: 0x040148EC RID: 84204
		[Token(Token = "0x40148EC")]
		[FieldOffset(Offset = "0x310")]
		private FixedPosition[] m_targetPositions;

		// Token: 0x040148ED RID: 84205
		[Token(Token = "0x40148ED")]
		[FieldOffset(Offset = "0x318")]
		private FixedPosition m_projectileStartPos;

		// Token: 0x040148EE RID: 84206
		[Token(Token = "0x40148EE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_allowNoTarget;

		// Token: 0x040148EF RID: 84207
		[Token(Token = "0x40148EF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x040148F0 RID: 84208
		[Token(Token = "0x40148F0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoCastOnTargets;

		// Token: 0x040148F1 RID: 84209
		[Token(Token = "0x40148F1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CreateProjectile;

		// Token: 0x040148F2 RID: 84210
		[Token(Token = "0x40148F2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CreateProjectiles;

		// Token: 0x040148F3 RID: 84211
		[Token(Token = "0x40148F3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
