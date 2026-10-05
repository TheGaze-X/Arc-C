using System;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine.Scripting;

namespace UnityEngine.Tilemaps
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	[RequiredByNativeCode]
	public class ITilemap
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal ITilemap()
		{
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x5A05720", Offset = "0x5A04320", VA = "0x185A05720")]
		public void RefreshTile(Vector3Int position)
		{
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x5A050B0", Offset = "0x5A03CB0", VA = "0x185A050B0")]
		[RequiredByNativeCode]
		private static ITilemap CreateInstance()
		{
			return null;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x5A05140", Offset = "0x5A03D40", VA = "0x185A05140")]
		[RequiredByNativeCode]
		private static void FindAllRefreshPositions(ITilemap tilemap, int count, IntPtr oldTilesIntPtr, IntPtr newTilesIntPtr, IntPtr positionsIntPtr)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x5A054A0", Offset = "0x5A040A0", VA = "0x185A054A0")]
		[RequiredByNativeCode]
		private static void GetAllTileData(ITilemap tilemap, int count, IntPtr tilesIntPtr, IntPtr positionsIntPtr, IntPtr outTileDataIntPtr)
		{
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x0")]
		internal static ITilemap s_Instance;

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x10")]
		internal Tilemap m_Tilemap;

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x18")]
		internal bool m_AddToList;

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x1C")]
		internal int m_RefreshCount;

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x20")]
		internal NativeArray<Vector3Int> m_RefreshPos;
	}
}
