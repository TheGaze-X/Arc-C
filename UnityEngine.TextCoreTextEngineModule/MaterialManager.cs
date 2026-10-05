using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	internal static class MaterialManager
	{
		// Token: 0x0600008A RID: 138 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x59F2A80", Offset = "0x59F1680", VA = "0x1859F2A80")]
		public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial)
		{
			return null;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x59F2E60", Offset = "0x59F1A60", VA = "0x1859F2E60")]
		public static Material GetFallbackMaterial(FontAsset fontAsset, Material sourceMaterial, int atlasIndex)
		{
			return null;
		}

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<long, Material> s_FallbackMaterials;
	}
}
