using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.Tiles
{
	// Token: 0x020029F7 RID: 10743
	[Token(Token = "0x20029F7")]
	public class UpdateTileHeight : Tile.Behaviour
	{
		// Token: 0x06011D23 RID: 72995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D23")]
		[Address(RVA = "0x9BF670", Offset = "0x9BE270", VA = "0x1809BF670", Slot = "5")]
		public override void ImportInit(Tile tile)
		{
		}

		// Token: 0x06011D24 RID: 72996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D24")]
		[Address(RVA = "0x9BF670", Offset = "0x9BE270", VA = "0x1809BF670", Slot = "4")]
		public override void Init(Tile tile)
		{
		}

		// Token: 0x06011D25 RID: 72997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D25")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public UpdateTileHeight()
		{
		}

		// Token: 0x04014048 RID: 81992
		[Token(Token = "0x4014048")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _heightOffset;
	}
}
