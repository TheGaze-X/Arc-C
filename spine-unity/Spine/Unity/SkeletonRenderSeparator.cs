using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity
{
	// Token: 0x02000097 RID: 151
	[Token(Token = "0x2000097")]
	[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonRenderSeparator")]
	[ExecuteAlways]
	public class SkeletonRenderSeparator : MonoBehaviour
	{
		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x0600063A RID: 1594 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170001B2")]
		public SkeletonRenderer SkeletonRenderer
		{
			[Token(Token = "0x6000639")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600063A")]
			[Address(RVA = "0x4E98C60", Offset = "0x4E97860", VA = "0x184E98C60")]
			set
			{
			}
		}

		// Token: 0x1400002D RID: 45
		// (add) Token: 0x0600063B RID: 1595 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x0600063C RID: 1596 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1400002D")]
		public event SkeletonRenderer.SkeletonRendererDelegate OnMeshAndMaterialsUpdated
		{
			[Token(Token = "0x600063B")]
			[Address(RVA = "0x4E98B20", Offset = "0x4E97720", VA = "0x184E98B20")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600063C")]
			[Address(RVA = "0x4E98BC0", Offset = "0x4E977C0", VA = "0x184E98BC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600063D")]
		[Address(RVA = "0x4E97F50", Offset = "0x4E96B50", VA = "0x184E97F50")]
		public static SkeletonRenderSeparator AddToSkeletonRenderer(SkeletonRenderer skeletonRenderer, int sortingLayerID = 0, int extraPartsRenderers = 0, int sortingOrderIncrement = 5, int baseSortingOrder = 0, bool addMinimumPartsRenderers = true)
		{
			return null;
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600063E")]
		[Address(RVA = "0x4E97DC0", Offset = "0x4E969C0", VA = "0x184E97DC0")]
		public SkeletonPartsRenderer AddPartsRenderer(int sortingOrderIncrement = 5, [Optional] string name)
		{
			return null;
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600063F")]
		[Address(RVA = "0x4E98730", Offset = "0x4E97330", VA = "0x184E98730")]
		public void OnEnable()
		{
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000640")]
		[Address(RVA = "0x4E98500", Offset = "0x4E97100", VA = "0x184E98500")]
		public void OnDisable()
		{
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000641")]
		[Address(RVA = "0x4E981C0", Offset = "0x4E96DC0", VA = "0x184E981C0")]
		private void HandleRender(SkeletonRendererInstruction instruction)
		{
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000642")]
		[Address(RVA = "0x4E98A90", Offset = "0x4E97690", VA = "0x184E98A90")]
		public SkeletonRenderSeparator()
		{
		}

		// Token: 0x040003CE RID: 974
		[Token(Token = "0x40003CE")]
		public const int DefaultSortingOrderIncrement = 5;

		// Token: 0x040003CF RID: 975
		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected SkeletonRenderer skeletonRenderer;

		// Token: 0x040003D0 RID: 976
		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MeshRenderer mainMeshRenderer;

		// Token: 0x040003D1 RID: 977
		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool copyPropertyBlock;

		// Token: 0x040003D2 RID: 978
		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[Tooltip("Copies MeshRenderer flags into each parts renderer")]
		public bool copyMeshRendererFlags;

		// Token: 0x040003D3 RID: 979
		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<SkeletonPartsRenderer> partsRenderers;

		// Token: 0x040003D5 RID: 981
		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private MaterialPropertyBlock copiedBlock;
	}
}
