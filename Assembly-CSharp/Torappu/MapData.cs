using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x020010E5 RID: 4325
	[Token(Token = "0x20010E5")]
	[Serializable]
	public class MapData
	{
		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x06006E88 RID: 28296 RVA: 0x00032148 File Offset: 0x00030348
		[Token(Token = "0x17000D28")]
		[JsonIgnore]
		public int width
		{
			[Token(Token = "0x6006E88")]
			[Address(RVA = "0x2107600", Offset = "0x2106200", VA = "0x182107600")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x06006E89 RID: 28297 RVA: 0x00032160 File Offset: 0x00030360
		[Token(Token = "0x17000D29")]
		[JsonIgnore]
		public int height
		{
			[Token(Token = "0x6006E89")]
			[Address(RVA = "0x21075D0", Offset = "0x21061D0", VA = "0x1821075D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000D2A RID: 3370
		[Token(Token = "0x17000D2A")]
		public TileData this[int r, int c]
		{
			[Token(Token = "0x6006E8A")]
			[Address(RVA = "0x2107540", Offset = "0x2106140", VA = "0x182107540")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D2B RID: 3371
		[Token(Token = "0x17000D2B")]
		public TileData this[GridPosition pos]
		{
			[Token(Token = "0x6006E8B")]
			[Address(RVA = "0x21074B0", Offset = "0x21060B0", VA = "0x1821074B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006E8C RID: 28300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E8C")]
		[Address(RVA = "0x2107420", Offset = "0x2106020", VA = "0x182107420")]
		public MapData()
		{
		}

		// Token: 0x04005CAF RID: 23727
		[Token(Token = "0x4005CAF")]
		[FieldOffset(Offset = "0x10")]
		public short[,] map;

		// Token: 0x04005CB0 RID: 23728
		[Token(Token = "0x4005CB0")]
		[FieldOffset(Offset = "0x18")]
		public TileData[] tiles;

		// Token: 0x04005CB1 RID: 23729
		[Token(Token = "0x4005CB1")]
		[FieldOffset(Offset = "0x20")]
		public MapData.Edge[] blockEdges;

		// Token: 0x04005CB2 RID: 23730
		[Token(Token = "0x4005CB2")]
		[FieldOffset(Offset = "0x28")]
		public string[] tags;

		// Token: 0x04005CB3 RID: 23731
		[Token(Token = "0x4005CB3")]
		[FieldOffset(Offset = "0x30")]
		public MapEffectData[] effects;

		// Token: 0x04005CB4 RID: 23732
		[Token(Token = "0x4005CB4")]
		[FieldOffset(Offset = "0x38")]
		public string[] layerRects;

		// Token: 0x020010E6 RID: 4326
		[Token(Token = "0x20010E6")]
		[Serializable]
		public class Edge
		{
			// Token: 0x06006E8D RID: 28301 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006E8D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Edge()
			{
			}

			// Token: 0x04005CB5 RID: 23733
			[Token(Token = "0x4005CB5")]
			[FieldOffset(Offset = "0x10")]
			public GridPosition pos;

			// Token: 0x04005CB6 RID: 23734
			[Token(Token = "0x4005CB6")]
			[FieldOffset(Offset = "0x18")]
			public SharedConsts.Direction direction;

			// Token: 0x04005CB7 RID: 23735
			[Token(Token = "0x4005CB7")]
			[FieldOffset(Offset = "0x1C")]
			public MotionMask blockMask;
		}
	}
}
