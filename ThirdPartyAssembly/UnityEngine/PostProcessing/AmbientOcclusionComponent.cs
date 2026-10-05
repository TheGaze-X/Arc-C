using System;
using Il2CppDummyDll;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000081 RID: 129
	[Token(Token = "0x2000081")]
	public sealed class AmbientOcclusionComponent : PostProcessingComponentCommandBuffer<AmbientOcclusionModel>
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x00002C70 File Offset: 0x00000E70
		[Token(Token = "0x17000031")]
		private AmbientOcclusionComponent.OcclusionSource occlusionSource
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x52F1880", Offset = "0x52F0480", VA = "0x1852F1880")]
			get
			{
				return AmbientOcclusionComponent.OcclusionSource.DepthTexture;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x00002C88 File Offset: 0x00000E88
		[Token(Token = "0x17000032")]
		private bool ambientOnlySupported
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x52F17E0", Offset = "0x52F03E0", VA = "0x1852F17E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x00002CA0 File Offset: 0x00000EA0
		[Token(Token = "0x17000033")]
		public override bool active
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x52F1770", Offset = "0x52F0370", VA = "0x1852F1770", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00002CB8 File Offset: 0x00000EB8
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x52F0C10", Offset = "0x52EF810", VA = "0x1852F0C10", Slot = "4")]
		public override DepthTextureMode GetCameraFlags()
		{
			return DepthTextureMode.None;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x52F0C50", Offset = "0x52EF850", VA = "0x1852F0C50", Slot = "11")]
		public override string GetName()
		{
			return null;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00002CD0 File Offset: 0x00000ED0
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x52F0BB0", Offset = "0x52EF7B0", VA = "0x1852F0BB0", Slot = "10")]
		public override CameraEvent GetCameraEvent()
		{
			return CameraEvent.BeforeDepthTexture;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x52F0C80", Offset = "0x52EF880", VA = "0x1852F0C80", Slot = "12")]
		public override void PopulateCommandBuffer(CommandBuffer cb)
		{
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x52F1680", Offset = "0x52F0280", VA = "0x1852F1680")]
		public AmbientOcclusionComponent()
		{
		}

		// Token: 0x0400034E RID: 846
		[Token(Token = "0x400034E")]
		private const string k_BlitShaderString = "Hidden/Post FX/Blit";

		// Token: 0x0400034F RID: 847
		[Token(Token = "0x400034F")]
		private const string k_ShaderString = "Hidden/Post FX/Ambient Occlusion";

		// Token: 0x04000350 RID: 848
		[Token(Token = "0x4000350")]
		[FieldOffset(Offset = "0x20")]
		private readonly RenderTargetIdentifier[] m_MRT;

		// Token: 0x02000082 RID: 130
		[Token(Token = "0x2000082")]
		private static class Uniforms
		{
			// Token: 0x04000351 RID: 849
			[Token(Token = "0x4000351")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly int _Intensity;

			// Token: 0x04000352 RID: 850
			[Token(Token = "0x4000352")]
			[FieldOffset(Offset = "0x4")]
			internal static readonly int _Radius;

			// Token: 0x04000353 RID: 851
			[Token(Token = "0x4000353")]
			[FieldOffset(Offset = "0x8")]
			internal static readonly int _Downsample;

			// Token: 0x04000354 RID: 852
			[Token(Token = "0x4000354")]
			[FieldOffset(Offset = "0xC")]
			internal static readonly int _SampleCount;

			// Token: 0x04000355 RID: 853
			[Token(Token = "0x4000355")]
			[FieldOffset(Offset = "0x10")]
			internal static readonly int _OcclusionTexture1;

			// Token: 0x04000356 RID: 854
			[Token(Token = "0x4000356")]
			[FieldOffset(Offset = "0x14")]
			internal static readonly int _OcclusionTexture2;

			// Token: 0x04000357 RID: 855
			[Token(Token = "0x4000357")]
			[FieldOffset(Offset = "0x18")]
			internal static readonly int _OcclusionTexture;

			// Token: 0x04000358 RID: 856
			[Token(Token = "0x4000358")]
			[FieldOffset(Offset = "0x1C")]
			internal static readonly int _MainTex;

			// Token: 0x04000359 RID: 857
			[Token(Token = "0x4000359")]
			[FieldOffset(Offset = "0x20")]
			internal static readonly int _TempRT;
		}

		// Token: 0x02000083 RID: 131
		[Token(Token = "0x2000083")]
		private enum OcclusionSource
		{
			// Token: 0x0400035B RID: 859
			[Token(Token = "0x400035B")]
			DepthTexture,
			// Token: 0x0400035C RID: 860
			[Token(Token = "0x400035C")]
			DepthNormalsTexture,
			// Token: 0x0400035D RID: 861
			[Token(Token = "0x400035D")]
			GBuffer
		}
	}
}
