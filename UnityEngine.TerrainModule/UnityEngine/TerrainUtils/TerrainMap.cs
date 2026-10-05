using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.TerrainUtils
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	public class TerrainMap
	{
		// Token: 0x06000018 RID: 24 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x59CDF40", Offset = "0x59CCB40", VA = "0x1859CDF40")]
		public Terrain GetTerrain(int tileX, int tileZ)
		{
			return null;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x59CDBF0", Offset = "0x59CC7F0", VA = "0x1859CDBF0")]
		public static TerrainMap CreateFromPlacement(Terrain originTerrain, [Optional] Predicate<Terrain> filter, bool fullValidation = true)
		{
			return null;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x59CD860", Offset = "0x59CC460", VA = "0x1859CD860")]
		public static TerrainMap CreateFromPlacement(Vector2 gridOrigin, Vector2 gridSize, [Optional] Predicate<Terrain> filter, bool fullValidation = true)
		{
			return null;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001B RID: 27 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000007")]
		public Dictionary<TerrainTileCoord, Terrain> terrainTiles
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x59CE8B0", Offset = "0x59CD4B0", VA = "0x1859CE8B0")]
		public TerrainMap()
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x59CD680", Offset = "0x59CC280", VA = "0x1859CD680")]
		private void AddTerrainInternal(int x, int z, Terrain terrain)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002070 File Offset: 0x00000270
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x59CDFC0", Offset = "0x59CCBC0", VA = "0x1859CDFC0")]
		private bool TryToAddTerrain(int tileX, int tileZ, Terrain terrain)
		{
			return default(bool);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x59CE0D0", Offset = "0x59CCCD0", VA = "0x1859CE0D0")]
		private void ValidateTerrain(int tileX, int tileZ)
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002088 File Offset: 0x00000288
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x59CE770", Offset = "0x59CD370", VA = "0x1859CE770")]
		private TerrainMapStatusCode Validate()
		{
			return TerrainMapStatusCode.OK;
		}

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Vector3 m_patchSize;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private TerrainMapStatusCode m_errorCode;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<TerrainTileCoord, Terrain> m_terrainTiles;
	}
}
