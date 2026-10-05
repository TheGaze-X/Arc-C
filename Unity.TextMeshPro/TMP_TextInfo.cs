using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	// Token: 0x0200009B RID: 155
	[Token(Token = "0x200009B")]
	[Serializable]
	public class TMP_TextInfo
	{
		// Token: 0x060005E8 RID: 1512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x58D28D0", Offset = "0x58D14D0", VA = "0x1858D28D0")]
		public TMP_TextInfo()
		{
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x58D2BC0", Offset = "0x58D17C0", VA = "0x1858D2BC0")]
		internal TMP_TextInfo(int characterCount)
		{
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x58D2A00", Offset = "0x58D1600", VA = "0x1858D2A00")]
		public TMP_TextInfo(TMP_Text textComponent)
		{
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x58D2270", Offset = "0x58D0E70", VA = "0x1858D2270")]
		public void Clear()
		{
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x58D1B80", Offset = "0x58D0780", VA = "0x1858D1B80")]
		internal void ClearAllData()
		{
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x58D1FF0", Offset = "0x58D0BF0", VA = "0x1858D1FF0")]
		public void ClearMeshInfo(bool updateMesh)
		{
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x58D1CC0", Offset = "0x58D08C0", VA = "0x1858D1CC0")]
		public void ClearAllMeshInfo()
		{
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x58D27B0", Offset = "0x58D13B0", VA = "0x1858D27B0")]
		public void ResetVertexLayout(bool isVolumetric)
		{
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x58D21B0", Offset = "0x58D0DB0", VA = "0x1858D21B0")]
		public void ClearUnusedVertices(MaterialReference[] materials)
		{
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x58D1D70", Offset = "0x58D0970", VA = "0x1858D1D70")]
		public void ClearLineInfo()
		{
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x58D20B0", Offset = "0x58D0CB0", VA = "0x1858D20B0")]
		internal void ClearPageInfo()
		{
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x58D22F0", Offset = "0x58D0EF0", VA = "0x1858D22F0")]
		public TMP_MeshInfo[] CopyMeshInfoVertexData()
		{
			return null;
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F4")]
		public static void Resize<T>(ref T[] array, int size)
		{
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F5")]
		public static void Resize<T>(ref T[] array, int size, bool isBlockAllocated)
		{
		}

		// Token: 0x040005C4 RID: 1476
		[Token(Token = "0x40005C4")]
		[FieldOffset(Offset = "0x0")]
		internal static Vector2 k_InfinityVectorPositive;

		// Token: 0x040005C5 RID: 1477
		[Token(Token = "0x40005C5")]
		[FieldOffset(Offset = "0x8")]
		internal static Vector2 k_InfinityVectorNegative;

		// Token: 0x040005C6 RID: 1478
		[Token(Token = "0x40005C6")]
		[FieldOffset(Offset = "0x10")]
		public TMP_Text textComponent;

		// Token: 0x040005C7 RID: 1479
		[Token(Token = "0x40005C7")]
		[FieldOffset(Offset = "0x18")]
		public int characterCount;

		// Token: 0x040005C8 RID: 1480
		[Token(Token = "0x40005C8")]
		[FieldOffset(Offset = "0x1C")]
		public int spriteCount;

		// Token: 0x040005C9 RID: 1481
		[Token(Token = "0x40005C9")]
		[FieldOffset(Offset = "0x20")]
		public int spaceCount;

		// Token: 0x040005CA RID: 1482
		[Token(Token = "0x40005CA")]
		[FieldOffset(Offset = "0x24")]
		public int wordCount;

		// Token: 0x040005CB RID: 1483
		[Token(Token = "0x40005CB")]
		[FieldOffset(Offset = "0x28")]
		public int linkCount;

		// Token: 0x040005CC RID: 1484
		[Token(Token = "0x40005CC")]
		[FieldOffset(Offset = "0x2C")]
		public int lineCount;

		// Token: 0x040005CD RID: 1485
		[Token(Token = "0x40005CD")]
		[FieldOffset(Offset = "0x30")]
		public int pageCount;

		// Token: 0x040005CE RID: 1486
		[Token(Token = "0x40005CE")]
		[FieldOffset(Offset = "0x34")]
		public int materialCount;

		// Token: 0x040005CF RID: 1487
		[Token(Token = "0x40005CF")]
		[FieldOffset(Offset = "0x38")]
		public TMP_CharacterInfo[] characterInfo;

		// Token: 0x040005D0 RID: 1488
		[Token(Token = "0x40005D0")]
		[FieldOffset(Offset = "0x40")]
		public TMP_WordInfo[] wordInfo;

		// Token: 0x040005D1 RID: 1489
		[Token(Token = "0x40005D1")]
		[FieldOffset(Offset = "0x48")]
		public TMP_LinkInfo[] linkInfo;

		// Token: 0x040005D2 RID: 1490
		[Token(Token = "0x40005D2")]
		[FieldOffset(Offset = "0x50")]
		public TMP_LineInfo[] lineInfo;

		// Token: 0x040005D3 RID: 1491
		[Token(Token = "0x40005D3")]
		[FieldOffset(Offset = "0x58")]
		public TMP_PageInfo[] pageInfo;

		// Token: 0x040005D4 RID: 1492
		[Token(Token = "0x40005D4")]
		[FieldOffset(Offset = "0x60")]
		public TMP_MeshInfo[] meshInfo;

		// Token: 0x040005D5 RID: 1493
		[Token(Token = "0x40005D5")]
		[FieldOffset(Offset = "0x68")]
		private TMP_MeshInfo[] m_CachedMeshInfo;
	}
}
