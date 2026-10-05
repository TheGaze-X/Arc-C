using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200002F")]
	[PostProcess(typeof(HGMobileBloomRenderer), "HG/Mobile Bloom", true)]
	[Serializable]
	public sealed class HGMobileBloom : PostProcessEffectSettings
	{
		// Token: 0x0600005D RID: 93 RVA: 0x0000224C File Offset: 0x0000044C
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x581A760", Offset = "0x5819360", VA = "0x18581A760", Slot = "4")]
		public override bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			return default(bool);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x5822FF0", Offset = "0x5821BF0", VA = "0x185822FF0")]
		public HGMobileBloom()
		{
		}

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x30")]
		public FloatParameter sepBlurSpread;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x38")]
		[PPMin(0f)]
		[Tooltip("Strength of the bloom filter. Values higher than 1 will make bloom contribute more energy to the final render.")]
		public FloatParameter intensity;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x40")]
		[PPMin(0f)]
		[Tooltip("Filters out pixels under this level of brightness. Value is in gamma-space.")]
		public FloatParameter threshold;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x48")]
		[Range(1f, 4f)]
		[Tooltip("Blur iteration")]
		public IntParameter iteration;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x50")]
		[Range(-1f, 1f)]
		[Tooltip("Distorts the bloom to give an anamorphic look. Negative values distort vertically, positive values distort horizontally.")]
		public FloatParameter anamorphicRatio;
	}
}
