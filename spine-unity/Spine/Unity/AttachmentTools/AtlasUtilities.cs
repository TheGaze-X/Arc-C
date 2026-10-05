using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity.AttachmentTools
{
	// Token: 0x020000CA RID: 202
	[Token(Token = "0x20000CA")]
	public static class AtlasUtilities
	{
		// Token: 0x06000729 RID: 1833 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x4EA2B50", Offset = "0x4EA1750", VA = "0x184EA2B50")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void Init()
		{
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600072A")]
		[Address(RVA = "0x4EA3B90", Offset = "0x4EA2790", VA = "0x184EA3B90")]
		public static AtlasRegion ToAtlasRegion(this Texture2D t, Material materialPropertySource, float scale = 0.01f)
		{
			return null;
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x4EA3350", Offset = "0x4EA1F50", VA = "0x184EA3350")]
		public static AtlasRegion ToAtlasRegion(this Texture2D t, Shader shader, float scale = 0.01f, [Optional] Material materialPropertySource)
		{
			return null;
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600072C")]
		[Address(RVA = "0x4EA2DE0", Offset = "0x4EA19E0", VA = "0x184EA2DE0")]
		public static AtlasRegion ToAtlasRegionPMAClone(this Texture2D t, Material materialPropertySource, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false)
		{
			return null;
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600072D")]
		[Address(RVA = "0x4EA3140", Offset = "0x4EA1D40", VA = "0x184EA3140")]
		public static AtlasRegion ToAtlasRegionPMAClone(this Texture2D t, Shader shader, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false, [Optional] Material materialPropertySource)
		{
			return null;
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600072E")]
		[Address(RVA = "0x4EA3C30", Offset = "0x4EA2830", VA = "0x184EA3C30")]
		public static AtlasPage ToSpineAtlasPage(this Material m)
		{
			return null;
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600072F")]
		[Address(RVA = "0x4EA36A0", Offset = "0x4EA22A0", VA = "0x184EA36A0")]
		public static AtlasRegion ToAtlasRegion(this Sprite s, AtlasPage page)
		{
			return null;
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000730")]
		[Address(RVA = "0x4EA3610", Offset = "0x4EA2210", VA = "0x184EA3610")]
		public static AtlasRegion ToAtlasRegion(this Sprite s, Material material)
		{
			return null;
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000731")]
		[Address(RVA = "0x4EA3090", Offset = "0x4EA1C90", VA = "0x184EA3090")]
		public static AtlasRegion ToAtlasRegionPMAClone(this Sprite s, Material materialPropertySource, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false)
		{
			return null;
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000732")]
		[Address(RVA = "0x4EA2E90", Offset = "0x4EA1A90", VA = "0x184EA2E90")]
		public static AtlasRegion ToAtlasRegionPMAClone(this Sprite s, Shader shader, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false, [Optional] Material materialPropertySource)
		{
			return null;
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000733")]
		[Address(RVA = "0x4EA3790", Offset = "0x4EA2390", VA = "0x184EA3790")]
		internal static AtlasRegion ToAtlasRegion(this Sprite s, bool isolatedTexture = false)
		{
			return null;
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000734")]
		[Address(RVA = "0x4EA0730", Offset = "0x4E9F330", VA = "0x184EA0730")]
		public static void GetRepackedAttachments(List<Attachment> sourceAttachments, List<Attachment> outputAttachments, Material materialPropertySource, out Material outputMaterial, out Texture2D outputTexture, int maxAtlasSize = 1024, int padding = 2, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false, string newAssetName = "Repacked Attachments", bool clearCache = false, bool useOriginalNonrenderables = true)
		{
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000735")]
		[Address(RVA = "0x4EA1260", Offset = "0x4E9FE60", VA = "0x184EA1260")]
		public static Skin GetRepackedSkin(this Skin o, string newName, Material materialPropertySource, out Material outputMaterial, out Texture2D outputTexture, int maxAtlasSize = 1024, int padding = 2, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false, bool useOriginalNonrenderables = true, bool clearCache = false, [Optional] int[] additionalTexturePropertyIDsToCopy, [Optional] Texture2D[] additionalOutputTextures, [Optional] TextureFormat[] additionalTextureFormats, [Optional] bool[] additionalTextureIsLinear)
		{
			return null;
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000736")]
		[Address(RVA = "0x4EA13B0", Offset = "0x4E9FFB0", VA = "0x184EA13B0")]
		public static Skin GetRepackedSkin(this Skin o, string newName, Shader shader, out Material outputMaterial, out Texture2D outputTexture, int maxAtlasSize = 1024, int padding = 2, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false, [Optional] Material materialPropertySource, bool clearCache = false, bool useOriginalNonrenderables = true, [Optional] int[] additionalTexturePropertyIDsToCopy, [Optional] Texture2D[] additionalOutputTextures, [Optional] TextureFormat[] additionalTextureFormats, [Optional] bool[] additionalTextureIsLinear)
		{
			return null;
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x4EA3D60", Offset = "0x4EA2960", VA = "0x184EA3D60")]
		public static Sprite ToSprite(this AtlasRegion ar, float pixelsPerUnit = 100f)
		{
			return null;
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000738")]
		[Address(RVA = "0x4E9FD10", Offset = "0x4E9E910", VA = "0x184E9FD10")]
		public static void ClearCache()
		{
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000739")]
		[Address(RVA = "0x4EA42E0", Offset = "0x4EA2EE0", VA = "0x184EA42E0")]
		public static Texture2D ToTexture(this AtlasRegion ar, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false, int texturePropertyId = 0, bool linear = false, bool applyPMA = false)
		{
			return null;
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600073A")]
		[Address(RVA = "0x4EA3E20", Offset = "0x4EA2A20", VA = "0x184EA3E20")]
		private static Texture2D ToTexture(this Sprite s, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false, bool linear = false, bool applyPMA = false)
		{
			return null;
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600073B")]
		[Address(RVA = "0x4EA02C0", Offset = "0x4E9EEC0", VA = "0x184EA02C0")]
		private static Texture2D GetClone(this Texture2D t, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false, bool linear = false, bool applyPMA = false)
		{
			return null;
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600073C")]
		[Address(RVA = "0x4EA0100", Offset = "0x4E9ED00", VA = "0x184EA0100")]
		private static void CopyTexture(Texture2D source, Rect sourceRect, Texture2D destination)
		{
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600073D")]
		[Address(RVA = "0x4E9FF00", Offset = "0x4E9EB00", VA = "0x184E9FF00")]
		private static void CopyTextureApplyPMA(Texture2D source, Rect sourceRect, Texture2D destination)
		{
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x000048D4 File Offset: 0x00002AD4
		[Token(Token = "0x600073E")]
		[Address(RVA = "0x4EA2BA0", Offset = "0x4EA17A0", VA = "0x184EA2BA0")]
		private static bool IsRenderable(Attachment a)
		{
			return default(bool);
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x000048EC File Offset: 0x00002AEC
		[Token(Token = "0x600073F")]
		[Address(RVA = "0x4EA2BE0", Offset = "0x4EA17E0", VA = "0x184EA2BE0")]
		private static Rect SpineUnityFlipRect(this Rect rect, int textureHeight)
		{
			return default(Rect);
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00004904 File Offset: 0x00002B04
		[Token(Token = "0x6000740")]
		[Address(RVA = "0x4EA2A30", Offset = "0x4EA1630", VA = "0x184EA2A30")]
		private static Rect GetUnityRect(this AtlasRegion region)
		{
			return default(Rect);
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x0000491C File Offset: 0x00002B1C
		[Token(Token = "0x6000741")]
		[Address(RVA = "0x4EA2910", Offset = "0x4EA1510", VA = "0x184EA2910")]
		private static Rect GetUnityRect(this AtlasRegion region, int textureHeight)
		{
			return default(Rect);
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00004934 File Offset: 0x00002B34
		[Token(Token = "0x6000742")]
		[Address(RVA = "0x4EA2600", Offset = "0x4EA1200", VA = "0x184EA2600")]
		private static Rect GetSpineAtlasRect(this AtlasRegion region, bool includeRotate = true)
		{
			return default(Rect);
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x0000494C File Offset: 0x00002B4C
		[Token(Token = "0x6000743")]
		[Address(RVA = "0x4EA4CE0", Offset = "0x4EA38E0", VA = "0x184EA4CE0")]
		private static Rect UVRectToTextureRect(Rect uvRect, int texWidth, int texHeight)
		{
			return default(Rect);
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00004964 File Offset: 0x00002B64
		[Token(Token = "0x6000744")]
		[Address(RVA = "0x4EA2C50", Offset = "0x4EA1850", VA = "0x184EA2C50")]
		private static Rect TextureRectToUVRect(Rect textureRect, int texWidth, int texHeight)
		{
			return default(Rect);
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000745")]
		[Address(RVA = "0x4EA4900", Offset = "0x4EA3500", VA = "0x184EA4900")]
		private static AtlasRegion UVRectToAtlasRegion(Rect uvRect, AtlasRegion referenceRegion, AtlasPage page)
		{
			return null;
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000746")]
		[Address(RVA = "0x4EA0600", Offset = "0x4E9F200", VA = "0x184EA0600")]
		private static Texture2D GetMainTexture(this AtlasRegion region)
		{
			return null;
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000747")]
		[Address(RVA = "0x4EA27D0", Offset = "0x4EA13D0", VA = "0x184EA27D0")]
		private static Texture2D GetTexture(this AtlasRegion region, string texturePropertyName)
		{
			return null;
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000748")]
		[Address(RVA = "0x4EA2690", Offset = "0x4EA1290", VA = "0x184EA2690")]
		private static Texture2D GetTexture(this AtlasRegion region, int texturePropertyId)
		{
			return null;
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000749")]
		[Address(RVA = "0x4EA0050", Offset = "0x4E9EC50", VA = "0x184EA0050")]
		private static void CopyTextureAttributesFrom(this Texture2D destination, Texture2D source)
		{
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x0000497C File Offset: 0x00002B7C
		[Token(Token = "0x600074A")]
		[Address(RVA = "0x4EA2B90", Offset = "0x4EA1790", VA = "0x184EA2B90")]
		private static float InverseLerp(float a, float b, float value)
		{
			return 0f;
		}

		// Token: 0x04000472 RID: 1138
		[Token(Token = "0x4000472")]
		internal const TextureFormat SpineTextureFormat = TextureFormat.RGBA32;

		// Token: 0x04000473 RID: 1139
		[Token(Token = "0x4000473")]
		internal const float DefaultMipmapBias = -0.5f;

		// Token: 0x04000474 RID: 1140
		[Token(Token = "0x4000474")]
		internal const bool UseMipMaps = false;

		// Token: 0x04000475 RID: 1141
		[Token(Token = "0x4000475")]
		internal const float DefaultScale = 0.01f;

		// Token: 0x04000476 RID: 1142
		[Token(Token = "0x4000476")]
		private const int NonrenderingRegion = -1;

		// Token: 0x04000477 RID: 1143
		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<AtlasRegion, int> existingRegions;

		// Token: 0x04000478 RID: 1144
		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly List<int> regionIndices;

		// Token: 0x04000479 RID: 1145
		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly List<Texture2D> texturesToPack;

		// Token: 0x0400047A RID: 1146
		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly List<AtlasRegion> originalRegions;

		// Token: 0x0400047B RID: 1147
		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly List<AtlasRegion> repackedRegions;

		// Token: 0x0400047C RID: 1148
		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly List<Attachment> repackedAttachments;

		// Token: 0x0400047D RID: 1149
		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static List<Texture2D>[] texturesToPackAtParam;

		// Token: 0x0400047E RID: 1150
		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static Dictionary<AtlasUtilities.IntAndAtlasRegionKey, Texture2D> CachedRegionTextures;

		// Token: 0x0400047F RID: 1151
		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static List<Texture2D> CachedRegionTexturesList;

		// Token: 0x020000CB RID: 203
		[Token(Token = "0x20000CB")]
		private struct IntAndAtlasRegionKey
		{
			// Token: 0x0600074C RID: 1868 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x600074C")]
			[Address(RVA = "0x5159D0", Offset = "0x5145D0", VA = "0x1805159D0")]
			public IntAndAtlasRegionKey(int i, AtlasRegion region)
			{
			}

			// Token: 0x0600074D RID: 1869 RVA: 0x00004994 File Offset: 0x00002B94
			[Token(Token = "0x600074D")]
			[Address(RVA = "0x4EA6E80", Offset = "0x4EA5A80", VA = "0x184EA6E80", Slot = "2")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x04000480 RID: 1152
			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int i;

			// Token: 0x04000481 RID: 1153
			[Token(Token = "0x4000481")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private AtlasRegion region;
		}
	}
}
