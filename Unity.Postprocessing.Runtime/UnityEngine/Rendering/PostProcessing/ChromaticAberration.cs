using System;
using Il2CppDummyDll;
using UnityEngine.Serialization;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	[PostProcess(typeof(ChromaticAberrationRenderer), "Unity/Chromatic Aberration", true)]
	[Serializable]
	public sealed class ChromaticAberration : PostProcessEffectSettings
	{
		// Token: 0x06000027 RID: 39 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x581A760", Offset = "0x5819360", VA = "0x18581A760", Slot = "4")]
		public override bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			return default(bool);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x581A7A0", Offset = "0x58193A0", VA = "0x18581A7A0")]
		public ChromaticAberration()
		{
		}

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Shifts the hue of chromatic aberrations.")]
		public TextureParameter spectralLut;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		[Tooltip("Amount of tangential distortion.")]
		public FloatParameter intensity;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x40")]
		[FormerlySerializedAs("mobileOptimized")]
		[Tooltip("Boost performances by lowering the effect quality. This settings is meant to be used on mobile and other low-end platforms but can also provide a nice performance boost on desktops and consoles.")]
		public BoolParameter fastMode;
	}
}
