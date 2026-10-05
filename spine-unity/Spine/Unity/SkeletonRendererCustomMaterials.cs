using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity
{
	// Token: 0x02000092 RID: 146
	[Token(Token = "0x2000092")]
	[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonRendererCustomMaterials")]
	[ExecuteAlways]
	public class SkeletonRendererCustomMaterials : MonoBehaviour
	{
		// Token: 0x06000621 RID: 1569 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000621")]
		[Address(RVA = "0x4E99790", Offset = "0x4E98390", VA = "0x184E99790")]
		private void SetCustomSlotMaterials()
		{
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000622")]
		[Address(RVA = "0x4E99420", Offset = "0x4E98020", VA = "0x184E99420")]
		private void RemoveCustomSlotMaterials()
		{
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000623")]
		[Address(RVA = "0x4E99640", Offset = "0x4E98240", VA = "0x184E99640")]
		private void SetCustomMaterialOverrides()
		{
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000624")]
		[Address(RVA = "0x4E99240", Offset = "0x4E97E40", VA = "0x184E99240")]
		private void RemoveCustomMaterialOverrides()
		{
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000625")]
		[Address(RVA = "0x4E98E50", Offset = "0x4E97A50", VA = "0x184E98E50")]
		private void OnEnable()
		{
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000626")]
		[Address(RVA = "0x4E98D90", Offset = "0x4E97990", VA = "0x184E98D90")]
		private void OnDisable()
		{
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000627")]
		[Address(RVA = "0x4E99930", Offset = "0x4E98530", VA = "0x184E99930")]
		public SkeletonRendererCustomMaterials()
		{
		}

		// Token: 0x040003BF RID: 959
		[Token(Token = "0x40003BF")]
		[FieldOffset(Offset = "0x18")]
		public SkeletonRenderer skeletonRenderer;

		// Token: 0x040003C0 RID: 960
		[Token(Token = "0x40003C0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected List<SkeletonRendererCustomMaterials.SlotMaterialOverride> customSlotMaterials;

		// Token: 0x040003C1 RID: 961
		[Token(Token = "0x40003C1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected List<SkeletonRendererCustomMaterials.AtlasMaterialOverride> customMaterialOverrides;

		// Token: 0x02000093 RID: 147
		[Token(Token = "0x2000093")]
		[Serializable]
		public struct SlotMaterialOverride : IEquatable<SkeletonRendererCustomMaterials.SlotMaterialOverride>
		{
			// Token: 0x06000628 RID: 1576 RVA: 0x00004544 File Offset: 0x00002744
			[Token(Token = "0x6000628")]
			[Address(RVA = "0x4E9E410", Offset = "0x4E9D010", VA = "0x184E9E410", Slot = "4")]
			public bool Equals(SkeletonRendererCustomMaterials.SlotMaterialOverride other)
			{
				return default(bool);
			}

			// Token: 0x040003C2 RID: 962
			[Token(Token = "0x40003C2")]
			[FieldOffset(Offset = "0x0")]
			public bool overrideDisabled;

			// Token: 0x040003C3 RID: 963
			[Token(Token = "0x40003C3")]
			[FieldOffset(Offset = "0x8")]
			[SpineSlot("", "", false, true, false)]
			public string slotName;

			// Token: 0x040003C4 RID: 964
			[Token(Token = "0x40003C4")]
			[FieldOffset(Offset = "0x10")]
			public Material material;
		}

		// Token: 0x02000094 RID: 148
		[Token(Token = "0x2000094")]
		[Serializable]
		public struct AtlasMaterialOverride : IEquatable<SkeletonRendererCustomMaterials.AtlasMaterialOverride>
		{
			// Token: 0x06000629 RID: 1577 RVA: 0x0000455C File Offset: 0x0000275C
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x4E8D710", Offset = "0x4E8C310", VA = "0x184E8D710", Slot = "4")]
			public bool Equals(SkeletonRendererCustomMaterials.AtlasMaterialOverride other)
			{
				return default(bool);
			}

			// Token: 0x040003C5 RID: 965
			[Token(Token = "0x40003C5")]
			[FieldOffset(Offset = "0x0")]
			public bool overrideDisabled;

			// Token: 0x040003C6 RID: 966
			[Token(Token = "0x40003C6")]
			[FieldOffset(Offset = "0x8")]
			public Material originalMaterial;

			// Token: 0x040003C7 RID: 967
			[Token(Token = "0x40003C7")]
			[FieldOffset(Offset = "0x10")]
			public Material replacementMaterial;
		}
	}
}
