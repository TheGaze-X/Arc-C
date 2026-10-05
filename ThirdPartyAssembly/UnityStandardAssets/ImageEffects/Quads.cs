using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200005C RID: 92
	[Token(Token = "0x200005C")]
	internal class Quads
	{
		// Token: 0x06000243 RID: 579 RVA: 0x000028F8 File Offset: 0x00000AF8
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x52FC1B0", Offset = "0x52FADB0", VA = "0x1852FC1B0")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x52FB8E0", Offset = "0x52FA4E0", VA = "0x1852FB8E0")]
		public static void Cleanup()
		{
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x52FBEC0", Offset = "0x52FAAC0", VA = "0x1852FBEC0")]
		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x52FBA70", Offset = "0x52FA670", VA = "0x1852FBA70")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Quads()
		{
		}

		// Token: 0x0400026C RID: 620
		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		// Token: 0x0400026D RID: 621
		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x8")]
		private static int currentQuads;
	}
}
