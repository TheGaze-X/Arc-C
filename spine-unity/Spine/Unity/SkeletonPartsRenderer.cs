using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity
{
	// Token: 0x02000095 RID: 149
	[Token(Token = "0x2000095")]
	[RequireComponent(typeof(MeshRenderer), typeof(MeshFilter))]
	[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonRenderSeparator")]
	public class SkeletonPartsRenderer : MonoBehaviour
	{
		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600062A RID: 1578 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x170001AF")]
		public MeshGenerator MeshGenerator
		{
			[Token(Token = "0x600062A")]
			[Address(RVA = "0x4E97CE0", Offset = "0x4E968E0", VA = "0x184E97CE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600062B RID: 1579 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x170001B0")]
		public MeshRenderer MeshRenderer
		{
			[Token(Token = "0x600062B")]
			[Address(RVA = "0x4E97D00", Offset = "0x4E96900", VA = "0x184E97D00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x170001B1")]
		public MeshFilter MeshFilter
		{
			[Token(Token = "0x600062C")]
			[Address(RVA = "0x4E97CC0", Offset = "0x4E968C0", VA = "0x184E97CC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400002C RID: 44
		// (add) Token: 0x0600062D RID: 1581 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x0600062E RID: 1582 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1400002C")]
		public event SkeletonPartsRenderer.SkeletonPartsRendererDelegate OnMeshAndMaterialsUpdated
		{
			[Token(Token = "0x600062D")]
			[Address(RVA = "0x4E97C20", Offset = "0x4E96820", VA = "0x184E97C20")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600062E")]
			[Address(RVA = "0x4E97D20", Offset = "0x4E96920", VA = "0x184E97D20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600062F")]
		[Address(RVA = "0x4E96FD0", Offset = "0x4E95BD0", VA = "0x184E96FD0")]
		private void LazyIntialize()
		{
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000630")]
		[Address(RVA = "0x4E96FA0", Offset = "0x4E95BA0", VA = "0x184E96FA0")]
		public void ClearMesh()
		{
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000631")]
		[Address(RVA = "0x4E974E0", Offset = "0x4E960E0", VA = "0x184E974E0")]
		public void RenderParts(ExposedList<SubmeshInstruction> instructions, int startSubmesh, int endSubmesh)
		{
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000632")]
		[Address(RVA = "0x4E97B70", Offset = "0x4E96770", VA = "0x184E97B70")]
		public void SetPropertyBlock(MaterialPropertyBlock block)
		{
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000633")]
		[Address(RVA = "0x4E972D0", Offset = "0x4E95ED0", VA = "0x184E972D0")]
		public static SkeletonPartsRenderer NewPartsRendererGameObject(Transform parent, string name, int sortingOrder = 0)
		{
			return null;
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000634")]
		[Address(RVA = "0x4E97BB0", Offset = "0x4E967B0", VA = "0x184E97BB0")]
		public SkeletonPartsRenderer()
		{
		}

		// Token: 0x040003C8 RID: 968
		[Token(Token = "0x40003C8")]
		[FieldOffset(Offset = "0x18")]
		private MeshGenerator meshGenerator;

		// Token: 0x040003C9 RID: 969
		[Token(Token = "0x40003C9")]
		[FieldOffset(Offset = "0x20")]
		private MeshRenderer meshRenderer;

		// Token: 0x040003CA RID: 970
		[Token(Token = "0x40003CA")]
		[FieldOffset(Offset = "0x28")]
		private MeshFilter meshFilter;

		// Token: 0x040003CC RID: 972
		[Token(Token = "0x40003CC")]
		[FieldOffset(Offset = "0x38")]
		private MeshRendererBuffers buffers;

		// Token: 0x040003CD RID: 973
		[Token(Token = "0x40003CD")]
		[FieldOffset(Offset = "0x40")]
		private SkeletonRendererInstruction currentInstructions;

		// Token: 0x02000096 RID: 150
		// (Invoke) Token: 0x06000636 RID: 1590
		[Token(Token = "0x2000096")]
		public delegate void SkeletonPartsRendererDelegate(SkeletonPartsRenderer skeletonPartsRenderer);
	}
}
