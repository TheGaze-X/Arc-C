using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000084 RID: 132
	[Token(Token = "0x2000084")]
	public sealed class BloomComponent : PostProcessingComponentRenderTexture<BloomModel>
	{
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060002BC RID: 700 RVA: 0x00002CE8 File Offset: 0x00000EE8
		[Token(Token = "0x17000034")]
		public override bool active
		{
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x52F29F0", Offset = "0x52F15F0", VA = "0x1852F29F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x52F1DF0", Offset = "0x52F09F0", VA = "0x1852F1DF0")]
		public void Prepare(RenderTexture source, Material uberMaterial, Texture autoExposure)
		{
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x52F2960", Offset = "0x52F1560", VA = "0x1852F2960")]
		public BloomComponent()
		{
		}

		// Token: 0x0400035E RID: 862
		[Token(Token = "0x400035E")]
		private const int k_MaxPyramidBlurLevel = 16;

		// Token: 0x0400035F RID: 863
		[Token(Token = "0x400035F")]
		[FieldOffset(Offset = "0x20")]
		private readonly RenderTexture[] m_BlurBuffer1;

		// Token: 0x04000360 RID: 864
		[Token(Token = "0x4000360")]
		[FieldOffset(Offset = "0x28")]
		private readonly RenderTexture[] m_BlurBuffer2;

		// Token: 0x02000085 RID: 133
		[Token(Token = "0x2000085")]
		private static class Uniforms
		{
			// Token: 0x04000361 RID: 865
			[Token(Token = "0x4000361")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly int _AutoExposure;

			// Token: 0x04000362 RID: 866
			[Token(Token = "0x4000362")]
			[FieldOffset(Offset = "0x4")]
			internal static readonly int _Threshold;

			// Token: 0x04000363 RID: 867
			[Token(Token = "0x4000363")]
			[FieldOffset(Offset = "0x8")]
			internal static readonly int _Curve;

			// Token: 0x04000364 RID: 868
			[Token(Token = "0x4000364")]
			[FieldOffset(Offset = "0xC")]
			internal static readonly int _PrefilterOffs;

			// Token: 0x04000365 RID: 869
			[Token(Token = "0x4000365")]
			[FieldOffset(Offset = "0x10")]
			internal static readonly int _SampleScale;

			// Token: 0x04000366 RID: 870
			[Token(Token = "0x4000366")]
			[FieldOffset(Offset = "0x14")]
			internal static readonly int _BaseTex;

			// Token: 0x04000367 RID: 871
			[Token(Token = "0x4000367")]
			[FieldOffset(Offset = "0x18")]
			internal static readonly int _BloomTex;

			// Token: 0x04000368 RID: 872
			[Token(Token = "0x4000368")]
			[FieldOffset(Offset = "0x1C")]
			internal static readonly int _Bloom_Settings;

			// Token: 0x04000369 RID: 873
			[Token(Token = "0x4000369")]
			[FieldOffset(Offset = "0x20")]
			internal static readonly int _Bloom_DirtTex;

			// Token: 0x0400036A RID: 874
			[Token(Token = "0x400036A")]
			[FieldOffset(Offset = "0x24")]
			internal static readonly int _Bloom_DirtIntensity;
		}
	}
}
