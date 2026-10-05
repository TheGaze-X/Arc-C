using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	[Preserve]
	[Serializable]
	internal sealed class Dithering
	{
		// Token: 0x06000047 RID: 71 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x5820B20", Offset = "0x581F720", VA = "0x185820B20")]
		internal void Render(PostProcessRenderContext context)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x5820DD0", Offset = "0x581F9D0", VA = "0x185820DD0")]
		public Dithering()
		{
		}

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x10")]
		private int m_NoiseTextureIndex;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x18")]
		private Random m_Random;
	}
}
