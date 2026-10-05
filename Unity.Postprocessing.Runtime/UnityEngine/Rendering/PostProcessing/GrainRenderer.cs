using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	[Preserve]
	internal sealed class GrainRenderer : PostProcessEffectRenderer<Grain>
	{
		// Token: 0x06000050 RID: 80 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x5821610", Offset = "0x5820210", VA = "0x185821610", Slot = "8")]
		public override void Render(PostProcessRenderContext context)
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002204 File Offset: 0x00000404
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x5821540", Offset = "0x5820140", VA = "0x185821540")]
		private RenderTextureFormat GetLookupFormat()
		{
			return RenderTextureFormat.ARGB32;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x5821590", Offset = "0x5820190", VA = "0x185821590", Slot = "7")]
		public override void Release()
		{
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x5821D80", Offset = "0x5820980", VA = "0x185821D80")]
		public GrainRenderer()
		{
		}

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x20")]
		private RenderTexture m_GrainLookupRT;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		private const int k_SampleCount = 1024;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x28")]
		private int m_SampleIndex;
	}
}
