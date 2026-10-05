using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity.Deprecated
{
	// Token: 0x020000CF RID: 207
	[Token(Token = "0x20000CF")]
	[DisallowMultipleComponent]
	[Obsolete("The spine-unity 3.7 runtime introduced SkeletonDataModifierAssets BlendModeMaterials which replaced SlotBlendModes. Will be removed in spine-unity 3.9.", false)]
	public class SlotBlendModes : MonoBehaviour
	{
		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600076F RID: 1903 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x170001C7")]
		internal static Dictionary<SlotBlendModes.MaterialTexturePair, SlotBlendModes.MaterialWithRefcount> MaterialTable
		{
			[Token(Token = "0x600076F")]
			[Address(RVA = "0x4EA9490", Offset = "0x4EA8090", VA = "0x184EA9490")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000770")]
		[Address(RVA = "0x4EA8B50", Offset = "0x4EA7750", VA = "0x184EA8B50")]
		internal static Material GetOrAddMaterialFor(Material materialSource, Texture2D texture)
		{
			return null;
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000771")]
		[Address(RVA = "0x4EA8A20", Offset = "0x4EA7620", VA = "0x184EA8A20")]
		internal static SlotBlendModes.MaterialWithRefcount GetExistingMaterialFor(Material materialSource, Texture2D texture)
		{
			return null;
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000772")]
		[Address(RVA = "0x4EA9020", Offset = "0x4EA7C20", VA = "0x184EA9020")]
		internal static void RemoveMaterialFromTable(Material materialSource, Texture2D texture)
		{
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x000049AC File Offset: 0x00002BAC
		// (set) Token: 0x06000774 RID: 1908 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170001C8")]
		public bool Applied
		{
			[Token(Token = "0x6000773")]
			[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000774")]
			[Address(RVA = "0x14D9990", Offset = "0x14D8590", VA = "0x1814D9990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000775")]
		[Address(RVA = "0x4EA9420", Offset = "0x4EA8020", VA = "0x184EA9420")]
		private void Start()
		{
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000776")]
		[Address(RVA = "0x4EA9010", Offset = "0x4EA7C10", VA = "0x184EA9010")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000777")]
		[Address(RVA = "0x4EA83E0", Offset = "0x4EA6FE0", VA = "0x184EA83E0")]
		public void Apply()
		{
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000778")]
		[Address(RVA = "0x4EA90D0", Offset = "0x4EA7CD0", VA = "0x184EA90D0")]
		public void Remove()
		{
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000779")]
		[Address(RVA = "0x4EA8E10", Offset = "0x4EA7A10", VA = "0x184EA8E10")]
		public void GetTexture()
		{
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600077A")]
		[Address(RVA = "0x4EA9430", Offset = "0x4EA8030", VA = "0x184EA9430")]
		public SlotBlendModes()
		{
		}

		// Token: 0x04000482 RID: 1154
		[Token(Token = "0x4000482")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<SlotBlendModes.MaterialTexturePair, SlotBlendModes.MaterialWithRefcount> materialTable;

		// Token: 0x04000483 RID: 1155
		[Token(Token = "0x4000483")]
		[FieldOffset(Offset = "0x18")]
		public Material multiplyMaterialSource;

		// Token: 0x04000484 RID: 1156
		[Token(Token = "0x4000484")]
		[FieldOffset(Offset = "0x20")]
		public Material screenMaterialSource;

		// Token: 0x04000485 RID: 1157
		[Token(Token = "0x4000485")]
		[FieldOffset(Offset = "0x28")]
		private Texture2D texture;

		// Token: 0x04000486 RID: 1158
		[Token(Token = "0x4000486")]
		[FieldOffset(Offset = "0x30")]
		private SlotBlendModes.SlotMaterialTextureTuple[] slotsWithCustomMaterial;

		// Token: 0x020000D0 RID: 208
		[Token(Token = "0x20000D0")]
		public struct MaterialTexturePair
		{
			// Token: 0x04000488 RID: 1160
			[Token(Token = "0x4000488")]
			[FieldOffset(Offset = "0x0")]
			public Texture2D texture2D;

			// Token: 0x04000489 RID: 1161
			[Token(Token = "0x4000489")]
			[FieldOffset(Offset = "0x8")]
			public Material material;
		}

		// Token: 0x020000D1 RID: 209
		[Token(Token = "0x20000D1")]
		internal class MaterialWithRefcount
		{
			// Token: 0x0600077B RID: 1915 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x600077B")]
			[Address(RVA = "0x4EA6EE0", Offset = "0x4EA5AE0", VA = "0x184EA6EE0")]
			public MaterialWithRefcount(Material mat)
			{
			}

			// Token: 0x0400048A RID: 1162
			[Token(Token = "0x400048A")]
			[FieldOffset(Offset = "0x10")]
			public Material materialClone;

			// Token: 0x0400048B RID: 1163
			[Token(Token = "0x400048B")]
			[FieldOffset(Offset = "0x18")]
			public int refcount;
		}

		// Token: 0x020000D2 RID: 210
		[Token(Token = "0x20000D2")]
		internal struct SlotMaterialTextureTuple
		{
			// Token: 0x0600077C RID: 1916 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x600077C")]
			[Address(RVA = "0x4EA9550", Offset = "0x4EA8150", VA = "0x184EA9550")]
			public SlotMaterialTextureTuple(Slot slot, Material material, Texture2D texture)
			{
			}

			// Token: 0x0400048C RID: 1164
			[Token(Token = "0x400048C")]
			[FieldOffset(Offset = "0x0")]
			public Slot slot;

			// Token: 0x0400048D RID: 1165
			[Token(Token = "0x400048D")]
			[FieldOffset(Offset = "0x8")]
			public Texture2D texture2D;

			// Token: 0x0400048E RID: 1166
			[Token(Token = "0x400048E")]
			[FieldOffset(Offset = "0x10")]
			public Material material;
		}
	}
}
