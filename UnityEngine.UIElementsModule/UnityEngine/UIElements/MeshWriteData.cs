using System;
using Il2CppDummyDll;
using Unity.Collections;

namespace UnityEngine.UIElements
{
	// Token: 0x02000209 RID: 521
	[Token(Token = "0x2000209")]
	public class MeshWriteData
	{
		// Token: 0x06000DDE RID: 3550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal MeshWriteData()
		{
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000DDF RID: 3551 RVA: 0x00006D98 File Offset: 0x00004F98
		[Token(Token = "0x17000332")]
		public int vertexCount
		{
			[Token(Token = "0x6000DDF")]
			[Address(RVA = "0x5B0C420", Offset = "0x5B0B020", VA = "0x185B0C420")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000DE0 RID: 3552 RVA: 0x00006DB0 File Offset: 0x00004FB0
		[Token(Token = "0x17000333")]
		public int indexCount
		{
			[Token(Token = "0x6000DE0")]
			[Address(RVA = "0x5B0C3E0", Offset = "0x5B0AFE0", VA = "0x185B0C3E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000DE1 RID: 3553 RVA: 0x00006DC8 File Offset: 0x00004FC8
		[Token(Token = "0x17000334")]
		public Rect uvRegion
		{
			[Token(Token = "0x6000DE1")]
			[Address(RVA = "0x597E590", Offset = "0x597D190", VA = "0x18597E590")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE2")]
		[Address(RVA = "0x5B0C350", Offset = "0x5B0AF50", VA = "0x185B0C350")]
		public void SetNextVertex(Vertex vertex)
		{
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE3")]
		[Address(RVA = "0x5B0C2F0", Offset = "0x5B0AEF0", VA = "0x185B0C2F0")]
		public void SetNextIndex(ushort index)
		{
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE4")]
		[Address(RVA = "0x5B0C220", Offset = "0x5B0AE20", VA = "0x185B0C220")]
		public void SetAllVertices(Vertex[] vertices)
		{
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE5")]
		[Address(RVA = "0x5B0C150", Offset = "0x5B0AD50", VA = "0x185B0C150")]
		public void SetAllIndices(ushort[] indices)
		{
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE6")]
		[Address(RVA = "0x5B0C0D0", Offset = "0x5B0ACD0", VA = "0x185B0C0D0")]
		internal void Reset(NativeSlice<Vertex> vertices, NativeSlice<ushort> indices)
		{
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE7")]
		[Address(RVA = "0x5B0C130", Offset = "0x5B0AD30", VA = "0x185B0C130")]
		internal void Reset(NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, Rect uvRegion)
		{
		}

		// Token: 0x04000739 RID: 1849
		[Token(Token = "0x4000739")]
		[FieldOffset(Offset = "0x10")]
		internal NativeSlice<Vertex> m_Vertices;

		// Token: 0x0400073A RID: 1850
		[Token(Token = "0x400073A")]
		[FieldOffset(Offset = "0x20")]
		internal NativeSlice<ushort> m_Indices;

		// Token: 0x0400073B RID: 1851
		[Token(Token = "0x400073B")]
		[FieldOffset(Offset = "0x30")]
		internal Rect m_UVRegion;

		// Token: 0x0400073C RID: 1852
		[Token(Token = "0x400073C")]
		[FieldOffset(Offset = "0x40")]
		internal int currentIndex;

		// Token: 0x0400073D RID: 1853
		[Token(Token = "0x400073D")]
		[FieldOffset(Offset = "0x44")]
		internal int currentVertex;
	}
}
