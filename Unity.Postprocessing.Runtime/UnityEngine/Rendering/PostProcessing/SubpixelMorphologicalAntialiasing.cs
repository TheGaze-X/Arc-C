using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	[Preserve]
	[Serializable]
	public sealed class SubpixelMorphologicalAntialiasing
	{
		// Token: 0x0600009C RID: 156 RVA: 0x00002384 File Offset: 0x00000584
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x582C340", Offset = "0x582AF40", VA = "0x18582C340")]
		public bool IsSupported()
		{
			return default(bool);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x582C390", Offset = "0x582AF90", VA = "0x18582C390")]
		internal void Render(PostProcessRenderContext context)
		{
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2646870", Offset = "0x2645470", VA = "0x182646870")]
		public SubpixelMorphologicalAntialiasing()
		{
		}

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x10")]
		[Tooltip("Lower quality is faster at the expense of visual quality (Low = ~60%, Medium = ~80%).")]
		public SubpixelMorphologicalAntialiasing.Quality quality;

		// Token: 0x0200004C RID: 76
		[Token(Token = "0x200004C")]
		private enum Pass
		{
			// Token: 0x0400011D RID: 285
			[Token(Token = "0x400011D")]
			EdgeDetection,
			// Token: 0x0400011E RID: 286
			[Token(Token = "0x400011E")]
			BlendWeights = 3,
			// Token: 0x0400011F RID: 287
			[Token(Token = "0x400011F")]
			NeighborhoodBlending = 6
		}

		// Token: 0x0200004D RID: 77
		[Token(Token = "0x200004D")]
		public enum Quality
		{
			// Token: 0x04000121 RID: 289
			[Token(Token = "0x4000121")]
			Low,
			// Token: 0x04000122 RID: 290
			[Token(Token = "0x4000122")]
			Medium,
			// Token: 0x04000123 RID: 291
			[Token(Token = "0x4000123")]
			High
		}
	}
}
