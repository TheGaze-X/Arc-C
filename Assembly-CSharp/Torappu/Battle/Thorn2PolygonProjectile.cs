using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020023E3 RID: 9187
	[Token(Token = "0x20023E3")]
	public class Thorn2PolygonProjectile : SimpleProjectile
	{
		// Token: 0x17001DE1 RID: 7649
		// (get) Token: 0x0600EA7C RID: 60028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001DE1")]
		public List<Tile> polygonRangeTiles
		{
			[Token(Token = "0x600EA7C")]
			[Address(RVA = "0x618F70", Offset = "0x617B70", VA = "0x180618F70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600EA7D RID: 60029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA7D")]
		[Address(RVA = "0x618DF0", Offset = "0x6179F0", VA = "0x180618DF0", Slot = "30")]
		protected override void OnInit(float initHeight)
		{
		}

		// Token: 0x0600EA7E RID: 60030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA7E")]
		[Address(RVA = "0x618EB0", Offset = "0x617AB0", VA = "0x180618EB0")]
		public Thorn2PolygonProjectile()
		{
		}

		// Token: 0x0600EA7F RID: 60031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EA7F")]
		[Address(RVA = "0x50CDF0", Offset = "0x50B9F0", VA = "0x18050CDF0")]
		private void <>xLuaBaseProxy_OnInit(float P0)
		{
		}

		// Token: 0x040102E7 RID: 66279
		[Token(Token = "0x40102E7")]
		[FieldOffset(Offset = "0x1B0")]
		private List<Tile> m_polygonRangeTiles;

		// Token: 0x040102E8 RID: 66280
		[Token(Token = "0x40102E8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_polygonRangeTiles;

		// Token: 0x040102E9 RID: 66281
		[Token(Token = "0x40102E9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040102EA RID: 66282
		[Token(Token = "0x40102EA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
