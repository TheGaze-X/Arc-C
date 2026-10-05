using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Spine.Unity.AttachmentTools
{
	// Token: 0x020000CE RID: 206
	[Token(Token = "0x20000CE")]
	public static class SkinUtilities
	{
		// Token: 0x06000764 RID: 1892 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000764")]
		[Address(RVA = "0x4EA82A0", Offset = "0x4EA6EA0", VA = "0x184EA82A0")]
		public static Skin UnshareSkin(this Skeleton skeleton, bool includeDefaultSkin, bool unshareAttachments, [Optional] AnimationState state)
		{
			return null;
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000765")]
		[Address(RVA = "0x4EA7FD0", Offset = "0x4EA6BD0", VA = "0x184EA7FD0")]
		public static Skin GetClonedSkin(this Skeleton skeleton, string newSkinName, bool includeDefaultSkin = false, bool cloneAttachments = false, bool cloneMeshesAsLinked = true)
		{
			return null;
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000766")]
		[Address(RVA = "0x4EA7CA0", Offset = "0x4EA68A0", VA = "0x184EA7CA0")]
		public static Skin GetClone(this Skin original)
		{
			return null;
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000767")]
		[Address(RVA = "0x4EA8190", Offset = "0x4EA6D90", VA = "0x184EA8190")]
		public static void SetAttachment(this Skin skin, string slotName, string keyName, Attachment attachment, Skeleton skeleton)
		{
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000768")]
		[Address(RVA = "0x4EA6F20", Offset = "0x4EA5B20", VA = "0x184EA6F20")]
		public static void AddAttachments(this Skin skin, Skin otherSkin)
		{
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000769")]
		[Address(RVA = "0x4EA7BD0", Offset = "0x4EA67D0", VA = "0x184EA7BD0")]
		public static Attachment GetAttachment(this Skin skin, string slotName, string keyName, Skeleton skeleton)
		{
			return null;
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600076A")]
		[Address(RVA = "0x4EA8270", Offset = "0x4EA6E70", VA = "0x184EA8270")]
		public static void SetAttachment(this Skin skin, int slotIndex, string keyName, Attachment attachment)
		{
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600076B")]
		[Address(RVA = "0x4EA80C0", Offset = "0x4EA6CC0", VA = "0x184EA80C0")]
		public static void RemoveAttachment(this Skin skin, string slotName, string keyName, SkeletonData skeletonData)
		{
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600076C")]
		[Address(RVA = "0x4EA6F80", Offset = "0x4EA5B80", VA = "0x184EA6F80")]
		public static void Clear(this Skin skin)
		{
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600076D")]
		[Address(RVA = "0x4EA6F50", Offset = "0x4EA5B50", VA = "0x184EA6F50")]
		public static void Append(this Skin destination, Skin source)
		{
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600076E")]
		[Address(RVA = "0x4EA6FD0", Offset = "0x4EA5BD0", VA = "0x184EA6FD0")]
		public static void CopyTo(this Skin source, Skin destination, bool overwrite, bool cloneAttachments, bool cloneMeshesAsLinked = true)
		{
		}
	}
}
