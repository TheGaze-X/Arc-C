using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029F3 RID: 10739
	[Token(Token = "0x20029F3")]
	public class TileTargetMovement : AdvancedMovement
	{
		// Token: 0x06011D0F RID: 72975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D0F")]
		[Address(RVA = "0x9B8810", Offset = "0x9B7410", VA = "0x1809B8810", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011D10 RID: 72976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D10")]
		[Address(RVA = "0x9B89F0", Offset = "0x9B75F0", VA = "0x1809B89F0", Slot = "5")]
		public override void OnTick(FP deltaTimeFp)
		{
		}

		// Token: 0x06011D11 RID: 72977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D11")]
		[Address(RVA = "0x9B9120", Offset = "0x9B7D20", VA = "0x1809B9120")]
		public TileTargetMovement()
		{
		}

		// Token: 0x06011D12 RID: 72978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D12")]
		[Address(RVA = "0x9936C0", Offset = "0x9922C0", VA = "0x1809936C0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011D13 RID: 72979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D13")]
		[Address(RVA = "0x994070", Offset = "0x992C70", VA = "0x180994070")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04014036 RID: 81974
		[Token(Token = "0x4014036")]
		[FieldOffset(Offset = "0x140")]
		private Tile _targetTile;

		// Token: 0x04014037 RID: 81975
		[Token(Token = "0x4014037")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04014038 RID: 81976
		[Token(Token = "0x4014038")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04014039 RID: 81977
		[Token(Token = "0x4014039")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
