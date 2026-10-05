using System;
using System.IO;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams
{
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000039")]
	public class InflaterInputBuffer
	{
		// Token: 0x06000241 RID: 577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x4A4D6F0", Offset = "0x4A4C2F0", VA = "0x184A4D6F0")]
		public InflaterInputBuffer(Stream stream)
		{
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x4A4D650", Offset = "0x4A4C250", VA = "0x184A4D650")]
		public InflaterInputBuffer(Stream stream, int bufferSize)
		{
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000243 RID: 579 RVA: 0x00003090 File Offset: 0x00001290
		[Token(Token = "0x1700007E")]
		public int RawLength
		{
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000244 RID: 580 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x1700007F")]
		public byte[] RawData
		{
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000245 RID: 581 RVA: 0x000030A8 File Offset: 0x000012A8
		[Token(Token = "0x17000080")]
		public int ClearTextLength
		{
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000246 RID: 582 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x17000081")]
		public byte[] ClearText
		{
			[Token(Token = "0x6000246")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000247 RID: 583 RVA: 0x000030C0 File Offset: 0x000012C0
		// (set) Token: 0x06000248 RID: 584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000082")]
		public int Available
		{
			[Token(Token = "0x6000247")]
			[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x927040", Offset = "0x925C40", VA = "0x180927040")]
			set
			{
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x4A4D5E0", Offset = "0x4A4C1E0", VA = "0x184A4D5E0")]
		public void SetInflaterInput(Inflater inflater)
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x4A4CEE0", Offset = "0x4A4BAE0", VA = "0x184A4CEE0")]
		public void Fill()
		{
		}

		// Token: 0x0600024B RID: 587 RVA: 0x000030D8 File Offset: 0x000012D8
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x4A4D490", Offset = "0x4A4C090", VA = "0x184A4D490")]
		public int ReadRawBuffer(byte[] buffer)
		{
			return 0;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x000030F0 File Offset: 0x000012F0
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x4A4D360", Offset = "0x4A4BF60", VA = "0x184A4D360")]
		public int ReadRawBuffer(byte[] outBuffer, int offset, int length)
		{
			return 0;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00003108 File Offset: 0x00001308
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x4A4D000", Offset = "0x4A4BC00", VA = "0x184A4D000")]
		public int ReadClearTextBuffer(byte[] outBuffer, int offset, int length)
		{
			return 0;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00003120 File Offset: 0x00001320
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x4A4D130", Offset = "0x4A4BD30", VA = "0x184A4D130")]
		public int ReadLeByte()
		{
			return 0;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00003138 File Offset: 0x00001338
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x4A4D330", Offset = "0x4A4BF30", VA = "0x184A4D330")]
		public int ReadLeShort()
		{
			return 0;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00003150 File Offset: 0x00001350
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x4A4D1E0", Offset = "0x4A4BDE0", VA = "0x184A4D1E0")]
		public int ReadLeInt()
		{
			return 0;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00003168 File Offset: 0x00001368
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x4A4D250", Offset = "0x4A4BE50", VA = "0x184A4D250")]
		public long ReadLeLong()
		{
			return 0L;
		}

		// Token: 0x17000083 RID: 131
		// (set) Token: 0x06000252 RID: 594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000083")]
		public ICryptoTransform CryptoTransform
		{
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x4A4D770", Offset = "0x4A4C370", VA = "0x184A4D770")]
			set
			{
			}
		}

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x10")]
		private int rawLength;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x18")]
		private byte[] rawData;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x20")]
		private int clearTextLength;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x28")]
		private byte[] clearText;

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x30")]
		private byte[] internalClearText;

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x38")]
		private int available;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x40")]
		private ICryptoTransform cryptoTransform;

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x48")]
		private Stream inputStream;
	}
}
