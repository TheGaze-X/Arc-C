using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000048 RID: 72
	[Token(Token = "0x2000048")]
	[Preserve]
	internal sealed class ScreenSpaceReflectionsRenderer : PostProcessEffectRenderer<ScreenSpaceReflections>
	{
		// Token: 0x06000096 RID: 150 RVA: 0x0000236C File Offset: 0x0000056C
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x54AE00", Offset = "0x549A00", VA = "0x18054AE00", Slot = "5")]
		public override DepthTextureMode GetCameraFlags()
		{
			return DepthTextureMode.None;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x582A440", Offset = "0x5829040", VA = "0x18582A440")]
		internal void CheckRT(ref RenderTexture rt, int width, int height, FilterMode filterMode, bool useMipMap)
		{
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x582A6F0", Offset = "0x58292F0", VA = "0x18582A6F0", Slot = "8")]
		public override void Render(PostProcessRenderContext context)
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x582A660", Offset = "0x5829260", VA = "0x18582A660", Slot = "7")]
		public override void Release()
		{
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x582BBB0", Offset = "0x582A7B0", VA = "0x18582BBB0")]
		public ScreenSpaceReflectionsRenderer()
		{
		}

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x20")]
		private RenderTexture m_Resolve;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x28")]
		private RenderTexture m_History;

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x30")]
		private int[] m_MipIDs;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x38")]
		private readonly ScreenSpaceReflectionsRenderer.QualityPreset[] m_Presets;

		// Token: 0x02000049 RID: 73
		[Token(Token = "0x2000049")]
		private class QualityPreset
		{
			// Token: 0x0600009B RID: 155 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public QualityPreset()
			{
			}

			// Token: 0x04000113 RID: 275
			[Token(Token = "0x4000113")]
			[FieldOffset(Offset = "0x10")]
			public int maximumIterationCount;

			// Token: 0x04000114 RID: 276
			[Token(Token = "0x4000114")]
			[FieldOffset(Offset = "0x14")]
			public float thickness;

			// Token: 0x04000115 RID: 277
			[Token(Token = "0x4000115")]
			[FieldOffset(Offset = "0x18")]
			public ScreenSpaceReflectionResolution downsampling;
		}

		// Token: 0x0200004A RID: 74
		[Token(Token = "0x200004A")]
		private enum Pass
		{
			// Token: 0x04000117 RID: 279
			[Token(Token = "0x4000117")]
			Test,
			// Token: 0x04000118 RID: 280
			[Token(Token = "0x4000118")]
			Resolve,
			// Token: 0x04000119 RID: 281
			[Token(Token = "0x4000119")]
			Reproject,
			// Token: 0x0400011A RID: 282
			[Token(Token = "0x400011A")]
			Composite
		}
	}
}
