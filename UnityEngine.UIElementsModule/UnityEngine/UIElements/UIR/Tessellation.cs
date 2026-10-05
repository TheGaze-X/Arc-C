using System;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020002B2 RID: 690
	[Token(Token = "0x20002B2")]
	internal static class Tessellation
	{
		// Token: 0x060012CF RID: 4815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012CF")]
		[Address(RVA = "0x5B48130", Offset = "0x5B46D30", VA = "0x185B48130")]
		public static void TessellateRect(MeshGenerationContextUtils.RectangleParams rectParams, float posZ, MeshBuilder.AllocMeshData meshAlloc, bool computeUVs)
		{
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D0")]
		[Address(RVA = "0x5B46A30", Offset = "0x5B45630", VA = "0x185B46A30")]
		public static void TessellateQuad(MeshGenerationContextUtils.RectangleParams rectParams, float posZ, MeshBuilder.AllocMeshData meshAlloc)
		{
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D1")]
		[Address(RVA = "0x5B443A0", Offset = "0x5B42FA0", VA = "0x185B443A0")]
		public static void TessellateBorder(MeshGenerationContextUtils.BorderParams borderParams, float posZ, MeshBuilder.AllocMeshData meshAlloc)
		{
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D2")]
		[Address(RVA = "0x5B49D80", Offset = "0x5B48980", VA = "0x185B49D80")]
		private static void TessellateRoundedCorners(ref MeshGenerationContextUtils.RectangleParams rectParams, float posZ, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D3")]
		[Address(RVA = "0x5B492B0", Offset = "0x5B47EB0", VA = "0x185B492B0")]
		private static void TessellateRoundedBorders(ref MeshGenerationContextUtils.BorderParams border, float posZ, MeshWriteData mesh, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D4")]
		[Address(RVA = "0x5B49880", Offset = "0x5B48480", VA = "0x185B49880")]
		private static void TessellateRoundedCorner(Rect rect, Color32 color, float posZ, Vector2 radius, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D5")]
		[Address(RVA = "0x5B488D0", Offset = "0x5B474D0", VA = "0x185B488D0")]
		private static void TessellateRoundedBorder(Rect rect, Color32 leftColor, Color32 topColor, float posZ, Vector2 radius, float leftWidth, float topWidth, MeshWriteData mesh, ColorPage leftColorPage, ColorPage topColorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x00009EA0 File Offset: 0x000080A0
		[Token(Token = "0x60012D6")]
		[Address(RVA = "0x5B43ED0", Offset = "0x5B42AD0", VA = "0x185B43ED0")]
		private static Vector2 IntersectLines(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3)
		{
			return default(Vector2);
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x00009EB8 File Offset: 0x000080B8
		[Token(Token = "0x60012D7")]
		[Address(RVA = "0x5B44070", Offset = "0x5B42C70", VA = "0x185B44070")]
		private static int LooseCompare(float a, float b)
		{
			return 0;
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D8")]
		[Address(RVA = "0x5B44FC0", Offset = "0x5B43BC0", VA = "0x185B44FC0")]
		private static void TessellateComplexBorderCorner(Rect rect, Vector2 radius, float leftWidth, float topWidth, Color32 leftColor, Color32 topColor, float posZ, MeshWriteData mesh, ColorPage leftColorPage, ColorPage topColorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D9")]
		[Address(RVA = "0x5B47C80", Offset = "0x5B46880", VA = "0x185B47C80")]
		private static void TessellateQuad(Rect rect, Color32 color, float posZ, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012DA")]
		[Address(RVA = "0x5B47060", Offset = "0x5B45C60", VA = "0x185B47060")]
		private static void TessellateQuad(Rect rect, Tessellation.Edges smoothedEdges, Color32 color, float posZ, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x00009ED0 File Offset: 0x000080D0
		[Token(Token = "0x60012DB")]
		[Address(RVA = "0x5B43570", Offset = "0x5B42170", VA = "0x185B43570")]
		private static int EdgesCount(Tessellation.Edges edges)
		{
			return 0;
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012DC")]
		[Address(RVA = "0x5B47140", Offset = "0x5B45D40", VA = "0x185B47140")]
		private unsafe static void TessellateQuad(Rect rect, Tessellation.Edges smoothedEdges, Vector2* offsets, Color32 color, float posZ, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012DD")]
		[Address(RVA = "0x5B435B0", Offset = "0x5B421B0", VA = "0x185B435B0")]
		private static void EncodeStraightArc(ref Vertex v0, ref Vertex v1, ref Vertex center, float radius)
		{
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012DE")]
		[Address(RVA = "0x5B43970", Offset = "0x5B42570", VA = "0x185B43970")]
		private static void ExpandTriangle(ref Vector3 v0, ref Vector3 v1, Vector3 center, float factor)
		{
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012DF")]
		[Address(RVA = "0x5B46150", Offset = "0x5B44D50", VA = "0x185B46150")]
		private static void TessellateQuadSingleEdge(Rect rect, Tessellation.Edges smoothedEdge, Color32 color, float posZ, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012E0")]
		[Address(RVA = "0x5B4A230", Offset = "0x5B48E30", VA = "0x185B4A230")]
		private static void TessellateStraightBorder(Rect rect, Tessellation.Edges smoothedEdge, float miterOffset, Color color, float posZ, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x00009EE8 File Offset: 0x000080E8
		[Token(Token = "0x60012E1")]
		[Address(RVA = "0x5B43C30", Offset = "0x5B42830", VA = "0x185B43C30")]
		private static Vector4 GetInterpolatedCircle(Vector2 p, ref Vertex v0, ref Vertex v1, ref Vertex v2)
		{
			return default(Vector4);
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012E2")]
		[Address(RVA = "0x5B43100", Offset = "0x5B41D00", VA = "0x185B43100")]
		private static void ComputeBarycentricCoordinates(Vector2 p, Vector2 a, Vector2 b, Vector2 c, out float u, out float v, out float w)
		{
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012E3")]
		[Address(RVA = "0x5B45870", Offset = "0x5B44470", VA = "0x185B45870")]
		private static void TessellateFilledFan(Vector2 center, Vector2 radius, Vector2 miterOffset, float leftWidth, float topWidth, Color32 leftColor, Color32 topColor, float posZ, MeshWriteData mesh, ColorPage leftColorPage, ColorPage topColorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012E4")]
		[Address(RVA = "0x5B44AA0", Offset = "0x5B436A0", VA = "0x185B44AA0")]
		private static void TessellateBorderedFan(Vector2 center, Vector2 outerRadius, float leftWidth, float topWidth, Color32 leftColor, Color32 topColor, float posZ, MeshWriteData mesh, ColorPage leftColorPage, ColorPage topColorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly)
		{
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012E5")]
		[Address(RVA = "0x5B44120", Offset = "0x5B42D20", VA = "0x185B44120")]
		private static void MirrorVertices(Rect rect, NativeSlice<Vertex> vertices, int vertexStart, int vertexCount, bool flipHorizontal)
		{
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012E6")]
		[Address(RVA = "0x5B43B50", Offset = "0x5B42750", VA = "0x185B43B50")]
		private static void FlipWinding(NativeSlice<ushort> indices, int indexStart, int indexCount)
		{
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012E7")]
		[Address(RVA = "0x5B43270", Offset = "0x5B41E70", VA = "0x185B43270")]
		private static void ComputeUVs(Rect tessellatedRect, Rect textureRect, Rect uvRegion, NativeSlice<Vertex> vertices)
		{
		}

		// Token: 0x04000A62 RID: 2658
		[Token(Token = "0x4000A62")]
		[FieldOffset(Offset = "0x0")]
		internal static float kEpsilon;

		// Token: 0x04000A63 RID: 2659
		[Token(Token = "0x4000A63")]
		[FieldOffset(Offset = "0x4")]
		internal static float kUnusedArc;

		// Token: 0x04000A64 RID: 2660
		[Token(Token = "0x4000A64")]
		[FieldOffset(Offset = "0x8")]
		internal static ushort kSubdivisions;

		// Token: 0x04000A65 RID: 2661
		[Token(Token = "0x4000A65")]
		[FieldOffset(Offset = "0x10")]
		private static ProfilerMarker s_MarkerTessellateRect;

		// Token: 0x04000A66 RID: 2662
		[Token(Token = "0x4000A66")]
		[FieldOffset(Offset = "0x18")]
		private static ProfilerMarker s_MarkerTessellateBorder;

		// Token: 0x04000A67 RID: 2663
		[Token(Token = "0x4000A67")]
		[FieldOffset(Offset = "0x20")]
		private static Tessellation.Edges[] s_AllEdges;

		// Token: 0x020002B3 RID: 691
		[Token(Token = "0x20002B3")]
		internal enum Edges
		{
			// Token: 0x04000A69 RID: 2665
			[Token(Token = "0x4000A69")]
			None,
			// Token: 0x04000A6A RID: 2666
			[Token(Token = "0x4000A6A")]
			Left,
			// Token: 0x04000A6B RID: 2667
			[Token(Token = "0x4000A6B")]
			Top,
			// Token: 0x04000A6C RID: 2668
			[Token(Token = "0x4000A6C")]
			Right = 4,
			// Token: 0x04000A6D RID: 2669
			[Token(Token = "0x4000A6D")]
			Bottom = 8,
			// Token: 0x04000A6E RID: 2670
			[Token(Token = "0x4000A6E")]
			All = 15
		}
	}
}
