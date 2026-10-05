using System;
using System.IO;
using Il2CppDummyDll;

namespace Moments.Encoder
{
	// Token: 0x020000F9 RID: 249
	[Token(Token = "0x20000F9")]
	public class LzwEncoder
	{
		// Token: 0x06000436 RID: 1078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x5427CF0", Offset = "0x54268F0", VA = "0x185427CF0")]
		public LzwEncoder(int width, int height, byte[] pixels, int color_depth)
		{
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000437")]
		[Address(RVA = "0x5427420", Offset = "0x5426020", VA = "0x185427420")]
		private void Add(byte c, Stream outs)
		{
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000438")]
		[Address(RVA = "0x5427470", Offset = "0x5426070", VA = "0x185427470")]
		private void ClearTable(Stream outs)
		{
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000439")]
		[Address(RVA = "0x5427C30", Offset = "0x5426830", VA = "0x185427C30")]
		private void ResetCodeTable(int hsize)
		{
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600043A")]
		[Address(RVA = "0x54274D0", Offset = "0x54260D0", VA = "0x1854274D0")]
		private void Compress(int init_bits, Stream outs)
		{
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600043B")]
		[Address(RVA = "0x5427850", Offset = "0x5426450", VA = "0x185427850")]
		public void Encode(Stream os)
		{
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x5427930", Offset = "0x5426530", VA = "0x185427930")]
		private void Flush(Stream outs)
		{
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00003780 File Offset: 0x00001980
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x5427A20", Offset = "0x5426620", VA = "0x185427A20")]
		private int MaxCode(int n_bits)
		{
			return 0;
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00003798 File Offset: 0x00001998
		[Token(Token = "0x600043E")]
		[Address(RVA = "0x5427A30", Offset = "0x5426630", VA = "0x185427A30")]
		private int NextPixel()
		{
			return 0;
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600043F")]
		[Address(RVA = "0x5427AC0", Offset = "0x54266C0", VA = "0x185427AC0")]
		private void Output(int code, Stream outs)
		{
		}

		// Token: 0x04000587 RID: 1415
		[Token(Token = "0x4000587")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int EOF;

		// Token: 0x04000588 RID: 1416
		[Token(Token = "0x4000588")]
		[FieldOffset(Offset = "0x10")]
		private byte[] pixAry;

		// Token: 0x04000589 RID: 1417
		[Token(Token = "0x4000589")]
		[FieldOffset(Offset = "0x18")]
		private int initCodeSize;

		// Token: 0x0400058A RID: 1418
		[Token(Token = "0x400058A")]
		[FieldOffset(Offset = "0x1C")]
		private int curPixel;

		// Token: 0x0400058B RID: 1419
		[Token(Token = "0x400058B")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int BITS;

		// Token: 0x0400058C RID: 1420
		[Token(Token = "0x400058C")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int HSIZE;

		// Token: 0x0400058D RID: 1421
		[Token(Token = "0x400058D")]
		[FieldOffset(Offset = "0x20")]
		private int n_bits;

		// Token: 0x0400058E RID: 1422
		[Token(Token = "0x400058E")]
		[FieldOffset(Offset = "0x24")]
		private int maxbits;

		// Token: 0x0400058F RID: 1423
		[Token(Token = "0x400058F")]
		[FieldOffset(Offset = "0x28")]
		private int maxcode;

		// Token: 0x04000590 RID: 1424
		[Token(Token = "0x4000590")]
		[FieldOffset(Offset = "0x2C")]
		private int maxmaxcode;

		// Token: 0x04000591 RID: 1425
		[Token(Token = "0x4000591")]
		[FieldOffset(Offset = "0x30")]
		private int[] htab;

		// Token: 0x04000592 RID: 1426
		[Token(Token = "0x4000592")]
		[FieldOffset(Offset = "0x38")]
		private int[] codetab;

		// Token: 0x04000593 RID: 1427
		[Token(Token = "0x4000593")]
		[FieldOffset(Offset = "0x40")]
		private int hsize;

		// Token: 0x04000594 RID: 1428
		[Token(Token = "0x4000594")]
		[FieldOffset(Offset = "0x44")]
		private int free_ent;

		// Token: 0x04000595 RID: 1429
		[Token(Token = "0x4000595")]
		[FieldOffset(Offset = "0x48")]
		private bool clear_flg;

		// Token: 0x04000596 RID: 1430
		[Token(Token = "0x4000596")]
		[FieldOffset(Offset = "0x4C")]
		private int g_init_bits;

		// Token: 0x04000597 RID: 1431
		[Token(Token = "0x4000597")]
		[FieldOffset(Offset = "0x50")]
		private int ClearCode;

		// Token: 0x04000598 RID: 1432
		[Token(Token = "0x4000598")]
		[FieldOffset(Offset = "0x54")]
		private int EOFCode;

		// Token: 0x04000599 RID: 1433
		[Token(Token = "0x4000599")]
		[FieldOffset(Offset = "0x58")]
		private int cur_accum;

		// Token: 0x0400059A RID: 1434
		[Token(Token = "0x400059A")]
		[FieldOffset(Offset = "0x5C")]
		private int cur_bits;

		// Token: 0x0400059B RID: 1435
		[Token(Token = "0x400059B")]
		[FieldOffset(Offset = "0x60")]
		private int[] masks;

		// Token: 0x0400059C RID: 1436
		[Token(Token = "0x400059C")]
		[FieldOffset(Offset = "0x68")]
		private int a_count;

		// Token: 0x0400059D RID: 1437
		[Token(Token = "0x400059D")]
		[FieldOffset(Offset = "0x70")]
		private byte[] accum;
	}
}
