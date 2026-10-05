using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	internal struct MaterialReference
	{
		// Token: 0x0600008D RID: 141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x59F43A0", Offset = "0x59F2FA0", VA = "0x1859F43A0")]
		public MaterialReference(int index, FontAsset fontAsset, SpriteAsset spriteAsset, Material material, float padding)
		{
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x59F3EF0", Offset = "0x59F2AF0", VA = "0x1859F3EF0")]
		public static int AddMaterialReference(Material material, FontAsset fontAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup)
		{
			return 0;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x59F4150", Offset = "0x59F2D50", VA = "0x1859F4150")]
		public static int AddMaterialReference(Material material, SpriteAsset spriteAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup)
		{
			return 0;
		}

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x0")]
		public int index;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x8")]
		public FontAsset fontAsset;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x10")]
		public SpriteAsset spriteAsset;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x18")]
		public Material material;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x20")]
		public bool isDefaultMaterial;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x21")]
		public bool isFallbackMaterial;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x28")]
		public Material fallbackMaterial;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x30")]
		public float padding;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x34")]
		public int referenceCount;
	}
}
