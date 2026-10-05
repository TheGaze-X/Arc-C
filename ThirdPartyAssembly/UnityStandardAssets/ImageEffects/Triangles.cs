using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200006C RID: 108
	[Token(Token = "0x200006C")]
	internal class Triangles
	{
		// Token: 0x06000265 RID: 613 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x5301780", Offset = "0x5300380", VA = "0x185301780")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x5300F40", Offset = "0x52FFB40", VA = "0x185300F40")]
		private static void Cleanup()
		{
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x5301470", Offset = "0x5300070", VA = "0x185301470")]
		private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x53010D0", Offset = "0x52FFCD0", VA = "0x1853010D0")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Triangles()
		{
		}

		// Token: 0x040002D1 RID: 721
		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		// Token: 0x040002D2 RID: 722
		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0x8")]
		private static int currentTris;
	}
}
