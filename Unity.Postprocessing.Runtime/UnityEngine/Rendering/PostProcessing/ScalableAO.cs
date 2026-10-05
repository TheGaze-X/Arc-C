using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	[Preserve]
	[Serializable]
	internal sealed class ScalableAO : IAmbientOcclusionMethod
	{
		// Token: 0x0600008A RID: 138 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x582A270", Offset = "0x5828E70", VA = "0x18582A270")]
		public ScalableAO(AmbientOcclusion settings)
		{
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000233C File Offset: 0x0000053C
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x54B800", Offset = "0x54A400", VA = "0x18054B800", Slot = "4")]
		public DepthTextureMode GetCameraFlags()
		{
			return DepthTextureMode.None;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x58295B0", Offset = "0x58281B0", VA = "0x1858295B0")]
		private void DoLazyInitialization(PostProcessRenderContext context)
		{
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x5829B50", Offset = "0x5828750", VA = "0x185829B50")]
		private void Render(PostProcessRenderContext context, CommandBuffer cmd, int occlusionSource)
		{
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x5829850", Offset = "0x5828450", VA = "0x185829850", Slot = "5")]
		public void RenderAfterOpaque(PostProcessRenderContext context)
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x5829AB0", Offset = "0x58286B0", VA = "0x185829AB0", Slot = "6")]
		public void RenderAmbientOnly(PostProcessRenderContext context)
		{
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x5829350", Offset = "0x5827F50", VA = "0x185829350", Slot = "7")]
		public void CompositeAmbientOnly(PostProcessRenderContext context)
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x58297E0", Offset = "0x58283E0", VA = "0x1858297E0", Slot = "8")]
		public void Release()
		{
		}

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x10")]
		private RenderTexture m_Result;

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x18")]
		private PropertySheet m_PropertySheet;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x20")]
		private AmbientOcclusion m_Settings;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x28")]
		private readonly RenderTargetIdentifier[] m_MRT;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x30")]
		private readonly int[] m_SampleCount;

		// Token: 0x02000042 RID: 66
		[Token(Token = "0x2000042")]
		private enum Pass
		{
			// Token: 0x040000F3 RID: 243
			[Token(Token = "0x40000F3")]
			OcclusionEstimationForward,
			// Token: 0x040000F4 RID: 244
			[Token(Token = "0x40000F4")]
			OcclusionEstimationDeferred,
			// Token: 0x040000F5 RID: 245
			[Token(Token = "0x40000F5")]
			HorizontalBlurForward,
			// Token: 0x040000F6 RID: 246
			[Token(Token = "0x40000F6")]
			HorizontalBlurDeferred,
			// Token: 0x040000F7 RID: 247
			[Token(Token = "0x40000F7")]
			VerticalBlur,
			// Token: 0x040000F8 RID: 248
			[Token(Token = "0x40000F8")]
			CompositionForward,
			// Token: 0x040000F9 RID: 249
			[Token(Token = "0x40000F9")]
			CompositionDeferred,
			// Token: 0x040000FA RID: 250
			[Token(Token = "0x40000FA")]
			DebugOverlay
		}
	}
}
