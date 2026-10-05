using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	[Preserve]
	internal sealed class AutoExposureRenderer : PostProcessEffectRenderer<AutoExposure>
	{
		// Token: 0x06000023 RID: 35 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x5819E10", Offset = "0x5818A10", VA = "0x185819E10")]
		public AutoExposureRenderer()
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x5819260", Offset = "0x5817E60", VA = "0x185819260")]
		private void CheckTexture(int eye, int id)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x5819520", Offset = "0x5818120", VA = "0x185819520", Slot = "8")]
		public override void Render(PostProcessRenderContext context)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x5819450", Offset = "0x5818050", VA = "0x185819450", Slot = "7")]
		public override void Release()
		{
		}

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		private const int k_NumEyes = 2;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		private const int k_NumAutoExposureTextures = 2;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x20")]
		private readonly RenderTexture[][] m_AutoExposurePool;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x28")]
		private int[] m_AutoExposurePingPong;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x30")]
		private RenderTexture m_CurrentAutoExposure;
	}
}
