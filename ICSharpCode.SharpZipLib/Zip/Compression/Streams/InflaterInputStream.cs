using System;
using System.IO;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	public class InflaterInputStream : Stream
	{
		// Token: 0x06000105 RID: 261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x4A3DD00", Offset = "0x4A3C900", VA = "0x184A3DD00")]
		public InflaterInputStream(Stream baseInputStream)
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x4A3DE60", Offset = "0x4A3CA60", VA = "0x184A3DE60")]
		public InflaterInputStream(Stream baseInputStream, Inflater inf)
		{
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x4A3DFF0", Offset = "0x4A3CBF0", VA = "0x184A3DFF0")]
		public InflaterInputStream(Stream baseInputStream, Inflater inflater, int bufferSize)
		{
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00002658 File Offset: 0x00000858
		// (set) Token: 0x06000109 RID: 265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002F")]
		public bool IsStreamOwner
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x2033940", Offset = "0x2032540", VA = "0x182033940")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x20339F0", Offset = "0x20325F0", VA = "0x1820339F0")]
			set
			{
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x4A3DA70", Offset = "0x4A3C670", VA = "0x184A3DA70")]
		public long Skip(long count)
		{
			return 0L;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x4A3DC10", Offset = "0x4A3C810", VA = "0x184A3DC10")]
		protected void StopDecrypting()
		{
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x17000030")]
		public virtual int Available
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x4A3E1E0", Offset = "0x4A3CDE0", VA = "0x184A3E1E0", Slot = "38")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x4A3D6A0", Offset = "0x4A3C2A0", VA = "0x184A3D6A0")]
		protected void Fill()
		{
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600010E RID: 270 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x17000031")]
		public override bool CanRead
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x4A3E210", Offset = "0x4A3CE10", VA = "0x184A3E210", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600010F RID: 271 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x17000032")]
		public override bool CanSeek
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000110 RID: 272 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x17000033")]
		public override bool CanWrite
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000111 RID: 273 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x17000034")]
		public override long Length
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x4A3E260", Offset = "0x4A3CE60", VA = "0x184A3E260", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00002700 File Offset: 0x00000900
		// (set) Token: 0x06000113 RID: 275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000035")]
		public override long Position
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x4A3E280", Offset = "0x4A3CE80", VA = "0x184A3E280", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x4A3E2D0", Offset = "0x4A3CED0", VA = "0x184A3E2D0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x4A3D740", Offset = "0x4A3C340", VA = "0x184A3D740", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x4A3D9B0", Offset = "0x4A3C5B0", VA = "0x184A3D9B0", Slot = "30")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x4A3DA10", Offset = "0x4A3C610", VA = "0x184A3DA10", Slot = "31")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x4A3DCA0", Offset = "0x4A3C8A0", VA = "0x184A3DCA0", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x4A3DC40", Offset = "0x4A3C840", VA = "0x184A3DC40", Slot = "37")]
		public override void WriteByte(byte value)
		{
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x4A3D5E0", Offset = "0x4A3C1E0", VA = "0x184A3D5E0", Slot = "26")]
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x4A3D640", Offset = "0x4A3C240", VA = "0x184A3D640", Slot = "18")]
		public override void Close()
		{
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x4A3D780", Offset = "0x4A3C380", VA = "0x184A3D780", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x28")]
		protected Inflater inf;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x30")]
		protected InflaterInputBuffer inputBuffer;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x38")]
		private Stream baseInputStream;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x40")]
		protected long csize;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x48")]
		private bool isClosed;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x49")]
		private bool isStreamOwner;
	}
}
