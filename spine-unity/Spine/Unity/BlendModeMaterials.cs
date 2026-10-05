using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity
{
	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000068")]
	[Serializable]
	public class BlendModeMaterials
	{
		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x00004004 File Offset: 0x00002204
		// (set) Token: 0x06000498 RID: 1176 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000174")]
		public bool RequiresBlendModeMaterials
		{
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000498")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			set
			{
			}
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x4E75620", Offset = "0x4E74220", VA = "0x184E75620")]
		public void ApplyMaterials(SkeletonData skeletonData)
		{
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600049A")]
		[Address(RVA = "0x4E75AB0", Offset = "0x4E746B0", VA = "0x184E75AB0")]
		protected AtlasRegion CloneAtlasRegionWithMaterial(AtlasRegion originalRegion, List<BlendModeMaterials.ReplacementMaterial> replacementMaterials)
		{
			return null;
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600049B")]
		[Address(RVA = "0x4E75C90", Offset = "0x4E74890", VA = "0x184E75C90")]
		public BlendModeMaterials()
		{
		}

		// Token: 0x040002A6 RID: 678
		[Token(Token = "0x40002A6")]
		[FieldOffset(Offset = "0x10")]
		[HideInInspector]
		[SerializeField]
		protected bool requiresBlendModeMaterials;

		// Token: 0x040002A7 RID: 679
		[Token(Token = "0x40002A7")]
		[FieldOffset(Offset = "0x11")]
		public bool applyAdditiveMaterial;

		// Token: 0x040002A8 RID: 680
		[Token(Token = "0x40002A8")]
		[FieldOffset(Offset = "0x18")]
		public List<BlendModeMaterials.ReplacementMaterial> additiveMaterials;

		// Token: 0x040002A9 RID: 681
		[Token(Token = "0x40002A9")]
		[FieldOffset(Offset = "0x20")]
		public List<BlendModeMaterials.ReplacementMaterial> multiplyMaterials;

		// Token: 0x040002AA RID: 682
		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0x28")]
		public List<BlendModeMaterials.ReplacementMaterial> screenMaterials;

		// Token: 0x02000069 RID: 105
		[Token(Token = "0x2000069")]
		[Serializable]
		public class ReplacementMaterial
		{
			// Token: 0x0600049C RID: 1180 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ReplacementMaterial()
			{
			}

			// Token: 0x040002AB RID: 683
			[Token(Token = "0x40002AB")]
			[FieldOffset(Offset = "0x10")]
			public string pageName;

			// Token: 0x040002AC RID: 684
			[Token(Token = "0x40002AC")]
			[FieldOffset(Offset = "0x18")]
			public Material material;
		}
	}
}
