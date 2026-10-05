using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000059 RID: 89
	[Token(Token = "0x2000059")]
	[Serializable]
	public sealed class VectorscopeMonitor : Monitor
	{
		// Token: 0x060000C6 RID: 198 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x584B1F0", Offset = "0x5849DF0", VA = "0x18584B1F0", Slot = "7")]
		internal override void OnDisable()
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000024BC File Offset: 0x000006BC
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "5")]
		internal override bool NeedsHalfRes()
		{
			return default(bool);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000024D4 File Offset: 0x000006D4
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x584BB10", Offset = "0x584A710", VA = "0x18584BB10", Slot = "4")]
		internal override bool ShaderResourcesAvailable(PostProcessRenderContext context)
		{
			return default(bool);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x584B270", Offset = "0x5849E70", VA = "0x18584B270", Slot = "8")]
		internal override void Render(PostProcessRenderContext context)
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x584BBD0", Offset = "0x584A7D0", VA = "0x18584BBD0")]
		public VectorscopeMonitor()
		{
		}

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x20")]
		public int size;

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x24")]
		public float exposure;

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x28")]
		private ComputeBuffer m_Data;

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		private const int k_ThreadGroupSizeX = 16;

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		private const int k_ThreadGroupSizeY = 16;
	}
}
