using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	[PostProcess(typeof(HGGreyScaleRenderer), "HG/GreyScale", true)]
	[Serializable]
	public sealed class HGGreyScale : PostProcessEffectSettings
	{
		// Token: 0x06000058 RID: 88 RVA: 0x00002234 File Offset: 0x00000434
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x58223F0", Offset = "0x5820FF0", VA = "0x1858223F0", Slot = "4")]
		public override bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			return default(bool);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x5822410", Offset = "0x5821010", VA = "0x185822410")]
		public HGGreyScale()
		{
		}

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public FloatParameter intensity;
	}
}
