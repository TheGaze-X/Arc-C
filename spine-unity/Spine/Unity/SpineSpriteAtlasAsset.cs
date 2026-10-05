using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.U2D;

namespace Spine.Unity
{
	// Token: 0x02000074 RID: 116
	[Token(Token = "0x2000074")]
	[CreateAssetMenu(fileName = "New Spine SpriteAtlas Asset", menuName = "Spine/Spine SpriteAtlas Asset")]
	public class SpineSpriteAtlasAsset : AtlasAssetBase
	{
		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x00004064 File Offset: 0x00002264
		[Token(Token = "0x1700017C")]
		public override bool IsLoaded
		{
			[Token(Token = "0x60004CA")]
			[Address(RVA = "0x5C59B0", Offset = "0x5C45B0", VA = "0x1805C59B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700017D")]
		public override IEnumerable<Material> Materials
		{
			[Token(Token = "0x60004CB")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x0000407C File Offset: 0x0000227C
		[Token(Token = "0x1700017E")]
		public override int MaterialCount
		{
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x4E8B520", Offset = "0x4E8A120", VA = "0x184E8B520", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700017F")]
		public override Material PrimaryMaterial
		{
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x35EEE60", Offset = "0x35EDA60", VA = "0x1835EEE60", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x4E8C410", Offset = "0x4E8B010", VA = "0x184E8C410")]
		public static SpineSpriteAtlasAsset CreateRuntimeInstance(SpriteAtlas spriteAtlasFile, Material[] materials, bool initialize)
		{
			return null;
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x5D55A0", Offset = "0x5D41A0", VA = "0x1805D55A0")]
		private void Reset()
		{
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x22F73B0", Offset = "0x22F5FB0", VA = "0x1822F73B0", Slot = "8")]
		public override void Clear()
		{
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x4E8C4F0", Offset = "0x4E8B0F0", VA = "0x184E8C4F0", Slot = "9")]
		public override Atlas GetAtlas()
		{
			return null;
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x4E8C040", Offset = "0x4E8AC40", VA = "0x184E8C040")]
		protected void AssignRegionsFromSavedRegions(Sprite[] sprites, Atlas usedAtlas)
		{
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x4E8C8F0", Offset = "0x4E8B4F0", VA = "0x184E8C8F0")]
		private Atlas LoadAtlas(SpriteAtlas spriteAtlas)
		{
			return null;
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x4E8C010", Offset = "0x4E8AC10", VA = "0x184E8C010")]
		public static Texture2D AccessPackedTexture(Sprite[] sprites)
		{
			return null;
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x4E8BF90", Offset = "0x4E8AB90", VA = "0x184E8BF90")]
		public static Sprite[] AccessPackedSprites(SpriteAtlas spriteAtlas)
		{
			return null;
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		public SpineSpriteAtlasAsset()
		{
		}

		// Token: 0x040002CC RID: 716
		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x18")]
		public SpriteAtlas spriteAtlasFile;

		// Token: 0x040002CD RID: 717
		[Token(Token = "0x40002CD")]
		[FieldOffset(Offset = "0x20")]
		public Material[] materials;

		// Token: 0x040002CE RID: 718
		[Token(Token = "0x40002CE")]
		[FieldOffset(Offset = "0x28")]
		protected Atlas atlas;

		// Token: 0x040002CF RID: 719
		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x30")]
		public bool updateRegionsInPlayMode;

		// Token: 0x040002D0 RID: 720
		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected SpineSpriteAtlasAsset.SavedRegionInfo[] savedRegions;

		// Token: 0x02000075 RID: 117
		[Token(Token = "0x2000075")]
		[Serializable]
		protected class SavedRegionInfo
		{
			// Token: 0x060004D7 RID: 1239 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SavedRegionInfo()
			{
			}

			// Token: 0x040002D1 RID: 721
			[Token(Token = "0x40002D1")]
			[FieldOffset(Offset = "0x10")]
			public float x;

			// Token: 0x040002D2 RID: 722
			[Token(Token = "0x40002D2")]
			[FieldOffset(Offset = "0x14")]
			public float y;

			// Token: 0x040002D3 RID: 723
			[Token(Token = "0x40002D3")]
			[FieldOffset(Offset = "0x18")]
			public float width;

			// Token: 0x040002D4 RID: 724
			[Token(Token = "0x40002D4")]
			[FieldOffset(Offset = "0x1C")]
			public float height;

			// Token: 0x040002D5 RID: 725
			[Token(Token = "0x40002D5")]
			[FieldOffset(Offset = "0x20")]
			public SpritePackingRotation packingRotation;
		}
	}
}
