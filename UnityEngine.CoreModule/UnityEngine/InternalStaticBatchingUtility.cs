using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x02000132 RID: 306
	[Token(Token = "0x2000132")]
	internal class InternalStaticBatchingUtility
	{
		// Token: 0x06000A88 RID: 2696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x595D840", Offset = "0x595C440", VA = "0x18595D840")]
		public static void CombineRoot(GameObject staticBatchRoot, InternalStaticBatchingUtility.StaticBatcherGOSorter sorter)
		{
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x595D860", Offset = "0x595C460", VA = "0x18595D860")]
		public static void Combine(GameObject staticBatchRoot, bool combineOnlyStatic, bool isEditorPostprocessScene, InternalStaticBatchingUtility.StaticBatcherGOSorter sorter)
		{
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x00005EB0 File Offset: 0x000040B0
		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x595DBF0", Offset = "0x595C7F0", VA = "0x18595DBF0")]
		private static uint GetMeshFormatHash(Mesh mesh)
		{
			return 0U;
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x595E940", Offset = "0x595D540", VA = "0x18595E940")]
		private static GameObject[] SortGameObjectsForStaticBatching(GameObject[] gos, InternalStaticBatchingUtility.StaticBatcherGOSorter sorter)
		{
			return null;
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x595C090", Offset = "0x595AC90", VA = "0x18595C090")]
		public static void CombineGameObjects(GameObject[] gos, GameObject staticBatchRoot, bool isEditorPostprocessScene, InternalStaticBatchingUtility.StaticBatcherGOSorter sorter)
		{
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x595DD70", Offset = "0x595C970", VA = "0x18595DD70")]
		private static void MakeBatch(List<MeshSubsetCombineUtility.MeshContainer> meshes, Transform staticBatchRootTransform, int batchIndex)
		{
		}

		// Token: 0x02000133 RID: 307
		[Token(Token = "0x2000133")]
		public class StaticBatcherGOSorter
		{
			// Token: 0x06000A8E RID: 2702 RVA: 0x00005EC8 File Offset: 0x000040C8
			[Token(Token = "0x6000A8E")]
			[Address(RVA = "0x596F5B0", Offset = "0x596E1B0", VA = "0x18596F5B0", Slot = "4")]
			public virtual long GetMaterialId(Renderer renderer)
			{
				return 0L;
			}

			// Token: 0x06000A8F RID: 2703 RVA: 0x00005EE0 File Offset: 0x000040E0
			[Token(Token = "0x6000A8F")]
			[Address(RVA = "0x596F4B0", Offset = "0x596E0B0", VA = "0x18596F4B0")]
			public int GetLightmapIndex(Renderer renderer)
			{
				return 0;
			}

			// Token: 0x06000A90 RID: 2704 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000A90")]
			[Address(RVA = "0x596FA90", Offset = "0x596E690", VA = "0x18596FA90")]
			public static Renderer GetRenderer(GameObject go)
			{
				return null;
			}

			// Token: 0x06000A91 RID: 2705 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000A91")]
			[Address(RVA = "0x596F7A0", Offset = "0x596E3A0", VA = "0x18596F7A0")]
			public static Mesh GetMesh(GameObject go)
			{
				return null;
			}

			// Token: 0x06000A92 RID: 2706 RVA: 0x00005EF8 File Offset: 0x000040F8
			[Token(Token = "0x6000A92")]
			[Address(RVA = "0x596F980", Offset = "0x596E580", VA = "0x18596F980", Slot = "5")]
			public virtual long GetRendererId(Renderer renderer)
			{
				return 0L;
			}

			// Token: 0x06000A93 RID: 2707 RVA: 0x00005F10 File Offset: 0x00004110
			[Token(Token = "0x6000A93")]
			[Address(RVA = "0x596FD10", Offset = "0x596E910", VA = "0x18596FD10")]
			public static bool GetScaleFlip(GameObject go)
			{
				return default(bool);
			}

			// Token: 0x06000A94 RID: 2708 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A94")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public StaticBatcherGOSorter()
			{
			}
		}
	}
}
