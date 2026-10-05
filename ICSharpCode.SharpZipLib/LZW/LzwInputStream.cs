using System;
using System.IO;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.LZW
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	public class LzwInputStream : Stream
	{
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00002880 File Offset: 0x00000A80
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003E")]
		public bool IsStreamOwner
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x17F30F0", Offset = "0x17F1CF0", VA = "0x1817F30F0")]
			set
			{
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x4A3F640", Offset = "0x4A3E240", VA = "0x184A3F640")]
		public LzwInputStream(Stream baseInputStream)
		{
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x4A3EA10", Offset = "0x4A3D610", VA = "0x184A3EA10", Slot = "34")]
		public override int ReadByte()
		{
			return 0;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x4A3EAA0", Offset = "0x4A3D6A0", VA = "0x184A3EAA0", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x4A3F470", Offset = "0x4A3E070", VA = "0x184A3F470")]
		private int ResetBuf(int bitPosition)
		{
			return 0;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x4A3E3F0", Offset = "0x4A3CFF0", VA = "0x184A3E3F0")]
		private void Fill()
		{
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x4A3E4E0", Offset = "0x4A3D0E0", VA = "0x184A3E4E0")]
		private void ParseHeader()
		{
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000153 RID: 339 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x1700003F")]
		public override bool CanRead
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x4A3F730", Offset = "0x4A3E330", VA = "0x184A3F730", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000154 RID: 340 RVA: 0x000028F8 File Offset: 0x00000AF8
		[Token(Token = "0x17000040")]
		public override bool CanSeek
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00002910 File Offset: 0x00000B10
		[Token(Token = "0x17000041")]
		public override bool CanWrite
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00002928 File Offset: 0x00000B28
		[Token(Token = "0x17000042")]
		public override long Length
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x4A3F780", Offset = "0x4A3E380", VA = "0x184A3F780", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00002940 File Offset: 0x00000B40
		// (set) Token: 0x06000158 RID: 344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000043")]
		public override long Position
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x4A3F790", Offset = "0x4A3E390", VA = "0x184A3F790", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x4A3F7E0", Offset = "0x4A3E3E0", VA = "0x184A3F7E0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x4A3E4A0", Offset = "0x4A3D0A0", VA = "0x184A3E4A0", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002958 File Offset: 0x00000B58
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x4A3F4C0", Offset = "0x4A3E0C0", VA = "0x184A3F4C0", Slot = "30")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x4A3F520", Offset = "0x4A3E120", VA = "0x184A3F520", Slot = "31")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x4A3F5E0", Offset = "0x4A3E1E0", VA = "0x184A3F5E0", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x4A3F580", Offset = "0x4A3E180", VA = "0x184A3F580", Slot = "37")]
		public override void WriteByte(byte value)
		{
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x4A3E330", Offset = "0x4A3CF30", VA = "0x184A3E330", Slot = "26")]
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x4A3E390", Offset = "0x4A3CF90", VA = "0x184A3E390", Slot = "18")]
		public override void Close()
		{
		}

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		private const int TBL_CLEAR = 256;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		private const int TBL_FIRST = 257;

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		private const int EXTRA = 64;

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x28")]
		private Stream baseInputStream;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x30")]
		private bool isStreamOwner;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x31")]
		private bool isClosed;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x38")]
		private readonly byte[] one;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x40")]
		private bool headerParsed;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x48")]
		private int[] tabPrefix;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x50")]
		private byte[] tabSuffix;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x58")]
		private readonly int[] zeros;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x60")]
		private byte[] stack;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x68")]
		private bool blockMode;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x6C")]
		private int nBits;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x70")]
		private int maxBits;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x74")]
		private int maxMaxCode;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x78")]
		private int maxCode;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x7C")]
		private int bitMask;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x80")]
		private int oldCode;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x84")]
		private byte finChar;

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x88")]
		private int stackP;

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x8C")]
		private int freeEnt;

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x90")]
		private readonly byte[] data;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x98")]
		private int bitPos;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x9C")]
		private int end;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0xA0")]
		private int got;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0xA4")]
		private bool eof;
	}
}
