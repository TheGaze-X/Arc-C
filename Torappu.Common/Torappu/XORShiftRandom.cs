using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020000A8 RID: 168
	[Token(Token = "0x20000A8")]
	public struct XORShiftRandom
	{
		// Token: 0x06000424 RID: 1060 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000424")]
		[Address(RVA = "0x55125A0", Offset = "0x55111A0", VA = "0x1855125A0")]
		public XORShiftRandom(uint seed)
		{
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x000052C4 File Offset: 0x000034C4
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x5512540", Offset = "0x5511140", VA = "0x185512540")]
		public uint Get()
		{
			return 0U;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x000052DC File Offset: 0x000034DC
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x55124F0", Offset = "0x55110F0", VA = "0x1855124F0")]
		public float GetFloat()
		{
			return 0f;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x000052F4 File Offset: 0x000034F4
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x55124B0", Offset = "0x55110B0", VA = "0x1855124B0")]
		public byte GetByte()
		{
			return 0;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0000530C File Offset: 0x0000350C
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x5512580", Offset = "0x5511180", VA = "0x185512580")]
		private static float _GetFloatFromInt(uint value)
		{
			return 0f;
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00005324 File Offset: 0x00003524
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x5512570", Offset = "0x5511170", VA = "0x185512570")]
		private static byte _GetByteFromInt(uint value)
		{
			return 0;
		}

		// Token: 0x0400043F RID: 1087
		[Token(Token = "0x400043F")]
		[FieldOffset(Offset = "0x0")]
		private uint x;

		// Token: 0x04000440 RID: 1088
		[Token(Token = "0x4000440")]
		[FieldOffset(Offset = "0x4")]
		private uint y;

		// Token: 0x04000441 RID: 1089
		[Token(Token = "0x4000441")]
		[FieldOffset(Offset = "0x8")]
		private uint z;

		// Token: 0x04000442 RID: 1090
		[Token(Token = "0x4000442")]
		[FieldOffset(Offset = "0xC")]
		private uint w;
	}
}
