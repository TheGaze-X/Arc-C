using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x0200054E RID: 1358
	[Token(Token = "0x200054E")]
	public class EasyMeshGenerator
	{
		// Token: 0x06005AA6 RID: 23206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AA6")]
		[Address(RVA = "0x1AEE4F0", Offset = "0x1AED0F0", VA = "0x181AEE4F0")]
		public void Begin()
		{
		}

		// Token: 0x06005AA7 RID: 23207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AA7")]
		[Address(RVA = "0x1AEE050", Offset = "0x1AECC50", VA = "0x181AEE050")]
		public void AddSquare(Bounds bounds)
		{
		}

		// Token: 0x06005AA8 RID: 23208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AA8")]
		[Address(RVA = "0x1AEDFA0", Offset = "0x1AECBA0", VA = "0x181AEDFA0")]
		public void AddSquare(Bounds bounds, Rect uvBounds)
		{
		}

		// Token: 0x06005AA9 RID: 23209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AA9")]
		[Address(RVA = "0x1AEE120", Offset = "0x1AECD20", VA = "0x181AEE120")]
		public void AddSquare(Bounds bounds, Color color)
		{
		}

		// Token: 0x06005AAA RID: 23210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AAA")]
		[Address(RVA = "0x1AEDCF0", Offset = "0x1AEC8F0", VA = "0x181AEDCF0")]
		public void AddSquare(Bounds bounds, Rect uvBounds, Color color)
		{
		}

		// Token: 0x06005AAB RID: 23211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AAB")]
		[Address(RVA = "0x1AEE310", Offset = "0x1AECF10", VA = "0x181AEE310")]
		public void AddVertex(Vector3 vertex, Vector2 uv, Color color)
		{
		}

		// Token: 0x06005AAC RID: 23212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AAC")]
		[Address(RVA = "0x1AEE1B0", Offset = "0x1AECDB0", VA = "0x181AEE1B0")]
		public void AddTriangle(int a, int b, int c)
		{
		}

		// Token: 0x06005AAD RID: 23213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AAD")]
		[Address(RVA = "0x1AEE590", Offset = "0x1AED190", VA = "0x181AEE590")]
		public Mesh Generate()
		{
			return null;
		}

		// Token: 0x06005AAE RID: 23214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AAE")]
		[Address(RVA = "0x1AEE4F0", Offset = "0x1AED0F0", VA = "0x181AEE4F0")]
		private void _ClearAll()
		{
		}

		// Token: 0x06005AAF RID: 23215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AAF")]
		[Address(RVA = "0x1AEE6A0", Offset = "0x1AED2A0", VA = "0x181AEE6A0")]
		public EasyMeshGenerator()
		{
		}

		// Token: 0x04002064 RID: 8292
		[Token(Token = "0x4002064")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color DEFAULT_COLOR;

		// Token: 0x04002065 RID: 8293
		[Token(Token = "0x4002065")]
		[FieldOffset(Offset = "0x10")]
		private List<Vector3> m_vertices;

		// Token: 0x04002066 RID: 8294
		[Token(Token = "0x4002066")]
		[FieldOffset(Offset = "0x18")]
		private List<Vector2> m_uvs;

		// Token: 0x04002067 RID: 8295
		[Token(Token = "0x4002067")]
		[FieldOffset(Offset = "0x20")]
		private List<Color> m_colors;

		// Token: 0x04002068 RID: 8296
		[Token(Token = "0x4002068")]
		[FieldOffset(Offset = "0x28")]
		private List<int> m_indices;
	}
}
