using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200003C RID: 60
	[Token(Token = "0x200003C")]
	[Preserve]
	internal sealed class MotionBlurRenderer : PostProcessEffectRenderer<MotionBlur>
	{
		// Token: 0x0600006F RID: 111 RVA: 0x000022AC File Offset: 0x000004AC
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x54AE00", Offset = "0x549A00", VA = "0x18054AE00", Slot = "5")]
		public override DepthTextureMode GetCameraFlags()
		{
			return DepthTextureMode.None;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x5824400", Offset = "0x5823000", VA = "0x185824400")]
		private void CreateTemporaryRT(PostProcessRenderContext context, int nameID, int width, int height, RenderTextureFormat RTFormat)
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x58244E0", Offset = "0x58230E0", VA = "0x1858244E0", Slot = "8")]
		public override void Render(PostProcessRenderContext context)
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x58250D0", Offset = "0x5823CD0", VA = "0x1858250D0")]
		public MotionBlurRenderer()
		{
		}

		// Token: 0x0200003D RID: 61
		[Token(Token = "0x200003D")]
		private enum Pass
		{
			// Token: 0x040000D0 RID: 208
			[Token(Token = "0x40000D0")]
			VelocitySetup,
			// Token: 0x040000D1 RID: 209
			[Token(Token = "0x40000D1")]
			TileMax1,
			// Token: 0x040000D2 RID: 210
			[Token(Token = "0x40000D2")]
			TileMax2,
			// Token: 0x040000D3 RID: 211
			[Token(Token = "0x40000D3")]
			TileMaxV,
			// Token: 0x040000D4 RID: 212
			[Token(Token = "0x40000D4")]
			NeighborMax,
			// Token: 0x040000D5 RID: 213
			[Token(Token = "0x40000D5")]
			Reconstruction
		}
	}
}
