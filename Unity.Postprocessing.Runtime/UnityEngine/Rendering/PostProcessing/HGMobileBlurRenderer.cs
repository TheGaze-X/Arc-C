using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000037 RID: 55
	[Token(Token = "0x2000037")]
	[Preserve]
	internal sealed class HGMobileBlurRenderer : PostProcessEffectRenderer<HGMobileBlur>
	{
		// Token: 0x06000066 RID: 102 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x5823AF0", Offset = "0x58226F0", VA = "0x185823AF0")]
		public HGMobileBlurRenderer()
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x5823150", Offset = "0x5821D50", VA = "0x185823150", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x5823260", Offset = "0x5821E60", VA = "0x185823260", Slot = "8")]
		public override void Render(PostProcessRenderContext context)
		{
		}

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x20")]
		internal int[] m_samplerTexOneQuater;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x28")]
		internal float[] m_spread;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x30")]
		private int downScale;

		// Token: 0x02000038 RID: 56
		[Token(Token = "0x2000038")]
		private enum Pass
		{
			// Token: 0x040000C4 RID: 196
			[Token(Token = "0x40000C4")]
			DownSample,
			// Token: 0x040000C5 RID: 197
			[Token(Token = "0x40000C5")]
			MobileBlur,
			// Token: 0x040000C6 RID: 198
			[Token(Token = "0x40000C6")]
			UpSampleMix
		}
	}
}
