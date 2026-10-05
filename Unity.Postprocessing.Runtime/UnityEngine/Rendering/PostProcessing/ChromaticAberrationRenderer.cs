using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	[Preserve]
	internal sealed class ChromaticAberrationRenderer : PostProcessEffectRenderer<ChromaticAberration>
	{
		// Token: 0x06000029 RID: 41 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x581A3E0", Offset = "0x5818FE0", VA = "0x18581A3E0", Slot = "8")]
		public override void Render(PostProcessRenderContext context)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x581A370", Offset = "0x5818F70", VA = "0x18581A370", Slot = "7")]
		public override void Release()
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x581A720", Offset = "0x5819320", VA = "0x18581A720")]
		public ChromaticAberrationRenderer()
		{
		}

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x20")]
		private Texture2D m_InternalSpectralLut;
	}
}
