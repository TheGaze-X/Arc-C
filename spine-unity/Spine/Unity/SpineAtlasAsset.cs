using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity
{
	// Token: 0x02000072 RID: 114
	[Token(Token = "0x2000072")]
	[CreateAssetMenu(fileName = "New Spine Atlas Asset", menuName = "Spine/Spine Atlas Asset")]
	public class SpineAtlasAsset : AtlasAssetBase
	{
		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x00004034 File Offset: 0x00002234
		[Token(Token = "0x17000178")]
		public override bool IsLoaded
		{
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x5C59B0", Offset = "0x5C45B0", VA = "0x1805C59B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000179")]
		public override IEnumerable<Material> Materials
		{
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x0000404C File Offset: 0x0000224C
		[Token(Token = "0x1700017A")]
		public override int MaterialCount
		{
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x4E8B520", Offset = "0x4E8A120", VA = "0x184E8B520", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700017B")]
		public override Material PrimaryMaterial
		{
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x35EEE60", Offset = "0x35EDA60", VA = "0x1835EEE60", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x4E8A460", Offset = "0x4E89060", VA = "0x184E8A460")]
		public static SpineAtlasAsset CreateRuntimeInstance(TextAsset atlasText, Material[] materials, bool initialize)
		{
			return null;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x4E8A540", Offset = "0x4E89140", VA = "0x184E8A540")]
		public static SpineAtlasAsset CreateRuntimeInstance(TextAsset atlasText, Texture2D[] textures, Material materialPropertySource, bool initialize)
		{
			return null;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x4E8A9F0", Offset = "0x4E895F0", VA = "0x184E8A9F0")]
		public static SpineAtlasAsset CreateRuntimeInstance(TextAsset atlasText, Texture2D[] textures, Shader shader, bool initialize)
		{
			return null;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x5D55A0", Offset = "0x5D41A0", VA = "0x1805D55A0")]
		private void Reset()
		{
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x22F73B0", Offset = "0x22F5FB0", VA = "0x1822F73B0", Slot = "8")]
		public override void Clear()
		{
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x4E8B030", Offset = "0x4E89C30", VA = "0x184E8B030", Slot = "9")]
		public override Atlas GetAtlas()
		{
			return null;
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x4E8AAE0", Offset = "0x4E896E0", VA = "0x184E8AAE0")]
		public Mesh GenerateMesh(string name, Mesh mesh, out Material material, float scale = 0.01f)
		{
			return null;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		public SpineAtlasAsset()
		{
		}

		// Token: 0x040002C8 RID: 712
		[Token(Token = "0x40002C8")]
		[FieldOffset(Offset = "0x18")]
		public TextAsset atlasFile;

		// Token: 0x040002C9 RID: 713
		[Token(Token = "0x40002C9")]
		[FieldOffset(Offset = "0x20")]
		public Material[] materials;

		// Token: 0x040002CA RID: 714
		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x28")]
		protected Atlas atlas;
	}
}
