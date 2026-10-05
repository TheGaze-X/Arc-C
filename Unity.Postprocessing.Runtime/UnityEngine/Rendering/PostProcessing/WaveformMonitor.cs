using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	[Serializable]
	public sealed class WaveformMonitor : Monitor
	{
		// Token: 0x060000CB RID: 203 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x584B1F0", Offset = "0x5849DF0", VA = "0x18584B1F0", Slot = "7")]
		internal override void OnDisable()
		{
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000024EC File Offset: 0x000006EC
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "5")]
		internal override bool NeedsHalfRes()
		{
			return default(bool);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002504 File Offset: 0x00000704
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x584C660", Offset = "0x584B260", VA = "0x18584C660", Slot = "4")]
		internal override bool ShaderResourcesAvailable(PostProcessRenderContext context)
		{
			return default(bool);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x584BBF0", Offset = "0x584A7F0", VA = "0x18584BBF0", Slot = "8")]
		internal override void Render(PostProcessRenderContext context)
		{
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x584C720", Offset = "0x584B320", VA = "0x18584C720")]
		public WaveformMonitor()
		{
		}

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x20")]
		public float exposure;

		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x24")]
		public int height;

		// Token: 0x0400015E RID: 350
		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x28")]
		private ComputeBuffer m_Data;

		// Token: 0x0400015F RID: 351
		[Token(Token = "0x400015F")]
		private const int k_ThreadGroupSize = 256;

		// Token: 0x04000160 RID: 352
		[Token(Token = "0x4000160")]
		private const int k_ThreadGroupSizeX = 16;

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		private const int k_ThreadGroupSizeY = 16;
	}
}
