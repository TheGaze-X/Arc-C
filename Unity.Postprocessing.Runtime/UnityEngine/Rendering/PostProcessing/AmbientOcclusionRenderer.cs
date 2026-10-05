using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	[Preserve]
	internal sealed class AmbientOcclusionRenderer : PostProcessEffectRenderer<AmbientOcclusion>
	{
		// Token: 0x06000017 RID: 23 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x58186B0", Offset = "0x58172B0", VA = "0x1858186B0", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x5818950", Offset = "0x5817550", VA = "0x185818950")]
		public bool IsAmbientOnly(PostProcessRenderContext context)
		{
			return default(bool);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x5818650", Offset = "0x5817250", VA = "0x185818650")]
		public IAmbientOcclusionMethod Get()
		{
			return null;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x5818440", Offset = "0x5817040", VA = "0x185818440", Slot = "5")]
		public override DepthTextureMode GetCameraFlags()
		{
			return DepthTextureMode.None;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x58189F0", Offset = "0x58175F0", VA = "0x1858189F0", Slot = "7")]
		public override void Release()
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x58185E0", Offset = "0x58171E0", VA = "0x1858185E0")]
		public ScalableAO GetScalableAO()
		{
			return null;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x5818570", Offset = "0x5817170", VA = "0x185818570")]
		public MultiScaleVO GetMultiScaleVO()
		{
			return null;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
		public override void Render(PostProcessRenderContext context)
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x5818B30", Offset = "0x5817730", VA = "0x185818B30")]
		public AmbientOcclusionRenderer()
		{
		}

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x20")]
		private IAmbientOcclusionMethod[] m_Methods;
	}
}
