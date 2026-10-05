using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x02000063 RID: 99
	[Token(Token = "0x2000063")]
	public class Triangulator
	{
		// Token: 0x06000474 RID: 1140 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000474")]
		[Address(RVA = "0x4E74A10", Offset = "0x4E73610", VA = "0x184E74A10")]
		public ExposedList<int> Triangulate(ExposedList<float> verticesArray)
		{
			return null;
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000475")]
		[Address(RVA = "0x4E73CC0", Offset = "0x4E728C0", VA = "0x184E73CC0")]
		public ExposedList<ExposedList<float>> Decompose(ExposedList<float> verticesArray, ExposedList<int> triangles)
		{
			return null;
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00003F14 File Offset: 0x00002114
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x4E748B0", Offset = "0x4E734B0", VA = "0x184E748B0")]
		private static bool IsConcave(int index, int vertexCount, float[] vertices, int[] indices)
		{
			return default(bool);
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00003F2C File Offset: 0x0000212C
		[Token(Token = "0x6000477")]
		[Address(RVA = "0x4E749D0", Offset = "0x4E735D0", VA = "0x184E749D0")]
		private static bool PositiveArea(float p1x, float p1y, float p2x, float p2y, float p3x, float p3y)
		{
			return default(bool);
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00003F44 File Offset: 0x00002144
		[Token(Token = "0x6000478")]
		[Address(RVA = "0x4E75070", Offset = "0x4E73C70", VA = "0x184E75070")]
		private static int Winding(float p1x, float p1y, float p2x, float p2y, float p3x, float p3y)
		{
			return 0;
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000479")]
		[Address(RVA = "0x4E750C0", Offset = "0x4E73CC0", VA = "0x184E750C0")]
		public Triangulator()
		{
		}

		// Token: 0x04000295 RID: 661
		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x10")]
		private readonly ExposedList<ExposedList<float>> convexPolygons;

		// Token: 0x04000296 RID: 662
		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x18")]
		private readonly ExposedList<ExposedList<int>> convexPolygonsIndices;

		// Token: 0x04000297 RID: 663
		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x20")]
		private readonly ExposedList<int> indicesArray;

		// Token: 0x04000298 RID: 664
		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x28")]
		private readonly ExposedList<bool> isConcaveArray;

		// Token: 0x04000299 RID: 665
		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x30")]
		private readonly ExposedList<int> triangles;

		// Token: 0x0400029A RID: 666
		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0x38")]
		private readonly Pool<ExposedList<float>> polygonPool;

		// Token: 0x0400029B RID: 667
		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x40")]
		private readonly Pool<ExposedList<int>> polygonIndicesPool;
	}
}
