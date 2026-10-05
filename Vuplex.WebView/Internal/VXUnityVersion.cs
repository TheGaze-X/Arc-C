using System;
using Il2CppDummyDll;

namespace Vuplex.WebView.Internal
{
	// Token: 0x02000098 RID: 152
	[Token(Token = "0x2000098")]
	public class VXUnityVersion
	{
		// Token: 0x06000481 RID: 1153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000481")]
		[Address(RVA = "0x5BD3F30", Offset = "0x5BD2B30", VA = "0x185BD3F30")]
		public VXUnityVersion()
		{
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700005D")]
		public static VXUnityVersion Instance
		{
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x5BD40D0", Offset = "0x5BD2CD0", VA = "0x185BD40D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400021C RID: 540
		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x10")]
		public readonly int Major;

		// Token: 0x0400021D RID: 541
		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x14")]
		public readonly int Minor;

		// Token: 0x0400021E RID: 542
		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x18")]
		public readonly int Patch;

		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x20")]
		public readonly string String;

		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x0")]
		private static VXUnityVersion _instance;
	}
}
