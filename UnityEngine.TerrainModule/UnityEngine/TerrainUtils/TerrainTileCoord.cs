using System;
using Il2CppDummyDll;

namespace UnityEngine.TerrainUtils
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	public readonly struct TerrainTileCoord
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x4F1E60", Offset = "0x4F0A60", VA = "0x1804F1E60")]
		public TerrainTileCoord(int tileX, int tileZ)
		{
		}

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x0")]
		public readonly int tileX;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x4")]
		public readonly int tileZ;
	}
}
