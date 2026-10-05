using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000024 RID: 36
	[Token(Token = "0x2000024")]
	[Preserve]
	internal sealed class DepthOfFieldRenderer : PostProcessEffectRenderer<DepthOfField>
	{
		// Token: 0x06000040 RID: 64 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x5820820", Offset = "0x581F420", VA = "0x185820820")]
		public DepthOfFieldRenderer()
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "5")]
		public override DepthTextureMode GetCameraFlags()
		{
			return DepthTextureMode.None;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x5820790", Offset = "0x581F390", VA = "0x185820790")]
		private RenderTextureFormat SelectFormat(RenderTextureFormat primary, RenderTextureFormat secondary)
		{
			return RenderTextureFormat.ARGB32;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x581F620", Offset = "0x581E220", VA = "0x18581F620")]
		private float CalculateMaxCoCRadius(int screenHeight)
		{
			return 0f;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x581F6A0", Offset = "0x581E2A0", VA = "0x18581F6A0")]
		private RenderTexture CheckHistory(int eye, int id, PostProcessRenderContext context, RenderTextureFormat format)
		{
			return null;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x581FA30", Offset = "0x581E630", VA = "0x18581FA30", Slot = "8")]
		public override void Render(PostProcessRenderContext context)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x581F900", Offset = "0x581E500", VA = "0x18581F900", Slot = "7")]
		public override void Release()
		{
		}

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		private const int k_NumEyes = 2;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		private const int k_NumCoCHistoryTextures = 2;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x20")]
		private readonly RenderTexture[][] m_CoCHistoryTextures;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x28")]
		private int[] m_HistoryPingPong;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		private const float k_FilmHeight = 0.024f;

		// Token: 0x02000025 RID: 37
		[Token(Token = "0x2000025")]
		private enum Pass
		{
			// Token: 0x0400008F RID: 143
			[Token(Token = "0x400008F")]
			CoCCalculation,
			// Token: 0x04000090 RID: 144
			[Token(Token = "0x4000090")]
			CoCTemporalFilter,
			// Token: 0x04000091 RID: 145
			[Token(Token = "0x4000091")]
			DownsampleAndPrefilter,
			// Token: 0x04000092 RID: 146
			[Token(Token = "0x4000092")]
			BokehSmallKernel,
			// Token: 0x04000093 RID: 147
			[Token(Token = "0x4000093")]
			BokehMediumKernel,
			// Token: 0x04000094 RID: 148
			[Token(Token = "0x4000094")]
			BokehLargeKernel,
			// Token: 0x04000095 RID: 149
			[Token(Token = "0x4000095")]
			BokehVeryLargeKernel,
			// Token: 0x04000096 RID: 150
			[Token(Token = "0x4000096")]
			PostFilter,
			// Token: 0x04000097 RID: 151
			[Token(Token = "0x4000097")]
			Combine,
			// Token: 0x04000098 RID: 152
			[Token(Token = "0x4000098")]
			DebugOverlay
		}
	}
}
