using System;
using System.Globalization;
using Il2CppDummyDll;

namespace Mono.Globalization.Unicode
{
	// Token: 0x0200005E RID: 94
	[Token(Token = "0x200005E")]
	internal class SortKeyBuffer
	{
		// Token: 0x06000115 RID: 277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SortKeyBuffer(int lcid)
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x4ABB250", Offset = "0x4AB9E50", VA = "0x184ABB250")]
		public void Reset()
		{
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x4ABB060", Offset = "0x4AB9C60", VA = "0x184ABB060")]
		internal void Initialize(System.Globalization.CompareOptions options, int lcid, string s, bool frenchSort)
		{
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x4ABA470", Offset = "0x4AB9070", VA = "0x184ABA470")]
		internal void AppendCJKExtension(byte lv1msb, byte lv1lsb)
		{
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x4ABA550", Offset = "0x4AB9150", VA = "0x184ABA550")]
		internal void AppendKana(byte category, byte lv1, byte lv2, byte lv3, bool isSmallKana, byte markType, bool isKatakana, bool isHalfWidth)
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x4ABA810", Offset = "0x4AB9410", VA = "0x184ABA810")]
		internal void AppendNormal(byte category, byte lv1, byte lv2, byte lv3)
		{
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x4ABA620", Offset = "0x4AB9220", VA = "0x184ABA620")]
		private void AppendLevel5(byte category, byte lv1)
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x4ABA3B0", Offset = "0x4AB8FB0", VA = "0x184ABA3B0")]
		private void AppendBufferPrimitive(byte value, ref byte[] buf, ref int bidx)
		{
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x4ABA9E0", Offset = "0x4AB95E0", VA = "0x184ABA9E0")]
		public System.Globalization.SortKey GetResultAndReset()
		{
			return null;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000029E8 File Offset: 0x00000BE8
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x4ABA990", Offset = "0x4AB9590", VA = "0x184ABA990")]
		private int GetOptimizedLength(byte[] data, int len, byte defaultValue)
		{
			return 0;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x4ABAA10", Offset = "0x4AB9610", VA = "0x184ABAA10")]
		public System.Globalization.SortKey GetResult()
		{
			return null;
		}

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x10")]
		private byte[] l1b;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x18")]
		private byte[] l2b;

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x20")]
		private byte[] l3b;

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x28")]
		private byte[] l4sb;

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x30")]
		private byte[] l4tb;

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x38")]
		private byte[] l4kb;

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x40")]
		private byte[] l4wb;

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x48")]
		private byte[] l5b;

		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x50")]
		private string source;

		// Token: 0x040001B5 RID: 437
		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x58")]
		private int l1;

		// Token: 0x040001B6 RID: 438
		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x5C")]
		private int l2;

		// Token: 0x040001B7 RID: 439
		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x60")]
		private int l3;

		// Token: 0x040001B8 RID: 440
		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x64")]
		private int l4s;

		// Token: 0x040001B9 RID: 441
		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x68")]
		private int l4t;

		// Token: 0x040001BA RID: 442
		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x6C")]
		private int l4k;

		// Token: 0x040001BB RID: 443
		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x70")]
		private int l4w;

		// Token: 0x040001BC RID: 444
		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x74")]
		private int l5;

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x78")]
		private int lcid;

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x7C")]
		private System.Globalization.CompareOptions options;

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x80")]
		private bool processLevel2;

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x81")]
		private bool frenchSort;

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x82")]
		private bool frenchSorted;
	}
}
