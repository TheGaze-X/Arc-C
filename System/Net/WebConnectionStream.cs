using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000346 RID: 838
	[Token(Token = "0x2000346")]
	internal abstract class WebConnectionStream : Stream
	{
		// Token: 0x06001768 RID: 5992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001768")]
		[Address(RVA = "0x5096DD0", Offset = "0x50959D0", VA = "0x185096DD0")]
		protected WebConnectionStream(WebConnection cnc, WebOperation operation)
		{
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06001769 RID: 5993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700051B")]
		internal HttpWebRequest Request
		{
			[Token(Token = "0x6001769")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x0600176A RID: 5994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700051C")]
		internal WebConnection Connection
		{
			[Token(Token = "0x600176A")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x0600176B RID: 5995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700051D")]
		internal WebOperation Operation
		{
			[Token(Token = "0x600176B")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x0600176C RID: 5996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700051E")]
		internal ServicePoint ServicePoint
		{
			[Token(Token = "0x600176C")]
			[Address(RVA = "0x5096F90", Offset = "0x5095B90", VA = "0x185096F90")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x0600176D RID: 5997 RVA: 0x0000AB00 File Offset: 0x00008D00
		[Token(Token = "0x1700051F")]
		public override bool CanTimeout
		{
			[Token(Token = "0x600176D")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x0600176E RID: 5998 RVA: 0x0000AB18 File Offset: 0x00008D18
		// (set) Token: 0x0600176F RID: 5999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000520")]
		public override int ReadTimeout
		{
			[Token(Token = "0x600176E")]
			[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70", Slot = "14")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600176F")]
			[Address(RVA = "0x5097010", Offset = "0x5095C10", VA = "0x185097010", Slot = "15")]
			set
			{
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06001770 RID: 6000 RVA: 0x0000AB30 File Offset: 0x00008D30
		// (set) Token: 0x06001771 RID: 6001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000521")]
		public override int WriteTimeout
		{
			[Token(Token = "0x6001770")]
			[Address(RVA = "0x926F80", Offset = "0x925B80", VA = "0x180926F80", Slot = "16")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001771")]
			[Address(RVA = "0x5097080", Offset = "0x5095C80", VA = "0x185097080", Slot = "17")]
			set
			{
			}
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001772")]
		[Address(RVA = "0x50965A0", Offset = "0x50951A0", VA = "0x1850965A0")]
		protected Exception GetException(Exception e)
		{
			return null;
		}

		// Token: 0x06001773 RID: 6003
		[Token(Token = "0x6001773")]
		protected abstract bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, out int result);

		// Token: 0x06001774 RID: 6004 RVA: 0x0000AB48 File Offset: 0x00008D48
		[Token(Token = "0x6001774")]
		[Address(RVA = "0x50967C0", Offset = "0x50953C0", VA = "0x1850967C0", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001775")]
		[Address(RVA = "0x5095DF0", Offset = "0x50949F0", VA = "0x185095DF0", Slot = "22")]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback cb, object state)
		{
			return null;
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x0000AB60 File Offset: 0x00008D60
		[Token(Token = "0x6001776")]
		[Address(RVA = "0x5096320", Offset = "0x5094F20", VA = "0x185096320", Slot = "23")]
		public override int EndRead(IAsyncResult r)
		{
			return 0;
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001777")]
		[Address(RVA = "0x50960A0", Offset = "0x5094CA0", VA = "0x1850960A0", Slot = "26")]
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback cb, object state)
		{
			return null;
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001778")]
		[Address(RVA = "0x5096400", Offset = "0x5095000", VA = "0x185096400", Slot = "27")]
		public override void EndWrite(IAsyncResult r)
		{
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001779")]
		[Address(RVA = "0x5096B80", Offset = "0x5095780", VA = "0x185096B80", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600177A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600177B")]
		[Address(RVA = "0x50964C0", Offset = "0x50950C0", VA = "0x1850964C0", Slot = "21")]
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600177C")]
		[Address(RVA = "0x50967B0", Offset = "0x50953B0", VA = "0x1850967B0")]
		internal void InternalClose()
		{
		}

		// Token: 0x0600177D RID: 6013
		[Token(Token = "0x600177D")]
		protected abstract void Close_internal(ref bool disposed);

		// Token: 0x0600177E RID: 6014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600177E")]
		[Address(RVA = "0x50962E0", Offset = "0x5094EE0", VA = "0x1850962E0", Slot = "18")]
		public override void Close()
		{
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x0000AB78 File Offset: 0x00008D78
		[Token(Token = "0x600177F")]
		[Address(RVA = "0x5096AC0", Offset = "0x50956C0", VA = "0x185096AC0", Slot = "30")]
		public override long Seek(long a, SeekOrigin b)
		{
			return 0L;
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001780")]
		[Address(RVA = "0x5096B20", Offset = "0x5095720", VA = "0x185096B20", Slot = "31")]
		public override void SetLength(long a)
		{
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06001781 RID: 6017 RVA: 0x0000AB90 File Offset: 0x00008D90
		[Token(Token = "0x17000522")]
		public override bool CanSeek
		{
			[Token(Token = "0x6001781")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06001782 RID: 6018 RVA: 0x0000ABA8 File Offset: 0x00008DA8
		[Token(Token = "0x17000523")]
		public override long Length
		{
			[Token(Token = "0x6001782")]
			[Address(RVA = "0x5096ED0", Offset = "0x5095AD0", VA = "0x185096ED0", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001783 RID: 6019 RVA: 0x0000ABC0 File Offset: 0x00008DC0
		// (set) Token: 0x06001784 RID: 6020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000524")]
		public override long Position
		{
			[Token(Token = "0x6001783")]
			[Address(RVA = "0x5096F30", Offset = "0x5095B30", VA = "0x185096F30", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6001784")]
			[Address(RVA = "0x5096FB0", Offset = "0x5095BB0", VA = "0x185096FB0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x04000D78 RID: 3448
		[Token(Token = "0x4000D78")]
		[FieldOffset(Offset = "0x28")]
		protected bool closed;

		// Token: 0x04000D79 RID: 3449
		[Token(Token = "0x4000D79")]
		[FieldOffset(Offset = "0x29")]
		private bool disposed;

		// Token: 0x04000D7A RID: 3450
		[Token(Token = "0x4000D7A")]
		[FieldOffset(Offset = "0x30")]
		private object locker;

		// Token: 0x04000D7B RID: 3451
		[Token(Token = "0x4000D7B")]
		[FieldOffset(Offset = "0x38")]
		private int read_timeout;

		// Token: 0x04000D7C RID: 3452
		[Token(Token = "0x4000D7C")]
		[FieldOffset(Offset = "0x3C")]
		private int write_timeout;
	}
}
