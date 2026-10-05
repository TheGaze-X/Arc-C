using System;
using Il2CppDummyDll;

namespace SharpNeatLib.Maths
{
	// Token: 0x0200007C RID: 124
	[Token(Token = "0x200007C")]
	public class FastRandom
	{
		// Token: 0x060002A4 RID: 676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x52F9230", Offset = "0x52F7E30", VA = "0x1852F9230")]
		public FastRandom()
		{
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x52F9270", Offset = "0x52F7E70", VA = "0x1852F9270")]
		public FastRandom(int seed)
		{
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x52F9210", Offset = "0x52F7E10", VA = "0x1852F9210")]
		public void Reinitialise(int seed)
		{
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00002BC8 File Offset: 0x00000DC8
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x52F8F60", Offset = "0x52F7B60", VA = "0x1852F8F60")]
		public int Next()
		{
			return 0;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00002BE0 File Offset: 0x00000DE0
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x52F9100", Offset = "0x52F7D00", VA = "0x1852F9100")]
		public int Next(int upperBound)
		{
			return 0;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00002BF8 File Offset: 0x00000DF8
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x52F8FB0", Offset = "0x52F7BB0", VA = "0x1852F8FB0")]
		public int Next(int lowerBound, int upperBound)
		{
			return 0;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00002C10 File Offset: 0x00000E10
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x52F8E90", Offset = "0x52F7A90", VA = "0x1852F8E90")]
		public double NextDouble()
		{
			return 0.0;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x52F8D10", Offset = "0x52F7910", VA = "0x1852F8D10")]
		public void NextBytes(byte[] buffer)
		{
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00002C28 File Offset: 0x00000E28
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x52F8F20", Offset = "0x52F7B20", VA = "0x1852F8F20")]
		public uint NextUInt()
		{
			return 0U;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00002C40 File Offset: 0x00000E40
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x52F8EE0", Offset = "0x52F7AE0", VA = "0x1852F8EE0")]
		public int NextInt()
		{
			return 0;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00002C58 File Offset: 0x00000E58
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x52F8CB0", Offset = "0x52F78B0", VA = "0x1852F8CB0")]
		public bool NextBool()
		{
			return default(bool);
		}

		// Token: 0x0400033F RID: 831
		[Token(Token = "0x400033F")]
		private const double REAL_UNIT_INT = 4.656612873077393E-10;

		// Token: 0x04000340 RID: 832
		[Token(Token = "0x4000340")]
		private const double REAL_UNIT_UINT = 2.3283064365386963E-10;

		// Token: 0x04000341 RID: 833
		[Token(Token = "0x4000341")]
		private const uint Y = 842502087U;

		// Token: 0x04000342 RID: 834
		[Token(Token = "0x4000342")]
		private const uint Z = 3579807591U;

		// Token: 0x04000343 RID: 835
		[Token(Token = "0x4000343")]
		private const uint W = 273326509U;

		// Token: 0x04000344 RID: 836
		[Token(Token = "0x4000344")]
		[FieldOffset(Offset = "0x10")]
		private uint x;

		// Token: 0x04000345 RID: 837
		[Token(Token = "0x4000345")]
		[FieldOffset(Offset = "0x14")]
		private uint y;

		// Token: 0x04000346 RID: 838
		[Token(Token = "0x4000346")]
		[FieldOffset(Offset = "0x18")]
		private uint z;

		// Token: 0x04000347 RID: 839
		[Token(Token = "0x4000347")]
		[FieldOffset(Offset = "0x1C")]
		private uint w;

		// Token: 0x04000348 RID: 840
		[Token(Token = "0x4000348")]
		[FieldOffset(Offset = "0x20")]
		private uint bitBuffer;

		// Token: 0x04000349 RID: 841
		[Token(Token = "0x4000349")]
		[FieldOffset(Offset = "0x24")]
		private uint bitMask;
	}
}
