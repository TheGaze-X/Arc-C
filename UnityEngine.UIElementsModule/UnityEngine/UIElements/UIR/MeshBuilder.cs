using System;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Profiling;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x0200029B RID: 667
	[Token(Token = "0x200029B")]
	internal static class MeshBuilder
	{
		// Token: 0x0600124E RID: 4686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600124E")]
		[Address(RVA = "0x5B35CF0", Offset = "0x5B348F0", VA = "0x185B35CF0")]
		internal static void MakeBorder(MeshGenerationContextUtils.BorderParams borderParams, float posZ, MeshBuilder.AllocMeshData meshAlloc)
		{
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600124F")]
		[Address(RVA = "0x5B36EA0", Offset = "0x5B35AA0", VA = "0x185B36EA0")]
		internal static void MakeSolidRect(MeshGenerationContextUtils.RectangleParams rectParams, float posZ, MeshBuilder.AllocMeshData meshAlloc)
		{
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001250")]
		[Address(RVA = "0x5B37AE0", Offset = "0x5B366E0", VA = "0x185B37AE0")]
		internal static void MakeTexturedRect(MeshGenerationContextUtils.RectangleParams rectParams, float posZ, MeshBuilder.AllocMeshData meshAlloc, ColorPage colorPage)
		{
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x00009CD8 File Offset: 0x00007ED8
		[Token(Token = "0x6001251")]
		[Address(RVA = "0x5B35060", Offset = "0x5B33C60", VA = "0x185B35060")]
		private static Vertex ConvertTextVertexToUIRVertex(MeshInfo info, int index, Vector2 offset, VertexFlags flags = VertexFlags.IsText, bool isDynamicColor = false)
		{
			return default(Vertex);
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x00009CF0 File Offset: 0x00007EF0
		[Token(Token = "0x6001252")]
		[Address(RVA = "0x5B35220", Offset = "0x5B33E20", VA = "0x185B35220")]
		private static Vertex ConvertTextVertexToUIRVertex(TextVertex textVertex, Vector2 offset)
		{
			return default(Vertex);
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x00009D08 File Offset: 0x00007F08
		[Token(Token = "0x6001253")]
		[Address(RVA = "0x5B35BC0", Offset = "0x5B347C0", VA = "0x185B35BC0")]
		private static int LimitTextVertices(int vertexCount, bool logTruncation = true)
		{
			return 0;
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001254")]
		[Address(RVA = "0x5B376C0", Offset = "0x5B362C0", VA = "0x185B376C0")]
		internal static void MakeText(MeshInfo meshInfo, Vector2 offset, MeshBuilder.AllocMeshData meshAlloc, VertexFlags flags = VertexFlags.IsText, bool isDynamicColor = false)
		{
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001255")]
		[Address(RVA = "0x5B371D0", Offset = "0x5B35DD0", VA = "0x185B371D0")]
		internal static void MakeText(NativeArray<TextVertex> uiVertices, Vector2 offset, MeshBuilder.AllocMeshData meshAlloc)
		{
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001256")]
		[Address(RVA = "0x5B3C7A0", Offset = "0x5B3B3A0", VA = "0x185B3C7A0")]
		internal static void UpdateText(NativeArray<TextVertex> uiVertices, Vector2 offset, Matrix4x4 transform, Color32 xformClipPages, Color32 ids, Color32 flags, Color32 opacityPageSettingIndex, NativeSlice<Vertex> vertices)
		{
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001257")]
		[Address(RVA = "0x5B35E10", Offset = "0x5B34A10", VA = "0x185B35E10")]
		private static void MakeQuad(Rect rcPosition, Rect rcTexCoord, Color color, float posZ, MeshBuilder.AllocMeshData meshAlloc, ColorPage colorPage)
		{
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001258")]
		[Address(RVA = "0x5B36370", Offset = "0x5B34F70", VA = "0x185B36370")]
		internal static void MakeSlicedQuad(ref MeshGenerationContextUtils.RectangleParams rectParams, float posZ, MeshBuilder.AllocMeshData meshAlloc)
		{
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001259")]
		[Address(RVA = "0x5B39CA0", Offset = "0x5B388A0", VA = "0x185B39CA0")]
		internal static void MakeVectorGraphics(MeshGenerationContextUtils.RectangleParams rectParams, int settingIndexOffset, MeshBuilder.AllocMeshData meshAlloc, out int finalVertexCount, out int finalIndexCount)
		{
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600125A")]
		[Address(RVA = "0x5B38F40", Offset = "0x5B37B40", VA = "0x185B38F40")]
		internal static void MakeVectorGraphicsStretchBackground(Vertex[] svgVertices, ushort[] svgIndices, float svgWidth, float svgHeight, Rect targetRect, Rect sourceUV, ScaleMode scaleMode, Color tint, int settingIndexOffset, MeshBuilder.AllocMeshData meshAlloc, out int finalVertexCount, out int finalIndexCount)
		{
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600125B")]
		[Address(RVA = "0x5B3BF60", Offset = "0x5B3AB60", VA = "0x185B3BF60")]
		private unsafe static void SplitTriangle(Vertex* vertices, ushort* indices, ref int vertexCount, int indexToProcess, ref int indexCount, float svgWidth, float svgHeight, Vector4 sliceLTRB, int sliceIndex)
		{
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600125C")]
		[Address(RVA = "0x5B3BC10", Offset = "0x5B3A810", VA = "0x185B3BC10")]
		private unsafe static void ScaleSplittedTriangles(Vertex* vertices, int vertexCount, float svgWidth, float svgHeight, Rect targetRect, Vector4 sliceLTRB)
		{
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600125D")]
		[Address(RVA = "0x5B383E0", Offset = "0x5B36FE0", VA = "0x185B383E0")]
		internal static void MakeVectorGraphics9SliceBackground(Vertex[] svgVertices, ushort[] svgIndices, float svgWidth, float svgHeight, Rect targetRect, Vector4 sliceLTRB, bool stretch, Color tint, int settingIndexOffset, MeshBuilder.AllocMeshData meshAlloc)
		{
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x00009D20 File Offset: 0x00007F20
		[Token(Token = "0x600125E")]
		[Address(RVA = "0x5B3CAB0", Offset = "0x5B3B6B0", VA = "0x185B3CAB0")]
		private static MeshBuilder.ClipCounts UpperBoundApproximateRectClippingResults(Vertex[] vertices, ushort[] indices, Vector4 clipRectMinMax)
		{
			return default(MeshBuilder.ClipCounts);
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600125F")]
		[Address(RVA = "0x5B3B6D0", Offset = "0x5B3A2D0", VA = "0x185B3B6D0")]
		private static void RectClip(Vertex[] vertices, ushort[] indices, Vector4 clipRectMinMax, MeshWriteData mwd, MeshBuilder.ClipCounts cc, ref int newVertexCount)
		{
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001260")]
		[Address(RVA = "0x5B3A880", Offset = "0x5B39480", VA = "0x185B3A880")]
		private unsafe static void RectClipTriangle(Vertex* vt, ushort* it, Vector4 clipRectMinMax, MeshWriteData mwd, ref ushort nextNewVertex)
		{
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x00009D38 File Offset: 0x00007F38
		[Token(Token = "0x6001261")]
		[Address(RVA = "0x5B35300", Offset = "0x5B33F00", VA = "0x185B35300")]
		private unsafe static Vector3 GetVertexBaryCentricCoordinates(Vertex* vt, float x, float y)
		{
			return default(Vector3);
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x00009D50 File Offset: 0x00007F50
		[Token(Token = "0x6001262")]
		[Address(RVA = "0x5B35750", Offset = "0x5B34350", VA = "0x185B35750")]
		private unsafe static Vertex InterpolateVertexInTriangle(Vertex* vt, float x, float y, Vector3 uvw)
		{
			return default(Vertex);
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x00009D68 File Offset: 0x00007F68
		[Token(Token = "0x6001263")]
		[Address(RVA = "0x5B354A0", Offset = "0x5B340A0", VA = "0x185B354A0")]
		private unsafe static Vertex InterpolateVertexInTriangleEdge(Vertex* vt, int e0, int e1, float t)
		{
			return default(Vertex);
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x00009D80 File Offset: 0x00007F80
		[Token(Token = "0x6001264")]
		[Address(RVA = "0x5B35A80", Offset = "0x5B34680", VA = "0x185B35A80")]
		private static float IntersectSegments(float ax, float ay, float bx, float by, float cx, float cy, float dx, float dy)
		{
			return 0f;
		}

		// Token: 0x04000998 RID: 2456
		[Token(Token = "0x4000998")]
		[FieldOffset(Offset = "0x0")]
		private static ProfilerMarker s_VectorGraphics9Slice;

		// Token: 0x04000999 RID: 2457
		[Token(Token = "0x4000999")]
		[FieldOffset(Offset = "0x8")]
		private static ProfilerMarker s_VectorGraphicsSplitTriangle;

		// Token: 0x0400099A RID: 2458
		[Token(Token = "0x400099A")]
		[FieldOffset(Offset = "0x10")]
		private static ProfilerMarker s_VectorGraphicsScaleTriangle;

		// Token: 0x0400099B RID: 2459
		[Token(Token = "0x400099B")]
		[FieldOffset(Offset = "0x18")]
		private static ProfilerMarker s_VectorGraphicsStretch;

		// Token: 0x0400099C RID: 2460
		[Token(Token = "0x400099C")]
		[FieldOffset(Offset = "0x20")]
		internal static readonly int s_MaxTextMeshVertices;

		// Token: 0x0400099D RID: 2461
		[Token(Token = "0x400099D")]
		[FieldOffset(Offset = "0x28")]
		private static readonly ushort[] slicedQuadIndices;

		// Token: 0x0400099E RID: 2462
		[Token(Token = "0x400099E")]
		[FieldOffset(Offset = "0x30")]
		private static readonly float[] k_TexCoordSlicesX;

		// Token: 0x0400099F RID: 2463
		[Token(Token = "0x400099F")]
		[FieldOffset(Offset = "0x38")]
		private static readonly float[] k_TexCoordSlicesY;

		// Token: 0x040009A0 RID: 2464
		[Token(Token = "0x40009A0")]
		[FieldOffset(Offset = "0x40")]
		private static readonly float[] k_PositionSlicesX;

		// Token: 0x040009A1 RID: 2465
		[Token(Token = "0x40009A1")]
		[FieldOffset(Offset = "0x48")]
		private static readonly float[] k_PositionSlicesY;

		// Token: 0x040009A2 RID: 2466
		[Token(Token = "0x40009A2")]
		[FieldOffset(Offset = "0x50")]
		private static MeshBuilder.VertexClipEdge[] s_AllClipEdges;

		// Token: 0x0200029C RID: 668
		[Token(Token = "0x200029C")]
		internal struct AllocMeshData
		{
			// Token: 0x06001266 RID: 4710 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x6001266")]
			[Address(RVA = "0x5B33A90", Offset = "0x5B32690", VA = "0x185B33A90")]
			internal MeshWriteData Allocate(uint vertexCount, uint indexCount)
			{
				return null;
			}

			// Token: 0x040009A3 RID: 2467
			[Token(Token = "0x40009A3")]
			[FieldOffset(Offset = "0x0")]
			internal MeshBuilder.AllocMeshData.Allocator alloc;

			// Token: 0x040009A4 RID: 2468
			[Token(Token = "0x40009A4")]
			[FieldOffset(Offset = "0x8")]
			internal Texture texture;

			// Token: 0x040009A5 RID: 2469
			[Token(Token = "0x40009A5")]
			[FieldOffset(Offset = "0x10")]
			internal TextureId svgTexture;

			// Token: 0x040009A6 RID: 2470
			[Token(Token = "0x40009A6")]
			[FieldOffset(Offset = "0x18")]
			internal Material material;

			// Token: 0x040009A7 RID: 2471
			[Token(Token = "0x40009A7")]
			[FieldOffset(Offset = "0x20")]
			internal MeshGenerationContext.MeshFlags flags;

			// Token: 0x040009A8 RID: 2472
			[Token(Token = "0x40009A8")]
			[FieldOffset(Offset = "0x24")]
			internal BMPAlloc colorAlloc;

			// Token: 0x0200029D RID: 669
			// (Invoke) Token: 0x06001268 RID: 4712
			[Token(Token = "0x200029D")]
			internal delegate MeshWriteData Allocator(uint vertexCount, uint indexCount, ref MeshBuilder.AllocMeshData allocatorData);
		}

		// Token: 0x0200029E RID: 670
		[Token(Token = "0x200029E")]
		private struct ClipCounts
		{
			// Token: 0x040009A9 RID: 2473
			[Token(Token = "0x40009A9")]
			[FieldOffset(Offset = "0x0")]
			public int firstClippedIndex;

			// Token: 0x040009AA RID: 2474
			[Token(Token = "0x40009AA")]
			[FieldOffset(Offset = "0x4")]
			public int firstDegenerateIndex;

			// Token: 0x040009AB RID: 2475
			[Token(Token = "0x40009AB")]
			[FieldOffset(Offset = "0x8")]
			public int lastClippedIndex;

			// Token: 0x040009AC RID: 2476
			[Token(Token = "0x40009AC")]
			[FieldOffset(Offset = "0xC")]
			public int clippedTriangles;

			// Token: 0x040009AD RID: 2477
			[Token(Token = "0x40009AD")]
			[FieldOffset(Offset = "0x10")]
			public int addedTriangles;

			// Token: 0x040009AE RID: 2478
			[Token(Token = "0x40009AE")]
			[FieldOffset(Offset = "0x14")]
			public int degenerateTriangles;
		}

		// Token: 0x0200029F RID: 671
		[Token(Token = "0x200029F")]
		private enum VertexClipEdge
		{
			// Token: 0x040009B0 RID: 2480
			[Token(Token = "0x40009B0")]
			None,
			// Token: 0x040009B1 RID: 2481
			[Token(Token = "0x40009B1")]
			Left,
			// Token: 0x040009B2 RID: 2482
			[Token(Token = "0x40009B2")]
			Top,
			// Token: 0x040009B3 RID: 2483
			[Token(Token = "0x40009B3")]
			Right = 4,
			// Token: 0x040009B4 RID: 2484
			[Token(Token = "0x40009B4")]
			Bottom = 8
		}
	}
}
