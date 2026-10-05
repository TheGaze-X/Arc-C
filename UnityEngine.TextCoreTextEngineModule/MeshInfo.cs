using System;
using Il2CppDummyDll;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	internal struct MeshInfo
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x59F4ED0", Offset = "0x59F3AD0", VA = "0x1859F4ED0")]
		public MeshInfo(int size)
		{
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x59F44D0", Offset = "0x59F30D0", VA = "0x1859F44D0")]
		internal void ResizeMeshInfo(int size)
		{
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x59F44A0", Offset = "0x59F30A0", VA = "0x1859F44A0")]
		internal void Clear(bool uploadChanges)
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x59F4460", Offset = "0x59F3060", VA = "0x1859F4460")]
		internal void ClearUnusedVertices()
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x59F46B0", Offset = "0x59F32B0", VA = "0x1859F46B0")]
		internal void SortGeometry(VertexSortingOrder order)
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x59F4760", Offset = "0x59F3360", VA = "0x1859F4760")]
		internal void SwapVertexData(int src, int dst)
		{
		}

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color32 k_DefaultColor;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x0")]
		public int vertexCount;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x8")]
		public Vector3[] vertices;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x10")]
		public Vector2[] uvs0;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x18")]
		public Vector2[] uvs2;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x20")]
		public Color32[] colors32;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x28")]
		public int[] triangles;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x30")]
		public Material material;
	}
}
