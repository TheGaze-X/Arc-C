using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200008C RID: 140
	[Token(Token = "0x200008C")]
	internal sealed class LogHistogram
	{
		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000200 RID: 512 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x06000201 RID: 513 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000035")]
		public ComputeBuffer data
		{
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x58309B0", Offset = "0x582F5B0", VA = "0x1858309B0")]
		public void Generate(PostProcessRenderContext context)
		{
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002D8C File Offset: 0x00000F8C
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x5830ED0", Offset = "0x582FAD0", VA = "0x185830ED0")]
		public Vector4 GetHistogramScaleOffsetRes(PostProcessRenderContext context)
		{
			return default(Vector4);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x5830FD0", Offset = "0x582FBD0", VA = "0x185830FD0")]
		public void Release()
		{
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LogHistogram()
		{
		}

		// Token: 0x040002B9 RID: 697
		[Token(Token = "0x40002B9")]
		public const int rangeMin = -9;

		// Token: 0x040002BA RID: 698
		[Token(Token = "0x40002BA")]
		public const int rangeMax = 9;

		// Token: 0x040002BB RID: 699
		[Token(Token = "0x40002BB")]
		private const int k_Bins = 128;
	}
}
