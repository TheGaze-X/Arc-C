using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200008D RID: 141
	[Token(Token = "0x200008D")]
	internal static class MeshUtilities
	{
		// Token: 0x06000207 RID: 519 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x58310A0", Offset = "0x582FCA0", VA = "0x1858310A0")]
		internal static Mesh GetColliderMesh(Collider collider)
		{
			return null;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x58313F0", Offset = "0x582FFF0", VA = "0x1858313F0")]
		internal static Mesh GetPrimitive(PrimitiveType primitiveType)
		{
			return null;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x5831000", Offset = "0x582FC00", VA = "0x185831000")]
		private static Mesh GetBuiltinMesh(PrimitiveType primitiveType)
		{
			return null;
		}

		// Token: 0x040002BD RID: 701
		[Token(Token = "0x40002BD")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<PrimitiveType, Mesh> s_Primitives;

		// Token: 0x040002BE RID: 702
		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<Type, PrimitiveType> s_ColliderPrimitives;
	}
}
