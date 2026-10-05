using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	public struct MaterialReference
	{
		// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x586BA60", Offset = "0x586A660", VA = "0x18586BA60")]
		public MaterialReference(int index, TMP_FontAsset fontAsset, TMP_SpriteAsset spriteAsset, Material material, float padding)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002148 File Offset: 0x00000348
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x586B970", Offset = "0x586A570", VA = "0x18586B970")]
		public static bool Contains(MaterialReference[] materialReferences, TMP_FontAsset fontAsset)
		{
			return default(bool);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x586B710", Offset = "0x586A310", VA = "0x18586B710")]
		public static int AddMaterialReference(Material material, TMP_FontAsset fontAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup)
		{
			return 0;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x586B4C0", Offset = "0x586A0C0", VA = "0x18586B4C0")]
		public static int AddMaterialReference(Material material, TMP_SpriteAsset spriteAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup)
		{
			return 0;
		}

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x0")]
		public int index;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x8")]
		public TMP_FontAsset fontAsset;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x10")]
		public TMP_SpriteAsset spriteAsset;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x18")]
		public Material material;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x20")]
		public bool isDefaultMaterial;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x21")]
		public bool isFallbackMaterial;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x28")]
		public Material fallbackMaterial;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x30")]
		public float padding;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x34")]
		public int referenceCount;
	}
}
