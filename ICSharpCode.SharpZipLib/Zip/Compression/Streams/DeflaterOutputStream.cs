using System;
using System.IO;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams
{
	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	public class DeflaterOutputStream : Stream
	{
		// Token: 0x06000121 RID: 289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x4A3ABC0", Offset = "0x4A397C0", VA = "0x184A3ABC0")]
		public DeflaterOutputStream(Stream baseOutputStream)
		{
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x4A3A920", Offset = "0x4A39520", VA = "0x184A3A920")]
		public DeflaterOutputStream(Stream baseOutputStream, Deflater deflater)
		{
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x4A3A940", Offset = "0x4A39540", VA = "0x184A3A940")]
		public DeflaterOutputStream(Stream baseOutputStream, Deflater deflater, int bufferSize)
		{
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x4A3A3B0", Offset = "0x4A38FB0", VA = "0x184A3A3B0", Slot = "38")]
		public virtual void Finish()
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00002778 File Offset: 0x00000978
		// (set) Token: 0x06000126 RID: 294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000036")]
		public bool IsStreamOwner
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x2419850", Offset = "0x2418450", VA = "0x182419850")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x2419880", Offset = "0x2418480", VA = "0x182419880")]
			set
			{
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x17000037")]
		public bool CanPatchEntries
		{
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x4A3AC50", Offset = "0x4A39850", VA = "0x184A3AC50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000128 RID: 296 RVA: 0x0000230A File Offset: 0x0000050A
		// (set) Token: 0x06000129 RID: 297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000038")]
		public string Password
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x4A3AD90", Offset = "0x4A39990", VA = "0x184A3AD90")]
			set
			{
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x4A3A2A0", Offset = "0x4A38EA0", VA = "0x184A3A2A0")]
		protected void EncryptBlock(byte[] buffer, int offset, int length)
		{
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x4A3A5D0", Offset = "0x4A391D0", VA = "0x184A3A5D0")]
		protected void InitializePassword(string password)
		{
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x4A3A170", Offset = "0x4A38D70", VA = "0x184A3A170")]
		protected void Deflate()
		{
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600012D RID: 301 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x17000039")]
		public override bool CanRead
		{
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600012E RID: 302 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x1700003A")]
		public override bool CanSeek
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600012F RID: 303 RVA: 0x000027D8 File Offset: 0x000009D8
		[Token(Token = "0x1700003B")]
		public override bool CanWrite
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x4A3ACA0", Offset = "0x4A398A0", VA = "0x184A3ACA0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000130 RID: 304 RVA: 0x000027F0 File Offset: 0x000009F0
		[Token(Token = "0x1700003C")]
		public override long Length
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x4A3ACF0", Offset = "0x4A398F0", VA = "0x184A3ACF0", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00002808 File Offset: 0x00000A08
		// (set) Token: 0x06000132 RID: 306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003D")]
		public override long Position
		{
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x4A3AD40", Offset = "0x4A39940", VA = "0x184A3AD40", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x4A3ADC0", Offset = "0x4A399C0", VA = "0x184A3ADC0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00002820 File Offset: 0x00000A20
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x4A3A770", Offset = "0x4A39370", VA = "0x184A3A770", Slot = "30")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x4A3A7D0", Offset = "0x4A393D0", VA = "0x184A3A7D0", Slot = "31")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x4A3A6B0", Offset = "0x4A392B0", VA = "0x184A3A6B0", Slot = "34")]
		public override int ReadByte()
		{
			return 0;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002850 File Offset: 0x00000A50
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x4A3A710", Offset = "0x4A39310", VA = "0x184A3A710", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x4A39F60", Offset = "0x4A38B60", VA = "0x184A39F60", Slot = "22")]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x4A39FC0", Offset = "0x4A38BC0", VA = "0x184A39FC0", Slot = "26")]
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x4A3A570", Offset = "0x4A39170", VA = "0x184A3A570", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x4A3A020", Offset = "0x4A38C20", VA = "0x184A3A020", Slot = "18")]
		public override void Close()
		{
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void GetAuthCodeIfAES()
		{
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x4A3A830", Offset = "0x4A39430", VA = "0x184A3A830", Slot = "37")]
		public override void WriteByte(byte value)
		{
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x4A3A8E0", Offset = "0x4A394E0", VA = "0x184A3A8E0", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x28")]
		private string password;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x30")]
		private ICryptoTransform cryptoTransform_;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x38")]
		protected byte[] AESAuthCode;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x40")]
		private byte[] buffer_;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x48")]
		protected Deflater deflater_;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x50")]
		protected Stream baseOutputStream_;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x58")]
		private bool isClosed_;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x59")]
		private bool isStreamOwner_;
	}
}
