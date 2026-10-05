using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	[Preserve]
	internal sealed class HGMobileBloomRenderer : PostProcessEffectRenderer<HGMobileBloom>
	{
		// Token: 0x0600005F RID: 95 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x5822490", Offset = "0x5821090", VA = "0x185822490", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x5822550", Offset = "0x5821150", VA = "0x185822550", Slot = "8")]
		public override void Render(PostProcessRenderContext context)
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x5822FB0", Offset = "0x5821BB0", VA = "0x185822FB0")]
		public HGMobileBloomRenderer()
		{
		}

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		public const RenderTextureFormat RT_FORMAT = RenderTextureFormat.RGB111110Float;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x20")]
		internal int[] m_samplerTex;

		// Token: 0x02000031 RID: 49
		[Token(Token = "0x2000031")]
		private enum Pass
		{
			// Token: 0x040000B2 RID: 178
			[Token(Token = "0x40000B2")]
			MobileDownsample,
			// Token: 0x040000B3 RID: 179
			[Token(Token = "0x40000B3")]
			MobileBlur,
			// Token: 0x040000B4 RID: 180
			[Token(Token = "0x40000B4")]
			MobileBlurH,
			// Token: 0x040000B5 RID: 181
			[Token(Token = "0x40000B5")]
			MobileBlurV
		}
	}
}
