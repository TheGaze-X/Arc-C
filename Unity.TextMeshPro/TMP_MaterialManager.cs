using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x02000066 RID: 102
	[Token(Token = "0x2000066")]
	public static class TMP_MaterialManager
	{
		// Token: 0x0600038D RID: 909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x58C6790", Offset = "0x58C5390", VA = "0x1858C6790")]
		private static void OnPreRender()
		{
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x58C63B0", Offset = "0x58C4FB0", VA = "0x1858C63B0")]
		public static Material GetStencilMaterial(Material baseMaterial, int stencilID)
		{
			return null;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038F")]
		[Address(RVA = "0x58C7090", Offset = "0x58C5C90", VA = "0x1858C7090")]
		public static void ReleaseStencilMaterial(Material stencilMaterial)
		{
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x58C53F0", Offset = "0x58C3FF0", VA = "0x1858C53F0")]
		public static Material GetBaseMaterial(Material stencilMaterial)
		{
			return null;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x58C7650", Offset = "0x58C6250", VA = "0x1858C7650")]
		public static Material SetStencil(Material material, int stencilID)
		{
			return null;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x58C48D0", Offset = "0x58C34D0", VA = "0x1858C48D0")]
		public static void AddMaskingMaterial(Material baseMaterial, Material stencilMaterial, int stencilID)
		{
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x58C74F0", Offset = "0x58C60F0", VA = "0x1858C74F0")]
		public static void RemoveStencilMaterial(Material stencilMaterial)
		{
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x58C6810", Offset = "0x58C5410", VA = "0x1858C6810")]
		public static void ReleaseBaseMaterial(Material baseMaterial)
		{
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x58C4DB0", Offset = "0x58C39B0", VA = "0x1858C4DB0")]
		public static void ClearMaterials()
		{
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00003438 File Offset: 0x00001638
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x58C5FC0", Offset = "0x58C4BC0", VA = "0x1858C5FC0")]
		public static int GetStencilID(GameObject obj)
		{
			return 0;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x58C5D90", Offset = "0x58C4990", VA = "0x1858C5D90")]
		public static Material GetMaterialForRendering(MaskableGraphic graphic, Material baseMaterial)
		{
			return null;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x58C5270", Offset = "0x58C3E70", VA = "0x1858C5270")]
		private static Transform FindRootSortOverrideCanvas(Transform start)
		{
			return null;
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x58C5A50", Offset = "0x58C4650", VA = "0x1858C5A50")]
		internal static Material GetFallbackMaterial(TMP_FontAsset fontAsset, Material sourceMaterial, int atlasIndex)
		{
			return null;
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x58C5570", Offset = "0x58C4170", VA = "0x1858C5570")]
		public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial)
		{
			return null;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x58C4790", Offset = "0x58C3390", VA = "0x1858C4790")]
		public static void AddFallbackMaterialReference(Material targetMaterial)
		{
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x58C72F0", Offset = "0x58C5EF0", VA = "0x1858C72F0")]
		public static void RemoveFallbackMaterialReference(Material targetMaterial)
		{
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x58C4B50", Offset = "0x58C3750", VA = "0x1858C4B50")]
		public static void CleanupFallbackMaterials()
		{
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x58C6E60", Offset = "0x58C5A60", VA = "0x1858C6E60")]
		public static void ReleaseFallbackMaterial(Material fallbackMaterial)
		{
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x58C4FA0", Offset = "0x58C3BA0", VA = "0x1858C4FA0")]
		public static void CopyMaterialPresetProperties(Material source, Material destination)
		{
		}

		// Token: 0x040002D9 RID: 729
		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0x0")]
		private static List<TMP_MaterialManager.MaskingMaterial> m_materialList;

		// Token: 0x040002DA RID: 730
		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<long, TMP_MaterialManager.FallbackMaterial> m_fallbackMaterials;

		// Token: 0x040002DB RID: 731
		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0x10")]
		private static Dictionary<int, long> m_fallbackMaterialLookup;

		// Token: 0x040002DC RID: 732
		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0x18")]
		private static List<TMP_MaterialManager.FallbackMaterial> m_fallbackCleanupList;

		// Token: 0x040002DD RID: 733
		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x20")]
		private static bool isFallbackListDirty;

		// Token: 0x02000067 RID: 103
		[Token(Token = "0x2000067")]
		private class FallbackMaterial
		{
			// Token: 0x060003A0 RID: 928 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FallbackMaterial()
			{
			}

			// Token: 0x040002DE RID: 734
			[Token(Token = "0x40002DE")]
			[FieldOffset(Offset = "0x10")]
			public long fallbackID;

			// Token: 0x040002DF RID: 735
			[Token(Token = "0x40002DF")]
			[FieldOffset(Offset = "0x18")]
			public Material sourceMaterial;

			// Token: 0x040002E0 RID: 736
			[Token(Token = "0x40002E0")]
			[FieldOffset(Offset = "0x20")]
			internal int sourceMaterialCRC;

			// Token: 0x040002E1 RID: 737
			[Token(Token = "0x40002E1")]
			[FieldOffset(Offset = "0x28")]
			public Material fallbackMaterial;

			// Token: 0x040002E2 RID: 738
			[Token(Token = "0x40002E2")]
			[FieldOffset(Offset = "0x30")]
			public int count;
		}

		// Token: 0x02000068 RID: 104
		[Token(Token = "0x2000068")]
		private class MaskingMaterial
		{
			// Token: 0x060003A1 RID: 929 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003A1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MaskingMaterial()
			{
			}

			// Token: 0x040002E3 RID: 739
			[Token(Token = "0x40002E3")]
			[FieldOffset(Offset = "0x10")]
			public Material baseMaterial;

			// Token: 0x040002E4 RID: 740
			[Token(Token = "0x40002E4")]
			[FieldOffset(Offset = "0x18")]
			public Material stencilMaterial;

			// Token: 0x040002E5 RID: 741
			[Token(Token = "0x40002E5")]
			[FieldOffset(Offset = "0x20")]
			public int count;

			// Token: 0x040002E6 RID: 742
			[Token(Token = "0x40002E6")]
			[FieldOffset(Offset = "0x24")]
			public int stencilID;
		}
	}
}
