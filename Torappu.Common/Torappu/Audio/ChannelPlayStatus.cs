using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.Audio
{
	// Token: 0x02000259 RID: 601
	[Token(Token = "0x2000259")]
	public struct ChannelPlayStatus
	{
		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000DC5 RID: 3525 RVA: 0x00008E4C File Offset: 0x0000704C
		// (set) Token: 0x06000DC6 RID: 3526 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x1700019F")]
		public bool isEmpty
		{
			[Token(Token = "0x6000DC5")]
			[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6000DC6")]
			[Address(RVA = "0xFEDED0", Offset = "0xFECAD0", VA = "0x180FEDED0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x04000E65 RID: 3685
		[Token(Token = "0x4000E65")]
		[FieldOffset(Offset = "0x0")]
		public static ChannelPlayStatus EMPTY;

		// Token: 0x04000E67 RID: 3687
		[Token(Token = "0x4000E67")]
		[FieldOffset(Offset = "0x8")]
		public double realStartDspTime;

		// Token: 0x04000E68 RID: 3688
		[Token(Token = "0x4000E68")]
		[FieldOffset(Offset = "0x10")]
		public int playingSourceIndex;

		// Token: 0x04000E69 RID: 3689
		[Token(Token = "0x4000E69")]
		[FieldOffset(Offset = "0x14")]
		public int playingSourceTimeSamples;
	}
}
