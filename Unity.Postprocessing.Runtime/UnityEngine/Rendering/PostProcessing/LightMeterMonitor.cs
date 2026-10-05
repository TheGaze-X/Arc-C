using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000056 RID: 86
	[Token(Token = "0x2000056")]
	[Serializable]
	public sealed class LightMeterMonitor : Monitor
	{
		// Token: 0x060000B9 RID: 185 RVA: 0x00002474 File Offset: 0x00000674
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x5830850", Offset = "0x582F450", VA = "0x185830850", Slot = "4")]
		internal override bool ShaderResourcesAvailable(PostProcessRenderContext context)
		{
			return default(bool);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x58301C0", Offset = "0x582EDC0", VA = "0x1858301C0", Slot = "8")]
		internal override void Render(PostProcessRenderContext context)
		{
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x5830990", Offset = "0x582F590", VA = "0x185830990")]
		public LightMeterMonitor()
		{
		}

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x20")]
		public int width;

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x24")]
		public int height;

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x28")]
		public bool showCurves;
	}
}
