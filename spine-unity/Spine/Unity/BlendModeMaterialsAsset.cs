using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity
{
	// Token: 0x020000B4 RID: 180
	[Token(Token = "0x20000B4")]
	[CreateAssetMenu(menuName = "Spine/SkeletonData Modifiers/Blend Mode Materials", order = 200)]
	public class BlendModeMaterialsAsset : SkeletonDataModifierAsset
	{
		// Token: 0x060006CC RID: 1740 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x4E8DFB0", Offset = "0x4E8CBB0", VA = "0x184E8DFB0", Slot = "4")]
		public override void Apply(SkeletonData skeletonData)
		{
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x4E8D9B0", Offset = "0x4E8C5B0", VA = "0x184E8D9B0")]
		public static void ApplyMaterials(SkeletonData skeletonData, Material multiplyTemplate, Material screenTemplate, Material additiveTemplate, bool includeAdditiveSlots)
		{
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x4E8DFF0", Offset = "0x4E8CBF0", VA = "0x184E8DFF0")]
		public BlendModeMaterialsAsset()
		{
		}

		// Token: 0x0400044F RID: 1103
		[Token(Token = "0x400044F")]
		[FieldOffset(Offset = "0x18")]
		public Material multiplyMaterialTemplate;

		// Token: 0x04000450 RID: 1104
		[Token(Token = "0x4000450")]
		[FieldOffset(Offset = "0x20")]
		public Material screenMaterialTemplate;

		// Token: 0x04000451 RID: 1105
		[Token(Token = "0x4000451")]
		[FieldOffset(Offset = "0x28")]
		public Material additiveMaterialTemplate;

		// Token: 0x04000452 RID: 1106
		[Token(Token = "0x4000452")]
		[FieldOffset(Offset = "0x30")]
		public bool applyAdditiveMaterial;

		// Token: 0x020000B5 RID: 181
		[Token(Token = "0x20000B5")]
		private class AtlasMaterialCache : IDisposable
		{
			// Token: 0x060006CF RID: 1743 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x4E8D320", Offset = "0x4E8BF20", VA = "0x184E8D320")]
			public AtlasRegion CloneAtlasRegionWithMaterial(AtlasRegion originalRegion, Material materialTemplate)
			{
				return null;
			}

			// Token: 0x060006D0 RID: 1744 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x4E8D3F0", Offset = "0x4E8BFF0", VA = "0x184E8D3F0")]
			private AtlasPage GetAtlasPageWithMaterial(AtlasPage originalPage, Material materialTemplate)
			{
				return null;
			}

			// Token: 0x060006D1 RID: 1745 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x4E8D3A0", Offset = "0x4E8BFA0", VA = "0x184E8D3A0", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x060006D2 RID: 1746 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x4E8D680", Offset = "0x4E8C280", VA = "0x184E8D680")]
			public AtlasMaterialCache()
			{
			}

			// Token: 0x04000453 RID: 1107
			[Token(Token = "0x4000453")]
			[FieldOffset(Offset = "0x10")]
			private readonly Dictionary<KeyValuePair<AtlasPage, Material>, AtlasPage> cache;
		}
	}
}
