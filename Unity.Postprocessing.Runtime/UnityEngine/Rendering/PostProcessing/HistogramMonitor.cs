using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000054 RID: 84
	[Token(Token = "0x2000054")]
	[Serializable]
	public sealed class HistogramMonitor : Monitor
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x582F7F0", Offset = "0x582E3F0", VA = "0x18582F7F0", Slot = "7")]
		internal override void OnDisable()
		{
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002444 File Offset: 0x00000644
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "5")]
		internal override bool NeedsHalfRes()
		{
			return default(bool);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000245C File Offset: 0x0000065C
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x5830070", Offset = "0x582EC70", VA = "0x185830070", Slot = "4")]
		internal override bool ShaderResourcesAvailable(PostProcessRenderContext context)
		{
			return default(bool);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x582F870", Offset = "0x582E470", VA = "0x18582F870", Slot = "8")]
		internal override void Render(PostProcessRenderContext context)
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x5830130", Offset = "0x582ED30", VA = "0x185830130")]
		public HistogramMonitor()
		{
		}

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x20")]
		public int width;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x24")]
		public int height;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x28")]
		public HistogramMonitor.Channel channel;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x30")]
		private ComputeBuffer m_Data;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		private const int k_NumBins = 256;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		private const int k_ThreadGroupSizeX = 16;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		private const int k_ThreadGroupSizeY = 16;

		// Token: 0x02000055 RID: 85
		[Token(Token = "0x2000055")]
		public enum Channel
		{
			// Token: 0x04000149 RID: 329
			[Token(Token = "0x4000149")]
			Red,
			// Token: 0x0400014A RID: 330
			[Token(Token = "0x400014A")]
			Green,
			// Token: 0x0400014B RID: 331
			[Token(Token = "0x400014B")]
			Blue,
			// Token: 0x0400014C RID: 332
			[Token(Token = "0x400014C")]
			Master
		}
	}
}
