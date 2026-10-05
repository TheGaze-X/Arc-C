using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	[Preserve]
	internal sealed class ColorGradingRenderer : PostProcessEffectRenderer<ColorGrading>
	{
		// Token: 0x06000030 RID: 48 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x581E310", Offset = "0x581CF10", VA = "0x18581E310", Slot = "8")]
		public override void Render(PostProcessRenderContext context)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x581B290", Offset = "0x5819E90", VA = "0x18581B290")]
		private void RenderExternalPipeline3D(PostProcessRenderContext context)
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x581C580", Offset = "0x581B180", VA = "0x18581C580")]
		private void RenderHDRPipeline3D(PostProcessRenderContext context)
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x581B550", Offset = "0x581A150", VA = "0x18581B550")]
		private void RenderHDRPipeline2D(PostProcessRenderContext context)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x581D500", Offset = "0x581C100", VA = "0x18581D500")]
		private void RenderLDRPipeline2D(PostProcessRenderContext context)
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x581A8B0", Offset = "0x58194B0", VA = "0x18581A8B0")]
		private void CheckInternalLogLut()
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x581AAA0", Offset = "0x58196A0", VA = "0x18581AAA0")]
		private void CheckInternalStripLut()
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x581AC80", Offset = "0x5819880", VA = "0x18581AC80")]
		private Texture2D GetCurveTexture(bool hdr)
		{
			return null;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x581B180", Offset = "0x5819D80", VA = "0x18581B180")]
		private static bool IsRenderTextureFormatSupportedForLinearFiltering(RenderTextureFormat format)
		{
			return default(bool);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000212C File Offset: 0x0000032C
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x581B0B0", Offset = "0x5819CB0", VA = "0x18581B0B0")]
		private static RenderTextureFormat GetLutFormat()
		{
			return RenderTextureFormat.ARGB32;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002144 File Offset: 0x00000344
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x581AC50", Offset = "0x5819850", VA = "0x18581AC50")]
		private static TextureFormat GetCurveFormat()
		{
			return (TextureFormat)0;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x581B1E0", Offset = "0x5819DE0", VA = "0x18581B1E0", Slot = "7")]
		public override void Release()
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x581E480", Offset = "0x581D080", VA = "0x18581E480")]
		public ColorGradingRenderer()
		{
		}

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x20")]
		private Texture2D m_GradingCurves;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x28")]
		private readonly Color[] m_Pixels;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x30")]
		private RenderTexture m_InternalLdrLut;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x38")]
		private RenderTexture m_InternalLogLut;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		private const int k_Lut2DSize = 16;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		private const int k_Lut3DSize = 33;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x40")]
		private readonly HableCurve m_HableCurve;

		// Token: 0x02000020 RID: 32
		[Token(Token = "0x2000020")]
		private enum Pass
		{
			// Token: 0x0400007D RID: 125
			[Token(Token = "0x400007D")]
			LutGenLDRFromScratch,
			// Token: 0x0400007E RID: 126
			[Token(Token = "0x400007E")]
			LutGenLDR,
			// Token: 0x0400007F RID: 127
			[Token(Token = "0x400007F")]
			LutGenHDR2D
		}
	}
}
