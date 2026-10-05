using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	[Preserve]
	[Serializable]
	internal sealed class MultiScaleVO : IAmbientOcclusionMethod
	{
		// Token: 0x06000073 RID: 115 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x5828E70", Offset = "0x5827A70", VA = "0x185828E70")]
		public MultiScaleVO(AmbientOcclusion settings)
		{
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000022C4 File Offset: 0x000004C4
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "4")]
		public DepthTextureMode GetCameraFlags()
		{
			return DepthTextureMode.None;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30")]
		public void SetResources(PostProcessResources resources)
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x58253F0", Offset = "0x5823FF0", VA = "0x1858253F0")]
		private void Alloc(CommandBuffer cmd, int id, MultiScaleVO.MipLevel size, RenderTextureFormat format, bool uav)
		{
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x5825290", Offset = "0x5823E90", VA = "0x185825290")]
		private void AllocArray(CommandBuffer cmd, int id, MultiScaleVO.MipLevel size, RenderTextureFormat format, bool uav)
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x5828840", Offset = "0x5827440", VA = "0x185828840")]
		private void Release(CommandBuffer cmd, int id)
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000022DC File Offset: 0x000004DC
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x58255C0", Offset = "0x58241C0", VA = "0x1858255C0")]
		private Vector4 CalculateZBufferParams(Camera camera)
		{
			return default(Vector4);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000022F4 File Offset: 0x000004F4
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x5825550", Offset = "0x5824150", VA = "0x185825550")]
		private float CalculateTanHalfFovHeight(Camera camera)
		{
			return 0f;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000230C File Offset: 0x0000050C
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x5826720", Offset = "0x5825320", VA = "0x185826720")]
		private Vector2 GetSize(MultiScaleVO.MipLevel mip)
		{
			return default(Vector2);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002324 File Offset: 0x00000524
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x58266C0", Offset = "0x58252C0", VA = "0x1858266C0")]
		private Vector3 GetSizeArray(MultiScaleVO.MipLevel mip)
		{
			return default(Vector3);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x5825B40", Offset = "0x5824740", VA = "0x185825B40")]
		public void GenerateAOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, RenderTargetIdentifier? depthMap, bool invert, bool isMSAA)
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x58268F0", Offset = "0x58254F0", VA = "0x1858268F0")]
		private void PushAllocCommands(CommandBuffer cmd, bool isMSAA)
		{
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x5826F30", Offset = "0x5825B30", VA = "0x185826F30")]
		private void PushDownsampleCommands(CommandBuffer cmd, Camera camera, RenderTargetIdentifier? depthMap, bool isMSAA)
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x5827B00", Offset = "0x5826700", VA = "0x185827B00")]
		private void PushRenderCommands(CommandBuffer cmd, int source, int destination, Vector3 sourceSize, float tanHalfFovH, bool isMSAA)
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x58282D0", Offset = "0x5826ED0", VA = "0x1858282D0")]
		private void PushUpsampleCommands(CommandBuffer cmd, int lowResDepth, int interleavedAO, int highResDepth, int? highResAO, RenderTargetIdentifier dest, Vector3 lowResDepthSize, Vector2 highResDepthSize, bool isMSAA, bool invert = false)
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x58278E0", Offset = "0x58264E0", VA = "0x1858278E0")]
		private void PushReleaseCommands(CommandBuffer cmd)
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x5826780", Offset = "0x5825380", VA = "0x185826780")]
		private void PreparePropertySheet(PostProcessRenderContext context)
		{
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x5825670", Offset = "0x5824270", VA = "0x185825670")]
		private void CheckAOTexture(PostProcessRenderContext context)
		{
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x5826E70", Offset = "0x5825A70", VA = "0x185826E70")]
		private void PushDebug(PostProcessRenderContext context)
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x58288E0", Offset = "0x58274E0", VA = "0x1858288E0", Slot = "5")]
		public void RenderAfterOpaque(PostProcessRenderContext context)
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x5828D00", Offset = "0x5827900", VA = "0x185828D00", Slot = "6")]
		public void RenderAmbientOnly(PostProcessRenderContext context)
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x58258E0", Offset = "0x58244E0", VA = "0x1858258E0", Slot = "7")]
		public void CompositeAmbientOnly(PostProcessRenderContext context)
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x5828870", Offset = "0x5827470", VA = "0x185828870", Slot = "8")]
		public void Release()
		{
		}

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x10")]
		private readonly float[] m_SampleThickness;

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x18")]
		private readonly float[] m_InvThicknessTable;

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x20")]
		private readonly float[] m_SampleWeightTable;

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x28")]
		private readonly int[] m_ScaledWidths;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x30")]
		private readonly int[] m_ScaledHeights;

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x38")]
		private AmbientOcclusion m_Settings;

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x40")]
		private PropertySheet m_PropertySheet;

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x48")]
		private PostProcessResources m_Resources;

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x50")]
		private RenderTexture m_AmbientOnlyAO;

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x58")]
		private readonly RenderTargetIdentifier[] m_MRT;

		// Token: 0x0200003F RID: 63
		[Token(Token = "0x200003F")]
		internal enum MipLevel
		{
			// Token: 0x040000E1 RID: 225
			[Token(Token = "0x40000E1")]
			Original,
			// Token: 0x040000E2 RID: 226
			[Token(Token = "0x40000E2")]
			L1,
			// Token: 0x040000E3 RID: 227
			[Token(Token = "0x40000E3")]
			L2,
			// Token: 0x040000E4 RID: 228
			[Token(Token = "0x40000E4")]
			L3,
			// Token: 0x040000E5 RID: 229
			[Token(Token = "0x40000E5")]
			L4,
			// Token: 0x040000E6 RID: 230
			[Token(Token = "0x40000E6")]
			L5,
			// Token: 0x040000E7 RID: 231
			[Token(Token = "0x40000E7")]
			L6
		}

		// Token: 0x02000040 RID: 64
		[Token(Token = "0x2000040")]
		private enum Pass
		{
			// Token: 0x040000E9 RID: 233
			[Token(Token = "0x40000E9")]
			DepthCopy,
			// Token: 0x040000EA RID: 234
			[Token(Token = "0x40000EA")]
			CompositionDeferred,
			// Token: 0x040000EB RID: 235
			[Token(Token = "0x40000EB")]
			CompositionForward,
			// Token: 0x040000EC RID: 236
			[Token(Token = "0x40000EC")]
			DebugOverlay
		}
	}
}
