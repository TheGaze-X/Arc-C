using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity
{
	// Token: 0x0200008F RID: 143
	[Token(Token = "0x200008F")]
	[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonGraphicCustomMaterials")]
	[ExecuteAlways]
	public class SkeletonGraphicCustomMaterials : MonoBehaviour
	{
		// Token: 0x06000618 RID: 1560 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000618")]
		[Address(RVA = "0x4E96C30", Offset = "0x4E95830", VA = "0x184E96C30")]
		private void SetCustomMaterialOverrides()
		{
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000619")]
		[Address(RVA = "0x4E96870", Offset = "0x4E95470", VA = "0x184E96870")]
		private void RemoveCustomMaterialOverrides()
		{
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600061A")]
		[Address(RVA = "0x4E96D80", Offset = "0x4E95980", VA = "0x184E96D80")]
		private void SetCustomTextureOverrides()
		{
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600061B")]
		[Address(RVA = "0x4E96A50", Offset = "0x4E95650", VA = "0x184E96A50")]
		private void RemoveCustomTextureOverrides()
		{
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600061C")]
		[Address(RVA = "0x4E964D0", Offset = "0x4E950D0", VA = "0x184E964D0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600061D")]
		[Address(RVA = "0x4E96410", Offset = "0x4E95010", VA = "0x184E96410")]
		private void OnDisable()
		{
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600061E")]
		[Address(RVA = "0x4E96ED0", Offset = "0x4E95AD0", VA = "0x184E96ED0")]
		public SkeletonGraphicCustomMaterials()
		{
		}

		// Token: 0x040003B6 RID: 950
		[Token(Token = "0x40003B6")]
		[FieldOffset(Offset = "0x18")]
		public SkeletonGraphic skeletonGraphic;

		// Token: 0x040003B7 RID: 951
		[Token(Token = "0x40003B7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected List<SkeletonGraphicCustomMaterials.AtlasMaterialOverride> customMaterialOverrides;

		// Token: 0x040003B8 RID: 952
		[Token(Token = "0x40003B8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected List<SkeletonGraphicCustomMaterials.AtlasTextureOverride> customTextureOverrides;

		// Token: 0x02000090 RID: 144
		[Token(Token = "0x2000090")]
		[Serializable]
		public struct AtlasMaterialOverride : IEquatable<SkeletonGraphicCustomMaterials.AtlasMaterialOverride>
		{
			// Token: 0x0600061F RID: 1567 RVA: 0x00004514 File Offset: 0x00002714
			[Token(Token = "0x600061F")]
			[Address(RVA = "0x4E8D7F0", Offset = "0x4E8C3F0", VA = "0x184E8D7F0", Slot = "4")]
			public bool Equals(SkeletonGraphicCustomMaterials.AtlasMaterialOverride other)
			{
				return default(bool);
			}

			// Token: 0x040003B9 RID: 953
			[Token(Token = "0x40003B9")]
			[FieldOffset(Offset = "0x0")]
			public bool overrideEnabled;

			// Token: 0x040003BA RID: 954
			[Token(Token = "0x40003BA")]
			[FieldOffset(Offset = "0x8")]
			public Texture originalTexture;

			// Token: 0x040003BB RID: 955
			[Token(Token = "0x40003BB")]
			[FieldOffset(Offset = "0x10")]
			public Material replacementMaterial;
		}

		// Token: 0x02000091 RID: 145
		[Token(Token = "0x2000091")]
		[Serializable]
		public struct AtlasTextureOverride : IEquatable<SkeletonGraphicCustomMaterials.AtlasTextureOverride>
		{
			// Token: 0x06000620 RID: 1568 RVA: 0x0000452C File Offset: 0x0000272C
			[Token(Token = "0x6000620")]
			[Address(RVA = "0x4E8D8D0", Offset = "0x4E8C4D0", VA = "0x184E8D8D0", Slot = "4")]
			public bool Equals(SkeletonGraphicCustomMaterials.AtlasTextureOverride other)
			{
				return default(bool);
			}

			// Token: 0x040003BC RID: 956
			[Token(Token = "0x40003BC")]
			[FieldOffset(Offset = "0x0")]
			public bool overrideEnabled;

			// Token: 0x040003BD RID: 957
			[Token(Token = "0x40003BD")]
			[FieldOffset(Offset = "0x8")]
			public Texture originalTexture;

			// Token: 0x040003BE RID: 958
			[Token(Token = "0x40003BE")]
			[FieldOffset(Offset = "0x10")]
			public Texture replacementTexture;
		}
	}
}
