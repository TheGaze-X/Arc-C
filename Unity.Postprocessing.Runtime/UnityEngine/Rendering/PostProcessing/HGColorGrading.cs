using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200002B RID: 43
	[Token(Token = "0x200002B")]
	[PostProcess(typeof(HGColorGradingRenderer), "HG/Color Grading Lookup", true)]
	[Serializable]
	public sealed class HGColorGrading : PostProcessEffectSettings
	{
		// Token: 0x06000054 RID: 84 RVA: 0x0000221C File Offset: 0x0000041C
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x5822160", Offset = "0x5820D60", VA = "0x185822160", Slot = "4")]
		public override bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			return default(bool);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x58221F0", Offset = "0x5820DF0", VA = "0x1858221F0")]
		public HGColorGrading()
		{
		}

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x30")]
		[DisplayName("Runtime Dynamic")]
		[Tooltip("是否允许runtime修改colorGrading的程度")]
		public BoolParameter runtimeDynamic;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("静态配置的colorGrading程度")]
		[DisplayName("Lut Contribution")]
		[Range(0f, 1f)]
		public FloatParameter lutContribution;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x40")]
		[DisplayName("Lookup Texture")]
		[Tooltip("A custom 3D log-encoded texture.")]
		public TextureParameter externalLut;
	}
}
