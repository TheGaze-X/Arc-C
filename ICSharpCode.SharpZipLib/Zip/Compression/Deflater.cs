using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip.Compression
{
	// Token: 0x0200003C RID: 60
	[Token(Token = "0x200003C")]
	public class Deflater
	{
		// Token: 0x06000268 RID: 616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x4A49890", Offset = "0x4A48490", VA = "0x184A49890")]
		public Deflater()
		{
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x4A49BC0", Offset = "0x4A487C0", VA = "0x184A49BC0")]
		public Deflater(int level)
		{
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x4A498A0", Offset = "0x4A484A0", VA = "0x184A498A0")]
		public Deflater(int level, bool noZlibHeaderOrFooter)
		{
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x4A49460", Offset = "0x4A48060", VA = "0x184A49460")]
		public void Reset()
		{
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600026C RID: 620 RVA: 0x00003270 File Offset: 0x00001470
		[Token(Token = "0x17000087")]
		public int Adler
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x4A49BD0", Offset = "0x4A487D0", VA = "0x184A49BD0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600026D RID: 621 RVA: 0x00003288 File Offset: 0x00001488
		[Token(Token = "0x17000088")]
		public long TotalIn
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x4A49C60", Offset = "0x4A48860", VA = "0x184A49C60")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600026E RID: 622 RVA: 0x000032A0 File Offset: 0x000014A0
		[Token(Token = "0x17000089")]
		public long TotalOut
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x4A49450", Offset = "0x4A48050", VA = "0x184A49450")]
		public void Flush()
		{
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x4A49440", Offset = "0x4A48040", VA = "0x184A49440")]
		public void Finish()
		{
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000271 RID: 625 RVA: 0x000032B8 File Offset: 0x000014B8
		[Token(Token = "0x1700008A")]
		public bool IsFinished
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x4A49C00", Offset = "0x4A48800", VA = "0x184A49C00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000272 RID: 626 RVA: 0x000032D0 File Offset: 0x000014D0
		[Token(Token = "0x1700008B")]
		public bool IsNeedingInput
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x4A49C30", Offset = "0x4A48830", VA = "0x184A49C30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x4A496A0", Offset = "0x4A482A0", VA = "0x184A496A0")]
		public void SetInput(byte[] input)
		{
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x4A49740", Offset = "0x4A48340", VA = "0x184A49740")]
		public void SetInput(byte[] input, int offset, int count)
		{
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x4A497D0", Offset = "0x4A483D0", VA = "0x184A497D0")]
		public void SetLevel(int level)
		{
		}

		// Token: 0x06000276 RID: 630 RVA: 0x000032E8 File Offset: 0x000014E8
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
		public int GetLevel()
		{
			return 0;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x4A49870", Offset = "0x4A48470", VA = "0x184A49870")]
		public void SetStrategy(DeflateStrategy strategy)
		{
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00003300 File Offset: 0x00001500
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x4A49410", Offset = "0x4A48010", VA = "0x184A49410")]
		public int Deflate(byte[] output)
		{
			return 0;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00003318 File Offset: 0x00001518
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x4A48F20", Offset = "0x4A47B20", VA = "0x184A48F20")]
		public int Deflate(byte[] output, int offset, int length)
		{
			return 0;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x4A49610", Offset = "0x4A48210", VA = "0x184A49610")]
		public void SetDictionary(byte[] dictionary)
		{
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x4A49590", Offset = "0x4A48190", VA = "0x184A49590")]
		public void SetDictionary(byte[] dictionary, int index, int count)
		{
		}

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		public const int BEST_COMPRESSION = 9;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		public const int BEST_SPEED = 1;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		public const int DEFAULT_COMPRESSION = -1;

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		public const int NO_COMPRESSION = 0;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		public const int DEFLATED = 8;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		private const int IS_SETDICT = 1;

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		private const int IS_FLUSHING = 4;

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		private const int IS_FINISHING = 8;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		private const int INIT_STATE = 0;

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		private const int SETDICT_STATE = 1;

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		private const int BUSY_STATE = 16;

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		private const int FLUSHING_STATE = 20;

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		private const int FINISHING_STATE = 28;

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		private const int FINISHED_STATE = 30;

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		private const int CLOSED_STATE = 127;

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x10")]
		private int level;

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x14")]
		private bool noZlibHeaderOrFooter;

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x18")]
		private int state;

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x20")]
		private long totalOut;

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x28")]
		private DeflaterPending pending;

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x30")]
		private DeflaterEngine engine;
	}
}
