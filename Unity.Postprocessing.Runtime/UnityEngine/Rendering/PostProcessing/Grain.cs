using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	[PostProcess(typeof(GrainRenderer), "Unity/Grain", true)]
	[Serializable]
	public sealed class Grain : PostProcessEffectSettings
	{
		// Token: 0x0600004E RID: 78 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x581A760", Offset = "0x5819360", VA = "0x18581A760", Slot = "4")]
		public override bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			return default(bool);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x5821DC0", Offset = "0x58209C0", VA = "0x185821DC0")]
		public Grain()
		{
		}

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Enable the use of colored grain.")]
		public BoolParameter colored;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		[Tooltip("Grain strength. Higher values mean more visible grain.")]
		public FloatParameter intensity;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x40")]
		[Range(0.3f, 3f)]
		[Tooltip("Grain particle size.")]
		public FloatParameter size;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		[DisplayName("Luminance Contribution")]
		[Tooltip("Controls the noise response curve based on scene luminance. Lower values mean less noise in dark areas.")]
		public FloatParameter lumContrib;
	}
}
