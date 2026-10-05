using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare.CriMana
{
	// Token: 0x02000130 RID: 304
	[Token(Token = "0x2000130")]
	[StructLayout(0)]
	public class FrameInfo
	{
		// Token: 0x060008B4 RID: 2228 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FrameInfo()
		{
		}

		// Token: 0x0400059E RID: 1438
		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int frameNo;

		// Token: 0x0400059F RID: 1439
		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int frameNoPerFile;

		// Token: 0x040005A0 RID: 1440
		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint width;

		// Token: 0x040005A1 RID: 1441
		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint height;

		// Token: 0x040005A2 RID: 1442
		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public uint dispWidth;

		// Token: 0x040005A3 RID: 1443
		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public uint dispHeight;

		// Token: 0x040005A4 RID: 1444
		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public uint numImages;

		// Token: 0x040005A5 RID: 1445
		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public uint framerateN;

		// Token: 0x040005A6 RID: 1446
		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public uint framerateD;

		// Token: 0x040005A7 RID: 1447
		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private uint _reserved1;

		// Token: 0x040005A8 RID: 1448
		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ulong time;

		// Token: 0x040005A9 RID: 1449
		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ulong tunit;

		// Token: 0x040005AA RID: 1450
		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public uint cntConcatenatedMovie;

		// Token: 0x040005AB RID: 1451
		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AlphaType alphaType;

		// Token: 0x040005AC RID: 1452
		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public uint cntSkippedFrames;

		// Token: 0x040005AD RID: 1453
		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public uint totalFramesPerFile;
	}
}
