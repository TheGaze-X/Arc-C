using System;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR.Implementation
{
	// Token: 0x020002D9 RID: 729
	[Token(Token = "0x20002D9")]
	internal static class CommandGenerator
	{
		// Token: 0x060013A7 RID: 5031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A7")]
		[Address(RVA = "0x5A54FB0", Offset = "0x5A53BB0", VA = "0x185A54FB0")]
		private static void GetVerticesTransformInfo(VisualElement ve, out Matrix4x4 transform)
		{
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A8")]
		[Address(RVA = "0x5A53870", Offset = "0x5A52470", VA = "0x185A53870")]
		internal static void ComputeTransformMatrix(VisualElement ve, VisualElement ancestor, out Matrix4x4 result)
		{
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x0000A410 File Offset: 0x00008610
		[Token(Token = "0x60013A9")]
		[Address(RVA = "0x5A55720", Offset = "0x5A54320", VA = "0x185A55720")]
		private static bool IsParentOrAncestorOf(this VisualElement ve, VisualElement child)
		{
			return default(bool);
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x0000A428 File Offset: 0x00008628
		[Token(Token = "0x60013AA")]
		[Address(RVA = "0x5A55C40", Offset = "0x5A54840", VA = "0x185A55C40")]
		public static UIRStylePainter.ClosingInfo PaintElement(RenderChain renderChain, VisualElement ve, ref ChainBuilderStats stats)
		{
			return default(UIRStylePainter.ClosingInfo);
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60013AB")]
		[Address(RVA = "0x5A54190", Offset = "0x5A52D90", VA = "0x185A54190")]
		private static Material CreateBlitShader(float colorConversion)
		{
			return null;
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60013AC")]
		[Address(RVA = "0x5A54C80", Offset = "0x5A53880", VA = "0x185A54C80")]
		private static Material GetBlitMaterial(VisualElement.RenderTargetMode mode)
		{
			return null;
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013AD")]
		[Address(RVA = "0x5A535D0", Offset = "0x5A521D0", VA = "0x185A535D0")]
		public static void ClosePaintElement(VisualElement ve, UIRStylePainter.ClosingInfo closingInfo, RenderChain renderChain, ref ChainBuilderStats stats)
		{
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013AE")]
		[Address(RVA = "0x5A58030", Offset = "0x5A56C30", VA = "0x185A58030")]
		private static void UpdateOrAllocate(ref MeshHandle data, int vertexCount, int indexCount, UIRenderDevice device, out NativeSlice<Vertex> verts, out NativeSlice<ushort> indices, out ushort indexOffset, ref ChainBuilderStats stats)
		{
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013AF")]
		[Address(RVA = "0x5A53D00", Offset = "0x5A52900", VA = "0x185A53D00")]
		private static void CopyTransformVertsPos(NativeSlice<Vertex> source, NativeSlice<Vertex> target, Matrix4x4 mat, Color32 xformClipPages, Color32 ids, Color32 addFlags, Color32 opacityPage, Color32 textCoreSettingsPage, bool isText, float textureId)
		{
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B0")]
		[Address(RVA = "0x5A53A50", Offset = "0x5A52650", VA = "0x185A53A50")]
		private static void CopyTransformVertsPosAndVec(NativeSlice<Vertex> source, NativeSlice<Vertex> target, Matrix4x4 mat, Color32 xformClipPages, Color32 ids, Color32 addFlags, Color32 opacityPage, Color32 textCoreSettingsPage, bool isText, float textureId)
		{
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B1")]
		[Address(RVA = "0x5A53F40", Offset = "0x5A52B40", VA = "0x185A53F40")]
		private static void CopyTriangleIndicesFlipWindingOrder(NativeSlice<ushort> source, NativeSlice<ushort> target, int indexOffset)
		{
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B2")]
		[Address(RVA = "0x5A540D0", Offset = "0x5A52CD0", VA = "0x185A540D0")]
		private static void CopyTriangleIndices(NativeSlice<ushort> source, NativeSlice<ushort> target, int indexOffset)
		{
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x0000A440 File Offset: 0x00008640
		[Token(Token = "0x60013B3")]
		[Address(RVA = "0x5A557C0", Offset = "0x5A543C0", VA = "0x185A557C0")]
		public static bool NudgeVerticesToNewSpace(VisualElement ve, UIRenderDevice device)
		{
			return default(bool);
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B4")]
		[Address(RVA = "0x5A543A0", Offset = "0x5A52FA0", VA = "0x185A543A0")]
		private static void DoNudgeVertices(VisualElement ve, UIRenderDevice device, MeshHandle mesh, ref Matrix4x4 nudgeTransform)
		{
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60013B5")]
		[Address(RVA = "0x5A55520", Offset = "0x5A54120", VA = "0x185A55520")]
		private static RenderChainCommand InjectMeshDrawCommand(RenderChain renderChain, VisualElement ve, ref RenderChainCommand cmdPrev, ref RenderChainCommand cmdNext, MeshHandle mesh, int indexCount, int indexOffset, Material material, TextureId texture, Texture font, int stencilRef)
		{
			return null;
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60013B6")]
		[Address(RVA = "0x5A55290", Offset = "0x5A53E90", VA = "0x185A55290")]
		private static RenderChainCommand InjectClosingMeshDrawCommand(RenderChain renderChain, VisualElement ve, ref RenderChainCommand cmdPrev, ref RenderChainCommand cmdNext, MeshHandle mesh, int indexCount, int indexOffset, Material material, TextureId texture, Texture font, int stencilRef)
		{
			return null;
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B7")]
		[Address(RVA = "0x5A549D0", Offset = "0x5A535D0", VA = "0x185A549D0")]
		private static void FindCommandInsertionPoint(VisualElement ve, out RenderChainCommand prev, out RenderChainCommand next)
		{
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B8")]
		[Address(RVA = "0x5A547A0", Offset = "0x5A533A0", VA = "0x185A547A0")]
		private static void FindClosingCommandInsertionPoint(VisualElement ve, out RenderChainCommand prev, out RenderChainCommand next)
		{
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B9")]
		[Address(RVA = "0x5A55400", Offset = "0x5A54000", VA = "0x185A55400")]
		private static void InjectCommandInBetween(RenderChain renderChain, RenderChainCommand cmd, ref RenderChainCommand prev, ref RenderChainCommand next)
		{
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013BA")]
		[Address(RVA = "0x5A55140", Offset = "0x5A53D40", VA = "0x185A55140")]
		private static void InjectClosingCommandInBetween(RenderChain renderChain, RenderChainCommand cmd, ref RenderChainCommand prev, ref RenderChainCommand next)
		{
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013BB")]
		[Address(RVA = "0x5A57C70", Offset = "0x5A56870", VA = "0x185A57C70")]
		public static void ResetCommands(RenderChain renderChain, VisualElement ve)
		{
		}

		// Token: 0x04000B71 RID: 2929
		[Token(Token = "0x4000B71")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ProfilerMarker k_ConvertEntriesToCommandsMarker;

		// Token: 0x04000B72 RID: 2930
		[Token(Token = "0x4000B72")]
		[FieldOffset(Offset = "0x8")]
		private static readonly ProfilerMarker k_NudgeVerticesMarker;

		// Token: 0x04000B73 RID: 2931
		[Token(Token = "0x4000B73")]
		[FieldOffset(Offset = "0x10")]
		private static readonly ProfilerMarker k_ComputeTransformMatrixMarker;

		// Token: 0x04000B74 RID: 2932
		[Token(Token = "0x4000B74")]
		[FieldOffset(Offset = "0x18")]
		private static Material s_blitMaterial_LinearToGamma;

		// Token: 0x04000B75 RID: 2933
		[Token(Token = "0x4000B75")]
		[FieldOffset(Offset = "0x20")]
		private static Material s_blitMaterial_GammaToLinear;

		// Token: 0x04000B76 RID: 2934
		[Token(Token = "0x4000B76")]
		[FieldOffset(Offset = "0x28")]
		private static Material s_blitMaterial_NoChange;

		// Token: 0x04000B77 RID: 2935
		[Token(Token = "0x4000B77")]
		[FieldOffset(Offset = "0x30")]
		private static Shader s_blitShader;
	}
}
