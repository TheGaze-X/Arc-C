using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002396 RID: 9110
	[Token(Token = "0x2002396")]
	public class DirectionTile : Tile
	{
		// Token: 0x17001D02 RID: 7426
		// (get) Token: 0x0600E70D RID: 59149 RVA: 0x00054288 File Offset: 0x00052488
		[Token(Token = "0x17001D02")]
		public SharedConsts.Direction tileDirection
		{
			[Token(Token = "0x600E70D")]
			[Address(RVA = "0x5BF430", Offset = "0x5BE030", VA = "0x1805BF430")]
			get
			{
				return SharedConsts.Direction.UP;
			}
		}

		// Token: 0x0600E70E RID: 59150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E70E")]
		[Address(RVA = "0x5BF2C0", Offset = "0x5BDEC0", VA = "0x1805BF2C0", Slot = "21")]
		public override void Init(TileData tileData, GridPosition pos)
		{
		}

		// Token: 0x0600E70F RID: 59151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E70F")]
		[Address(RVA = "0x5BF3C0", Offset = "0x5BDFC0", VA = "0x1805BF3C0")]
		public DirectionTile()
		{
		}

		// Token: 0x0600E710 RID: 59152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E710")]
		[Address(RVA = "0x5B8930", Offset = "0x5B7530", VA = "0x1805B8930")]
		private void <>xLuaBaseProxy_Init(TileData P0, GridPosition P1)
		{
		}

		// Token: 0x0400FE89 RID: 65161
		[Token(Token = "0x400FE89")]
		[FieldOffset(Offset = "0x128")]
		private SharedConsts.Direction m_tileDirection;

		// Token: 0x0400FE8A RID: 65162
		[Token(Token = "0x400FE8A")]
		private const string DEFAULT_DIRECTION = "left";

		// Token: 0x0400FE8B RID: 65163
		[Token(Token = "0x400FE8B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_tileDirection;

		// Token: 0x0400FE8C RID: 65164
		[Token(Token = "0x400FE8C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400FE8D RID: 65165
		[Token(Token = "0x400FE8D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
