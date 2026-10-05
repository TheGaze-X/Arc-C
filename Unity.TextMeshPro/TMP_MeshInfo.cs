using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	// Token: 0x0200006E RID: 110
	[Token(Token = "0x200006E")]
	public struct TMP_MeshInfo
	{
		// Token: 0x060003AA RID: 938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x58C9640", Offset = "0x58C8240", VA = "0x1858C9640")]
		public TMP_MeshInfo(Mesh mesh, int size)
		{
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x58C9C20", Offset = "0x58C8820", VA = "0x1858C9C20")]
		public TMP_MeshInfo(Mesh mesh, int size, bool isVolumetric)
		{
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x58C7C50", Offset = "0x58C6850", VA = "0x1858C7C50")]
		public void ResizeMeshInfo(int size)
		{
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x58C8150", Offset = "0x58C6D50", VA = "0x1858C8150")]
		public void ResizeMeshInfo(int size, bool isVolumetric)
		{
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x58C7A80", Offset = "0x58C6680", VA = "0x1858C7A80")]
		public void Clear()
		{
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x58C7B20", Offset = "0x58C6720", VA = "0x1858C7B20")]
		public void Clear(bool uploadChanges)
		{
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x58C7A40", Offset = "0x58C6640", VA = "0x1858C7A40")]
		public void ClearUnusedVertices()
		{
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x58C7960", Offset = "0x58C6560", VA = "0x1858C7960")]
		public void ClearUnusedVertices(int startIndex)
		{
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x58C7990", Offset = "0x58C6590", VA = "0x1858C7990")]
		public void ClearUnusedVertices(int startIndex, bool updateMesh)
		{
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x58C8C10", Offset = "0x58C7810", VA = "0x1858C8C10")]
		public void SortGeometry(VertexSortingOrder order)
		{
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x58C8CC0", Offset = "0x58C78C0", VA = "0x1858C8CC0")]
		public void SortGeometry(IList<int> sortingOrder)
		{
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x58C8E70", Offset = "0x58C7A70", VA = "0x1858C8E70")]
		public void SwapVertexData(int src, int dst)
		{
		}

		// Token: 0x040002EE RID: 750
		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color32 s_DefaultColor;

		// Token: 0x040002EF RID: 751
		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x4")]
		private static readonly Vector3 s_DefaultNormal;

		// Token: 0x040002F0 RID: 752
		[Token(Token = "0x40002F0")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Vector4 s_DefaultTangent;

		// Token: 0x040002F1 RID: 753
		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Bounds s_DefaultBounds;

		// Token: 0x040002F2 RID: 754
		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x0")]
		public Mesh mesh;

		// Token: 0x040002F3 RID: 755
		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x8")]
		public int vertexCount;

		// Token: 0x040002F4 RID: 756
		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x10")]
		public Vector3[] vertices;

		// Token: 0x040002F5 RID: 757
		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x18")]
		public Vector3[] normals;

		// Token: 0x040002F6 RID: 758
		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x20")]
		public Vector4[] tangents;

		// Token: 0x040002F7 RID: 759
		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0x28")]
		public Vector2[] uvs0;

		// Token: 0x040002F8 RID: 760
		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0x30")]
		public Vector2[] uvs2;

		// Token: 0x040002F9 RID: 761
		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0x38")]
		public Color32[] colors32;

		// Token: 0x040002FA RID: 762
		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0x40")]
		public int[] triangles;

		// Token: 0x040002FB RID: 763
		[Token(Token = "0x40002FB")]
		[FieldOffset(Offset = "0x48")]
		public Material material;
	}
}
