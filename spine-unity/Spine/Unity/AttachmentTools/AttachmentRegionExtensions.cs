using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity.AttachmentTools
{
	// Token: 0x020000CD RID: 205
	[Token(Token = "0x20000CD")]
	public static class AttachmentRegionExtensions
	{
		// Token: 0x06000754 RID: 1876 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x4EA5CF0", Offset = "0x4EA48F0", VA = "0x184EA5CF0")]
		public static AtlasRegion GetRegion(this Attachment attachment)
		{
			return null;
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000755")]
		[Address(RVA = "0x4EA5F00", Offset = "0x4EA4B00", VA = "0x184EA5F00")]
		public static AtlasRegion GetRegion(this RegionAttachment regionAttachment)
		{
			return null;
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000756")]
		[Address(RVA = "0x4EA5E40", Offset = "0x4EA4A40", VA = "0x184EA5E40")]
		public static AtlasRegion GetRegion(this MeshAttachment meshAttachment)
		{
			return null;
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x4EA6010", Offset = "0x4EA4C10", VA = "0x184EA6010")]
		public static void SetRegion(this Attachment attachment, AtlasRegion region, bool updateOffset = true)
		{
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000758")]
		[Address(RVA = "0x4EA6430", Offset = "0x4EA5030", VA = "0x184EA6430")]
		public static void SetRegion(this RegionAttachment attachment, AtlasRegion region, bool updateOffset = true)
		{
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000759")]
		[Address(RVA = "0x4EA6300", Offset = "0x4EA4F00", VA = "0x184EA6300")]
		public static void SetRegion(this MeshAttachment attachment, AtlasRegion region, bool updateUVs = true)
		{
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x4EA6E00", Offset = "0x4EA5A00", VA = "0x184EA6E00")]
		public static RegionAttachment ToRegionAttachment(this Sprite sprite, Material material, float rotation = 0f)
		{
			return null;
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600075B")]
		[Address(RVA = "0x4EA69B0", Offset = "0x4EA55B0", VA = "0x184EA69B0")]
		public static RegionAttachment ToRegionAttachment(this Sprite sprite, AtlasPage page, float rotation = 0f)
		{
			return null;
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600075C")]
		[Address(RVA = "0x4EA65C0", Offset = "0x4EA51C0", VA = "0x184EA65C0")]
		public static RegionAttachment ToRegionAttachmentPMAClone(this Sprite sprite, Shader shader, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false, [Optional] Material materialPropertySource, float rotation = 0f)
		{
			return null;
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600075D")]
		[Address(RVA = "0x4EA67B0", Offset = "0x4EA53B0", VA = "0x184EA67B0")]
		public static RegionAttachment ToRegionAttachmentPMAClone(this Sprite sprite, Material materialPropertySource, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false, float rotation = 0f)
		{
			return null;
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600075E")]
		[Address(RVA = "0x4EA6BA0", Offset = "0x4EA57A0", VA = "0x184EA6BA0")]
		public static RegionAttachment ToRegionAttachment(this AtlasRegion region, string attachmentName, float scale = 0.01f, float rotation = 0f)
		{
			return null;
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600075F")]
		[Address(RVA = "0x4EA6590", Offset = "0x4EA5190", VA = "0x184EA6590")]
		public static void SetScale(this RegionAttachment regionAttachment, Vector2 scale)
		{
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000760")]
		[Address(RVA = "0x4EA6570", Offset = "0x4EA5170", VA = "0x184EA6570")]
		public static void SetScale(this RegionAttachment regionAttachment, float x, float y)
		{
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000761")]
		[Address(RVA = "0x4EA5FE0", Offset = "0x4EA4BE0", VA = "0x184EA5FE0")]
		public static void SetPositionOffset(this RegionAttachment regionAttachment, Vector2 offset)
		{
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000762")]
		[Address(RVA = "0x4EA5FC0", Offset = "0x4EA4BC0", VA = "0x184EA5FC0")]
		public static void SetPositionOffset(this RegionAttachment regionAttachment, float x, float y)
		{
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000763")]
		[Address(RVA = "0x4EA6550", Offset = "0x4EA5150", VA = "0x184EA6550")]
		public static void SetRotation(this RegionAttachment regionAttachment, float rotation)
		{
		}
	}
}
