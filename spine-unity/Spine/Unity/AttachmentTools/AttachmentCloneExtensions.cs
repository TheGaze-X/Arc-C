using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity.AttachmentTools
{
	// Token: 0x020000CC RID: 204
	[Token(Token = "0x20000CC")]
	public static class AttachmentCloneExtensions
	{
		// Token: 0x0600074E RID: 1870 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x4EA5150", Offset = "0x4EA3D50", VA = "0x184EA5150")]
		public static Attachment GetCopy(this Attachment o, bool cloneMeshesAsLinked)
		{
			return null;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600074F")]
		[Address(RVA = "0x4EA54D0", Offset = "0x4EA40D0", VA = "0x184EA54D0")]
		public static MeshAttachment GetLinkedMesh(this MeshAttachment o, string newLinkedMeshName, AtlasRegion region)
		{
			return null;
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x4EA5290", Offset = "0x4EA3E90", VA = "0x184EA5290")]
		public static MeshAttachment GetLinkedMesh(this MeshAttachment o, Sprite sprite, Shader shader, [Optional] Material materialPropertySource)
		{
			return null;
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x4EA5230", Offset = "0x4EA3E30", VA = "0x184EA5230")]
		public static MeshAttachment GetLinkedMesh(this MeshAttachment o, Sprite sprite, Material materialPropertySource)
		{
			return null;
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000752")]
		[Address(RVA = "0x4EA5A00", Offset = "0x4EA4600", VA = "0x184EA5A00")]
		public static Attachment GetRemappedClone(this Attachment o, Sprite sprite, Material sourceMaterial, bool premultiplyAlpha = true, bool cloneMeshAsLinked = true, bool useOriginalRegionSize = false, bool pivotShiftsMeshUVCoords = true, bool useOriginalRegionScale = false)
		{
			return null;
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x4EA55F0", Offset = "0x4EA41F0", VA = "0x184EA55F0")]
		public static Attachment GetRemappedClone(this Attachment o, AtlasRegion atlasRegion, bool cloneMeshAsLinked = true, bool useOriginalRegionSize = false, float scale = 0.01f)
		{
			return null;
		}
	}
}
